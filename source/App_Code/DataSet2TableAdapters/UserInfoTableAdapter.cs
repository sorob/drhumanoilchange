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

namespace DataSet2TableAdapters;

[ToolboxItem(true)]
[DataObject(true)]
[HelpKeyword("vs.data.TableAdapter")]
[Designer("Microsoft.VSDesigner.DataSource.Design.TableAdapterDesigner, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
[DesignerCategory("code")]
public class UserInfoTableAdapter : Component
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
	public UserInfoTableAdapter()
	{
		ClearBeforeFill = true;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	private void InitAdapter()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected Obj, but got Unknown
		//IL_02bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c7: Expected Obj, but got Unknown
		//IL_0339: Unknown result type (might be due to invalid IL or missing references)
		//IL_0343: Expected Obj, but got Unknown
		//IL_034a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0354: Expected Obj, but got Unknown
		//IL_03c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d0: Expected Obj, but got Unknown
		//IL_0407: Unknown result type (might be due to invalid IL or missing references)
		//IL_0411: Expected Obj, but got Unknown
		//IL_0447: Unknown result type (might be due to invalid IL or missing references)
		//IL_0451: Expected Obj, but got Unknown
		//IL_0488: Unknown result type (might be due to invalid IL or missing references)
		//IL_0492: Expected Obj, but got Unknown
		//IL_04c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_04d2: Expected Obj, but got Unknown
		//IL_0509: Unknown result type (might be due to invalid IL or missing references)
		//IL_0513: Expected Obj, but got Unknown
		//IL_054a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0554: Expected Obj, but got Unknown
		//IL_058b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0595: Expected Obj, but got Unknown
		//IL_05cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_05d6: Expected Obj, but got Unknown
		//IL_060d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0617: Expected Obj, but got Unknown
		//IL_064d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0657: Expected Obj, but got Unknown
		//IL_068d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0697: Expected Obj, but got Unknown
		//IL_06ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_06d8: Expected Obj, but got Unknown
		//IL_070f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0719: Expected Obj, but got Unknown
		//IL_074f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0759: Expected Obj, but got Unknown
		//IL_0790: Unknown result type (might be due to invalid IL or missing references)
		//IL_079a: Expected Obj, but got Unknown
		//IL_07d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_07db: Expected Obj, but got Unknown
		//IL_0812: Unknown result type (might be due to invalid IL or missing references)
		//IL_081c: Expected Obj, but got Unknown
		//IL_0852: Unknown result type (might be due to invalid IL or missing references)
		//IL_085c: Expected Obj, but got Unknown
		//IL_0892: Unknown result type (might be due to invalid IL or missing references)
		//IL_089c: Expected Obj, but got Unknown
		//IL_08d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_08dd: Expected Obj, but got Unknown
		//IL_0914: Unknown result type (might be due to invalid IL or missing references)
		//IL_091e: Expected Obj, but got Unknown
		//IL_0955: Unknown result type (might be due to invalid IL or missing references)
		//IL_095f: Expected Obj, but got Unknown
		//IL_0996: Unknown result type (might be due to invalid IL or missing references)
		//IL_09a0: Expected Obj, but got Unknown
		//IL_09d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_09e1: Expected Obj, but got Unknown
		//IL_0a18: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a22: Expected Obj, but got Unknown
		//IL_0a59: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a63: Expected Obj, but got Unknown
		//IL_0a9a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0aa4: Expected Obj, but got Unknown
		//IL_0adb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ae5: Expected Obj, but got Unknown
		//IL_0aec: Unknown result type (might be due to invalid IL or missing references)
		//IL_0af6: Expected Obj, but got Unknown
		//IL_0b68: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b72: Expected Obj, but got Unknown
		//IL_0ba9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bb3: Expected Obj, but got Unknown
		//IL_0be9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bf3: Expected Obj, but got Unknown
		//IL_0c2a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c34: Expected Obj, but got Unknown
		//IL_0c6a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c74: Expected Obj, but got Unknown
		//IL_0cab: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cb5: Expected Obj, but got Unknown
		//IL_0cec: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cf6: Expected Obj, but got Unknown
		//IL_0d2d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d37: Expected Obj, but got Unknown
		//IL_0d6e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d78: Expected Obj, but got Unknown
		//IL_0daf: Unknown result type (might be due to invalid IL or missing references)
		//IL_0db9: Expected Obj, but got Unknown
		//IL_0def: Unknown result type (might be due to invalid IL or missing references)
		//IL_0df9: Expected Obj, but got Unknown
		//IL_0e2f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e39: Expected Obj, but got Unknown
		//IL_0e70: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e7a: Expected Obj, but got Unknown
		//IL_0eb1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ebb: Expected Obj, but got Unknown
		//IL_0ef1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0efb: Expected Obj, but got Unknown
		//IL_0f32: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f3c: Expected Obj, but got Unknown
		//IL_0f73: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f7d: Expected Obj, but got Unknown
		//IL_0fb4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fbe: Expected Obj, but got Unknown
		//IL_0ff4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ffe: Expected Obj, but got Unknown
		//IL_1034: Unknown result type (might be due to invalid IL or missing references)
		//IL_103e: Expected Obj, but got Unknown
		//IL_1075: Unknown result type (might be due to invalid IL or missing references)
		//IL_107f: Expected Obj, but got Unknown
		//IL_10b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_10c0: Expected Obj, but got Unknown
		//IL_10f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_1101: Expected Obj, but got Unknown
		//IL_1138: Unknown result type (might be due to invalid IL or missing references)
		//IL_1142: Expected Obj, but got Unknown
		//IL_1179: Unknown result type (might be due to invalid IL or missing references)
		//IL_1183: Expected Obj, but got Unknown
		//IL_11ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_11c4: Expected Obj, but got Unknown
		//IL_11fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_1205: Expected Obj, but got Unknown
		//IL_123c: Unknown result type (might be due to invalid IL or missing references)
		//IL_1246: Expected Obj, but got Unknown
		//IL_127d: Unknown result type (might be due to invalid IL or missing references)
		//IL_1287: Expected Obj, but got Unknown
		//IL_12be: Unknown result type (might be due to invalid IL or missing references)
		//IL_12c8: Expected Obj, but got Unknown
		_adapter = new SqlDataAdapter();
		DataTableMapping dataTableMapping = new DataTableMapping();
		dataTableMapping.SourceTable = "Table";
		dataTableMapping.DataSetTable = "UserInfo";
		dataTableMapping.ColumnMappings.Add("Name", "Name");
		dataTableMapping.ColumnMappings.Add("sex", "sex");
		dataTableMapping.ColumnMappings.Add("RegisterDate", "RegisterDate");
		dataTableMapping.ColumnMappings.Add("Address", "Address");
		dataTableMapping.ColumnMappings.Add("Maried", "Maried");
		dataTableMapping.ColumnMappings.Add("NumberofChildren", "NumberofChildren");
		dataTableMapping.ColumnMappings.Add("Sybling", "Sybling");
		dataTableMapping.ColumnMappings.Add("City", "City");
		dataTableMapping.ColumnMappings.Add("State", "State");
		dataTableMapping.ColumnMappings.Add("Zipcode", "Zipcode");
		dataTableMapping.ColumnMappings.Add("areacode", "areacode");
		dataTableMapping.ColumnMappings.Add("phonenumber", "phonenumber");
		dataTableMapping.ColumnMappings.Add("occupation", "occupation");
		dataTableMapping.ColumnMappings.Add("Habbies", "Habbies");
		dataTableMapping.ColumnMappings.Add("birthdate", "birthdate");
		dataTableMapping.ColumnMappings.Add("birthplace", "birthplace");
		dataTableMapping.ColumnMappings.Add("lastgrad", "lastgrad");
		dataTableMapping.ColumnMappings.Add("SSN", "SSN");
		dataTableMapping.ColumnMappings.Add("Labnum", "Labnum");
		dataTableMapping.ColumnMappings.Add("PsychologicallyStress", "PsychologicallyStress");
		dataTableMapping.ColumnMappings.Add("height", "height");
		dataTableMapping.ColumnMappings.Add("weight", "weight");
		dataTableMapping.ColumnMappings.Add("eyecolor", "eyecolor");
		dataTableMapping.ColumnMappings.Add("haircolor", "haircolor");
		dataTableMapping.ColumnMappings.Add("bloodtype", "bloodtype");
		dataTableMapping.ColumnMappings.Add("UserName", "UserName");
		dataTableMapping.ColumnMappings.Add("Code", "Code");
		dataTableMapping.ColumnMappings.Add("race", "race");
		dataTableMapping.ColumnMappings.Add("referral", "referral");
		((DataAdapter)(object)_adapter).TableMappings.Add(dataTableMapping);
		_adapter.DeleteCommand = new SqlCommand();
		_adapter.DeleteCommand.Connection = Connection;
		_adapter.DeleteCommand.CommandText = "DELETE FROM [UserInfo] WHERE (([UserName] = @Original_UserName))";
		_adapter.DeleteCommand.CommandType = CommandType.Text;
		_adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_UserName", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte)0, (byte)0, "UserName", DataRowVersion.Original, false, (object)null, "", "", ""));
		_adapter.InsertCommand = new SqlCommand();
		_adapter.InsertCommand.Connection = Connection;
		_adapter.InsertCommand.CommandText = "INSERT INTO [UserInfo] ([Name], [sex], [RegisterDate], [Address], [Maried], [NumberofChildren], [Sybling], [City], [State], [Zipcode], [areacode], [phonenumber], [occupation], [Habbies], [birthdate], [birthplace], [lastgrad], [SSN], [Labnum], [PsychologicallyStress], [height], [weight], [eyecolor], [haircolor], [bloodtype], [UserName], [Code], [race], [referral]) VALUES (@Name, @sex, @RegisterDate, @Address, @Maried, @NumberofChildren, @Sybling, @City, @State, @Zipcode, @areacode, @phonenumber, @occupation, @Habbies, @birthdate, @birthplace, @lastgrad, @SSN, @Labnum, @PsychologicallyStress, @height, @weight, @eyecolor, @haircolor, @bloodtype, @UserName, @Code, @race, @referral)";
		_adapter.InsertCommand.CommandType = CommandType.Text;
		_adapter.InsertCommand.Parameters.Add(new SqlParameter("@Name", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte)0, (byte)0, "Name", DataRowVersion.Current, false, (object)null, "", "", ""));
		_adapter.InsertCommand.Parameters.Add(new SqlParameter("@sex", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte)0, (byte)0, "sex", DataRowVersion.Current, false, (object)null, "", "", ""));
		_adapter.InsertCommand.Parameters.Add(new SqlParameter("@RegisterDate", SqlDbType.DateTime, 0, ParameterDirection.Input, (byte)0, (byte)0, "RegisterDate", DataRowVersion.Current, false, (object)null, "", "", ""));
		_adapter.InsertCommand.Parameters.Add(new SqlParameter("@Address", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte)0, (byte)0, "Address", DataRowVersion.Current, false, (object)null, "", "", ""));
		_adapter.InsertCommand.Parameters.Add(new SqlParameter("@Maried", SqlDbType.Bit, 0, ParameterDirection.Input, (byte)0, (byte)0, "Maried", DataRowVersion.Current, false, (object)null, "", "", ""));
		_adapter.InsertCommand.Parameters.Add(new SqlParameter("@NumberofChildren", SqlDbType.SmallInt, 0, ParameterDirection.Input, (byte)0, (byte)0, "NumberofChildren", DataRowVersion.Current, false, (object)null, "", "", ""));
		_adapter.InsertCommand.Parameters.Add(new SqlParameter("@Sybling", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte)0, (byte)0, "Sybling", DataRowVersion.Current, false, (object)null, "", "", ""));
		_adapter.InsertCommand.Parameters.Add(new SqlParameter("@City", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte)0, (byte)0, "City", DataRowVersion.Current, false, (object)null, "", "", ""));
		_adapter.InsertCommand.Parameters.Add(new SqlParameter("@State", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte)0, (byte)0, "State", DataRowVersion.Current, false, (object)null, "", "", ""));
		_adapter.InsertCommand.Parameters.Add(new SqlParameter("@Zipcode", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte)0, (byte)0, "Zipcode", DataRowVersion.Current, false, (object)null, "", "", ""));
		_adapter.InsertCommand.Parameters.Add(new SqlParameter("@areacode", SqlDbType.Int, 0, ParameterDirection.Input, (byte)0, (byte)0, "areacode", DataRowVersion.Current, false, (object)null, "", "", ""));
		_adapter.InsertCommand.Parameters.Add(new SqlParameter("@phonenumber", SqlDbType.Int, 0, ParameterDirection.Input, (byte)0, (byte)0, "phonenumber", DataRowVersion.Current, false, (object)null, "", "", ""));
		_adapter.InsertCommand.Parameters.Add(new SqlParameter("@occupation", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte)0, (byte)0, "occupation", DataRowVersion.Current, false, (object)null, "", "", ""));
		_adapter.InsertCommand.Parameters.Add(new SqlParameter("@Habbies", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte)0, (byte)0, "Habbies", DataRowVersion.Current, false, (object)null, "", "", ""));
		_adapter.InsertCommand.Parameters.Add(new SqlParameter("@birthdate", SqlDbType.DateTime, 0, ParameterDirection.Input, (byte)0, (byte)0, "birthdate", DataRowVersion.Current, false, (object)null, "", "", ""));
		_adapter.InsertCommand.Parameters.Add(new SqlParameter("@birthplace", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte)0, (byte)0, "birthplace", DataRowVersion.Current, false, (object)null, "", "", ""));
		_adapter.InsertCommand.Parameters.Add(new SqlParameter("@lastgrad", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte)0, (byte)0, "lastgrad", DataRowVersion.Current, false, (object)null, "", "", ""));
		_adapter.InsertCommand.Parameters.Add(new SqlParameter("@SSN", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte)0, (byte)0, "SSN", DataRowVersion.Current, false, (object)null, "", "", ""));
		_adapter.InsertCommand.Parameters.Add(new SqlParameter("@Labnum", SqlDbType.Int, 0, ParameterDirection.Input, (byte)0, (byte)0, "Labnum", DataRowVersion.Current, false, (object)null, "", "", ""));
		_adapter.InsertCommand.Parameters.Add(new SqlParameter("@PsychologicallyStress", SqlDbType.Bit, 0, ParameterDirection.Input, (byte)0, (byte)0, "PsychologicallyStress", DataRowVersion.Current, false, (object)null, "", "", ""));
		_adapter.InsertCommand.Parameters.Add(new SqlParameter("@height", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte)0, (byte)0, "height", DataRowVersion.Current, false, (object)null, "", "", ""));
		_adapter.InsertCommand.Parameters.Add(new SqlParameter("@weight", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte)0, (byte)0, "weight", DataRowVersion.Current, false, (object)null, "", "", ""));
		_adapter.InsertCommand.Parameters.Add(new SqlParameter("@eyecolor", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte)0, (byte)0, "eyecolor", DataRowVersion.Current, false, (object)null, "", "", ""));
		_adapter.InsertCommand.Parameters.Add(new SqlParameter("@haircolor", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte)0, (byte)0, "haircolor", DataRowVersion.Current, false, (object)null, "", "", ""));
		_adapter.InsertCommand.Parameters.Add(new SqlParameter("@bloodtype", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte)0, (byte)0, "bloodtype", DataRowVersion.Current, false, (object)null, "", "", ""));
		_adapter.InsertCommand.Parameters.Add(new SqlParameter("@UserName", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte)0, (byte)0, "UserName", DataRowVersion.Current, false, (object)null, "", "", ""));
		_adapter.InsertCommand.Parameters.Add(new SqlParameter("@Code", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte)0, (byte)0, "Code", DataRowVersion.Current, false, (object)null, "", "", ""));
		_adapter.InsertCommand.Parameters.Add(new SqlParameter("@race", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte)0, (byte)0, "race", DataRowVersion.Current, false, (object)null, "", "", ""));
		_adapter.InsertCommand.Parameters.Add(new SqlParameter("@referral", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte)0, (byte)0, "referral", DataRowVersion.Current, false, (object)null, "", "", ""));
		_adapter.UpdateCommand = new SqlCommand();
		_adapter.UpdateCommand.Connection = Connection;
		_adapter.UpdateCommand.CommandText = "UPDATE [UserInfo] SET [Name] = @Name, [sex] = @sex, [RegisterDate] = @RegisterDate, [Address] = @Address, [Maried] = @Maried, [NumberofChildren] = @NumberofChildren, [Sybling] = @Sybling, [City] = @City, [State] = @State, [Zipcode] = @Zipcode, [areacode] = @areacode, [phonenumber] = @phonenumber, [occupation] = @occupation, [Habbies] = @Habbies, [birthdate] = @birthdate, [birthplace] = @birthplace, [lastgrad] = @lastgrad, [SSN] = @SSN, [Labnum] = @Labnum, [PsychologicallyStress] = @PsychologicallyStress, [height] = @height, [weight] = @weight, [eyecolor] = @eyecolor, [haircolor] = @haircolor, [bloodtype] = @bloodtype, [UserName] = @UserName, [Code] = @Code, [race] = @race, [referral] = @referral WHERE (([UserName] = @Original_UserName))";
		_adapter.UpdateCommand.CommandType = CommandType.Text;
		_adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Name", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte)0, (byte)0, "Name", DataRowVersion.Current, false, (object)null, "", "", ""));
		_adapter.UpdateCommand.Parameters.Add(new SqlParameter("@sex", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte)0, (byte)0, "sex", DataRowVersion.Current, false, (object)null, "", "", ""));
		_adapter.UpdateCommand.Parameters.Add(new SqlParameter("@RegisterDate", SqlDbType.DateTime, 0, ParameterDirection.Input, (byte)0, (byte)0, "RegisterDate", DataRowVersion.Current, false, (object)null, "", "", ""));
		_adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Address", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte)0, (byte)0, "Address", DataRowVersion.Current, false, (object)null, "", "", ""));
		_adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Maried", SqlDbType.Bit, 0, ParameterDirection.Input, (byte)0, (byte)0, "Maried", DataRowVersion.Current, false, (object)null, "", "", ""));
		_adapter.UpdateCommand.Parameters.Add(new SqlParameter("@NumberofChildren", SqlDbType.SmallInt, 0, ParameterDirection.Input, (byte)0, (byte)0, "NumberofChildren", DataRowVersion.Current, false, (object)null, "", "", ""));
		_adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Sybling", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte)0, (byte)0, "Sybling", DataRowVersion.Current, false, (object)null, "", "", ""));
		_adapter.UpdateCommand.Parameters.Add(new SqlParameter("@City", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte)0, (byte)0, "City", DataRowVersion.Current, false, (object)null, "", "", ""));
		_adapter.UpdateCommand.Parameters.Add(new SqlParameter("@State", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte)0, (byte)0, "State", DataRowVersion.Current, false, (object)null, "", "", ""));
		_adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Zipcode", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte)0, (byte)0, "Zipcode", DataRowVersion.Current, false, (object)null, "", "", ""));
		_adapter.UpdateCommand.Parameters.Add(new SqlParameter("@areacode", SqlDbType.Int, 0, ParameterDirection.Input, (byte)0, (byte)0, "areacode", DataRowVersion.Current, false, (object)null, "", "", ""));
		_adapter.UpdateCommand.Parameters.Add(new SqlParameter("@phonenumber", SqlDbType.Int, 0, ParameterDirection.Input, (byte)0, (byte)0, "phonenumber", DataRowVersion.Current, false, (object)null, "", "", ""));
		_adapter.UpdateCommand.Parameters.Add(new SqlParameter("@occupation", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte)0, (byte)0, "occupation", DataRowVersion.Current, false, (object)null, "", "", ""));
		_adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Habbies", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte)0, (byte)0, "Habbies", DataRowVersion.Current, false, (object)null, "", "", ""));
		_adapter.UpdateCommand.Parameters.Add(new SqlParameter("@birthdate", SqlDbType.DateTime, 0, ParameterDirection.Input, (byte)0, (byte)0, "birthdate", DataRowVersion.Current, false, (object)null, "", "", ""));
		_adapter.UpdateCommand.Parameters.Add(new SqlParameter("@birthplace", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte)0, (byte)0, "birthplace", DataRowVersion.Current, false, (object)null, "", "", ""));
		_adapter.UpdateCommand.Parameters.Add(new SqlParameter("@lastgrad", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte)0, (byte)0, "lastgrad", DataRowVersion.Current, false, (object)null, "", "", ""));
		_adapter.UpdateCommand.Parameters.Add(new SqlParameter("@SSN", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte)0, (byte)0, "SSN", DataRowVersion.Current, false, (object)null, "", "", ""));
		_adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Labnum", SqlDbType.Int, 0, ParameterDirection.Input, (byte)0, (byte)0, "Labnum", DataRowVersion.Current, false, (object)null, "", "", ""));
		_adapter.UpdateCommand.Parameters.Add(new SqlParameter("@PsychologicallyStress", SqlDbType.Bit, 0, ParameterDirection.Input, (byte)0, (byte)0, "PsychologicallyStress", DataRowVersion.Current, false, (object)null, "", "", ""));
		_adapter.UpdateCommand.Parameters.Add(new SqlParameter("@height", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte)0, (byte)0, "height", DataRowVersion.Current, false, (object)null, "", "", ""));
		_adapter.UpdateCommand.Parameters.Add(new SqlParameter("@weight", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte)0, (byte)0, "weight", DataRowVersion.Current, false, (object)null, "", "", ""));
		_adapter.UpdateCommand.Parameters.Add(new SqlParameter("@eyecolor", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte)0, (byte)0, "eyecolor", DataRowVersion.Current, false, (object)null, "", "", ""));
		_adapter.UpdateCommand.Parameters.Add(new SqlParameter("@haircolor", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte)0, (byte)0, "haircolor", DataRowVersion.Current, false, (object)null, "", "", ""));
		_adapter.UpdateCommand.Parameters.Add(new SqlParameter("@bloodtype", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte)0, (byte)0, "bloodtype", DataRowVersion.Current, false, (object)null, "", "", ""));
		_adapter.UpdateCommand.Parameters.Add(new SqlParameter("@UserName", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte)0, (byte)0, "UserName", DataRowVersion.Current, false, (object)null, "", "", ""));
		_adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Code", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte)0, (byte)0, "Code", DataRowVersion.Current, false, (object)null, "", "", ""));
		_adapter.UpdateCommand.Parameters.Add(new SqlParameter("@race", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte)0, (byte)0, "race", DataRowVersion.Current, false, (object)null, "", "", ""));
		_adapter.UpdateCommand.Parameters.Add(new SqlParameter("@referral", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte)0, (byte)0, "referral", DataRowVersion.Current, false, (object)null, "", "", ""));
		_adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_UserName", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte)0, (byte)0, "UserName", DataRowVersion.Original, false, (object)null, "", "", ""));
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
		//IL_00c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cd: Expected Obj, but got Unknown
		//IL_00d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00db: Expected Obj, but got Unknown
		//IL_0140: Unknown result type (might be due to invalid IL or missing references)
		//IL_014a: Expected Obj, but got Unknown
		//IL_0182: Unknown result type (might be due to invalid IL or missing references)
		//IL_018c: Expected Obj, but got Unknown
		_commandCollection = new SqlCommand[3];
		_commandCollection[0] = new SqlCommand();
		_commandCollection[0].Connection = Connection;
		_commandCollection[0].CommandText = "SELECT UserInfo.* FROM UserInfo";
		_commandCollection[0].CommandType = CommandType.Text;
		_commandCollection[1] = new SqlCommand();
		_commandCollection[1].Connection = Connection;
		_commandCollection[1].CommandText = "SELECT Labnum FROM UserInfo WHERE (UserName = @username)";
		_commandCollection[1].CommandType = CommandType.Text;
		_commandCollection[1].Parameters.Add(new SqlParameter("@username", SqlDbType.NVarChar, 256, ParameterDirection.Input, (byte)0, (byte)0, "UserName", DataRowVersion.Current, false, (object)null, "", "", ""));
		_commandCollection[2] = new SqlCommand();
		_commandCollection[2].Connection = Connection;
		_commandCollection[2].CommandText = "UPDATE [UserInfo] SET  [Labnum] = @Labnum WHERE (([UserName] = @Original_UserName))";
		_commandCollection[2].CommandType = CommandType.Text;
		_commandCollection[2].Parameters.Add(new SqlParameter("@Labnum", SqlDbType.Int, 4, ParameterDirection.Input, (byte)0, (byte)0, "Labnum", DataRowVersion.Current, false, (object)null, "", "", ""));
		_commandCollection[2].Parameters.Add(new SqlParameter("@Original_UserName", SqlDbType.NVarChar, 256, ParameterDirection.Input, (byte)0, (byte)0, "UserName", DataRowVersion.Original, false, (object)null, "", "", ""));
	}

	[DataObjectMethod(DataObjectMethodType.Fill, true)]
	[DebuggerNonUserCode]
	[HelpKeyword("vs.data.TableAdapter")]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	public virtual int Fill(DataSet2.UserInfoDataTable dataTable)
	{
		Adapter.SelectCommand = CommandCollection[0];
		if (ClearBeforeFill)
		{
			dataTable.Clear();
		}
		return ((DbDataAdapter)(object)Adapter).Fill((DataTable)dataTable);
	}

	[HelpKeyword("vs.data.TableAdapter")]
	[DebuggerNonUserCode]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	[DataObjectMethod(DataObjectMethodType.Select, true)]
	public virtual DataSet2.UserInfoDataTable GetData()
	{
		Adapter.SelectCommand = CommandCollection[0];
		DataSet2.UserInfoDataTable userInfoDataTable = new DataSet2.UserInfoDataTable();
		((DbDataAdapter)(object)Adapter).Fill((DataTable)userInfoDataTable);
		return userInfoDataTable;
	}

	[DebuggerNonUserCode]
	[HelpKeyword("vs.data.TableAdapter")]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	public virtual int Update(DataSet2.UserInfoDataTable dataTable)
	{
		return ((DbDataAdapter)(object)Adapter).Update((DataTable)dataTable);
	}

	[HelpKeyword("vs.data.TableAdapter")]
	[DebuggerNonUserCode]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	public virtual int Update(DataSet2 dataSet)
	{
		return ((DbDataAdapter)(object)Adapter).Update((DataSet)dataSet, "UserInfo");
	}

	[HelpKeyword("vs.data.TableAdapter")]
	[DebuggerNonUserCode]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	public virtual int Update(DataRow dataRow)
	{
		return ((DbDataAdapter)(object)Adapter).Update(new DataRow[1] { dataRow });
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	[HelpKeyword("vs.data.TableAdapter")]
	[DebuggerNonUserCode]
	public virtual int Update(DataRow[] dataRows)
	{
		return ((DbDataAdapter)(object)Adapter).Update(dataRows);
	}

	[DataObjectMethod(DataObjectMethodType.Delete, true)]
	[HelpKeyword("vs.data.TableAdapter")]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	[DebuggerNonUserCode]
	public virtual int Delete(string Original_UserName)
	{
		if (Original_UserName == null)
		{
			throw new ArgumentNullException("Original_UserName");
		}
		Adapter.DeleteCommand.Parameters[0].Value = Original_UserName;
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

	[DebuggerNonUserCode]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	[DataObjectMethod(DataObjectMethodType.Insert, true)]
	[HelpKeyword("vs.data.TableAdapter")]
	public virtual int Insert(string Name, string sex, DateTime? RegisterDate, string Address, bool? Maried, short? NumberofChildren, string Sybling, string City, string State, string Zipcode, int areacode, int phonenumber, string occupation, string Habbies, DateTime birthdate, string birthplace, string lastgrad, string SSN, int Labnum, bool? PsychologicallyStress, string height, string weight, string eyecolor, string haircolor, string bloodtype, string UserName, string Code, string race, string referral)
	{
		if (Name == null)
		{
			throw new ArgumentNullException("Name");
		}
		Adapter.InsertCommand.Parameters[0].Value = Name;
		if (sex == null)
		{
			throw new ArgumentNullException("sex");
		}
		Adapter.InsertCommand.Parameters[1].Value = sex;
		if (RegisterDate.HasValue)
		{
			Adapter.InsertCommand.Parameters[2].Value = RegisterDate.Value;
		}
		else
		{
			Adapter.InsertCommand.Parameters[2].Value = DBNull.Value;
		}
		if (Address == null)
		{
			Adapter.InsertCommand.Parameters[3].Value = DBNull.Value;
		}
		else
		{
			Adapter.InsertCommand.Parameters[3].Value = Address;
		}
		if (Maried.HasValue)
		{
			Adapter.InsertCommand.Parameters[4].Value = Maried.Value;
		}
		else
		{
			Adapter.InsertCommand.Parameters[4].Value = DBNull.Value;
		}
		if (NumberofChildren.HasValue)
		{
			Adapter.InsertCommand.Parameters[5].Value = NumberofChildren.Value;
		}
		else
		{
			Adapter.InsertCommand.Parameters[5].Value = DBNull.Value;
		}
		if (Sybling == null)
		{
			Adapter.InsertCommand.Parameters[6].Value = DBNull.Value;
		}
		else
		{
			Adapter.InsertCommand.Parameters[6].Value = Sybling;
		}
		if (City == null)
		{
			Adapter.InsertCommand.Parameters[7].Value = DBNull.Value;
		}
		else
		{
			Adapter.InsertCommand.Parameters[7].Value = City;
		}
		if (State == null)
		{
			Adapter.InsertCommand.Parameters[8].Value = DBNull.Value;
		}
		else
		{
			Adapter.InsertCommand.Parameters[8].Value = State;
		}
		if (Zipcode == null)
		{
			throw new ArgumentNullException("Zipcode");
		}
		Adapter.InsertCommand.Parameters[9].Value = Zipcode;
		Adapter.InsertCommand.Parameters[10].Value = areacode;
		Adapter.InsertCommand.Parameters[11].Value = phonenumber;
		if (occupation == null)
		{
			Adapter.InsertCommand.Parameters[12].Value = DBNull.Value;
		}
		else
		{
			Adapter.InsertCommand.Parameters[12].Value = occupation;
		}
		if (Habbies == null)
		{
			Adapter.InsertCommand.Parameters[13].Value = DBNull.Value;
		}
		else
		{
			Adapter.InsertCommand.Parameters[13].Value = Habbies;
		}
		Adapter.InsertCommand.Parameters[14].Value = birthdate;
		if (birthplace == null)
		{
			Adapter.InsertCommand.Parameters[15].Value = DBNull.Value;
		}
		else
		{
			Adapter.InsertCommand.Parameters[15].Value = birthplace;
		}
		if (lastgrad == null)
		{
			Adapter.InsertCommand.Parameters[16].Value = DBNull.Value;
		}
		else
		{
			Adapter.InsertCommand.Parameters[16].Value = lastgrad;
		}
		if (SSN == null)
		{
			Adapter.InsertCommand.Parameters[17].Value = DBNull.Value;
		}
		else
		{
			Adapter.InsertCommand.Parameters[17].Value = SSN;
		}
		Adapter.InsertCommand.Parameters[18].Value = Labnum;
		if (PsychologicallyStress.HasValue)
		{
			Adapter.InsertCommand.Parameters[19].Value = PsychologicallyStress.Value;
		}
		else
		{
			Adapter.InsertCommand.Parameters[19].Value = DBNull.Value;
		}
		if (height == null)
		{
			Adapter.InsertCommand.Parameters[20].Value = DBNull.Value;
		}
		else
		{
			Adapter.InsertCommand.Parameters[20].Value = height;
		}
		if (weight == null)
		{
			Adapter.InsertCommand.Parameters[21].Value = DBNull.Value;
		}
		else
		{
			Adapter.InsertCommand.Parameters[21].Value = weight;
		}
		if (eyecolor == null)
		{
			Adapter.InsertCommand.Parameters[22].Value = DBNull.Value;
		}
		else
		{
			Adapter.InsertCommand.Parameters[22].Value = eyecolor;
		}
		if (haircolor == null)
		{
			Adapter.InsertCommand.Parameters[23].Value = DBNull.Value;
		}
		else
		{
			Adapter.InsertCommand.Parameters[23].Value = haircolor;
		}
		if (bloodtype == null)
		{
			Adapter.InsertCommand.Parameters[24].Value = DBNull.Value;
		}
		else
		{
			Adapter.InsertCommand.Parameters[24].Value = bloodtype;
		}
		if (UserName == null)
		{
			throw new ArgumentNullException("UserName");
		}
		Adapter.InsertCommand.Parameters[25].Value = UserName;
		if (Code == null)
		{
			Adapter.InsertCommand.Parameters[26].Value = DBNull.Value;
		}
		else
		{
			Adapter.InsertCommand.Parameters[26].Value = Code;
		}
		if (race == null)
		{
			Adapter.InsertCommand.Parameters[27].Value = DBNull.Value;
		}
		else
		{
			Adapter.InsertCommand.Parameters[27].Value = race;
		}
		if (referral == null)
		{
			Adapter.InsertCommand.Parameters[28].Value = DBNull.Value;
		}
		else
		{
			Adapter.InsertCommand.Parameters[28].Value = referral;
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
	[DataObjectMethod(DataObjectMethodType.Update, true)]
	[HelpKeyword("vs.data.TableAdapter")]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	public virtual int Update(string Name, string sex, DateTime? RegisterDate, string Address, bool? Maried, short? NumberofChildren, string Sybling, string City, string State, string Zipcode, int areacode, int phonenumber, string occupation, string Habbies, DateTime birthdate, string birthplace, string lastgrad, string SSN, int Labnum, bool? PsychologicallyStress, string height, string weight, string eyecolor, string haircolor, string bloodtype, string UserName, string Code, string race, string referral, string Original_UserName)
	{
		if (Name == null)
		{
			throw new ArgumentNullException("Name");
		}
		Adapter.UpdateCommand.Parameters[0].Value = Name;
		if (sex == null)
		{
			throw new ArgumentNullException("sex");
		}
		Adapter.UpdateCommand.Parameters[1].Value = sex;
		if (RegisterDate.HasValue)
		{
			Adapter.UpdateCommand.Parameters[2].Value = RegisterDate.Value;
		}
		else
		{
			Adapter.UpdateCommand.Parameters[2].Value = DBNull.Value;
		}
		if (Address == null)
		{
			Adapter.UpdateCommand.Parameters[3].Value = DBNull.Value;
		}
		else
		{
			Adapter.UpdateCommand.Parameters[3].Value = Address;
		}
		if (Maried.HasValue)
		{
			Adapter.UpdateCommand.Parameters[4].Value = Maried.Value;
		}
		else
		{
			Adapter.UpdateCommand.Parameters[4].Value = DBNull.Value;
		}
		if (NumberofChildren.HasValue)
		{
			Adapter.UpdateCommand.Parameters[5].Value = NumberofChildren.Value;
		}
		else
		{
			Adapter.UpdateCommand.Parameters[5].Value = DBNull.Value;
		}
		if (Sybling == null)
		{
			Adapter.UpdateCommand.Parameters[6].Value = DBNull.Value;
		}
		else
		{
			Adapter.UpdateCommand.Parameters[6].Value = Sybling;
		}
		if (City == null)
		{
			Adapter.UpdateCommand.Parameters[7].Value = DBNull.Value;
		}
		else
		{
			Adapter.UpdateCommand.Parameters[7].Value = City;
		}
		if (State == null)
		{
			Adapter.UpdateCommand.Parameters[8].Value = DBNull.Value;
		}
		else
		{
			Adapter.UpdateCommand.Parameters[8].Value = State;
		}
		if (Zipcode == null)
		{
			throw new ArgumentNullException("Zipcode");
		}
		Adapter.UpdateCommand.Parameters[9].Value = Zipcode;
		Adapter.UpdateCommand.Parameters[10].Value = areacode;
		Adapter.UpdateCommand.Parameters[11].Value = phonenumber;
		if (occupation == null)
		{
			Adapter.UpdateCommand.Parameters[12].Value = DBNull.Value;
		}
		else
		{
			Adapter.UpdateCommand.Parameters[12].Value = occupation;
		}
		if (Habbies == null)
		{
			Adapter.UpdateCommand.Parameters[13].Value = DBNull.Value;
		}
		else
		{
			Adapter.UpdateCommand.Parameters[13].Value = Habbies;
		}
		Adapter.UpdateCommand.Parameters[14].Value = birthdate;
		if (birthplace == null)
		{
			Adapter.UpdateCommand.Parameters[15].Value = DBNull.Value;
		}
		else
		{
			Adapter.UpdateCommand.Parameters[15].Value = birthplace;
		}
		if (lastgrad == null)
		{
			Adapter.UpdateCommand.Parameters[16].Value = DBNull.Value;
		}
		else
		{
			Adapter.UpdateCommand.Parameters[16].Value = lastgrad;
		}
		if (SSN == null)
		{
			Adapter.UpdateCommand.Parameters[17].Value = DBNull.Value;
		}
		else
		{
			Adapter.UpdateCommand.Parameters[17].Value = SSN;
		}
		Adapter.UpdateCommand.Parameters[18].Value = Labnum;
		if (PsychologicallyStress.HasValue)
		{
			Adapter.UpdateCommand.Parameters[19].Value = PsychologicallyStress.Value;
		}
		else
		{
			Adapter.UpdateCommand.Parameters[19].Value = DBNull.Value;
		}
		if (height == null)
		{
			Adapter.UpdateCommand.Parameters[20].Value = DBNull.Value;
		}
		else
		{
			Adapter.UpdateCommand.Parameters[20].Value = height;
		}
		if (weight == null)
		{
			Adapter.UpdateCommand.Parameters[21].Value = DBNull.Value;
		}
		else
		{
			Adapter.UpdateCommand.Parameters[21].Value = weight;
		}
		if (eyecolor == null)
		{
			Adapter.UpdateCommand.Parameters[22].Value = DBNull.Value;
		}
		else
		{
			Adapter.UpdateCommand.Parameters[22].Value = eyecolor;
		}
		if (haircolor == null)
		{
			Adapter.UpdateCommand.Parameters[23].Value = DBNull.Value;
		}
		else
		{
			Adapter.UpdateCommand.Parameters[23].Value = haircolor;
		}
		if (bloodtype == null)
		{
			Adapter.UpdateCommand.Parameters[24].Value = DBNull.Value;
		}
		else
		{
			Adapter.UpdateCommand.Parameters[24].Value = bloodtype;
		}
		if (UserName == null)
		{
			throw new ArgumentNullException("UserName");
		}
		Adapter.UpdateCommand.Parameters[25].Value = UserName;
		if (Code == null)
		{
			Adapter.UpdateCommand.Parameters[26].Value = DBNull.Value;
		}
		else
		{
			Adapter.UpdateCommand.Parameters[26].Value = Code;
		}
		if (race == null)
		{
			Adapter.UpdateCommand.Parameters[27].Value = DBNull.Value;
		}
		else
		{
			Adapter.UpdateCommand.Parameters[27].Value = race;
		}
		if (referral == null)
		{
			Adapter.UpdateCommand.Parameters[28].Value = DBNull.Value;
		}
		else
		{
			Adapter.UpdateCommand.Parameters[28].Value = referral;
		}
		if (Original_UserName == null)
		{
			throw new ArgumentNullException("Original_UserName");
		}
		Adapter.UpdateCommand.Parameters[29].Value = Original_UserName;
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
	public virtual int Update(string Name, string sex, DateTime? RegisterDate, string Address, bool? Maried, short? NumberofChildren, string Sybling, string City, string State, string Zipcode, int areacode, int phonenumber, string occupation, string Habbies, DateTime birthdate, string birthplace, string lastgrad, string SSN, int Labnum, bool? PsychologicallyStress, string height, string weight, string eyecolor, string haircolor, string bloodtype, string Code, string race, string referral, string Original_UserName)
	{
		return Update(Name, sex, RegisterDate, Address, Maried, NumberofChildren, Sybling, City, State, Zipcode, areacode, phonenumber, occupation, Habbies, birthdate, birthplace, lastgrad, SSN, Labnum, PsychologicallyStress, height, weight, eyecolor, haircolor, bloodtype, Original_UserName, Code, race, referral, Original_UserName);
	}

	[HelpKeyword("vs.data.TableAdapter")]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	[DebuggerNonUserCode]
	public virtual object ScalarQuery(string username)
	{
		SqlCommand val = CommandCollection[1];
		if (username == null)
		{
			throw new ArgumentNullException("username");
		}
		val.Parameters[0].Value = username;
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
	[DataObjectMethod(DataObjectMethodType.Update, false)]
	[HelpKeyword("vs.data.TableAdapter")]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	public virtual int UpdateNum(int Labnum, string Original_UserName)
	{
		SqlCommand val = CommandCollection[2];
		val.Parameters[0].Value = Labnum;
		if (Original_UserName == null)
		{
			throw new ArgumentNullException("Original_UserName");
		}
		val.Parameters[1].Value = Original_UserName;
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
