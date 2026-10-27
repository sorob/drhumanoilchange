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
public class admin_parseredit_aspx : Admin_ParserEdit
{
	private static bool __initialized;

	private static object __stringResource;

	private static object __fileDependencies;

	protected override bool SupportAutoEvents => false;

	[DebuggerNonUserCode]
	public admin_parseredit_aspx()
	{
		((TemplateControl)this).AppRelativeVirtualPath = "~/Admin/ParserEdit.aspx";
		if (!__initialized)
		{
			__stringResource = RuntimeHelpers.GetObjectValue(((TemplateControl)this).ReadStringResource());
			__fileDependencies = RuntimeHelpers.GetObjectValue(((Page)this).GetWrappedFileDependencies(new string[4] { "~/Admin/ParserEdit.aspx", "~/master1.master", "~/master1.master.vb", "~/Admin/ParserEdit.aspx.vb" }));
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
	private CommandField __BuildControl__control3()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		CommandField val = new CommandField();
		val.ShowEditButton = true;
		return val;
	}

	[DebuggerNonUserCode]
	private BoundField __BuildControl__control4()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		BoundField val = new BoundField();
		val.DataField = "ABR";
		val.HeaderText = "ABR";
		val.ReadOnly = true;
		((DataControlField)val).SortExpression = "ABR";
		return val;
	}

