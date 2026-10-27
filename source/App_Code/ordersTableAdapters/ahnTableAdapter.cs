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

namespace ordersTableAdapters;

[DataObject(true)]
[ToolboxItem(true)]
[DesignerCategory("code")]
[HelpKeyword("vs.data.TableAdapter")]
[Designer("Microsoft.VSDesigner.DataSource.Design.TableAdapterDesigner, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
public class ahnTableAdapter : Component
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
	public ahnTableAdapter()
	{
		ClearBeforeFill = true;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	private void InitAdapter()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected Obj, but got Unknown
		//IL_0341: Unknown result type (might be due to invalid IL or missing references)
		//IL_034b: Expected Obj, but got Unknown
		//IL_03bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c6: Expected Obj, but got Unknown
		//IL_03cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d7: Expected Obj, but got Unknown
		//IL_0449: Unknown result type (might be due to invalid IL or missing references)
		//IL_0453: Expected Obj, but got Unknown
		//IL_048a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0494: Expected Obj, but got Unknown
		//IL_04cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_04d5: Expected Obj, but got Unknown
		//IL_050c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0516: Expected Obj, but got Unknown
		//IL_054d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0557: Expected Obj, but got Unknown
		//IL_058e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0598: Expected Obj, but got Unknown
		//IL_05cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_05d9: Expected Obj, but got Unknown
		//IL_0610: Unknown result type (might be due to invalid IL or missing references)
		//IL_061a: Expected Obj, but got Unknown
		//IL_0651: Unknown result type (might be due to invalid IL or missing references)
		//IL_065b: Expected Obj, but got Unknown
		//IL_0692: Unknown result type (might be due to invalid IL or missing references)
		//IL_069c: Expected Obj, but got Unknown
		//IL_06d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_06dd: Expected Obj, but got Unknown
		//IL_0714: Unknown result type (might be due to invalid IL or missing references)
		//IL_071e: Expected Obj, but got Unknown
		//IL_0755: Unknown result type (might be due to invalid IL or missing references)
		//IL_075f: Expected Obj, but got Unknown
		//IL_0796: Unknown result type (might be due to invalid IL or missing references)
		//IL_07a0: Expected Obj, but got Unknown
		//IL_07d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_07e1: Expected Obj, but got Unknown
		//IL_0818: Unknown result type (might be due to invalid IL or missing references)
		//IL_0822: Expected Obj, but got Unknown
		//IL_0859: Unknown result type (might be due to invalid IL or missing references)
		//IL_0863: Expected Obj, but got Unknown
		//IL_089a: Unknown result type (might be due to invalid IL or missing references)
		//IL_08a4: Expected Obj, but got Unknown
		//IL_08db: Unknown result type (might be due to invalid IL or missing references)
		//IL_08e5: Expected Obj, but got Unknown
		//IL_091c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0926: Expected Obj, but got Unknown
		//IL_095d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0967: Expected Obj, but got Unknown
		//IL_099e: Unknown result type (might be due to invalid IL or missing references)
		//IL_09a8: Expected Obj, but got Unknown
		//IL_09df: Unknown result type (might be due to invalid IL or missing references)
		//IL_09e9: Expected Obj, but got Unknown
		//IL_0a20: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a2a: Expected Obj, but got Unknown
		//IL_0a61: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a6b: Expected Obj, but got Unknown
		//IL_0aa2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0aac: Expected Obj, but got Unknown
		//IL_0ae3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0aed: Expected Obj, but got Unknown
		//IL_0b24: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b2e: Expected Obj, but got Unknown
		//IL_0b65: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b6f: Expected Obj, but got Unknown
		//IL_0ba6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bb0: Expected Obj, but got Unknown
		//IL_0be7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bf1: Expected Obj, but got Unknown
		//IL_0c28: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c32: Expected Obj, but got Unknown
		//IL_0c69: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c73: Expected Obj, but got Unknown
		//IL_0caa: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cb4: Expected Obj, but got Unknown
		//IL_0cbb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cc5: Expected Obj, but got Unknown
		//IL_0d37: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d41: Expected Obj, but got Unknown
		//IL_0d78: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d82: Expected Obj, but got Unknown
		//IL_0db9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0dc3: Expected Obj, but got Unknown
		//IL_0dfa: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e04: Expected Obj, but got Unknown
		//IL_0e3b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e45: Expected Obj, but got Unknown
		//IL_0e7c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e86: Expected Obj, but got Unknown
		//IL_0ebd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ec7: Expected Obj, but got Unknown
		//IL_0efe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f08: Expected Obj, but got Unknown
		//IL_0f3f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f49: Expected Obj, but got Unknown
		//IL_0f80: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f8a: Expected Obj, but got Unknown
		//IL_0fc1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fcb: Expected Obj, but got Unknown
		//IL_1002: Unknown result type (might be due to invalid IL or missing references)
		//IL_100c: Expected Obj, but got Unknown
		//IL_1043: Unknown result type (might be due to invalid IL or missing references)
		//IL_104d: Expected Obj, but got Unknown
		//IL_1084: Unknown result type (might be due to invalid IL or missing references)
		//IL_108e: Expected Obj, but got Unknown
		//IL_10c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_10cf: Expected Obj, but got Unknown
		//IL_1106: Unknown result type (might be due to invalid IL or missing references)
		//IL_1110: Expected Obj, but got Unknown
		//IL_1147: Unknown result type (might be due to invalid IL or missing references)
		//IL_1151: Expected Obj, but got Unknown
		//IL_1188: Unknown result type (might be due to invalid IL or missing references)
		//IL_1192: Expected Obj, but got Unknown
		//IL_11c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_11d3: Expected Obj, but got Unknown
		//IL_120a: Unknown result type (might be due to invalid IL or missing references)
		//IL_1214: Expected Obj, but got Unknown
		//IL_124b: Unknown result type (might be due to invalid IL or missing references)
		//IL_1255: Expected Obj, but got Unknown
		//IL_128c: Unknown result type (might be due to invalid IL or missing references)
		//IL_1296: Expected Obj, but got Unknown
		//IL_12cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_12d7: Expected Obj, but got Unknown
		//IL_130e: Unknown result type (might be due to invalid IL or missing references)
		//IL_1318: Expected Obj, but got Unknown
		//IL_134f: Unknown result type (might be due to invalid IL or missing references)
		//IL_1359: Expected Obj, but got Unknown
		//IL_1390: Unknown result type (might be due to invalid IL or missing references)
		//IL_139a: Expected Obj, but got Unknown
		//IL_13d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_13db: Expected Obj, but got Unknown
		//IL_1412: Unknown result type (might be due to invalid IL or missing references)
		//IL_141c: Expected Obj, but got Unknown
		//IL_1453: Unknown result type (might be due to invalid IL or missing references)
		//IL_145d: Expected Obj, but got Unknown
		//IL_1494: Unknown result type (might be due to invalid IL or missing references)
		//IL_149e: Expected Obj, but got Unknown
		//IL_14d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_14df: Expected Obj, but got Unknown
		//IL_1516: Unknown result type (might be due to invalid IL or missing references)
		//IL_1520: Expected Obj, but got Unknown
		//IL_1557: Unknown result type (might be due to invalid IL or missing references)
		//IL_1561: Expected Obj, but got Unknown
		//IL_1598: Unknown result type (might be due to invalid IL or missing references)
		//IL_15a2: Expected Obj, but got Unknown
		//IL_15d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_15e2: Expected Obj, but got Unknown
		_adapter = new SqlDataAdapter();
		DataTableMapping dataTableMapping = new DataTableMapping();
		dataTableMapping.SourceTable = "Table";
		dataTableMapping.DataSetTable = "ahn";
		dataTableMapping.ColumnMappings.Add("mc_gross", "mc_gross");
		dataTableMapping.ColumnMappings.Add("item_number1", "item_number1");
		dataTableMapping.ColumnMappings.Add("payer_id", "payer_id");
		dataTableMapping.ColumnMappings.Add("tax", "tax");
		dataTableMapping.ColumnMappings.Add("payment_date", "payment_date");
		dataTableMapping.ColumnMappings.Add("payment_status", "payment_status");
		dataTableMapping.ColumnMappings.Add("charset", "charset");
		dataTableMapping.ColumnMappings.Add("mc_tax1", "mc_tax1");
		dataTableMapping.ColumnMappings.Add("mc_shipping", "mc_shipping");
		dataTableMapping.ColumnMappings.Add("mc_handling", "mc_handling");
		dataTableMapping.ColumnMappings.Add("first_name", "first_name");
		dataTableMapping.ColumnMappings.Add("notify_version", "notify_version");
		dataTableMapping.ColumnMappings.Add("custom", "custom");
		dataTableMapping.ColumnMappings.Add("payer_status", "payer_status");
		dataTableMapping.ColumnMappings.Add("num_cart_items", "num_cart_items");
		dataTableMapping.ColumnMappings.Add("mc_handling1", "mc_handling1");
		dataTableMapping.ColumnMappings.Add("verify_sign", "verify_sign");
		dataTableMapping.ColumnMappings.Add("payer_email", "payer_email");
		dataTableMapping.ColumnMappings.Add("mc_shipping1", "mc_shipping1");
		dataTableMapping.ColumnMappings.Add("tax1", "tax1");
		dataTableMapping.ColumnMappings.Add("txn_id", "txn_id");
		dataTableMapping.ColumnMappings.Add("payment_type", "payment_type");
		dataTableMapping.ColumnMappings.Add("last_name", "last_name");
		dataTableMapping.ColumnMappings.Add("item_name1", "item_name1");
		dataTableMapping.ColumnMappings.Add("quantity1", "quantity1");
		dataTableMapping.ColumnMappings.Add("pending_reason", "pending_reason");
		dataTableMapping.ColumnMappings.Add("txn_type", "txn_type");
		dataTableMapping.ColumnMappings.Add("mc_gross_1", "mc_gross_1");
		dataTableMapping.ColumnMappings.Add("mc_currency", "mc_currency");
		dataTableMapping.ColumnMappings.Add("residence_country", "residence_country");
		dataTableMapping.ColumnMappings.Add("test_ipn", "test_ipn");
		dataTableMapping.ColumnMappings.Add("payment_gross", "payment_gross");
		dataTableMapping.ColumnMappings.Add("username", "username");
		dataTableMapping.ColumnMappings.Add("id", "id");
		dataTableMapping.ColumnMappings.Add("25receiver_email", "25receiver_email");
		((DataAdapter)(object)_adapter).TableMappings.Add(dataTableMapping);
		_adapter.DeleteCommand = new SqlCommand();
		_adapter.DeleteCommand.Connection = Connection;
		_adapter.DeleteCommand.CommandText = "DELETE FROM [ahn] WHERE (([id] = @Original_id))";
		_adapter.DeleteCommand.CommandType = CommandType.Text;
		_adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_id", SqlDbType.Int, 0, ParameterDirection.Input, (byte)0, (byte)0, "id", DataRowVersion.Original, false, (object)null, "", "", ""));
		_adapter.InsertCommand = new SqlCommand();
		_adapter.InsertCommand.Connection = Connection;
		_adapter.InsertCommand.CommandText = "INSERT INTO [ahn] ([mc_gross], [item_number1], [payer_id], [tax], [payment_date], [payment_status], [charset], [mc_tax1], [mc_shipping], [mc_handling], [first_name], [notify_version], [custom], [payer_status], [num_cart_items], [mc_handling1], [verify_sign], [payer_email], [mc_shipping1], [tax1], [txn_id], [payment_type], [last_name], [item_name1], [quantity1], [pending_reason], [txn_type], [mc_gross_1], [mc_currency], [residence_country], [test_ipn], [payment_gross], [username], [25receiver_email]) VALUES (@mc_gross, @item_number1, @payer_id, @tax, @payment_date, @payment_status, @charset, @mc_tax1, @mc_shipping, @mc_handling, @first_name, @notify_version, @custom, @payer_status, @num_cart_items, @mc_handling1, @verify_sign, @payer_email, @mc_shipping1, @tax1, @txn_id, @payment_type, @last_name, @item_name1, @quantity1, @pending_reason, @txn_type, @mc_gross_1, @mc_currency, @residence_country, @test_ipn, @payment_gross, @username, @p1)";
		_adapter.InsertCommand.CommandType = CommandType.Text;
		_adapter.InsertCommand.Parameters.Add(new SqlParameter("@mc_gross", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte)0, (byte)0, "mc_gross", DataRowVersion.Current, false, (object)null, "", "", ""));
		_adapter.InsertCommand.Parameters.Add(new SqlParameter("@item_number1", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte)0, (byte)0, "item_number1", DataRowVersion.Current, false, (object)null, "", "", ""));
		_adapter.InsertCommand.Parameters.Add(new SqlParameter("@payer_id", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte)0, (byte)0, "payer_id", DataRowVersion.Current, false, (object)null, "", "", ""));
		_adapter.InsertCommand.Parameters.Add(new SqlParameter("@tax", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte)0, (byte)0, "tax", DataRowVersion.Current, false, (object)null, "", "", ""));
		_adapter.InsertCommand.Parameters.Add(new SqlParameter("@payment_date", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte)0, (byte)0, "payment_date", DataRowVersion.Current, false, (object)null, "", "", ""));
		_adapter.InsertCommand.Parameters.Add(new SqlParameter("@payment_status", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte)0, (byte)0, "payment_status", DataRowVersion.Current, false, (object)null, "", "", ""));
		_adapter.InsertCommand.Parameters.Add(new SqlParameter("@charset", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte)0, (byte)0, "charset", DataRowVersion.Current, false, (object)null, "", "", ""));
		_adapter.InsertCommand.Parameters.Add(new SqlParameter("@mc_tax1", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte)0, (byte)0, "mc_tax1", DataRowVersion.Current, false, (object)null, "", "", ""));
		_adapter.InsertCommand.Parameters.Add(new SqlParameter("@mc_shipping", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte)0, (byte)0, "mc_shipping", DataRowVersion.Current, false, (object)null, "", "", ""));
		_adapter.InsertCommand.Parameters.Add(new SqlParameter("@mc_handling", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte)0, (byte)0, "mc_handling", DataRowVersion.Current, false, (object)null, "", "", ""));
		_adapter.InsertCommand.Parameters.Add(new SqlParameter("@first_name", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte)0, (byte)0, "first_name", DataRowVersion.Current, false, (object)null, "", "", ""));
		_adapter.InsertCommand.Parameters.Add(new SqlParameter("@notify_version", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte)0, (byte)0, "notify_version", DataRowVersion.Current, false, (object)null, "", "", ""));
		_adapter.InsertCommand.Parameters.Add(new SqlParameter("@custom", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte)0, (byte)0, "custom", DataRowVersion.Current, false, (object)null, "", "", ""));
		_adapter.InsertCommand.Parameters.Add(new SqlParameter("@payer_status", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte)0, (byte)0, "payer_status", DataRowVersion.Current, false, (object)null, "", "", ""));
		_adapter.InsertCommand.Parameters.Add(new SqlParameter("@num_cart_items", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte)0, (byte)0, "num_cart_items", DataRowVersion.Current, false, (object)null, "", "", ""));
		_adapter.InsertCommand.Parameters.Add(new SqlParameter("@mc_handling1", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte)0, (byte)0, "mc_handling1", DataRowVersion.Current, false, (object)null, "", "", ""));
		_adapter.InsertCommand.Parameters.Add(new SqlParameter("@verify_sign", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte)0, (byte)0, "verify_sign", DataRowVersion.Current, false, (object)null, "", "", ""));
		_adapter.InsertCommand.Parameters.Add(new SqlParameter("@payer_email", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte)0, (byte)0, "payer_email", DataRowVersion.Current, false, (object)null, "", "", ""));
		_adapter.InsertCommand.Parameters.Add(new SqlParameter("@mc_shipping1", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte)0, (byte)0, "mc_shipping1", DataRowVersion.Current, false, (object)null, "", "", ""));
		_adapter.InsertCommand.Parameters.Add(new SqlParameter("@tax1", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte)0, (byte)0, "tax1", DataRowVersion.Current, false, (object)null, "", "", ""));
		_adapter.InsertCommand.Parameters.Add(new SqlParameter("@txn_id", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte)0, (byte)0, "txn_id", DataRowVersion.Current, false, (object)null, "", "", ""));
		_adapter.InsertCommand.Parameters.Add(new SqlParameter("@payment_type", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte)0, (byte)0, "payment_type", DataRowVersion.Current, false, (object)null, "", "", ""));
		_adapter.InsertCommand.Parameters.Add(new SqlParameter("@last_name", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte)0, (byte)0, "last_name", DataRowVersion.Current, false, (object)null, "", "", ""));
		_adapter.InsertCommand.Parameters.Add(new SqlParameter("@item_name1", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte)0, (byte)0, "item_name1", DataRowVersion.Current, false, (object)null, "", "", ""));
		_adapter.InsertCommand.Parameters.Add(new SqlParameter("@quantity1", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte)0, (byte)0, "quantity1", DataRowVersion.Current, false, (object)null, "", "", ""));
		_adapter.InsertCommand.Parameters.Add(new SqlParameter("@pending_reason", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte)0, (byte)0, "pending_reason", DataRowVersion.Current, false, (object)null, "", "", ""));
		_adapter.InsertCommand.Parameters.Add(new SqlParameter("@txn_type", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte)0, (byte)0, "txn_type", DataRowVersion.Current, false, (object)null, "", "", ""));
		_adapter.InsertCommand.Parameters.Add(new SqlParameter("@mc_gross_1", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte)0, (byte)0, "mc_gross_1", DataRowVersion.Current, false, (object)null, "", "", ""));
		_adapter.InsertCommand.Parameters.Add(new SqlParameter("@mc_currency", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte)0, (byte)0, "mc_currency", DataRowVersion.Current, false, (object)null, "", "", ""));
		_adapter.InsertCommand.Parameters.Add(new SqlParameter("@residence_country", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte)0, (byte)0, "residence_country", DataRowVersion.Current, false, (object)null, "", "", ""));
		_adapter.InsertCommand.Parameters.Add(new SqlParameter("@test_ipn", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte)0, (byte)0, "test_ipn", DataRowVersion.Current, false, (object)null, "", "", ""));
		_adapter.InsertCommand.Parameters.Add(new SqlParameter("@payment_gross", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte)0, (byte)0, "payment_gross", DataRowVersion.Current, false, (object)null, "", "", ""));
		_adapter.InsertCommand.Parameters.Add(new SqlParameter("@username", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte)0, (byte)0, "username", DataRowVersion.Current, false, (object)null, "", "", ""));
		_adapter.InsertCommand.Parameters.Add(new SqlParameter("@p1", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte)0, (byte)0, "25receiver_email", DataRowVersion.Current, false, (object)null, "", "", ""));
		_adapter.UpdateCommand = new SqlCommand();
		_adapter.UpdateCommand.Connection = Connection;
		_adapter.UpdateCommand.CommandText = "UPDATE [ahn] SET [mc_gross] = @mc_gross, [item_number1] = @item_number1, [payer_id] = @payer_id, [tax] = @tax, [payment_date] = @payment_date, [payment_status] = @payment_status, [charset] = @charset, [mc_tax1] = @mc_tax1, [mc_shipping] = @mc_shipping, [mc_handling] = @mc_handling, [first_name] = @first_name, [notify_version] = @notify_version, [custom] = @custom, [payer_status] = @payer_status, [num_cart_items] = @num_cart_items, [mc_handling1] = @mc_handling1, [verify_sign] = @verify_sign, [payer_email] = @payer_email, [mc_shipping1] = @mc_shipping1, [tax1] = @tax1, [txn_id] = @txn_id, [payment_type] = @payment_type, [last_name] = @last_name, [item_name1] = @item_name1, [quantity1] = @quantity1, [pending_reason] = @pending_reason, [txn_type] = @txn_type, [mc_gross_1] = @mc_gross_1, [mc_currency] = @mc_currency, [residence_country] = @residence_country, [test_ipn] = @test_ipn, [payment_gross] = @payment_gross, [username] = @username, [25receiver_email] = @p1 WHERE (([id] = @Original_id))";
		_adapter.UpdateCommand.CommandType = CommandType.Text;
		_adapter.UpdateCommand.Parameters.Add(new SqlParameter("@mc_gross", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte)0, (byte)0, "mc_gross", DataRowVersion.Current, false, (object)null, "", "", ""));
		_adapter.UpdateCommand.Parameters.Add(new SqlParameter("@item_number1", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte)0, (byte)0, "item_number1", DataRowVersion.Current, false, (object)null, "", "", ""));
		_adapter.UpdateCommand.Parameters.Add(new SqlParameter("@payer_id", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte)0, (byte)0, "payer_id", DataRowVersion.Current, false, (object)null, "", "", ""));
		_adapter.UpdateCommand.Parameters.Add(new SqlParameter("@tax", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte)0, (byte)0, "tax", DataRowVersion.Current, false, (object)null, "", "", ""));
		_adapter.UpdateCommand.Parameters.Add(new SqlParameter("@payment_date", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte)0, (byte)0, "payment_date", DataRowVersion.Current, false, (object)null, "", "", ""));
		_adapter.UpdateCommand.Parameters.Add(new SqlParameter("@payment_status", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte)0, (byte)0, "payment_status", DataRowVersion.Current, false, (object)null, "", "", ""));
		_adapter.UpdateCommand.Parameters.Add(new SqlParameter("@charset", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte)0, (byte)0, "charset", DataRowVersion.Current, false, (object)null, "", "", ""));
		_adapter.UpdateCommand.Parameters.Add(new SqlParameter("@mc_tax1", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte)0, (byte)0, "mc_tax1", DataRowVersion.Current, false, (object)null, "", "", ""));
		_adapter.UpdateCommand.Parameters.Add(new SqlParameter("@mc_shipping", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte)0, (byte)0, "mc_shipping", DataRowVersion.Current, false, (object)null, "", "", ""));
		_adapter.UpdateCommand.Parameters.Add(new SqlParameter("@mc_handling", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte)0, (byte)0, "mc_handling", DataRowVersion.Current, false, (object)null, "", "", ""));
		_adapter.UpdateCommand.Parameters.Add(new SqlParameter("@first_name", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte)0, (byte)0, "first_name", DataRowVersion.Current, false, (object)null, "", "", ""));
		_adapter.UpdateCommand.Parameters.Add(new SqlParameter("@notify_version", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte)0, (byte)0, "notify_version", DataRowVersion.Current, false, (object)null, "", "", ""));
		_adapter.UpdateCommand.Parameters.Add(new SqlParameter("@custom", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte)0, (byte)0, "custom", DataRowVersion.Current, false, (object)null, "", "", ""));
		_adapter.UpdateCommand.Parameters.Add(new SqlParameter("@payer_status", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte)0, (byte)0, "payer_status", DataRowVersion.Current, false, (object)null, "", "", ""));
		_adapter.UpdateCommand.Parameters.Add(new SqlParameter("@num_cart_items", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte)0, (byte)0, "num_cart_items", DataRowVersion.Current, false, (object)null, "", "", ""));
		_adapter.UpdateCommand.Parameters.Add(new SqlParameter("@mc_handling1", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte)0, (byte)0, "mc_handling1", DataRowVersion.Current, false, (object)null, "", "", ""));
		_adapter.UpdateCommand.Parameters.Add(new SqlParameter("@verify_sign", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte)0, (byte)0, "verify_sign", DataRowVersion.Current, false, (object)null, "", "", ""));
		_adapter.UpdateCommand.Parameters.Add(new SqlParameter("@payer_email", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte)0, (byte)0, "payer_email", DataRowVersion.Current, false, (object)null, "", "", ""));
		_adapter.UpdateCommand.Parameters.Add(new SqlParameter("@mc_shipping1", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte)0, (byte)0, "mc_shipping1", DataRowVersion.Current, false, (object)null, "", "", ""));
		_adapter.UpdateCommand.Parameters.Add(new SqlParameter("@tax1", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte)0, (byte)0, "tax1", DataRowVersion.Current, false, (object)null, "", "", ""));
		_adapter.UpdateCommand.Parameters.Add(new SqlParameter("@txn_id", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte)0, (byte)0, "txn_id", DataRowVersion.Current, false, (object)null, "", "", ""));
		_adapter.UpdateCommand.Parameters.Add(new SqlParameter("@payment_type", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte)0, (byte)0, "payment_type", DataRowVersion.Current, false, (object)null, "", "", ""));
		_adapter.UpdateCommand.Parameters.Add(new SqlParameter("@last_name", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte)0, (byte)0, "last_name", DataRowVersion.Current, false, (object)null, "", "", ""));
		_adapter.UpdateCommand.Parameters.Add(new SqlParameter("@item_name1", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte)0, (byte)0, "item_name1", DataRowVersion.Current, false, (object)null, "", "", ""));
		_adapter.UpdateCommand.Parameters.Add(new SqlParameter("@quantity1", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte)0, (byte)0, "quantity1", DataRowVersion.Current, false, (object)null, "", "", ""));
		_adapter.UpdateCommand.Parameters.Add(new SqlParameter("@pending_reason", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte)0, (byte)0, "pending_reason", DataRowVersion.Current, false, (object)null, "", "", ""));
		_adapter.UpdateCommand.Parameters.Add(new SqlParameter("@txn_type", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte)0, (byte)0, "txn_type", DataRowVersion.Current, false, (object)null, "", "", ""));
		_adapter.UpdateCommand.Parameters.Add(new SqlParameter("@mc_gross_1", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte)0, (byte)0, "mc_gross_1", DataRowVersion.Current, false, (object)null, "", "", ""));
		_adapter.UpdateCommand.Parameters.Add(new SqlParameter("@mc_currency", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte)0, (byte)0, "mc_currency", DataRowVersion.Current, false, (object)null, "", "", ""));
		_adapter.UpdateCommand.Parameters.Add(new SqlParameter("@residence_country", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte)0, (byte)0, "residence_country", DataRowVersion.Current, false, (object)null, "", "", ""));
		_adapter.UpdateCommand.Parameters.Add(new SqlParameter("@test_ipn", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte)0, (byte)0, "test_ipn", DataRowVersion.Current, false, (object)null, "", "", ""));
		_adapter.UpdateCommand.Parameters.Add(new SqlParameter("@payment_gross", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte)0, (byte)0, "payment_gross", DataRowVersion.Current, false, (object)null, "", "", ""));
		_adapter.UpdateCommand.Parameters.Add(new SqlParameter("@username", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte)0, (byte)0, "username", DataRowVersion.Current, false, (object)null, "", "", ""));
		_adapter.UpdateCommand.Parameters.Add(new SqlParameter("@p1", SqlDbType.NVarChar, 0, ParameterDirection.Input, (byte)0, (byte)0, "25receiver_email", DataRowVersion.Current, false, (object)null, "", "", ""));
		_adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_id", SqlDbType.Int, 0, ParameterDirection.Input, (byte)0, (byte)0, "id", DataRowVersion.Original, false, (object)null, "", "", ""));
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
		//IL_024f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0259: Expected Obj, but got Unknown
		//IL_0291: Unknown result type (might be due to invalid IL or missing references)
		//IL_029b: Expected Obj, but got Unknown
		//IL_02d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_02dd: Expected Obj, but got Unknown
		//IL_0315: Unknown result type (might be due to invalid IL or missing references)
		//IL_031f: Expected Obj, but got Unknown
		//IL_0357: Unknown result type (might be due to invalid IL or missing references)
		//IL_0361: Expected Obj, but got Unknown
		//IL_0399: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a3: Expected Obj, but got Unknown
		//IL_03db: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e5: Expected Obj, but got Unknown
		//IL_041d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0427: Expected Obj, but got Unknown
		//IL_045f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0469: Expected Obj, but got Unknown
		//IL_04a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ab: Expected Obj, but got Unknown
		//IL_04e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ed: Expected Obj, but got Unknown
		//IL_0525: Unknown result type (might be due to invalid IL or missing references)
		//IL_052f: Expected Obj, but got Unknown
		//IL_0567: Unknown result type (might be due to invalid IL or missing references)
		//IL_0571: Expected Obj, but got Unknown
		//IL_05a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_05b3: Expected Obj, but got Unknown
		//IL_05eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_05f5: Expected Obj, but got Unknown
		//IL_062d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0637: Expected Obj, but got Unknown
		//IL_066f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0679: Expected Obj, but got Unknown
		//IL_06b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_06bb: Expected Obj, but got Unknown
		//IL_06f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_06fd: Expected Obj, but got Unknown
		//IL_0735: Unknown result type (might be due to invalid IL or missing references)
		//IL_073f: Expected Obj, but got Unknown
		//IL_0777: Unknown result type (might be due to invalid IL or missing references)
		//IL_0781: Expected Obj, but got Unknown
		//IL_07b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_07c3: Expected Obj, but got Unknown
		//IL_07fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0805: Expected Obj, but got Unknown
		//IL_083d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0847: Expected Obj, but got Unknown
		//IL_087f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0889: Expected Obj, but got Unknown
		//IL_08c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_08cb: Expected Obj, but got Unknown
		//IL_0903: Unknown result type (might be due to invalid IL or missing references)
		//IL_090d: Expected Obj, but got Unknown
		//IL_0945: Unknown result type (might be due to invalid IL or missing references)
		//IL_094f: Expected Obj, but got Unknown
		_commandCollection = new SqlCommand[2];
		_commandCollection[0] = new SqlCommand();
		_commandCollection[0].Connection = Connection;
		_commandCollection[0].CommandText = "SELECT     mc_gross, item_number1, payer_id, tax, payment_date, payment_status, charset, mc_tax1, mc_shipping, mc_handling, first_name, notify_version, \r\n                      custom, payer_status, num_cart_items, mc_handling1, verify_sign, payer_email, mc_shipping1, tax1, txn_id, payment_type, last_name, item_name1, \r\n                     quantity1, pending_reason, txn_type, mc_gross_1, mc_currency, residence_country, test_ipn, payment_gross, username, id, \r\n                      [25receiver_email]\r\nFROM         ahn";
		_commandCollection[0].CommandType = CommandType.Text;
		_commandCollection[1] = new SqlCommand();
		_commandCollection[1].Connection = Connection;
		_commandCollection[1].CommandText = "INSERT INTO ahn\r\n                      (mc_gross, item_number1, payer_id, tax, payment_date, payment_status, charset, mc_tax1, mc_shipping, mc_handling, first_name, notify_version, \r\n                      custom, payer_status, num_cart_items, mc_handling1, verify_sign, payer_email, mc_shipping1, tax1, txn_id, payment_type, last_name, item_name1, \r\n                      quantity1, pending_reason, txn_type, mc_gross_1, mc_currency, residence_country, test_ipn, payment_gross, username, [25receiver_email])\r\nVALUES     (@mc_gross,@item_number1,@payer_id,@tax,@payment_date,@payment_status,@charset,@mc_tax1,@mc_shipping,@mc_handling,@first_name,@notify_version,@custom,@payer_status,@num_cart_items,@mc_handling1,@verify_sign,@payer_email,@mc_shipping1,@tax1,@txn_id,@payment_type,@last_name,@item_name1,@quantity1,@pending_reason,@txn_type,@mc_gross_1,@mc_currency,@residence_country,@test_ipn,@payment_gross,@username,@emailr)";
		_commandCollection[1].CommandType = CommandType.Text;
		_commandCollection[1].Parameters.Add(new SqlParameter("@mc_gross", SqlDbType.NVarChar, 255, ParameterDirection.Input, (byte)0, (byte)0, "mc_gross", DataRowVersion.Current, false, (object)null, "", "", ""));
		_commandCollection[1].Parameters.Add(new SqlParameter("@item_number1", SqlDbType.NVarChar, 255, ParameterDirection.Input, (byte)0, (byte)0, "item_number1", DataRowVersion.Current, false, (object)null, "", "", ""));
		_commandCollection[1].Parameters.Add(new SqlParameter("@payer_id", SqlDbType.NVarChar, 255, ParameterDirection.Input, (byte)0, (byte)0, "payer_id", DataRowVersion.Current, false, (object)null, "", "", ""));
		_commandCollection[1].Parameters.Add(new SqlParameter("@tax", SqlDbType.NVarChar, 255, ParameterDirection.Input, (byte)0, (byte)0, "tax", DataRowVersion.Current, false, (object)null, "", "", ""));
		_commandCollection[1].Parameters.Add(new SqlParameter("@payment_date", SqlDbType.NVarChar, 255, ParameterDirection.Input, (byte)0, (byte)0, "payment_date", DataRowVersion.Current, false, (object)null, "", "", ""));
		_commandCollection[1].Parameters.Add(new SqlParameter("@payment_status", SqlDbType.NVarChar, 255, ParameterDirection.Input, (byte)0, (byte)0, "payment_status", DataRowVersion.Current, false, (object)null, "", "", ""));
		_commandCollection[1].Parameters.Add(new SqlParameter("@charset", SqlDbType.NVarChar, 255, ParameterDirection.Input, (byte)0, (byte)0, "charset", DataRowVersion.Current, false, (object)null, "", "", ""));
		_commandCollection[1].Parameters.Add(new SqlParameter("@mc_tax1", SqlDbType.NVarChar, 255, ParameterDirection.Input, (byte)0, (byte)0, "mc_tax1", DataRowVersion.Current, false, (object)null, "", "", ""));
		_commandCollection[1].Parameters.Add(new SqlParameter("@mc_shipping", SqlDbType.NVarChar, 255, ParameterDirection.Input, (byte)0, (byte)0, "mc_shipping", DataRowVersion.Current, false, (object)null, "", "", ""));
		_commandCollection[1].Parameters.Add(new SqlParameter("@mc_handling", SqlDbType.NVarChar, 255, ParameterDirection.Input, (byte)0, (byte)0, "mc_handling", DataRowVersion.Current, false, (object)null, "", "", ""));
		_commandCollection[1].Parameters.Add(new SqlParameter("@first_name", SqlDbType.NVarChar, 255, ParameterDirection.Input, (byte)0, (byte)0, "first_name", DataRowVersion.Current, false, (object)null, "", "", ""));
		_commandCollection[1].Parameters.Add(new SqlParameter("@notify_version", SqlDbType.NVarChar, 255, ParameterDirection.Input, (byte)0, (byte)0, "notify_version", DataRowVersion.Current, false, (object)null, "", "", ""));
		_commandCollection[1].Parameters.Add(new SqlParameter("@custom", SqlDbType.NVarChar, 255, ParameterDirection.Input, (byte)0, (byte)0, "custom", DataRowVersion.Current, false, (object)null, "", "", ""));
		_commandCollection[1].Parameters.Add(new SqlParameter("@payer_status", SqlDbType.NVarChar, 255, ParameterDirection.Input, (byte)0, (byte)0, "payer_status", DataRowVersion.Current, false, (object)null, "", "", ""));
		_commandCollection[1].Parameters.Add(new SqlParameter("@num_cart_items", SqlDbType.NVarChar, 255, ParameterDirection.Input, (byte)0, (byte)0, "num_cart_items", DataRowVersion.Current, false, (object)null, "", "", ""));
		_commandCollection[1].Parameters.Add(new SqlParameter("@mc_handling1", SqlDbType.NVarChar, 255, ParameterDirection.Input, (byte)0, (byte)0, "mc_handling1", DataRowVersion.Current, false, (object)null, "", "", ""));
		_commandCollection[1].Parameters.Add(new SqlParameter("@verify_sign", SqlDbType.NVarChar, 255, ParameterDirection.Input, (byte)0, (byte)0, "verify_sign", DataRowVersion.Current, false, (object)null, "", "", ""));
		_commandCollection[1].Parameters.Add(new SqlParameter("@payer_email", SqlDbType.NVarChar, 255, ParameterDirection.Input, (byte)0, (byte)0, "payer_email", DataRowVersion.Current, false, (object)null, "", "", ""));
		_commandCollection[1].Parameters.Add(new SqlParameter("@mc_shipping1", SqlDbType.NVarChar, 255, ParameterDirection.Input, (byte)0, (byte)0, "mc_shipping1", DataRowVersion.Current, false, (object)null, "", "", ""));
		_commandCollection[1].Parameters.Add(new SqlParameter("@tax1", SqlDbType.NVarChar, 255, ParameterDirection.Input, (byte)0, (byte)0, "tax1", DataRowVersion.Current, false, (object)null, "", "", ""));
		_commandCollection[1].Parameters.Add(new SqlParameter("@txn_id", SqlDbType.NVarChar, 255, ParameterDirection.Input, (byte)0, (byte)0, "txn_id", DataRowVersion.Current, false, (object)null, "", "", ""));
		_commandCollection[1].Parameters.Add(new SqlParameter("@payment_type", SqlDbType.NVarChar, 255, ParameterDirection.Input, (byte)0, (byte)0, "payment_type", DataRowVersion.Current, false, (object)null, "", "", ""));
		_commandCollection[1].Parameters.Add(new SqlParameter("@last_name", SqlDbType.NVarChar, 255, ParameterDirection.Input, (byte)0, (byte)0, "last_name", DataRowVersion.Current, false, (object)null, "", "", ""));
		_commandCollection[1].Parameters.Add(new SqlParameter("@item_name1", SqlDbType.NVarChar, 255, ParameterDirection.Input, (byte)0, (byte)0, "item_name1", DataRowVersion.Current, false, (object)null, "", "", ""));
		_commandCollection[1].Parameters.Add(new SqlParameter("@quantity1", SqlDbType.NVarChar, 255, ParameterDirection.Input, (byte)0, (byte)0, "quantity1", DataRowVersion.Current, false, (object)null, "", "", ""));
		_commandCollection[1].Parameters.Add(new SqlParameter("@pending_reason", SqlDbType.NVarChar, 255, ParameterDirection.Input, (byte)0, (byte)0, "pending_reason", DataRowVersion.Current, false, (object)null, "", "", ""));
		_commandCollection[1].Parameters.Add(new SqlParameter("@txn_type", SqlDbType.NVarChar, 255, ParameterDirection.Input, (byte)0, (byte)0, "txn_type", DataRowVersion.Current, false, (object)null, "", "", ""));
		_commandCollection[1].Parameters.Add(new SqlParameter("@mc_gross_1", SqlDbType.NVarChar, 255, ParameterDirection.Input, (byte)0, (byte)0, "mc_gross_1", DataRowVersion.Current, false, (object)null, "", "", ""));
		_commandCollection[1].Parameters.Add(new SqlParameter("@mc_currency", SqlDbType.NVarChar, 255, ParameterDirection.Input, (byte)0, (byte)0, "mc_currency", DataRowVersion.Current, false, (object)null, "", "", ""));
		_commandCollection[1].Parameters.Add(new SqlParameter("@residence_country", SqlDbType.NVarChar, 255, ParameterDirection.Input, (byte)0, (byte)0, "residence_country", DataRowVersion.Current, false, (object)null, "", "", ""));
		_commandCollection[1].Parameters.Add(new SqlParameter("@test_ipn", SqlDbType.NVarChar, 255, ParameterDirection.Input, (byte)0, (byte)0, "test_ipn", DataRowVersion.Current, false, (object)null, "", "", ""));
		_commandCollection[1].Parameters.Add(new SqlParameter("@payment_gross", SqlDbType.NVarChar, 255, ParameterDirection.Input, (byte)0, (byte)0, "payment_gross", DataRowVersion.Current, false, (object)null, "", "", ""));
		_commandCollection[1].Parameters.Add(new SqlParameter("@username", SqlDbType.NVarChar, 256, ParameterDirection.Input, (byte)0, (byte)0, "username", DataRowVersion.Current, false, (object)null, "", "", ""));
		_commandCollection[1].Parameters.Add(new SqlParameter("@emailr", SqlDbType.NVarChar, 255, ParameterDirection.Input, (byte)0, (byte)0, "25receiver_email", DataRowVersion.Current, false, (object)null, "", "", ""));
	}

	[HelpKeyword("vs.data.TableAdapter")]
	[DataObjectMethod(DataObjectMethodType.Fill, true)]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	[DebuggerNonUserCode]
	public virtual int Fill(orders.ahnDataTable dataTable)
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
	public virtual orders.ahnDataTable GetData()
	{
		Adapter.SelectCommand = CommandCollection[0];
		orders.ahnDataTable ahnDataTable = new orders.ahnDataTable();
		((DbDataAdapter)(object)Adapter).Fill((DataTable)ahnDataTable);
		return ahnDataTable;
	}

	[HelpKeyword("vs.data.TableAdapter")]
	[DebuggerNonUserCode]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	public virtual int Update(orders.ahnDataTable dataTable)
	{
		return ((DbDataAdapter)(object)Adapter).Update((DataTable)dataTable);
	}

	[HelpKeyword("vs.data.TableAdapter")]
	[DebuggerNonUserCode]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	public virtual int Update(orders dataSet)
	{
		return ((DbDataAdapter)(object)Adapter).Update((DataSet)dataSet, "ahn");
	}

	[DebuggerNonUserCode]
	[HelpKeyword("vs.data.TableAdapter")]
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

	[DebuggerNonUserCode]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	[DataObjectMethod(DataObjectMethodType.Delete, true)]
	[HelpKeyword("vs.data.TableAdapter")]
	public virtual int Delete(int Original_id)
	{
		Adapter.DeleteCommand.Parameters[0].Value = Original_id;
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
	[DebuggerNonUserCode]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	[HelpKeyword("vs.data.TableAdapter")]
	public virtual int Insert(string mc_gross, string item_number1, string payer_id, string tax, string payment_date, string payment_status, string charset, string mc_tax1, string mc_shipping, string mc_handling, string first_name, string notify_version, string custom, string payer_status, string num_cart_items, string mc_handling1, string verify_sign, string payer_email, string mc_shipping1, string tax1, string txn_id, string payment_type, string last_name, string item_name1, string quantity1, string pending_reason, string txn_type, string mc_gross_1, string mc_currency, string residence_country, string test_ipn, string payment_gross, string username, string p1)
	{
		if (mc_gross == null)
		{
			Adapter.InsertCommand.Parameters[0].Value = DBNull.Value;
		}
		else
		{
			Adapter.InsertCommand.Parameters[0].Value = mc_gross;
		}
		if (item_number1 == null)
		{
			Adapter.InsertCommand.Parameters[1].Value = DBNull.Value;
		}
		else
		{
			Adapter.InsertCommand.Parameters[1].Value = item_number1;
		}
		if (payer_id == null)
		{
			Adapter.InsertCommand.Parameters[2].Value = DBNull.Value;
		}
		else
		{
			Adapter.InsertCommand.Parameters[2].Value = payer_id;
		}
		if (tax == null)
		{
			Adapter.InsertCommand.Parameters[3].Value = DBNull.Value;
		}
		else
		{
			Adapter.InsertCommand.Parameters[3].Value = tax;
		}
		if (payment_date == null)
		{
			Adapter.InsertCommand.Parameters[4].Value = DBNull.Value;
		}
		else
		{
			Adapter.InsertCommand.Parameters[4].Value = payment_date;
		}
		if (payment_status == null)
		{
			Adapter.InsertCommand.Parameters[5].Value = DBNull.Value;
		}
		else
		{
			Adapter.InsertCommand.Parameters[5].Value = payment_status;
		}
		if (charset == null)
		{
			Adapter.InsertCommand.Parameters[6].Value = DBNull.Value;
		}
		else
		{
			Adapter.InsertCommand.Parameters[6].Value = charset;
		}
		if (mc_tax1 == null)
		{
			Adapter.InsertCommand.Parameters[7].Value = DBNull.Value;
		}
		else
		{
			Adapter.InsertCommand.Parameters[7].Value = mc_tax1;
		}
		if (mc_shipping == null)
		{
			Adapter.InsertCommand.Parameters[8].Value = DBNull.Value;
		}
		else
		{
			Adapter.InsertCommand.Parameters[8].Value = mc_shipping;
		}
		if (mc_handling == null)
		{
			Adapter.InsertCommand.Parameters[9].Value = DBNull.Value;
		}
		else
		{
			Adapter.InsertCommand.Parameters[9].Value = mc_handling;
		}
		if (first_name == null)
		{
			Adapter.InsertCommand.Parameters[10].Value = DBNull.Value;
		}
		else
		{
			Adapter.InsertCommand.Parameters[10].Value = first_name;
		}
		if (notify_version == null)
		{
			Adapter.InsertCommand.Parameters[11].Value = DBNull.Value;
		}
		else
		{
			Adapter.InsertCommand.Parameters[11].Value = notify_version;
		}
		if (custom == null)
		{
			Adapter.InsertCommand.Parameters[12].Value = DBNull.Value;
		}
		else
		{
			Adapter.InsertCommand.Parameters[12].Value = custom;
		}
		if (payer_status == null)
		{
			Adapter.InsertCommand.Parameters[13].Value = DBNull.Value;
		}
		else
		{
			Adapter.InsertCommand.Parameters[13].Value = payer_status;
		}
		if (num_cart_items == null)
		{
			Adapter.InsertCommand.Parameters[14].Value = DBNull.Value;
		}
		else
		{
			Adapter.InsertCommand.Parameters[14].Value = num_cart_items;
		}
		if (mc_handling1 == null)
		{
			Adapter.InsertCommand.Parameters[15].Value = DBNull.Value;
		}
		else
		{
			Adapter.InsertCommand.Parameters[15].Value = mc_handling1;
		}
		if (verify_sign == null)
		{
			Adapter.InsertCommand.Parameters[16].Value = DBNull.Value;
		}
		else
		{
			Adapter.InsertCommand.Parameters[16].Value = verify_sign;
		}
		if (payer_email == null)
		{
			Adapter.InsertCommand.Parameters[17].Value = DBNull.Value;
		}
		else
		{
			Adapter.InsertCommand.Parameters[17].Value = payer_email;
		}
		if (mc_shipping1 == null)
		{
			Adapter.InsertCommand.Parameters[18].Value = DBNull.Value;
		}
		else
		{
			Adapter.InsertCommand.Parameters[18].Value = mc_shipping1;
		}
		if (tax1 == null)
		{
			Adapter.InsertCommand.Parameters[19].Value = DBNull.Value;
		}
		else
		{
			Adapter.InsertCommand.Parameters[19].Value = tax1;
		}
		if (txn_id == null)
		{
			Adapter.InsertCommand.Parameters[20].Value = DBNull.Value;
		}
		else
		{
			Adapter.InsertCommand.Parameters[20].Value = txn_id;
		}
		if (payment_type == null)
		{
			Adapter.InsertCommand.Parameters[21].Value = DBNull.Value;
		}
		else
		{
			Adapter.InsertCommand.Parameters[21].Value = payment_type;
		}
		if (last_name == null)
		{
			Adapter.InsertCommand.Parameters[22].Value = DBNull.Value;
		}
		else
		{
			Adapter.InsertCommand.Parameters[22].Value = last_name;
		}
		if (item_name1 == null)
		{
			Adapter.InsertCommand.Parameters[23].Value = DBNull.Value;
		}
		else
		{
			Adapter.InsertCommand.Parameters[23].Value = item_name1;
		}
		if (quantity1 == null)
		{
			Adapter.InsertCommand.Parameters[24].Value = DBNull.Value;
		}
		else
		{
			Adapter.InsertCommand.Parameters[24].Value = quantity1;
		}
		if (pending_reason == null)
		{
			Adapter.InsertCommand.Parameters[25].Value = DBNull.Value;
		}
		else
		{
			Adapter.InsertCommand.Parameters[25].Value = pending_reason;
		}
		if (txn_type == null)
		{
			Adapter.InsertCommand.Parameters[26].Value = DBNull.Value;
		}
		else
		{
			Adapter.InsertCommand.Parameters[26].Value = txn_type;
		}
		if (mc_gross_1 == null)
		{
			Adapter.InsertCommand.Parameters[27].Value = DBNull.Value;
		}
		else
		{
			Adapter.InsertCommand.Parameters[27].Value = mc_gross_1;
		}
		if (mc_currency == null)
		{
			Adapter.InsertCommand.Parameters[28].Value = DBNull.Value;
		}
		else
		{
			Adapter.InsertCommand.Parameters[28].Value = mc_currency;
		}
		if (residence_country == null)
		{
			Adapter.InsertCommand.Parameters[29].Value = DBNull.Value;
		}
		else
		{
			Adapter.InsertCommand.Parameters[29].Value = residence_country;
		}
		if (test_ipn == null)
		{
			Adapter.InsertCommand.Parameters[30].Value = DBNull.Value;
		}
		else
		{
			Adapter.InsertCommand.Parameters[30].Value = test_ipn;
		}
		if (payment_gross == null)
		{
			Adapter.InsertCommand.Parameters[31].Value = DBNull.Value;
		}
		else
		{
			Adapter.InsertCommand.Parameters[31].Value = payment_gross;
		}
		if (username == null)
		{
			throw new ArgumentNullException("username");
		}
		Adapter.InsertCommand.Parameters[32].Value = username;
		if (p1 == null)
		{
			Adapter.InsertCommand.Parameters[33].Value = DBNull.Value;
		}
		else
		{
			Adapter.InsertCommand.Parameters[33].Value = p1;
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
	[HelpKeyword("vs.data.TableAdapter")]
	[DataObjectMethod(DataObjectMethodType.Update, true)]
	public virtual int Update(string mc_gross, string item_number1, string payer_id, string tax, string payment_date, string payment_status, string charset, string mc_tax1, string mc_shipping, string mc_handling, string first_name, string notify_version, string custom, string payer_status, string num_cart_items, string mc_handling1, string verify_sign, string payer_email, string mc_shipping1, string tax1, string txn_id, string payment_type, string last_name, string item_name1, string quantity1, string pending_reason, string txn_type, string mc_gross_1, string mc_currency, string residence_country, string test_ipn, string payment_gross, string username, string p1, int Original_id)
	{
		if (mc_gross == null)
		{
			Adapter.UpdateCommand.Parameters[0].Value = DBNull.Value;
		}
		else
		{
			Adapter.UpdateCommand.Parameters[0].Value = mc_gross;
		}
		if (item_number1 == null)
		{
			Adapter.UpdateCommand.Parameters[1].Value = DBNull.Value;
		}
		else
		{
			Adapter.UpdateCommand.Parameters[1].Value = item_number1;
		}
		if (payer_id == null)
		{
			Adapter.UpdateCommand.Parameters[2].Value = DBNull.Value;
		}
		else
		{
			Adapter.UpdateCommand.Parameters[2].Value = payer_id;
		}
		if (tax == null)
		{
			Adapter.UpdateCommand.Parameters[3].Value = DBNull.Value;
		}
		else
		{
			Adapter.UpdateCommand.Parameters[3].Value = tax;
		}
		if (payment_date == null)
		{
			Adapter.UpdateCommand.Parameters[4].Value = DBNull.Value;
		}
		else
		{
			Adapter.UpdateCommand.Parameters[4].Value = payment_date;
		}
		if (payment_status == null)
		{
			Adapter.UpdateCommand.Parameters[5].Value = DBNull.Value;
		}
		else
		{
			Adapter.UpdateCommand.Parameters[5].Value = payment_status;
		}
		if (charset == null)
		{
			Adapter.UpdateCommand.Parameters[6].Value = DBNull.Value;
		}
		else
		{
			Adapter.UpdateCommand.Parameters[6].Value = charset;
		}
		if (mc_tax1 == null)
		{
			Adapter.UpdateCommand.Parameters[7].Value = DBNull.Value;
		}
		else
		{
			Adapter.UpdateCommand.Parameters[7].Value = mc_tax1;
		}
		if (mc_shipping == null)
		{
			Adapter.UpdateCommand.Parameters[8].Value = DBNull.Value;
		}
		else
		{
			Adapter.UpdateCommand.Parameters[8].Value = mc_shipping;
		}
		if (mc_handling == null)
		{
			Adapter.UpdateCommand.Parameters[9].Value = DBNull.Value;
		}
		else
		{
			Adapter.UpdateCommand.Parameters[9].Value = mc_handling;
		}
		if (first_name == null)
		{
			Adapter.UpdateCommand.Parameters[10].Value = DBNull.Value;
		}
		else
		{
			Adapter.UpdateCommand.Parameters[10].Value = first_name;
		}
		if (notify_version == null)
		{
			Adapter.UpdateCommand.Parameters[11].Value = DBNull.Value;
		}
		else
		{
			Adapter.UpdateCommand.Parameters[11].Value = notify_version;
		}
		if (custom == null)
		{
			Adapter.UpdateCommand.Parameters[12].Value = DBNull.Value;
		}
		else
		{
			Adapter.UpdateCommand.Parameters[12].Value = custom;
		}
		if (payer_status == null)
		{
			Adapter.UpdateCommand.Parameters[13].Value = DBNull.Value;
		}
		else
		{
			Adapter.UpdateCommand.Parameters[13].Value = payer_status;
		}
		if (num_cart_items == null)
		{
			Adapter.UpdateCommand.Parameters[14].Value = DBNull.Value;
		}
		else
		{
			Adapter.UpdateCommand.Parameters[14].Value = num_cart_items;
		}
		if (mc_handling1 == null)
		{
			Adapter.UpdateCommand.Parameters[15].Value = DBNull.Value;
		}
		else
		{
			Adapter.UpdateCommand.Parameters[15].Value = mc_handling1;
		}
		if (verify_sign == null)
		{
			Adapter.UpdateCommand.Parameters[16].Value = DBNull.Value;
		}
		else
		{
			Adapter.UpdateCommand.Parameters[16].Value = verify_sign;
		}
		if (payer_email == null)
		{
			Adapter.UpdateCommand.Parameters[17].Value = DBNull.Value;
		}
		else
		{
			Adapter.UpdateCommand.Parameters[17].Value = payer_email;
		}
		if (mc_shipping1 == null)
		{
			Adapter.UpdateCommand.Parameters[18].Value = DBNull.Value;
		}
		else
		{
			Adapter.UpdateCommand.Parameters[18].Value = mc_shipping1;
		}
		if (tax1 == null)
		{
			Adapter.UpdateCommand.Parameters[19].Value = DBNull.Value;
		}
		else
		{
			Adapter.UpdateCommand.Parameters[19].Value = tax1;
		}
		if (txn_id == null)
		{
			Adapter.UpdateCommand.Parameters[20].Value = DBNull.Value;
		}
		else
		{
			Adapter.UpdateCommand.Parameters[20].Value = txn_id;
		}
		if (payment_type == null)
		{
			Adapter.UpdateCommand.Parameters[21].Value = DBNull.Value;
		}
		else
		{
			Adapter.UpdateCommand.Parameters[21].Value = payment_type;
		}
		if (last_name == null)
		{
			Adapter.UpdateCommand.Parameters[22].Value = DBNull.Value;
		}
		else
		{
			Adapter.UpdateCommand.Parameters[22].Value = last_name;
		}
		if (item_name1 == null)
		{
			Adapter.UpdateCommand.Parameters[23].Value = DBNull.Value;
		}
		else
		{
			Adapter.UpdateCommand.Parameters[23].Value = item_name1;
		}
		if (quantity1 == null)
		{
			Adapter.UpdateCommand.Parameters[24].Value = DBNull.Value;
		}
		else
		{
			Adapter.UpdateCommand.Parameters[24].Value = quantity1;
		}
		if (pending_reason == null)
		{
			Adapter.UpdateCommand.Parameters[25].Value = DBNull.Value;
		}
		else
		{
			Adapter.UpdateCommand.Parameters[25].Value = pending_reason;
		}
		if (txn_type == null)
		{
			Adapter.UpdateCommand.Parameters[26].Value = DBNull.Value;
		}
		else
		{
			Adapter.UpdateCommand.Parameters[26].Value = txn_type;
		}
		if (mc_gross_1 == null)
		{
			Adapter.UpdateCommand.Parameters[27].Value = DBNull.Value;
		}
		else
		{
			Adapter.UpdateCommand.Parameters[27].Value = mc_gross_1;
		}
		if (mc_currency == null)
		{
			Adapter.UpdateCommand.Parameters[28].Value = DBNull.Value;
		}
		else
		{
			Adapter.UpdateCommand.Parameters[28].Value = mc_currency;
		}
		if (residence_country == null)
		{
			Adapter.UpdateCommand.Parameters[29].Value = DBNull.Value;
		}
		else
		{
			Adapter.UpdateCommand.Parameters[29].Value = residence_country;
		}
		if (test_ipn == null)
		{
			Adapter.UpdateCommand.Parameters[30].Value = DBNull.Value;
		}
		else
		{
			Adapter.UpdateCommand.Parameters[30].Value = test_ipn;
		}
		if (payment_gross == null)
		{
			Adapter.UpdateCommand.Parameters[31].Value = DBNull.Value;
		}
		else
		{
			Adapter.UpdateCommand.Parameters[31].Value = payment_gross;
		}
		if (username == null)
		{
			throw new ArgumentNullException("username");
		}
		Adapter.UpdateCommand.Parameters[32].Value = username;
		if (p1 == null)
		{
			Adapter.UpdateCommand.Parameters[33].Value = DBNull.Value;
		}
		else
		{
			Adapter.UpdateCommand.Parameters[33].Value = p1;
		}
		Adapter.UpdateCommand.Parameters[34].Value = Original_id;
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
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	[DebuggerNonUserCode]
	public virtual int InsertQuery(string mc_gross, string item_number1, string payer_id, string tax, string payment_date, string payment_status, string charset, string mc_tax1, string mc_shipping, string mc_handling, string first_name, string notify_version, string custom, string payer_status, string num_cart_items, string mc_handling1, string verify_sign, string payer_email, string mc_shipping1, string tax1, string txn_id, string payment_type, string last_name, string item_name1, string quantity1, string pending_reason, string txn_type, string mc_gross_1, string mc_currency, string residence_country, string test_ipn, string payment_gross, string username, string emailr)
	{
		SqlCommand val = CommandCollection[1];
		if (mc_gross == null)
		{
			val.Parameters[0].Value = DBNull.Value;
		}
		else
		{
			val.Parameters[0].Value = mc_gross;
		}
		if (item_number1 == null)
		{
			val.Parameters[1].Value = DBNull.Value;
		}
		else
		{
			val.Parameters[1].Value = item_number1;
		}
		if (payer_id == null)
		{
			val.Parameters[2].Value = DBNull.Value;
		}
		else
		{
			val.Parameters[2].Value = payer_id;
		}
		if (tax == null)
		{
			val.Parameters[3].Value = DBNull.Value;
		}
		else
		{
			val.Parameters[3].Value = tax;
		}
		if (payment_date == null)
		{
			val.Parameters[4].Value = DBNull.Value;
		}
		else
		{
			val.Parameters[4].Value = payment_date;
		}
		if (payment_status == null)
		{
			val.Parameters[5].Value = DBNull.Value;
		}
		else
		{
			val.Parameters[5].Value = payment_status;
		}
		if (charset == null)
		{
			val.Parameters[6].Value = DBNull.Value;
		}
		else
		{
			val.Parameters[6].Value = charset;
		}
		if (mc_tax1 == null)
		{
			val.Parameters[7].Value = DBNull.Value;
		}
		else
		{
			val.Parameters[7].Value = mc_tax1;
		}
		if (mc_shipping == null)
		{
			val.Parameters[8].Value = DBNull.Value;
		}
		else
		{
			val.Parameters[8].Value = mc_shipping;
		}
		if (mc_handling == null)
		{
			val.Parameters[9].Value = DBNull.Value;
		}
		else
		{
			val.Parameters[9].Value = mc_handling;
		}
		if (first_name == null)
		{
			val.Parameters[10].Value = DBNull.Value;
		}
		else
		{
			val.Parameters[10].Value = first_name;
		}
		if (notify_version == null)
		{
			val.Parameters[11].Value = DBNull.Value;
		}
		else
		{
			val.Parameters[11].Value = notify_version;
		}
		if (custom == null)
		{
			val.Parameters[12].Value = DBNull.Value;
		}
		else
		{
			val.Parameters[12].Value = custom;
		}
		if (payer_status == null)
		{
			val.Parameters[13].Value = DBNull.Value;
		}
		else
		{
			val.Parameters[13].Value = payer_status;
		}
		if (num_cart_items == null)
		{
			val.Parameters[14].Value = DBNull.Value;
		}
		else
		{
			val.Parameters[14].Value = num_cart_items;
		}
		if (mc_handling1 == null)
		{
			val.Parameters[15].Value = DBNull.Value;
		}
		else
		{
			val.Parameters[15].Value = mc_handling1;
		}
		if (verify_sign == null)
		{
			val.Parameters[16].Value = DBNull.Value;
		}
		else
		{
			val.Parameters[16].Value = verify_sign;
		}
		if (payer_email == null)
		{
			val.Parameters[17].Value = DBNull.Value;
		}
		else
		{
			val.Parameters[17].Value = payer_email;
		}
		if (mc_shipping1 == null)
		{
			val.Parameters[18].Value = DBNull.Value;
		}
		else
		{
			val.Parameters[18].Value = mc_shipping1;
		}
		if (tax1 == null)
		{
			val.Parameters[19].Value = DBNull.Value;
		}
		else
		{
			val.Parameters[19].Value = tax1;
		}
		if (txn_id == null)
		{
			val.Parameters[20].Value = DBNull.Value;
		}
		else
		{
			val.Parameters[20].Value = txn_id;
		}
		if (payment_type == null)
		{
			val.Parameters[21].Value = DBNull.Value;
		}
		else
		{
			val.Parameters[21].Value = payment_type;
		}
		if (last_name == null)
		{
			val.Parameters[22].Value = DBNull.Value;
		}
		else
		{
			val.Parameters[22].Value = last_name;
		}
		if (item_name1 == null)
		{
			val.Parameters[23].Value = DBNull.Value;
		}
		else
		{
			val.Parameters[23].Value = item_name1;
		}
		if (quantity1 == null)
		{
			val.Parameters[24].Value = DBNull.Value;
		}
		else
		{
			val.Parameters[24].Value = quantity1;
		}
		if (pending_reason == null)
		{
			val.Parameters[25].Value = DBNull.Value;
		}
		else
		{
			val.Parameters[25].Value = pending_reason;
		}
		if (txn_type == null)
		{
			val.Parameters[26].Value = DBNull.Value;
		}
		else
		{
			val.Parameters[26].Value = txn_type;
		}
		if (mc_gross_1 == null)
		{
			val.Parameters[27].Value = DBNull.Value;
		}
		else
		{
			val.Parameters[27].Value = mc_gross_1;
		}
		if (mc_currency == null)
		{
			val.Parameters[28].Value = DBNull.Value;
		}
		else
		{
			val.Parameters[28].Value = mc_currency;
		}
		if (residence_country == null)
		{
			val.Parameters[29].Value = DBNull.Value;
		}
		else
		{
			val.Parameters[29].Value = residence_country;
		}
		if (test_ipn == null)
		{
			val.Parameters[30].Value = DBNull.Value;
		}
		else
		{
			val.Parameters[30].Value = test_ipn;
		}
		if (payment_gross == null)
		{
			val.Parameters[31].Value = DBNull.Value;
		}
		else
		{
			val.Parameters[31].Value = payment_gross;
		}
		if (username == null)
		{
			throw new ArgumentNullException("username");
		}
		val.Parameters[32].Value = username;
		if (emailr == null)
		{
			val.Parameters[33].Value = DBNull.Value;
		}
		else
		{
			val.Parameters[33].Value = emailr;
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
