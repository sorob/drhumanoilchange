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

[Designer("Microsoft.VSDesigner.DataSource.Design.TableAdapterDesigner, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
[DataObject(true)]
[ToolboxItem(true)]
[DesignerCategory("code")]
[HelpKeyword("vs.data.TableAdapter")]
public class testWordInstanceTableAdapter : Component
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

	[DebuggerNonUserCode]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
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

	[DebuggerNonUserCode]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
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
	public testWordInstanceTableAdapter()
	{
		ClearBeforeFill = true;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	private void InitAdapter()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected Obj, but got Unknown
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a1: Expected Obj, but got Unknown
		//IL_0112: Unknown result type (might be due to invalid IL or missing references)
		//IL_011c: Expected Obj, but got Unknown
		//IL_0152: Unknown result type (might be due to invalid IL or missing references)
		//IL_015c: Expected Obj, but got Unknown
		//IL_0192: Unknown result type (might be due to invalid IL or missing references)
		//IL_019c: Expected Obj, but got Unknown
		//IL_01d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01dd: Expected Obj, but got Unknown
		_adapter = new SqlDataAdapter();
		DataTableMapping dataTableMapping = new DataTableMapping();
		dataTableMapping.SourceTable = "Table";
		dataTableMapping.DataSetTable = "testWordInstance";
		dataTableMapping.ColumnMappings.Add("test_instance_id", "test_instance_id");
		dataTableMapping.ColumnMappings.Add("main_word_id", "main_word_id");
		dataTableMapping.ColumnMappings.Add("answerd_word_id", "answerd_word_id");
		dataTableMapping.ColumnMappings.Add("time", "time");
		((DataAdapter)(object)_adapter).TableMappings.Add(dataTableMapping);
		_adapter.InsertCommand = new SqlCommand();
		_adapter.InsertCommand.Connection = Connection;
		_adapter.InsertCommand.CommandText = "INSERT INTO [testWordInstance] ([test_instance_id], [main_word_id], [answerd_word_id], [time]) VALUES (@test_instance_id, @main_word_id, @answerd_word_id, @time)";
		_adapter.InsertCommand.CommandType = CommandType.Text;
		_adapter.InsertCommand.Parameters.Add(new SqlParameter("@test_instance_id", SqlDbType.Int, 0, ParameterDirection.Input, (byte)0, (byte)0, "test_instance_id", DataRowVersion.Current, false, (object)null, "", "", ""));
		_adapter.InsertCommand.Parameters.Add(new SqlParameter("@main_word_id", SqlDbType.Int, 0, ParameterDirection.Input, (byte)0, (byte)0, "main_word_id", DataRowVersion.Current, false, (object)null, "", "", ""));
		_adapter.InsertCommand.Parameters.Add(new SqlParameter("@answerd_word_id", SqlDbType.Int, 0, ParameterDirection.Input, (byte)0, (byte)0, "answerd_word_id", DataRowVersion.Current, false, (object)null, "", "", ""));
		_adapter.InsertCommand.Parameters.Add(new SqlParameter("@time", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte)0, (byte)0, "time", DataRowVersion.Current, false, (object)null, "", "", ""));
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	[DebuggerNonUserCode]
	private void InitConnection()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected Obj, but got Unknown
		_connection = new SqlConnection();
		_connection.ConnectionString = ConfigurationManager.ConnectionStrings["nazdiltarinConnectionString"].ConnectionString;
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	[DebuggerNonUserCode]
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
		//IL_0178: Unknown result type (might be due to invalid IL or missing references)
		//IL_0182: Expected Obj, but got Unknown
		//IL_01b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bf: Expected Obj, but got Unknown
		//IL_01f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fe: Expected Obj, but got Unknown
		//IL_0206: Unknown result type (might be due to invalid IL or missing references)
		//IL_020c: Expected Obj, but got Unknown
		//IL_0271: Unknown result type (might be due to invalid IL or missing references)
		//IL_027b: Expected Obj, but got Unknown
		//IL_02ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b8: Expected Obj, but got Unknown
		//IL_02eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f5: Expected Obj, but got Unknown
		_commandCollection = new SqlCommand[4];
		_commandCollection[0] = new SqlCommand();
		_commandCollection[0].Connection = Connection;
		_commandCollection[0].CommandText = "SELECT     testWordInstance.*\r\nFROM         testWordInstance";
		_commandCollection[0].CommandType = CommandType.Text;
		_commandCollection[1] = new SqlCommand();
		_commandCollection[1].Connection = Connection;
		_commandCollection[1].CommandText = "SELECT     main_word_id\r\nFROM         testWordInstance\r\nWHERE     (test_instance_id = @tid)";
		_commandCollection[1].CommandType = CommandType.Text;
		_commandCollection[1].Parameters.Add(new SqlParameter("@tid", SqlDbType.Int, 4, ParameterDirection.Input, (byte)0, (byte)0, "test_instance_id", DataRowVersion.Current, false, (object)null, "", "", ""));
		_commandCollection[2] = new SqlCommand();
		_commandCollection[2].Connection = Connection;
		_commandCollection[2].CommandText = "INSERT INTO [testWordInstance] ([test_instance_id], [main_word_id], [answerd_word_id], [time]) VALUES (@test_instance_id, @main_word_id, @answerd_word_id, @time)";
		_commandCollection[2].CommandType = CommandType.Text;
		_commandCollection[2].Parameters.Add(new SqlParameter("@test_instance_id", SqlDbType.Int, 4, ParameterDirection.Input, (byte)0, (byte)0, "test_instance_id", DataRowVersion.Current, false, (object)null, "", "", ""));
		_commandCollection[2].Parameters.Add(new SqlParameter("@main_word_id", SqlDbType.Int, 4, ParameterDirection.Input, (byte)0, (byte)0, "main_word_id", DataRowVersion.Current, false, (object)null, "", "", ""));
		_commandCollection[2].Parameters.Add(new SqlParameter("@answerd_word_id", SqlDbType.Int, 4, ParameterDirection.Input, (byte)0, (byte)0, "answerd_word_id", DataRowVersion.Current, false, (object)null, "", "", ""));
		_commandCollection[2].Parameters.Add(new SqlParameter("@time", SqlDbType.NVarChar, 50, ParameterDirection.Input, (byte)0, (byte)0, "time", DataRowVersion.Current, false, (object)null, "", "", ""));
		_commandCollection[3] = new SqlCommand();
		_commandCollection[3].Connection = Connection;
		_commandCollection[3].CommandText = "UPDATE    testWordInstance\r\nSET              answerd_word_id = @choise\r\nWHERE     (test_instance_id = @tid) AND (main_word_id = @wid)";
		_commandCollection[3].CommandType = CommandType.Text;
		_commandCollection[3].Parameters.Add(new SqlParameter("@choise", SqlDbType.Int, 4, ParameterDirection.Input, (byte)0, (byte)0, "answerd_word_id", DataRowVersion.Current, false, (object)null, "", "", ""));
		_commandCollection[3].Parameters.Add(new SqlParameter("@tid", SqlDbType.Int, 4, ParameterDirection.Input, (byte)0, (byte)0, "test_instance_id", DataRowVersion.Original, false, (object)null, "", "", ""));
		_commandCollection[3].Parameters.Add(new SqlParameter("@wid", SqlDbType.Int, 4, ParameterDirection.Input, (byte)0, (byte)0, "main_word_id", DataRowVersion.Original, false, (object)null, "", "", ""));
	}

	[DataObjectMethod(DataObjectMethodType.Fill, true)]
	[HelpKeyword("vs.data.TableAdapter")]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	[DebuggerNonUserCode]
	public virtual int Fill(WAT.testWordInstanceDataTable dataTable)
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
	public virtual WAT.testWordInstanceDataTable GetData()
	{
		Adapter.SelectCommand = CommandCollection[0];
		WAT.testWordInstanceDataTable testWordInstanceDataTable = new WAT.testWordInstanceDataTable();
		((DbDataAdapter)(object)Adapter).Fill((DataTable)testWordInstanceDataTable);
		return testWordInstanceDataTable;
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	[DebuggerNonUserCode]
	[DataObjectMethod(DataObjectMethodType.Fill, false)]
	[HelpKeyword("vs.data.TableAdapter")]
	public virtual int FillBywid(WAT.testWordInstanceDataTable dataTable, int? tid)
	{
		Adapter.SelectCommand = CommandCollection[1];
		if (tid.HasValue)
		{
			Adapter.SelectCommand.Parameters[0].Value = tid.Value;
		}
		else
		{
			Adapter.SelectCommand.Parameters[0].Value = DBNull.Value;
		}
		if (ClearBeforeFill)
		{
			dataTable.Clear();
		}
		return ((DbDataAdapter)(object)Adapter).Fill((DataTable)dataTable);
	}

	[DataObjectMethod(DataObjectMethodType.Select, false)]
	[HelpKeyword("vs.data.TableAdapter")]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	[DebuggerNonUserCode]
	public virtual WAT.testWordInstanceDataTable GetDataBywid(int? tid)
	{
		Adapter.SelectCommand = CommandCollection[1];
		if (tid.HasValue)
		{
			Adapter.SelectCommand.Parameters[0].Value = tid.Value;
		}
		else
		{
			Adapter.SelectCommand.Parameters[0].Value = DBNull.Value;
		}
		WAT.testWordInstanceDataTable testWordInstanceDataTable = new WAT.testWordInstanceDataTable();
		((DbDataAdapter)(object)Adapter).Fill((DataTable)testWordInstanceDataTable);
		return testWordInstanceDataTable;
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	[HelpKeyword("vs.data.TableAdapter")]
	[DebuggerNonUserCode]
	public virtual int Update(WAT.testWordInstanceDataTable dataTable)
	{
		return ((DbDataAdapter)(object)Adapter).Update((DataTable)dataTable);
	}

	[HelpKeyword("vs.data.TableAdapter")]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	[DebuggerNonUserCode]
	public virtual int Update(WAT dataSet)
	{
		return ((DbDataAdapter)(object)Adapter).Update((DataSet)dataSet, "testWordInstance");
	}

	[DebuggerNonUserCode]
	[HelpKeyword("vs.data.TableAdapter")]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	public virtual int Update(DataRow dataRow)
	{
		return ((DbDataAdapter)(object)Adapter).Update(new DataRow[1] { dataRow });
	}

	[DebuggerNonUserCode]
	[HelpKeyword("vs.data.TableAdapter")]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	public virtual int Update(DataRow[] dataRows)
	{
		return ((DbDataAdapter)(object)Adapter).Update(dataRows);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	[DataObjectMethod(DataObjectMethodType.Insert, true)]
	[HelpKeyword("vs.data.TableAdapter")]
	public virtual int Insert(int? test_instance_id, int? main_word_id, int? answerd_word_id, string time)
	{
		if (test_instance_id.HasValue)
		{
			Adapter.InsertCommand.Parameters[0].Value = test_instance_id.Value;
		}
		else
		{
			Adapter.InsertCommand.Parameters[0].Value = DBNull.Value;
		}
		if (main_word_id.HasValue)
		{
			Adapter.InsertCommand.Parameters[1].Value = main_word_id.Value;
		}
		else
		{
			Adapter.InsertCommand.Parameters[1].Value = DBNull.Value;
		}
		if (answerd_word_id.HasValue)
		{
			Adapter.InsertCommand.Parameters[2].Value = answerd_word_id.Value;
		}
		else
		{
			Adapter.InsertCommand.Parameters[2].Value = DBNull.Value;
		}
		if (time == null)
		{
			Adapter.InsertCommand.Parameters[3].Value = DBNull.Value;
		}
		else
		{
			Adapter.InsertCommand.Parameters[3].Value = time;
		}
		ConnectionState state = Adapter.InsertCommand.Connection.State;
		if ((Adapter.InsertCommand.Connection.State & ConnectionState.Open) != ConnectionState.Open)
		{
			Adapter.InsertCommand.Connection.Open();
		}
		try
		{
			return Adapter.InsertCommand.ExecuteNonQuery();
		}
		finally
		{
			if (state == ConnectionState.Closed)
			{
				Adapter.InsertCommand.Connection.Close();
			}
		}
	}

	[DebuggerNonUserCode]
	[DataObjectMethod(DataObjectMethodType.Insert, false)]
	[HelpKeyword("vs.data.TableAdapter")]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	public virtual int InsertQuery(int? test_instance_id, int? main_word_id, int? answerd_word_id, string time)
	{
		SqlCommand val = CommandCollection[2];
		if (test_instance_id.HasValue)
		{
			val.Parameters[0].Value = test_instance_id.Value;
		}
		else
		{
			val.Parameters[0].Value = DBNull.Value;
		}
		if (main_word_id.HasValue)
		{
			val.Parameters[1].Value = main_word_id.Value;
		}
		else
		{
			val.Parameters[1].Value = DBNull.Value;
		}
		if (answerd_word_id.HasValue)
		{
			val.Parameters[2].Value = answerd_word_id.Value;
		}
		else
		{
			val.Parameters[2].Value = DBNull.Value;
		}
		if (time == null)
		{
			val.Parameters[3].Value = DBNull.Value;
		}
		else
		{
			val.Parameters[3].Value = time;
		}
		ConnectionState state = val.Connection.State;
		if ((val.Connection.State & ConnectionState.Open) != ConnectionState.Open)
		{
			val.Connection.Open();
		}
		try
		{
			return val.ExecuteNonQuery();
		}
		finally
		{
			if (state == ConnectionState.Closed)
			{
				val.Connection.Close();
			}
		}
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	[DebuggerNonUserCode]
	[DataObjectMethod(DataObjectMethodType.Update, false)]
	[HelpKeyword("vs.data.TableAdapter")]
	public virtual int Updateanswer(int? choise, int? tid, int? wid)
	{
		SqlCommand val = CommandCollection[3];
		if (choise.HasValue)
		{
			val.Parameters[0].Value = choise.Value;
		}
		else
		{
			val.Parameters[0].Value = DBNull.Value;
		}
		if (tid.HasValue)
		{
			val.Parameters[1].Value = tid.Value;
		}
		else
		{
			val.Parameters[1].Value = DBNull.Value;
		}
		if (wid.HasValue)
		{
			val.Parameters[2].Value = wid.Value;
		}
		else
		{
			val.Parameters[2].Value = DBNull.Value;
		}
		ConnectionState state = val.Connection.State;
		if ((val.Connection.State & ConnectionState.Open) != ConnectionState.Open)
		{
			val.Connection.Open();
		}
		try
		{
			return val.ExecuteNonQuery();
		}
		finally
		{
			if (state == ConnectionState.Closed)
			{
				val.Connection.Close();
			}
		}
	}
}
