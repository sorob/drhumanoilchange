using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Web;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;

namespace ASP;

[CompilerGlobalScope]
public class timekeeper_aspx : Timekeeper
{
	private static bool __initialized;

	private static object __fileDependencies;

	protected override bool SupportAutoEvents => false;

	[DebuggerNonUserCode]
	public timekeeper_aspx()
	{
		((TemplateControl)this).AppRelativeVirtualPath = "~/Timekeeper.aspx";
		if (!__initialized)
		{
			__fileDependencies = RuntimeHelpers.GetObjectValue(((Page)this).GetWrappedFileDependencies(new string[2] { "~/Timekeeper.aspx", "~/Timekeeper.aspx.vb" }));
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
		val2.AddParsedSubObject((object)new LiteralControl("time keeper"));
		return val;
	}

	[DebuggerNonUserCode]
	private HtmlMeta __BuildControl__control4()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		HtmlMeta val = new HtmlMeta();
		((IAttributeAccessor)val).SetAttribute("HTTP-EQUIV", "REFRESH");
		val.Content = "120";
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
		HtmlMeta val4 = __BuildControl__control4();
		val3.AddParsedSubObject((object)val4);
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
	private HtmlForm __BuildControlform1()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Expected Obj, but got Unknown
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Expected Obj, but got Unknown
		HtmlForm val = (form1 = new HtmlForm());
		((Control)val).ID = "form1";
		IParserAccessor val3 = (IParserAccessor)(object)val;
		val3.AddParsedSubObject((object)new LiteralControl("\r\n    <div>\r\n        "));
		Label val4 = __BuildControlLabel1();
		val3.AddParsedSubObject((object)val4);
		val3.AddParsedSubObject((object)new LiteralControl("</div>\r\n    "));
		return val;
	}

	[DebuggerNonUserCode]
	private void __BuildControlTree(timekeeper_aspx __ctrl)
	{
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Expected Obj, but got Unknown
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Expected Obj, but got Unknown
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		//IL_005f: Expected Obj, but got Unknown
		((Page)__ctrl).Theme = "Theme1";
		((Page)this).InitializeCulture();
		((IParserAccessor)__ctrl).AddParsedSubObject((object)new LiteralControl("\r\n\r\n<!DOCTYPE html PUBLIC \"-//W3C//DTD XHTML 1.0 Transitional//EN\" \"http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd\">\r\n\r\n<html xmlns=\"http://www.w3.org/1999/xhtml\" >\r\n"));
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
		return -1241485440;
	}

	[DebuggerNonUserCode]
	public override void ProcessRequest(HttpContext context)
	{
		((Page)this).ProcessRequest(context);
	}
}