	[DebuggerNonUserCode]
	private BoundField __BuildControl__control5()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		BoundField val = new BoundField();
		val.DataField = "testname";
		val.HeaderText = "testname";
		((DataControlField)val).SortExpression = "testname";
		return val;
	}

	[DebuggerNonUserCode]
	private BoundField __BuildControl__control6()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		BoundField val = new BoundField();
		val.DataField = "result";
		val.HeaderText = "result";
		((DataControlField)val).SortExpression = "result";
		return val;
	}

	[DebuggerNonUserCode]
	private BoundField __BuildControl__control7()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		BoundField val = new BoundField();
		val.DataField = "flag";
		val.HeaderText = "flag";
		((DataControlField)val).SortExpression = "flag";
		return val;
	}

	[DebuggerNonUserCode]
	private BoundField __BuildControl__control8()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		BoundField val = new BoundField();
		val.DataField = "low";
		val.HeaderText = "low";
		((DataControlField)val).SortExpression = "low";
		return val;
	}

	[DebuggerNonUserCode]
	private BoundField __BuildControl__control9()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		BoundField val = new BoundField();
		val.DataField = "high";
		val.HeaderText = "high";
		((DataControlField)val).SortExpression = "high";
		return val;
	}

	[DebuggerNonUserCode]
	private BoundField __BuildControl__control10()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		BoundField val = new BoundField();
		val.DataField = "Category21";
		val.HeaderText = "Category21";
		((DataControlField)val).SortExpression = "Category21";
		return val;
	}

	[DebuggerNonUserCode]
	private BoundField __BuildControl__control11()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		BoundField val = new BoundField();
		val.DataField = "Default";
		val.HeaderText = "Default";
		((DataControlField)val).SortExpression = "Default";
		return val;
	}

	[DebuggerNonUserCode]
	private BoundField __BuildControl__control12()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		BoundField val = new BoundField();
		val.DataField = "Units";
		val.HeaderText = "Units";
		((DataControlField)val).SortExpression = "Units";
		return val;
	}

	[DebuggerNonUserCode]
	private BoundField __BuildControl__control13()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		BoundField val = new BoundField();
		val.DataField = "DefaultOpt";
		val.HeaderText = "DefaultOpt";
		((DataControlField)val).SortExpression = "DefaultOpt";
		return val;
	}

	[DebuggerNonUserCode]
	private LinkButton __BuildControl__control16()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		LinkButton val = new LinkButton();
		((Control)val).TemplateControl = (TemplateControl)(object)this;
		((Control)val).ApplyStyleSheetSkin((Page)(object)this);
		((Control)val).ID = "LinkButton1";
		val.CausesValidation = false;
		val.CommandName = "Delete";
		val.OnClientClick = "return confirm('Are you sure you want to delete this record? There will be no way to recover a deleted test.');";
		val.Text = "Delete";
		return val;
	}

	[DebuggerNonUserCode]
	private void __BuildControl__control15(Control __ctrl)
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Expected Obj, but got Unknown
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Expected Obj, but got Unknown
		((IParserAccessor)__ctrl).AddParsedSubObject((object)new LiteralControl("\r\n                    "));
		LinkButton val = __BuildControl__control16();
		((IParserAccessor)__ctrl).AddParsedSubObject((object)val);
		((IParserAccessor)__ctrl).AddParsedSubObject((object)new LiteralControl("\r\n                "));
	}

	[DebuggerNonUserCode]
	private TemplateField __BuildControl__control14()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Expected Obj, but got Unknown
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Expected Obj, but got Unknown
		TemplateField val = new TemplateField();
		val.ItemTemplate = (ITemplate)new CompiledBindableTemplateBuilder((BuildTemplateMethod)__BuildControl__control15, (ExtractTemplateValuesMethod)null);
		((DataControlField)val).ShowHeader = false;
		return val;
	}

	[DebuggerNonUserCode]
	private void __BuildControl__control2(DataControlFieldCollection __ctrl)
	{
		CommandField val = __BuildControl__control3();
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
		BoundField val10 = __BuildControl__control12();
		__ctrl.Add((DataControlField)(object)val10);
		BoundField val11 = __BuildControl__control13();
		__ctrl.Add((DataControlField)(object)val11);
		TemplateField val12 = __BuildControl__control14();
		__ctrl.Add((DataControlField)(object)val12);
	}

	[DebuggerNonUserCode]
	private GridView __BuildControlGridView1()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		GridView val = (GridView1 = new GridView());
		((Control)val).ApplyStyleSheetSkin((Page)(object)this);
		((Control)val).ID = "GridView1";
		val.AutoGenerateColumns = false;
		val.DataKeyNames = new string[1] { "ABR" };
		((DataBoundControl)val).DataSourceID = "SqlDataSource1";
		val.EmptyDataText = "There are no data records to display.";
		__BuildControl__control2(val.Columns);
		return val;
	}

	[DebuggerNonUserCode]
	private Parameter __BuildControl__control18()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Parameter val = new Parameter();
		val.Name = "codedname";
		val.Type = TypeCode.String;
		return val;
	}

	[DebuggerNonUserCode]
	private Parameter __BuildControl__control19()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Parameter val = new Parameter();
		val.Name = "drawdate";
		val.Type = TypeCode.String;
		return val;
	}

	[DebuggerNonUserCode]
	private Parameter __BuildControl__control20()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Parameter val = new Parameter();
		val.Name = "rptdate";
		val.Type = TypeCode.String;
		return val;
	}

	[DebuggerNonUserCode]
	private Parameter __BuildControl__control21()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Parameter val = new Parameter();
		val.Name = "specno";
		val.Type = TypeCode.String;
		return val;
	}

	[DebuggerNonUserCode]
	private Parameter __BuildControl__control22()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Parameter val = new Parameter();
		val.Name = "ABR";
		val.Type = TypeCode.String;
		return val;
	}

	[DebuggerNonUserCode]
	private Parameter __BuildControl__control23()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Parameter val = new Parameter();
		val.Name = "testname";
		val.Type = TypeCode.String;
		return val;
	}

	[DebuggerNonUserCode]
	private Parameter __BuildControl__control24()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Parameter val = new Parameter();
		val.Name = "result";
		val.Type = TypeCode.Double;
		return val;
	}

	[DebuggerNonUserCode]
	private Parameter __BuildControl__control25()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Parameter val = new Parameter();
		val.Name = "flag";
		val.Type = TypeCode.String;
		return val;
	}

	[DebuggerNonUserCode]
	private Parameter __BuildControl__control26()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Parameter val = new Parameter();
		val.Name = "low";
		val.Type = TypeCode.Double;
		return val;
	}

	[DebuggerNonUserCode]
	private Parameter __BuildControl__control27()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Parameter val = new Parameter();
		val.Name = "high";
		val.Type = TypeCode.Double;
		return val;
	}

	[DebuggerNonUserCode]
	private Parameter __BuildControl__control28()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Parameter val = new Parameter();
		val.Name = "Category21";
		val.Type = TypeCode.String;
		return val;
	}

	[DebuggerNonUserCode]
	private Parameter __BuildControl__control29()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Parameter val = new Parameter();
		val.Name = "Default";
		val.Type = TypeCode.String;
		return val;
	}

	[DebuggerNonUserCode]
	private Parameter __BuildControl__control30()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Parameter val = new Parameter();
		val.Name = "Units";
		val.Type = TypeCode.String;
		return val;
	}

	[DebuggerNonUserCode]
	private Parameter __BuildControl__control31()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Parameter val = new Parameter();
		val.Name = "DefaultOpt";
		val.Type = TypeCode.String;
		return val;
	}

	[DebuggerNonUserCode]
	private Parameter __BuildControl__control32()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Parameter val = new Parameter();
		val.Name = "F15";
		val.Type = TypeCode.String;
		return val;
	}

	[DebuggerNonUserCode]
	private void __BuildControl__control17(ParameterCollection __ctrl)
	{
		Parameter val = __BuildControl__control18();
		__ctrl.Add(val);
		Parameter val2 = __BuildControl__control19();
		__ctrl.Add(val2);
		Parameter val3 = __BuildControl__control20();
		__ctrl.Add(val3);
		Parameter val4 = __BuildControl__control21();
		__ctrl.Add(val4);
		Parameter val5 = __BuildControl__control22();
		__ctrl.Add(val5);
		Parameter val6 = __BuildControl__control23();
		__ctrl.Add(val6);
		Parameter val7 = __BuildControl__control24();
		__ctrl.Add(val7);
		Parameter val8 = __BuildControl__control25();
		__ctrl.Add(val8);
		Parameter val9 = __BuildControl__control26();
		__ctrl.Add(val9);
		Parameter val10 = __BuildControl__control27();
		__ctrl.Add(val10);
		Parameter val11 = __BuildControl__control28();
		__ctrl.Add(val11);
		Parameter val12 = __BuildControl__control29();
		__ctrl.Add(val12);
		Parameter val13 = __BuildControl__control30();
		__ctrl.Add(val13);
		Parameter val14 = __BuildControl__control31();
		__ctrl.Add(val14);
		Parameter val15 = __BuildControl__control32();
		__ctrl.Add(val15);
	}

	[DebuggerNonUserCode]
	private Parameter __BuildControl__control34()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Parameter val = new Parameter();
		val.Name = "ABR";
		val.Type = TypeCode.String;
		return val;
	}

	[DebuggerNonUserCode]
	private void __BuildControl__control33(ParameterCollection __ctrl)
	{
		Parameter val = __BuildControl__control34();
		__ctrl.Add(val);
	}

	[DebuggerNonUserCode]
	private Parameter __BuildControl__control36()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Parameter val = new Parameter();
		val.Name = "codedname";
		val.Type = TypeCode.String;
		return val;
	}

	[DebuggerNonUserCode]
	private Parameter __BuildControl__control37()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Parameter val = new Parameter();
		val.Name = "drawdate";
		val.Type = TypeCode.String;
		return val;
	}

	[DebuggerNonUserCode]
	private Parameter __BuildControl__control38()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Parameter val = new Parameter();
		val.Name = "rptdate";
		val.Type = TypeCode.String;
		return val;
	}

	[DebuggerNonUserCode]
	private Parameter __BuildControl__control39()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Parameter val = new Parameter();
		val.Name = "specno";
		val.Type = TypeCode.String;
		return val;
	}

	[DebuggerNonUserCode]
	private Parameter __BuildControl__control40()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Parameter val = new Parameter();
		val.Name = "testname";
		val.Type = TypeCode.String;
		return val;
	}

	[DebuggerNonUserCode]
	private Parameter __BuildControl__control41()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Parameter val = new Parameter();
		val.Name = "result";
		val.Type = TypeCode.Double;
		return val;
	}

	[DebuggerNonUserCode]
	private Parameter __BuildControl__control42()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Parameter val = new Parameter();
		val.Name = "flag";
		val.Type = TypeCode.String;
		return val;
	}

	[DebuggerNonUserCode]
	private Parameter __BuildControl__control43()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Parameter val = new Parameter();
		val.Name = "low";
		val.Type = TypeCode.Double;
		return val;
	}

	[DebuggerNonUserCode]
	private Parameter __BuildControl__control44()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Parameter val = new Parameter();
		val.Name = "high";
		val.Type = TypeCode.Double;
		return val;
	}

	[DebuggerNonUserCode]
	private Parameter __BuildControl__control45()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Parameter val = new Parameter();
		val.Name = "Category21";
		val.Type = TypeCode.String;
		return val;
	}

	[DebuggerNonUserCode]
	private Parameter __BuildControl__control46()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Parameter val = new Parameter();
		val.Name = "Default";
		val.Type = TypeCode.String;
		return val;
	}

	[DebuggerNonUserCode]
	private Parameter __BuildControl__control47()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Parameter val = new Parameter();
		val.Name = "Units";
		val.Type = TypeCode.String;
		return val;
	}

	[DebuggerNonUserCode]
	private Parameter __BuildControl__control48()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Parameter val = new Parameter();
		val.Name = "DefaultOpt";
		val.Type = TypeCode.String;
		return val;
	}

	[DebuggerNonUserCode]
	private Parameter __BuildControl__control49()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Parameter val = new Parameter();
		val.Name = "F15";
		val.Type = TypeCode.String;
		return val;
	}

	[DebuggerNonUserCode]
	private Parameter __BuildControl__control50()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Parameter val = new Parameter();
		val.Name = "ABR";
		val.Type = TypeCode.String;
		return val;
	}

	[DebuggerNonUserCode]
	private void __BuildControl__control35(ParameterCollection __ctrl)
	{
		Parameter val = __BuildControl__control36();
		__ctrl.Add(val);
		Parameter val2 = __BuildControl__control37();
		__ctrl.Add(val2);
		Parameter val3 = __BuildControl__control38();
		__ctrl.Add(val3);
		Parameter val4 = __BuildControl__control39();
		__ctrl.Add(val4);
		Parameter val5 = __BuildControl__control40();
		__ctrl.Add(val5);
		Parameter val6 = __BuildControl__control41();
		__ctrl.Add(val6);
		Parameter val7 = __BuildControl__control42();
		__ctrl.Add(val7);
		Parameter val8 = __BuildControl__control43();
		__ctrl.Add(val8);
		Parameter val9 = __BuildControl__control44();
		__ctrl.Add(val9);
		Parameter val10 = __BuildControl__control45();
		__ctrl.Add(val10);
		Parameter val11 = __BuildControl__control46();
		__ctrl.Add(val11);
		Parameter val12 = __BuildControl__control47();
		__ctrl.Add(val12);
		Parameter val13 = __BuildControl__control48();
		__ctrl.Add(val13);
		Parameter val14 = __BuildControl__control49();
		__ctrl.Add(val14);
		Parameter val15 = __BuildControl__control50();
		__ctrl.Add(val15);
	}

	[DebuggerNonUserCode]
	private SqlDataSource __BuildControlSqlDataSource1()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		SqlDataSource val = (SqlDataSource1 = new SqlDataSource());
		((Control)val).ID = "SqlDataSource1";
		val.DeleteCommand = "DELETE FROM [txtimp] WHERE [ABR] = @ABR";
		val.InsertCommand = "INSERT INTO [txtimp] ([codedname], [drawdate], [rptdate], [specno], [ABR], [testname], [result], [flag], [low], [high], [Category21], [Default], [Units], [DefaultOpt], [F15]) VALUES (@codedname, @drawdate, @rptdate, @specno, @ABR, @testname, @result, @flag, @low, @high, @Category21, @Default, @Units, @DefaultOpt, @F15)";
		val.SelectCommand = "SELECT [codedname], [drawdate], [rptdate], [specno], [ABR], [testname], [result], [flag], [low], [high], [Category21], [Default], [Units], [DefaultOpt], [F15] FROM [txtimp]";
		val.UpdateCommand = "UPDATE [txtimp] SET [codedname] = @codedname, [drawdate] = @drawdate, [rptdate] = @rptdate, [specno] = @specno, [testname] = @testname, [result] = @result, [flag] = @flag, [low] = @low, [high] = @high, [Category21] = @Category21, [Default] = @Default, [Units] = @Units, [DefaultOpt] = @DefaultOpt, [F15] = @F15 WHERE [ABR] = @ABR";
		__BuildControl__control17(val.InsertParameters);
		__BuildControl__control33(val.DeleteParameters);
		__BuildControl__control35(val.UpdateParameters);
		val.ConnectionString = Convert.ToString(ConnectionStringsExpressionBuilder.GetConnectionString("LocalSqlServer"), CultureInfo.CurrentCulture);
		val.ProviderName = Convert.ToString(ConnectionStringsExpressionBuilder.GetConnectionStringProviderName("LocalSqlServer"), CultureInfo.CurrentCulture);
		return val;
	}

	[DebuggerNonUserCode]
	private Button __BuildControlButton2()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Button val = (Button2 = new Button());
		((Control)val).ApplyStyleSheetSkin((Page)(object)this);
		((Control)val).ID = "Button2";
		val.Text = "Add more";
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
		val3.AddParsedSubObject((object)new LiteralControl("    "));
		GridView val4 = __BuildControlGridView1();
		val3.AddParsedSubObject((object)val4);
		val3.AddParsedSubObject((object)new LiteralControl("\r\n    "));
		SqlDataSource val5 = __BuildControlSqlDataSource1();
		val3.AddParsedSubObject((object)val5);
		val3.AddParsedSubObject((object)new LiteralControl("\r\n\r\n            "));
		Button val6 = __BuildControlButton2();
		val3.AddParsedSubObject((object)val6);
		val3.AddParsedSubObject((object)new LiteralControl("\r\n\r\n        "));
		return val;
	}

	[DebuggerNonUserCode]
	private DropDownList __BuildControlDropDownList1()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		DropDownList val = (DropDownList1 = new DropDownList());
		((Control)val).ApplyStyleSheetSkin((Page)(object)this);
		((Control)val).ID = "DropDownList1";
		((DataBoundControl)val).DataSourceID = "SqlDataSource2";
		((ListControl)val).DataTextField = "testName";
		((ListControl)val).DataValueField = "testAbrev";
		Unit width = new Unit(264.0, (UnitType)1);
		((WebControl)val).Width = width;
		return val;
	}

	[DebuggerNonUserCode]
	private Parameter __BuildControl__control52()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Parameter val = new Parameter();
		val.Name = "testName";
		val.Type = TypeCode.String;
		return val;
	}

	[DebuggerNonUserCode]
	private Parameter __BuildControl__control53()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Parameter val = new Parameter();
		val.Name = "testAbrev";
		val.Type = TypeCode.String;
		return val;
	}

	[DebuggerNonUserCode]
	private void __BuildControl__control51(ParameterCollection __ctrl)
	{
		Parameter val = __BuildControl__control52();
		__ctrl.Add(val);
		Parameter val2 = __BuildControl__control53();
		__ctrl.Add(val2);
	}

	[DebuggerNonUserCode]
	private Parameter __BuildControl__control55()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Parameter val = new Parameter();
		val.Name = "testAbrev";
		val.Type = TypeCode.String;
		return val;
	}

	[DebuggerNonUserCode]
	private void __BuildControl__control54(ParameterCollection __ctrl)
	{
		Parameter val = __BuildControl__control55();
		__ctrl.Add(val);
	}

	[DebuggerNonUserCode]
	private Parameter __BuildControl__control57()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Parameter val = new Parameter();
		val.Name = "testName";
		val.Type = TypeCode.String;
		return val;
	}

	[DebuggerNonUserCode]
	private Parameter __BuildControl__control58()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Parameter val = new Parameter();
		val.Name = "testAbrev";
		val.Type = TypeCode.String;
		return val;
	}

	[DebuggerNonUserCode]
	private void __BuildControl__control56(ParameterCollection __ctrl)
	{
		Parameter val = __BuildControl__control57();
		__ctrl.Add(val);
		Parameter val2 = __BuildControl__control58();
		__ctrl.Add(val2);
	}

	[DebuggerNonUserCode]
	private SqlDataSource __BuildControlSqlDataSource2()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		SqlDataSource val = (SqlDataSource2 = new SqlDataSource());
		((Control)val).ID = "SqlDataSource2";
		val.DeleteCommand = "DELETE FROM [TestRef] WHERE [testAbrev] = @testAbrev";
		val.InsertCommand = "INSERT INTO [TestRef] ([testName], [testAbrev]) VALUES (@testName, @testAbrev)";
		val.SelectCommand = "SELECT testName, testAbrev FROM TestRef WHERE (testAbrev NOT IN (SELECT ABR FROM txtimp))";
		val.UpdateCommand = "UPDATE [TestRef] SET [testName] = @testName WHERE [testAbrev] = @testAbrev";
		__BuildControl__control51(val.InsertParameters);
		__BuildControl__control54(val.DeleteParameters);
		__BuildControl__control56(val.UpdateParameters);
		val.ConnectionString = Convert.ToString(ConnectionStringsExpressionBuilder.GetConnectionString("nazdiltarinConnectionString"), CultureInfo.CurrentCulture);
		val.ProviderName = Convert.ToString(ConnectionStringsExpressionBuilder.GetConnectionStringProviderName("LocalSqlServer"), CultureInfo.CurrentCulture);
		return val;
	}

	[DebuggerNonUserCode]
	private TextBox __BuildControlTname()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		TextBox val = (Tname = new TextBox());
		((Control)val).ApplyStyleSheetSkin((Page)(object)this);
		((Control)val).ID = "Tname";
		return val;
	}

	[DebuggerNonUserCode]
	private TextBox __BuildControlTresult()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		TextBox val = (Tresult = new TextBox());
		((Control)val).ApplyStyleSheetSkin((Page)(object)this);
		((Control)val).ID = "Tresult";
		return val;
	}

	[DebuggerNonUserCode]
	private TextBox __BuildControlTflag()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		TextBox val = (Tflag = new TextBox());
		((Control)val).ApplyStyleSheetSkin((Page)(object)this);
		((Control)val).ID = "Tflag";
		return val;
	}

	[DebuggerNonUserCode]
	private TextBox __BuildControlTlow()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		TextBox val = (Tlow = new TextBox());
		((Control)val).ApplyStyleSheetSkin((Page)(object)this);
		((Control)val).ID = "Tlow";
		return val;
	}

	[DebuggerNonUserCode]
	private TextBox __BuildControlThigh()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		TextBox val = (Thigh = new TextBox());
		((Control)val).ApplyStyleSheetSkin((Page)(object)this);
		((Control)val).ID = "Thigh";
		return val;
	}

	[DebuggerNonUserCode]
	private DropDownList __BuildControlDropDownList3()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		DropDownList val = (DropDownList3 = new DropDownList());
		((Control)val).ApplyStyleSheetSkin((Page)(object)this);
		((Control)val).ID = "DropDownList3";
		((DataBoundControl)val).DataSourceID = "SqlDataSource3";
		((ListControl)val).DataTextField = "Category";
		((ListControl)val).DataValueField = "Category";
		Unit width = new Unit(264.0, (UnitType)1);
		((WebControl)val).Width = width;
		return val;
	}

	[DebuggerNonUserCode]
	private SqlDataSource __BuildControlSqlDataSource3()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		SqlDataSource val = (SqlDataSource3 = new SqlDataSource());
		((Control)val).ID = "SqlDataSource3";
		val.SelectCommand = "SELECT Category FROM TestRef GROUP BY Category";
		val.ConnectionString = Convert.ToString(ConnectionStringsExpressionBuilder.GetConnectionString("nazdiltarinConnectionString"), CultureInfo.CurrentCulture);
		val.ProviderName = Convert.ToString(ConnectionStringsExpressionBuilder.GetConnectionStringProviderName("LocalSqlServer"), CultureInfo.CurrentCulture);
		return val;
	}

	[DebuggerNonUserCode]
	private TextBox __BuildControlTdefault()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		TextBox val = (Tdefault = new TextBox());
		((Control)val).ApplyStyleSheetSkin((Page)(object)this);
		((Control)val).ID = "Tdefault";
		return val;
	}

	[DebuggerNonUserCode]
	private TextBox __BuildControlTunits()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		TextBox val = (Tunits = new TextBox());
		((Control)val).ApplyStyleSheetSkin((Page)(object)this);
		((Control)val).ID = "Tunits";
		return val;
	}

	[DebuggerNonUserCode]
	private TextBox __BuildControlTdefopt()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		TextBox val = (Tdefopt = new TextBox());
		((Control)val).ApplyStyleSheetSkin((Page)(object)this);
		((Control)val).ID = "Tdefopt";
		val.Text = "Optimum";
		return val;
	}

	[DebuggerNonUserCode]
	private Button __BuildControlButton1()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Button val = (Button1 = new Button());
		((Control)val).ApplyStyleSheetSkin((Page)(object)this);
		((Control)val).ID = "Button1";
		val.Text = "Add to the Parser";
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
		//IL_0156: Unknown result type (might be due to invalid IL or missing references)
		//IL_0160: Expected Obj, but got Unknown
		View val = (View2 = new View());
		((Control)val).ID = "View2";
		IParserAccessor val3 = (IParserAccessor)(object)val;
		val3.AddParsedSubObject((object)new LiteralControl("\r\n            <table class=\"style1\">\r\n                <tr>\r\n                    <td>\r\n                        Select a Test:</td>\r\n                    <td>\r\n                        "));
		DropDownList val4 = __BuildControlDropDownList1();
		val3.AddParsedSubObject((object)val4);
		val3.AddParsedSubObject((object)new LiteralControl("\r\n                        "));
		SqlDataSource val5 = __BuildControlSqlDataSource2();
		val3.AddParsedSubObject((object)val5);
		val3.AddParsedSubObject((object)((TemplateControl)this).CreateResourceBasedLiteralControl(0, 328, true));
		TextBox val6 = __BuildControlTname();
		val3.AddParsedSubObject((object)val6);
		val3.AddParsedSubObject((object)((TemplateControl)this).CreateResourceBasedLiteralControl(328, 313, true));
		TextBox val7 = __BuildControlTresult();
		val3.AddParsedSubObject((object)val7);
		val3.AddParsedSubObject((object)((TemplateControl)this).CreateResourceBasedLiteralControl(641, 339, true));
		TextBox val8 = __BuildControlTflag();
		val3.AddParsedSubObject((object)val8);
		val3.AddParsedSubObject((object)((TemplateControl)this).CreateResourceBasedLiteralControl(980, 328, true));
		TextBox val9 = __BuildControlTlow();
		val3.AddParsedSubObject((object)val9);
		val3.AddParsedSubObject((object)((TemplateControl)this).CreateResourceBasedLiteralControl(1308, 338, true));
		TextBox val10 = __BuildControlThigh();
		val3.AddParsedSubObject((object)val10);
		val3.AddParsedSubObject((object)((TemplateControl)this).CreateResourceBasedLiteralControl(1646, 342, true));
		DropDownList val11 = __BuildControlDropDownList3();
		val3.AddParsedSubObject((object)val11);
		val3.AddParsedSubObject((object)new LiteralControl("\r\n                        "));
		SqlDataSource val12 = __BuildControlSqlDataSource3();
		val3.AddParsedSubObject((object)val12);
		val3.AddParsedSubObject((object)((TemplateControl)this).CreateResourceBasedLiteralControl(1988, 307, true));
		TextBox val13 = __BuildControlTdefault();
		val3.AddParsedSubObject((object)val13);
		val3.AddParsedSubObject((object)((TemplateControl)this).CreateResourceBasedLiteralControl(2295, 305, true));
		TextBox val14 = __BuildControlTunits();
		val3.AddParsedSubObject((object)val14);
		val3.AddParsedSubObject((object)((TemplateControl)this).CreateResourceBasedLiteralControl(2600, 311, true));
		TextBox val15 = __BuildControlTdefopt();
		val3.AddParsedSubObject((object)val15);
		val3.AddParsedSubObject((object)((TemplateControl)this).CreateResourceBasedLiteralControl(2911, 369, true));
		Button val16 = __BuildControlButton1();
		val3.AddParsedSubObject((object)val16);
		val3.AddParsedSubObject((object)((TemplateControl)this).CreateResourceBasedLiteralControl(3280, 1305, true));
		return val;
	}

	[DebuggerNonUserCode]
	private MultiView __BuildControlMultiView1()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Expected Obj, but got Unknown
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Expected Obj, but got Unknown
		//IL_0070: Unknown result type (might be due to invalid IL or missing references)
		//IL_007a: Expected Obj, but got Unknown
		MultiView val = (MultiView1 = new MultiView());
		((Control)val).TemplateControl = (TemplateControl)(object)this;
		((Control)val).ID = "MultiView1";
		val.ActiveViewIndex = 0;
		IParserAccessor val3 = (IParserAccessor)(object)val;
		val3.AddParsedSubObject((object)new LiteralControl("\r\n        "));
		View val4 = __BuildControlView1();
		val3.AddParsedSubObject((object)val4);
		val3.AddParsedSubObject((object)new LiteralControl("\r\n        "));
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
		((IParserAccessor)__ctrl).AddParsedSubObject((object)new LiteralControl("\r\n    "));
		MultiView val = __BuildControlMultiView1();
		((IParserAccessor)__ctrl).AddParsedSubObject((object)val);
		((IParserAccessor)__ctrl).AddParsedSubObject((object)new LiteralControl("\r\n"));
	}

	[DebuggerNonUserCode]
	private void __BuildControlTree(admin_parseredit_aspx __ctrl)
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
		return 307590811;
	}

	[DebuggerNonUserCode]
	public override void ProcessRequest(HttpContext context)
	{
		((Page)this).ProcessRequest(context);
	}
}
