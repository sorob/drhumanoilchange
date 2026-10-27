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
public class admin_refedit_aspx : Admin_RefEdit
{
	private static bool __initialized;

	private static object __stringResource;

	private static object __fileDependencies;

	protected override bool SupportAutoEvents => false;

	[DebuggerNonUserCode]
	public admin_refedit_aspx()
	{
		((TemplateControl)this).AppRelativeVirtualPath = "~/Admin/RefEdit.aspx";
		if (!__initialized)
		{
			__stringResource = RuntimeHelpers.GetObjectValue(((TemplateControl)this).ReadStringResource());
			__fileDependencies = RuntimeHelpers.GetObjectValue(((Page)this).GetWrappedFileDependencies(new string[4] { "~/Admin/RefEdit.aspx", "~/master1.master", "~/master1.master.vb", "~/Admin/RefEdit.aspx.vb" }));
			__initialized = true;
		}
		((Page)this).Server.ScriptTimeout = 30000000;
	}

	[DebuggerNonUserCode]
	private void __BuildControlContent1(Control __ctrl)
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Expected Obj, but got Unknown
		((IParserAccessor)__ctrl).AddParsedSubObject((object)new LiteralControl("\r\n    <style type=\"text/css\">\r\n        .style1\r\n        {\r\n            width: 100%;\r\n        }\r\n    </style>\r\n"));
	}

	[DebuggerNonUserCode]
	private ControlParameter __BuildControl__control3()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		ControlParameter val = new ControlParameter();
		val.ControlID = "tname";
		((Parameter)val).Name = "testName";
		val.PropertyName = "Text";
		((Parameter)val).Type = TypeCode.String;
		return val;
	}

	[DebuggerNonUserCode]
	private ControlParameter __BuildControl__control4()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		ControlParameter val = new ControlParameter();
		val.ControlID = "Tabrev";
		((Parameter)val).Name = "testAbrev";
		val.PropertyName = "Text";
		((Parameter)val).Type = TypeCode.String;
		return val;
	}

	[DebuggerNonUserCode]
	private ControlParameter __BuildControl__control5()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		ControlParameter val = new ControlParameter();
		val.ControlID = "Dlow";
		((Parameter)val).Name = "DocLow";
		val.PropertyName = "Text";
		((Parameter)val).Type = TypeCode.Double;
		return val;
	}

	[DebuggerNonUserCode]
	private ControlParameter __BuildControl__control6()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		ControlParameter val = new ControlParameter();
		val.ControlID = "Dhigh";
		((Parameter)val).Name = "DocHigh";
		val.PropertyName = "Text";
		((Parameter)val).Type = TypeCode.Double;
		return val;
	}

	[DebuggerNonUserCode]
	private ControlParameter __BuildControl__control7()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		ControlParameter val = new ControlParameter();
		val.ControlID = "medlow";
		((Parameter)val).Name = "MedLow";
		val.PropertyName = "Text";
		((Parameter)val).Type = TypeCode.Double;
		return val;
	}

	[DebuggerNonUserCode]
	private ControlParameter __BuildControl__control8()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		ControlParameter val = new ControlParameter();
		val.ControlID = "medHigh";
		((Parameter)val).Name = "MedHigh";
		val.PropertyName = "Text";
		((Parameter)val).Type = TypeCode.Double;
		return val;
	}

	[DebuggerNonUserCode]
	private Parameter __BuildControl__control9()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Parameter val = new Parameter();
		val.Name = "Sex";
		val.Type = TypeCode.String;
		val.DefaultValue = "Male";
		return val;
	}

	[DebuggerNonUserCode]
	private ControlParameter __BuildControl__control10()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		ControlParameter val = new ControlParameter();
		val.ControlID = "Categor";
		((Parameter)val).DefaultValue = "";
		((Parameter)val).Name = "Category";
		val.PropertyName = "Text";
		((Parameter)val).Type = TypeCode.String;
		return val;
	}

	[DebuggerNonUserCode]
	private ControlParameter __BuildControl__control11()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		ControlParameter val = new ControlParameter();
		val.ControlID = "Tdefval";
		((Parameter)val).Name = "Defaultval";
		val.PropertyName = "Text";
		return val;
	}

	[DebuggerNonUserCode]
	private void __BuildControl__control2(ParameterCollection __ctrl)
	{
		ControlParameter val = __BuildControl__control3();
		__ctrl.Add((Parameter)(object)val);
		ControlParameter val2 = __BuildControl__control4();
		__ctrl.Add((Parameter)(object)val2);
		ControlParameter val3 = __BuildControl__control5();
		__ctrl.Add((Parameter)(object)val3);
		ControlParameter val4 = __BuildControl__control6();
		__ctrl.Add((Parameter)(object)val4);
		ControlParameter val5 = __BuildControl__control7();
		__ctrl.Add((Parameter)(object)val5);
		ControlParameter val6 = __BuildControl__control8();
		__ctrl.Add((Parameter)(object)val6);
		Parameter val7 = __BuildControl__control9();
		__ctrl.Add(val7);
		ControlParameter val8 = __BuildControl__control10();
		__ctrl.Add((Parameter)(object)val8);
		ControlParameter val9 = __BuildControl__control11();
		__ctrl.Add((Parameter)(object)val9);
	}

	[DebuggerNonUserCode]
	private Parameter __BuildControl__control13()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Parameter val = new Parameter();
		val.Name = "testAbrev";
		val.Type = TypeCode.String;
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
		val.Name = "testName";
		val.Type = TypeCode.String;
		return val;
	}

	[DebuggerNonUserCode]
	private Parameter __BuildControl__control16()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Parameter val = new Parameter();
		val.Name = "DocLow";
		val.Type = TypeCode.Double;
		return val;
	}

	[DebuggerNonUserCode]
	private Parameter __BuildControl__control17()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Parameter val = new Parameter();
		val.Name = "DocHigh";
		val.Type = TypeCode.Double;
		return val;
	}

	[DebuggerNonUserCode]
	private Parameter __BuildControl__control18()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Parameter val = new Parameter();
		val.Name = "MedLow";
		val.Type = TypeCode.Double;
		return val;
	}

	[DebuggerNonUserCode]
	private Parameter __BuildControl__control19()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Parameter val = new Parameter();
		val.Name = "MedHigh";
		val.Type = TypeCode.Double;
		return val;
	}

	[DebuggerNonUserCode]
	private Parameter __BuildControl__control20()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Parameter val = new Parameter();
		val.Name = "Sex";
		val.Type = TypeCode.String;
		return val;
	}

	[DebuggerNonUserCode]
	private Parameter __BuildControl__control21()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Parameter val = new Parameter();
		val.Name = "Category";
		val.Type = TypeCode.String;
		return val;
	}

	[DebuggerNonUserCode]
	private Parameter __BuildControl__control22()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Parameter val = new Parameter();
		val.Name = "Defaultval";
		return val;
	}

	[DebuggerNonUserCode]
	private Parameter __BuildControl__control23()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Parameter val = new Parameter();
		val.Name = "testAbrev";
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
		Parameter val9 = __BuildControl__control23();
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
		val.DeleteCommand = "DELETE FROM [TestRef] WHERE [testAbrev] = @testAbrev";
		val.InsertCommand = "INSERT INTO [TestRef] ([testName], [testAbrev], [DocLow], [DocHigh], [MedLow], [MedHigh], [Sex], [Category], [Defaultval]) VALUES (@testName, @testAbrev, @DocLow, @DocHigh, @MedLow, @MedHigh, @Sex, @Category, @Defaultval)";
		val.SelectCommand = "SELECT testName, testAbrev, DocLow, DocHigh, MedLow, MedHigh, Sex, rid, Category, Defaultval FROM TestRef";
		val.UpdateCommand = "UPDATE TestRef SET testName = @testName, DocLow = @DocLow, DocHigh = @DocHigh, MedLow = @MedLow, MedHigh = @MedHigh, Sex = @Sex, Category = @Category, Defaultval = @Defaultval WHERE (testAbrev = @testAbrev)";
		__BuildControl__control2(val.InsertParameters);
		__BuildControl__control12(val.DeleteParameters);
		__BuildControl__control14(val.UpdateParameters);
		val.ConnectionString = Convert.ToString(ConnectionStringsExpressionBuilder.GetConnectionString("ConnectionString"), CultureInfo.CurrentCulture);
		val.ProviderName = Convert.ToString(ConnectionStringsExpressionBuilder.GetConnectionStringProviderName("ConnectionString"), CultureInfo.CurrentCulture);
		return val;
	}

	[DebuggerNonUserCode]
	private Button __BuildControlButton1()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		Button val = (Button1 = new Button());
		((Control)val).ApplyStyleSheetSkin((Page)(object)this);
		((Control)val).ID = "Button1";
		val.Text = "Add Test";
		Unit width = new Unit(125.0, (UnitType)1);
		((WebControl)val).Width = width;
		return val;
	}

	[DebuggerNonUserCode]
	private CommandField __BuildControl__control25()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		CommandField val = new CommandField();
		val.ShowDeleteButton = true;
		val.ShowEditButton = true;
		return val;
	}

	[DebuggerNonUserCode]
	private BoundField __BuildControl__control26()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		BoundField val = new BoundField();
		val.DataField = "testName";
		val.HeaderText = "testName";
		((DataControlField)val).SortExpression = "testName";
		return val;
	}

	[DebuggerNonUserCode]
	private BoundField __BuildControl__control27()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		BoundField val = new BoundField();
		val.DataField = "testAbrev";
		val.HeaderText = "testAbrev";
		val.ReadOnly = true;
		((DataControlField)val).SortExpression = "testAbrev";
		return val;
	}

	[DebuggerNonUserCode]
	private BoundField __BuildControl__control28()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		BoundField val = new BoundField();
		val.DataField = "DocLow";
		val.HeaderText = "DocLow";
		((DataControlField)val).SortExpression = "DocLow";
		return val;
	}

	[DebuggerNonUserCode]
	private BoundField __BuildControl__control29()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		BoundField val = new BoundField();
		val.DataField = "DocHigh";
		val.HeaderText = "DocHigh";
		((DataControlField)val).SortExpression = "DocHigh";
		return val;
	}

	[DebuggerNonUserCode]
	private BoundField __BuildControl__control30()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		BoundField val = new BoundField();
		val.DataField = "MedLow";
		val.HeaderText = "MedLow";
		((DataControlField)val).SortExpression = "MedLow";
		return val;
	}

	[DebuggerNonUserCode]
	private BoundField __BuildControl__control31()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		BoundField val = new BoundField();
		val.DataField = "MedHigh";
		val.HeaderText = "MedHigh";
		((DataControlField)val).SortExpression = "MedHigh";
		return val;
	}

	[DebuggerNonUserCode]
	private BoundField __BuildControl__control32()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		BoundField val = new BoundField();
		val.DataField = "Sex";
		val.HeaderText = "Sex";
		((DataControlField)val).SortExpression = "Sex";
		return val;
	}

	[DebuggerNonUserCode]
	private BoundField __BuildControl__control33()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		BoundField val = new BoundField();
		val.DataField = "rid";
		val.HeaderText = "rid";
		((DataControlField)val).InsertVisible = false;
		val.ReadOnly = true;
		((DataControlField)val).SortExpression = "rid";
		return val;
	}

	[DebuggerNonUserCode]
	private BoundField __BuildControl__control34()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		BoundField val = new BoundField();
		val.DataField = "Category";
		val.HeaderText = "Category";
		((DataControlField)val).SortExpression = "Category";
		return val;
	}

	[DebuggerNonUserCode]
	private BoundField __BuildControl__control35()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		BoundField val = new BoundField();
		val.DataField = "Defaultval";
		val.HeaderText = "Defaultval";
		((DataControlField)val).SortExpression = "Defaultval";
		return val;
	}

	[DebuggerNonUserCode]
	private void __BuildControl__control24(DataControlFieldCollection __ctrl)
	{
		CommandField val = __BuildControl__control25();
		__ctrl.Add((DataControlField)(object)val);
		BoundField val2 = __BuildControl__control26();
		__ctrl.Add((DataControlField)(object)val2);
		BoundField val3 = __BuildControl__control27();
		__ctrl.Add((DataControlField)(object)val3);
		BoundField val4 = __BuildControl__control28();
		__ctrl.Add((DataControlField)(object)val4);
		BoundField val5 = __BuildControl__control29();
		__ctrl.Add((DataControlField)(object)val5);
		BoundField val6 = __BuildControl__control30();
		__ctrl.Add((DataControlField)(object)val6);
		BoundField val7 = __BuildControl__control31();
		__ctrl.Add((DataControlField)(object)val7);
		BoundField val8 = __BuildControl__control32();
		__ctrl.Add((DataControlField)(object)val8);
		BoundField val9 = __BuildControl__control33();
		__ctrl.Add((DataControlField)(object)val9);
		BoundField val10 = __BuildControl__control34();
		__ctrl.Add((DataControlField)(object)val10);
		BoundField val11 = __BuildControl__control35();
		__ctrl.Add((DataControlField)(object)val11);
	}

	[DebuggerNonUserCode]
	private GridView __BuildControlGridView2()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		GridView val = (GridView2 = new GridView());
		((Control)val).ApplyStyleSheetSkin((Page)(object)this);
		((Control)val).ID = "GridView2";
		val.AllowSorting = true;
		val.AutoGenerateColumns = false;
		val.DataKeyNames = new string[1] { "testAbrev" };
		((DataBoundControl)val).DataSourceID = "SqlDataSource1";
		__BuildControl__control24(val.Columns);
		return val;
	}

	[DebuggerNonUserCode]
	private void __BuildControl__control36(Control __ctrl)
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Expected Obj, but got Unknown
		((IParserAccessor)__ctrl).AddParsedSubObject((object)new LiteralControl("\r\n                    <br />\r\n                "));
	}

	[DebuggerNonUserCode]
	private UpdatePanel __BuildControlUpdatePanel2()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Expected Obj, but got Unknown
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Expected Obj, but got Unknown
		UpdatePanel val = (UpdatePanel2 = new UpdatePanel());
		val.ContentTemplate = (ITemplate)new CompiledTemplateBuilder((BuildTemplateMethod)__BuildControl__control36);
		((Control)val).ID = "UpdatePanel2";
		return val;
	}

	[DebuggerNonUserCode]
	private View __BuildControlView1()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Expected Obj, but got Unknown
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Expected Obj, but got Unknown
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		//IL_006c: Expected Obj, but got Unknown
		//IL_0084: Unknown result type (might be due to invalid IL or missing references)
		//IL_008e: Expected Obj, but got Unknown
		View val = (View1 = new View());
		((Control)val).ID = "View1";
		IParserAccessor val3 = (IParserAccessor)(object)val;
		val3.AddParsedSubObject((object)new LiteralControl("\r\n            \r\n            "));
		Button val4 = __BuildControlButton1();
		val3.AddParsedSubObject((object)val4);
		val3.AddParsedSubObject((object)new LiteralControl("\r\n      \r\n               \r\n            "));
		GridView val5 = __BuildControlGridView2();
		val3.AddParsedSubObject((object)val5);
		val3.AddParsedSubObject((object)new LiteralControl("\r\n                 \r\n         \r\n            "));
		UpdatePanel val6 = __BuildControlUpdatePanel2();
		val3.AddParsedSubObject((object)val6);
		val3.AddParsedSubObject((object)new LiteralControl("\r\n        "));
		return val;
	}

	[DebuggerNonUserCode]
	private TextBox __BuildControltname()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		TextBox val = (tname = new TextBox());
		((Control)val).ApplyStyleSheetSkin((Page)(object)this);
		((Control)val).ID = "tname";
		return val;
	}

	[DebuggerNonUserCode]
	private TextBox __BuildControlTabrev()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		TextBox val = (Tabrev = new TextBox());
		((Control)val).ApplyStyleSheetSkin((Page)(object)this);
		((Control)val).ID = "Tabrev";
		return val;
	}

	[DebuggerNonUserCode]
	private TextBox __BuildControlDlow()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		TextBox val = (Dlow = new TextBox());
		((Control)val).ApplyStyleSheetSkin((Page)(object)this);
		((Control)val).ID = "Dlow";
		return val;
	}

	[DebuggerNonUserCode]
	private TextBox __BuildControlDhigh()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		TextBox val = (Dhigh = new TextBox());
		((Control)val).ApplyStyleSheetSkin((Page)(object)this);
		((Control)val).ID = "Dhigh";
		return val;
	}

	[DebuggerNonUserCode]
	private TextBox __BuildControlmedlow()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		TextBox val = (medlow = new TextBox());
		((Control)val).ApplyStyleSheetSkin((Page)(object)this);
		((Control)val).ID = "medlow";
		return val;
	}

	[DebuggerNonUserCode]
	private TextBox __BuildControlmedHigh()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		TextBox val = (medHigh = new TextBox());
		((Control)val).ApplyStyleSheetSkin((Page)(object)this);
		((Control)val).ID = "medHigh";
		return val;
	}

	[DebuggerNonUserCode]
	private TextBox __BuildControlCategor()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		TextBox val = (Categor = new TextBox());
		((Control)val).ApplyStyleSheetSkin((Page)(object)this);
		((Control)val).ID = "Categor";
		return val;
	}

	[DebuggerNonUserCode]
	private TextBox __BuildControlTdefval()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		TextBox val = (Tdefval = new TextBox());
		((Control)val).ApplyStyleSheetSkin((Page)(object)this);
		((Control)val).ID = "Tdefval";
		return val;
	}

	[DebuggerNonUserCode]
	private Button __BuildControlButton2()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		Button val = (Button2 = new Button());
		((Control)val).ApplyStyleSheetSkin((Page)(object)this);
		((Control)val).ID = "Button2";
		val.Text = "Submit";
		Unit width = new Unit(160.0, (UnitType)1);
		((WebControl)val).Width = width;
		return val;
	}

	[DebuggerNonUserCode]
	private Button __BuildControlButton3()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Button val = (Button3 = new Button());
		((Control)val).ApplyStyleSheetSkin((Page)(object)this);
		((Control)val).ID = "Button3";
		val.Text = "Cancel";
		return val;
	}

	[DebuggerNonUserCode]
	private View __BuildControlView2()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Expected Obj, but got Unknown
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Expected Obj, but got Unknown
		//IL_0104: Unknown result type (might be due to invalid IL or missing references)
		//IL_010e: Expected Obj, but got Unknown
		//IL_014f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0159: Expected Obj, but got Unknown
		//IL_0171: Unknown result type (might be due to invalid IL or missing references)
		//IL_017b: Expected Obj, but got Unknown
		View val = (View2 = new View());
		((Control)val).ID = "View2";
		IParserAccessor val3 = (IParserAccessor)(object)val;
		val3.AddParsedSubObject((object)new LiteralControl("\r\n            <table class=\"style1\">\r\n                <tr>\r\n                    <td>\r\n                        Test name:</td>\r\n                    <td>\r\n                        "));
		TextBox val4 = __BuildControltname();
		val3.AddParsedSubObject((object)val4);
		val3.AddParsedSubObject((object)new LiteralControl("\r\n                    </td>\r\n                    <td>\r\n                        &nbsp;</td>\r\n                </tr>\r\n                <tr>\r\n                    <td>\r\n                        Test Abrev:</td>\r\n                    <td>\r\n                        "));
		TextBox val5 = __BuildControlTabrev();
		val3.AddParsedSubObject((object)val5);
		val3.AddParsedSubObject((object)((TemplateControl)this).CreateResourceBasedLiteralControl(0, 261, true));
		TextBox val6 = __BuildControlDlow();
		val3.AddParsedSubObject((object)val6);
		val3.AddParsedSubObject((object)((TemplateControl)this).CreateResourceBasedLiteralControl(261, 262, true));
		TextBox val7 = __BuildControlDhigh();
		val3.AddParsedSubObject((object)val7);
		val3.AddParsedSubObject((object)((TemplateControl)this).CreateResourceBasedLiteralControl(523, 256, true));
		TextBox val8 = __BuildControlmedlow();
		val3.AddParsedSubObject((object)val8);
		val3.AddParsedSubObject((object)((TemplateControl)this).CreateResourceBasedLiteralControl(779, 257, true));
		TextBox val9 = __BuildControlmedHigh();
		val3.AddParsedSubObject((object)val9);
		val3.AddParsedSubObject((object)new LiteralControl("\r\n                    </td>\r\n                    <td>\r\n                        &nbsp;</td>\r\n                </tr>\r\n                <tr>\r\n                    <td>\r\n                        Category:</td>\r\n                    <td>\r\n                        "));
		TextBox val10 = __BuildControlCategor();
		val3.AddParsedSubObject((object)val10);
		val3.AddParsedSubObject((object)((TemplateControl)this).CreateResourceBasedLiteralControl(1036, 258, true));
		TextBox val11 = __BuildControlTdefval();
		val3.AddParsedSubObject((object)val11);
		val3.AddParsedSubObject((object)new LiteralControl("\r\n                    </td>\r\n                    <td>\r\n                        &nbsp;</td>\r\n                </tr>\r\n                <tr>\r\n                    <td>\r\n                        &nbsp;</td>\r\n                    <td>\r\n                        "));
		Button val12 = __BuildControlButton2();
		val3.AddParsedSubObject((object)val12);
		val3.AddParsedSubObject((object)new LiteralControl("\r\n                        "));
		Button val13 = __BuildControlButton3();
		val3.AddParsedSubObject((object)val13);
		val3.AddParsedSubObject((object)((TemplateControl)this).CreateResourceBasedLiteralControl(1294, 617, true));
		return val;
	}

	[DebuggerNonUserCode]
	private MultiView __BuildControlMultiView1()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Expected Obj, but got Unknown
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Expected Obj, but got Unknown
		MultiView val = (MultiView1 = new MultiView());
		((Control)val).TemplateControl = (TemplateControl)(object)this;
		((Control)val).ID = "MultiView1";
		val.ActiveViewIndex = 0;
		IParserAccessor val3 = (IParserAccessor)(object)val;
		val3.AddParsedSubObject((object)new LiteralControl("\r\n        "));
		View val4 = __BuildControlView1();
		val3.AddParsedSubObject((object)val4);
		View val5 = __BuildControlView2();
		val3.AddParsedSubObject((object)val5);
		val3.AddParsedSubObject((object)new LiteralControl("\r\n    "));
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
		SqlDataSource val = __BuildControlSqlDataSource1();
		((IParserAccessor)__ctrl).AddParsedSubObject((object)val);
		((IParserAccessor)__ctrl).AddParsedSubObject((object)new LiteralControl("\r\n   \r\n    "));
		MultiView val2 = __BuildControlMultiView1();
		((IParserAccessor)__ctrl).AddParsedSubObject((object)val2);
		((IParserAccessor)__ctrl).AddParsedSubObject((object)new LiteralControl("\r\n"));
	}

	[DebuggerNonUserCode]
	private void __BuildControlTree(admin_refedit_aspx __ctrl)
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
		((TemplateControl)this).SetStringResourcePointer(RuntimeHelpers.GetObjectValue(__stringResource), 0);
		__BuildControlTree(this);
		((Page)this).AddWrappedFileDependencies(RuntimeHelpers.GetObjectValue(__fileDependencies));
		((Page)this).Request.ValidateInput();
	}

	[DebuggerNonUserCode]
	public override int GetTypeHashCode()
	{
		return -1178014100;
	}

	[DebuggerNonUserCode]
	public override void ProcessRequest(HttpContext context)
	{
		((Page)this).ProcessRequest(context);
	}
}
