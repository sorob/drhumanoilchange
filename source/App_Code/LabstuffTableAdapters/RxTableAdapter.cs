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

namespace LabstuffTableAdapters;

[DataObject(true)]
[HelpKeyword("vs.data.TableAdapter")]
[Designer("Microsoft.VSDesigner.DataSource.Design.TableAdapterDesigner, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
[DesignerCategory("code")]
[ToolboxItem(true)]
public class RxTableAdapter : Component
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

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	[DebuggerNonUserCode]
	public RxTableAdapter()
	{
		ClearBeforeFill = true;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	private void InitAdapter()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected Obj, but got Unknown
		//IL_00c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cd: Expected Obj, but got Unknown
		//IL_013e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0148: Expected Obj, but got Unknown
		//IL_017f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0189: Expected Obj, but got Unknown
		//IL_01c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ca: Expected Obj, but got Unknown
		//IL_0201: Unknown result type (might be due to invalid IL or missing references)
		//IL_020b: Expected Obj, but got Unknown
		//IL_0241: Unknown result type (might be due to invalid IL or missing references)
		//IL_024b: Expected Obj, but got Unknown
		//IL_0282: Unknown result type (might be due to invalid IL or missing references)
		//IL_028c: Expected Obj, but got Unknown
		_adapter = new SqlDataAdapter();
		DataTableMapping dataTableMapping = new DataTableMapping();
		dataTableMapping.SourceTable = "Table";
		dataTableMapping.DataSetTable = "Rx";
		dataTableMapping.ColumnMappings.Add("Prod-ID", "Prod-ID");
		dataTableMapping.ColumnMappings.Add("Product", "Product");
		dataTableMapping.ColumnMappings.Add("Dosage", "Dosage");
		dataTableMapping.ColumnMappings.Add("Co", "Co");
		dataTableMapping.ColumnMappings.Add("Order", "Order");
		dataTableMapping.ColumnMappings.Add("Body_Part", "Body_Part");
		((DataAdapter)(object)_adapter).TableMappings.Add(dataTableMapping);
		_adapter.InsertCommand = new SqlCommand();
		_adapter.InsertCommand.Connection = Connection;
		_adapter.InsertCommand.CommandText = "INSERT INTO [Rx] ([Prod-ID], [Product], [Dosage], [Co], [Order], [Body_Part]) VALUES (@p1, @Product, @Dosage, @Co, @Order, @Body_Part)";
		_adapter.InsertCommand.CommandType = CommandType.Text;
		_adapter.InsertCommand.Parameters.Add(new SqlParameter("@p1", SqlDbType.Float, 0, ParameterDirection.Input, (byte)0, (byte)0, "Prod-ID", DataRowVersion.Current, false, (object)null, "", "", ""));
		_adapter.InsertCommand.Parameters.Add(new SqlParameter("@Product", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte)0, (byte)0, "Product", DataRowVersion.Current, false, (object)null, "", "", ""));
		_adapter.InsertCommand.Parameters.Add(new SqlParameter("@Dosage", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte)0, (byte)0, "Dosage", DataRowVersion.Current, false, (object)null, "", "", ""));
		_adapter.InsertCommand.Parameters.Add(new SqlParameter("@Co", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte)0, (byte)0, "Co", DataRowVersion.Current, false, (object)null, "", "", ""));
		_adapter.InsertCommand.Parameters.Add(new SqlParameter("@Order", SqlDbType.Float, 0, ParameterDirection.Input, (byte)0, (byte)0, "Order", DataRowVersion.Current, false, (object)null, "", "", ""));
		_adapter.InsertCommand.Parameters.Add(new SqlParameter("@Body_Part", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte)0, (byte)0, "Body_Part", DataRowVersion.Current, false, (object)null, "", "", ""));
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

	[DebuggerNonUserCode]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	private void InitCommandCollection()
	{
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected Obj, but got Unknown
		//IL_0083: Unknown result type (might be due to invalid IL or missing references)
		//IL_008d: Expected Obj, but got Unknown
		//IL_00c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cf: Expected Obj, but got Unknown
		_commandCollection = new SqlCommand[1];
		_commandCollection[0] = new SqlCommand();
		_commandCollection[0].Connection = Connection;
		_commandCollection[0].CommandText = "SELECT     [Prod-ID], Product, Dosage, Co, [Order], Body_Part\r\nFROM         Rx\r\nWHERE     (Abrev = @Abrev) AND (H_L = @hl)";
		_commandCollection[0].CommandType = CommandType.Text;
		_commandCollection[0].Parameters.Add(new SqlParameter("@Abrev", SqlDbType.NVarChar, 255, ParameterDirection.Input, (byte)0, (byte)0, "Abrev", DataRowVersion.Current, false, (object)null, "", "", ""));
		_commandCollection[0].Parameters.Add(new SqlParameter("@hl", SqlDbType.NVarChar, 255, ParameterDirection.Input, (byte)0, (byte)0, "H_L", DataRowVersion.Current, false, (object)null, "", "", ""));
	}

	[HelpKeyword("vs.data.TableAdapter")]
	[DataObjectMethod(DataObjectMethodType.Fill, true)]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	[DebuggerNonUserCode]
	public virtual int Fill(Labstuff.RxDataTable dataTable, string Abrev, string hl)
	{
		Adapter.SelectCommand = CommandCollection[0];
		if (Abrev == null)
		{
			Adapter.SelectCommand.Parameters[0].Value = DBNull.Value;
		}
		else
		{
			Adapter.SelectCommand.Parameters[0].Value = Abrev;
		}
		if (hl == null)
		{
			Adapter.SelectCommand.Parameters[1].Value = DBNull.Value;
		}
		else
		{
			Adapter.SelectCommand.Parameters[1].Value = hl;
		}
		if (ClearBeforeFill)
		{
			dataTable.Clear();
		}
		return ((DbDataAdapter)(object)Adapter).Fill((DataTable)dataTable);
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	[DebuggerNonUserCode]
	[DataObjectMethod(DataObjectMethodType.Select, true)]
	[HelpKeyword("vs.data.TableAdapter")]
	public virtual Labstuff.RxDataTable GetData(string Abrev, string hl)
	{
		Adapter.SelectCommand = CommandCollection[0];
		if (Abrev == null)
		{
			Adapter.SelectCommand.Parameters[0].Value = DBNull.Value;
		}
		else
		{
			Adapter.SelectCommand.Parameters[0].Value = Abrev;
		}
		if (hl == null)
		{
			Adapter.SelectCommand.Parameters[1].Value = DBNull.Value;
		}
		else
		{
			Adapter.SelectCommand.Parameters[1].Value = hl;
		}
		Labstuff.RxDataTable rxDataTable = new Labstuff.RxDataTable();
		((DbDataAdapter)(object)Adapter).Fill((DataTable)rxDataTable);
		return rxDataTable;
	}

	[DebuggerNonUserCode]
	[HelpKeyword("vs.data.TableAdapter")]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	public virtual int Update(Labstuff.RxDataTable dataTable)
	{
		return ((DbDataAdapter)(object)Adapter).Update((DataTable)dataTable);
	}

	[HelpKeyword("vs.data.TableAdapter")]
	[DebuggerNonUserCode]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	public virtual int Update(Labstuff dataSet)
	{
		return ((DbDataAdapter)(object)Adapter).Update((DataSet)dataSet, "Rx");
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	[HelpKeyword("vs.data.TableAdapter")]
	[DebuggerNonUserCode]
	public virtual int Update(DataRow dataRow)
	{
		return ((DbDataAdapter)(object)Adapter).Update(new DataRow[1] { dataRow });
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	[DebuggerNonUserCode]
	[HelpKeyword("vs.data.TableAdapter")]
	public virtual int Update(DataRow[] dataRows)
	{
		return ((DbDataAdapter)(object)Adapter).Update(dataRows);
	}

	[DataObjectMethod(DataObjectMethodType.Insert, true)]
	[DebuggerNonUserCode]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	[HelpKeyword("vs.data.TableAdapter")]
	public virtual int Insert(double? p1, string Product, string Dosage, string Co, double? Order, string Body_Part)
	{
		if (p1.HasValue)
		{
			Adapter.InsertCommand.Parameters[0].Value = p1.Value;
		}
		else
		{
			Adapter.InsertCommand.Parameters[0].Value = DBNull.Value;
		}
		if (Product == null)
		{
			Adapter.InsertCommand.Parameters[1].Value = DBNull.Value;
		}
		else
		{
			Adapter.InsertCommand.Parameters[1].Value = Product;
		}
		if (Dosage == null)
		{
			Adapter.InsertCommand.Parameters[2].Value = DBNull.Value;
		}
		else
		{
			Adapter.InsertCommand.Parameters[2].Value = Dosage;
		}
		if (Co == null)
		{
			Adapter.InsertCommand.Parameters[3].Value = DBNull.Value;
		}
		else
		{
			Adapter.InsertCommand.Parameters[3].Value = Co;
		}
		if (Order.HasValue)
		{
			Adapter.InsertCommand.Parameters[4].Value = Order.Value;
		}
		else
		{
			Adapter.InsertCommand.Parameters[4].Value = DBNull.Value;
		}
		if (Body_Part == null)
		{
			Adapter.InsertCommand.Parameters[5].Value = DBNull.Value;
		}
		else
		{
			Adapter.InsertCommand.Parameters[5].Value = Body_Part;
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
}
