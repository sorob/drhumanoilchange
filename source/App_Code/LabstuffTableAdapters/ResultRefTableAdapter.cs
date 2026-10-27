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

namespace LabstuffTableAdapters;

[DesignerCategory("code")]
[Designer("Microsoft.VSDesigner.DataSource.Design.TableAdapterDesigner, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
[ToolboxItem(true)]
[HelpKeyword("vs.data.TableAdapter")]
[DataObject(true)]
public class ResultRefTableAdapter : Component
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

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	[DebuggerNonUserCode]
	public ResultRefTableAdapter()
	{
		ClearBeforeFill = true;
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	[DebuggerNonUserCode]
	private void InitAdapter()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected Obj, but got Unknown
		//IL_0173: Unknown result type (might be due to invalid IL or missing references)
		//IL_017d: Expected Obj, but got Unknown
		//IL_01ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f9: Expected Obj, but got Unknown
		//IL_022f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0239: Expected Obj, but got Unknown
		//IL_0240: Unknown result type (might be due to invalid IL or missing references)
		//IL_024a: Expected Obj, but got Unknown
		//IL_02bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c5: Expected Obj, but got Unknown
		//IL_02fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0305: Expected Obj, but got Unknown
		//IL_033c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0346: Expected Obj, but got Unknown
		//IL_037c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0386: Expected Obj, but got Unknown
		//IL_03bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c6: Expected Obj, but got Unknown
		//IL_03fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0406: Expected Obj, but got Unknown
		//IL_043c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0446: Expected Obj, but got Unknown
		//IL_047d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0487: Expected Obj, but got Unknown
		//IL_04bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_04c7: Expected Obj, but got Unknown
		//IL_04fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0507: Expected Obj, but got Unknown
		//IL_053d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0547: Expected Obj, but got Unknown
		//IL_057d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0587: Expected Obj, but got Unknown
		//IL_05bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_05c7: Expected Obj, but got Unknown
		//IL_05ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_05d8: Expected Obj, but got Unknown
		//IL_0649: Unknown result type (might be due to invalid IL or missing references)
		//IL_0653: Expected Obj, but got Unknown
		//IL_0689: Unknown result type (might be due to invalid IL or missing references)
		//IL_0693: Expected Obj, but got Unknown
		//IL_06ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_06d4: Expected Obj, but got Unknown
		//IL_070a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0714: Expected Obj, but got Unknown
		//IL_074a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0754: Expected Obj, but got Unknown
		//IL_078a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0794: Expected Obj, but got Unknown
		//IL_07ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_07d4: Expected Obj, but got Unknown
		//IL_080b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0815: Expected Obj, but got Unknown
		//IL_084b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0855: Expected Obj, but got Unknown
		//IL_088b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0895: Expected Obj, but got Unknown
		//IL_08cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_08d5: Expected Obj, but got Unknown
		//IL_090b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0915: Expected Obj, but got Unknown
		//IL_094b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0955: Expected Obj, but got Unknown
		//IL_098c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0996: Expected Obj, but got Unknown
		//IL_09cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_09d6: Expected Obj, but got Unknown
		_adapter = new SqlDataAdapter();
		DataTableMapping dataTableMapping = new DataTableMapping();
		dataTableMapping.SourceTable = "Table";
		dataTableMapping.DataSetTable = "ResultRef";
		dataTableMapping.ColumnMappings.Add("Result", "Result");
		dataTableMapping.ColumnMappings.Add("rid", "rid");
		dataTableMapping.ColumnMappings.Add("TestAbrev", "TestAbrev");
		dataTableMapping.ColumnMappings.Add("MedLow", "MedLow");
		dataTableMapping.ColumnMappings.Add("MedHigh", "MedHigh");
		dataTableMapping.ColumnMappings.Add("Medopt", "Medopt");
		dataTableMapping.ColumnMappings.Add("MedScale", "MedScale");
		dataTableMapping.ColumnMappings.Add("UserName", "UserName");
		dataTableMapping.ColumnMappings.Add("DocLow", "DocLow");
		dataTableMapping.ColumnMappings.Add("DocOpt", "DocOpt");
		dataTableMapping.ColumnMappings.Add("DocHigh", "DocHigh");
		dataTableMapping.ColumnMappings.Add("DocScale", "DocScale");
		dataTableMapping.ColumnMappings.Add("Testid", "Testid");
		dataTableMapping.ColumnMappings.Add("RRefindex", "RRefindex");
		((DataAdapter)(object)_adapter).TableMappings.Add(dataTableMapping);
		_adapter.DeleteCommand = new SqlCommand();
		_adapter.DeleteCommand.Connection = Connection;
		_adapter.DeleteCommand.CommandText = "DELETE FROM [ResultRef] WHERE (([TestAbrev] = @Original_TestAbrev) AND ([Testid] = @Original_Testid))";
		_adapter.DeleteCommand.CommandType = CommandType.Text;
		_adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_TestAbrev", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte)0, (byte)0, "TestAbrev", DataRowVersion.Original, false, (object)null, "", "", ""));
		_adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_Testid", SqlDbType.Int, 0, ParameterDirection.Input, (byte)0, (byte)0, "Testid", DataRowVersion.Original, false, (object)null, "", "", ""));
		_adapter.InsertCommand = new SqlCommand();
		_adapter.InsertCommand.Connection = Connection;
		_adapter.InsertCommand.CommandText = "INSERT INTO [ResultRef] ([Result], [rid], [TestAbrev], [MedLow], [MedHigh], [Medopt], [MedScale], [UserName], [DocLow], [DocOpt], [DocHigh], [DocScale], [Testid]) VALUES (@Result, @rid, @TestAbrev, @MedLow, @MedHigh, @Medopt, @MedScale, @UserName, @DocLow, @DocOpt, @DocHigh, @DocScale, @Testid)";
		_adapter.InsertCommand.CommandType = CommandType.Text;
		_adapter.InsertCommand.Parameters.Add(new SqlParameter("@Result", SqlDbType.Float, 0, ParameterDirection.Input, (byte)0, (byte)0, "Result", DataRowVersion.Current, false, (object)null, "", "", ""));
		_adapter.InsertCommand.Parameters.Add(new SqlParameter("@rid", SqlDbType.Int, 0, ParameterDirection.Input, (byte)0, (byte)0, "rid", DataRowVersion.Current, false, (object)null, "", "", ""));
		_adapter.InsertCommand.Parameters.Add(new SqlParameter("@TestAbrev", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte)0, (byte)0, "TestAbrev", DataRowVersion.Current, false, (object)null, "", "", ""));
		_adapter.InsertCommand.Parameters.Add(new SqlParameter("@MedLow", SqlDbType.Float, 0, ParameterDirection.Input, (byte)0, (byte)0, "MedLow", DataRowVersion.Current, false, (object)null, "", "", ""));
		_adapter.InsertCommand.Parameters.Add(new SqlParameter("@MedHigh", SqlDbType.Float, 0, ParameterDirection.Input, (byte)0, (byte)0, "MedHigh", DataRowVersion.Current, false, (object)null, "", "", ""));
		_adapter.InsertCommand.Parameters.Add(new SqlParameter("@Medopt", SqlDbType.Float, 0, ParameterDirection.Input, (byte)0, (byte)0, "Medopt", DataRowVersion.Current, false, (object)null, "", "", ""));
		_adapter.InsertCommand.Parameters.Add(new SqlParameter("@MedScale", SqlDbType.Float, 0, ParameterDirection.Input, (byte)0, (byte)0, "MedScale", DataRowVersion.Current, false, (object)null, "", "", ""));
		_adapter.InsertCommand.Parameters.Add(new SqlParameter("@UserName", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte)0, (byte)0, "UserName", DataRowVersion.Current, false, (object)null, "", "", ""));
		_adapter.InsertCommand.Parameters.Add(new SqlParameter("@DocLow", SqlDbType.Float, 0, ParameterDirection.Input, (byte)0, (byte)0, "DocLow", DataRowVersion.Current, false, (object)null, "", "", ""));
		_adapter.InsertCommand.Parameters.Add(new SqlParameter("@DocOpt", SqlDbType.Float, 0, ParameterDirection.Input, (byte)0, (byte)0, "DocOpt", DataRowVersion.Current, false, (object)null, "", "", ""));
		_adapter.InsertCommand.Parameters.Add(new SqlParameter("@DocHigh", SqlDbType.Float, 0, ParameterDirection.Input, (byte)0, (byte)0, "DocHigh", DataRowVersion.Current, false, (object)null, "", "", ""));
		_adapter.InsertCommand.Parameters.Add(new SqlParameter("@DocScale", SqlDbType.Float, 0, ParameterDirection.Input, (byte)0, (byte)0, "DocScale", DataRowVersion.Current, false, (object)null, "", "", ""));
		_adapter.InsertCommand.Parameters.Add(new SqlParameter("@Testid", SqlDbType.Int, 0, ParameterDirection.Input, (byte)0, (byte)0, "Testid", DataRowVersion.Current, false, (object)null, "", "", ""));
		_adapter.UpdateCommand = new SqlCommand();
		_adapter.UpdateCommand.Connection = Connection;
		_adapter.UpdateCommand.CommandText = "UPDATE [ResultRef] SET [Result] = @Result, [rid] = @rid, [TestAbrev] = @TestAbrev, [MedLow] = @MedLow, [MedHigh] = @MedHigh, [Medopt] = @Medopt, [MedScale] = @MedScale, [UserName] = @UserName, [DocLow] = @DocLow, [DocOpt] = @DocOpt, [DocHigh] = @DocHigh, [DocScale] = @DocScale, [Testid] = @Testid WHERE (([TestAbrev] = @Original_TestAbrev) AND ([Testid] = @Original_Testid))";
		_adapter.UpdateCommand.CommandType = CommandType.Text;
		_adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Result", SqlDbType.Float, 0, ParameterDirection.Input, (byte)0, (byte)0, "Result", DataRowVersion.Current, false, (object)null, "", "", ""));
		_adapter.UpdateCommand.Parameters.Add(new SqlParameter("@rid", SqlDbType.Int, 0, ParameterDirection.Input, (byte)0, (byte)0, "rid", DataRowVersion.Current, false, (object)null, "", "", ""));
		_adapter.UpdateCommand.Parameters.Add(new SqlParameter("@TestAbrev", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte)0, (byte)0, "TestAbrev", DataRowVersion.Current, false, (object)null, "", "", ""));
		_adapter.UpdateCommand.Parameters.Add(new SqlParameter("@MedLow", SqlDbType.Float, 0, ParameterDirection.Input, (byte)0, (byte)0, "MedLow", DataRowVersion.Current, false, (object)null, "", "", ""));
		_adapter.UpdateCommand.Parameters.Add(new SqlParameter("@MedHigh", SqlDbType.Float, 0, ParameterDirection.Input, (byte)0, (byte)0, "MedHigh", DataRowVersion.Current, false, (object)null, "", "", ""));
		_adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Medopt", SqlDbType.Float, 0, ParameterDirection.Input, (byte)0, (byte)0, "Medopt", DataRowVersion.Current, false, (object)null, "", "", ""));
		_adapter.UpdateCommand.Parameters.Add(new SqlParameter("@MedScale", SqlDbType.Float, 0, ParameterDirection.Input, (byte)0, (byte)0, "MedScale", DataRowVersion.Current, false, (object)null, "", "", ""));
		_adapter.UpdateCommand.Parameters.Add(new SqlParameter("@UserName", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte)0, (byte)0, "UserName", DataRowVersion.Current, false, (object)null, "", "", ""));
		_adapter.UpdateCommand.Parameters.Add(new SqlParameter("@DocLow", SqlDbType.Float, 0, ParameterDirection.Input, (byte)0, (byte)0, "DocLow", DataRowVersion.Current, false, (object)null, "", "", ""));
		_adapter.UpdateCommand.Parameters.Add(new SqlParameter("@DocOpt", SqlDbType.Float, 0, ParameterDirection.Input, (byte)0, (byte)0, "DocOpt", DataRowVersion.Current, false, (object)null, "", "", ""));
		_adapter.UpdateCommand.Parameters.Add(new SqlParameter("@DocHigh", SqlDbType.Float, 0, ParameterDirection.Input, (byte)0, (byte)0, "DocHigh", DataRowVersion.Current, false, (object)null, "", "", ""));
		_adapter.UpdateCommand.Parameters.Add(new SqlParameter("@DocScale", SqlDbType.Float, 0, ParameterDirection.Input, (byte)0, (byte)0, "DocScale", DataRowVersion.Current, false, (object)null, "", "", ""));
		_adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Testid", SqlDbType.Int, 0, ParameterDirection.Input, (byte)0, (byte)0, "Testid", DataRowVersion.Current, false, (object)null, "", "", ""));
		_adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_TestAbrev", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte)0, (byte)0, "TestAbrev", DataRowVersion.Original, false, (object)null, "", "", ""));
		_adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_Testid", SqlDbType.Int, 0, ParameterDirection.Input, (byte)0, (byte)0, "Testid", DataRowVersion.Original, false, (object)null, "", "", ""));
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
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Expected Obj, but got Unknown
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Expected Obj, but got Unknown
		//IL_00c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cb: Expected Obj, but got Unknown
		//IL_00fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0108: Expected Obj, but got Unknown
		//IL_0110: Unknown result type (might be due to invalid IL or missing references)
		//IL_0116: Expected Obj, but got Unknown
		//IL_017b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0185: Expected Obj, but got Unknown
		//IL_01ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c4: Expected Obj, but got Unknown
		//IL_01cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d2: Expected Obj, but got Unknown
		//IL_0237: Unknown result type (might be due to invalid IL or missing references)
		//IL_0241: Expected Obj, but got Unknown
		//IL_0249: Unknown result type (might be due to invalid IL or missing references)
		//IL_024f: Expected Obj, but got Unknown
		//IL_02b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c0: Expected Obj, but got Unknown
		//IL_02f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_02fd: Expected Obj, but got Unknown
		//IL_0305: Unknown result type (might be due to invalid IL or missing references)
		//IL_030b: Expected Obj, but got Unknown
		//IL_036d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0377: Expected Obj, but got Unknown
		//IL_03a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b2: Expected Obj, but got Unknown
		//IL_03e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ec: Expected Obj, but got Unknown
		//IL_041d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0427: Expected Obj, but got Unknown
		//IL_0458: Unknown result type (might be due to invalid IL or missing references)
		//IL_0462: Expected Obj, but got Unknown
		//IL_0493: Unknown result type (might be due to invalid IL or missing references)
		//IL_049d: Expected Obj, but got Unknown
		//IL_04ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_04d8: Expected Obj, but got Unknown
		//IL_0509: Unknown result type (might be due to invalid IL or missing references)
		//IL_0513: Expected Obj, but got Unknown
		//IL_0547: Unknown result type (might be due to invalid IL or missing references)
		//IL_0551: Expected Obj, but got Unknown
		//IL_0582: Unknown result type (might be due to invalid IL or missing references)
		//IL_058c: Expected Obj, but got Unknown
		//IL_05bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_05c7: Expected Obj, but got Unknown
		//IL_05f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0602: Expected Obj, but got Unknown
		//IL_0633: Unknown result type (might be due to invalid IL or missing references)
		//IL_063d: Expected Obj, but got Unknown
		//IL_066d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0677: Expected Obj, but got Unknown
		//IL_067f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0685: Expected Obj, but got Unknown
		//IL_06ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_06f9: Expected Obj, but got Unknown
		//IL_0701: Unknown result type (might be due to invalid IL or missing references)
		//IL_0707: Expected Obj, but got Unknown
		//IL_076c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0776: Expected Obj, but got Unknown
		//IL_07a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_07b3: Expected Obj, but got Unknown
		//IL_07e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_07f0: Expected Obj, but got Unknown
		//IL_0823: Unknown result type (might be due to invalid IL or missing references)
		//IL_082d: Expected Obj, but got Unknown
		//IL_0860: Unknown result type (might be due to invalid IL or missing references)
		//IL_086a: Expected Obj, but got Unknown
		//IL_08a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_08ac: Expected Obj, but got Unknown
		//IL_08df: Unknown result type (might be due to invalid IL or missing references)
		//IL_08e9: Expected Obj, but got Unknown
		//IL_091c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0926: Expected Obj, but got Unknown
		//IL_0959: Unknown result type (might be due to invalid IL or missing references)
		//IL_0963: Expected Obj, but got Unknown
		//IL_0996: Unknown result type (might be due to invalid IL or missing references)
		//IL_09a0: Expected Obj, but got Unknown
		//IL_09d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_09df: Expected Obj, but got Unknown
		//IL_0a12: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a1c: Expected Obj, but got Unknown
		//IL_0a24: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a2a: Expected Obj, but got Unknown
		//IL_0a8f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a99: Expected Obj, but got Unknown
		//IL_0acc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ad6: Expected Obj, but got Unknown
		//IL_0b09: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b13: Expected Obj, but got Unknown
		//IL_0b46: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b50: Expected Obj, but got Unknown
		//IL_0b83: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b8d: Expected Obj, but got Unknown
		//IL_0bc0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bca: Expected Obj, but got Unknown
		//IL_0bfd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c07: Expected Obj, but got Unknown
		//IL_0c3a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c44: Expected Obj, but got Unknown
		//IL_0c77: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c81: Expected Obj, but got Unknown
		//IL_0cb4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cbe: Expected Obj, but got Unknown
		//IL_0cf6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d00: Expected Obj, but got Unknown
		//IL_0d33: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d3d: Expected Obj, but got Unknown
		//IL_0d72: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d7c: Expected Obj, but got Unknown
		_commandCollection = new SqlCommand[9];
		_commandCollection[0] = new SqlCommand();
		_commandCollection[0].Connection = Connection;
		_commandCollection[0].CommandText = "SELECT     Result, rid, TestAbrev, MedLow, MedHigh, Medopt, MedScale, UserName, DocLow, DocOpt, DocHigh, DocScale, Testid, RRefindex\r\nFROM         ResultRef";
		_commandCollection[0].CommandType = CommandType.Text;
		_commandCollection[1] = new SqlCommand();
		_commandCollection[1].Connection = Connection;
		_commandCollection[1].CommandText = "DELETE FROM ResultRef WHERE (TestAbrev = @testabrev) AND (Testid = @testid)";
		_commandCollection[1].CommandType = CommandType.Text;
		_commandCollection[1].Parameters.Add(new SqlParameter("@testabrev", SqlDbType.NVarChar, 50, ParameterDirection.Input, (byte)0, (byte)0, "TestAbrev", DataRowVersion.Original, false, (object)null, "", "", ""));
		_commandCollection[1].Parameters.Add(new SqlParameter("@testid", SqlDbType.Int, 4, ParameterDirection.Input, (byte)0, (byte)0, "Testid", DataRowVersion.Original, false, (object)null, "", "", ""));
		_commandCollection[2] = new SqlCommand();
		_commandCollection[2].Connection = Connection;
		_commandCollection[2].CommandText = "SELECT Result, rid, TestAbrev, MedLow, MedHigh, Medopt, MedScale, UserName, DocLow, DocOpt, DocHigh, DocScale, Testid, RRefindex FROM ResultRef WHERE (Testid = @TestId) AND (TestAbrev = @TestAbrev)";
		_commandCollection[2].CommandType = CommandType.Text;
		_commandCollection[2].Parameters.Add(new SqlParameter("@TestId", SqlDbType.Int, 4, ParameterDirection.Input, (byte)0, (byte)0, "Testid", DataRowVersion.Current, false, (object)null, "", "", ""));
		_commandCollection[2].Parameters.Add(new SqlParameter("@TestAbrev", SqlDbType.NVarChar, 50, ParameterDirection.Input, (byte)0, (byte)0, "TestAbrev", DataRowVersion.Current, false, (object)null, "", "", ""));
		_commandCollection[3] = new SqlCommand();
		_commandCollection[3].Connection = Connection;
		_commandCollection[3].CommandText = "SELECT Result, rid, TestAbrev, MedLow, MedHigh, Medopt, MedScale, UserName, DocLow, DocHigh, DocOpt, DocScale, Testid FROM ResultRef WHERE (Testid = @Testid)";
		_commandCollection[3].CommandType = CommandType.Text;
		_commandCollection[3].Parameters.Add(new SqlParameter("@Testid", SqlDbType.Int, 4, ParameterDirection.Input, (byte)0, (byte)0, "Testid", DataRowVersion.Current, false, (object)null, "", "", ""));
		_commandCollection[4] = new SqlCommand();
		_commandCollection[4].Connection = Connection;
		_commandCollection[4].CommandText = "SELECT Result FROM ResultRef WHERE (TestAbrev = @TestAbrev) AND (Testid = @Testid)";
		_commandCollection[4].CommandType = CommandType.Text;
		_commandCollection[4].Parameters.Add(new SqlParameter("@TestAbrev", SqlDbType.NVarChar, 50, ParameterDirection.Input, (byte)0, (byte)0, "TestAbrev", DataRowVersion.Current, false, (object)null, "", "", ""));
		_commandCollection[4].Parameters.Add(new SqlParameter("@Testid", SqlDbType.Int, 4, ParameterDirection.Input, (byte)0, (byte)0, "Testid", DataRowVersion.Current, false, (object)null, "", "", ""));
		_commandCollection[5] = new SqlCommand();
		_commandCollection[5].Connection = Connection;
		_commandCollection[5].CommandText = "addEdit";
		_commandCollection[5].CommandType = CommandType.StoredProcedure;
		_commandCollection[5].Parameters.Add(new SqlParameter("@RETURN_VALUE", SqlDbType.Int, 4, ParameterDirection.ReturnValue, (byte)10, (byte)0, (string)null, DataRowVersion.Current, false, (object)null, "", "", ""));
		_commandCollection[5].Parameters.Add(new SqlParameter("@Result", SqlDbType.Real, 4, ParameterDirection.Input, (byte)24, (byte)0, (string)null, DataRowVersion.Current, false, (object)null, "", "", ""));
		_commandCollection[5].Parameters.Add(new SqlParameter("@rid", SqlDbType.Int, 4, ParameterDirection.Input, (byte)10, (byte)0, (string)null, DataRowVersion.Current, false, (object)null, "", "", ""));
		_commandCollection[5].Parameters.Add(new SqlParameter("@TestAbrev", SqlDbType.NVarChar, 50, ParameterDirection.Input, (byte)0, (byte)0, (string)null, DataRowVersion.Current, false, (object)null, "", "", ""));
		_commandCollection[5].Parameters.Add(new SqlParameter("@MedLow", SqlDbType.Real, 4, ParameterDirection.Input, (byte)24, (byte)0, (string)null, DataRowVersion.Current, false, (object)null, "", "", ""));
		_commandCollection[5].Parameters.Add(new SqlParameter("@MedHigh", SqlDbType.Real, 4, ParameterDirection.Input, (byte)24, (byte)0, (string)null, DataRowVersion.Current, false, (object)null, "", "", ""));
		_commandCollection[5].Parameters.Add(new SqlParameter("@Medopt", SqlDbType.Real, 4, ParameterDirection.Input, (byte)24, (byte)0, (string)null, DataRowVersion.Current, false, (object)null, "", "", ""));
		_commandCollection[5].Parameters.Add(new SqlParameter("@MedScale", SqlDbType.Real, 4, ParameterDirection.Input, (byte)24, (byte)0, (string)null, DataRowVersion.Current, false, (object)null, "", "", ""));
		_commandCollection[5].Parameters.Add(new SqlParameter("@UserName", SqlDbType.NVarChar, 256, ParameterDirection.Input, (byte)0, (byte)0, (string)null, DataRowVersion.Current, false, (object)null, "", "", ""));
		_commandCollection[5].Parameters.Add(new SqlParameter("@DocLow", SqlDbType.Real, 4, ParameterDirection.Input, (byte)24, (byte)0, (string)null, DataRowVersion.Current, false, (object)null, "", "", ""));
		_commandCollection[5].Parameters.Add(new SqlParameter("@DocOpt", SqlDbType.Real, 4, ParameterDirection.Input, (byte)24, (byte)0, (string)null, DataRowVersion.Current, false, (object)null, "", "", ""));
		_commandCollection[5].Parameters.Add(new SqlParameter("@DocHigh", SqlDbType.Real, 4, ParameterDirection.Input, (byte)24, (byte)0, (string)null, DataRowVersion.Current, false, (object)null, "", "", ""));
		_commandCollection[5].Parameters.Add(new SqlParameter("@DocScale", SqlDbType.Real, 4, ParameterDirection.Input, (byte)24, (byte)0, (string)null, DataRowVersion.Current, false, (object)null, "", "", ""));
		_commandCollection[5].Parameters.Add(new SqlParameter("@Testid", SqlDbType.Int, 4, ParameterDirection.Input, (byte)10, (byte)0, (string)null, DataRowVersion.Current, false, (object)null, "", "", ""));
		_commandCollection[6] = new SqlCommand();
		_commandCollection[6].Connection = Connection;
		_commandCollection[6].CommandText = "SELECT COUNT(*) AS totallabs FROM ResultRef WHERE (UserName = @username)";
		_commandCollection[6].CommandType = CommandType.Text;
		_commandCollection[6].Parameters.Add(new SqlParameter("@username", SqlDbType.NVarChar, 256, ParameterDirection.Input, (byte)0, (byte)0, "UserName", DataRowVersion.Current, false, (object)null, "", "", ""));
		_commandCollection[7] = new SqlCommand();
		_commandCollection[7].Connection = Connection;
		_commandCollection[7].CommandText = "UPDATE ResultRef SET Result = @Result, MedLow = @MedLow, MedHigh = @MedHigh, Medopt = @Medopt, MedScale = @MedScale, UserName = @UserName, DocLow = @DocLow, DocOpt = @DocOpt, DocHigh = @DocHigh, DocScale = @DocScale WHERE (TestAbrev = @TestAbrev) AND (Testid = @Testid)";
		_commandCollection[7].CommandType = CommandType.Text;
		_commandCollection[7].Parameters.Add(new SqlParameter("@Result", SqlDbType.Float, 8, ParameterDirection.Input, (byte)0, (byte)0, "Result", DataRowVersion.Current, false, (object)null, "", "", ""));
		_commandCollection[7].Parameters.Add(new SqlParameter("@MedLow", SqlDbType.Float, 8, ParameterDirection.Input, (byte)0, (byte)0, "MedLow", DataRowVersion.Current, false, (object)null, "", "", ""));
		_commandCollection[7].Parameters.Add(new SqlParameter("@MedHigh", SqlDbType.Float, 8, ParameterDirection.Input, (byte)0, (byte)0, "MedHigh", DataRowVersion.Current, false, (object)null, "", "", ""));
		_commandCollection[7].Parameters.Add(new SqlParameter("@Medopt", SqlDbType.Float, 8, ParameterDirection.Input, (byte)0, (byte)0, "Medopt", DataRowVersion.Current, false, (object)null, "", "", ""));
		_commandCollection[7].Parameters.Add(new SqlParameter("@MedScale", SqlDbType.Float, 8, ParameterDirection.Input, (byte)0, (byte)0, "MedScale", DataRowVersion.Current, false, (object)null, "", "", ""));
		_commandCollection[7].Parameters.Add(new SqlParameter("@UserName", SqlDbType.NVarChar, 256, ParameterDirection.Input, (byte)0, (byte)0, "UserName", DataRowVersion.Current, false, (object)null, "", "", ""));
		_commandCollection[7].Parameters.Add(new SqlParameter("@DocLow", SqlDbType.Float, 8, ParameterDirection.Input, (byte)0, (byte)0, "DocLow", DataRowVersion.Current, false, (object)null, "", "", ""));
		_commandCollection[7].Parameters.Add(new SqlParameter("@DocOpt", SqlDbType.Float, 8, ParameterDirection.Input, (byte)0, (byte)0, "DocOpt", DataRowVersion.Current, false, (object)null, "", "", ""));
		_commandCollection[7].Parameters.Add(new SqlParameter("@DocHigh", SqlDbType.Float, 8, ParameterDirection.Input, (byte)0, (byte)0, "DocHigh", DataRowVersion.Current, false, (object)null, "", "", ""));
		_commandCollection[7].Parameters.Add(new SqlParameter("@DocScale", SqlDbType.Float, 8, ParameterDirection.Input, (byte)0, (byte)0, "DocScale", DataRowVersion.Current, false, (object)null, "", "", ""));
		_commandCollection[7].Parameters.Add(new SqlParameter("@TestAbrev", SqlDbType.NVarChar, 50, ParameterDirection.Input, (byte)0, (byte)0, "TestAbrev", DataRowVersion.Original, false, (object)null, "", "", ""));
		_commandCollection[7].Parameters.Add(new SqlParameter("@Testid", SqlDbType.Int, 4, ParameterDirection.Input, (byte)0, (byte)0, "Testid", DataRowVersion.Original, false, (object)null, "", "", ""));
		_commandCollection[8] = new SqlCommand();
		_commandCollection[8].Connection = Connection;
		_commandCollection[8].CommandText = "UPDATE       ResultRef\r\nSET                Result = @Result, rid = @rid, MedLow = @MedLow, MedHigh = @MedHigh, Medopt = @Medopt, MedScale = @MedScale, DocLow = @DocLow, \r\n                         DocOpt = @DocOpt, DocHigh = @DocHigh, DocScale = @DocScale\r\nWHERE        (UserName = @UserName) AND (Testid = @Testid) AND (TestAbrev = @TestAbrev)";
		_commandCollection[8].CommandType = CommandType.Text;
		_commandCollection[8].Parameters.Add(new SqlParameter("@Result", SqlDbType.Float, 8, ParameterDirection.Input, (byte)0, (byte)0, "Result", DataRowVersion.Current, false, (object)null, "", "", ""));
		_commandCollection[8].Parameters.Add(new SqlParameter("@rid", SqlDbType.Int, 4, ParameterDirection.Input, (byte)0, (byte)0, "rid", DataRowVersion.Current, false, (object)null, "", "", ""));
		_commandCollection[8].Parameters.Add(new SqlParameter("@MedLow", SqlDbType.Float, 8, ParameterDirection.Input, (byte)0, (byte)0, "MedLow", DataRowVersion.Current, false, (object)null, "", "", ""));
		_commandCollection[8].Parameters.Add(new SqlParameter("@MedHigh", SqlDbType.Float, 8, ParameterDirection.Input, (byte)0, (byte)0, "MedHigh", DataRowVersion.Current, false, (object)null, "", "", ""));
		_commandCollection[8].Parameters.Add(new SqlParameter("@Medopt", SqlDbType.Float, 8, ParameterDirection.Input, (byte)0, (byte)0, "Medopt", DataRowVersion.Current, false, (object)null, "", "", ""));
		_commandCollection[8].Parameters.Add(new SqlParameter("@MedScale", SqlDbType.Float, 8, ParameterDirection.Input, (byte)0, (byte)0, "MedScale", DataRowVersion.Current, false, (object)null, "", "", ""));
		_commandCollection[8].Parameters.Add(new SqlParameter("@DocLow", SqlDbType.Float, 8, ParameterDirection.Input, (byte)0, (byte)0, "DocLow", DataRowVersion.Current, false, (object)null, "", "", ""));
		_commandCollection[8].Parameters.Add(new SqlParameter("@DocOpt", SqlDbType.Float, 8, ParameterDirection.Input, (byte)0, (byte)0, "DocOpt", DataRowVersion.Current, false, (object)null, "", "", ""));
		_commandCollection[8].Parameters.Add(new SqlParameter("@DocHigh", SqlDbType.Float, 8, ParameterDirection.Input, (byte)0, (byte)0, "DocHigh", DataRowVersion.Current, false, (object)null, "", "", ""));
		_commandCollection[8].Parameters.Add(new SqlParameter("@DocScale", SqlDbType.Float, 8, ParameterDirection.Input, (byte)0, (byte)0, "DocScale", DataRowVersion.Current, false, (object)null, "", "", ""));
		_commandCollection[8].Parameters.Add(new SqlParameter("@UserName", SqlDbType.NVarChar, 256, ParameterDirection.Input, (byte)0, (byte)0, "UserName", DataRowVersion.Original, false, (object)null, "", "", ""));
		_commandCollection[8].Parameters.Add(new SqlParameter("@Testid", SqlDbType.Int, 4, ParameterDirection.Input, (byte)0, (byte)0, "Testid", DataRowVersion.Original, false, (object)null, "", "", ""));
		_commandCollection[8].Parameters.Add(new SqlParameter("@TestAbrev", SqlDbType.NVarChar, 50, ParameterDirection.Input, (byte)0, (byte)0, "TestAbrev", DataRowVersion.Original, false, (object)null, "", "", ""));
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	[DataObjectMethod(DataObjectMethodType.Fill, true)]
	[HelpKeyword("vs.data.TableAdapter")]
	[DebuggerNonUserCode]
	public virtual int Fill(Labstuff.ResultRefDataTable dataTable)
	{
		Adapter.SelectCommand = CommandCollection[0];
		if (ClearBeforeFill)
		{
			dataTable.Clear();
		}
		return ((DbDataAdapter)(object)Adapter).Fill((DataTable)dataTable);
	}

	[DebuggerNonUserCode]
	[HelpKeyword("vs.data.TableAdapter")]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	[DataObjectMethod(DataObjectMethodType.Select, true)]
	public virtual Labstuff.ResultRefDataTable GetData()
	{
		Adapter.SelectCommand = CommandCollection[0];
		Labstuff.ResultRefDataTable resultRefDataTable = new Labstuff.ResultRefDataTable();
		((DbDataAdapter)(object)Adapter).Fill((DataTable)resultRefDataTable);
		return resultRefDataTable;
	}

	[DataObjectMethod(DataObjectMethodType.Fill, false)]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	[DebuggerNonUserCode]
	[HelpKeyword("vs.data.TableAdapter")]
	public virtual int FillBy(Labstuff.ResultRefDataTable dataTable, int TestId, string TestAbrev)
	{
		Adapter.SelectCommand = CommandCollection[2];
		Adapter.SelectCommand.Parameters[0].Value = TestId;
		if (TestAbrev == null)
		{
			throw new ArgumentNullException("TestAbrev");
		}
		Adapter.SelectCommand.Parameters[1].Value = TestAbrev;
		if (ClearBeforeFill)
		{
			dataTable.Clear();
		}
		return ((DbDataAdapter)(object)Adapter).Fill((DataTable)dataTable);
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	[DebuggerNonUserCode]
	[DataObjectMethod(DataObjectMethodType.Select, false)]
	[HelpKeyword("vs.data.TableAdapter")]
	public virtual Labstuff.ResultRefDataTable fillByTestId_TestAbrev(int TestId, string TestAbrev)
	{
		Adapter.SelectCommand = CommandCollection[2];
		Adapter.SelectCommand.Parameters[0].Value = TestId;
		if (TestAbrev == null)
		{
			throw new ArgumentNullException("TestAbrev");
		}
		Adapter.SelectCommand.Parameters[1].Value = TestAbrev;
		Labstuff.ResultRefDataTable resultRefDataTable = new Labstuff.ResultRefDataTable();
		((DbDataAdapter)(object)Adapter).Fill((DataTable)resultRefDataTable);
		return resultRefDataTable;
	}

	[DataObjectMethod(DataObjectMethodType.Fill, false)]
	[DebuggerNonUserCode]
	[HelpKeyword("vs.data.TableAdapter")]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	public virtual int FillByTestId(Labstuff.ResultRefDataTable dataTable, int Testid)
	{
		Adapter.SelectCommand = CommandCollection[3];
		Adapter.SelectCommand.Parameters[0].Value = Testid;
		if (ClearBeforeFill)
		{
			dataTable.Clear();
		}
		return ((DbDataAdapter)(object)Adapter).Fill((DataTable)dataTable);
	}

	[DataObjectMethod(DataObjectMethodType.Select, false)]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	[HelpKeyword("vs.data.TableAdapter")]
	[DebuggerNonUserCode]
	public virtual Labstuff.ResultRefDataTable GetDataBy6(int Testid)
	{
		Adapter.SelectCommand = CommandCollection[3];
		Adapter.SelectCommand.Parameters[0].Value = Testid;
		Labstuff.ResultRefDataTable resultRefDataTable = new Labstuff.ResultRefDataTable();
		((DbDataAdapter)(object)Adapter).Fill((DataTable)resultRefDataTable);
		return resultRefDataTable;
	}

	[DebuggerNonUserCode]
	[HelpKeyword("vs.data.TableAdapter")]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	public virtual int Update(Labstuff.ResultRefDataTable dataTable)
	{
		return ((DbDataAdapter)(object)Adapter).Update((DataTable)dataTable);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	[HelpKeyword("vs.data.TableAdapter")]
	public virtual int Update(Labstuff dataSet)
	{
		return ((DbDataAdapter)(object)Adapter).Update((DataSet)dataSet, "ResultRef");
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

	[DataObjectMethod(DataObjectMethodType.Delete, true)]
	[HelpKeyword("vs.data.TableAdapter")]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	[DebuggerNonUserCode]
	public virtual int Delete(string Original_TestAbrev, int Original_Testid)
	{
		if (Original_TestAbrev == null)
		{
			throw new ArgumentNullException("Original_TestAbrev");
		}
		Adapter.DeleteCommand.Parameters[0].Value = Original_TestAbrev;
		Adapter.DeleteCommand.Parameters[1].Value = Original_Testid;
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

	[DataObjectMethod(DataObjectMethodType.Insert, true)]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	[DebuggerNonUserCode]
	[HelpKeyword("vs.data.TableAdapter")]
	public virtual int Insert(double? Result, int rid, string TestAbrev, double? MedLow, double? MedHigh, double? Medopt, double? MedScale, string UserName, double? DocLow, double? DocOpt, double? DocHigh, double? DocScale, int Testid)
	{
		if (Result.HasValue)
		{
			Adapter.InsertCommand.Parameters[0].Value = Result.Value;
		}
		else
		{
			Adapter.InsertCommand.Parameters[0].Value = DBNull.Value;
		}
		Adapter.InsertCommand.Parameters[1].Value = rid;
		if (TestAbrev == null)
		{
			throw new ArgumentNullException("TestAbrev");
		}
		Adapter.InsertCommand.Parameters[2].Value = TestAbrev;
		if (MedLow.HasValue)
		{
			Adapter.InsertCommand.Parameters[3].Value = MedLow.Value;
		}
		else
		{
			Adapter.InsertCommand.Parameters[3].Value = DBNull.Value;
		}
		if (MedHigh.HasValue)
		{
			Adapter.InsertCommand.Parameters[4].Value = MedHigh.Value;
		}
		else
		{
			Adapter.InsertCommand.Parameters[4].Value = DBNull.Value;
		}
		if (Medopt.HasValue)
		{
			Adapter.InsertCommand.Parameters[5].Value = Medopt.Value;
		}
		else
		{
			Adapter.InsertCommand.Parameters[5].Value = DBNull.Value;
		}
		if (MedScale.HasValue)
		{
			Adapter.InsertCommand.Parameters[6].Value = MedScale.Value;
		}
		else
		{
			Adapter.InsertCommand.Parameters[6].Value = DBNull.Value;
		}
		if (UserName == null)
		{
			Adapter.InsertCommand.Parameters[7].Value = DBNull.Value;
		}
		else
		{
			Adapter.InsertCommand.Parameters[7].Value = UserName;
		}
		if (DocLow.HasValue)
		{
			Adapter.InsertCommand.Parameters[8].Value = DocLow.Value;
		}
		else
		{
			Adapter.InsertCommand.Parameters[8].Value = DBNull.Value;
		}
		if (DocOpt.HasValue)
		{
			Adapter.InsertCommand.Parameters[9].Value = DocOpt.Value;
		}
		else
		{
			Adapter.InsertCommand.Parameters[9].Value = DBNull.Value;
		}
		if (DocHigh.HasValue)
		{
			Adapter.InsertCommand.Parameters[10].Value = DocHigh.Value;
		}
		else
		{
			Adapter.InsertCommand.Parameters[10].Value = DBNull.Value;
		}
		if (DocScale.HasValue)
		{
			Adapter.InsertCommand.Parameters[11].Value = DocScale.Value;
		}
		else
		{
			Adapter.InsertCommand.Parameters[11].Value = DBNull.Value;
		}
		Adapter.InsertCommand.Parameters[12].Value = Testid;
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

	[HelpKeyword("vs.data.TableAdapter")]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	[DebuggerNonUserCode]
	[DataObjectMethod(DataObjectMethodType.Update, true)]
	public virtual int Update(double? Result, int rid, string TestAbrev, double? MedLow, double? MedHigh, double? Medopt, double? MedScale, string UserName, double? DocLow, double? DocOpt, double? DocHigh, double? DocScale, int Testid, string Original_TestAbrev, int Original_Testid)
	{
		if (Result.HasValue)
		{
			Adapter.UpdateCommand.Parameters[0].Value = Result.Value;
		}
		else
		{
			Adapter.UpdateCommand.Parameters[0].Value = DBNull.Value;
		}
		Adapter.UpdateCommand.Parameters[1].Value = rid;
		if (TestAbrev == null)
		{
			throw new ArgumentNullException("TestAbrev");
		}
		Adapter.UpdateCommand.Parameters[2].Value = TestAbrev;
		if (MedLow.HasValue)
		{
			Adapter.UpdateCommand.Parameters[3].Value = MedLow.Value;
		}
		else
		{
			Adapter.UpdateCommand.Parameters[3].Value = DBNull.Value;
		}
		if (MedHigh.HasValue)
		{
			Adapter.UpdateCommand.Parameters[4].Value = MedHigh.Value;
		}
		else
		{
			Adapter.UpdateCommand.Parameters[4].Value = DBNull.Value;
		}
		if (Medopt.HasValue)
		{
			Adapter.UpdateCommand.Parameters[5].Value = Medopt.Value;
		}
		else
		{
			Adapter.UpdateCommand.Parameters[5].Value = DBNull.Value;
		}
		if (MedScale.HasValue)
		{
			Adapter.UpdateCommand.Parameters[6].Value = MedScale.Value;
		}
		else
		{
			Adapter.UpdateCommand.Parameters[6].Value = DBNull.Value;
		}
		if (UserName == null)
		{
			Adapter.UpdateCommand.Parameters[7].Value = DBNull.Value;
		}
		else
		{
			Adapter.UpdateCommand.Parameters[7].Value = UserName;
		}
		if (DocLow.HasValue)
		{
			Adapter.UpdateCommand.Parameters[8].Value = DocLow.Value;
		}
		else
		{
			Adapter.UpdateCommand.Parameters[8].Value = DBNull.Value;
		}
		if (DocOpt.HasValue)
		{
			Adapter.UpdateCommand.Parameters[9].Value = DocOpt.Value;
		}
		else
		{
			Adapter.UpdateCommand.Parameters[9].Value = DBNull.Value;
		}
		if (DocHigh.HasValue)
		{
			Adapter.UpdateCommand.Parameters[10].Value = DocHigh.Value;
		}
		else
		{
			Adapter.UpdateCommand.Parameters[10].Value = DBNull.Value;
		}
		if (DocScale.HasValue)
		{
			Adapter.UpdateCommand.Parameters[11].Value = DocScale.Value;
		}
		else
		{
			Adapter.UpdateCommand.Parameters[11].Value = DBNull.Value;
		}
		Adapter.UpdateCommand.Parameters[12].Value = Testid;
		if (Original_TestAbrev == null)
		{
			throw new ArgumentNullException("Original_TestAbrev");
		}
		Adapter.UpdateCommand.Parameters[13].Value = Original_TestAbrev;
		Adapter.UpdateCommand.Parameters[14].Value = Original_Testid;
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
	[DataObjectMethod(DataObjectMethodType.Update, true)]
	[HelpKeyword("vs.data.TableAdapter")]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	public virtual int Update(double? Result, int rid, string TestAbrev, double? MedLow, double? MedHigh, double? Medopt, double? MedScale, string UserName, double? DocLow, double? DocOpt, double? DocHigh, double? DocScale, string Original_TestAbrev, int Original_Testid)
	{
		return Update(Result, rid, TestAbrev, MedLow, MedHigh, Medopt, MedScale, UserName, DocLow, DocOpt, DocHigh, DocScale, Original_Testid, Original_TestAbrev, Original_Testid);
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	[DebuggerNonUserCode]
	[DataObjectMethod(DataObjectMethodType.Delete, false)]
	[HelpKeyword("vs.data.TableAdapter")]
	public virtual int DeleteQuery(string testabrev, int testid)
	{
		SqlCommand val = CommandCollection[1];
		if (testabrev == null)
		{
			throw new ArgumentNullException("testabrev");
		}
		val.Parameters[0].Value = testabrev;
		val.Parameters[1].Value = testid;
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
	[DebuggerNonUserCode]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	public virtual double? ifTestAdded(string TestAbrev, int Testid)
	{
		SqlCommand val = CommandCollection[4];
		if (TestAbrev == null)
		{
			throw new ArgumentNullException("TestAbrev");
		}
		val.Parameters[0].Value = TestAbrev;
		val.Parameters[1].Value = Testid;
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
		return Conversions.ToDouble(objectValue);
	}

	[DebuggerNonUserCode]
	[HelpKeyword("vs.data.TableAdapter")]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	public virtual int InsertResults(float? Result, int? rid, string TestAbrev, float? MedLow, float? MedHigh, float? Medopt, float? MedScale, string UserName, float? DocLow, float? DocOpt, float? DocHigh, float? DocScale, int? Testid)
	{
		SqlCommand val = CommandCollection[5];
		if (Result.HasValue)
		{
			val.Parameters[1].Value = Result.Value;
		}
		else
		{
			val.Parameters[1].Value = DBNull.Value;
		}
		if (rid.HasValue)
		{
			val.Parameters[2].Value = rid.Value;
		}
		else
		{
			val.Parameters[2].Value = DBNull.Value;
		}
		if (TestAbrev == null)
		{
			val.Parameters[3].Value = DBNull.Value;
		}
		else
		{
			val.Parameters[3].Value = TestAbrev;
		}
		if (MedLow.HasValue)
		{
			val.Parameters[4].Value = MedLow.Value;
		}
		else
		{
			val.Parameters[4].Value = DBNull.Value;
		}
		if (MedHigh.HasValue)
		{
			val.Parameters[5].Value = MedHigh.Value;
		}
		else
		{
			val.Parameters[5].Value = DBNull.Value;
		}
		if (Medopt.HasValue)
		{
			val.Parameters[6].Value = Medopt.Value;
		}
		else
		{
			val.Parameters[6].Value = DBNull.Value;
		}
		if (MedScale.HasValue)
		{
			val.Parameters[7].Value = MedScale.Value;
		}
		else
		{
			val.Parameters[7].Value = DBNull.Value;
		}
		if (UserName == null)
		{
			val.Parameters[8].Value = DBNull.Value;
		}
		else
		{
			val.Parameters[8].Value = UserName;
		}
		if (DocLow.HasValue)
		{
			val.Parameters[9].Value = DocLow.Value;
		}
		else
		{
			val.Parameters[9].Value = DBNull.Value;
		}
		if (DocOpt.HasValue)
		{
			val.Parameters[10].Value = DocOpt.Value;
		}
		else
		{
			val.Parameters[10].Value = DBNull.Value;
		}
		if (DocHigh.HasValue)
		{
			val.Parameters[11].Value = DocHigh.Value;
		}
		else
		{
			val.Parameters[11].Value = DBNull.Value;
		}
		if (DocScale.HasValue)
		{
			val.Parameters[12].Value = DocScale.Value;
		}
		else
		{
			val.Parameters[12].Value = DBNull.Value;
		}
		if (Testid.HasValue)
		{
			val.Parameters[13].Value = Testid.Value;
		}
		else
		{
			val.Parameters[13].Value = DBNull.Value;
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
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	[DebuggerNonUserCode]
	public virtual object ScalarQuery(string username)
	{
		SqlCommand val = CommandCollection[6];
		if (username == null)
		{
			val.Parameters[0].Value = DBNull.Value;
		}
		else
		{
			val.Parameters[0].Value = username;
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

	[DebuggerNonUserCode]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	[DataObjectMethod(DataObjectMethodType.Update, false)]
	[HelpKeyword("vs.data.TableAdapter")]
	public virtual int update4Ratios(double? Result, double? MedLow, double? MedHigh, double? Medopt, double? MedScale, string UserName, double? DocLow, double? DocOpt, double? DocHigh, double? DocScale, string TestAbrev, int Testid)
	{
		SqlCommand val = CommandCollection[7];
		if (Result.HasValue)
		{
			val.Parameters[0].Value = Result.Value;
		}
		else
		{
			val.Parameters[0].Value = DBNull.Value;
		}
		if (MedLow.HasValue)
		{
			val.Parameters[1].Value = MedLow.Value;
		}
		else
		{
			val.Parameters[1].Value = DBNull.Value;
		}
		if (MedHigh.HasValue)
		{
			val.Parameters[2].Value = MedHigh.Value;
		}
		else
		{
			val.Parameters[2].Value = DBNull.Value;
		}
		if (Medopt.HasValue)
		{
			val.Parameters[3].Value = Medopt.Value;
		}
		else
		{
			val.Parameters[3].Value = DBNull.Value;
		}
		if (MedScale.HasValue)
		{
			val.Parameters[4].Value = MedScale.Value;
		}
		else
		{
			val.Parameters[4].Value = DBNull.Value;
		}
		if (UserName == null)
		{
			val.Parameters[5].Value = DBNull.Value;
		}
		else
		{
			val.Parameters[5].Value = UserName;
		}
		if (DocLow.HasValue)
		{
			val.Parameters[6].Value = DocLow.Value;
		}
		else
		{
			val.Parameters[6].Value = DBNull.Value;
		}
		if (DocOpt.HasValue)
		{
			val.Parameters[7].Value = DocOpt.Value;
		}
		else
		{
			val.Parameters[7].Value = DBNull.Value;
		}
		if (DocHigh.HasValue)
		{
			val.Parameters[8].Value = DocHigh.Value;
		}
		else
		{
			val.Parameters[8].Value = DBNull.Value;
		}
		if (DocScale.HasValue)
		{
			val.Parameters[9].Value = DocScale.Value;
		}
		else
		{
			val.Parameters[9].Value = DBNull.Value;
		}
		if (TestAbrev == null)
		{
			throw new ArgumentNullException("TestAbrev");
		}
		val.Parameters[10].Value = TestAbrev;
		val.Parameters[11].Value = Testid;
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
	[HelpKeyword("vs.data.TableAdapter")]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	[DebuggerNonUserCode]
	public virtual int UpdateQuery(double? Result, int rid, double? MedLow, double? MedHigh, double? Medopt, double? MedScale, double? DocLow, double? DocOpt, double? DocHigh, double? DocScale, string UserName, int Testid, string TestAbrev)
	{
		SqlCommand val = CommandCollection[8];
		if (Result.HasValue)
		{
			val.Parameters[0].Value = Result.Value;
		}
		else
		{
			val.Parameters[0].Value = DBNull.Value;
		}
		val.Parameters[1].Value = rid;
		if (MedLow.HasValue)
		{
			val.Parameters[2].Value = MedLow.Value;
		}
		else
		{
			val.Parameters[2].Value = DBNull.Value;
		}
		if (MedHigh.HasValue)
		{
			val.Parameters[3].Value = MedHigh.Value;
		}
		else
		{
			val.Parameters[3].Value = DBNull.Value;
		}
		if (Medopt.HasValue)
		{
			val.Parameters[4].Value = Medopt.Value;
		}
		else
		{
			val.Parameters[4].Value = DBNull.Value;
		}
		if (MedScale.HasValue)
		{
			val.Parameters[5].Value = MedScale.Value;
		}
		else
		{
			val.Parameters[5].Value = DBNull.Value;
		}
		if (DocLow.HasValue)
		{
			val.Parameters[6].Value = DocLow.Value;
		}
		else
		{
			val.Parameters[6].Value = DBNull.Value;
		}
		if (DocOpt.HasValue)
		{
			val.Parameters[7].Value = DocOpt.Value;
		}
		else
		{
			val.Parameters[7].Value = DBNull.Value;
		}
		if (DocHigh.HasValue)
		{
			val.Parameters[8].Value = DocHigh.Value;
		}
		else
		{
			val.Parameters[8].Value = DBNull.Value;
		}
		if (DocScale.HasValue)
		{
			val.Parameters[9].Value = DocScale.Value;
		}
		else
		{
			val.Parameters[9].Value = DBNull.Value;
		}
		if (UserName == null)
		{
			val.Parameters[10].Value = DBNull.Value;
		}
		else
		{
			val.Parameters[10].Value = UserName;
		}
		val.Parameters[11].Value = Testid;
		if (TestAbrev == null)
		{
			throw new ArgumentNullException("TestAbrev");
		}
		val.Parameters[12].Value = TestAbrev;
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
