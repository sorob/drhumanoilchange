using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Web;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using CrystalDecisions.Web;

namespace ASP;

[CompilerGlobalScope]
public class cr_getreport_aspx : GetReport
{
	private static bool __initialized;

	private static object __stringResource;

	private static object __fileDependencies;

	protected override bool SupportAutoEvents => false;

	[DebuggerNonUserCode]
	public cr_getreport_aspx()
	{
		((TemplateControl)this).AppRelativeVirtualPath = "~/CR/GetReport.aspx";
		if (!__initialized)
		{
			__stringResource = RuntimeHelpers.GetObjectValue(((TemplateControl)this).ReadStringResource());
			__fileDependencies = RuntimeHelpers.GetObjectValue(((Page)this).GetWrappedFileDependencies(new string[2] { "~/CR/GetReport.aspx", "~/CR/GetReport.aspx.vb" }));
			__initialized = true;
		}
		((Page)this).Server.ScriptTimeout = 30000000;
	}

	[DebuggerNonUserCode]
	private HtmlTitle __BuildControl__control2()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Expected Obj, but got Unknown
		HtmlTitle val = new HtmlTitle();
		IParserAccessor val2 = (IParserAccessor)(object)val;
		val2.AddParsedSubObject((object)new LiteralControl("Human Oil Change"));
		return val;
	}

	[DebuggerNonUserCode]
	private HtmlHead __BuildControlHead1()
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected Obj, but got Unknown
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Expected Obj, but got Unknown
		HtmlHead val = (Head1 = new HtmlHead("head"));
		((Control)val).ID = "Head1";
		HtmlTitle val3 = __BuildControl__control2();
		IParserAccessor val4 = (IParserAccessor)(object)val;
		val4.AddParsedSubObject((object)val3);
		val4.AddParsedSubObject((object)new LiteralControl("\r\n    <style type=\"text/css\">\r\n        .style1\r\n        {\r\n            width: 100%;\r\n        }\r\n    </style>\r\n"));
		return val;
	}

	[DebuggerNonUserCode]
	private Label __BuildControlLabel1()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Label val = (Label1 = new Label());
		((Control)val).ApplyStyleSheetSkin((Page)(object)this);
		((Control)val).ID = "Label1";
		val.Text = "Label";
		return val;
	}

	[DebuggerNonUserCode]
	private ScriptManager __BuildControlScriptManager1()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		ScriptManager val = (ScriptManager1 = new ScriptManager());
		((Control)val).ID = "ScriptManager1";
		return val;
	}

	[DebuggerNonUserCode]
	private LinkButton __BuildControlLinkButton1()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Expected Obj, but got Unknown
		LinkButton val = (LinkButton1 = new LinkButton());
		((Control)val).ApplyStyleSheetSkin((Page)(object)this);
		((Control)val).ID = "LinkButton1";
		((Control)val).Visible = false;
		IParserAccessor val3 = (IParserAccessor)(object)val;
		val3.AddParsedSubObject((object)new LiteralControl("PDF"));
		return val;
	}

	[DebuggerNonUserCode]
	private LinkButton __BuildControlLinkButton2()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Expected Obj, but got Unknown
		LinkButton val = (LinkButton2 = new LinkButton());
		((Control)val).ApplyStyleSheetSkin((Page)(object)this);
		((Control)val).ID = "LinkButton2";
		IParserAccessor val3 = (IParserAccessor)(object)val;
		val3.AddParsedSubObject((object)new LiteralControl("Complete Report"));
		return val;
	}

	[DebuggerNonUserCode]
	private LinkButton __BuildControlLinkButton3()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Expected Obj, but got Unknown
		LinkButton val = (LinkButton3 = new LinkButton());
		((Control)val).ApplyStyleSheetSkin((Page)(object)this);
		((Control)val).ID = "LinkButton3";
		IParserAccessor val3 = (IParserAccessor)(object)val;
		val3.AddParsedSubObject((object)new LiteralControl("Worked-on Report"));
		return val;
	}

	[DebuggerNonUserCode]
	private CrystalReportViewer __BuildControlCrystalReportViewer1()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		CrystalReportViewer val = (CrystalReportViewer1 = new CrystalReportViewer());
		((Control)val).TemplateControl = (TemplateControl)(object)this;
		((Control)val).ApplyStyleSheetSkin((Page)(object)this);
		((Control)val).ID = "CrystalReportViewer1";
		((CrystalReportViewerBase)val).AutoDataBind = true;
		Unit height = new Unit(947.0, (UnitType)1);
		((WebControl)val).Height = height;
		height = new Unit(845.0, (UnitType)1);
		((WebControl)val).Width = height;
		val.HasCrystalLogo = false;
		((CrystalReportViewerBase)val).ReuseParameterValuesOnRefresh = true;
		return val;
	}

	[DebuggerNonUserCode]
	private void __BuildControl__control3(Control __ctrl)
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Expected Obj, but got Unknown
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Expected Obj, but got Unknown
		((IParserAccessor)__ctrl).AddParsedSubObject((object)new LiteralControl("\r\n        "));
		CrystalReportViewer val = __BuildControlCrystalReportViewer1();
		((IParserAccessor)__ctrl).AddParsedSubObject((object)val);
		((IParserAccessor)__ctrl).AddParsedSubObject((object)new LiteralControl("\r\n     \r\n               \r\n            "));
	}

	[DebuggerNonUserCode]
	private UpdatePanel __BuildControlUpdatePanel1()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Expected Obj, but got Unknown
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Expected Obj, but got Unknown
		UpdatePanel val = (UpdatePanel1 = new UpdatePanel());
		val.ContentTemplate = (ITemplate)new CompiledTemplateBuilder((BuildTemplateMethod)__BuildControl__control3);
		((Control)val).ID = "UpdatePanel1";
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
		//IL_0087: Unknown result type (might be due to invalid IL or missing references)
		//IL_0091: Expected Obj, but got Unknown
		//IL_00a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b3: Expected Obj, but got Unknown
		//IL_00f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fe: Expected Obj, but got Unknown
		HtmlForm val = (form1 = new HtmlForm());
		((Control)val).ID = "form1";
		IParserAccessor val3 = (IParserAccessor)(object)val;
		val3.AddParsedSubObject((object)new LiteralControl("\r\n    <div>\r\n        "));
		Label val4 = __BuildControlLabel1();
		val3.AddParsedSubObject((object)val4);
		val3.AddParsedSubObject((object)new LiteralControl("\r\n        "));
		ScriptManager val5 = __BuildControlScriptManager1();
		val3.AddParsedSubObject((object)val5);
		val3.AddParsedSubObject((object)((TemplateControl)this).CreateResourceBasedLiteralControl(0, 280, true));
		LinkButton val6 = __BuildControlLinkButton1();
		val3.AddParsedSubObject((object)val6);
		val3.AddParsedSubObject((object)new LiteralControl("\r\n                </td>\r\n                <td width=\"30\">\r\n                    &nbsp;</td>\r\n                <td>\r\n                    "));
		LinkButton val7 = __BuildControlLinkButton2();
		val3.AddParsedSubObject((object)val7);
		val3.AddParsedSubObject((object)new LiteralControl("\r\n                </td>\r\n                <td>\r\n                    "));
		LinkButton val8 = __BuildControlLinkButton3();
		val3.AddParsedSubObject((object)val8);
		val3.AddParsedSubObject((object)((TemplateControl)this).CreateResourceBasedLiteralControl(280, 354, true));
		UpdatePanel val9 = __BuildControlUpdatePanel1();
		val3.AddParsedSubObject((object)val9);
		val3.AddParsedSubObject((object)new LiteralControl("\r\n        <br />\r\n        <br />\r\n    \r\n    </div>\r\n    "));
		return val;
	}

	[DebuggerNonUserCode]
	private void __BuildControlTree(cr_getreport_aspx __ctrl)
	{
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Expected Obj, but got Unknown
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Expected Obj, but got Unknown
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0054: Expected Obj, but got Unknown
		((Page)this).InitializeCulture();
		((IParserAccessor)__ctrl).AddParsedSubObject((object)new LiteralControl("\r\n\r\n<html xmlns=\"http://www.w3.org/1999/xhtml\" >\r\n"));
		HtmlHead val = __BuildControlHead1();
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
		((TemplateControl)this).SetStringResourcePointer(RuntimeHelpers.GetObjectValue(__stringResource), 0);
		__BuildControlTree(this);
		((Page)this).AddWrappedFileDependencies(RuntimeHelpers.GetObjectValue(__fileDependencies));
		((Page)this).Request.ValidateInput();
	}

	[DebuggerNonUserCode]
	public override int GetTypeHashCode()
	{
		return 1134557974;
	}

	[DebuggerNonUserCode]
	public override void ProcessRequest(HttpContext context)
	{
		((Page)this).ProcessRequest(context);
	}
}
