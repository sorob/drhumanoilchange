using System;
using System.Diagnostics;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Web;
using System.Web.Compilation;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;

namespace ASP;

[CompilerGlobalScope]
public class buy_aspx : buy
{
	private static bool __initialized;

	private static object __stringResource;

	private static object __fileDependencies;

	protected override bool SupportAutoEvents => false;

	[DebuggerNonUserCode]
	public buy_aspx()
	{
		((TemplateControl)this).AppRelativeVirtualPath = "~/buy.aspx";
		if (!__initialized)
		{
			__stringResource = RuntimeHelpers.GetObjectValue(((TemplateControl)this).ReadStringResource());
			__fileDependencies = RuntimeHelpers.GetObjectValue(((Page)this).GetWrappedFileDependencies(new string[4] { "~/buy.aspx", "~/master1.master", "~/master1.master.vb", "~/buy.aspx.vb" }));
			__initialized = true;
		}
		((Page)this).Server.ScriptTimeout = 30000000;
	}

	[DebuggerNonUserCode]
	private Parameter __BuildControl__control3()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Parameter val = new Parameter();
		val.Name = "mc_gross";
		val.Type = TypeCode.String;
		return val;
	}

	[DebuggerNonUserCode]
	private Parameter __BuildControl__control4()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Parameter val = new Parameter();
		val.Name = "item_number1";
		val.Type = TypeCode.String;
		return val;
	}

	[DebuggerNonUserCode]
	private Parameter __BuildControl__control5()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Parameter val = new Parameter();
		val.Name = "payer_id";
		val.Type = TypeCode.String;
		return val;
	}

	[DebuggerNonUserCode]
	private Parameter __BuildControl__control6()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Parameter val = new Parameter();
		val.Name = "tax";
		val.Type = TypeCode.String;
		return val;
	}

	[DebuggerNonUserCode]
	private Parameter __BuildControl__control7()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Parameter val = new Parameter();
		val.Name = "payment_date";
		val.Type = TypeCode.String;
		return val;
	}

	[DebuggerNonUserCode]
	private Parameter __BuildControl__control8()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Parameter val = new Parameter();
		val.Name = "payment_status";
		val.Type = TypeCode.String;
		return val;
	}

	[DebuggerNonUserCode]
	private Parameter __BuildControl__control9()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Parameter val = new Parameter();
		val.Name = "charset";
		val.Type = TypeCode.String;
		return val;
	}

	[DebuggerNonUserCode]
	private Parameter __BuildControl__control10()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Parameter val = new Parameter();
		val.Name = "mc_tax1";
		val.Type = TypeCode.String;
		return val;
	}

	[DebuggerNonUserCode]
	private Parameter __BuildControl__control11()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Parameter val = new Parameter();
		val.Name = "mc_shipping";
		val.Type = TypeCode.String;
		return val;
	}

	[DebuggerNonUserCode]
	private Parameter __BuildControl__control12()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Parameter val = new Parameter();
		val.Name = "mc_handling";
		val.Type = TypeCode.String;
		return val;
	}

	[DebuggerNonUserCode]
	private Parameter __BuildControl__control13()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Parameter val = new Parameter();
		val.Name = "first_name";
		val.Type = TypeCode.String;
		return val;
	}

	[DebuggerNonUserCode]
	private Parameter __BuildControl__control14()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Parameter val = new Parameter();
		val.Name = "notify_version";
		val.Type = TypeCode.String;
		return val;
	}

	[DebuggerNonUserCode]
	private Parameter __BuildControl__control15()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Parameter val = new Parameter();
		val.Name = "custom";
		val.Type = TypeCode.String;
		return val;
	}

	[DebuggerNonUserCode]
	private Parameter __BuildControl__control16()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Parameter val = new Parameter();
		val.Name = "payer_status";
		val.Type = TypeCode.String;
		return val;
	}

	[DebuggerNonUserCode]
	private Parameter __BuildControl__control17()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Parameter val = new Parameter();
		val.Name = "num_cart_items";
		val.Type = TypeCode.String;
		return val;
	}

	[DebuggerNonUserCode]
	private Parameter __BuildControl__control18()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Parameter val = new Parameter();
		val.Name = "mc_handling1";
		val.Type = TypeCode.String;
		return val;
	}

	[DebuggerNonUserCode]
	private Parameter __BuildControl__control19()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Parameter val = new Parameter();
		val.Name = "verify_sign";
		val.Type = TypeCode.String;
		return val;
	}

	[DebuggerNonUserCode]
	private Parameter __BuildControl__control20()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Parameter val = new Parameter();
		val.Name = "payer_email";
		val.Type = TypeCode.String;
		return val;
	}

	[DebuggerNonUserCode]
	private Parameter __BuildControl__control21()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Parameter val = new Parameter();
		val.Name = "mc_shipping1";
		val.Type = TypeCode.String;
		return val;
	}

	[DebuggerNonUserCode]
	private Parameter __BuildControl__control22()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Parameter val = new Parameter();
		val.Name = "tax1";
		val.Type = TypeCode.String;
		return val;
	}

	[DebuggerNonUserCode]
	private Parameter __BuildControl__control23()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Parameter val = new Parameter();
		val.Name = "txn_id";
		val.Type = TypeCode.String;
		return val;
	}

	[DebuggerNonUserCode]
	private Parameter __BuildControl__control24()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Parameter val = new Parameter();
		val.Name = "payment_type";
		val.Type = TypeCode.String;
		return val;
	}

	[DebuggerNonUserCode]
	private Parameter __BuildControl__control25()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Parameter val = new Parameter();
		val.Name = "last_name";
		val.Type = TypeCode.String;
		return val;
	}

	[DebuggerNonUserCode]
	private Parameter __BuildControl__control26()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Parameter val = new Parameter();
		val.Name = "item_name1";
		val.Type = TypeCode.String;
		return val;
	}

	[DebuggerNonUserCode]
	private Parameter __BuildControl__control27()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Parameter val = new Parameter();
		val.Name = "column1";
		val.Type = TypeCode.String;
		return val;
	}

	[DebuggerNonUserCode]
	private Parameter __BuildControl__control28()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Parameter val = new Parameter();
		val.Name = "quantity1";
		val.Type = TypeCode.String;
		return val;
	}

	[DebuggerNonUserCode]
	private Parameter __BuildControl__control29()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Parameter val = new Parameter();
		val.Name = "pending_reason";
		val.Type = TypeCode.String;
		return val;
	}

	[DebuggerNonUserCode]
	private Parameter __BuildControl__control30()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Parameter val = new Parameter();
		val.Name = "txn_type";
		val.Type = TypeCode.String;
		return val;
	}

	[DebuggerNonUserCode]
	private Parameter __BuildControl__control31()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Parameter val = new Parameter();
		val.Name = "mc_gross_1";
		val.Type = TypeCode.String;
		return val;
	}

	[DebuggerNonUserCode]
	private Parameter __BuildControl__control32()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Parameter val = new Parameter();
		val.Name = "mc_currency";
		val.Type = TypeCode.String;
		return val;
	}

	[DebuggerNonUserCode]
	private Parameter __BuildControl__control33()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Parameter val = new Parameter();
		val.Name = "residence_country";
		val.Type = TypeCode.String;
		return val;
	}

	[DebuggerNonUserCode]
	private Parameter __BuildControl__control34()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Parameter val = new Parameter();
		val.Name = "test_ipn";
		val.Type = TypeCode.String;
		return val;
	}

	[DebuggerNonUserCode]
	private Parameter __BuildControl__control35()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Parameter val = new Parameter();
		val.Name = "payment_gross";
		val.Type = TypeCode.String;
		return val;
	}

	[DebuggerNonUserCode]
	private Parameter __BuildControl__control36()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Parameter val = new Parameter();
		val.Name = "username";
		val.Type = TypeCode.String;
		return val;
	}

	[DebuggerNonUserCode]
	private void __BuildControl__control2(ParameterCollection __ctrl)
	{
		Parameter val = __BuildControl__control3();
		__ctrl.Add(val);
		Parameter val2 = __BuildControl__control4();
		__ctrl.Add(val2);
		Parameter val3 = __BuildControl__control5();
		__ctrl.Add(val3);
		Parameter val4 = __BuildControl__control6();
		__ctrl.Add(val4);
		Parameter val5 = __BuildControl__control7();
		__ctrl.Add(val5);
		Parameter val6 = __BuildControl__control8();
		__ctrl.Add(val6);
		Parameter val7 = __BuildControl__control9();
		__ctrl.Add(val7);
		Parameter val8 = __BuildControl__control10();
		__ctrl.Add(val8);
		Parameter val9 = __BuildControl__control11();
		__ctrl.Add(val9);
		Parameter val10 = __BuildControl__control12();
		__ctrl.Add(val10);
		Parameter val11 = __BuildControl__control13();
		__ctrl.Add(val11);
		Parameter val12 = __BuildControl__control14();
		__ctrl.Add(val12);
		Parameter val13 = __BuildControl__control15();
		__ctrl.Add(val13);
		Parameter val14 = __BuildControl__control16();
		__ctrl.Add(val14);
		Parameter val15 = __BuildControl__control17();
		__ctrl.Add(val15);
		Parameter val16 = __BuildControl__control18();
		__ctrl.Add(val16);
		Parameter val17 = __BuildControl__control19();
		__ctrl.Add(val17);
		Parameter val18 = __BuildControl__control20();
		__ctrl.Add(val18);
		Parameter val19 = __BuildControl__control21();
		__ctrl.Add(val19);
		Parameter val20 = __BuildControl__control22();
		__ctrl.Add(val20);
		Parameter val21 = __BuildControl__control23();
		__ctrl.Add(val21);
		Parameter val22 = __BuildControl__control24();
		__ctrl.Add(val22);
		Parameter val23 = __BuildControl__control25();
		__ctrl.Add(val23);
		Parameter val24 = __BuildControl__control26();
		__ctrl.Add(val24);
		Parameter val25 = __BuildControl__control27();
		__ctrl.Add(val25);
		Parameter val26 = __BuildControl__control28();
		__ctrl.Add(val26);
		Parameter val27 = __BuildControl__control29();
		__ctrl.Add(val27);
		Parameter val28 = __BuildControl__control30();
		__ctrl.Add(val28);
		Parameter val29 = __BuildControl__control31();
		__ctrl.Add(val29);
		Parameter val30 = __BuildControl__control32();
		__ctrl.Add(val30);
		Parameter val31 = __BuildControl__control33();
		__ctrl.Add(val31);
		Parameter val32 = __BuildControl__control34();
		__ctrl.Add(val32);
		Parameter val33 = __BuildControl__control35();
		__ctrl.Add(val33);
		Parameter val34 = __BuildControl__control36();
		__ctrl.Add(val34);
	}

	[DebuggerNonUserCode]
	private Parameter __BuildControl__control38()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Parameter val = new Parameter();
		val.Name = "mc_gross";
		val.Type = TypeCode.String;
		return val;
	}

	[DebuggerNonUserCode]
	private Parameter __BuildControl__control39()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Parameter val = new Parameter();
		val.Name = "item_number1";
		val.Type = TypeCode.String;
		return val;
	}

	[DebuggerNonUserCode]
	private Parameter __BuildControl__control40()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Parameter val = new Parameter();
		val.Name = "payer_id";
		val.Type = TypeCode.String;
		return val;
	}

	[DebuggerNonUserCode]
	private Parameter __BuildControl__control41()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Parameter val = new Parameter();
		val.Name = "tax";
		val.Type = TypeCode.String;
		return val;
	}

	[DebuggerNonUserCode]
	private Parameter __BuildControl__control42()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Parameter val = new Parameter();
		val.Name = "payment_date";
		val.Type = TypeCode.String;
		return val;
	}

	[DebuggerNonUserCode]
	private Parameter __BuildControl__control43()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Parameter val = new Parameter();
		val.Name = "payment_status";
		val.Type = TypeCode.String;
		return val;
	}

	[DebuggerNonUserCode]
	private Parameter __BuildControl__control44()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Parameter val = new Parameter();
		val.Name = "charset";
		val.Type = TypeCode.String;
		return val;
	}

	[DebuggerNonUserCode]
	private Parameter __BuildControl__control45()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Parameter val = new Parameter();
		val.Name = "mc_tax1";
		val.Type = TypeCode.String;
		return val;
	}

	[DebuggerNonUserCode]
	private Parameter __BuildControl__control46()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Parameter val = new Parameter();
		val.Name = "mc_shipping";
		val.Type = TypeCode.String;
		return val;
	}

	[DebuggerNonUserCode]
	private Parameter __BuildControl__control47()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Parameter val = new Parameter();
		val.Name = "mc_handling";
		val.Type = TypeCode.String;
		return val;
	}

	[DebuggerNonUserCode]
	private Parameter __BuildControl__control48()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Parameter val = new Parameter();
		val.Name = "first_name";
		val.Type = TypeCode.String;
		return val;
	}

	[DebuggerNonUserCode]
	private Parameter __BuildControl__control49()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Parameter val = new Parameter();
		val.Name = "notify_version";
		val.Type = TypeCode.String;
		return val;
	}

	[DebuggerNonUserCode]
	private Parameter __BuildControl__control50()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Parameter val = new Parameter();
		val.Name = "custom";
		val.Type = TypeCode.String;
		return val;
	}

	[DebuggerNonUserCode]
	private Parameter __BuildControl__control51()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Parameter val = new Parameter();
		val.Name = "payer_status";
		val.Type = TypeCode.String;
		return val;
	}

	[DebuggerNonUserCode]
	private Parameter __BuildControl__control52()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Parameter val = new Parameter();
		val.Name = "num_cart_items";
		val.Type = TypeCode.String;
		return val;
	}

	[DebuggerNonUserCode]
	private Parameter __BuildControl__control53()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Parameter val = new Parameter();
		val.Name = "mc_handling1";
		val.Type = TypeCode.String;
		return val;
	}

	[DebuggerNonUserCode]
	private Parameter __BuildControl__control54()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Parameter val = new Parameter();
		val.Name = "verify_sign";
		val.Type = TypeCode.String;
		return val;
	}

	[DebuggerNonUserCode]
	private Parameter __BuildControl__control55()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Parameter val = new Parameter();
		val.Name = "payer_email";
		val.Type = TypeCode.String;
		return val;
	}

	[DebuggerNonUserCode]
	private Parameter __BuildControl__control56()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Parameter val = new Parameter();
		val.Name = "mc_shipping1";
		val.Type = TypeCode.String;
		return val;
	}

	[DebuggerNonUserCode]
	private Parameter __BuildControl__control57()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Parameter val = new Parameter();
		val.Name = "tax1";
		val.Type = TypeCode.String;
		return val;
	}

	[DebuggerNonUserCode]
	private Parameter __BuildControl__control58()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Parameter val = new Parameter();
		val.Name = "txn_id";
		val.Type = TypeCode.String;
		return val;
	}

	[DebuggerNonUserCode]
	private Parameter __BuildControl__control59()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Parameter val = new Parameter();
		val.Name = "payment_type";
		val.Type = TypeCode.String;
		return val;
	}

	[DebuggerNonUserCode]
	private Parameter __BuildControl__control60()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Parameter val = new Parameter();
		val.Name = "last_name";
		val.Type = TypeCode.String;
		return val;
	}

	[DebuggerNonUserCode]
	private Parameter __BuildControl__control61()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Parameter val = new Parameter();
		val.Name = "item_name1";
		val.Type = TypeCode.String;
		return val;
	}

	[DebuggerNonUserCode]
	private Parameter __BuildControl__control62()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Parameter val = new Parameter();
		val.Name = "column1";
		val.Type = TypeCode.String;
		return val;
	}

	[DebuggerNonUserCode]
	private Parameter __BuildControl__control63()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Parameter val = new Parameter();
		val.Name = "quantity1";
		val.Type = TypeCode.String;
		return val;
	}

	[DebuggerNonUserCode]
	private Parameter __BuildControl__control64()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Parameter val = new Parameter();
		val.Name = "pending_reason";
		val.Type = TypeCode.String;
		return val;
	}

	[DebuggerNonUserCode]
	private Parameter __BuildControl__control65()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Parameter val = new Parameter();
		val.Name = "txn_type";
		val.Type = TypeCode.String;
		return val;
	}

	[DebuggerNonUserCode]
	private Parameter __BuildControl__control66()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Parameter val = new Parameter();
		val.Name = "mc_gross_1";
		val.Type = TypeCode.String;
		return val;
	}

	[DebuggerNonUserCode]
	private Parameter __BuildControl__control67()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Parameter val = new Parameter();
		val.Name = "mc_currency";
		val.Type = TypeCode.String;
		return val;
	}

	[DebuggerNonUserCode]
	private Parameter __BuildControl__control68()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Parameter val = new Parameter();
		val.Name = "residence_country";
		val.Type = TypeCode.String;
		return val;
	}

	[DebuggerNonUserCode]
	private Parameter __BuildControl__control69()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Parameter val = new Parameter();
		val.Name = "test_ipn";
		val.Type = TypeCode.String;
		return val;
	}

	[DebuggerNonUserCode]
	private Parameter __BuildControl__control70()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Parameter val = new Parameter();
		val.Name = "payment_gross";
		val.Type = TypeCode.String;
		return val;
	}

	[DebuggerNonUserCode]
	private Parameter __BuildControl__control71()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Parameter val = new Parameter();
		val.Name = "username";
		val.Type = TypeCode.String;
		return val;
	}

	[DebuggerNonUserCode]
	private Parameter __BuildControl__control72()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Parameter val = new Parameter();
		val.Name = "id";
		val.Type = TypeCode.Int32;
		return val;
	}

	[DebuggerNonUserCode]
	private void __BuildControl__control37(ParameterCollection __ctrl)
	{
		Parameter val = __BuildControl__control38();
		__ctrl.Add(val);
		Parameter val2 = __BuildControl__control39();
		__ctrl.Add(val2);
		Parameter val3 = __BuildControl__control40();
		__ctrl.Add(val3);
		Parameter val4 = __BuildControl__control41();
		__ctrl.Add(val4);
		Parameter val5 = __BuildControl__control42();
		__ctrl.Add(val5);
		Parameter val6 = __BuildControl__control43();
		__ctrl.Add(val6);
		Parameter val7 = __BuildControl__control44();
		__ctrl.Add(val7);
		Parameter val8 = __BuildControl__control45();
		__ctrl.Add(val8);
		Parameter val9 = __BuildControl__control46();
		__ctrl.Add(val9);
		Parameter val10 = __BuildControl__control47();
		__ctrl.Add(val10);
		Parameter val11 = __BuildControl__control48();
		__ctrl.Add(val11);
		Parameter val12 = __BuildControl__control49();
		__ctrl.Add(val12);
		Parameter val13 = __BuildControl__control50();
		__ctrl.Add(val13);
		Parameter val14 = __BuildControl__control51();
		__ctrl.Add(val14);
		Parameter val15 = __BuildControl__control52();
		__ctrl.Add(val15);
		Parameter val16 = __BuildControl__control53();
		__ctrl.Add(val16);
		Parameter val17 = __BuildControl__control54();
		__ctrl.Add(val17);
		Parameter val18 = __BuildControl__control55();
		__ctrl.Add(val18);
		Parameter val19 = __BuildControl__control56();
		__ctrl.Add(val19);
		Parameter val20 = __BuildControl__control57();
		__ctrl.Add(val20);
		Parameter val21 = __BuildControl__control58();
		__ctrl.Add(val21);
		Parameter val22 = __BuildControl__control59();
		__ctrl.Add(val22);
		Parameter val23 = __BuildControl__control60();
		__ctrl.Add(val23);
		Parameter val24 = __BuildControl__control61();
		__ctrl.Add(val24);
		Parameter val25 = __BuildControl__control62();
		__ctrl.Add(val25);
		Parameter val26 = __BuildControl__control63();
		__ctrl.Add(val26);
		Parameter val27 = __BuildControl__control64();
		__ctrl.Add(val27);
		Parameter val28 = __BuildControl__control65();
		__ctrl.Add(val28);
		Parameter val29 = __BuildControl__control66();
		__ctrl.Add(val29);
		Parameter val30 = __BuildControl__control67();
		__ctrl.Add(val30);
		Parameter val31 = __BuildControl__control68();
		__ctrl.Add(val31);
		Parameter val32 = __BuildControl__control69();
		__ctrl.Add(val32);
		Parameter val33 = __BuildControl__control70();
		__ctrl.Add(val33);
		Parameter val34 = __BuildControl__control71();
		__ctrl.Add(val34);
		Parameter val35 = __BuildControl__control72();
		__ctrl.Add(val35);
	}

	[DebuggerNonUserCode]
	private Parameter __BuildControl__control74()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Parameter val = new Parameter();
		val.Name = "id";
		val.Type = TypeCode.Int32;
		return val;
	}

	[DebuggerNonUserCode]
	private void __BuildControl__control73(ParameterCollection __ctrl)
	{
		Parameter val = __BuildControl__control74();
		__ctrl.Add(val);
	}

	[DebuggerNonUserCode]
	private SqlDataSource __BuildControlSqlDataSource1()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		SqlDataSource val = (SqlDataSource1 = new SqlDataSource());
		((Control)val).TemplateControl = (TemplateControl)(object)this;
		((Control)val).ID = "SqlDataSource1";
		val.DeleteCommand = "DELETE FROM [ahn] WHERE [id] = @id";
		val.InsertCommand = "INSERT INTO [ahn] ([mc_gross], [item_number1], [payer_id], [tax], [payment_date], [payment_status], [charset], [mc_tax1], [mc_shipping], [mc_handling], [first_name], [notify_version], [custom], [payer_status], [num_cart_items], [mc_handling1], [verify_sign], [payer_email], [mc_shipping1], [tax1], [txn_id], [payment_type], [last_name], [item_name1], [25receiver_email], [quantity1], [pending_reason], [txn_type], [mc_gross_1], [mc_currency], [residence_country], [test_ipn], [payment_gross], [username]) VALUES (@mc_gross, @item_number1, @payer_id, @tax, @payment_date, @payment_status, @charset, @mc_tax1, @mc_shipping, @mc_handling, @first_name, @notify_version, @custom, @payer_status, @num_cart_items, @mc_handling1, @verify_sign, @payer_email, @mc_shipping1, @tax1, @txn_id, @payment_type, @last_name, @item_name1, @column1, @quantity1, @pending_reason, @txn_type, @mc_gross_1, @mc_currency, @residence_country, @test_ipn, @payment_gross, @username)";
		val.SelectCommand = "SELECT [mc_gross], [item_number1], [payer_id], [tax], [payment_date], [payment_status], [charset], [mc_tax1], [mc_shipping], [mc_handling], [first_name], [notify_version], [custom], [payer_status], [num_cart_items], [mc_handling1], [verify_sign], [payer_email], [mc_shipping1], [tax1], [txn_id], [payment_type], [last_name], [item_name1], [25receiver_email] AS column1, [quantity1], [pending_reason], [txn_type], [mc_gross_1], [mc_currency], [residence_country], [test_ipn], [payment_gross], [username], [id] FROM [ahn]";
		val.UpdateCommand = "UPDATE [ahn] SET [mc_gross] = @mc_gross, [item_number1] = @item_number1, [payer_id] = @payer_id, [tax] = @tax, [payment_date] = @payment_date, [payment_status] = @payment_status, [charset] = @charset, [mc_tax1] = @mc_tax1, [mc_shipping] = @mc_shipping, [mc_handling] = @mc_handling, [first_name] = @first_name, [notify_version] = @notify_version, [custom] = @custom, [payer_status] = @payer_status, [num_cart_items] = @num_cart_items, [mc_handling1] = @mc_handling1, [verify_sign] = @verify_sign, [payer_email] = @payer_email, [mc_shipping1] = @mc_shipping1, [tax1] = @tax1, [txn_id] = @txn_id, [payment_type] = @payment_type, [last_name] = @last_name, [item_name1] = @item_name1, [25receiver_email] = @column1, [quantity1] = @quantity1, [pending_reason] = @pending_reason, [txn_type] = @txn_type, [mc_gross_1] = @mc_gross_1, [mc_currency] = @mc_currency, [residence_country] = @residence_country, [test_ipn] = @test_ipn, [payment_gross] = @payment_gross, [username] = @username WHERE [id] = @id";
		__BuildControl__control2(val.InsertParameters);
		__BuildControl__control37(val.UpdateParameters);
		__BuildControl__control73(val.DeleteParameters);
		val.ConnectionString = Convert.ToString(ConnectionStringsExpressionBuilder.GetConnectionString("LocalSqlServer"), CultureInfo.CurrentCulture);
		val.ProviderName = Convert.ToString(ConnectionStringsExpressionBuilder.GetConnectionStringProviderName("LocalSqlServer"), CultureInfo.CurrentCulture);
		return val;
	}

	[DebuggerNonUserCode]
	private Label __BuildControlLabel2()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Label val = (Label2 = new Label());
		((Control)val).ApplyStyleSheetSkin((Page)(object)this);
		((Control)val).ID = "Label2";
		return val;
	}

	[DebuggerNonUserCode]
	private Label __BuildControlLabel30()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Label val = (Label30 = new Label());
		((Control)val).ApplyStyleSheetSkin((Page)(object)this);
		((Control)val).ID = "Label30";
		return val;
	}

	[DebuggerNonUserCode]
	private Label __BuildControlLabel19()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Label val = (Label19 = new Label());
		((Control)val).ApplyStyleSheetSkin((Page)(object)this);
		((Control)val).ID = "Label19";
		return val;
	}

	[DebuggerNonUserCode]
	private Label __BuildControlLabel3()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Label val = (Label3 = new Label());
		((Control)val).ApplyStyleSheetSkin((Page)(object)this);
		((Control)val).ID = "Label3";
		return val;
	}

	[DebuggerNonUserCode]
	private Label __BuildControlLabel31()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Label val = (Label31 = new Label());
		((Control)val).ApplyStyleSheetSkin((Page)(object)this);
		((Control)val).ID = "Label31";
		return val;
	}

	[DebuggerNonUserCode]
	private Label __BuildControlLabel5()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Label val = (Label5 = new Label());
		((Control)val).ApplyStyleSheetSkin((Page)(object)this);
		((Control)val).ID = "Label5";
		return val;
	}

	[DebuggerNonUserCode]
	private Label __BuildControlLabel6()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Label val = (Label6 = new Label());
		((Control)val).ApplyStyleSheetSkin((Page)(object)this);
		((Control)val).ID = "Label6";
		return val;
	}

	[DebuggerNonUserCode]
	private Label __BuildControlLabel7()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Label val = (Label7 = new Label());
		((Control)val).ApplyStyleSheetSkin((Page)(object)this);
		((Control)val).ID = "Label7";
		return val;
	}

	[DebuggerNonUserCode]
	private Label __BuildControlLabel23()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Label val = (Label23 = new Label());
		((Control)val).ApplyStyleSheetSkin((Page)(object)this);
		((Control)val).ID = "Label23";
		return val;
	}

	[DebuggerNonUserCode]
	private Label __BuildControlLabel9()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Label val = (Label9 = new Label());
		((Control)val).ApplyStyleSheetSkin((Page)(object)this);
		((Control)val).ID = "Label9";
		return val;
	}

	[DebuggerNonUserCode]
	private Label __BuildControlLabel10()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Label val = (Label10 = new Label());
		((Control)val).ApplyStyleSheetSkin((Page)(object)this);
		((Control)val).ID = "Label10";
		return val;
	}

	[DebuggerNonUserCode]
	private Label __BuildControlLabel11()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Label val = (Label11 = new Label());
		((Control)val).ApplyStyleSheetSkin((Page)(object)this);
		((Control)val).ID = "Label11";
		return val;
	}

	[DebuggerNonUserCode]
	private Label __BuildControlLabel12()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Label val = (Label12 = new Label());
		((Control)val).ApplyStyleSheetSkin((Page)(object)this);
		((Control)val).ID = "Label12";
		return val;
	}

	[DebuggerNonUserCode]
	private Label __BuildControlLabel24()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Label val = (Label24 = new Label());
		((Control)val).ApplyStyleSheetSkin((Page)(object)this);
		((Control)val).ID = "Label24";
		return val;
	}

	[DebuggerNonUserCode]
	private HtmlGenericControl __BuildControlcontentdiv1()
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected Obj, but got Unknown
		//IL_0051: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Expected Obj, but got Unknown
		//IL_0073: Unknown result type (might be due to invalid IL or missing references)
		//IL_007d: Expected Obj, but got Unknown
		//IL_0095: Unknown result type (might be due to invalid IL or missing references)
		//IL_009f: Expected Obj, but got Unknown
		//IL_00b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c1: Expected Obj, but got Unknown
		//IL_00d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e3: Expected Obj, but got Unknown
		//IL_014d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0157: Expected Obj, but got Unknown
		//IL_023a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0244: Expected Obj, but got Unknown
		HtmlGenericControl val = (contentdiv1 = new HtmlGenericControl("div"));
		((Control)val).TemplateControl = (TemplateControl)(object)this;
		((Control)val).ID = "contentdiv1";
		IParserAccessor val3 = (IParserAccessor)(object)val;
		val3.AddParsedSubObject((object)((TemplateControl)this).CreateResourceBasedLiteralControl(0, 414, true));
		Label val4 = __BuildControlLabel2();
		val3.AddParsedSubObject((object)val4);
		val3.AddParsedSubObject((object)new LiteralControl("\r\n                "));
		Label val5 = __BuildControlLabel30();
		val3.AddParsedSubObject((object)val5);
		val3.AddParsedSubObject((object)new LiteralControl("</td>\r\n            <td style=\"height: 20px\" width=\"25%\">\r\n            </td>\r\n            <td style=\"width: 100px; height: 20px\">\r\n                Email :</td>\r\n            <td style=\"width: 100px; height: 20px\">\r\n                "));
		Label val6 = __BuildControlLabel19();
		val3.AddParsedSubObject((object)val6);
		val3.AddParsedSubObject((object)new LiteralControl("</td>\r\n        </tr>\r\n        <tr>\r\n            <td>\r\n                Item Number :</td>\r\n            <td style=\"width: 100px\">\r\n                "));
		Label val7 = __BuildControlLabel3();
		val3.AddParsedSubObject((object)val7);
		val3.AddParsedSubObject((object)new LiteralControl("</td>\r\n            <td width=\"25%\">\r\n            </td>\r\n            <td style=\"width: 100px\">\r\n                Country :</td>\r\n            <td style=\"width: 100px\">\r\n                "));
		Label val8 = __BuildControlLabel31();
		val3.AddParsedSubObject((object)val8);
		val3.AddParsedSubObject((object)new LiteralControl("</td>\r\n        </tr>\r\n        <tr>\r\n            <td style=\"height: 19px\">\r\n                Tax :</td>\r\n            <td style=\"width: 100px; height: 19px;\">\r\n                "));
		Label val9 = __BuildControlLabel5();
		val3.AddParsedSubObject((object)val9);
		val3.AddParsedSubObject((object)((TemplateControl)this).CreateResourceBasedLiteralControl(414, 367, true));
		Label val10 = __BuildControlLabel6();
		val3.AddParsedSubObject((object)val10);
		val3.AddParsedSubObject((object)((TemplateControl)this).CreateResourceBasedLiteralControl(781, 317, true));
		Label val11 = __BuildControlLabel7();
		val3.AddParsedSubObject((object)val11);
		val3.AddParsedSubObject((object)new LiteralControl("</td>\r\n            <td width=\"25%\">\r\n            </td>\r\n            <td style=\"width: 100px\">\r\n                Payment Type :</td>\r\n            <td style=\"width: 100px\">\r\n                "));
		Label val12 = __BuildControlLabel23();
		val3.AddParsedSubObject((object)val12);
		val3.AddParsedSubObject((object)((TemplateControl)this).CreateResourceBasedLiteralControl(1098, 440, true));
		Label val13 = __BuildControlLabel9();
		val3.AddParsedSubObject((object)val13);
		val3.AddParsedSubObject((object)((TemplateControl)this).CreateResourceBasedLiteralControl(1538, 317, true));
		Label val14 = __BuildControlLabel10();
		val3.AddParsedSubObject((object)val14);
		val3.AddParsedSubObject((object)((TemplateControl)this).CreateResourceBasedLiteralControl(1855, 363, true));
		Label val15 = __BuildControlLabel11();
		val3.AddParsedSubObject((object)val15);
		val3.AddParsedSubObject((object)((TemplateControl)this).CreateResourceBasedLiteralControl(2218, 399, true));
		Label val16 = __BuildControlLabel12();
		val3.AddParsedSubObject((object)val16);
		val3.AddParsedSubObject((object)((TemplateControl)this).CreateResourceBasedLiteralControl(2617, 361, true));
		Label val17 = __BuildControlLabel24();
		val3.AddParsedSubObject((object)val17);
		val3.AddParsedSubObject((object)new LiteralControl("</td>\r\n            <td width=\"25%\">\r\n            </td>\r\n            <td style=\"width: 100px\">\r\n            </td>\r\n            <td style=\"width: 100px\">\r\n                </td>\r\n        </tr>\r\n    </table>"));
		return val;
	}

	[DebuggerNonUserCode]
	private void __BuildControlContent1(Control __ctrl)
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Expected Obj, but got Unknown
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Expected Obj, but got Unknown
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_004e: Expected Obj, but got Unknown
		((IParserAccessor)__ctrl).AddParsedSubObject((object)new LiteralControl("\r\n    "));
		SqlDataSource val = __BuildControlSqlDataSource1();
		((IParserAccessor)__ctrl).AddParsedSubObject((object)val);
		((IParserAccessor)__ctrl).AddParsedSubObject((object)new LiteralControl("\r\n   "));
		HtmlGenericControl val2 = __BuildControlcontentdiv1();
		((IParserAccessor)__ctrl).AddParsedSubObject((object)val2);
		((IParserAccessor)__ctrl).AddParsedSubObject((object)new LiteralControl("\r\n"));
	}

	[DebuggerNonUserCode]
	private void __BuildControlTree(buy_aspx __ctrl)
	{
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Expected Obj, but got Unknown
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Expected Obj, but got Unknown
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Expected Obj, but got Unknown
		((Page)__ctrl).MasterPageFile = "~/master1.master";
		((Page)__ctrl).Title = "Buyer's Reciept";
		((Page)this).InitializeCulture();
		((Page)this).AddContentTemplate("ContentPlaceHolder1", (ITemplate)new CompiledTemplateBuilder((BuildTemplateMethod)__BuildControlContent1));
		((IParserAccessor)__ctrl).AddParsedSubObject((object)new LiteralControl("\r\n\r\n"));
	}

	[DebuggerNonUserCode]
	protected override void FrameworkInitialize()
	{
		((Page)this).FrameworkInitialize();
		((TemplateControl)this).SetStringResourcePointer(RuntimeHelpers.GetObjectValue(__stringResource), 0);
		__BuildControlTree(this);
		((Page)this).AddWrappedFileDependencies(RuntimeHelpers.GetObjectValue(__fileDependencies));
		((Page)this).Request.ValidateInput();
	}

	[DebuggerNonUserCode]
	public override int GetTypeHashCode()
	{
		return 821390073;
	}

	[DebuggerNonUserCode]
	public override void ProcessRequest(HttpContext context)
	{
		((Page)this).ProcessRequest(context);
	}
}
