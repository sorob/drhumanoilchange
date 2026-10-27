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

namespace userinfoTableAdapters;

[DesignerCategory("code")]
[HelpKeyword("vs.data.TableAdapter")]
[ToolboxItem(true)]
[Designer("Microsoft.VSDesigner.DataSource.Design.TableAdapterDesigner, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
[DataObject(true)]
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

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	[DebuggerNonUserCode]
	public UserInfoTableAdapter()
	{
		ClearBeforeFill = true;
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	[DebuggerNonUserCode]
	private void InitAdapter()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected Obj, but got Unknown
		//IL_0291: Unknown result type (might be due to invalid IL or missing references)
		//IL_029b: Expected Obj, but got Unknown
		//IL_030d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0317: Expected Obj, but got Unknown
		//IL_031e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0328: Expected Obj, but got Unknown
		//IL_039a: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a4: Expected Obj, but got Unknown
		//IL_03db: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e5: Expected Obj, but got Unknown
		//IL_041b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0425: Expected Obj, but got Unknown
		//IL_045c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0466: Expected Obj, but got Unknown
		//IL_049c: Unknown result type (might be due to invalid IL or missing references)
		//IL_04a6: Expected Obj, but got Unknown
		//IL_04dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_04e7: Expected Obj, but got Unknown
		//IL_051e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0528: Expected Obj, but got Unknown
		//IL_055f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0569: Expected Obj, but got Unknown
		//IL_05a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_05aa: Expected Obj, but got Unknown
		//IL_05e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_05eb: Expected Obj, but got Unknown
		//IL_0621: Unknown result type (might be due to invalid IL or missing references)
		//IL_062b: Expected Obj, but got Unknown
		//IL_0661: Unknown result type (might be due to invalid IL or missing references)
		//IL_066b: Expected Obj, but got Unknown
		//IL_06a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_06ac: Expected Obj, but got Unknown
		//IL_06e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_06ed: Expected Obj, but got Unknown
		//IL_0723: Unknown result type (might be due to invalid IL or missing references)
		//IL_072d: Expected Obj, but got Unknown
		//IL_0764: Unknown result type (might be due to invalid IL or missing references)
		//IL_076e: Expected Obj, but got Unknown
		//IL_07a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_07af: Expected Obj, but got Unknown
		//IL_07e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_07f0: Expected Obj, but got Unknown
		//IL_0826: Unknown result type (might be due to invalid IL or missing references)
		//IL_0830: Expected Obj, but got Unknown
		//IL_0866: Unknown result type (might be due to invalid IL or missing references)
		//IL_0870: Expected Obj, but got Unknown
		//IL_08a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_08b1: Expected Obj, but got Unknown
		//IL_08e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_08f2: Expected Obj, but got Unknown
		//IL_0929: Unknown result type (might be due to invalid IL or missing references)
		//IL_0933: Expected Obj, but got Unknown
		//IL_096a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0974: Expected Obj, but got Unknown
		//IL_09ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_09b5: Expected Obj, but got Unknown
		//IL_09ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_09f6: Expected Obj, but got Unknown
		//IL_0a2d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a37: Expected Obj, but got Unknown
		//IL_0a3e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a48: Expected Obj, but got Unknown
		//IL_0aba: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ac4: Expected Obj, but got Unknown
		//IL_0afb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b05: Expected Obj, but got Unknown
		//IL_0b3b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b45: Expected Obj, but got Unknown
		//IL_0b7c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b86: Expected Obj, but got Unknown
		//IL_0bbc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bc6: Expected Obj, but got Unknown
		//IL_0bfd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c07: Expected Obj, but got Unknown
		//IL_0c3e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c48: Expected Obj, but got Unknown
		//IL_0c7f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c89: Expected Obj, but got Unknown
		//IL_0cc0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cca: Expected Obj, but got Unknown
		//IL_0d01: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d0b: Expected Obj, but got Unknown
		//IL_0d41: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d4b: Expected Obj, but got Unknown
		//IL_0d81: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d8b: Expected Obj, but got Unknown
		//IL_0dc2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0dcc: Expected Obj, but got Unknown
		//IL_0e03: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e0d: Expected Obj, but got Unknown
		//IL_0e43: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e4d: Expected Obj, but got Unknown
		//IL_0e84: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e8e: Expected Obj, but got Unknown
		//IL_0ec5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ecf: Expected Obj, but got Unknown
		//IL_0f06: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f10: Expected Obj, but got Unknown
		//IL_0f46: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f50: Expected Obj, but got Unknown
		//IL_0f86: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f90: Expected Obj, but got Unknown
		//IL_0fc7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fd1: Expected Obj, but got Unknown
		//IL_1008: Unknown result type (might be due to invalid IL or missing references)
		//IL_1012: Expected Obj, but got Unknown
		//IL_1049: Unknown result type (might be due to invalid IL or missing references)
		//IL_1053: Expected Obj, but got Unknown
		//IL_108a: Unknown result type (might be due to invalid IL or missing references)
		//IL_1094: Expected Obj, but got Unknown
		//IL_10cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_10d5: Expected Obj, but got Unknown
		//IL_110c: Unknown result type (might be due to invalid IL or missing references)
		//IL_1116: Expected Obj, but got Unknown
		//IL_114d: Unknown result type (might be due to invalid IL or missing references)
		//IL_1157: Expected Obj, but got Unknown
		//IL_118e: Unknown result type (might be due to invalid IL or missing references)
		//IL_1198: Expected Obj, but got Unknown
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
		((DataAdapter)(object)_adapter).TableMappings.Add(dataTableMapping);
		_adapter.DeleteCommand = new SqlCommand();
		_adapter.DeleteCommand.Connection = Connection;
		_adapter.DeleteCommand.CommandText = "DELETE FROM [UserInfo] WHERE (([UserName] = @Original_UserName))";
		_adapter.DeleteCommand.CommandType = CommandType.Text;
		_adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_UserName", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte)0, (byte)0, "UserName", DataRowVersion.Original, false, (object)null, "", "", ""));
		_adapter.InsertCommand = new SqlCommand();
		_adapter.InsertCommand.Connection = Connection;
		_adapter.InsertCommand.CommandText = "INSERT INTO [UserInfo] ([Name], [sex], [RegisterDate], [Address], [Maried], [NumberofChildren], [Sybling], [City], [State], [Zipcode], [areacode], [phonenumber], [occupation], [Habbies], [birthdate], [birthplace], [lastgrad], [SSN], [Labnum], [PsychologicallyStress], [height], [weight], [eyecolor], [haircolor], [bloodtype], [UserName], [Code]) VALUES (@Name, @sex, @RegisterDate, @Address, @Maried, @NumberofChildren, @Sybling, @City, @State, @Zipcode, @areacode, @phonenumber, @occupation, @Habbies, @birthdate, @birthplace, @lastgrad, @SSN, @Labnum, @PsychologicallyStress, @height, @weight, @eyecolor, @haircolor, @bloodtype, @UserName, @Code)";
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
		_adapter.UpdateCommand = new SqlCommand();
		_adapter.UpdateCommand.Connection = Connection;
		_adapter.UpdateCommand.CommandText = "UPDATE [UserInfo] SET [Name] = @Name, [sex] = @sex, [RegisterDate] = @RegisterDate, [Address] = @Address, [Maried] = @Maried, [NumberofChildren] = @NumberofChildren, [Sybling] = @Sybling, [City] = @City, [State] = @State, [Zipcode] = @Zipcode, [areacode] = @areacode, [phonenumber] = @phonenumber, [occupation] = @occupation, [Habbies] = @Habbies, [birthdate] = @birthdate, [birthplace] = @birthplace, [lastgrad] = @lastgrad, [SSN] = @SSN, [Labnum] = @Labnum, [PsychologicallyStress] = @PsychologicallyStress, [height] = @height, [weight] = @weight, [eyecolor] = @eyecolor, [haircolor] = @haircolor, [bloodtype] = @bloodtype, [UserName] = @UserName, [Code] = @Code WHERE (([UserName] = @Original_UserName))";
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
		_adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_UserName", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte)0, (byte)0, "UserName", DataRowVersion.Original, false, (object)null, "", "", ""));
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
		_commandCollection = new SqlCommand[1];
		_commandCollection[0] = new SqlCommand();
		_commandCollection[0].Connection = Connection;
		_commandCollection[0].CommandText = "SELECT     Name, sex, RegisterDate, Address, Maried, NumberofChildren, Sybling, City, State, Zipcode, areacode, phonenumber, occupation, Habbies, birthdate, \r\n                      birthplace, lastgrad, SSN, Labnum, PsychologicallyStress, height, weight, eyecolor, haircolor, bloodtype, UserName, Code\r\nFROM         UserInfo\r\nWHERE     (UserName = @un)";
		_commandCollection[0].CommandType = CommandType.Text;
		_commandCollection[0].Parameters.Add(new SqlParameter("@un", SqlDbType.NVarChar, 256, ParameterDirection.Input, (byte)0, (byte)0, "UserName", DataRowVersion.Current, false, (object)null, "", "", ""));
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	[DataObjectMethod(DataObjectMethodType.Fill, true)]
	[HelpKeyword("vs.data.TableAdapter")]
	[DebuggerNonUserCode]
	public virtual int Fill(userinfo.UserInfoDataTable dataTable, string un)
	{
		Adapter.SelectCommand = CommandCollection[0];
		if (un == null)
		{
			throw new ArgumentNullException("un");
		}
		Adapter.SelectCommand.Parameters[0].Value = un;
		if (ClearBeforeFill)
		{
			dataTable.Clear();
		}
		return ((DbDataAdapter)(object)Adapter).Fill((DataTable)dataTable);
	}

	[DebuggerNonUserCode]
	[HelpKeyword("vs.data.TableAdapter")]
	[DataObjectMethod(DataObjectMethodType.Select, true)]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	public virtual userinfo.UserInfoDataTable GetData(string un)
	{
		Adapter.SelectCommand = CommandCollection[0];
		if (un == null)
		{
			throw new ArgumentNullException("un");
		}
		Adapter.SelectCommand.Parameters[0].Value = un;
		userinfo.UserInfoDataTable userInfoDataTable = new userinfo.UserInfoDataTable();
		((DbDataAdapter)(object)Adapter).Fill((DataTable)userInfoDataTable);
		return userInfoDataTable;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	[HelpKeyword("vs.data.TableAdapter")]
	public virtual int Update(userinfo.UserInfoDataTable dataTable)
	{
		return ((DbDataAdapter)(object)Adapter).Update((DataTable)dataTable);
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	[DebuggerNonUserCode]
	[HelpKeyword("vs.data.TableAdapter")]
	public virtual int Update(userinfo dataSet)
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
	[DebuggerNonUserCode]
	[HelpKeyword("vs.data.TableAdapter")]
	public virtual int Update(DataRow[] dataRows)
	{
		return ((DbDataAdapter)(object)Adapter).Update(dataRows);
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	[DataObjectMethod(DataObjectMethodType.Delete, true)]
	[HelpKeyword("vs.data.TableAdapter")]
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

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	[DebuggerNonUserCode]
	[DataObjectMethod(DataObjectMethodType.Insert, true)]
	[HelpKeyword("vs.data.TableAdapter")]
	public virtual int Insert(string Name, string sex, DateTime? RegisterDate, string Address, bool? Maried, short? NumberofChildren, string Sybling, string City, string State, string Zipcode, int areacode, int phonenumber, string occupation, string Habbies, DateTime birthdate, string birthplace, string lastgrad, string SSN, int Labnum, bool? PsychologicallyStress, string height, string weight, string eyecolor, string haircolor, string bloodtype, string UserName, string Code)
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
	[DataObjectMethod(DataObjectMethodType.Update, true)]
	[DebuggerNonUserCode]
	[HelpKeyword("vs.data.TableAdapter")]
	public virtual int Update(string Name, string sex, DateTime? RegisterDate, string Address, bool? Maried, short? NumberofChildren, string Sybling, string City, string State, string Zipcode, int areacode, int phonenumber, string occupation, string Habbies, DateTime birthdate, string birthplace, string lastgrad, string SSN, int Labnum, bool? PsychologicallyStress, string height, string weight, string eyecolor, string haircolor, string bloodtype, string UserName, string Code, string Original_UserName)
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
		if (Original_UserName == null)
		{
			throw new ArgumentNullException("Original_UserName");
		}
		Adapter.UpdateCommand.Parameters[27].Value = Original_UserName;
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
	[DataObjectMethod(DataObjectMethodType.Update, true)]
	[HelpKeyword("vs.data.TableAdapter")]
	public virtual int Update(string Name, string sex, DateTime? RegisterDate, string Address, bool? Maried, short? NumberofChildren, string Sybling, string City, string State, string Zipcode, int areacode, int phonenumber, string occupation, string Habbies, DateTime birthdate, string birthplace, string lastgrad, string SSN, int Labnum, bool? PsychologicallyStress, string height, string weight, string eyecolor, string haircolor, string bloodtype, string Code, string Original_UserName)
	{
		return Update(Name, sex, RegisterDate, Address, Maried, NumberofChildren, Sybling, City, State, Zipcode, areacode, phonenumber, occupation, Habbies, birthdate, birthplace, lastgrad, SSN, Labnum, PsychologicallyStress, height, weight, eyecolor, haircolor, bloodtype, Original_UserName, Code, Original_UserName);
	}
}
