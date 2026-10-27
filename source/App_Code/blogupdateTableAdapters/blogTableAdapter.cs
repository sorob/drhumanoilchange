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

namespace blogupdateTableAdapters;

[ToolboxItem(true)]
[DataObject(true)]
[HelpKeyword("vs.data.TableAdapter")]
[DesignerCategory("code")]
[Designer("Microsoft.VSDesigner.DataSource.Design.TableAdapterDesigner, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
public class blogTableAdapter : Component
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
	public blogTableAdapter()
	{
		ClearBeforeFill = true;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	private void InitAdapter()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected Obj, but got Unknown
		//IL_00d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e3: Expected Obj, but got Unknown
		//IL_0154: Unknown result type (might be due to invalid IL or missing references)
		//IL_015e: Expected Obj, but got Unknown
		//IL_0165: Unknown result type (might be due to invalid IL or missing references)
		//IL_016f: Expected Obj, but got Unknown
		//IL_01e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01eb: Expected Obj, but got Unknown
		//IL_0222: Unknown result type (might be due to invalid IL or missing references)
		//IL_022c: Expected Obj, but got Unknown
		//IL_0263: Unknown result type (might be due to invalid IL or missing references)
		//IL_026d: Expected Obj, but got Unknown
		//IL_02a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ae: Expected Obj, but got Unknown
		//IL_02e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ef: Expected Obj, but got Unknown
		//IL_0325: Unknown result type (might be due to invalid IL or missing references)
		//IL_032f: Expected Obj, but got Unknown
		//IL_0336: Unknown result type (might be due to invalid IL or missing references)
		//IL_0340: Expected Obj, but got Unknown
		//IL_03b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_03bc: Expected Obj, but got Unknown
		//IL_03f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_03fd: Expected Obj, but got Unknown
		//IL_0434: Unknown result type (might be due to invalid IL or missing references)
		//IL_043e: Expected Obj, but got Unknown
		//IL_0475: Unknown result type (might be due to invalid IL or missing references)
		//IL_047f: Expected Obj, but got Unknown
		//IL_04b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_04c0: Expected Obj, but got Unknown
		//IL_04f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0500: Expected Obj, but got Unknown
		//IL_0536: Unknown result type (might be due to invalid IL or missing references)
		//IL_0540: Expected Obj, but got Unknown
		_adapter = new SqlDataAdapter();
		DataTableMapping dataTableMapping = new DataTableMapping();
		dataTableMapping.SourceTable = "Table";
		dataTableMapping.DataSetTable = "blog";
		dataTableMapping.ColumnMappings.Add("blogtext", "blogtext");
		dataTableMapping.ColumnMappings.Add("blogtitle", "blogtitle");
		dataTableMapping.ColumnMappings.Add("img", "img");
		dataTableMapping.ColumnMappings.Add("thumb", "thumb");
		dataTableMapping.ColumnMappings.Add("commenting", "commenting");
		dataTableMapping.ColumnMappings.Add("bid", "bid");
		dataTableMapping.ColumnMappings.Add("lang", "lang");
		((DataAdapter)(object)_adapter).TableMappings.Add(dataTableMapping);
		_adapter.DeleteCommand = new SqlCommand();
		_adapter.DeleteCommand.Connection = Connection;
		_adapter.DeleteCommand.CommandText = "DELETE FROM [blog] WHERE (([bid] = @Original_bid))";
		_adapter.DeleteCommand.CommandType = CommandType.Text;
		_adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_bid", SqlDbType.Int, 0, ParameterDirection.Input, (byte)0, (byte)0, "bid", DataRowVersion.Original, false, (object)null, "", "", ""));
		_adapter.InsertCommand = new SqlCommand();
		_adapter.InsertCommand.Connection = Connection;
		_adapter.InsertCommand.CommandText = "INSERT INTO [blog] ([blogtext], [blogtitle], [img], [lang], [thumb], [commenting]) VALUES (@blogtext, @blogtitle, @img, @lang, @thumb, @commenting)";
		_adapter.InsertCommand.CommandType = CommandType.Text;
		_adapter.InsertCommand.Parameters.Add(new SqlParameter("@blogtext", SqlDbType.NText, 0, ParameterDirection.Input, (byte)0, (byte)0, "blogtext", DataRowVersion.Current, false, (object)null, "", "", ""));
		_adapter.InsertCommand.Parameters.Add(new SqlParameter("@blogtitle", SqlDbType.NText, 0, ParameterDirection.Input, (byte)0, (byte)0, "blogtitle", DataRowVersion.Current, false, (object)null, "", "", ""));
		_adapter.InsertCommand.Parameters.Add(new SqlParameter("@img", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte)0, (byte)0, "img", DataRowVersion.Current, false, (object)null, "", "", ""));
		_adapter.InsertCommand.Parameters.Add(new SqlParameter("@lang", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte)0, (byte)0, "lang", DataRowVersion.Current, false, (object)null, "", "", ""));
		_adapter.InsertCommand.Parameters.Add(new SqlParameter("@thumb", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte)0, (byte)0, "thumb", DataRowVersion.Current, false, (object)null, "", "", ""));
		_adapter.InsertCommand.Parameters.Add(new SqlParameter("@commenting", SqlDbType.Bit, 0, ParameterDirection.Input, (byte)0, (byte)0, "commenting", DataRowVersion.Current, false, (object)null, "", "", ""));
		_adapter.UpdateCommand = new SqlCommand();
		_adapter.UpdateCommand.Connection = Connection;
		_adapter.UpdateCommand.CommandText = "UPDATE [blog] SET [blogtext] = @blogtext, [blogtitle] = @blogtitle, [img] = @img, [lang] = @lang, [thumb] = @thumb, [commenting] = @commenting WHERE (([bid] = @Original_bid))";
		_adapter.UpdateCommand.CommandType = CommandType.Text;
		_adapter.UpdateCommand.Parameters.Add(new SqlParameter("@blogtext", SqlDbType.NText, 0, ParameterDirection.Input, (byte)0, (byte)0, "blogtext", DataRowVersion.Current, false, (object)null, "", "", ""));
		_adapter.UpdateCommand.Parameters.Add(new SqlParameter("@blogtitle", SqlDbType.NText, 0, ParameterDirection.Input, (byte)0, (byte)0, "blogtitle", DataRowVersion.Current, false, (object)null, "", "", ""));
		_adapter.UpdateCommand.Parameters.Add(new SqlParameter("@img", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte)0, (byte)0, "img", DataRowVersion.Current, false, (object)null, "", "", ""));
		_adapter.UpdateCommand.Parameters.Add(new SqlParameter("@lang", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte)0, (byte)0, "lang", DataRowVersion.Current, false, (object)null, "", "", ""));
		_adapter.UpdateCommand.Parameters.Add(new SqlParameter("@thumb", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte)0, (byte)0, "thumb", DataRowVersion.Current, false, (object)null, "", "", ""));
		_adapter.UpdateCommand.Parameters.Add(new SqlParameter("@commenting", SqlDbType.Bit, 0, ParameterDirection.Input, (byte)0, (byte)0, "commenting", DataRowVersion.Current, false, (object)null, "", "", ""));
		_adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_bid", SqlDbType.Int, 0, ParameterDirection.Input, (byte)0, (byte)0, "bid", DataRowVersion.Original, false, (object)null, "", "", ""));
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
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		//IL_008a: Expected Obj, but got Unknown
		//IL_00bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c7: Expected Obj, but got Unknown
		//IL_00cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d5: Expected Obj, but got Unknown
		//IL_013f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0149: Expected Obj, but got Unknown
		//IL_0181: Unknown result type (might be due to invalid IL or missing references)
		//IL_018b: Expected Obj, but got Unknown
		//IL_01c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ca: Expected Obj, but got Unknown
		//IL_01ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_0209: Expected Obj, but got Unknown
		//IL_023c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0246: Expected Obj, but got Unknown
		//IL_0279: Unknown result type (might be due to invalid IL or missing references)
		//IL_0283: Expected Obj, but got Unknown
		//IL_02b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c2: Expected Obj, but got Unknown
		//IL_02f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0301: Expected Obj, but got Unknown
		//IL_0309: Unknown result type (might be due to invalid IL or missing references)
		//IL_030f: Expected Obj, but got Unknown
		//IL_0376: Unknown result type (might be due to invalid IL or missing references)
		//IL_0380: Expected Obj, but got Unknown
		//IL_03b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_03bf: Expected Obj, but got Unknown
		//IL_03f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_03fc: Expected Obj, but got Unknown
		//IL_0404: Unknown result type (might be due to invalid IL or missing references)
		//IL_040a: Expected Obj, but got Unknown
		//IL_0474: Unknown result type (might be due to invalid IL or missing references)
		//IL_047e: Expected Obj, but got Unknown
		//IL_04b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_04c0: Expected Obj, but got Unknown
		//IL_04f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ff: Expected Obj, but got Unknown
		//IL_0534: Unknown result type (might be due to invalid IL or missing references)
		//IL_053e: Expected Obj, but got Unknown
		//IL_0571: Unknown result type (might be due to invalid IL or missing references)
		//IL_057b: Expected Obj, but got Unknown
		//IL_05ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_05b8: Expected Obj, but got Unknown
		//IL_05ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_05f7: Expected Obj, but got Unknown
		//IL_05ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_0605: Expected Obj, but got Unknown
		//IL_066f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0679: Expected Obj, but got Unknown
		//IL_06b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_06bb: Expected Obj, but got Unknown
		//IL_06ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_06f8: Expected Obj, but got Unknown
		//IL_072d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0737: Expected Obj, but got Unknown
		//IL_076a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0774: Expected Obj, but got Unknown
		_commandCollection = new SqlCommand[5];
		_commandCollection[0] = new SqlCommand();
		_commandCollection[0].Connection = Connection;
		_commandCollection[0].CommandText = "SELECT blogtext, blogtitle, img, lang,thumb, commenting, bid FROM blog WHERE (un = @un) AND (bid = @bid)";
		_commandCollection[0].CommandType = CommandType.Text;
		_commandCollection[0].Parameters.Add(new SqlParameter("@un", SqlDbType.NVarChar, 50, ParameterDirection.Input, (byte)0, (byte)0, "un", DataRowVersion.Current, false, (object)null, "", "", ""));
		_commandCollection[0].Parameters.Add(new SqlParameter("@bid", SqlDbType.Int, 4, ParameterDirection.Input, (byte)0, (byte)0, "bid", DataRowVersion.Current, false, (object)null, "", "", ""));
		_commandCollection[1] = new SqlCommand();
		_commandCollection[1].Connection = Connection;
		_commandCollection[1].CommandText = "INSERT INTO blog(blogtext, blogtitle, img, thumb, commenting, sdate, lang, un) VALUES (@blogtext, @blogtitle, @img, @thumb, @commenting, @sdate, @lang, @un);\r\nSELECT SCOPE_IDENTITY()";
		_commandCollection[1].CommandType = CommandType.Text;
		_commandCollection[1].Parameters.Add(new SqlParameter("@blogtext", SqlDbType.NText, 1073741823, ParameterDirection.Input, (byte)0, (byte)0, "blogtext", DataRowVersion.Current, false, (object)null, "", "", ""));
		_commandCollection[1].Parameters.Add(new SqlParameter("@blogtitle", SqlDbType.NText, 1073741823, ParameterDirection.Input, (byte)0, (byte)0, "blogtitle", DataRowVersion.Current, false, (object)null, "", "", ""));
		_commandCollection[1].Parameters.Add(new SqlParameter("@img", SqlDbType.NVarChar, 50, ParameterDirection.Input, (byte)0, (byte)0, "img", DataRowVersion.Current, false, (object)null, "", "", ""));
		_commandCollection[1].Parameters.Add(new SqlParameter("@thumb", SqlDbType.NVarChar, 50, ParameterDirection.Input, (byte)0, (byte)0, "thumb", DataRowVersion.Current, false, (object)null, "", "", ""));
		_commandCollection[1].Parameters.Add(new SqlParameter("@commenting", SqlDbType.Bit, 1, ParameterDirection.Input, (byte)0, (byte)0, "commenting", DataRowVersion.Current, false, (object)null, "", "", ""));
		_commandCollection[1].Parameters.Add(new SqlParameter("@sdate", SqlDbType.DateTime, 8, ParameterDirection.Input, (byte)0, (byte)0, "sdate", DataRowVersion.Current, false, (object)null, "", "", ""));
		_commandCollection[1].Parameters.Add(new SqlParameter("@lang", SqlDbType.NVarChar, 50, ParameterDirection.Input, (byte)0, (byte)0, "lang", DataRowVersion.Current, false, (object)null, "", "", ""));
		_commandCollection[1].Parameters.Add(new SqlParameter("@un", SqlDbType.NVarChar, 50, ParameterDirection.Input, (byte)0, (byte)0, "un", DataRowVersion.Current, false, (object)null, "", "", ""));
		_commandCollection[2] = new SqlCommand();
		_commandCollection[2].Connection = Connection;
		_commandCollection[2].CommandText = "UPDATE blog SET img = @img, thumb = @thumb WHERE (bid = @Original_bid)";
		_commandCollection[2].CommandType = CommandType.Text;
		_commandCollection[2].Parameters.Add(new SqlParameter("@img", SqlDbType.NVarChar, 50, ParameterDirection.Input, (byte)0, (byte)0, "img", DataRowVersion.Current, false, (object)null, "", "", ""));
		_commandCollection[2].Parameters.Add(new SqlParameter("@thumb", SqlDbType.NVarChar, 50, ParameterDirection.Input, (byte)0, (byte)0, "thumb", DataRowVersion.Current, false, (object)null, "", "", ""));
		_commandCollection[2].Parameters.Add(new SqlParameter("@Original_bid", SqlDbType.Int, 4, ParameterDirection.Input, (byte)0, (byte)0, "bid", DataRowVersion.Original, false, (object)null, "", "", ""));
		_commandCollection[3] = new SqlCommand();
		_commandCollection[3].Connection = Connection;
		_commandCollection[3].CommandText = "UPDATE blog SET blogtext = @blogtext, blogtitle = @blogtitle, img = @img, thumb = @thumb, commenting = @commenting WHERE (bid = @Original_bid) AND (un = @un)";
		_commandCollection[3].CommandType = CommandType.Text;
		_commandCollection[3].Parameters.Add(new SqlParameter("@blogtext", SqlDbType.NText, 1073741823, ParameterDirection.Input, (byte)0, (byte)0, "blogtext", DataRowVersion.Current, false, (object)null, "", "", ""));
		_commandCollection[3].Parameters.Add(new SqlParameter("@blogtitle", SqlDbType.NText, 1073741823, ParameterDirection.Input, (byte)0, (byte)0, "blogtitle", DataRowVersion.Current, false, (object)null, "", "", ""));
		_commandCollection[3].Parameters.Add(new SqlParameter("@img", SqlDbType.NVarChar, 50, ParameterDirection.Input, (byte)0, (byte)0, "img", DataRowVersion.Current, false, (object)null, "", "", ""));
		_commandCollection[3].Parameters.Add(new SqlParameter("@thumb", SqlDbType.NVarChar, 50, ParameterDirection.Input, (byte)0, (byte)0, "thumb", DataRowVersion.Current, false, (object)null, "", "", ""));
		_commandCollection[3].Parameters.Add(new SqlParameter("@commenting", SqlDbType.Bit, 1, ParameterDirection.Input, (byte)0, (byte)0, "commenting", DataRowVersion.Current, false, (object)null, "", "", ""));
		_commandCollection[3].Parameters.Add(new SqlParameter("@Original_bid", SqlDbType.Int, 4, ParameterDirection.Input, (byte)0, (byte)0, "bid", DataRowVersion.Original, false, (object)null, "", "", ""));
		_commandCollection[3].Parameters.Add(new SqlParameter("@un", SqlDbType.NVarChar, 50, ParameterDirection.Input, (byte)0, (byte)0, "un", DataRowVersion.Original, false, (object)null, "", "", ""));
		_commandCollection[4] = new SqlCommand();
		_commandCollection[4].Connection = Connection;
		_commandCollection[4].CommandText = "UPDATE    blog\r\nSET              blogtext = @blogtext, blogtitle = @blogtitle, commenting = @commenting, lang = @cat\r\nWHERE     (bid = @Original_bid)";
		_commandCollection[4].CommandType = CommandType.Text;
		_commandCollection[4].Parameters.Add(new SqlParameter("@blogtext", SqlDbType.NText, 1073741823, ParameterDirection.Input, (byte)0, (byte)0, "blogtext", DataRowVersion.Current, false, (object)null, "", "", ""));
		_commandCollection[4].Parameters.Add(new SqlParameter("@blogtitle", SqlDbType.NText, 1073741823, ParameterDirection.Input, (byte)0, (byte)0, "blogtitle", DataRowVersion.Current, false, (object)null, "", "", ""));
		_commandCollection[4].Parameters.Add(new SqlParameter("@commenting", SqlDbType.Bit, 1, ParameterDirection.Input, (byte)0, (byte)0, "commenting", DataRowVersion.Current, false, (object)null, "", "", ""));
		_commandCollection[4].Parameters.Add(new SqlParameter("@cat", SqlDbType.NVarChar, 50, ParameterDirection.Input, (byte)0, (byte)0, "lang", DataRowVersion.Current, false, (object)null, "", "", ""));
		_commandCollection[4].Parameters.Add(new SqlParameter("@Original_bid", SqlDbType.Int, 4, ParameterDirection.Input, (byte)0, (byte)0, "bid", DataRowVersion.Original, false, (object)null, "", "", ""));
	}

	[DataObjectMethod(DataObjectMethodType.Fill, true)]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	[DebuggerNonUserCode]
	[HelpKeyword("vs.data.TableAdapter")]
	public virtual int Fill(blogupdate.blogDataTable dataTable, string un, int bid)
	{
		Adapter.SelectCommand = CommandCollection[0];
		if (un == null)
		{
			Adapter.SelectCommand.Parameters[0].Value = DBNull.Value;
		}
		else
		{
			Adapter.SelectCommand.Parameters[0].Value = un;
		}
		Adapter.SelectCommand.Parameters[1].Value = bid;
		if (ClearBeforeFill)
		{
			dataTable.Clear();
		}
		return ((DbDataAdapter)(object)Adapter).Fill((DataTable)dataTable);
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	[HelpKeyword("vs.data.TableAdapter")]
	[DebuggerNonUserCode]
	[DataObjectMethod(DataObjectMethodType.Select, true)]
	public virtual blogupdate.blogDataTable GetData(string un, int bid)
	{
		Adapter.SelectCommand = CommandCollection[0];
		if (un == null)
		{
			Adapter.SelectCommand.Parameters[0].Value = DBNull.Value;
		}
		else
		{
			Adapter.SelectCommand.Parameters[0].Value = un;
		}
		Adapter.SelectCommand.Parameters[1].Value = bid;
		blogupdate.blogDataTable blogDataTable = new blogupdate.blogDataTable();
		((DbDataAdapter)(object)Adapter).Fill((DataTable)blogDataTable);
		return blogDataTable;
	}

	[HelpKeyword("vs.data.TableAdapter")]
	[DebuggerNonUserCode]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	public virtual int Update(blogupdate.blogDataTable dataTable)
	{
		return ((DbDataAdapter)(object)Adapter).Update((DataTable)dataTable);
	}

	[HelpKeyword("vs.data.TableAdapter")]
	[DebuggerNonUserCode]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	public virtual int Update(blogupdate dataSet)
	{
		return ((DbDataAdapter)(object)Adapter).Update((DataSet)dataSet, "blog");
	}

	[DebuggerNonUserCode]
	[HelpKeyword("vs.data.TableAdapter")]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	public virtual int Update(DataRow dataRow)
	{
		return ((DbDataAdapter)(object)Adapter).Update(new DataRow[1] { dataRow });
	}

	[DebuggerNonUserCode]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	[HelpKeyword("vs.data.TableAdapter")]
	public virtual int Update(DataRow[] dataRows)
	{
		return ((DbDataAdapter)(object)Adapter).Update(dataRows);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	[DataObjectMethod(DataObjectMethodType.Delete, true)]
	[HelpKeyword("vs.data.TableAdapter")]
	public virtual int Delete(int Original_bid)
	{
		Adapter.DeleteCommand.Parameters[0].Value = Original_bid;
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

	[HelpKeyword("vs.data.TableAdapter")]
	[DebuggerNonUserCode]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	[DataObjectMethod(DataObjectMethodType.Insert, true)]
	public virtual int Insert(string blogtext, string blogtitle, string img, string lang, string thumb, bool? commenting)
	{
		if (blogtext == null)
		{
			Adapter.InsertCommand.Parameters[0].Value = DBNull.Value;
		}
		else
		{
			Adapter.InsertCommand.Parameters[0].Value = blogtext;
		}
		if (blogtitle == null)
		{
			Adapter.InsertCommand.Parameters[1].Value = DBNull.Value;
		}
		else
		{
			Adapter.InsertCommand.Parameters[1].Value = blogtitle;
		}
		if (img == null)
		{
			Adapter.InsertCommand.Parameters[2].Value = DBNull.Value;
		}
		else
		{
			Adapter.InsertCommand.Parameters[2].Value = img;
		}
		if (lang == null)
		{
			Adapter.InsertCommand.Parameters[3].Value = DBNull.Value;
		}
		else
		{
			Adapter.InsertCommand.Parameters[3].Value = lang;
		}
		if (thumb == null)
		{
			Adapter.InsertCommand.Parameters[4].Value = DBNull.Value;
		}
		else
		{
			Adapter.InsertCommand.Parameters[4].Value = thumb;
		}
		if (commenting.HasValue)
		{
			Adapter.InsertCommand.Parameters[5].Value = commenting.Value;
		}
		else
		{
			Adapter.InsertCommand.Parameters[5].Value = DBNull.Value;
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
	public virtual int Update(string blogtext, string blogtitle, string img, string lang, string thumb, bool? commenting, int Original_bid)
	{
		if (blogtext == null)
		{
			Adapter.UpdateCommand.Parameters[0].Value = DBNull.Value;
		}
		else
		{
			Adapter.UpdateCommand.Parameters[0].Value = blogtext;
		}
		if (blogtitle == null)
		{
			Adapter.UpdateCommand.Parameters[1].Value = DBNull.Value;
		}
		else
		{
			Adapter.UpdateCommand.Parameters[1].Value = blogtitle;
		}
		if (img == null)
		{
			Adapter.UpdateCommand.Parameters[2].Value = DBNull.Value;
		}
		else
		{
			Adapter.UpdateCommand.Parameters[2].Value = img;
		}
		if (lang == null)
		{
			Adapter.UpdateCommand.Parameters[3].Value = DBNull.Value;
		}
		else
		{
			Adapter.UpdateCommand.Parameters[3].Value = lang;
		}
		if (thumb == null)
		{
			Adapter.UpdateCommand.Parameters[4].Value = DBNull.Value;
		}
		else
		{
			Adapter.UpdateCommand.Parameters[4].Value = thumb;
		}
		if (commenting.HasValue)
		{
			Adapter.UpdateCommand.Parameters[5].Value = commenting.Value;
		}
		else
		{
			Adapter.UpdateCommand.Parameters[5].Value = DBNull.Value;
		}
		Adapter.UpdateCommand.Parameters[6].Value = Original_bid;
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
	[DataObjectMethod(DataObjectMethodType.Insert, false)]
	[DebuggerNonUserCode]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	public virtual int InsertAndget(string blogtext, string blogtitle, string img, string thumb, bool? commenting, DateTime? sdate, string lang, string un)
	{
		SqlCommand val = CommandCollection[1];
		if (blogtext == null)
		{
			val.Parameters[0].Value = DBNull.Value;
		}
		else
		{
			val.Parameters[0].Value = blogtext;
		}
		if (blogtitle == null)
		{
			val.Parameters[1].Value = DBNull.Value;
		}
		else
		{
			val.Parameters[1].Value = blogtitle;
		}
		if (img == null)
		{
			val.Parameters[2].Value = DBNull.Value;
		}
		else
		{
			val.Parameters[2].Value = img;
		}
		if (thumb == null)
		{
			val.Parameters[3].Value = DBNull.Value;
		}
		else
		{
			val.Parameters[3].Value = thumb;
		}
		if (commenting.HasValue)
		{
			val.Parameters[4].Value = commenting.Value;
		}
		else
		{
			val.Parameters[4].Value = DBNull.Value;
		}
		if (sdate.HasValue)
		{
			val.Parameters[5].Value = sdate.Value;
		}
		else
		{
			val.Parameters[5].Value = DBNull.Value;
		}
		if (lang == null)
		{
			val.Parameters[6].Value = DBNull.Value;
		}
		else
		{
			val.Parameters[6].Value = lang;
		}
		if (un == null)
		{
			val.Parameters[7].Value = DBNull.Value;
		}
		else
		{
			val.Parameters[7].Value = un;
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

	[DataObjectMethod(DataObjectMethodType.Update, false)]
	[DebuggerNonUserCode]
	[HelpKeyword("vs.data.TableAdapter")]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	public virtual int SetimgAfterUpld(string img, string thumb, int Original_bid)
	{
		SqlCommand val = CommandCollection[2];
		if (img == null)
		{
			val.Parameters[0].Value = DBNull.Value;
		}
		else
		{
			val.Parameters[0].Value = img;
		}
		if (thumb == null)
		{
			val.Parameters[1].Value = DBNull.Value;
		}
		else
		{
			val.Parameters[1].Value = thumb;
		}
		val.Parameters[2].Value = Original_bid;
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

	[HelpKeyword("vs.data.TableAdapter")]
	[DataObjectMethod(DataObjectMethodType.Update, false)]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	[DebuggerNonUserCode]
	public virtual int UpdateQuery(string blogtext, string blogtitle, string img, string thumb, bool? commenting, int Original_bid, string un)
	{
		SqlCommand val = CommandCollection[3];
		if (blogtext == null)
		{
			val.Parameters[0].Value = DBNull.Value;
		}
		else
		{
			val.Parameters[0].Value = blogtext;
		}
		if (blogtitle == null)
		{
			val.Parameters[1].Value = DBNull.Value;
		}
		else
		{
			val.Parameters[1].Value = blogtitle;
		}
		if (img == null)
		{
			val.Parameters[2].Value = DBNull.Value;
		}
		else
		{
			val.Parameters[2].Value = img;
		}
		if (thumb == null)
		{
			val.Parameters[3].Value = DBNull.Value;
		}
		else
		{
			val.Parameters[3].Value = thumb;
		}
		if (commenting.HasValue)
		{
			val.Parameters[4].Value = commenting.Value;
		}
		else
		{
			val.Parameters[4].Value = DBNull.Value;
		}
		val.Parameters[5].Value = Original_bid;
		if (un == null)
		{
			val.Parameters[6].Value = DBNull.Value;
		}
		else
		{
			val.Parameters[6].Value = un;
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

	[HelpKeyword("vs.data.TableAdapter")]
	[DataObjectMethod(DataObjectMethodType.Update, false)]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	[DebuggerNonUserCode]
	public virtual int updateWOimg(string blogtext, string blogtitle, bool? commenting, string cat, int Original_bid)
	{
		SqlCommand val = CommandCollection[4];
		if (blogtext == null)
		{
			val.Parameters[0].Value = DBNull.Value;
		}
		else
		{
			val.Parameters[0].Value = blogtext;
		}
		if (blogtitle == null)
		{
			val.Parameters[1].Value = DBNull.Value;
		}
		else
		{
			val.Parameters[1].Value = blogtitle;
		}
		if (commenting.HasValue)
		{
			val.Parameters[2].Value = commenting.Value;
		}
		else
		{
			val.Parameters[2].Value = DBNull.Value;
		}
		if (cat == null)
		{
			val.Parameters[3].Value = DBNull.Value;
		}
		else
		{
			val.Parameters[3].Value = cat;
		}
		val.Parameters[4].Value = Original_bid;
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
