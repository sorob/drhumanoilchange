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

[ToolboxItem(true)]
[DesignerCategory("code")]
[HelpKeyword("vs.data.TableAdapter")]
[Designer("Microsoft.VSDesigner.DataSource.Design.TableAdapterDesigner, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
[DataObject(true)]
public class txtimpTableAdapter : Component
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
	public txtimpTableAdapter()
	{
		ClearBeforeFill = true;
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	[DebuggerNonUserCode]
	private void InitAdapter()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected Obj, but got Unknown
		//IL_0189: Unknown result type (might be due to invalid IL or missing references)
		//IL_0193: Expected Obj, but got Unknown
		//IL_0205: Unknown result type (might be due to invalid IL or missing references)
		//IL_020f: Expected Obj, but got Unknown
		//IL_0216: Unknown result type (might be due to invalid IL or missing references)
		//IL_0220: Expected Obj, but got Unknown
		//IL_0292: Unknown result type (might be due to invalid IL or missing references)
		//IL_029c: Expected Obj, but got Unknown
		//IL_02d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_02dd: Expected Obj, but got Unknown
		//IL_0314: Unknown result type (might be due to invalid IL or missing references)
		//IL_031e: Expected Obj, but got Unknown
		//IL_0355: Unknown result type (might be due to invalid IL or missing references)
		//IL_035f: Expected Obj, but got Unknown
		//IL_0396: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a0: Expected Obj, but got Unknown
		//IL_03d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e1: Expected Obj, but got Unknown
		//IL_0417: Unknown result type (might be due to invalid IL or missing references)
		//IL_0421: Expected Obj, but got Unknown
		//IL_0458: Unknown result type (might be due to invalid IL or missing references)
		//IL_0462: Expected Obj, but got Unknown
		//IL_0498: Unknown result type (might be due to invalid IL or missing references)
		//IL_04a2: Expected Obj, but got Unknown
		//IL_04d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_04e2: Expected Obj, but got Unknown
		//IL_0519: Unknown result type (might be due to invalid IL or missing references)
		//IL_0523: Expected Obj, but got Unknown
		//IL_055a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0564: Expected Obj, but got Unknown
		//IL_059b: Unknown result type (might be due to invalid IL or missing references)
		//IL_05a5: Expected Obj, but got Unknown
		//IL_05dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_05e6: Expected Obj, but got Unknown
		//IL_061d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0627: Expected Obj, but got Unknown
		//IL_062e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0638: Expected Obj, but got Unknown
		//IL_06aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_06b4: Expected Obj, but got Unknown
		//IL_06eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_06f5: Expected Obj, but got Unknown
		//IL_072c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0736: Expected Obj, but got Unknown
		//IL_076d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0777: Expected Obj, but got Unknown
		//IL_07ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_07b8: Expected Obj, but got Unknown
		//IL_07ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_07f9: Expected Obj, but got Unknown
		//IL_082f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0839: Expected Obj, but got Unknown
		//IL_0870: Unknown result type (might be due to invalid IL or missing references)
		//IL_087a: Expected Obj, but got Unknown
		//IL_08b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_08ba: Expected Obj, but got Unknown
		//IL_08f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_08fa: Expected Obj, but got Unknown
		//IL_0931: Unknown result type (might be due to invalid IL or missing references)
		//IL_093b: Expected Obj, but got Unknown
		//IL_0972: Unknown result type (might be due to invalid IL or missing references)
		//IL_097c: Expected Obj, but got Unknown
		//IL_09b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_09bd: Expected Obj, but got Unknown
		//IL_09f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_09fe: Expected Obj, but got Unknown
		//IL_0a35: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a3f: Expected Obj, but got Unknown
		//IL_0a76: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a80: Expected Obj, but got Unknown
		_adapter = new SqlDataAdapter();
		DataTableMapping dataTableMapping = new DataTableMapping();
		dataTableMapping.SourceTable = "Table";
		dataTableMapping.DataSetTable = "txtimp";
		dataTableMapping.ColumnMappings.Add("codedname", "codedname");
		dataTableMapping.ColumnMappings.Add("drawdate", "drawdate");
		dataTableMapping.ColumnMappings.Add("rptdate", "rptdate");
		dataTableMapping.ColumnMappings.Add("specno", "specno");
		dataTableMapping.ColumnMappings.Add("ABR", "ABR");
		dataTableMapping.ColumnMappings.Add("testname", "testname");
		dataTableMapping.ColumnMappings.Add("result", "result");
		dataTableMapping.ColumnMappings.Add("flag", "flag");
		dataTableMapping.ColumnMappings.Add("low", "low");
		dataTableMapping.ColumnMappings.Add("high", "high");
		dataTableMapping.ColumnMappings.Add("Category21", "Category21");
		dataTableMapping.ColumnMappings.Add("Default", "Default");
		dataTableMapping.ColumnMappings.Add("Units", "Units");
		dataTableMapping.ColumnMappings.Add("DefaultOpt", "DefaultOpt");
		dataTableMapping.ColumnMappings.Add("F15", "F15");
		((DataAdapter)(object)_adapter).TableMappings.Add(dataTableMapping);
		_adapter.DeleteCommand = new SqlCommand();
		_adapter.DeleteCommand.Connection = Connection;
		_adapter.DeleteCommand.CommandText = "DELETE FROM [txtimp] WHERE (([ABR] = @Original_ABR))";
		_adapter.DeleteCommand.CommandType = CommandType.Text;
		_adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_ABR", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte)0, (byte)0, "ABR", DataRowVersion.Original, false, (object)null, "", "", ""));
		_adapter.InsertCommand = new SqlCommand();
		_adapter.InsertCommand.Connection = Connection;
		_adapter.InsertCommand.CommandText = "INSERT INTO [txtimp] ([codedname], [drawdate], [rptdate], [specno], [ABR], [testname], [result], [flag], [low], [high], [Category21], [Default], [Units], [DefaultOpt], [F15]) VALUES (@codedname, @drawdate, @rptdate, @specno, @ABR, @testname, @result, @flag, @low, @high, @Category21, @Default, @Units, @DefaultOpt, @F15)";
		_adapter.InsertCommand.CommandType = CommandType.Text;
		_adapter.InsertCommand.Parameters.Add(new SqlParameter("@codedname", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte)0, (byte)0, "codedname", DataRowVersion.Current, false, (object)null, "", "", ""));
		_adapter.InsertCommand.Parameters.Add(new SqlParameter("@drawdate", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte)0, (byte)0, "drawdate", DataRowVersion.Current, false, (object)null, "", "", ""));
		_adapter.InsertCommand.Parameters.Add(new SqlParameter("@rptdate", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte)0, (byte)0, "rptdate", DataRowVersion.Current, false, (object)null, "", "", ""));
		_adapter.InsertCommand.Parameters.Add(new SqlParameter("@specno", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte)0, (byte)0, "specno", DataRowVersion.Current, false, (object)null, "", "", ""));
		_adapter.InsertCommand.Parameters.Add(new SqlParameter("@ABR", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte)0, (byte)0, "ABR", DataRowVersion.Current, false, (object)null, "", "", ""));
		_adapter.InsertCommand.Parameters.Add(new SqlParameter("@testname", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte)0, (byte)0, "testname", DataRowVersion.Current, false, (object)null, "", "", ""));
		_adapter.InsertCommand.Parameters.Add(new SqlParameter("@result", SqlDbType.Float, 0, ParameterDirection.Input, (byte)0, (byte)0, "result", DataRowVersion.Current, false, (object)null, "", "", ""));
		_adapter.InsertCommand.Parameters.Add(new SqlParameter("@flag", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte)0, (byte)0, "flag", DataRowVersion.Current, false, (object)null, "", "", ""));
		_adapter.InsertCommand.Parameters.Add(new SqlParameter("@low", SqlDbType.Float, 0, ParameterDirection.Input, (byte)0, (byte)0, "low", DataRowVersion.Current, false, (object)null, "", "", ""));
		_adapter.InsertCommand.Parameters.Add(new SqlParameter("@high", SqlDbType.Float, 0, ParameterDirection.Input, (byte)0, (byte)0, "high", DataRowVersion.Current, false, (object)null, "", "", ""));
		_adapter.InsertCommand.Parameters.Add(new SqlParameter("@Category21", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte)0, (byte)0, "Category21", DataRowVersion.Current, false, (object)null, "", "", ""));
		_adapter.InsertCommand.Parameters.Add(new SqlParameter("@Default", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte)0, (byte)0, "Default", DataRowVersion.Current, false, (object)null, "", "", ""));
		_adapter.InsertCommand.Parameters.Add(new SqlParameter("@Units", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte)0, (byte)0, "Units", DataRowVersion.Current, false, (object)null, "", "", ""));
		_adapter.InsertCommand.Parameters.Add(new SqlParameter("@DefaultOpt", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte)0, (byte)0, "DefaultOpt", DataRowVersion.Current, false, (object)null, "", "", ""));
		_adapter.InsertCommand.Parameters.Add(new SqlParameter("@F15", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte)0, (byte)0, "F15", DataRowVersion.Current, false, (object)null, "", "", ""));
		_adapter.UpdateCommand = new SqlCommand();
		_adapter.UpdateCommand.Connection = Connection;
		_adapter.UpdateCommand.CommandText = "UPDATE [txtimp] SET [codedname] = @codedname, [drawdate] = @drawdate, [rptdate] = @rptdate, [specno] = @specno, [ABR] = @ABR, [testname] = @testname, [result] = @result, [flag] = @flag, [low] = @low, [high] = @high, [Category21] = @Category21, [Default] = @Default, [Units] = @Units, [DefaultOpt] = @DefaultOpt, [F15] = @F15 WHERE (([ABR] = @Original_ABR))";
		_adapter.UpdateCommand.CommandType = CommandType.Text;
		_adapter.UpdateCommand.Parameters.Add(new SqlParameter("@codedname", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte)0, (byte)0, "codedname", DataRowVersion.Current, false, (object)null, "", "", ""));
		_adapter.UpdateCommand.Parameters.Add(new SqlParameter("@drawdate", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte)0, (byte)0, "drawdate", DataRowVersion.Current, false, (object)null, "", "", ""));
		_adapter.UpdateCommand.Parameters.Add(new SqlParameter("@rptdate", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte)0, (byte)0, "rptdate", DataRowVersion.Current, false, (object)null, "", "", ""));
		_adapter.UpdateCommand.Parameters.Add(new SqlParameter("@specno", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte)0, (byte)0, "specno", DataRowVersion.Current, false, (object)null, "", "", ""));
		_adapter.UpdateCommand.Parameters.Add(new SqlParameter("@ABR", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte)0, (byte)0, "ABR", DataRowVersion.Current, false, (object)null, "", "", ""));
		_adapter.UpdateCommand.Parameters.Add(new SqlParameter("@testname", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte)0, (byte)0, "testname", DataRowVersion.Current, false, (object)null, "", "", ""));
		_adapter.UpdateCommand.Parameters.Add(new SqlParameter("@result", SqlDbType.Float, 0, ParameterDirection.Input, (byte)0, (byte)0, "result", DataRowVersion.Current, false, (object)null, "", "", ""));
		_adapter.UpdateCommand.Parameters.Add(new SqlParameter("@flag", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte)0, (byte)0, "flag", DataRowVersion.Current, false, (object)null, "", "", ""));
		_adapter.UpdateCommand.Parameters.Add(new SqlParameter("@low", SqlDbType.Float, 0, ParameterDirection.Input, (byte)0, (byte)0, "low", DataRowVersion.Current, false, (object)null, "", "", ""));
		_adapter.UpdateCommand.Parameters.Add(new SqlParameter("@high", SqlDbType.Float, 0, ParameterDirection.Input, (byte)0, (byte)0, "high", DataRowVersion.Current, false, (object)null, "", "", ""));
		_adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Category21", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte)0, (byte)0, "Category21", DataRowVersion.Current, false, (object)null, "", "", ""));
		_adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Default", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte)0, (byte)0, "Default", DataRowVersion.Current, false, (object)null, "", "", ""));
		_adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Units", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte)0, (byte)0, "Units", DataRowVersion.Current, false, (object)null, "", "", ""));
		_adapter.UpdateCommand.Parameters.Add(new SqlParameter("@DefaultOpt", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte)0, (byte)0, "DefaultOpt", DataRowVersion.Current, false, (object)null, "", "", ""));
		_adapter.UpdateCommand.Parameters.Add(new SqlParameter("@F15", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte)0, (byte)0, "F15", DataRowVersion.Current, false, (object)null, "", "", ""));
		_adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_ABR", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte)0, (byte)0, "ABR", DataRowVersion.Original, false, (object)null, "", "", ""));
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
		//IL_00c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cd: Expected Obj, but got Unknown
		//IL_0105: Unknown result type (might be due to invalid IL or missing references)
		//IL_010f: Expected Obj, but got Unknown
		//IL_0147: Unknown result type (might be due to invalid IL or missing references)
		//IL_0151: Expected Obj, but got Unknown
		//IL_0189: Unknown result type (might be due to invalid IL or missing references)
		//IL_0193: Expected Obj, but got Unknown
		//IL_01cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d5: Expected Obj, but got Unknown
		//IL_020d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0217: Expected Obj, but got Unknown
		//IL_024a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0254: Expected Obj, but got Unknown
		//IL_028c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0296: Expected Obj, but got Unknown
		//IL_02c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d3: Expected Obj, but got Unknown
		//IL_0306: Unknown result type (might be due to invalid IL or missing references)
		//IL_0310: Expected Obj, but got Unknown
		//IL_0348: Unknown result type (might be due to invalid IL or missing references)
		//IL_0352: Expected Obj, but got Unknown
		//IL_038a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0394: Expected Obj, but got Unknown
		//IL_03cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d6: Expected Obj, but got Unknown
		//IL_040e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0418: Expected Obj, but got Unknown
		//IL_0450: Unknown result type (might be due to invalid IL or missing references)
		//IL_045a: Expected Obj, but got Unknown
		_commandCollection = new SqlCommand[2];
		_commandCollection[0] = new SqlCommand();
		_commandCollection[0].Connection = Connection;
		_commandCollection[0].CommandText = "SELECT        txtimp.*\r\nFROM            txtimp";
		_commandCollection[0].CommandType = CommandType.Text;
		_commandCollection[1] = new SqlCommand();
		_commandCollection[1].Connection = Connection;
		_commandCollection[1].CommandText = "INSERT INTO [txtimp] ([codedname], [drawdate], [rptdate], [specno], [ABR], [testname], [result], [flag], [low], [high], [Category21], [Default], [Units], [DefaultOpt], [F15]) VALUES (@codedname, @drawdate, @rptdate, @specno, @ABR, @testname, @result, @flag, @low, @high, @Category21, @Default, @Units, @DefaultOpt, @F15)";
		_commandCollection[1].CommandType = CommandType.Text;
		_commandCollection[1].Parameters.Add(new SqlParameter("@codedname", SqlDbType.NVarChar, 255, ParameterDirection.Input, (byte)0, (byte)0, "codedname", DataRowVersion.Current, false, (object)null, "", "", ""));
		_commandCollection[1].Parameters.Add(new SqlParameter("@drawdate", SqlDbType.NVarChar, 255, ParameterDirection.Input, (byte)0, (byte)0, "drawdate", DataRowVersion.Current, false, (object)null, "", "", ""));
		_commandCollection[1].Parameters.Add(new SqlParameter("@rptdate", SqlDbType.NVarChar, 255, ParameterDirection.Input, (byte)0, (byte)0, "rptdate", DataRowVersion.Current, false, (object)null, "", "", ""));
		_commandCollection[1].Parameters.Add(new SqlParameter("@specno", SqlDbType.NVarChar, 255, ParameterDirection.Input, (byte)0, (byte)0, "specno", DataRowVersion.Current, false, (object)null, "", "", ""));
		_commandCollection[1].Parameters.Add(new SqlParameter("@ABR", SqlDbType.NVarChar, 255, ParameterDirection.Input, (byte)0, (byte)0, "ABR", DataRowVersion.Current, false, (object)null, "", "", ""));
		_commandCollection[1].Parameters.Add(new SqlParameter("@testname", SqlDbType.NVarChar, 255, ParameterDirection.Input, (byte)0, (byte)0, "testname", DataRowVersion.Current, false, (object)null, "", "", ""));
		_commandCollection[1].Parameters.Add(new SqlParameter("@result", SqlDbType.Float, 8, ParameterDirection.Input, (byte)0, (byte)0, "result", DataRowVersion.Current, false, (object)null, "", "", ""));
		_commandCollection[1].Parameters.Add(new SqlParameter("@flag", SqlDbType.NVarChar, 255, ParameterDirection.Input, (byte)0, (byte)0, "flag", DataRowVersion.Current, false, (object)null, "", "", ""));
		_commandCollection[1].Parameters.Add(new SqlParameter("@low", SqlDbType.Float, 8, ParameterDirection.Input, (byte)0, (byte)0, "low", DataRowVersion.Current, false, (object)null, "", "", ""));
		_commandCollection[1].Parameters.Add(new SqlParameter("@high", SqlDbType.Float, 8, ParameterDirection.Input, (byte)0, (byte)0, "high", DataRowVersion.Current, false, (object)null, "", "", ""));
		_commandCollection[1].Parameters.Add(new SqlParameter("@Category21", SqlDbType.NVarChar, 255, ParameterDirection.Input, (byte)0, (byte)0, "Category21", DataRowVersion.Current, false, (object)null, "", "", ""));
		_commandCollection[1].Parameters.Add(new SqlParameter("@Default", SqlDbType.NVarChar, 255, ParameterDirection.Input, (byte)0, (byte)0, "Default", DataRowVersion.Current, false, (object)null, "", "", ""));
		_commandCollection[1].Parameters.Add(new SqlParameter("@Units", SqlDbType.NVarChar, 255, ParameterDirection.Input, (byte)0, (byte)0, "Units", DataRowVersion.Current, false, (object)null, "", "", ""));
		_commandCollection[1].Parameters.Add(new SqlParameter("@DefaultOpt", SqlDbType.NVarChar, 255, ParameterDirection.Input, (byte)0, (byte)0, "DefaultOpt", DataRowVersion.Current, false, (object)null, "", "", ""));
		_commandCollection[1].Parameters.Add(new SqlParameter("@F15", SqlDbType.NVarChar, 255, ParameterDirection.Input, (byte)0, (byte)0, "F15", DataRowVersion.Current, false, (object)null, "", "", ""));
	}

	[DebuggerNonUserCode]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	[HelpKeyword("vs.data.TableAdapter")]
	[DataObjectMethod(DataObjectMethodType.Fill, true)]
	public virtual int Fill(textref.txtimpDataTable dataTable)
	{
		Adapter.SelectCommand = CommandCollection[0];
		if (ClearBeforeFill)
		{
			dataTable.Clear();
		}
		return ((DbDataAdapter)(object)Adapter).Fill((DataTable)dataTable);
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	[DebuggerNonUserCode]
	[HelpKeyword("vs.data.TableAdapter")]
	[DataObjectMethod(DataObjectMethodType.Select, true)]
	public virtual textref.txtimpDataTable GetData()
	{
		Adapter.SelectCommand = CommandCollection[0];
		textref.txtimpDataTable txtimpDataTable = new textref.txtimpDataTable();
		((DbDataAdapter)(object)Adapter).Fill((DataTable)txtimpDataTable);
		return txtimpDataTable;
	}

	[DebuggerNonUserCode]
	[HelpKeyword("vs.data.TableAdapter")]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	public virtual int Update(textref.txtimpDataTable dataTable)
	{
		return ((DbDataAdapter)(object)Adapter).Update((DataTable)dataTable);
	}

	[HelpKeyword("vs.data.TableAdapter")]
	[DebuggerNonUserCode]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	public virtual int Update(textref dataSet)
	{
		return ((DbDataAdapter)(object)Adapter).Update((DataSet)dataSet, "txtimp");
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	[DebuggerNonUserCode]
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

	[DataObjectMethod(DataObjectMethodType.Delete, true)]
	[DebuggerNonUserCode]
	[HelpKeyword("vs.data.TableAdapter")]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	public virtual int Delete(string Original_ABR)
	{
		if (Original_ABR == null)
		{
			throw new ArgumentNullException("Original_ABR");
		}
		Adapter.DeleteCommand.Parameters[0].Value = Original_ABR;
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
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	[DataObjectMethod(DataObjectMethodType.Insert, true)]
	[DebuggerNonUserCode]
	public virtual int Insert(string codedname, string drawdate, string rptdate, string specno, string ABR, string testname, double? result, string flag, double? low, double? high, string Category21, string _Default, string Units, string DefaultOpt, string F15)
	{
		if (codedname == null)
		{
			Adapter.InsertCommand.Parameters[0].Value = DBNull.Value;
		}
		else
		{
			Adapter.InsertCommand.Parameters[0].Value = codedname;
		}
		if (drawdate == null)
		{
			Adapter.InsertCommand.Parameters[1].Value = DBNull.Value;
		}
		else
		{
			Adapter.InsertCommand.Parameters[1].Value = drawdate;
		}
		if (rptdate == null)
		{
			Adapter.InsertCommand.Parameters[2].Value = DBNull.Value;
		}
		else
		{
			Adapter.InsertCommand.Parameters[2].Value = rptdate;
		}
		if (specno == null)
		{
			Adapter.InsertCommand.Parameters[3].Value = DBNull.Value;
		}
		else
		{
			Adapter.InsertCommand.Parameters[3].Value = specno;
		}
		if (ABR == null)
		{
			throw new ArgumentNullException("ABR");
		}
		Adapter.InsertCommand.Parameters[4].Value = ABR;
		if (testname == null)
		{
			Adapter.InsertCommand.Parameters[5].Value = DBNull.Value;
		}
		else
		{
			Adapter.InsertCommand.Parameters[5].Value = testname;
		}
		if (result.HasValue)
		{
			Adapter.InsertCommand.Parameters[6].Value = result.Value;
		}
		else
		{
			Adapter.InsertCommand.Parameters[6].Value = DBNull.Value;
		}
		if (flag == null)
		{
			Adapter.InsertCommand.Parameters[7].Value = DBNull.Value;
		}
		else
		{
			Adapter.InsertCommand.Parameters[7].Value = flag;
		}
		if (low.HasValue)
		{
			Adapter.InsertCommand.Parameters[8].Value = low.Value;
		}
		else
		{
			Adapter.InsertCommand.Parameters[8].Value = DBNull.Value;
		}
		if (high.HasValue)
		{
			Adapter.InsertCommand.Parameters[9].Value = high.Value;
		}
		else
		{
			Adapter.InsertCommand.Parameters[9].Value = DBNull.Value;
		}
		if (Category21 == null)
		{
			Adapter.InsertCommand.Parameters[10].Value = DBNull.Value;
		}
		else
		{
			Adapter.InsertCommand.Parameters[10].Value = Category21;
		}
		if (_Default == null)
		{
			Adapter.InsertCommand.Parameters[11].Value = DBNull.Value;
		}
		else
		{
			Adapter.InsertCommand.Parameters[11].Value = _Default;
		}
		if (Units == null)
		{
			Adapter.InsertCommand.Parameters[12].Value = DBNull.Value;
		}
		else
		{
			Adapter.InsertCommand.Parameters[12].Value = Units;
		}
		if (DefaultOpt == null)
		{
			Adapter.InsertCommand.Parameters[13].Value = DBNull.Value;
		}
		else
		{
			Adapter.InsertCommand.Parameters[13].Value = DefaultOpt;
		}
		if (F15 == null)
		{
			Adapter.InsertCommand.Parameters[14].Value = DBNull.Value;
		}
		else
		{
			Adapter.InsertCommand.Parameters[14].Value = F15;
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
	[HelpKeyword("vs.data.TableAdapter")]
	[DebuggerNonUserCode]
	[DataObjectMethod(DataObjectMethodType.Update, true)]
	public virtual int Update(string codedname, string drawdate, string rptdate, string specno, string ABR, string testname, double? result, string flag, double? low, double? high, string Category21, string _Default, string Units, string DefaultOpt, string F15, string Original_ABR)
	{
		if (codedname == null)
		{
			Adapter.UpdateCommand.Parameters[0].Value = DBNull.Value;
		}
		else
		{
			Adapter.UpdateCommand.Parameters[0].Value = codedname;
		}
		if (drawdate == null)
		{
			Adapter.UpdateCommand.Parameters[1].Value = DBNull.Value;
		}
		else
		{
			Adapter.UpdateCommand.Parameters[1].Value = drawdate;
		}
		if (rptdate == null)
		{
			Adapter.UpdateCommand.Parameters[2].Value = DBNull.Value;
		}
		else
		{
			Adapter.UpdateCommand.Parameters[2].Value = rptdate;
		}
		if (specno == null)
		{
			Adapter.UpdateCommand.Parameters[3].Value = DBNull.Value;
		}
		else
		{
			Adapter.UpdateCommand.Parameters[3].Value = specno;
		}
		if (ABR == null)
		{
			throw new ArgumentNullException("ABR");
		}
		Adapter.UpdateCommand.Parameters[4].Value = ABR;
		if (testname == null)
		{
			Adapter.UpdateCommand.Parameters[5].Value = DBNull.Value;
		}
		else
		{
			Adapter.UpdateCommand.Parameters[5].Value = testname;
		}
		if (result.HasValue)
		{
			Adapter.UpdateCommand.Parameters[6].Value = result.Value;
		}
		else
		{
			Adapter.UpdateCommand.Parameters[6].Value = DBNull.Value;
		}
		if (flag == null)
		{
			Adapter.UpdateCommand.Parameters[7].Value = DBNull.Value;
		}
		else
		{
			Adapter.UpdateCommand.Parameters[7].Value = flag;
		}
		if (low.HasValue)
		{
			Adapter.UpdateCommand.Parameters[8].Value = low.Value;
		}
		else
		{
			Adapter.UpdateCommand.Parameters[8].Value = DBNull.Value;
		}
		if (high.HasValue)
		{
			Adapter.UpdateCommand.Parameters[9].Value = high.Value;
		}
		else
		{
			Adapter.UpdateCommand.Parameters[9].Value = DBNull.Value;
		}
		if (Category21 == null)
		{
			Adapter.UpdateCommand.Parameters[10].Value = DBNull.Value;
		}
		else
		{
			Adapter.UpdateCommand.Parameters[10].Value = Category21;
		}
		if (_Default == null)
		{
			Adapter.UpdateCommand.Parameters[11].Value = DBNull.Value;
		}
		else
		{
			Adapter.UpdateCommand.Parameters[11].Value = _Default;
		}
		if (Units == null)
		{
			Adapter.UpdateCommand.Parameters[12].Value = DBNull.Value;
		}
		else
		{
			Adapter.UpdateCommand.Parameters[12].Value = Units;
		}
		if (DefaultOpt == null)
		{
			Adapter.UpdateCommand.Parameters[13].Value = DBNull.Value;
		}
		else
		{
			Adapter.UpdateCommand.Parameters[13].Value = DefaultOpt;
		}
		if (F15 == null)
		{
			Adapter.UpdateCommand.Parameters[14].Value = DBNull.Value;
		}
		else
		{
			Adapter.UpdateCommand.Parameters[14].Value = F15;
		}
		if (Original_ABR == null)
		{
			throw new ArgumentNullException("Original_ABR");
		}
		Adapter.UpdateCommand.Parameters[15].Value = Original_ABR;
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

	[DataObjectMethod(DataObjectMethodType.Update, true)]
	[HelpKeyword("vs.data.TableAdapter")]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	[DebuggerNonUserCode]
	public virtual int Update(string codedname, string drawdate, string rptdate, string specno, string testname, double? result, string flag, double? low, double? high, string Category21, string _Default, string Units, string DefaultOpt, string F15, string Original_ABR)
	{
		return Update(codedname, drawdate, rptdate, specno, Original_ABR, testname, result, flag, low, high, Category21, _Default, Units, DefaultOpt, F15, Original_ABR);
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	[DebuggerNonUserCode]
	[HelpKeyword("vs.data.TableAdapter")]
	[DataObjectMethod(DataObjectMethodType.Insert, false)]
	public virtual int insertq(string codedname, string drawdate, string rptdate, string specno, string ABR, string testname, double? result, string flag, double? low, double? high, string Category21, string _Default, string Units, string DefaultOpt, string F15)
	{
		SqlCommand val = CommandCollection[1];
		if (codedname == null)
		{
			val.Parameters[0].Value = DBNull.Value;
		}
		else
		{
			val.Parameters[0].Value = codedname;
		}
		if (drawdate == null)
		{
			val.Parameters[1].Value = DBNull.Value;
		}
		else
		{
			val.Parameters[1].Value = drawdate;
		}
		if (rptdate == null)
		{
			val.Parameters[2].Value = DBNull.Value;
		}
		else
		{
			val.Parameters[2].Value = rptdate;
		}
		if (specno == null)
		{
			val.Parameters[3].Value = DBNull.Value;
		}
		else
		{
			val.Parameters[3].Value = specno;
		}
		if (ABR == null)
		{
			throw new ArgumentNullException("ABR");
		}
		val.Parameters[4].Value = ABR;
		if (testname == null)
		{
			val.Parameters[5].Value = DBNull.Value;
		}
		else
		{
			val.Parameters[5].Value = testname;
		}
		if (result.HasValue)
		{
			val.Parameters[6].Value = result.Value;
		}
		else
		{
			val.Parameters[6].Value = DBNull.Value;
		}
		if (flag == null)
		{
			val.Parameters[7].Value = DBNull.Value;
		}
		else
		{
			val.Parameters[7].Value = flag;
		}
		if (low.HasValue)
		{
			val.Parameters[8].Value = low.Value;
		}
		else
		{
			val.Parameters[8].Value = DBNull.Value;
		}
		if (high.HasValue)
		{
			val.Parameters[9].Value = high.Value;
		}
		else
		{
			val.Parameters[9].Value = DBNull.Value;
		}
		if (Category21 == null)
		{
			val.Parameters[10].Value = DBNull.Value;
		}
		else
		{
			val.Parameters[10].Value = Category21;
		}
		if (_Default == null)
		{
			val.Parameters[11].Value = DBNull.Value;
		}
		else
		{
			val.Parameters[11].Value = _Default;
		}
		if (Units == null)
		{
			val.Parameters[12].Value = DBNull.Value;
		}
		else
		{
			val.Parameters[12].Value = Units;
		}
		if (DefaultOpt == null)
		{
			val.Parameters[13].Value = DBNull.Value;
		}
		else
		{
			val.Parameters[13].Value = DefaultOpt;
		}
		if (F15 == null)
		{
			val.Parameters[14].Value = DBNull.Value;
		}
		else
		{
			val.Parameters[14].Value = F15;
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
