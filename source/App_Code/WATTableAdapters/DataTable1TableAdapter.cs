using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Configuration;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace WATTableAdapters;

[DesignerCategory("code")]
[DataObject(true)]
[Designer("Microsoft.VSDesigner.DataSource.Design.TableAdapterDesigner, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
[ToolboxItem(true)]
[HelpKeyword("vs.data.TableAdapter")]
public class DataTable1TableAdapter : Component
{
	[AccessedThroughProperty("_adapter")]
	private SqlDataAdapter __adapter;

	private SqlConnection _connection;

	private SqlCommand[] _commandCollection;

	private bool _clearBeforeFill;

	protected virtual SqlDataAdapter _adapter
	{
		get
		{
			return __adapter;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			__adapter = value;
		}
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	[DebuggerNonUserCode]
	private SqlDataAdapter Adapter
	{
		get
		{
			if (_adapter == null)
			{
				InitAdapter();
			}
			return _adapter;
		}
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	[DebuggerNonUserCode]
	internal SqlConnection Connection
	{
		get
		{
			if (_connection == null)
			{
				InitConnection();
			}
			return _connection;
		}
		set
		{
			_connection = value;
			if (Adapter.InsertCommand != null)
			{
				Adapter.InsertCommand.Connection = value;
			}
			if (Adapter.DeleteCommand != null)
			{
				Adapter.DeleteCommand.Connection = value;
			}
			if (Adapter.UpdateCommand != null)
			{
				Adapter.UpdateCommand.Connection = value;
			}
			for (int i = 0; i < CommandCollection.Length; i = checked(i + 1))
			{
				if (CommandCollection[i] != null)
				{
					CommandCollection[i].Connection = value;
				}
			}
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	protected SqlCommand[] CommandCollection
	{
		get
		{
			if (_commandCollection == null)
			{
				InitCommandCollection();
			}
			return _commandCollection;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	public bool ClearBeforeFill
	{
		get
		{
			return _clearBeforeFill;
		}
		set
		{
			_clearBeforeFill = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	public DataTable1TableAdapter()
	{
		ClearBeforeFill = true;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	private void InitAdapter()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected Obj, but got Unknown
		_adapter = new SqlDataAdapter();
		DataTableMapping dataTableMapping = new DataTableMapping();
		dataTableMapping.SourceTable = "Table";
		dataTableMapping.DataSetTable = "DataTable1";
		dataTableMapping.ColumnMappings.Add("word_nm", "word_nm");
		dataTableMapping.ColumnMappings.Add("choice_word_id", "choice_word_id");
		dataTableMapping.ColumnMappings.Add("choice_word_nm", "choice_word_nm");
		((DataAdapter)(object)_adapter).TableMappings.Add(dataTableMapping);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	private void InitConnection()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected Obj, but got Unknown
		_connection = new SqlConnection();
		_connection.ConnectionString = ConfigurationManager.ConnectionStrings["nazdiltarinConnectionString"].ConnectionString;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	private void InitCommandCollection()
	{
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected Obj, but got Unknown
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_0059: Expected Obj, but got Unknown
		//IL_00be: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c8: Expected Obj, but got Unknown
		//IL_00d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d6: Expected Obj, but got Unknown
		//IL_013b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0145: Expected Obj, but got Unknown
		_commandCollection = new SqlCommand[3];
		_commandCollection[0] = new SqlCommand();
		_commandCollection[0].Connection = Connection;
		_commandCollection[0].CommandText = "SELECT     mainWord.word_nm, choiceWord.choice_word_id, choiceWord.choice_word_nm\r\nFROM         choiceWord INNER JOIN\r\n                      mainWord ON choiceWord.word_id = mainWord.word_id";
		_commandCollection[0].CommandType = CommandType.Text;
		_commandCollection[1] = new SqlCommand();
		_commandCollection[1].Connection = Connection;
		_commandCollection[1].CommandText = "SELECT     mainWord.word_nm, choiceWord.choice_word_id, choiceWord.choice_word_nm\r\nFROM         choiceWord LEFT OUTER JOIN\r\n                      mainWord ON choiceWord.word_id = mainWord.word_id\r\nWHERE     (mainWord.word_id = @wid)";
		_commandCollection[1].CommandType = CommandType.Text;
		_commandCollection[1].Parameters.Add(new SqlParameter("@wid", SqlDbType.Int, 4, ParameterDirection.Input, (byte)0, (byte)0, "word_id", DataRowVersion.Current, false, (object)null, "", "", ""));
		_commandCollection[2] = new SqlCommand();
		_commandCollection[2].Connection = Connection;
		_commandCollection[2].CommandText = "SELECT     SUM(choiceWord.Score) AS Expr1\r\nFROM         testWordInstance INNER JOIN\r\n                      choiceWord ON testWordInstance.main_word_id = choiceWord.word_id AND testWordInstance.answerd_word_id = choiceWord.choice_word_id\r\nWHERE     (testWordInstance.test_instance_id = @testid)";
		_commandCollection[2].CommandType = CommandType.Text;
		_commandCollection[2].Parameters.Add(new SqlParameter("@testid", SqlDbType.Int, 4, ParameterDirection.Input, (byte)0, (byte)0, "test_instance_id", DataRowVersion.Current, false, (object)null, "", "", ""));
	}

	[DataObjectMethod(DataObjectMethodType.Fill, true)]
	[HelpKeyword("vs.data.TableAdapter")]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	[DebuggerNonUserCode]
	public virtual int Fill(WAT.DataTable1DataTable dataTable)
	{
		Adapter.SelectCommand = CommandCollection[0];
		if (ClearBeforeFill)
		{
			dataTable.Clear();
		}
		return ((DbDataAdapter)(object)Adapter).Fill((DataTable)dataTable);
	}

	[HelpKeyword("vs.data.TableAdapter")]
	[DataObjectMethod(DataObjectMethodType.Select, true)]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	[DebuggerNonUserCode]
	public virtual WAT.DataTable1DataTable GetData()
	{
		Adapter.SelectCommand = CommandCollection[0];
		WAT.DataTable1DataTable dataTable1DataTable = new WAT.DataTable1DataTable();
		((DbDataAdapter)(object)Adapter).Fill((DataTable)dataTable1DataTable);
		return dataTable1DataTable;
	}

	[DataObjectMethod(DataObjectMethodType.Fill, false)]
	[DebuggerNonUserCode]
	[HelpKeyword("vs.data.TableAdapter")]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	public virtual int FillById(WAT.DataTable1DataTable dataTable, int wid)
	{
		Adapter.SelectCommand = CommandCollection[1];
		Adapter.SelectCommand.Parameters[0].Value = wid;
		if (ClearBeforeFill)
		{
			dataTable.Clear();
		}
		return ((DbDataAdapter)(object)Adapter).Fill((DataTable)dataTable);
	}

	[DebuggerNonUserCode]
	[DataObjectMethod(DataObjectMethodType.Select, false)]
	[HelpKeyword("vs.data.TableAdapter")]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	public virtual WAT.DataTable1DataTable GetDataById(int wid)
	{
		Adapter.SelectCommand = CommandCollection[1];
		Adapter.SelectCommand.Parameters[0].Value = wid;
		WAT.DataTable1DataTable dataTable1DataTable = new WAT.DataTable1DataTable();
		((DbDataAdapter)(object)Adapter).Fill((DataTable)dataTable1DataTable);
		return dataTable1DataTable;
	}

	[HelpKeyword("vs.data.TableAdapter")]
	[DebuggerNonUserCode]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	public virtual object getscore(int? testid)
	{
		SqlCommand val = CommandCollection[2];
		if (testid.HasValue)
		{
			val.Parameters[0].Value = testid.Value;
		}
		else
		{
			val.Parameters[0].Value = DBNull.Value;
		}
		ConnectionState state = val.Connection.State;
		if ((val.Connection.State & ConnectionState.Open) != ConnectionState.Open)
		{
			val.Connection.Open();
		}
		object objectValue;
		try
		{
			objectValue = RuntimeHelpers.GetObjectValue(val.ExecuteScalar());
		}
		finally
		{
			if (state == ConnectionState.Closed)
			{
				val.Connection.Close();
			}
		}
		if (objectValue == null || (object)objectValue.GetType() == typeof(DBNull))
		{
			return null;
		}
		return objectValue;
	}
}
