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
public class labcalc_edit_resultedit_aspx : LabCalc_Edit_ResultEdit
{
	private static bool __initialized;

	private static object __stringResource;

	private static object __fileDependencies;

	protected override bool SupportAutoEvents => false;

	[DebuggerNonUserCode]
	public labcalc_edit_resultedit_aspx()
	{
		((TemplateControl)this).AppRelativeVirtualPath = "~/LabCalc/Edit/ResultEdit.aspx";
		if (!__initialized)
		{
			__stringResource = RuntimeHelpers.GetObjectValue(((TemplateControl)this).ReadStringResource());
			__fileDependencies = RuntimeHelpers.GetObjectValue(((Page)this).GetWrappedFileDependencies(new string[4] { "~/LabCalc/Edit/ResultEdit.aspx", "~/master1.master", "~/master1.master.vb", "~/LabCalc/Edit/ResultEdit.aspx.vb" }));
			__initialized = true;
		}
		((Page)this).Server.ScriptTimeout = 30000000;
	}

	[DebuggerNonUserCode]
	private void __BuildControlContent1(Control __ctrl)
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Expected Obj, but got Unknown
		((IParserAccessor)__ctrl).AddParsedSubObject((object)new LiteralControl("\r\n    <style type=\"text/css\">\r\n        .style2\r\n        {\r\n            width: 100%;\r\n        }\r\n        .style3\r\n        {\r\n            width: 103px;\r\n        }\r\n    </style>\r\n"));
	}

	[DebuggerNonUserCode]
	private QueryStringParameter __BuildControl__control3()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		QueryStringParameter val = new QueryStringParameter();
		((Parameter)val).Name = "Testid";
		val.QueryStringField = "tid";
		((Parameter)val).Type = TypeCode.Int32;
		return val;
	}

	[DebuggerNonUserCode]
	private Parameter __BuildControl__control4()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Parameter val = new Parameter();
		val.Name = "UserName";
		val.Type = TypeCode.String;
		return val;
	}

	[DebuggerNonUserCode]
	private void __BuildControl__control2(ParameterCollection __ctrl)
	{
		QueryStringParameter val = __BuildControl__control3();
		__ctrl.Add((Parameter)(object)val);
		Parameter val2 = __BuildControl__control4();
		__ctrl.Add(val2);
	}

	[DebuggerNonUserCode]
	private Parameter __BuildControl__control6()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Parameter val = new Parameter();
		val.Name = "TestAbrev";
		val.Type = TypeCode.String;
		return val;
	}

	[DebuggerNonUserCode]
	private Parameter __BuildControl__control7()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Parameter val = new Parameter();
		val.Name = "Testid";
		val.Type = TypeCode.Int32;
		return val;
	}

	[DebuggerNonUserCode]
	private void __BuildControl__control5(ParameterCollection __ctrl)
	{
		Parameter val = __BuildControl__control6();
		__ctrl.Add(val);
		Parameter val2 = __BuildControl__control7();
		__ctrl.Add(val2);
	}

	[DebuggerNonUserCode]
	private Parameter __BuildControl__control9()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Parameter val = new Parameter();
		val.Name = "Result";
		val.Type = TypeCode.Double;
		return val;
	}

	[DebuggerNonUserCode]
	private Parameter __BuildControl__control10()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Parameter val = new Parameter();
		val.Name = "rid";
		val.Type = TypeCode.Int32;
		return val;
	}

	[DebuggerNonUserCode]
	private Parameter __BuildControl__control11()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Parameter val = new Parameter();
		val.Name = "TestAbrev";
		val.Type = TypeCode.String;
		return val;
	}

	[DebuggerNonUserCode]
	private Parameter __BuildControl__control12()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Parameter val = new Parameter();
		val.Name = "MedLow";
		val.Type = TypeCode.Double;
		return val;
	}

	[DebuggerNonUserCode]
	private Parameter __BuildControl__control13()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Parameter val = new Parameter();
		val.Name = "MedHigh";
		val.Type = TypeCode.Double;
		return val;
	}

	[DebuggerNonUserCode]
	private Parameter __BuildControl__control14()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Parameter val = new Parameter();
		val.Name = "Medopt";
		val.Type = TypeCode.Double;
		return val;
	}

	[DebuggerNonUserCode]
	private Parameter __BuildControl__control15()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Parameter val = new Parameter();
		val.Name = "MedScale";
		val.Type = TypeCode.Double;
		return val;
	}

	[DebuggerNonUserCode]
	private Parameter __BuildControl__control16()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Parameter val = new Parameter();
		val.Name = "UserName";
		val.Type = TypeCode.String;
		return val;
	}

	[DebuggerNonUserCode]
	private Parameter __BuildControl__control17()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Parameter val = new Parameter();
		val.Name = "DocLow";
		val.Type = TypeCode.Double;
		return val;
	}

	[DebuggerNonUserCode]
	private Parameter __BuildControl__control18()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Parameter val = new Parameter();
		val.Name = "DocHigh";
		val.Type = TypeCode.Double;
		return val;
	}

	[DebuggerNonUserCode]
	private Parameter __BuildControl__control19()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Parameter val = new Parameter();
		val.Name = "DocOpt";
		val.Type = TypeCode.Double;
		return val;
	}

	[DebuggerNonUserCode]
	private Parameter __BuildControl__control20()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Parameter val = new Parameter();
		val.Name = "DocScale";
		val.Type = TypeCode.Double;
		return val;
	}

	[DebuggerNonUserCode]
	private Parameter __BuildControl__control21()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Parameter val = new Parameter();
		val.Name = "Testid";
		val.Type = TypeCode.Int32;
		return val;
	}

	[DebuggerNonUserCode]
	private void __BuildControl__control8(ParameterCollection __ctrl)
	{
		Parameter val = __BuildControl__control9();
		__ctrl.Add(val);
		Parameter val2 = __BuildControl__control10();
		__ctrl.Add(val2);
		Parameter val3 = __BuildControl__control11();
		__ctrl.Add(val3);
		Parameter val4 = __BuildControl__control12();
		__ctrl.Add(val4);
		Parameter val5 = __BuildControl__control13();
		__ctrl.Add(val5);
		Parameter val6 = __BuildControl__control14();
		__ctrl.Add(val6);
		Parameter val7 = __BuildControl__control15();
		__ctrl.Add(val7);
		Parameter val8 = __BuildControl__control16();
		__ctrl.Add(val8);
		Parameter val9 = __BuildControl__control17();
		__ctrl.Add(val9);
		Parameter val10 = __BuildControl__control18();
		__ctrl.Add(val10);
		Parameter val11 = __BuildControl__control19();
		__ctrl.Add(val11);
		Parameter val12 = __BuildControl__control20();
		__ctrl.Add(val12);
		Parameter val13 = __BuildControl__control21();
		__ctrl.Add(val13);
	}

	[DebuggerNonUserCode]
	private Parameter __BuildControl__control23()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Parameter val = new Parameter();
		val.Name = "Result";
		val.Type = TypeCode.Double;
		return val;
	}

	[DebuggerNonUserCode]
	private Parameter __BuildControl__control24()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Parameter val = new Parameter();
		val.Name = "rid";
		val.Type = TypeCode.Int32;
		return val;
	}

	[DebuggerNonUserCode]
	private Parameter __BuildControl__control25()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Parameter val = new Parameter();
		val.Name = "MedLow";
		val.Type = TypeCode.Double;
		return val;
	}

	[DebuggerNonUserCode]
	private Parameter __BuildControl__control26()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Parameter val = new Parameter();
		val.Name = "MedHigh";
		val.Type = TypeCode.Double;
		return val;
	}

	[DebuggerNonUserCode]
	private Parameter __BuildControl__control27()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Parameter val = new Parameter();
		val.Name = "Medopt";
		val.Type = TypeCode.Double;
		return val;
	}

	[DebuggerNonUserCode]
	private Parameter __BuildControl__control28()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Parameter val = new Parameter();
		val.Name = "MedScale";
		val.Type = TypeCode.Double;
		return val;
	}

	[DebuggerNonUserCode]
	private Parameter __BuildControl__control29()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Parameter val = new Parameter();
		val.Name = "UserName";
		val.Type = TypeCode.String;
		return val;
	}

	[DebuggerNonUserCode]
	private Parameter __BuildControl__control30()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Parameter val = new Parameter();
		val.Name = "DocLow";
		val.Type = TypeCode.Double;
		return val;
	}

	[DebuggerNonUserCode]
	private Parameter __BuildControl__control31()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Parameter val = new Parameter();
		val.Name = "DocHigh";
		val.Type = TypeCode.Double;
		return val;
	}

	[DebuggerNonUserCode]
	private Parameter __BuildControl__control32()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Parameter val = new Parameter();
		val.Name = "DocOpt";
		val.Type = TypeCode.Double;
		return val;
	}

	[DebuggerNonUserCode]
	private Parameter __BuildControl__control33()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Parameter val = new Parameter();
		val.Name = "DocScale";
		val.Type = TypeCode.Double;
		return val;
	}

	[DebuggerNonUserCode]
	private Parameter __BuildControl__control34()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Parameter val = new Parameter();
		val.Name = "RRefindex";
		val.Type = TypeCode.Int32;
		return val;
	}

	[DebuggerNonUserCode]
	private Parameter __BuildControl__control35()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Parameter val = new Parameter();
		val.Name = "TestAbrev";
		val.Type = TypeCode.String;
		return val;
	}

	[DebuggerNonUserCode]
	private Parameter __BuildControl__control36()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Parameter val = new Parameter();
		val.Name = "Testid";
		val.Type = TypeCode.Int32;
		return val;
	}

	[DebuggerNonUserCode]
	private void __BuildControl__control22(ParameterCollection __ctrl)
	{
		Parameter val = __BuildControl__control23();
		__ctrl.Add(val);
		Parameter val2 = __BuildControl__control24();
		__ctrl.Add(val2);
		Parameter val3 = __BuildControl__control25();
		__ctrl.Add(val3);
		Parameter val4 = __BuildControl__control26();
		__ctrl.Add(val4);
		Parameter val5 = __BuildControl__control27();
		__ctrl.Add(val5);
		Parameter val6 = __BuildControl__control28();
		__ctrl.Add(val6);
		Parameter val7 = __BuildControl__control29();
		__ctrl.Add(val7);
		Parameter val8 = __BuildControl__control30();
		__ctrl.Add(val8);
		Parameter val9 = __BuildControl__control31();
		__ctrl.Add(val9);
		Parameter val10 = __BuildControl__control32();
		__ctrl.Add(val10);
		Parameter val11 = __BuildControl__control33();
		__ctrl.Add(val11);
		Parameter val12 = __BuildControl__control34();
		__ctrl.Add(val12);
		Parameter val13 = __BuildControl__control35();
		__ctrl.Add(val13);
		Parameter val14 = __BuildControl__control36();
		__ctrl.Add(val14);
	}

	[DebuggerNonUserCode]
	private SqlDataSource __BuildControlSqlDataSource1()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		SqlDataSource val = (SqlDataSource1 = new SqlDataSource());
		((Control)val).TemplateControl = (TemplateControl)(object)this;
		((Control)val).ID = "SqlDataSource1";
		val.DeleteCommand = "DELETE FROM [ResultRef] WHERE [TestAbrev] = @TestAbrev AND [Testid] = @Testid";
		val.InsertCommand = "INSERT INTO [ResultRef] ([Result], [rid], [TestAbrev], [MedLow], [MedHigh], [Medopt], [MedScale], [UserName], [DocLow], [DocHigh], [DocOpt], [DocScale], [Testid]) VALUES (@Result, @rid, @TestAbrev, @MedLow, @MedHigh, @Medopt, @MedScale, @UserName, @DocLow, @DocHigh, @DocOpt, @DocScale, @Testid)";
		val.SelectCommand = "SELECT [Result], [rid], [TestAbrev], [MedLow], [MedHigh], [Medopt], [MedScale], [UserName], [DocLow], [DocHigh], [DocOpt], [DocScale], [Testid], [RRefindex] FROM [ResultRef] WHERE (([Testid] = @Testid) AND ([UserName] = @UserName))";
		val.UpdateCommand = "UPDATE [ResultRef] SET [Result] = @Result, [rid] = @rid, [MedLow] = @MedLow, [MedHigh] = @MedHigh, [Medopt] = @Medopt, [MedScale] = @MedScale, [UserName] = @UserName, [DocLow] = @DocLow, [DocHigh] = @DocHigh, [DocOpt] = @DocOpt, [DocScale] = @DocScale, [RRefindex] = @RRefindex WHERE [TestAbrev] = @TestAbrev AND [Testid] = @Testid";
		__BuildControl__control2(val.SelectParameters);
		__BuildControl__control5(val.DeleteParameters);
		__BuildControl__control8(val.InsertParameters);
		__BuildControl__control22(val.UpdateParameters);
		val.ConnectionString = Convert.ToString(ConnectionStringsExpressionBuilder.GetConnectionString("nazdiltarinConnectionString"), CultureInfo.CurrentCulture);
		val.ProviderName = Convert.ToString(ConnectionStringsExpressionBuilder.GetConnectionStringProviderName("LocalSqlServer"), CultureInfo.CurrentCulture);
		return val;
	}

	[DebuggerNonUserCode]
	private CommandField __BuildControl__control38()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		CommandField val = new CommandField();
		val.SelectText = "Edit";
		val.ShowSelectButton = true;
		return val;
	}

	[DebuggerNonUserCode]
	private BoundField __BuildControl__control39()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		BoundField val = new BoundField();
		val.DataField = "Result";
		val.HeaderText = "Result";
		((DataControlField)val).SortExpression = "Result";
		return val;
	}

	[DebuggerNonUserCode]
	private BoundField __BuildControl__control40()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		BoundField val = new BoundField();
		val.DataField = "rid";
		val.HeaderText = "rid";
		((DataControlField)val).SortExpression = "rid";
		return val;
	}

	[DebuggerNonUserCode]
	private BoundField __BuildControl__control41()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		BoundField val = new BoundField();
		val.DataField = "TestAbrev";
		val.HeaderText = "TestAbrev";
		val.ReadOnly = true;
		((DataControlField)val).SortExpression = "TestAbrev";
		return val;
	}

	[DebuggerNonUserCode]
	private BoundField __BuildControl__control42()
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
	private BoundField __BuildControl__control43()
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
	private BoundField __BuildControl__control44()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		BoundField val = new BoundField();
		val.DataField = "Medopt";
		val.HeaderText = "Medopt";
		((DataControlField)val).SortExpression = "Medopt";
		return val;
	}

	[DebuggerNonUserCode]
	private BoundField __BuildControl__control45()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		BoundField val = new BoundField();
		val.DataField = "MedScale";
		val.HeaderText = "MedScale";
		((DataControlField)val).SortExpression = "MedScale";
		return val;
	}

	[DebuggerNonUserCode]
	private BoundField __BuildControl__control46()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		BoundField val = new BoundField();
		val.DataField = "UserName";
		val.HeaderText = "UserName";
		((DataControlField)val).SortExpression = "UserName";
		return val;
	}

	[DebuggerNonUserCode]
	private BoundField __BuildControl__control47()
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
	private BoundField __BuildControl__control48()
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
	private BoundField __BuildControl__control49()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		BoundField val = new BoundField();
		val.DataField = "DocOpt";
		val.HeaderText = "DocOpt";
		((DataControlField)val).SortExpression = "DocOpt";
		return val;
	}

	[DebuggerNonUserCode]
	private BoundField __BuildControl__control50()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		BoundField val = new BoundField();
		val.DataField = "DocScale";
		val.HeaderText = "DocScale";
		((DataControlField)val).SortExpression = "DocScale";
		return val;
	}

	[DebuggerNonUserCode]
	private BoundField __BuildControl__control51()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		BoundField val = new BoundField();
		val.DataField = "Testid";
		val.HeaderText = "Testid";
		val.ReadOnly = true;
		((DataControlField)val).SortExpression = "Testid";
		return val;
	}

	[DebuggerNonUserCode]
	private BoundField __BuildControl__control52()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		BoundField val = new BoundField();
		val.DataField = "RRefindex";
		val.HeaderText = "RRefindex";
		val.ReadOnly = true;
		((DataControlField)val).SortExpression = "RRefindex";
		return val;
	}

	[DebuggerNonUserCode]
	private void __BuildControl__control37(DataControlFieldCollection __ctrl)
	{
		CommandField val = __BuildControl__control38();
		__ctrl.Add((DataControlField)(object)val);
		BoundField val2 = __BuildControl__control39();
		__ctrl.Add((DataControlField)(object)val2);
		BoundField val3 = __BuildControl__control40();
		__ctrl.Add((DataControlField)(object)val3);
		BoundField val4 = __BuildControl__control41();
		__ctrl.Add((DataControlField)(object)val4);
		BoundField val5 = __BuildControl__control42();
		__ctrl.Add((DataControlField)(object)val5);
		BoundField val6 = __BuildControl__control43();
		__ctrl.Add((DataControlField)(object)val6);
		BoundField val7 = __BuildControl__control44();
		__ctrl.Add((DataControlField)(object)val7);
		BoundField val8 = __BuildControl__control45();
		__ctrl.Add((DataControlField)(object)val8);
		BoundField val9 = __BuildControl__control46();
		__ctrl.Add((DataControlField)(object)val9);
		BoundField val10 = __BuildControl__control47();
		__ctrl.Add((DataControlField)(object)val10);
		BoundField val11 = __BuildControl__control48();
		__ctrl.Add((DataControlField)(object)val11);
		BoundField val12 = __BuildControl__control49();
		__ctrl.Add((DataControlField)(object)val12);
		BoundField val13 = __BuildControl__control50();
		__ctrl.Add((DataControlField)(object)val13);
		BoundField val14 = __BuildControl__control51();
		__ctrl.Add((DataControlField)(object)val14);
		BoundField val15 = __BuildControl__control52();
		__ctrl.Add((DataControlField)(object)val15);
	}

	[DebuggerNonUserCode]
	private GridView __BuildControlGridView1()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		GridView val = (GridView1 = new GridView());
		((Control)val).ApplyStyleSheetSkin((Page)(object)this);
		((Control)val).ID = "GridView1";
		val.AllowSorting = true;
		val.AutoGenerateColumns = false;
		val.DataKeyNames = new string[2] { "TestAbrev", "Testid" };
		((DataBoundControl)val).DataSourceID = "SqlDataSource1";
		val.EmptyDataText = "There are no data records to display.";
		__BuildControl__control37(val.Columns);
		return val;
	}

	[DebuggerNonUserCode]
	private View __BuildControlView1()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Expected Obj, but got Unknown
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Expected Obj, but got Unknown
		View val = (View1 = new View());
		((Control)val).ID = "View1";
		IParserAccessor val3 = (IParserAccessor)(object)val;
		val3.AddParsedSubObject((object)new LiteralControl("\r\n        "));
		GridView val4 = __BuildControlGridView1();
		val3.AddParsedSubObject((object)val4);
		val3.AddParsedSubObject((object)new LiteralControl("\r\n            "));
		return val;
	}

	[DebuggerNonUserCode]
	private TextBox __BuildControlT_result()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		TextBox val = (T_result = new TextBox());
		((Control)val).ApplyStyleSheetSkin((Page)(object)this);
		((Control)val).ID = "T_result";
		return val;
	}

	[DebuggerNonUserCode]
	private Label __BuildControlT_abrev()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Label val = (T_abrev = new Label());
		((Control)val).ApplyStyleSheetSkin((Page)(object)this);
		((Control)val).ID = "T_abrev";
		val.Text = "Label";
		return val;
	}

	[DebuggerNonUserCode]
	private TextBox __BuildControlT_medlow()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		TextBox val = (T_medlow = new TextBox());
		((Control)val).ApplyStyleSheetSkin((Page)(object)this);
		((Control)val).ID = "T_medlow";
		return val;
	}

	[DebuggerNonUserCode]
	private TextBox __BuildControlmedhigh()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		TextBox val = (medhigh = new TextBox());
		((Control)val).ApplyStyleSheetSkin((Page)(object)this);
		((Control)val).ID = "medhigh";
		return val;
	}

	[DebuggerNonUserCode]
	private TextBox __BuildControlT_doclow()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		TextBox val = (T_doclow = new TextBox());
		((Control)val).ApplyStyleSheetSkin((Page)(object)this);
		((Control)val).ID = "T_doclow";
		return val;
	}

	[DebuggerNonUserCode]
	private TextBox __BuildControlT_dochigh()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		TextBox val = (T_dochigh = new TextBox());
		((Control)val).ApplyStyleSheetSkin((Page)(object)this);
		((Control)val).ID = "T_dochigh";
		return val;
	}

	[DebuggerNonUserCode]
	private Button __BuildControlupdatebtn()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		Button val = (updatebtn = new Button());
		((Control)val).ApplyStyleSheetSkin((Page)(object)this);
		((Control)val).ID = "updatebtn";
		val.Text = "Update";
		Unit width = new Unit(245.0, (UnitType)1);
		((WebControl)val).Width = width;
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
		//IL_0132: Unknown result type (might be due to invalid IL or missing references)
		//IL_013c: Expected Obj, but got Unknown
		View val = (View2 = new View());
		((Control)val).ID = "View2";
		IParserAccessor val3 = (IParserAccessor)(object)val;
		val3.AddParsedSubObject((object)new LiteralControl("\r\n                 <table class=\"style2\">\r\n                     <tr>\r\n                         <td class=\"style3\">\r\n                             Result</td>\r\n                         <td>\r\n                             "));
		TextBox val4 = __BuildControlT_result();
		val3.AddParsedSubObject((object)val4);
		val3.AddParsedSubObject((object)((TemplateControl)this).CreateResourceBasedLiteralControl(0, 314, true));
		Label val5 = __BuildControlT_abrev();
		val3.AddParsedSubObject((object)val5);
		val3.AddParsedSubObject((object)((TemplateControl)this).CreateResourceBasedLiteralControl(314, 311, true));
		TextBox val6 = __BuildControlT_medlow();
		val3.AddParsedSubObject((object)val6);
		val3.AddParsedSubObject((object)((TemplateControl)this).CreateResourceBasedLiteralControl(625, 312, true));
		TextBox val7 = __BuildControlmedhigh();
		val3.AddParsedSubObject((object)val7);
		val3.AddParsedSubObject((object)((TemplateControl)this).CreateResourceBasedLiteralControl(937, 311, true));
		TextBox val8 = __BuildControlT_doclow();
		val3.AddParsedSubObject((object)val8);
		val3.AddParsedSubObject((object)((TemplateControl)this).CreateResourceBasedLiteralControl(1248, 312, true));
		TextBox val9 = __BuildControlT_dochigh();
		val3.AddParsedSubObject((object)val9);
		val3.AddParsedSubObject((object)((TemplateControl)this).CreateResourceBasedLiteralControl(1560, 310, true));
		Button val10 = __BuildControlupdatebtn();
		val3.AddParsedSubObject((object)val10);
		val3.AddParsedSubObject((object)new LiteralControl("\r\n                             "));
		Button val11 = __BuildControlButton1();
		val3.AddParsedSubObject((object)val11);
		val3.AddParsedSubObject((object)((TemplateControl)this).CreateResourceBasedLiteralControl(1870, 2198, true));
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
		val3.AddParsedSubObject((object)new LiteralControl("\r\n            \r\n            \r\n            \r\n            \r\n             "));
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
		((IParserAccessor)__ctrl).AddParsedSubObject((object)new LiteralControl("\r\n\r\n   \r\n         "));
		MultiView val2 = __BuildControlMultiView1();
		((IParserAccessor)__ctrl).AddParsedSubObject((object)val2);
		((IParserAccessor)__ctrl).AddParsedSubObject((object)new LiteralControl(" \r\n    \r\n"));
	}

	[DebuggerNonUserCode]
	private void __BuildControlTree(labcalc_edit_resultedit_aspx __ctrl)
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
		return -449764047;
	}

	[DebuggerNonUserCode]
	public override void ProcessRequest(HttpContext context)
	{
		((Page)this).ProcessRequest(context);
	}
}
