using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ASP;

[CompilerGlobalScope]
public class reader_aspx : reader
{
	private static bool __initialized;

	private static object __stringResource;

	private static object __fileDependencies;

	protected override bool SupportAutoEvents => false;

	[DebuggerNonUserCode]
	public reader_aspx()
	{
		((TemplateControl)this).AppRelativeVirtualPath = "~/reader.aspx";
		if (!__initialized)
		{
			__stringResource = RuntimeHelpers.GetObjectValue(((TemplateControl)this).ReadStringResource());
			__fileDependencies = RuntimeHelpers.GetObjectValue(((Page)this).GetWrappedFileDependencies(new string[4] { "~/reader.aspx", "~/master1.master", "~/master1.master.vb", "~/reader.aspx.vb" }));
			__initialized = true;
		}
		((Page)this).Server.ScriptTimeout = 30000000;
	}

	[DebuggerNonUserCode]
	private HyperLink __BuildControlHyperLink1()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		HyperLink val = (HyperLink1 = new HyperLink());
		((Control)val).TemplateControl = (TemplateControl)(object)this;
		((Control)val).ApplyStyleSheetSkin((Page)(object)this);
		((Control)val).ID = "HyperLink1";
		val.ImageUrl = "~/images/spacer.gif";
		return val;
	}

	[DebuggerNonUserCode]
	private Label __BuildControlLabel1()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		Label val = (Label1 = new Label());
		((Control)val).TemplateControl = (TemplateControl)(object)this;
		((Control)val).ApplyStyleSheetSkin((Page)(object)this);
		((Control)val).ID = "Label1";
		((WebControl)val).Font.Size = FontUnit.Large;
		((WebControl)val).ForeColor = Color.FromArgb(64, 64, 64);
		return val;
	}

	[DebuggerNonUserCode]
	private Label __BuildControlLabel2()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Label val = (Label2 = new Label());
		((Control)val).TemplateControl = (TemplateControl)(object)this;
		((Control)val).ApplyStyleSheetSkin((Page)(object)this);
		((Control)val).ID = "Label2";
		return val;
	}

	[DebuggerNonUserCode]
	private void __BuildControlContent1(Control __ctrl)
	{
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Expected Obj, but got Unknown
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Expected Obj, but got Unknown
		((IParserAccessor)__ctrl).AddParsedSubObject((object)((TemplateControl)this).CreateResourceBasedLiteralControl(0, 651, true));
		HyperLink val = __BuildControlHyperLink1();
		((IParserAccessor)__ctrl).AddParsedSubObject((object)val);
		((IParserAccessor)__ctrl).AddParsedSubObject((object)new LiteralControl("</td>\r\n                            <td  style=\"height: 22px\" bgcolor=\"#F0F0F0\">\r\n                                &nbsp;"));
		Label val2 = __BuildControlLabel1();
		((IParserAccessor)__ctrl).AddParsedSubObject((object)val2);
		((IParserAccessor)__ctrl).AddParsedSubObject((object)((TemplateControl)this).CreateResourceBasedLiteralControl(651, 261, true));
		Label val3 = __BuildControlLabel2();
		((IParserAccessor)__ctrl).AddParsedSubObject((object)val3);
		((IParserAccessor)__ctrl).AddParsedSubObject((object)new LiteralControl("</td>\r\n            </tr>\r\n        </table>\r\n    \r\n    </div>\r\n"));
	}

	[DebuggerNonUserCode]
	private void __BuildControlTree(reader_aspx __ctrl)
	{
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Expected Obj, but got Unknown
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Expected Obj, but got Unknown
		((Page)__ctrl).MasterPageFile = "~/master1.master";
		((Page)this).InitializeCulture();
		((Page)this).AddContentTemplate("ContentPlaceHolder1", (ITemplate)new CompiledTemplateBuilder((BuildTemplateMethod)__BuildControlContent1));
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
		return 1870163742;
	}

	[DebuggerNonUserCode]
	public override void ProcessRequest(HttpContext context)
	{
		((Page)this).ProcessRequest(context);
	}
}
