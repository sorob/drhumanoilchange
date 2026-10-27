using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ASP;

[CompilerGlobalScope]
public class p6psych_aspx : p6psych
{
	private static bool __initialized;

	private static object __stringResource;

	private static object __fileDependencies;

	protected override bool SupportAutoEvents => false;

	[DebuggerNonUserCode]
	public p6psych_aspx()
	{
		((TemplateControl)this).AppRelativeVirtualPath = "~/p6psych.aspx";
		if (!__initialized)
		{
			__stringResource = RuntimeHelpers.GetObjectValue(((TemplateControl)this).ReadStringResource());
			__fileDependencies = RuntimeHelpers.GetObjectValue(((Page)this).GetWrappedFileDependencies(new string[4] { "~/p6psych.aspx", "~/master1.master", "~/master1.master.vb", "~/p6psych.aspx.vb" }));
			__initialized = true;
		}
		((Page)this).Server.ScriptTimeout = 30000000;
	}

	[DebuggerNonUserCode]
	private Image __BuildControlImage1()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Image val = (Image1 = new Image());
		((Control)val).ApplyStyleSheetSkin((Page)(object)this);
		((Control)val).ID = "Image1";
		val.ImageUrl = "~/images/P6-Psych.gif";
		return val;
	}

	[DebuggerNonUserCode]
	private ImageButton __BuildControlImageButton1()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		ImageButton val = (ImageButton1 = new ImageButton());
		((Control)val).ApplyStyleSheetSkin((Page)(object)this);
		((Control)val).ID = "ImageButton1";
		((Image)val).ImageUrl = "~/images/download.gif";
		return val;
	}

	[DebuggerNonUserCode]
	private ImageButton __BuildControlImageButton2()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		ImageButton val = (ImageButton2 = new ImageButton());
		((Control)val).ApplyStyleSheetSkin((Page)(object)this);
		((Control)val).ID = "ImageButton2";
		((Image)val).ImageUrl = "~/images/buy.gif";
		return val;
	}

	[DebuggerNonUserCode]
	private View __BuildControlView1()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Expected Obj, but got Unknown
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Expected Obj, but got Unknown
		//IL_0087: Unknown result type (might be due to invalid IL or missing references)
		//IL_0091: Expected Obj, but got Unknown
		View val = (View1 = new View());
		((Control)val).ID = "View1";
		IParserAccessor val3 = (IParserAccessor)(object)val;
		val3.AddParsedSubObject((object)new LiteralControl("\r\n    <table border=\"0\" style=\"width: 100%; height: 100%\">\r\n        <tr>\r\n            <td width=\"100\">\r\n                "));
		Image val4 = __BuildControlImage1();
		val3.AddParsedSubObject((object)val4);
		val3.AddParsedSubObject((object)((TemplateControl)this).CreateResourceBasedLiteralControl(0, 3221, false));
		ImageButton val5 = __BuildControlImageButton1();
		val3.AddParsedSubObject((object)val5);
		val3.AddParsedSubObject((object)new LiteralControl("\r\n                "));
		ImageButton val6 = __BuildControlImageButton2();
		val3.AddParsedSubObject((object)val6);
		val3.AddParsedSubObject((object)new LiteralControl("&nbsp;\r\n            </td>\r\n        </tr>\r\n    </table>\r\n        "));
		return val;
	}

	[DebuggerNonUserCode]
	private MultiView __BuildControlMultiView1()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Expected Obj, but got Unknown
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0056: Expected Obj, but got Unknown
		MultiView val = (MultiView1 = new MultiView());
		((Control)val).TemplateControl = (TemplateControl)(object)this;
		((Control)val).ID = "MultiView1";
		val.ActiveViewIndex = 0;
		IParserAccessor val3 = (IParserAccessor)(object)val;
		val3.AddParsedSubObject((object)new LiteralControl("\r\n        "));
		View val4 = __BuildControlView1();
		val3.AddParsedSubObject((object)val4);
		val3.AddParsedSubObject((object)new LiteralControl("\r\n    "));
		return val;
	}

	[DebuggerNonUserCode]
	private void __BuildControlContent1(Control __ctrl)
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
	private void __BuildControlTree(p6psych_aspx __ctrl)
	{
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Expected Obj, but got Unknown
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Expected Obj, but got Unknown
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0056: Expected Obj, but got Unknown
		((Page)__ctrl).MasterPageFile = "~/master1.master";
		((Page)__ctrl).Title = "Human Oil Change";
		((Page)__ctrl).Theme = "Theme1";
		((Page)this).InitializeCulture();
		((Page)this).AddContentTemplate("ContentPlaceHolder1", (ITemplate)new CompiledTemplateBuilder((BuildTemplateMethod)__BuildControlContent1));
		((IParserAccessor)__ctrl).AddParsedSubObject((object)new LiteralControl("\r\n\r\n"));
	}

	[DebuggerNonUserCode]
	protected override void FrameworkInitialize()
	{
		((Page)this).StyleSheetTheme = "Theme1";
		((Page)this).FrameworkInitialize();
		((TemplateControl)this).SetStringResourcePointer(RuntimeHelpers.GetObjectValue(__stringResource), 0);
		__BuildControlTree(this);
		((Page)this).AddWrappedFileDependencies(RuntimeHelpers.GetObjectValue(__fileDependencies));
		((Page)this).Request.ValidateInput();
	}

	[DebuggerNonUserCode]
	public override int GetTypeHashCode()
	{
		return 74635011;
	}

	[DebuggerNonUserCode]
	public override void ProcessRequest(HttpContext context)
	{
		((Page)this).ProcessRequest(context);
	}
}
