using System;
using System.Diagnostics;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Web;
using System.Web.Compilation;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ASP;

[CompilerGlobalScope]
public class admin_deposits_aspx : Admin_deposits
{
	private static bool __initialized;

	private static object __fileDependencies;

	protected override bool SupportAutoEvents => false;

	[DebuggerNonUserCode]
	public admin_deposits_aspx()
	{
		((TemplateControl)this).AppRelativeVirtualPath = "~/Admin/deposits.aspx";
		if (!__initialized)
		{
			__fileDependencies = RuntimeHelpers.GetObjectValue(((Page)this).GetWrappedFileDependencies(new string[4] { "~/Admin/deposits.aspx", "~/master1.master", "~/master1.master.vb", "~/Admin/deposits.aspx.vb" }));
			__initialized = true;
		}
		((Page)this).Server.ScriptTimeout = 30000000;
	}

	[DebuggerNonUserCode]
	private void __BuildControlContent1(Control __ctrl)
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Expected Obj, but got Unknown
		((IParserAccessor)__ctrl).AddParsedSubObject((object)new LiteralControl("\r\n"));
	}

	[DebuggerNonUserCode]
	private BoundField __BuildControl__control3()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		BoundField val = new BoundField();
		val.DataField = "neme";
		val.HeaderText = "neme";
		((DataControlField)val).SortExpression = "neme";
		return val;
	}

	[DebuggerNonUserCode]
	private BoundField __BuildControl__control4()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		BoundField val = new BoundField();
		val.DataField = "uname";
		val.HeaderText = "uname";
		((DataControlField)val).SortExpression = "uname";
		return val;
	}

	[DebuggerNonUserCode]
	private BoundField __BuildControl__control5()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		BoundField val = new BoundField();
		val.DataField = "phone";
		val.HeaderText = "phone";
		((DataControlField)val).SortExpression = "phone";
		return val;
	}

	[DebuggerNonUserCode]
	private BoundField __BuildControl__control6()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		BoundField val = new BoundField();
		val.DataField = "email";
		val.HeaderText = "email";
		((DataControlField)val).SortExpression = "email";
		return val;
	}

	[DebuggerNonUserCode]
	private BoundField __BuildControl__control7()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		BoundField val = new BoundField();
		val.DataField = "amount";
		val.HeaderText = "amount";
		((DataControlField)val).SortExpression = "amount";
		return val;
	}

	[DebuggerNonUserCode]
	private BoundField __BuildControl__control8()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		BoundField val = new BoundField();
		val.DataField = "confirm";
		val.HeaderText = "confirm";
		((DataControlField)val).SortExpression = "confirm";
		return val;
	}

	[DebuggerNonUserCode]
	private BoundField __BuildControl__control9()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		BoundField val = new BoundField();
		val.DataField = "date";
		val.HeaderText = "date";
		((DataControlField)val).SortExpression = "date";
		return val;
	}

	[DebuggerNonUserCode]
	private BoundField __BuildControl__control10()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		BoundField val = new BoundField();
		val.DataField = "purpose";
		val.HeaderText = "purpose";
		((DataControlField)val).SortExpression = "purpose";
		return val;
	}

	[DebuggerNonUserCode]
	private BoundField __BuildControl__control11()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		BoundField val = new BoundField();
		val.DataField = "tid";
		val.HeaderText = "tid";
		val.ReadOnly = true;
		((DataControlField)val).SortExpression = "tid";
		return val;
	}

	[DebuggerNonUserCode]
	private void __BuildControl__control2(DataControlFieldCollection __ctrl)
	{
		BoundField val = __BuildControl__control3();
		__ctrl.Add((DataControlField)(object)val);
		BoundField val2 = __BuildControl__control4();
		__ctrl.Add((DataControlField)(object)val2);
		BoundField val3 = __BuildControl__control5();
		__ctrl.Add((DataControlField)(object)val3);
		BoundField val4 = __BuildControl__control6();
		__ctrl.Add((DataControlField)(object)val4);
		BoundField val5 = __BuildControl__control7();
		__ctrl.Add((DataControlField)(object)val5);
		BoundField val6 = __BuildControl__control8();
		__ctrl.Add((DataControlField)(object)val6);
		BoundField val7 = __BuildControl__control9();
		__ctrl.Add((DataControlField)(object)val7);
		BoundField val8 = __BuildControl__control10();
		__ctrl.Add((DataControlField)(object)val8);
		BoundField val9 = __BuildControl__control11();
		__ctrl.Add((DataControlField)(object)val9);
	}

	[DebuggerNonUserCode]
	private GridView __BuildControlGridView1()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		GridView val = (GridView1 = new GridView());
		((Control)val).TemplateControl = (TemplateControl)(object)this;
		((Control)val).ApplyStyleSheetSkin((Page)(object)this);
		((Control)val).ID = "GridView1";
		val.AllowSorting = true;
		val.AutoGenerateColumns = false;
		val.DataKeyNames = new string[1] { "tid" };
		((DataBoundControl)val).DataSourceID = "SqlDataSource1";
		val.EmptyDataText = "There are no data records to display.";
		__BuildControl__control2(val.Columns);
		return val;
	}

	[DebuggerNonUserCode]
	private Parameter __BuildControl__control13()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Parameter val = new Parameter();
		val.Name = "tid";
		val.Type = TypeCode.Int32;
		return val;
	}

	[DebuggerNonUserCode]
	private void __BuildControl__control12(ParameterCollection __ctrl)
	{
		Parameter val = __BuildControl__control13();
		__ctrl.Add(val);
	}

	[DebuggerNonUserCode]
	private Parameter __BuildControl__control15()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Parameter val = new Parameter();
		val.Name = "neme";
		val.Type = TypeCode.String;
		return val;
	}

	[DebuggerNonUserCode]
	private Parameter __BuildControl__control16()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Parameter val = new Parameter();
		val.Name = "uname";
		val.Type = TypeCode.String;
		return val;
	}

	[DebuggerNonUserCode]
	private Parameter __BuildControl__control17()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Parameter val = new Parameter();
		val.Name = "phone";
		val.Type = TypeCode.String;
		return val;
	}

	[DebuggerNonUserCode]
	private Parameter __BuildControl__control18()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Parameter val = new Parameter();
		val.Name = "email";
		val.Type = TypeCode.String;
		return val;
	}

	[DebuggerNonUserCode]
	private Parameter __BuildControl__control19()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Parameter val = new Parameter();
		val.Name = "amount";
		val.Type = TypeCode.String;
		return val;
	}

	[DebuggerNonUserCode]
	private Parameter __BuildControl__control20()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Parameter val = new Parameter();
		val.Name = "confirm";
		val.Type = TypeCode.String;
		return val;
	}

	[DebuggerNonUserCode]
	private Parameter __BuildControl__control21()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Parameter val = new Parameter();
		val.Name = "date";
		val.Type = TypeCode.String;
		return val;
	}

	[DebuggerNonUserCode]
	private Parameter __BuildControl__control22()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Parameter val = new Parameter();
		val.Name = "purpose";
		val.Type = TypeCode.String;
		return val;
	}

	[DebuggerNonUserCode]
	private void __BuildControl__control14(ParameterCollection __ctrl)
	{
		Parameter val = __BuildControl__control15();
		__ctrl.Add(val);
		Parameter val2 = __BuildControl__control16();
		__ctrl.Add(val2);
		Parameter val3 = __BuildControl__control17();
		__ctrl.Add(val3);
		Parameter val4 = __BuildControl__control18();
		__ctrl.Add(val4);
		Parameter val5 = __BuildControl__control19();
		__ctrl.Add(val5);
		Parameter val6 = __BuildControl__control20();
		__ctrl.Add(val6);
		Parameter val7 = __BuildControl__control21();
		__ctrl.Add(val7);
		Parameter val8 = __BuildControl__control22();
		__ctrl.Add(val8);
	}

	[DebuggerNonUserCode]
	private Parameter __BuildControl__control24()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Parameter val = new Parameter();
		val.Name = "neme";
		val.Type = TypeCode.String;
		return val;
	}

	[DebuggerNonUserCode]
	private Parameter __BuildControl__control25()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Parameter val = new Parameter();
		val.Name = "uname";
		val.Type = TypeCode.String;
		return val;
	}

	[DebuggerNonUserCode]
	private Parameter __BuildControl__control26()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Parameter val = new Parameter();
		val.Name = "phone";
		val.Type = TypeCode.String;
		return val;
	}

	[DebuggerNonUserCode]
	private Parameter __BuildControl__control27()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Parameter val = new Parameter();
		val.Name = "email";
		val.Type = TypeCode.String;
		return val;
	}

	[DebuggerNonUserCode]
	private Parameter __BuildControl__control28()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Parameter val = new Parameter();
		val.Name = "amount";
		val.Type = TypeCode.String;
		return val;
	}

	[DebuggerNonUserCode]
	private Parameter __BuildControl__control29()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Parameter val = new Parameter();
		val.Name = "confirm";
		val.Type = TypeCode.String;
		return val;
	}

	[DebuggerNonUserCode]
	private Parameter __BuildControl__control30()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Parameter val = new Parameter();
		val.Name = "date";
		val.Type = TypeCode.String;
		return val;
	}

	[DebuggerNonUserCode]
	private Parameter __BuildControl__control31()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Parameter val = new Parameter();
		val.Name = "purpose";
		val.Type = TypeCode.String;
		return val;
	}

	[DebuggerNonUserCode]
	private Parameter __BuildControl__control32()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Parameter val = new Parameter();
		val.Name = "tid";
		val.Type = TypeCode.Int32;
		return val;
	}

	[DebuggerNonUserCode]
	private void __BuildControl__control23(ParameterCollection __ctrl)
	{
		Parameter val = __BuildControl__control24();
		__ctrl.Add(val);
		Parameter val2 = __BuildControl__control25();
		__ctrl.Add(val2);
		Parameter val3 = __BuildControl__control26();
		__ctrl.Add(val3);
		Parameter val4 = __BuildControl__control27();
		__ctrl.Add(val4);
		Parameter val5 = __BuildControl__control28();
		__ctrl.Add(val5);
		Parameter val6 = __BuildControl__control29();
		__ctrl.Add(val6);
		Parameter val7 = __BuildControl__control30();
		__ctrl.Add(val7);
		Parameter val8 = __BuildControl__control31();
		__ctrl.Add(val8);
		Parameter val9 = __BuildControl__control32();
		__ctrl.Add(val9);
	}

	[DebuggerNonUserCode]
	private SqlDataSource __BuildControlSqlDataSource1()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		SqlDataSource val = (SqlDataSource1 = new SqlDataSource());
		((Control)val).TemplateControl = (TemplateControl)(object)this;
		((Control)val).ID = "SqlDataSource1";
		val.DeleteCommand = "DELETE FROM [deposits] WHERE [tid] = @tid";
		val.InsertCommand = "INSERT INTO [deposits] ([neme], [uname], [phone], [email], [amount], [confirm], [date], [purpose]) VALUES (@neme, @uname, @phone, @email, @amount, @confirm, @date, @purpose)";
		val.SelectCommand = "SELECT [neme], [uname], [phone], [email], [amount], [confirm], [date], [purpose], [tid] FROM [deposits]";
		val.UpdateCommand = "UPDATE [deposits] SET [neme] = @neme, [uname] = @uname, [phone] = @phone, [email] = @email, [amount] = @amount, [confirm] = @confirm, [date] = @date, [purpose] = @purpose WHERE [tid] = @tid";
		__BuildControl__control12(val.DeleteParameters);
		__BuildControl__control14(val.InsertParameters);
		__BuildControl__control23(val.UpdateParameters);
		val.ConnectionString = Convert.ToString(ConnectionStringsExpressionBuilder.GetConnectionString("LocalSqlServer"), CultureInfo.CurrentCulture);
		val.ProviderName = Convert.ToString(ConnectionStringsExpressionBuilder.GetConnectionStringProviderName("LocalSqlServer"), CultureInfo.CurrentCulture);
		return val;
	}

	[DebuggerNonUserCode]
	private void __BuildControlContent2(Control __ctrl)
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Expected Obj, but got Unknown
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Expected Obj, but got Unknown
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_004e: Expected Obj, but got Unknown
		((IParserAccessor)__ctrl).AddParsedSubObject((object)new LiteralControl("\r\n    "));
		GridView val = __BuildControlGridView1();
		((IParserAccessor)__ctrl).AddParsedSubObject((object)val);
		((IParserAccessor)__ctrl).AddParsedSubObject((object)new LiteralControl("\r\n    "));
		SqlDataSource val2 = __BuildControlSqlDataSource1();
		((IParserAccessor)__ctrl).AddParsedSubObject((object)val2);
		((IParserAccessor)__ctrl).AddParsedSubObject((object)new LiteralControl("\r\n"));
	}

	[DebuggerNonUserCode]
	private void __BuildControlTree(admin_deposits_aspx __ctrl)
	{
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Expected Obj, but got Unknown
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Expected Obj, but got Unknown
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_0051: Expected Obj, but got Unknown
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0056: Expected Obj, but got Unknown
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0068: Expected Obj, but got Unknown
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0078: Expected Obj, but got Unknown
		((Page)__ctrl).Title = "";
		((Page)__ctrl).MasterPageFile = "~/master1.master";
		((Page)this).InitializeCulture();
		((Page)this).AddContentTemplate("head", (ITemplate)new CompiledTemplateBuilder((BuildTemplateMethod)__BuildControlContent1));
		((Page)this).AddContentTemplate("ContentPlaceHolder1", (ITemplate)new CompiledTemplateBuilder((BuildTemplateMethod)__BuildControlContent2));
		((IParserAccessor)__ctrl).AddParsedSubObject((object)new LiteralControl("\r\n"));
		((IParserAccessor)__ctrl).AddParsedSubObject((object)new LiteralControl("\r\n\r\n"));
	}

	[DebuggerNonUserCode]
	protected override void FrameworkInitialize()
	{
		((Page)this).FrameworkInitialize();
		__BuildControlTree(this);
		((Page)this).AddWrappedFileDependencies(RuntimeHelpers.GetObjectValue(__fileDependencies));
		((Page)this).Request.ValidateInput();
	}

	[DebuggerNonUserCode]
	public override int GetTypeHashCode()
	{
		return 2110067270;
	}

	[DebuggerNonUserCode]
	public override void ProcessRequest(HttpContext context)
	{
		((Page)this).ProcessRequest(context);
	}
}
