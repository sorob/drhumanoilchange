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

namespace storeprociduresdsTableAdapters;

[Designer("Microsoft.VSDesigner.DataSource.Design.TableAdapterDesigner, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
[DataObject(true)]
[ToolboxItem(true)]
[DesignerCategory("code")]
[HelpKeyword("vs.data.TableAdapter")]
public class view3TableAdapter : Component
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

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	[DebuggerNonUserCode]
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

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	[DebuggerNonUserCode]
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
	public view3TableAdapter()
	{
		ClearBeforeFill = true;
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	[DebuggerNonUserCode]
	private void InitAdapter()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected Obj, but got Unknown
		_adapter = new SqlDataAdapter();
		DataTableMapping dataTableMapping = new DataTableMapping();
		dataTableMapping.SourceTable = "Table";
		dataTableMapping.DataSetTable = "view3";
		dataTableMapping.ColumnMappings.Add("R1", "R1");
		dataTableMapping.ColumnMappings.Add("R2", "R2");
		dataTableMapping.ColumnMappings.Add("MS1", "MS1");
		dataTableMapping.ColumnMappings.Add("DS1", "DS1");
		dataTableMapping.ColumnMappings.Add("DocLow", "DocLow");
		dataTableMapping.ColumnMappings.Add("DocHigh", "DocHigh");
		dataTableMapping.ColumnMappings.Add("DocOpt", "DocOpt");
		dataTableMapping.ColumnMappings.Add("MedLow", "MedLow");
		dataTableMapping.ColumnMappings.Add("MedHigh", "MedHigh");
		dataTableMapping.ColumnMappings.Add("Medopt", "Medopt");
		dataTableMapping.ColumnMappings.Add("Category", "Category");
		dataTableMapping.ColumnMappings.Add("testName", "testName");
		dataTableMapping.ColumnMappings.Add("testAbrev", "testAbrev");
		dataTableMapping.ColumnMappings.Add("MS2", "MS2");
		dataTableMapping.ColumnMappings.Add("DS2", "DS2");
		dataTableMapping.ColumnMappings.Add("inf", "inf");
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

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	[DebuggerNonUserCode]
	private void InitCommandCollection()
	{
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected Obj, but got Unknown
		//IL_007b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0085: Expected Obj, but got Unknown
		//IL_00b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bf: Expected Obj, but got Unknown
		//IL_00ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f9: Expected Obj, but got Unknown
		_commandCollection = new SqlCommand[1];
		_commandCollection[0] = new SqlCommand();
		_commandCollection[0].Connection = Connection;
		_commandCollection[0].CommandText = "dbo.view3";
		_commandCollection[0].CommandType = CommandType.StoredProcedure;
		_commandCollection[0].Parameters.Add(new SqlParameter("@RETURN_VALUE", SqlDbType.Int, 4, ParameterDirection.ReturnValue, (byte)10, (byte)0, (string)null, DataRowVersion.Current, false, (object)null, "", "", ""));
		_commandCollection[0].Parameters.Add(new SqlParameter("@t1", SqlDbType.Int, 4, ParameterDirection.Input, (byte)10, (byte)0, (string)null, DataRowVersion.Current, false, (object)null, "", "", ""));
		_commandCollection[0].Parameters.Add(new SqlParameter("@t2", SqlDbType.Int, 4, ParameterDirection.Input, (byte)10, (byte)0, (string)null, DataRowVersion.Current, false, (object)null, "", "", ""));
	}

	[DataObjectMethod(DataObjectMethodType.Fill, true)]
	[DebuggerNonUserCode]
	[HelpKeyword("vs.data.TableAdapter")]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	public virtual int Fill(storeprociduresds.view3DataTable dataTable, int? t1, int? t2)
	{
		Adapter.SelectCommand = CommandCollection[0];
		if (t1.HasValue)
		{
			Adapter.SelectCommand.Parameters[1].Value = t1.Value;
		}
		else
		{
			Adapter.SelectCommand.Parameters[1].Value = DBNull.Value;
		}
		if (t2.HasValue)
		{
			Adapter.SelectCommand.Parameters[2].Value = t2.Value;
		}
		else
		{
			Adapter.SelectCommand.Parameters[2].Value = DBNull.Value;
		}
		if (ClearBeforeFill)
		{
			dataTable.Clear();
		}
		return ((DbDataAdapter)(object)Adapter).Fill((DataTable)dataTable);
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	[DataObjectMethod(DataObjectMethodType.Select, true)]
	[HelpKeyword("vs.data.TableAdapter")]
	[DebuggerNonUserCode]
	public virtual storeprociduresds.view3DataTable GetData(int? t1, int? t2)
	{
		Adapter.SelectCommand = CommandCollection[0];
		if (t1.HasValue)
		{
			Adapter.SelectCommand.Parameters[1].Value = t1.Value;
		}
		else
		{
			Adapter.SelectCommand.Parameters[1].Value = DBNull.Value;
		}
		if (t2.HasValue)
		{
			Adapter.SelectCommand.Parameters[2].Value = t2.Value;
		}
		else
		{
			Adapter.SelectCommand.Parameters[2].Value = DBNull.Value;
		}
		storeprociduresds.view3DataTable view3DataTable = new storeprociduresds.view3DataTable();
		((DbDataAdapter)(object)Adapter).Fill((DataTable)view3DataTable);
		return view3DataTable;
	}
}
