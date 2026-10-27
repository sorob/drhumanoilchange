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

namespace textrefTableAdapters;

[DesignerCategory("code")]
[HelpKeyword("vs.data.TableAdapter")]
[ToolboxItem(true)]
[Designer("Microsoft.VSDesigner.DataSource.Design.TableAdapterDesigner, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
[DataObject(true)]
public class TestRefTableAdapter : Component
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
	public TestRefTableAdapter()
	{
		ClearBeforeFill = true;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	private void InitAdapter()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected Obj, but got Unknown
		//IL_0105: Unknown result type (might be due to invalid IL or missing references)
		//IL_010f: Expected Obj, but got Unknown
		//IL_0181: Unknown result type (might be due to invalid IL or missing references)
		//IL_018b: Expected Obj, but got Unknown
		//IL_0192: Unknown result type (might be due to invalid IL or missing references)
		//IL_019c: Expected Obj, but got Unknown
		//IL_020e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0218: Expected Obj, but got Unknown
		//IL_024f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0259: Expected Obj, but got Unknown
		//IL_028f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0299: Expected Obj, but got Unknown
		//IL_02cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d9: Expected Obj, but got Unknown
		//IL_030f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0319: Expected Obj, but got Unknown
		//IL_034f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0359: Expected Obj, but got Unknown
		//IL_0390: Unknown result type (might be due to invalid IL or missing references)
		//IL_039a: Expected Obj, but got Unknown
		//IL_03d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_03db: Expected Obj, but got Unknown
		//IL_03e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ec: Expected Obj, but got Unknown
		//IL_045e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0468: Expected Obj, but got Unknown
		//IL_049f: Unknown result type (might be due to invalid IL or missing references)
		//IL_04a9: Expected Obj, but got Unknown
		//IL_04df: Unknown result type (might be due to invalid IL or missing references)
		//IL_04e9: Expected Obj, but got Unknown
		//IL_051f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0529: Expected Obj, but got Unknown
		//IL_055f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0569: Expected Obj, but got Unknown
		//IL_059f: Unknown result type (might be due to invalid IL or missing references)
		//IL_05a9: Expected Obj, but got Unknown
		//IL_05e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_05ea: Expected Obj, but got Unknown
		//IL_0621: Unknown result type (might be due to invalid IL or missing references)
		//IL_062b: Expected Obj, but got Unknown
		//IL_0662: Unknown result type (might be due to invalid IL or missing references)
		//IL_066c: Expected Obj, but got Unknown
		_adapter = new SqlDataAdapter();
		DataTableMapping dataTableMapping = new DataTableMapping();
		dataTableMapping.SourceTable = "Table";
		dataTableMapping.DataSetTable = "TestRef";
		dataTableMapping.ColumnMappings.Add("testName", "testName");
		dataTableMapping.ColumnMappings.Add("testAbrev", "testAbrev");
		dataTableMapping.ColumnMappings.Add("DocLow", "DocLow");
		dataTableMapping.ColumnMappings.Add("DocHigh", "DocHigh");
		dataTableMapping.ColumnMappings.Add("MedLow", "MedLow");
		dataTableMapping.ColumnMappings.Add("MedHigh", "MedHigh");
		dataTableMapping.ColumnMappings.Add("Sex", "Sex");
		dataTableMapping.ColumnMappings.Add("rid", "rid");
		dataTableMapping.ColumnMappings.Add("Category", "Category");
		((DataAdapter)(object)_adapter).TableMappings.Add(dataTableMapping);
		_adapter.DeleteCommand = new SqlCommand();
		_adapter.DeleteCommand.Connection = Connection;
		_adapter.DeleteCommand.CommandText = "DELETE FROM [TestRef] WHERE (([testAbrev] = @Original_testAbrev))";
		_adapter.DeleteCommand.CommandType = CommandType.Text;
		_adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_testAbrev", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte)0, (byte)0, "testAbrev", DataRowVersion.Original, false, (object)null, "", "", ""));
		_adapter.InsertCommand = new SqlCommand();
		_adapter.InsertCommand.Connection = Connection;
		_adapter.InsertCommand.CommandText = "INSERT INTO [TestRef] ([testName], [testAbrev], [DocLow], [DocHigh], [MedLow], [MedHigh], [Sex], [Category]) VALUES (@testName, @testAbrev, @DocLow, @DocHigh, @MedLow, @MedHigh, @Sex, @Category)";
		_adapter.InsertCommand.CommandType = CommandType.Text;
		_adapter.InsertCommand.Parameters.Add(new SqlParameter("@testName", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte)0, (byte)0, "testName", DataRowVersion.Current, false, (object)null, "", "", ""));
		_adapter.InsertCommand.Parameters.Add(new SqlParameter("@testAbrev", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte)0, (byte)0, "testAbrev", DataRowVersion.Current, false, (object)null, "", "", ""));
		_adapter.InsertCommand.Parameters.Add(new SqlParameter("@DocLow", SqlDbType.Float, 0, ParameterDirection.Input, (byte)0, (byte)0, "DocLow", DataRowVersion.Current, false, (object)null, "", "", ""));
		_adapter.InsertCommand.Parameters.Add(new SqlParameter("@DocHigh", SqlDbType.Float, 0, ParameterDirection.Input, (byte)0, (byte)0, "DocHigh", DataRowVersion.Current, false, (object)null, "", "", ""));
		_adapter.InsertCommand.Parameters.Add(new SqlParameter("@MedLow", SqlDbType.Float, 0, ParameterDirection.Input, (byte)0, (byte)0, "MedLow", DataRowVersion.Current, false, (object)null, "", "", ""));
		_adapter.InsertCommand.Parameters.Add(new SqlParameter("@MedHigh", SqlDbType.Float, 0, ParameterDirection.Input, (byte)0, (byte)0, "MedHigh", DataRowVersion.Current, false, (object)null, "", "", ""));
		_adapter.InsertCommand.Parameters.Add(new SqlParameter("@Sex", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte)0, (byte)0, "Sex", DataRowVersion.Current, false, (object)null, "", "", ""));
		_adapter.InsertCommand.Parameters.Add(new SqlParameter("@Category", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte)0, (byte)0, "Category", DataRowVersion.Current, false, (object)null, "", "", ""));
		_adapter.UpdateCommand = new SqlCommand();
		_adapter.UpdateCommand.Connection = Connection;
		_adapter.UpdateCommand.CommandText = "UPDATE [TestRef] SET [testName] = @testName, [testAbrev] = @testAbrev, [DocLow] = @DocLow, [DocHigh] = @DocHigh, [MedLow] = @MedLow, [MedHigh] = @MedHigh, [Sex] = @Sex, [Category] = @Category WHERE (([testAbrev] = @Original_testAbrev))";
		_adapter.UpdateCommand.CommandType = CommandType.Text;
		_adapter.UpdateCommand.Parameters.Add(new SqlParameter("@testName", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte)0, (byte)0, "testName", DataRowVersion.Current, false, (object)null, "", "", ""));
		_adapter.UpdateCommand.Parameters.Add(new SqlParameter("@testAbrev", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte)0, (byte)0, "testAbrev", DataRowVersion.Current, false, (object)null, "", "", ""));
		_adapter.UpdateCommand.Parameters.Add(new SqlParameter("@DocLow", SqlDbType.Float, 0, ParameterDirection.Input, (byte)0, (byte)0, "DocLow", DataRowVersion.Current, false, (object)null, "", "", ""));
		_adapter.UpdateCommand.Parameters.Add(new SqlParameter("@DocHigh", SqlDbType.Float, 0, ParameterDirection.Input, (byte)0, (byte)0, "DocHigh", DataRowVersion.Current, false, (object)null, "", "", ""));
		_adapter.UpdateCommand.Parameters.Add(new SqlParameter("@MedLow", SqlDbType.Float, 0, ParameterDirection.Input, (byte)0, (byte)0, "MedLow", DataRowVersion.Current, false, (object)null, "", "", ""));
		_adapter.UpdateCommand.Parameters.Add(new SqlParameter("@MedHigh", SqlDbType.Float, 0, ParameterDirection.Input, (byte)0, (byte)0, "MedHigh", DataRowVersion.Current, false, (object)null, "", "", ""));
		_adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Sex", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte)0, (byte)0, "Sex", DataRowVersion.Current, false, (object)null, "", "", ""));
		_adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Category", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte)0, (byte)0, "Category", DataRowVersion.Current, false, (object)null, "", "", ""));
		_adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_testAbrev", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte)0, (byte)0, "testAbrev", DataRowVersion.Original, false, (object)null, "", "", ""));
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
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_0059: Expected Obj, but got Unknown
		//IL_00c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ca: Expected Obj, but got Unknown
		//IL_00d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d8: Expected Obj, but got Unknown
		//IL_013f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0149: Expected Obj, but got Unknown
		_commandCollection = new SqlCommand[3];
		_commandCollection[0] = new SqlCommand();
		_commandCollection[0].Connection = Connection;
		_commandCollection[0].CommandText = "SELECT     TestRef.*\r\nFROM         TestRef";
		_commandCollection[0].CommandType = CommandType.Text;
		_commandCollection[1] = new SqlCommand();
		_commandCollection[1].Connection = Connection;
		_commandCollection[1].CommandText = "SELECT Category, DocHigh, DocLow, MedHigh, MedLow, Sex, rid, testAbrev, testName FROM TestRef WHERE (testName LIKE @tname + N'%') OR (testAbrev LIKE @tname + N'%')";
		_commandCollection[1].CommandType = CommandType.Text;
		_commandCollection[1].Parameters.Add(new SqlParameter("@tname", SqlDbType.NVarChar, 50, ParameterDirection.Input, (byte)0, (byte)0, "testName", DataRowVersion.Current, false, (object)null, "", "", ""));
		_commandCollection[2] = new SqlCommand();
		_commandCollection[2].Connection = Connection;
		_commandCollection[2].CommandText = "SELECT Category, DocHigh, DocLow, MedHigh, MedLow, Sex, rid, testAbrev, testName FROM TestRef WHERE (testAbrev = @abrev)";
		_commandCollection[2].CommandType = CommandType.Text;
		_commandCollection[2].Parameters.Add(new SqlParameter("@abrev", SqlDbType.NVarChar, 50, ParameterDirection.Input, (byte)0, (byte)0, "testAbrev", DataRowVersion.Current, false, (object)null, "", "", ""));
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	[HelpKeyword("vs.data.TableAdapter")]
	[DebuggerNonUserCode]
	[DataObjectMethod(DataObjectMethodType.Fill, true)]
	public virtual int Fill(textref.TestRefDataTable dataTable)
	{
		Adapter.SelectCommand = CommandCollection[0];
		if (ClearBeforeFill)
		{
			dataTable.Clear();
		}
		return ((DbDataAdapter)(object)Adapter).Fill((DataTable)dataTable);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	[HelpKeyword("vs.data.TableAdapter")]
	[DataObjectMethod(DataObjectMethodType.Select, true)]
	public virtual textref.TestRefDataTable GetData()
	{
		Adapter.SelectCommand = CommandCollection[0];
		textref.TestRefDataTable testRefDataTable = new textref.TestRefDataTable();
		((DbDataAdapter)(object)Adapter).Fill((DataTable)testRefDataTable);
		return testRefDataTable;
	}

	[DebuggerNonUserCode]
	[DataObjectMethod(DataObjectMethodType.Fill, false)]
	[HelpKeyword("vs.data.TableAdapter")]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	public virtual int FillBy(textref.TestRefDataTable dataTable, string tname)
	{
		Adapter.SelectCommand = CommandCollection[1];
		if (tname == null)
		{
			Adapter.SelectCommand.Parameters[0].Value = DBNull.Value;
		}
		else
		{
			Adapter.SelectCommand.Parameters[0].Value = tname;
		}
		if (ClearBeforeFill)
		{
			dataTable.Clear();
		}
		return ((DbDataAdapter)(object)Adapter).Fill((DataTable)dataTable);
	}

	[DebuggerNonUserCode]
	[HelpKeyword("vs.data.TableAdapter")]
	[DataObjectMethod(DataObjectMethodType.Select, false)]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	public virtual textref.TestRefDataTable GetDataBy(string tname)
	{
		Adapter.SelectCommand = CommandCollection[1];
		if (tname == null)
		{
			Adapter.SelectCommand.Parameters[0].Value = DBNull.Value;
		}
		else
		{
			Adapter.SelectCommand.Parameters[0].Value = tname;
		}
		textref.TestRefDataTable testRefDataTable = new textref.TestRefDataTable();
		((DbDataAdapter)(object)Adapter).Fill((DataTable)testRefDataTable);
		return testRefDataTable;
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	[DataObjectMethod(DataObjectMethodType.Fill, false)]
	[HelpKeyword("vs.data.TableAdapter")]
	[DebuggerNonUserCode]
	public virtual int FillBy1(textref.TestRefDataTable dataTable, string abrev)
	{
		Adapter.SelectCommand = CommandCollection[2];
		if (abrev == null)
		{
			throw new ArgumentNullException("abrev");
		}
		Adapter.SelectCommand.Parameters[0].Value = abrev;
		if (ClearBeforeFill)
		{
			dataTable.Clear();
		}
		return ((DbDataAdapter)(object)Adapter).Fill((DataTable)dataTable);
	}

	[HelpKeyword("vs.data.TableAdapter")]
	[DataObjectMethod(DataObjectMethodType.Select, false)]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	[DebuggerNonUserCode]
	public virtual textref.TestRefDataTable GetDataBy1(string abrev)
	{
		Adapter.SelectCommand = CommandCollection[2];
		if (abrev == null)
		{
			throw new ArgumentNullException("abrev");
		}
		Adapter.SelectCommand.Parameters[0].Value = abrev;
		textref.TestRefDataTable testRefDataTable = new textref.TestRefDataTable();
		((DbDataAdapter)(object)Adapter).Fill((DataTable)testRefDataTable);
		return testRefDataTable;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	[HelpKeyword("vs.data.TableAdapter")]
	public virtual int Update(textref.TestRefDataTable dataTable)
	{
		return ((DbDataAdapter)(object)Adapter).Update((DataTable)dataTable);
	}

	[HelpKeyword("vs.data.TableAdapter")]
	[DebuggerNonUserCode]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	public virtual int Update(textref dataSet)
	{
		return ((DbDataAdapter)(object)Adapter).Update((DataSet)dataSet, "TestRef");
	}

	[DebuggerNonUserCode]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	[HelpKeyword("vs.data.TableAdapter")]
	public virtual int Update(DataRow dataRow)
	{
		return ((DbDataAdapter)(object)Adapter).Update(new DataRow[1] { dataRow });
	}

	[HelpKeyword("vs.data.TableAdapter")]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	[DebuggerNonUserCode]
	public virtual int Update(DataRow[] dataRows)
	{
		return ((DbDataAdapter)(object)Adapter).Update(dataRows);
	}

	[HelpKeyword("vs.data.TableAdapter")]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	[DebuggerNonUserCode]
	[DataObjectMethod(DataObjectMethodType.Delete, true)]
	public virtual int Delete(string Original_testAbrev)
	{
		if (Original_testAbrev == null)
		{
			throw new ArgumentNullException("Original_testAbrev");
		}
		Adapter.DeleteCommand.Parameters[0].Value = Original_testAbrev;
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
	[DebuggerNonUserCode]
	[HelpKeyword("vs.data.TableAdapter")]
	public virtual int Insert(string testName, string testAbrev, double? DocLow, double? DocHigh, double? MedLow, double? MedHigh, string Sex, string Category)
	{
		if (testName == null)
		{
			Adapter.InsertCommand.Parameters[0].Value = DBNull.Value;
		}
		else
		{
			Adapter.InsertCommand.Parameters[0].Value = testName;
		}
		if (testAbrev == null)
		{
			throw new ArgumentNullException("testAbrev");
		}
		Adapter.InsertCommand.Parameters[1].Value = testAbrev;
		if (DocLow.HasValue)
		{
			Adapter.InsertCommand.Parameters[2].Value = DocLow.Value;
		}
		else
		{
			Adapter.InsertCommand.Parameters[2].Value = DBNull.Value;
		}
		if (DocHigh.HasValue)
		{
			Adapter.InsertCommand.Parameters[3].Value = DocHigh.Value;
		}
		else
		{
			Adapter.InsertCommand.Parameters[3].Value = DBNull.Value;
		}
		if (MedLow.HasValue)
		{
			Adapter.InsertCommand.Parameters[4].Value = MedLow.Value;
		}
		else
		{
			Adapter.InsertCommand.Parameters[4].Value = DBNull.Value;
		}
		if (MedHigh.HasValue)
		{
			Adapter.InsertCommand.Parameters[5].Value = MedHigh.Value;
		}
		else
		{
			Adapter.InsertCommand.Parameters[5].Value = DBNull.Value;
		}
		if (Sex == null)
		{
			Adapter.InsertCommand.Parameters[6].Value = DBNull.Value;
		}
		else
		{
			Adapter.InsertCommand.Parameters[6].Value = Sex;
		}
		if (Category == null)
		{
			Adapter.InsertCommand.Parameters[7].Value = DBNull.Value;
		}
		else
		{
			Adapter.InsertCommand.Parameters[7].Value = Category;
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
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	[HelpKeyword("vs.data.TableAdapter")]
	[DataObjectMethod(DataObjectMethodType.Update, true)]
	public virtual int Update(string testName, string testAbrev, double? DocLow, double? DocHigh, double? MedLow, double? MedHigh, string Sex, string Category, string Original_testAbrev)
	{
		if (testName == null)
		{
			Adapter.UpdateCommand.Parameters[0].Value = DBNull.Value;
		}
		else
		{
			Adapter.UpdateCommand.Parameters[0].Value = testName;
		}
		if (testAbrev == null)
		{
			throw new ArgumentNullException("testAbrev");
		}
		Adapter.UpdateCommand.Parameters[1].Value = testAbrev;
		if (DocLow.HasValue)
		{
			Adapter.UpdateCommand.Parameters[2].Value = DocLow.Value;
		}
		else
		{
			Adapter.UpdateCommand.Parameters[2].Value = DBNull.Value;
		}
		if (DocHigh.HasValue)
		{
			Adapter.UpdateCommand.Parameters[3].Value = DocHigh.Value;
		}
		else
		{
			Adapter.UpdateCommand.Parameters[3].Value = DBNull.Value;
		}
		if (MedLow.HasValue)
		{
			Adapter.UpdateCommand.Parameters[4].Value = MedLow.Value;
		}
		else
		{
			Adapter.UpdateCommand.Parameters[4].Value = DBNull.Value;
		}
		if (MedHigh.HasValue)
		{
			Adapter.UpdateCommand.Parameters[5].Value = MedHigh.Value;
		}
		else
		{
			Adapter.UpdateCommand.Parameters[5].Value = DBNull.Value;
		}
		if (Sex == null)
		{
			Adapter.UpdateCommand.Parameters[6].Value = DBNull.Value;
		}
		else
		{
			Adapter.UpdateCommand.Parameters[6].Value = Sex;
		}
		if (Category == null)
		{
			Adapter.UpdateCommand.Parameters[7].Value = DBNull.Value;
		}
		else
		{
			Adapter.UpdateCommand.Parameters[7].Value = Category;
		}
		if (Original_testAbrev == null)
		{
			throw new ArgumentNullException("Original_testAbrev");
		}
		Adapter.UpdateCommand.Parameters[8].Value = Original_testAbrev;
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

	[HelpKeyword("vs.data.TableAdapter")]
	[DataObjectMethod(DataObjectMethodType.Update, true)]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	[DebuggerNonUserCode]
	public virtual int Update(string testName, double? DocLow, double? DocHigh, double? MedLow, double? MedHigh, string Sex, string Category, string Original_testAbrev)
	{
		return Update(testName, Original_testAbrev, DocLow, DocHigh, MedLow, MedHigh, Sex, Category, Original_testAbrev);
	}
}
