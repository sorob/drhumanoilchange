using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Sahil.WebControls;

namespace ASP;

[CompilerGlobalScope]
public class wat_test_aspx : WAT_Test
{
	private static bool __initialized;

	private static object __stringResource;

	private static object __fileDependencies;

	protected override bool SupportAutoEvents => false;

	[DebuggerNonUserCode]
	public wat_test_aspx()
	{
		((TemplateControl)this).AppRelativeVirtualPath = "~/WAT/Test.aspx";
		if (!__initialized)
		{
			__stringResource = RuntimeHelpers.GetObjectValue(((TemplateControl)this).ReadStringResource());
			__fileDependencies = RuntimeHelpers.GetObjectValue(((Page)this).GetWrappedFileDependencies(new string[4] { "~/WAT/Test.aspx", "~/master1.master", "~/master1.master.vb", "~/WAT/Test.aspx.vb" }));
			__initialized = true;
		}
		((Page)this).Server.ScriptTimeout = 30000000;
	}

	[DebuggerNonUserCode]
	private Label __BuildControlLabel1()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		Label val = (Label1 = new Label());
		((Control)val).TemplateControl = (TemplateControl)(object)this;
		((Control)val).ApplyStyleSheetSkin((Page)(object)this);
		((Control)val).ID = "Label1";
		((WebControl)val).ForeColor = Color.White;
		((WebControl)val).Font.Size = FontUnit.XLarge;
		val.Text = "Label";
		return val;
	}

	[DebuggerNonUserCode]
	private Button __BuildControlButton1()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ac: Unknown result type (might be due to invalid IL or missing references)
		Button val = (Button1 = new Button());
		((Control)val).TemplateControl = (TemplateControl)(object)this;
		((Control)val).ApplyStyleSheetSkin((Page)(object)this);
		((Control)val).ID = "Button1";
		((WebControl)val).Font.Bold = true;
		Unit width = new Unit(180.0, (UnitType)1);
		((WebControl)val).Width = width;
		((WebControl)val).ForeColor = SystemColors.Desktop;
		((WebControl)val).Font.Size = FontUnit.Medium;
		val.Text = "Button";
		((WebControl)val).Font.Strikeout = false;
		((WebControl)val).BackColor = Color.LightSteelBlue;
		((WebControl)val).BorderColor = Color.DodgerBlue;
		((WebControl)val).BorderStyle = (BorderStyle)9;
		width = new Unit(1.0, (UnitType)1);
		((WebControl)val).BorderWidth = width;
		val.Click += Button1_Click;
		return val;
	}

	[DebuggerNonUserCode]
	private Button __BuildControlButton2()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ac: Unknown result type (might be due to invalid IL or missing references)
		Button val = (Button2 = new Button());
		((Control)val).TemplateControl = (TemplateControl)(object)this;
		((Control)val).ApplyStyleSheetSkin((Page)(object)this);
		((Control)val).ID = "Button2";
		((WebControl)val).Font.Bold = true;
		Unit width = new Unit(180.0, (UnitType)1);
		((WebControl)val).Width = width;
		((WebControl)val).ForeColor = SystemColors.Desktop;
		((WebControl)val).Font.Size = FontUnit.Medium;
		val.Text = "Button";
		((WebControl)val).Font.Strikeout = false;
		((WebControl)val).BackColor = Color.LightSteelBlue;
		((WebControl)val).BorderColor = Color.DodgerBlue;
		((WebControl)val).BorderStyle = (BorderStyle)9;
		width = new Unit(1.0, (UnitType)1);
		((WebControl)val).BorderWidth = width;
		val.Click += Button2_Click;
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
	private ProgressBar __BuildControlProgressBar1()
	{
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		ProgressBar progressBar = (ProgressBar1 = new ProgressBar());
		((Control)progressBar).TemplateControl = (TemplateControl)(object)this;
		((Control)progressBar).ApplyStyleSheetSkin((Page)(object)this);
		((Control)progressBar).ID = "ProgressBar1";
		Unit width = new Unit(150.0, (UnitType)1);
		((WebControl)progressBar).Width = width;
		progressBar.Maximum = 80;
		progressBar.Value = 1;
		progressBar.Minimum = 0;
		return progressBar;
	}

	[DebuggerNonUserCode]
	private void __BuildControl__control2(Control __ctrl)
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected Obj, but got Unknown
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Expected Obj, but got Unknown
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0054: Expected Obj, but got Unknown
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Expected Obj, but got Unknown
		//IL_008a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0094: Expected Obj, but got Unknown
		//IL_00ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b6: Expected Obj, but got Unknown
		((IParserAccessor)__ctrl).AddParsedSubObject((object)new LiteralControl("\r\n<TABLE id=\"table1\" cellSpacing=0 cellPadding=5 width=160 align=center border=0><TBODY><TR><TD align=center colSpan=2>"));
		Label val = __BuildControlLabel1();
		((IParserAccessor)__ctrl).AddParsedSubObject((object)val);
		((IParserAccessor)__ctrl).AddParsedSubObject((object)new LiteralControl(" </TD></TR><TR><TD>"));
		Button val2 = __BuildControlButton1();
		((IParserAccessor)__ctrl).AddParsedSubObject((object)val2);
		((IParserAccessor)__ctrl).AddParsedSubObject((object)new LiteralControl(" </TD><TD>"));
		Button val3 = __BuildControlButton2();
		((IParserAccessor)__ctrl).AddParsedSubObject((object)val3);
		((IParserAccessor)__ctrl).AddParsedSubObject((object)new LiteralControl(" </TD></TR><TR><TD>&nbsp; </TD><TD></TD></TR><TR><TD align=left colSpan=2>"));
		Label val4 = __BuildControlLabel2();
		((IParserAccessor)__ctrl).AddParsedSubObject((object)val4);
		((IParserAccessor)__ctrl).AddParsedSubObject((object)new LiteralControl("<BR />"));
		ProgressBar progressBar = __BuildControlProgressBar1();
		((IParserAccessor)__ctrl).AddParsedSubObject((object)progressBar);
		((IParserAccessor)__ctrl).AddParsedSubObject((object)new LiteralControl("</TD></TR></TBODY></TABLE>\r\n"));
	}

	[DebuggerNonUserCode]
	private UpdatePanel __BuildControlUpdatePanel2()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Expected Obj, but got Unknown
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Expected Obj, but got Unknown
		UpdatePanel val = (UpdatePanel2 = new UpdatePanel());
		((Control)val).TemplateControl = (TemplateControl)(object)this;
		val.ContentTemplate = (ITemplate)new CompiledTemplateBuilder((BuildTemplateMethod)__BuildControl__control2);
		((Control)val).ID = "UpdatePanel2";
		return val;
	}

	[DebuggerNonUserCode]
	private void __BuildControl__control3(Control __ctrl)
	{
		((IParserAccessor)__ctrl).AddParsedSubObject((object)((TemplateControl)this).CreateResourceBasedLiteralControl(0, 311, true));
	}

	[DebuggerNonUserCode]
	private UpdateProgress __BuildControlUpdateProgress1()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Expected Obj, but got Unknown
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Expected Obj, but got Unknown
		UpdateProgress val = (UpdateProgress1 = new UpdateProgress());
		((Control)val).TemplateControl = (TemplateControl)(object)this;
		val.ProgressTemplate = (ITemplate)new CompiledTemplateBuilder((BuildTemplateMethod)__BuildControl__control3);
		((Control)val).ID = "UpdateProgress1";
		val.AssociatedUpdatePanelID = "UpdatePanel2";
		val.DynamicLayout = true;
		return val;
	}

	[DebuggerNonUserCode]
	private void __BuildControlContent1(Control __ctrl)
	{
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Expected Obj, but got Unknown
		((IParserAccessor)__ctrl).AddParsedSubObject((object)((TemplateControl)this).CreateResourceBasedLiteralControl(311, 269, true));
		UpdatePanel val = __BuildControlUpdatePanel2();
		((IParserAccessor)__ctrl).AddParsedSubObject((object)val);
		((IParserAccessor)__ctrl).AddParsedSubObject((object)((TemplateControl)this).CreateResourceBasedLiteralControl(580, 284, true));
		UpdateProgress val2 = __BuildControlUpdateProgress1();
		((IParserAccessor)__ctrl).AddParsedSubObject((object)val2);
		((IParserAccessor)__ctrl).AddParsedSubObject((object)new LiteralControl("\r\n                        </td>\r\n                    </tr>\r\n                </table>\r\n            </td>\r\n        </tr>\r\n    </table>\r\n"));
	}

	[DebuggerNonUserCode]
	private void __BuildControlTree(wat_test_aspx __ctrl)
	{
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Expected Obj, but got Unknown
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Expected Obj, but got Unknown
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Expected Obj, but got Unknown
		((Page)__ctrl).MasterPageFile = "~/master1.master";
		((Page)__ctrl).Title = "WAT Test";
		((Page)this).InitializeCulture();
		((Page)this).AddContentTemplate("ContentPlaceHolder1", (ITemplate)new CompiledTemplateBuilder((BuildTemplateMethod)__BuildControlContent1));
		((IParserAccessor)__ctrl).AddParsedSubObject((object)new LiteralControl("\r\n"));
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
		return 592130014;
	}

	[DebuggerNonUserCode]
	public override void ProcessRequest(HttpContext context)
	{
		((Page)this).ProcessRequest(context);
	}
}
