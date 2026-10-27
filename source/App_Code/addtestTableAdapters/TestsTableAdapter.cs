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
using Microsoft.VisualBasic.CompilerServices;

namespace addtestTableAdapters;

[DataObject(true)]
[HelpKeyword("vs.data.TableAdapter")]
[ToolboxItem(true)]
[DesignerCategory("code")]
[Designer("Microsoft.VSDesigner.DataSource.Design.TableAdapterDesigner, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
public class TestsTableAdapter : Component
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

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	[DebuggerNonUserCode]
	public TestsTableAdapter()
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
		//IL_0123: Unknown result type (might be due to invalid IL or missing references)
		//IL_012d: Expected Obj, but got Unknown
		//IL_019f: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a9: Expected Obj, but got Unknown
		//IL_01df: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e9: Expected Obj, but got Unknown
		//IL_021f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0229: Expected Obj, but got Unknown
		//IL_0230: Unknown result type (might be due to invalid IL or missing references)
		//IL_023a: Expected Obj, but got Unknown
		//IL_02ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b6: Expected Obj, but got Unknown
		//IL_02ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f6: Expected Obj, but got Unknown
		//IL_032c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0336: Expected Obj, but got Unknown
		//IL_036c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0376: Expected Obj, but got Unknown
		_adapter = new SqlDataAdapter();
		DataTableMapping dataTableMapping = new DataTableMapping();
		dataTableMapping.SourceTable = "Table";
		dataTableMapping.DataSetTable = "Tests";
		dataTableMapping.ColumnMappings.Add("UserName", "UserName");
		dataTableMapping.ColumnMappings.Add("testid", "testid");
		dataTableMapping.ColumnMappings.Add("DateCollected", "DateCollected");
		dataTableMapping.ColumnMappings.Add("DateReported", "DateReported");
		((DataAdapter)(object)_adapter).TableMappings.Add(dataTableMapping);
		_adapter.DeleteCommand = new SqlCommand();
		_adapter.DeleteCommand.Connection = Connection;
		_adapter.DeleteCommand.CommandText = "DELETE FROM [Tests] WHERE (([testid] = @Original_testid))";
		_adapter.DeleteCommand.CommandType = CommandType.Text;
		_adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_testid", SqlDbType.Int, 0, ParameterDirection.Input, (byte)0, (byte)0, "testid", DataRowVersion.Original, false, (object)null, "", "", ""));
		_adapter.InsertCommand = new SqlCommand();
		_adapter.InsertCommand.Connection = Connection;
		_adapter.InsertCommand.CommandText = "INSERT INTO [Tests] ([UserName], [DateCollected], [DateReported]) VALUES (@UserName, @DateCollected, @DateReported)";
		_adapter.InsertCommand.CommandType = CommandType.Text;
		_adapter.InsertCommand.Parameters.Add(new SqlParameter("@UserName", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte)0, (byte)0, "UserName", DataRowVersion.Current, false, (object)null, "", "", ""));
		_adapter.InsertCommand.Parameters.Add(new SqlParameter("@DateCollected", SqlDbType.DateTime, 0, ParameterDirection.Input, (byte)0, (byte)0, "DateCollected", DataRowVersion.Current, false, (object)null, "", "", ""));
		_adapter.InsertCommand.Parameters.Add(new SqlParameter("@DateReported", SqlDbType.DateTime, 0, ParameterDirection.Input, (byte)0, (byte)0, "DateReported", DataRowVersion.Current, false, (object)null, "", "", ""));
		_adapter.UpdateCommand = new SqlCommand();
		_adapter.UpdateCommand.Connection = Connection;
		_adapter.UpdateCommand.CommandText = "UPDATE [Tests] SET [UserName] = @UserName, [DateCollected] = @DateCollected, [DateReported] = @DateReported WHERE (([testid] = @Original_testid))";
		_adapter.UpdateCommand.CommandType = CommandType.Text;
		_adapter.UpdateCommand.Parameters.Add(new SqlParameter("@UserName", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte)0, (byte)0, "UserName", DataRowVersion.Current, false, (object)null, "", "", ""));
		_adapter.UpdateCommand.Parameters.Add(new SqlParameter("@DateCollected", SqlDbType.DateTime, 0, ParameterDirection.Input, (byte)0, (byte)0, "DateCollected", DataRowVersion.Current, false, (object)null, "", "", ""));
		_adapter.UpdateCommand.Parameters.Add(new SqlParameter("@DateReported", SqlDbType.DateTime, 0, ParameterDirection.Input, (byte)0, (byte)0, "DateReported", DataRowVersion.Current, false, (object)null, "", "", ""));
		_adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_testid", SqlDbType.Int, 0, ParameterDirection.Input, (byte)0, (byte)0, "testid", DataRowVersion.Original, false, (object)null, "", "", ""));
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
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_0059: Expected Obj, but got Unknown
		//IL_00bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c5: Expected Obj, but got Unknown
		//IL_00f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0103: Expected Obj, but got Unknown
		//IL_0133: Unknown result type (might be due to invalid IL or missing references)
		//IL_013d: Expected Obj, but got Unknown
		//IL_016d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0177: Expected Obj, but got Unknown
		//IL_017f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0185: Expected Obj, but got Unknown
		//IL_01ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f9: Expected Obj, but got Unknown
		_commandCollection = new SqlCommand[3];
		_commandCollection[0] = new SqlCommand();
		_commandCollection[0].Connection = Connection;
		_commandCollection[0].CommandText = "SELECT UserName, testid, DateCollected, DateReported FROM Tests";
		_commandCollection[0].CommandType = CommandType.Text;
		_commandCollection[1] = new SqlCommand();
		_commandCollection[1].Connection = Connection;
		_commandCollection[1].CommandText = "addgettest";
		_commandCollection[1].CommandType = CommandType.StoredProcedure;
		_commandCollection[1].Parameters.Add(new SqlParameter("@RETURN_VALUE", SqlDbType.Int, 4, ParameterDirection.ReturnValue, (byte)10, (byte)0, (string)null, DataRowVersion.Current, false, (object)null, "", "", ""));
		_commandCollection[1].Parameters.Add(new SqlParameter("@UserName", SqlDbType.VarChar, 256, ParameterDirection.Input, (byte)0, (byte)0, (string)null, DataRowVersion.Current, false, (object)null, "", "", ""));
		_commandCollection[1].Parameters.Add(new SqlParameter("@DateCollected", SqlDbType.DateTime, 8, ParameterDirection.Input, (byte)23, (byte)3, (string)null, DataRowVersion.Current, false, (object)null, "", "", ""));
		_commandCollection[1].Parameters.Add(new SqlParameter("@DateReported", SqlDbType.DateTime, 8, ParameterDirection.Input, (byte)23, (byte)3, (string)null, DataRowVersion.Current, false, (object)null, "", "", ""));
		_commandCollection[2] = new SqlCommand();
		_commandCollection[2].Connection = Connection;
		_commandCollection[2].CommandText = "SELECT COUNT(UserName) FROM Tests where UserName=@un ";
		_commandCollection[2].CommandType = CommandType.Text;
		_commandCollection[2].Parameters.Add(new SqlParameter("@un", SqlDbType.NVarChar, 256, ParameterDirection.Input, (byte)0, (byte)0, "UserName", DataRowVersion.Current, false, (object)null, "", "", ""));
	}

	[HelpKeyword("vs.data.TableAdapter")]
	[DataObjectMethod(DataObjectMethodType.Fill, true)]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	[DebuggerNonUserCode]
	public virtual int Fill(addtest.TestsDataTable dataTable)
	{
		Adapter.SelectCommand = CommandCollection[0];
		if (ClearBeforeFill)
		{
			dataTable.Clear();
		}
		return ((DbDataAdapter)(object)Adapter).Fill((DataTable)dataTable);
	}

	[DataObjectMethod(DataObjectMethodType.Select, true)]
	[HelpKeyword("vs.data.TableAdapter")]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	[DebuggerNonUserCode]
	public virtual addtest.TestsDataTable GetData()
	{
		Adapter.SelectCommand = CommandCollection[0];
		addtest.TestsDataTable testsDataTable = new addtest.TestsDataTable();
		((DbDataAdapter)(object)Adapter).Fill((DataTable)testsDataTable);
		return testsDataTable;
	}

	[DebuggerNonUserCode]
	[HelpKeyword("vs.data.TableAdapter")]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	public virtual int Update(addtest.TestsDataTable dataTable)
	{
		return ((DbDataAdapter)(object)Adapter).Update((DataTable)dataTable);
	}

	[DebuggerNonUserCode]
	[HelpKeyword("vs.data.TableAdapter")]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	public virtual int Update(addtest dataSet)
	{
		return ((DbDataAdapter)(object)Adapter).Update((DataSet)dataSet, "Tests");
	}

	[DebuggerNonUserCode]
	[HelpKeyword("vs.data.TableAdapter")]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
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

	[HelpKeyword("vs.data.TableAdapter")]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	[DataObjectMethod(DataObjectMethodType.Delete, true)]
	[DebuggerNonUserCode]
	public virtual int Delete(int Original_testid)
	{
		Adapter.DeleteCommand.Parameters[0].Value = Original_testid;
		ConnectionState state = Adapter.DeleteCommand.Connection.State;
		if ((Adapter.DeleteCommand.Connection.State & ConnectionState.Open) != ConnectionState.Open)
		{
			Adapter.DeleteCommand.Connection.Open();
		}
		try
		{
			return Adapter.DeleteCommand.ExecuteNonQuery();
		}
		finally
		{
			if (state == ConnectionState.Closed)
			{
				Adapter.DeleteCommand.Connection.Close();
			}
		}
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	[DataObjectMethod(DataObjectMethodType.Insert, true)]
	[HelpKeyword("vs.data.TableAdapter")]
	[DebuggerNonUserCode]
	public virtual int Insert(string UserName, DateTime? DateCollected, DateTime? DateReported)
	{
		if (UserName == null)
		{
			Adapter.InsertCommand.Parameters[0].Value = DBNull.Value;
		}
		else
		{
			Adapter.InsertCommand.Parameters[0].Value = UserName;
		}
		if (DateCollected.HasValue)
		{
			Adapter.InsertCommand.Parameters[1].Value = DateCollected.Value;
		}
		else
		{
			Adapter.InsertCommand.Parameters[1].Value = DBNull.Value;
		}
		if (DateReported.HasValue)
		{
			Adapter.InsertCommand.Parameters[2].Value = DateReported.Value;
		}
		else
		{
			Adapter.InsertCommand.Parameters[2].Value = DBNull.Value;
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

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	[DebuggerNonUserCode]
	[DataObjectMethod(DataObjectMethodType.Update, true)]
	[HelpKeyword("vs.data.TableAdapter")]
	public virtual int Update(string UserName, DateTime? DateCollected, DateTime? DateReported, int Original_testid)
	{
		if (UserName == null)
		{
			Adapter.UpdateCommand.Parameters[0].Value = DBNull.Value;
		}
		else
		{
			Adapter.UpdateCommand.Parameters[0].Value = UserName;
		}
		if (DateCollected.HasValue)
		{
			Adapter.UpdateCommand.Parameters[1].Value = DateCollected.Value;
		}
		else
		{
			Adapter.UpdateCommand.Parameters[1].Value = DBNull.Value;
		}
		if (DateReported.HasValue)
		{
			Adapter.UpdateCommand.Parameters[2].Value = DateReported.Value;
		}
		else
		{
			Adapter.UpdateCommand.Parameters[2].Value = DBNull.Value;
		}
		Adapter.UpdateCommand.Parameters[3].Value = Original_testid;
		ConnectionState state = Adapter.UpdateCommand.Connection.State;
		if ((Adapter.UpdateCommand.Connection.State & ConnectionState.Open) != ConnectionState.Open)
		{
			Adapter.UpdateCommand.Connection.Open();
		}
		try
		{
			return Adapter.UpdateCommand.ExecuteNonQuery();
		}
		finally
		{
			if (state == ConnectionState.Closed)
			{
				Adapter.UpdateCommand.Connection.Close();
			}
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	[HelpKeyword("vs.data.TableAdapter")]
	public virtual string addgettest(string UserName, DateTime? DateCollected, DateTime? DateReported)
	{
		SqlCommand val = CommandCollection[1];
		if (UserName == null)
		{
			val.Parameters[1].Value = DBNull.Value;
		}
		else
		{
			val.Parameters[1].Value = UserName;
		}
		if (DateCollected.HasValue)
		{
			val.Parameters[2].Value = DateCollected.Value;
		}
		else
		{
			val.Parameters[2].Value = DBNull.Value;
		}
		if (DateReported.HasValue)
		{
			val.Parameters[3].Value = DateReported.Value;
		}
		else
		{
			val.Parameters[3].Value = DBNull.Value;
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
		return Conversions.ToString(objectValue);
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	[HelpKeyword("vs.data.TableAdapter")]
	[DebuggerNonUserCode]
	public virtual object getnum(string un)
	{
		SqlCommand val = CommandCollection[2];
		if (un == null)
		{
			val.Parameters[0].Value = DBNull.Value;
		}
		else
		{
			val.Parameters[0].Value = un;
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
