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

[DataObject(true)]
[DesignerCategory("code")]
[Designer("Microsoft.VSDesigner.DataSource.Design.TableAdapterDesigner, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
[HelpKeyword("vs.data.TableAdapter")]
[ToolboxItem(true)]
public class aspnet_MembershipTableAdapter : Component
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

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	[DebuggerNonUserCode]
	public aspnet_MembershipTableAdapter()
	{
		ClearBeforeFill = true;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	private void InitAdapter()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected Obj, but got Unknown
		//IL_020d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0217: Expected Obj, but got Unknown
		//IL_0289: Unknown result type (might be due to invalid IL or missing references)
		//IL_0293: Expected Obj, but got Unknown
		//IL_029a: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a4: Expected Obj, but got Unknown
		//IL_0316: Unknown result type (might be due to invalid IL or missing references)
		//IL_0320: Expected Obj, but got Unknown
		//IL_0357: Unknown result type (might be due to invalid IL or missing references)
		//IL_0361: Expected Obj, but got Unknown
		//IL_0398: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a2: Expected Obj, but got Unknown
		//IL_03d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e2: Expected Obj, but got Unknown
		//IL_0419: Unknown result type (might be due to invalid IL or missing references)
		//IL_0423: Expected Obj, but got Unknown
		//IL_045a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0464: Expected Obj, but got Unknown
		//IL_049b: Unknown result type (might be due to invalid IL or missing references)
		//IL_04a5: Expected Obj, but got Unknown
		//IL_04dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_04e6: Expected Obj, but got Unknown
		//IL_051d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0527: Expected Obj, but got Unknown
		//IL_055e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0568: Expected Obj, but got Unknown
		//IL_059e: Unknown result type (might be due to invalid IL or missing references)
		//IL_05a8: Expected Obj, but got Unknown
		//IL_05de: Unknown result type (might be due to invalid IL or missing references)
		//IL_05e8: Expected Obj, but got Unknown
		//IL_061e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0628: Expected Obj, but got Unknown
		//IL_065e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0668: Expected Obj, but got Unknown
		//IL_069e: Unknown result type (might be due to invalid IL or missing references)
		//IL_06a8: Expected Obj, but got Unknown
		//IL_06de: Unknown result type (might be due to invalid IL or missing references)
		//IL_06e8: Expected Obj, but got Unknown
		//IL_071e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0728: Expected Obj, but got Unknown
		//IL_075e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0768: Expected Obj, but got Unknown
		//IL_079e: Unknown result type (might be due to invalid IL or missing references)
		//IL_07a8: Expected Obj, but got Unknown
		//IL_07de: Unknown result type (might be due to invalid IL or missing references)
		//IL_07e8: Expected Obj, but got Unknown
		//IL_081f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0829: Expected Obj, but got Unknown
		//IL_0830: Unknown result type (might be due to invalid IL or missing references)
		//IL_083a: Expected Obj, but got Unknown
		//IL_08ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_08b6: Expected Obj, but got Unknown
		//IL_08ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_08f7: Expected Obj, but got Unknown
		//IL_092e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0938: Expected Obj, but got Unknown
		//IL_096e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0978: Expected Obj, but got Unknown
		//IL_09af: Unknown result type (might be due to invalid IL or missing references)
		//IL_09b9: Expected Obj, but got Unknown
		//IL_09f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_09fa: Expected Obj, but got Unknown
		//IL_0a31: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a3b: Expected Obj, but got Unknown
		//IL_0a72: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a7c: Expected Obj, but got Unknown
		//IL_0ab3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0abd: Expected Obj, but got Unknown
		//IL_0af4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0afe: Expected Obj, but got Unknown
		//IL_0b34: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b3e: Expected Obj, but got Unknown
		//IL_0b74: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b7e: Expected Obj, but got Unknown
		//IL_0bb4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bbe: Expected Obj, but got Unknown
		//IL_0bf4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bfe: Expected Obj, but got Unknown
		//IL_0c34: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c3e: Expected Obj, but got Unknown
		//IL_0c74: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c7e: Expected Obj, but got Unknown
		//IL_0cb4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cbe: Expected Obj, but got Unknown
		//IL_0cf4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cfe: Expected Obj, but got Unknown
		//IL_0d34: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d3e: Expected Obj, but got Unknown
		//IL_0d74: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d7e: Expected Obj, but got Unknown
		//IL_0db5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0dbf: Expected Obj, but got Unknown
		//IL_0df6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e00: Expected Obj, but got Unknown
		_adapter = new SqlDataAdapter();
		DataTableMapping dataTableMapping = new DataTableMapping();
		dataTableMapping.SourceTable = "Table";
		dataTableMapping.DataSetTable = "aspnet_Membership";
		dataTableMapping.ColumnMappings.Add("ApplicationId", "ApplicationId");
		dataTableMapping.ColumnMappings.Add("UserId", "UserId");
		dataTableMapping.ColumnMappings.Add("Password", "Password");
		dataTableMapping.ColumnMappings.Add("PasswordFormat", "PasswordFormat");
		dataTableMapping.ColumnMappings.Add("PasswordSalt", "PasswordSalt");
		dataTableMapping.ColumnMappings.Add("MobilePIN", "MobilePIN");
		dataTableMapping.ColumnMappings.Add("Email", "Email");
		dataTableMapping.ColumnMappings.Add("LoweredEmail", "LoweredEmail");
		dataTableMapping.ColumnMappings.Add("PasswordQuestion", "PasswordQuestion");
		dataTableMapping.ColumnMappings.Add("PasswordAnswer", "PasswordAnswer");
		dataTableMapping.ColumnMappings.Add("IsApproved", "IsApproved");
		dataTableMapping.ColumnMappings.Add("IsLockedOut", "IsLockedOut");
		dataTableMapping.ColumnMappings.Add("CreateDate", "CreateDate");
		dataTableMapping.ColumnMappings.Add("LastLoginDate", "LastLoginDate");
		dataTableMapping.ColumnMappings.Add("LastPasswordChangedDate", "LastPasswordChangedDate");
		dataTableMapping.ColumnMappings.Add("LastLockoutDate", "LastLockoutDate");
		dataTableMapping.ColumnMappings.Add("FailedPasswordAttemptCount", "FailedPasswordAttemptCount");
		dataTableMapping.ColumnMappings.Add("FailedPasswordAttemptWindowStart", "FailedPasswordAttemptWindowStart");
		dataTableMapping.ColumnMappings.Add("FailedPasswordAnswerAttemptCount", "FailedPasswordAnswerAttemptCount");
		dataTableMapping.ColumnMappings.Add("FailedPasswordAnswerAttemptWindowStart", "FailedPasswordAnswerAttemptWindowStart");
		dataTableMapping.ColumnMappings.Add("Comment", "Comment");
		((DataAdapter)(object)_adapter).TableMappings.Add(dataTableMapping);
		_adapter.DeleteCommand = new SqlCommand();
		_adapter.DeleteCommand.Connection = Connection;
		_adapter.DeleteCommand.CommandText = "DELETE FROM [dbo].[aspnet_Membership] WHERE (([UserId] = @Original_UserId))";
		_adapter.DeleteCommand.CommandType = CommandType.Text;
		_adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_UserId", SqlDbType.UniqueIdentifier, 0, ParameterDirection.Input, (byte)0, (byte)0, "UserId", DataRowVersion.Original, false, (object)null, "", "", ""));
		_adapter.InsertCommand = new SqlCommand();
		_adapter.InsertCommand.Connection = Connection;
		_adapter.InsertCommand.CommandText = "INSERT INTO [dbo].[aspnet_Membership] ([ApplicationId], [UserId], [Password], [PasswordFormat], [PasswordSalt], [MobilePIN], [Email], [LoweredEmail], [PasswordQuestion], [PasswordAnswer], [IsApproved], [IsLockedOut], [CreateDate], [LastLoginDate], [LastPasswordChangedDate], [LastLockoutDate], [FailedPasswordAttemptCount], [FailedPasswordAttemptWindowStart], [FailedPasswordAnswerAttemptCount], [FailedPasswordAnswerAttemptWindowStart], [Comment]) VALUES (@ApplicationId, @UserId, @Password, @PasswordFormat, @PasswordSalt, @MobilePIN, @Email, @LoweredEmail, @PasswordQuestion, @PasswordAnswer, @IsApproved, @IsLockedOut, @CreateDate, @LastLoginDate, @LastPasswordChangedDate, @LastLockoutDate, @FailedPasswordAttemptCount, @FailedPasswordAttemptWindowStart, @FailedPasswordAnswerAttemptCount, @FailedPasswordAnswerAttemptWindowStart, @Comment)";
		_adapter.InsertCommand.CommandType = CommandType.Text;
		_adapter.InsertCommand.Parameters.Add(new SqlParameter("@ApplicationId", SqlDbType.UniqueIdentifier, 0, ParameterDirection.Input, (byte)0, (byte)0, "ApplicationId", DataRowVersion.Current, false, (object)null, "", "", ""));
		_adapter.InsertCommand.Parameters.Add(new SqlParameter("@UserId", SqlDbType.UniqueIdentifier, 0, ParameterDirection.Input, (byte)0, (byte)0, "UserId", DataRowVersion.Current, false, (object)null, "", "", ""));
		_adapter.InsertCommand.Parameters.Add(new SqlParameter("@Password", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte)0, (byte)0, "Password", DataRowVersion.Current, false, (object)null, "", "", ""));
		_adapter.InsertCommand.Parameters.Add(new SqlParameter("@PasswordFormat", SqlDbType.Int, 0, ParameterDirection.Input, (byte)0, (byte)0, "PasswordFormat", DataRowVersion.Current, false, (object)null, "", "", ""));
		_adapter.InsertCommand.Parameters.Add(new SqlParameter("@PasswordSalt", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte)0, (byte)0, "PasswordSalt", DataRowVersion.Current, false, (object)null, "", "", ""));
		_adapter.InsertCommand.Parameters.Add(new SqlParameter("@MobilePIN", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte)0, (byte)0, "MobilePIN", DataRowVersion.Current, false, (object)null, "", "", ""));
		_adapter.InsertCommand.Parameters.Add(new SqlParameter("@Email", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte)0, (byte)0, "Email", DataRowVersion.Current, false, (object)null, "", "", ""));
		_adapter.InsertCommand.Parameters.Add(new SqlParameter("@LoweredEmail", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte)0, (byte)0, "LoweredEmail", DataRowVersion.Current, false, (object)null, "", "", ""));
		_adapter.InsertCommand.Parameters.Add(new SqlParameter("@PasswordQuestion", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte)0, (byte)0, "PasswordQuestion", DataRowVersion.Current, false, (object)null, "", "", ""));
		_adapter.InsertCommand.Parameters.Add(new SqlParameter("@PasswordAnswer", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte)0, (byte)0, "PasswordAnswer", DataRowVersion.Current, false, (object)null, "", "", ""));
		_adapter.InsertCommand.Parameters.Add(new SqlParameter("@IsApproved", SqlDbType.Bit, 0, ParameterDirection.Input, (byte)0, (byte)0, "IsApproved", DataRowVersion.Current, false, (object)null, "", "", ""));
		_adapter.InsertCommand.Parameters.Add(new SqlParameter("@IsLockedOut", SqlDbType.Bit, 0, ParameterDirection.Input, (byte)0, (byte)0, "IsLockedOut", DataRowVersion.Current, false, (object)null, "", "", ""));
		_adapter.InsertCommand.Parameters.Add(new SqlParameter("@CreateDate", SqlDbType.DateTime, 0, ParameterDirection.Input, (byte)0, (byte)0, "CreateDate", DataRowVersion.Current, false, (object)null, "", "", ""));
		_adapter.InsertCommand.Parameters.Add(new SqlParameter("@LastLoginDate", SqlDbType.DateTime, 0, ParameterDirection.Input, (byte)0, (byte)0, "LastLoginDate", DataRowVersion.Current, false, (object)null, "", "", ""));
		_adapter.InsertCommand.Parameters.Add(new SqlParameter("@LastPasswordChangedDate", SqlDbType.DateTime, 0, ParameterDirection.Input, (byte)0, (byte)0, "LastPasswordChangedDate", DataRowVersion.Current, false, (object)null, "", "", ""));
		_adapter.InsertCommand.Parameters.Add(new SqlParameter("@LastLockoutDate", SqlDbType.DateTime, 0, ParameterDirection.Input, (byte)0, (byte)0, "LastLockoutDate", DataRowVersion.Current, false, (object)null, "", "", ""));
		_adapter.InsertCommand.Parameters.Add(new SqlParameter("@FailedPasswordAttemptCount", SqlDbType.Int, 0, ParameterDirection.Input, (byte)0, (byte)0, "FailedPasswordAttemptCount", DataRowVersion.Current, false, (object)null, "", "", ""));
		_adapter.InsertCommand.Parameters.Add(new SqlParameter("@FailedPasswordAttemptWindowStart", SqlDbType.DateTime, 0, ParameterDirection.Input, (byte)0, (byte)0, "FailedPasswordAttemptWindowStart", DataRowVersion.Current, false, (object)null, "", "", ""));
		_adapter.InsertCommand.Parameters.Add(new SqlParameter("@FailedPasswordAnswerAttemptCount", SqlDbType.Int, 0, ParameterDirection.Input, (byte)0, (byte)0, "FailedPasswordAnswerAttemptCount", DataRowVersion.Current, false, (object)null, "", "", ""));
		_adapter.InsertCommand.Parameters.Add(new SqlParameter("@FailedPasswordAnswerAttemptWindowStart", SqlDbType.DateTime, 0, ParameterDirection.Input, (byte)0, (byte)0, "FailedPasswordAnswerAttemptWindowStart", DataRowVersion.Current, false, (object)null, "", "", ""));
		_adapter.InsertCommand.Parameters.Add(new SqlParameter("@Comment", SqlDbType.NText, 0, ParameterDirection.Input, (byte)0, (byte)0, "Comment", DataRowVersion.Current, false, (object)null, "", "", ""));
		_adapter.UpdateCommand = new SqlCommand();
		_adapter.UpdateCommand.Connection = Connection;
		_adapter.UpdateCommand.CommandText = "UPDATE [dbo].[aspnet_Membership] SET [ApplicationId] = @ApplicationId, [UserId] = @UserId, [Password] = @Password, [PasswordFormat] = @PasswordFormat, [PasswordSalt] = @PasswordSalt, [MobilePIN] = @MobilePIN, [Email] = @Email, [LoweredEmail] = @LoweredEmail, [PasswordQuestion] = @PasswordQuestion, [PasswordAnswer] = @PasswordAnswer, [IsApproved] = @IsApproved, [IsLockedOut] = @IsLockedOut, [CreateDate] = @CreateDate, [LastLoginDate] = @LastLoginDate, [LastPasswordChangedDate] = @LastPasswordChangedDate, [LastLockoutDate] = @LastLockoutDate, [FailedPasswordAttemptCount] = @FailedPasswordAttemptCount, [FailedPasswordAttemptWindowStart] = @FailedPasswordAttemptWindowStart, [FailedPasswordAnswerAttemptCount] = @FailedPasswordAnswerAttemptCount, [FailedPasswordAnswerAttemptWindowStart] = @FailedPasswordAnswerAttemptWindowStart, [Comment] = @Comment WHERE (([UserId] = @Original_UserId))";
		_adapter.UpdateCommand.CommandType = CommandType.Text;
		_adapter.UpdateCommand.Parameters.Add(new SqlParameter("@ApplicationId", SqlDbType.UniqueIdentifier, 0, ParameterDirection.Input, (byte)0, (byte)0, "ApplicationId", DataRowVersion.Current, false, (object)null, "", "", ""));
		_adapter.UpdateCommand.Parameters.Add(new SqlParameter("@UserId", SqlDbType.UniqueIdentifier, 0, ParameterDirection.Input, (byte)0, (byte)0, "UserId", DataRowVersion.Current, false, (object)null, "", "", ""));
		_adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Password", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte)0, (byte)0, "Password", DataRowVersion.Current, false, (object)null, "", "", ""));
		_adapter.UpdateCommand.Parameters.Add(new SqlParameter("@PasswordFormat", SqlDbType.Int, 0, ParameterDirection.Input, (byte)0, (byte)0, "PasswordFormat", DataRowVersion.Current, false, (object)null, "", "", ""));
		_adapter.UpdateCommand.Parameters.Add(new SqlParameter("@PasswordSalt", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte)0, (byte)0, "PasswordSalt", DataRowVersion.Current, false, (object)null, "", "", ""));
		_adapter.UpdateCommand.Parameters.Add(new SqlParameter("@MobilePIN", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte)0, (byte)0, "MobilePIN", DataRowVersion.Current, false, (object)null, "", "", ""));
		_adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Email", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte)0, (byte)0, "Email", DataRowVersion.Current, false, (object)null, "", "", ""));
		_adapter.UpdateCommand.Parameters.Add(new SqlParameter("@LoweredEmail", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte)0, (byte)0, "LoweredEmail", DataRowVersion.Current, false, (object)null, "", "", ""));
		_adapter.UpdateCommand.Parameters.Add(new SqlParameter("@PasswordQuestion", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte)0, (byte)0, "PasswordQuestion", DataRowVersion.Current, false, (object)null, "", "", ""));
		_adapter.UpdateCommand.Parameters.Add(new SqlParameter("@PasswordAnswer", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte)0, (byte)0, "PasswordAnswer", DataRowVersion.Current, false, (object)null, "", "", ""));
		_adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsApproved", SqlDbType.Bit, 0, ParameterDirection.Input, (byte)0, (byte)0, "IsApproved", DataRowVersion.Current, false, (object)null, "", "", ""));
		_adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsLockedOut", SqlDbType.Bit, 0, ParameterDirection.Input, (byte)0, (byte)0, "IsLockedOut", DataRowVersion.Current, false, (object)null, "", "", ""));
		_adapter.UpdateCommand.Parameters.Add(new SqlParameter("@CreateDate", SqlDbType.DateTime, 0, ParameterDirection.Input, (byte)0, (byte)0, "CreateDate", DataRowVersion.Current, false, (object)null, "", "", ""));
		_adapter.UpdateCommand.Parameters.Add(new SqlParameter("@LastLoginDate", SqlDbType.DateTime, 0, ParameterDirection.Input, (byte)0, (byte)0, "LastLoginDate", DataRowVersion.Current, false, (object)null, "", "", ""));
		_adapter.UpdateCommand.Parameters.Add(new SqlParameter("@LastPasswordChangedDate", SqlDbType.DateTime, 0, ParameterDirection.Input, (byte)0, (byte)0, "LastPasswordChangedDate", DataRowVersion.Current, false, (object)null, "", "", ""));
		_adapter.UpdateCommand.Parameters.Add(new SqlParameter("@LastLockoutDate", SqlDbType.DateTime, 0, ParameterDirection.Input, (byte)0, (byte)0, "LastLockoutDate", DataRowVersion.Current, false, (object)null, "", "", ""));
		_adapter.UpdateCommand.Parameters.Add(new SqlParameter("@FailedPasswordAttemptCount", SqlDbType.Int, 0, ParameterDirection.Input, (byte)0, (byte)0, "FailedPasswordAttemptCount", DataRowVersion.Current, false, (object)null, "", "", ""));
		_adapter.UpdateCommand.Parameters.Add(new SqlParameter("@FailedPasswordAttemptWindowStart", SqlDbType.DateTime, 0, ParameterDirection.Input, (byte)0, (byte)0, "FailedPasswordAttemptWindowStart", DataRowVersion.Current, false, (object)null, "", "", ""));
		_adapter.UpdateCommand.Parameters.Add(new SqlParameter("@FailedPasswordAnswerAttemptCount", SqlDbType.Int, 0, ParameterDirection.Input, (byte)0, (byte)0, "FailedPasswordAnswerAttemptCount", DataRowVersion.Current, false, (object)null, "", "", ""));
		_adapter.UpdateCommand.Parameters.Add(new SqlParameter("@FailedPasswordAnswerAttemptWindowStart", SqlDbType.DateTime, 0, ParameterDirection.Input, (byte)0, (byte)0, "FailedPasswordAnswerAttemptWindowStart", DataRowVersion.Current, false, (object)null, "", "", ""));
		_adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Comment", SqlDbType.NText, 0, ParameterDirection.Input, (byte)0, (byte)0, "Comment", DataRowVersion.Current, false, (object)null, "", "", ""));
		_adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_UserId", SqlDbType.UniqueIdentifier, 0, ParameterDirection.Input, (byte)0, (byte)0, "UserId", DataRowVersion.Original, false, (object)null, "", "", ""));
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
		//IL_00be: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c8: Expected Obj, but got Unknown
		//IL_00fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0107: Expected Obj, but got Unknown
		_commandCollection = new SqlCommand[2];
		_commandCollection[0] = new SqlCommand();
		_commandCollection[0].Connection = Connection;
		_commandCollection[0].CommandText = "SELECT     dbo.aspnet_Membership.*\r\nFROM         dbo.aspnet_Membership";
		_commandCollection[0].CommandType = CommandType.Text;
		_commandCollection[1] = new SqlCommand();
		_commandCollection[1].Connection = Connection;
		_commandCollection[1].CommandText = "UPDATE    dbo.aspnet_Membership\r\nSET              IsApproved = @IsApproved\r\nWHERE     (UserId = @Original_UserId)";
		_commandCollection[1].CommandType = CommandType.Text;
		_commandCollection[1].Parameters.Add(new SqlParameter("@IsApproved", SqlDbType.Bit, 1, ParameterDirection.Input, (byte)0, (byte)0, "IsApproved", DataRowVersion.Current, false, (object)null, "", "", ""));
		_commandCollection[1].Parameters.Add(new SqlParameter("@Original_UserId", SqlDbType.UniqueIdentifier, 16, ParameterDirection.Input, (byte)0, (byte)0, "UserId", DataRowVersion.Original, false, (object)null, "", "", ""));
	}

	[DataObjectMethod(DataObjectMethodType.Fill, true)]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	[DebuggerNonUserCode]
	[HelpKeyword("vs.data.TableAdapter")]
	public virtual int Fill(userinfo.aspnet_MembershipDataTable dataTable)
	{
		Adapter.SelectCommand = CommandCollection[0];
		if (ClearBeforeFill)
		{
			dataTable.Clear();
		}
		return ((DbDataAdapter)(object)Adapter).Fill((DataTable)dataTable);
	}

	[DebuggerNonUserCode]
	[DataObjectMethod(DataObjectMethodType.Select, true)]
	[HelpKeyword("vs.data.TableAdapter")]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	public virtual userinfo.aspnet_MembershipDataTable GetData()
	{
		Adapter.SelectCommand = CommandCollection[0];
		userinfo.aspnet_MembershipDataTable aspnet_MembershipDataTable = new userinfo.aspnet_MembershipDataTable();
		((DbDataAdapter)(object)Adapter).Fill((DataTable)aspnet_MembershipDataTable);
		return aspnet_MembershipDataTable;
	}

	[DebuggerNonUserCode]
	[HelpKeyword("vs.data.TableAdapter")]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	public virtual int Update(userinfo.aspnet_MembershipDataTable dataTable)
	{
		return ((DbDataAdapter)(object)Adapter).Update((DataTable)dataTable);
	}

	[DebuggerNonUserCode]
	[HelpKeyword("vs.data.TableAdapter")]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	public virtual int Update(userinfo dataSet)
	{
		return ((DbDataAdapter)(object)Adapter).Update((DataSet)dataSet, "aspnet_Membership");
	}

	[DebuggerNonUserCode]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	[HelpKeyword("vs.data.TableAdapter")]
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

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	[DataObjectMethod(DataObjectMethodType.Delete, true)]
	[DebuggerNonUserCode]
	[HelpKeyword("vs.data.TableAdapter")]
	public virtual int Delete(Guid Original_UserId)
	{
		Adapter.DeleteCommand.Parameters[0].Value = Original_UserId;
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
	[DebuggerNonUserCode]
	[DataObjectMethod(DataObjectMethodType.Insert, true)]
	public virtual int Insert(Guid ApplicationId, Guid UserId, string Password, int PasswordFormat, string PasswordSalt, string MobilePIN, string Email, string LoweredEmail, string PasswordQuestion, string PasswordAnswer, bool IsApproved, bool IsLockedOut, DateTime CreateDate, DateTime LastLoginDate, DateTime LastPasswordChangedDate, DateTime LastLockoutDate, int FailedPasswordAttemptCount, DateTime FailedPasswordAttemptWindowStart, int FailedPasswordAnswerAttemptCount, DateTime FailedPasswordAnswerAttemptWindowStart, string Comment)
	{
		Adapter.InsertCommand.Parameters[0].Value = ApplicationId;
		Adapter.InsertCommand.Parameters[1].Value = UserId;
		if (Password == null)
		{
			throw new ArgumentNullException("Password");
		}
		Adapter.InsertCommand.Parameters[2].Value = Password;
		Adapter.InsertCommand.Parameters[3].Value = PasswordFormat;
		if (PasswordSalt == null)
		{
			throw new ArgumentNullException("PasswordSalt");
		}
		Adapter.InsertCommand.Parameters[4].Value = PasswordSalt;
		if (MobilePIN == null)
		{
			Adapter.InsertCommand.Parameters[5].Value = DBNull.Value;
		}
		else
		{
			Adapter.InsertCommand.Parameters[5].Value = MobilePIN;
		}
		if (Email == null)
		{
			Adapter.InsertCommand.Parameters[6].Value = DBNull.Value;
		}
		else
		{
			Adapter.InsertCommand.Parameters[6].Value = Email;
		}
		if (LoweredEmail == null)
		{
			Adapter.InsertCommand.Parameters[7].Value = DBNull.Value;
		}
		else
		{
			Adapter.InsertCommand.Parameters[7].Value = LoweredEmail;
		}
		if (PasswordQuestion == null)
		{
			Adapter.InsertCommand.Parameters[8].Value = DBNull.Value;
		}
		else
		{
			Adapter.InsertCommand.Parameters[8].Value = PasswordQuestion;
		}
		if (PasswordAnswer == null)
		{
			Adapter.InsertCommand.Parameters[9].Value = DBNull.Value;
		}
		else
		{
			Adapter.InsertCommand.Parameters[9].Value = PasswordAnswer;
		}
		Adapter.InsertCommand.Parameters[10].Value = IsApproved;
		Adapter.InsertCommand.Parameters[11].Value = IsLockedOut;
		Adapter.InsertCommand.Parameters[12].Value = CreateDate;
		Adapter.InsertCommand.Parameters[13].Value = LastLoginDate;
		Adapter.InsertCommand.Parameters[14].Value = LastPasswordChangedDate;
		Adapter.InsertCommand.Parameters[15].Value = LastLockoutDate;
		Adapter.InsertCommand.Parameters[16].Value = FailedPasswordAttemptCount;
		Adapter.InsertCommand.Parameters[17].Value = FailedPasswordAttemptWindowStart;
		Adapter.InsertCommand.Parameters[18].Value = FailedPasswordAnswerAttemptCount;
		Adapter.InsertCommand.Parameters[19].Value = FailedPasswordAnswerAttemptWindowStart;
		if (Comment == null)
		{
			Adapter.InsertCommand.Parameters[20].Value = DBNull.Value;
		}
		else
		{
			Adapter.InsertCommand.Parameters[20].Value = Comment;
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

	[DataObjectMethod(DataObjectMethodType.Update, true)]
	[HelpKeyword("vs.data.TableAdapter")]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	[DebuggerNonUserCode]
	public virtual int Update(Guid ApplicationId, Guid UserId, string Password, int PasswordFormat, string PasswordSalt, string MobilePIN, string Email, string LoweredEmail, string PasswordQuestion, string PasswordAnswer, bool IsApproved, bool IsLockedOut, DateTime CreateDate, DateTime LastLoginDate, DateTime LastPasswordChangedDate, DateTime LastLockoutDate, int FailedPasswordAttemptCount, DateTime FailedPasswordAttemptWindowStart, int FailedPasswordAnswerAttemptCount, DateTime FailedPasswordAnswerAttemptWindowStart, string Comment, Guid Original_UserId)
	{
		Adapter.UpdateCommand.Parameters[0].Value = ApplicationId;
		Adapter.UpdateCommand.Parameters[1].Value = UserId;
		if (Password == null)
		{
			throw new ArgumentNullException("Password");
		}
		Adapter.UpdateCommand.Parameters[2].Value = Password;
		Adapter.UpdateCommand.Parameters[3].Value = PasswordFormat;
		if (PasswordSalt == null)
		{
			throw new ArgumentNullException("PasswordSalt");
		}
		Adapter.UpdateCommand.Parameters[4].Value = PasswordSalt;
		if (MobilePIN == null)
		{
			Adapter.UpdateCommand.Parameters[5].Value = DBNull.Value;
		}
		else
		{
			Adapter.UpdateCommand.Parameters[5].Value = MobilePIN;
		}
		if (Email == null)
		{
			Adapter.UpdateCommand.Parameters[6].Value = DBNull.Value;
		}
		else
		{
			Adapter.UpdateCommand.Parameters[6].Value = Email;
		}
		if (LoweredEmail == null)
		{
			Adapter.UpdateCommand.Parameters[7].Value = DBNull.Value;
		}
		else
		{
			Adapter.UpdateCommand.Parameters[7].Value = LoweredEmail;
		}
		if (PasswordQuestion == null)
		{
			Adapter.UpdateCommand.Parameters[8].Value = DBNull.Value;
		}
		else
		{
			Adapter.UpdateCommand.Parameters[8].Value = PasswordQuestion;
		}
		if (PasswordAnswer == null)
		{
			Adapter.UpdateCommand.Parameters[9].Value = DBNull.Value;
		}
		else
		{
			Adapter.UpdateCommand.Parameters[9].Value = PasswordAnswer;
		}
		Adapter.UpdateCommand.Parameters[10].Value = IsApproved;
		Adapter.UpdateCommand.Parameters[11].Value = IsLockedOut;
		Adapter.UpdateCommand.Parameters[12].Value = CreateDate;
		Adapter.UpdateCommand.Parameters[13].Value = LastLoginDate;
		Adapter.UpdateCommand.Parameters[14].Value = LastPasswordChangedDate;
		Adapter.UpdateCommand.Parameters[15].Value = LastLockoutDate;
		Adapter.UpdateCommand.Parameters[16].Value = FailedPasswordAttemptCount;
		Adapter.UpdateCommand.Parameters[17].Value = FailedPasswordAttemptWindowStart;
		Adapter.UpdateCommand.Parameters[18].Value = FailedPasswordAnswerAttemptCount;
		Adapter.UpdateCommand.Parameters[19].Value = FailedPasswordAnswerAttemptWindowStart;
		if (Comment == null)
		{
			Adapter.UpdateCommand.Parameters[20].Value = DBNull.Value;
		}
		else
		{
			Adapter.UpdateCommand.Parameters[20].Value = Comment;
		}
		Adapter.UpdateCommand.Parameters[21].Value = Original_UserId;
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
	public virtual int Update(Guid ApplicationId, string Password, int PasswordFormat, string PasswordSalt, string MobilePIN, string Email, string LoweredEmail, string PasswordQuestion, string PasswordAnswer, bool IsApproved, bool IsLockedOut, DateTime CreateDate, DateTime LastLoginDate, DateTime LastPasswordChangedDate, DateTime LastLockoutDate, int FailedPasswordAttemptCount, DateTime FailedPasswordAttemptWindowStart, int FailedPasswordAnswerAttemptCount, DateTime FailedPasswordAnswerAttemptWindowStart, string Comment, Guid Original_UserId)
	{
		return Update(ApplicationId, Original_UserId, Password, PasswordFormat, PasswordSalt, MobilePIN, Email, LoweredEmail, PasswordQuestion, PasswordAnswer, IsApproved, IsLockedOut, CreateDate, LastLoginDate, LastPasswordChangedDate, LastLockoutDate, FailedPasswordAttemptCount, FailedPasswordAttemptWindowStart, FailedPasswordAnswerAttemptCount, FailedPasswordAnswerAttemptWindowStart, Comment, Original_UserId);
	}

	[HelpKeyword("vs.data.TableAdapter")]
	[DebuggerNonUserCode]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	[DataObjectMethod(DataObjectMethodType.Update, false)]
	public virtual int changeaprove(bool IsApproved, Guid Original_UserId)
	{
		SqlCommand val = CommandCollection[1];
		val.Parameters[0].Value = IsApproved;
		val.Parameters[1].Value = Original_UserId;
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
