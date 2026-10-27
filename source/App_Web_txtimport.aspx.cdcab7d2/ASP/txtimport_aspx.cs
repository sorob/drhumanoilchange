using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Web;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;

namespace ASP;

[CompilerGlobalScope]
public class txtimport_aspx : txtimport
{
	private static bool __initialized;

	private static object __fileDependencies;

	protected override bool SupportAutoEvents => false;

	[DebuggerNonUserCode]
	public txtimport_aspx()
	{
		((TemplateControl)this).AppRelativeVirtualPath = "~/txtimport.aspx";
		if (!__initialized)
		{
			__fileDependencies = RuntimeHelpers.GetObjectValue(((Page)this).GetWrappedFileDependencies(new string[2] { "~/txtimport.aspx", "~/txtimport.aspx.vb" }));
			__initialized = true;
		}
		((Page)this).Server.ScriptTimeout = 30000000;
	}

	[DebuggerNonUserCode]
	private HtmlTitle __BuildControl__control3()
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
	private FileUpload __BuildControlFileUpload1()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		FileUpload val = (FileUpload1 = new FileUpload());
		((Control)val).ApplyStyleSheetSkin((Page)(object)this);
		((Control)val).ID = "FileUpload1";
		return val;
	}

	[DebuggerNonUserCode]
	private LinkButton __BuildControlLinkButton1()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Expected Obj, but got Unknown
		LinkButton val = (LinkButton1 = new LinkButton());
		((Control)val).ApplyStyleSheetSkin((Page)(object)this);
		((Control)val).ID = "LinkButton1";
		IParserAccessor val3 = (IParserAccessor)(object)val;
		val3.AddParsedSubObject((object)new LiteralControl("Submit"));
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
		val3.AddParsedSubObject((object)new LiteralControl("\r\n    <div>\r\n        "));
		FileUpload val4 = __BuildControlFileUpload1();
		val3.AddParsedSubObject((object)val4);
		val3.AddParsedSubObject((object)new LiteralControl("\r\n        "));
		LinkButton val5 = __BuildControlLinkButton1();
		val3.AddParsedSubObject((object)val5);
		val3.AddParsedSubObject((object)new LiteralControl("</div>\r\n    "));
		return val;
	}

	[DebuggerNonUserCode]
	private void __BuildControlTree(txtimport_aspx __ctrl)
	{
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Expected Obj, but got Unknown
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Expected Obj, but got Unknown
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0054: Expected Obj, but got Unknown
		((Page)this).InitializeCulture();
		((IParserAccessor)__ctrl).AddParsedSubObject((object)new LiteralControl("\r\n\r\n<!DOCTYPE html PUBLIC \"-//W3C//DTD XHTML 1.0 Transitional//EN\" \"http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd\">\r\n\r\n<html xmlns=\"http://www.w3.org/1999/xhtml\" >\r\n"));
		HtmlHead val = __BuildControl__control2();
		((IParserAccessor)__ctrl).AddParsedSubObject((object)val);
		((IParserAccessor)__ctrl).AddParsedSubObject((object)new LiteralControl("\r\n<body bgcolor=DimGray>\r\n    "));
		HtmlForm val2 = __BuildControlform1();
		((IParserAccessor)__ctrl).AddParsedSubObject((object)val2);
		((IParserAccessor)__ctrl).AddParsedSubObject((object)new LiteralControl("\r\n</body>\r\n</html>\r\n"));
	}

	[DebuggerNonUserCode]
	protected override void FrameworkInitialize()
	{
		((Page)this).StyleSheetTheme = "Theme1";
		((Page)this).FrameworkInitialize();
		__BuildControlTree(this);
		((Page)this).AddWrappedFileDependencies(RuntimeHelpers.GetObjectValue(__fileDependencies));
		((Page)this).Request.ValidateInput();
	}

	[DebuggerNonUserCode]
	public override int GetTypeHashCode()
	{
		return -380685854;
	}

	[DebuggerNonUserCode]
	public override void ProcessRequest(HttpContext context)
	{
		((Page)this).ProcessRequest(context);
	}
}
