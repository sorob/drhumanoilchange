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
public class cr_default_aspx : _Default
{
	private static bool __initialized;

	private static object __fileDependencies;

	protected override bool SupportAutoEvents => false;

	[DebuggerNonUserCode]
	public cr_default_aspx()
	{
		((TemplateControl)this).AppRelativeVirtualPath = "~/CR/Default.aspx";
		if (!__initialized)
		{
			__fileDependencies = RuntimeHelpers.GetObjectValue(((Page)this).GetWrappedFileDependencies(new string[2] { "~/CR/Default.aspx", "~/CR/Default.aspx.vb" }));
			__initialized = true;
		}
		((Page)this).Server.ScriptTimeout = 30000000;
	}

	[DebuggerNonUserCode]
	private HtmlTitle __BuildControl__control3()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		return new HtmlTitle();
	}

	[DebuggerNonUserCode]
	private HtmlHead __BuildControl__control2()
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected Obj, but got Unknown
		HtmlHead val = new HtmlHead("head");
		HtmlTitle val2 = __BuildControl__control3();
		IParserAccessor val3 = (IParserAccessor)(object)val;
		val3.AddParsedSubObject((object)val2);
		return val;
	}

	[DebuggerNonUserCode]
	private BoundField __BuildControl__control5()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		BoundField val = new BoundField();
		val.DataField = "gId";
		val.HeaderText = "gId";
		val.ReadOnly = true;
		((DataControlField)val).SortExpression = "gId";
		return val;
	}

	[DebuggerNonUserCode]
	private BoundField __BuildControl__control6()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		BoundField val = new BoundField();
		val.DataField = "scHigh";
		val.HeaderText = "scHigh";
		((DataControlField)val).SortExpression = "scHigh";
		return val;
	}

	[DebuggerNonUserCode]
	private BoundField __BuildControl__control7()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		BoundField val = new BoundField();
		val.DataField = "scLow";
		val.HeaderText = "scLow";
		((DataControlField)val).SortExpression = "scLow";
		return val;
	}

	[DebuggerNonUserCode]
	private BoundField __BuildControl__control8()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		BoundField val = new BoundField();
		val.DataField = "inf";
		val.HeaderText = "inf";
		((DataControlField)val).SortExpression = "inf";
		return val;
	}

	[DebuggerNonUserCode]
	private BoundField __BuildControl__control9()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		BoundField val = new BoundField();
		val.DataField = "rpt";
		val.HeaderText = "rpt";
		((DataControlField)val).SortExpression = "rpt";
		return val;
	}

	[DebuggerNonUserCode]
	private void __BuildControl__control4(DataControlFieldCollection __ctrl)
	{
		BoundField val = __BuildControl__control5();
		__ctrl.Add((DataControlField)(object)val);
		BoundField val2 = __BuildControl__control6();
		__ctrl.Add((DataControlField)(object)val2);
		BoundField val3 = __BuildControl__control7();
		__ctrl.Add((DataControlField)(object)val3);
		BoundField val4 = __BuildControl__control8();
		__ctrl.Add((DataControlField)(object)val4);
		BoundField val5 = __BuildControl__control9();
		__ctrl.Add((DataControlField)(object)val5);
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
		val.DataKeyNames = new string[1] { "gId" };
		((DataBoundControl)val).DataSourceID = "SqlDataSource1";
		val.EmptyDataText = "There are no data records to display.";
		__BuildControl__control4(val.Columns);
		return val;
	}

	[DebuggerNonUserCode]
	private Parameter __BuildControl__control11()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Parameter val = new Parameter();
		val.Name = "t1";
		return val;
	}

	[DebuggerNonUserCode]
	private Parameter __BuildControl__control12()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Parameter val = new Parameter();
		val.Name = "t2";
		return val;
	}

	[DebuggerNonUserCode]
	private void __BuildControl__control10(ParameterCollection __ctrl)
	{
		Parameter val = __BuildControl__control11();
		__ctrl.Add(val);
		Parameter val2 = __BuildControl__control12();
		__ctrl.Add(val2);
	}

	[DebuggerNonUserCode]
	private Parameter __BuildControl__control14()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Parameter val = new Parameter();
		val.Name = "gId";
		val.Type = TypeCode.Int32;
		return val;
	}

	[DebuggerNonUserCode]
	private void __BuildControl__control13(ParameterCollection __ctrl)
	{
		Parameter val = __BuildControl__control14();
		__ctrl.Add(val);
	}

	[DebuggerNonUserCode]
	private Parameter __BuildControl__control16()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Parameter val = new Parameter();
		val.Name = "scHigh";
		val.Type = TypeCode.Double;
		return val;
	}

	[DebuggerNonUserCode]
	private Parameter __BuildControl__control17()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Parameter val = new Parameter();
		val.Name = "scLow";
		val.Type = TypeCode.Double;
		return val;
	}

	[DebuggerNonUserCode]
	private Parameter __BuildControl__control18()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Parameter val = new Parameter();
		val.Name = "inf";
		val.Type = TypeCode.String;
		return val;
	}

	[DebuggerNonUserCode]
	private Parameter __BuildControl__control19()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Parameter val = new Parameter();
		val.Name = "rpt";
		val.Type = TypeCode.String;
		return val;
	}

	[DebuggerNonUserCode]
	private void __BuildControl__control15(ParameterCollection __ctrl)
	{
		Parameter val = __BuildControl__control16();
		__ctrl.Add(val);
		Parameter val2 = __BuildControl__control17();
		__ctrl.Add(val2);
		Parameter val3 = __BuildControl__control18();
		__ctrl.Add(val3);
		Parameter val4 = __BuildControl__control19();
		__ctrl.Add(val4);
	}

	[DebuggerNonUserCode]
	private Parameter __BuildControl__control21()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Parameter val = new Parameter();
		val.Name = "scHigh";
		val.Type = TypeCode.Double;
		return val;
	}

	[DebuggerNonUserCode]
	private Parameter __BuildControl__control22()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Parameter val = new Parameter();
		val.Name = "scLow";
		val.Type = TypeCode.Double;
		return val;
	}

	[DebuggerNonUserCode]
	private Parameter __BuildControl__control23()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Parameter val = new Parameter();
		val.Name = "inf";
		val.Type = TypeCode.String;
		return val;
	}

	[DebuggerNonUserCode]
	private Parameter __BuildControl__control24()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Parameter val = new Parameter();
		val.Name = "rpt";
		val.Type = TypeCode.String;
		return val;
	}

	[DebuggerNonUserCode]
	private Parameter __BuildControl__control25()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Parameter val = new Parameter();
		val.Name = "gId";
		val.Type = TypeCode.Int32;
		return val;
	}

	[DebuggerNonUserCode]
	private void __BuildControl__control20(ParameterCollection __ctrl)
	{
		Parameter val = __BuildControl__control21();
		__ctrl.Add(val);
		Parameter val2 = __BuildControl__control22();
		__ctrl.Add(val2);
		Parameter val3 = __BuildControl__control23();
		__ctrl.Add(val3);
		Parameter val4 = __BuildControl__control24();
		__ctrl.Add(val4);
		Parameter val5 = __BuildControl__control25();
		__ctrl.Add(val5);
	}

	[DebuggerNonUserCode]
	private SqlDataSource __BuildControlSqlDataSource1()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		SqlDataSource val = (SqlDataSource1 = new SqlDataSource());
		((Control)val).ID = "SqlDataSource1";
		val.DeleteCommand = "DELETE FROM [ScRanges] WHERE [gId] = @gId";
		val.InsertCommand = "INSERT INTO [ScRanges] ([scHigh], [scLow], [inf], [rpt]) VALUES (@scHigh, @scLow, @inf, @rpt)";
		val.SelectCommand = "SELECT ResultRef.Result AS R1, ResultRef_1.Result AS R2, ResultRef.MedScale AS MS1, ResultRef.DocScale AS DS1, ResultRef.DocLow, ResultRef.DocHigh, ResultRef.DocOpt, ResultRef.MedLow, ResultRef.MedHigh, ResultRef.Medopt, TestRef.Category, TestRef.testName, TestRef.testAbrev, ResultRef_1.MedScale AS MS2, ResultRef_1.DocScale AS DS2, ScRanges.inf FROM ResultRef INNER JOIN ResultRef AS ResultRef_1 ON ResultRef.TestAbrev = ResultRef_1.TestAbrev INNER JOIN TestRef ON ResultRef.TestAbrev = TestRef.testAbrev INNER JOIN ScRanges ON ResultRef.MedScale >= ScRanges.scLow AND ResultRef.MedScale < ScRanges.scHigh WHERE (ResultRef.Testid = @t1) AND (ResultRef_1.Testid = @t2) AND (ScRanges.rpt = N'full') ORDER BY ABS(ResultRef1.docScale) DESC";
		val.UpdateCommand = "UPDATE [ScRanges] SET [scHigh] = @scHigh, [scLow] = @scLow, [inf] = @inf, [rpt] = @rpt WHERE [gId] = @gId";
		__BuildControl__control10(val.SelectParameters);
		__BuildControl__control13(val.DeleteParameters);
		__BuildControl__control15(val.InsertParameters);
		__BuildControl__control20(val.UpdateParameters);
		val.ConnectionString = Convert.ToString(ConnectionStringsExpressionBuilder.GetConnectionString("nazdiltarinConnectionString"), CultureInfo.CurrentCulture);
		val.ProviderName = Convert.ToString(ConnectionStringsExpressionBuilder.GetConnectionStringProviderName("LocalSqlServer"), CultureInfo.CurrentCulture);
		return val;
	}

	[DebuggerNonUserCode]
	private HtmlForm __BuildControlform1()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Expected Obj, but got Unknown
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Expected Obj, but got Unknown
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		//IL_006c: Expected Obj, but got Unknown
		HtmlForm val = (form1 = new HtmlForm());
		((Control)val).ID = "form1";
		IParserAccessor val3 = (IParserAccessor)(object)val;
		val3.AddParsedSubObject((object)new LiteralControl("\r\n    <div>\r\n    \r\n        "));
		GridView val4 = __BuildControlGridView1();
		val3.AddParsedSubObject((object)val4);
		val3.AddParsedSubObject((object)new LiteralControl("\r\n        "));
		SqlDataSource val5 = __BuildControlSqlDataSource1();
		val3.AddParsedSubObject((object)val5);
		val3.AddParsedSubObject((object)new LiteralControl("\r\n    \r\n    </div>\r\n    "));
		return val;
	}

	[DebuggerNonUserCode]
	private void __BuildControlTree(cr_default_aspx __ctrl)
	{
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Expected Obj, but got Unknown
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Expected Obj, but got Unknown
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0054: Expected Obj, but got Unknown
		((Page)this).InitializeCulture();
		((IParserAccessor)__ctrl).AddParsedSubObject((object)new LiteralControl("\r\n\r\n<!DOCTYPE html PUBLIC \"-//W3C//DTD XHTML 1.0 Transitional//EN\" \"http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd\">\r\n\r\n<html xmlns=\"http://www.w3.org/1999/xhtml\">\r\n"));
		HtmlHead val = __BuildControl__control2();
		((IParserAccessor)__ctrl).AddParsedSubObject((object)val);
		((IParserAccessor)__ctrl).AddParsedSubObject((object)new LiteralControl("\r\n<body>\r\n    "));
		HtmlForm val2 = __BuildControlform1();
		((IParserAccessor)__ctrl).AddParsedSubObject((object)val2);
		((IParserAccessor)__ctrl).AddParsedSubObject((object)new LiteralControl("\r\n</body>\r\n</html>\r\n"));
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
		return 363306266;
	}

	[DebuggerNonUserCode]
	public override void ProcessRequest(HttpContext context)
	{
		((Page)this).ProcessRequest(context);
	}
}
