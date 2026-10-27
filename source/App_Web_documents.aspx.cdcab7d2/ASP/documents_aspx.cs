using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Web;
using System.Web.UI;
using System.Web.UI.HtmlControls;

namespace ASP;

[CompilerGlobalScope]
public class documents_aspx : Doc
{
	private static bool __initialized;

	private static object __fileDependencies;

	protected override bool SupportAutoEvents => false;

	[DebuggerNonUserCode]
	public documents_aspx()
	{
		((TemplateControl)this).AppRelativeVirtualPath = "~/Documents.aspx";
		if (!__initialized)
		{
			__fileDependencies = RuntimeHelpers.GetObjectValue(((Page)this).GetWrappedFileDependencies(new string[4] { "~/Documents.aspx", "~/master1.master", "~/master1.master.vb", "~/Documents.aspx.vb" }));
			__initialized = true;
		}
		((Page)this).Server.ScriptTimeout = 30000000;
	}

	[DebuggerNonUserCode]
	private HtmlGenericControl __BuildControlIFRAME1()
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected Obj, but got Unknown
		HtmlGenericControl val = (IFRAME1 = new HtmlGenericControl("iframe"));
		((Control)val).TemplateControl = (TemplateControl)(object)this;
		((Control)val).ID = "IFRAME1";
		((IAttributeAccessor)val).SetAttribute("allowtransparency", "");
		((IAttributeAccessor)val).SetAttribute("frameborder", "0");
		((IAttributeAccessor)val).SetAttribute("marginheight", "0");
		((IAttributeAccessor)val).SetAttribute("marginwidth", "0");
		((IAttributeAccessor)val).SetAttribute("style", "width: 577px; height: 387px");
		((IAttributeAccessor)val).SetAttribute("src", "Articles.aspx");
		return val;
	}

	[DebuggerNonUserCode]
	private void __BuildControlContent1(Control __ctrl)
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Expected Obj, but got Unknown
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Expected Obj, but got Unknown
		((IParserAccessor)__ctrl).AddParsedSubObject((object)new LiteralControl("\r\n    <table border=\"0\" cellpadding=\"0\" cellspacing=\"0\" style=\"width: 100%\">\r\n        <tr>\r\n            <td align=\"center\">\r\n                "));
		HtmlGenericControl val = __BuildControlIFRAME1();
		((IParserAccessor)__ctrl).AddParsedSubObject((object)val);
		((IParserAccessor)__ctrl).AddParsedSubObject((object)new LiteralControl("\r\n            </td>\r\n        </tr>\r\n    </table>\r\n"));
	}

	[DebuggerNonUserCode]
	private void __BuildControlTree(documents_aspx __ctrl)
	{
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Expected Obj, but got Unknown
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Expected Obj, but got Unknown
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Expected Obj, but got Unknown
		((Page)__ctrl).MasterPageFile = "~/master1.master";
		((Page)__ctrl).Title = "Human Oil Change";
		((Page)this).InitializeCulture();
		((Page)this).AddContentTemplate("ContentPlaceHolder1", (ITemplate)new CompiledTemplateBuilder((BuildTemplateMethod)__BuildControlContent1));
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
		return 1331355034;
	}

	[DebuggerNonUserCode]
	public override void ProcessRequest(HttpContext context)
	{
		((Page)this).ProcessRequest(context);
	}
}
