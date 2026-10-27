using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;

namespace ASP;

[CompilerGlobalScope]
public class master1_master : master1
{
	private ITemplate __Template_head;

	private ITemplate __Template_ContentPlaceHolder1;

	private static bool __initialized;

	private static object __stringResource;

	[TemplateInstance(/*Could not decode attribute arguments.*/)]
	[TemplateContainer(typeof(MasterPage))]
	public virtual ITemplate Template_head
	{
		get
		{
			return __Template_head;
		}
		set
		{
			__Template_head = value;
		}
	}

	[TemplateInstance(/*Could not decode attribute arguments.*/)]
	[TemplateContainer(typeof(MasterPage))]
	public virtual ITemplate Template_ContentPlaceHolder1
	{
		get
		{
			return __Template_ContentPlaceHolder1;
		}
		set
		{
			__Template_ContentPlaceHolder1 = value;
		}
	}

	[DebuggerNonUserCode]
	public master1_master()
	{
		((TemplateControl)this).AppRelativeVirtualPath = "~/master1.master";
		if (!__initialized)
		{
			__stringResource = RuntimeHelpers.GetObjectValue(((TemplateControl)this).ReadStringResource());
			__initialized = true;
		}
		((MasterPage)this).ContentPlaceHolders.Add("head");
		((MasterPage)this).ContentPlaceHolders.Add("contentplaceholder1");
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
		val2.AddParsedSubObject((object)new LiteralControl("Mental Stress Tester"));
		return val;
	}

	[DebuggerNonUserCode]
	private HtmlLink __BuildControl__control4()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		HtmlLink val = new HtmlLink();
		val.Href = "App_Themes/Theme1/StyleSheet.css";
		((IAttributeAccessor)val).SetAttribute("rel", "stylesheet");
		((IAttributeAccessor)val).SetAttribute("type", "text/css");
		return val;
	}

	[DebuggerNonUserCode]
	private ContentPlaceHolder __BuildControlhead()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Expected Obj, but got Unknown
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Expected Obj, but got Unknown
		ContentPlaceHolder val = (head = new ContentPlaceHolder());
		((Control)val).ID = "head";
		if (((MasterPage)this).ContentTemplates != null)
		{
			__Template_head = (ITemplate)((MasterPage)this).ContentTemplates["head"];
		}
		if (__Template_head != null)
		{
			((MasterPage)this).InstantiateInContentPlaceHolder((Control)(object)val, __Template_head);
		}
		else
		{
			IParserAccessor val3 = (IParserAccessor)(object)val;
			val3.AddParsedSubObject((object)new LiteralControl("\r\n    "));
		}
		return val;
	}

	[DebuggerNonUserCode]
	private HtmlHead __BuildControl__control2()
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected Obj, but got Unknown
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Expected Obj, but got Unknown
		HtmlHead val = new HtmlHead("head");
		HtmlTitle val2 = __BuildControl__control3();
		IParserAccessor val3 = (IParserAccessor)(object)val;
		val3.AddParsedSubObject((object)val2);
		HtmlLink val4 = __BuildControl__control4();
		val3.AddParsedSubObject((object)val4);
		val3.AddParsedSubObject((object)new LiteralControl("\r\n    <script language=\"javascript\">        AC_FL_RunContent = 0;</script>\r\n    <script src=\"AC_RunActiveContent.js\" language=\"javascript\"></script>\r\n    <script type=\"text/javascript\" src=\"swfobject.js\"></script>\r\n    "));
		ContentPlaceHolder val5 = __BuildControlhead();
		val3.AddParsedSubObject((object)val5);
		return val;
	}

	[DebuggerNonUserCode]
	private ServiceReference __BuildControl__control6()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		ServiceReference val = new ServiceReference();
		val.Path = "AutoComplete.asmx";
		return val;
	}

	[DebuggerNonUserCode]
	private void __BuildControl__control5(ServiceReferenceCollection __ctrl)
	{
		ServiceReference item = __BuildControl__control6();
		((Collection<ServiceReference>)(object)__ctrl).Add(item);
	}

	[DebuggerNonUserCode]
	private ScriptManager __BuildControlScriptManager1()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		ScriptManager val = (ScriptManager1 = new ScriptManager());
		((Control)val).ID = "ScriptManager1";
		__BuildControl__control5(val.Services);
		return val;
	}

	[DebuggerNonUserCode]
	private Image __BuildControlImage3()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Image val = (Image3 = new Image());
		((Control)val).ApplyStyleSheetSkin(((Control)this).Page);
		((Control)val).ID = "Image3";
		val.ImageUrl = "~/images/human-oil-change.gif";
		return val;
	}

	[DebuggerNonUserCode]
	private SiteMapDataSource __BuildControlSiteMapDS1()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		SiteMapDataSource val = (SiteMapDS1 = new SiteMapDataSource());
		((Control)val).ID = "SiteMapDS1";
		val.ShowStartingNode = false;
		return val;
	}

	[DebuggerNonUserCode]
	private void __BuildControl__control7(MenuItemStyle __ctrl)
	{
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		Unit horizontalPadding = new Unit(5.0, (UnitType)1);
		__ctrl.HorizontalPadding = horizontalPadding;
		horizontalPadding = new Unit(2.0, (UnitType)1);
		__ctrl.VerticalPadding = horizontalPadding;
		((Style)__ctrl).ForeColor = Color.FromArgb(102, 153, 255);
	}

	[DebuggerNonUserCode]
	private void __BuildControl__control8(Style __ctrl)
	{
		__ctrl.BackColor = Color.LightSteelBlue;
		__ctrl.ForeColor = Color.Black;
	}

	[DebuggerNonUserCode]
	private void __BuildControl__control9(SubMenuStyle __ctrl)
	{
		((Style)__ctrl).BackColor = Color.FromArgb(247, 246, 243);
	}

	[DebuggerNonUserCode]
	private void __BuildControl__control10(MenuItemStyle __ctrl)
	{
		((Style)__ctrl).BackColor = Color.FromArgb(93, 123, 157);
		((Style)__ctrl).ForeColor = Color.White;
	}

	[DebuggerNonUserCode]
	private void __BuildControl__control11(MenuItemStyle __ctrl)
	{
		((Style)__ctrl).BackColor = Color.FromArgb(93, 123, 157);
		((Style)__ctrl).ForeColor = Color.White;
	}

	[DebuggerNonUserCode]
	private void __BuildControl__control12(MenuItemStyle __ctrl)
	{
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		Unit horizontalPadding = new Unit(5.0, (UnitType)1);
		__ctrl.HorizontalPadding = horizontalPadding;
		horizontalPadding = new Unit(2.0, (UnitType)1);
		__ctrl.VerticalPadding = horizontalPadding;
		((Style)__ctrl).ForeColor = Color.FromArgb(102, 153, 255);
		((Style)__ctrl).CssClass = "mnu";
		((Style)__ctrl).Font.Size = FontUnit.Small;
	}

	[DebuggerNonUserCode]
	private void __BuildControl__control13(Style __ctrl)
	{
		__ctrl.BackColor = Color.LightSteelBlue;
		__ctrl.ForeColor = Color.White;
	}

	[DebuggerNonUserCode]
	private Menu __BuildControlMenu1()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_0085: Unknown result type (might be due to invalid IL or missing references)
		//IL_008a: Unknown result type (might be due to invalid IL or missing references)
		//IL_009e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
		Menu val = (Menu1 = new Menu());
		((Control)val).ApplyStyleSheetSkin(((Control)this).Page);
		((Control)val).ID = "Menu1";
		((HierarchicalDataBoundControl)val).DataSourceID = "SiteMapDS1";
		val.DynamicHorizontalOffset = 2;
		((WebControl)val).Font.Names = new string[1] { "Verdana" };
		((WebControl)val).Font.Size = FontUnit.Small;
		((WebControl)val).ForeColor = Color.FromArgb(204, 255, 51);
		Unit staticSubMenuIndent = new Unit(10.0, (UnitType)1);
		val.StaticSubMenuIndent = staticSubMenuIndent;
		staticSubMenuIndent = new Unit(192.0, (UnitType)1);
		((WebControl)val).Width = staticSubMenuIndent;
		((WebControl)val).Font.Bold = true;
		((WebControl)val).CssClass = "mnu";
		__BuildControl__control7(val.StaticMenuItemStyle);
		__BuildControl__control8(val.DynamicHoverStyle);
		__BuildControl__control9(val.DynamicMenuStyle);
		__BuildControl__control10(val.StaticSelectedStyle);
		__BuildControl__control11(val.DynamicSelectedStyle);
		__BuildControl__control12(val.DynamicMenuItemStyle);
		__BuildControl__control13(val.StaticHoverStyle);
		return val;
	}

	[DebuggerNonUserCode]
	private LoginName __BuildControl__control15()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		LoginName val = new LoginName();
		((Control)val).TemplateControl = (TemplateControl)(object)this;
		((Control)val).ApplyStyleSheetSkin(((Control)this).Page);
		((Control)val).ID = "LoginName1";
		((WebControl)val).Font.Bold = true;
		((WebControl)val).ForeColor = Color.Black;
		return val;
	}

	[DebuggerNonUserCode]
	private HyperLink __BuildControl__control16()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Expected Obj, but got Unknown
		HyperLink val = new HyperLink();
		((Control)val).TemplateControl = (TemplateControl)(object)this;
		((Control)val).ApplyStyleSheetSkin(((Control)this).Page);
		((Control)val).ID = "HyperLink2";
		val.NavigateUrl = "~/ChangePass.aspx";
		IParserAccessor val2 = (IParserAccessor)(object)val;
		val2.AddParsedSubObject((object)new LiteralControl("Change Your Password"));
		return val;
	}

	[DebuggerNonUserCode]
	private Image __BuildControl__control17()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Image val = new Image();
		((Control)val).TemplateControl = (TemplateControl)(object)this;
		((Control)val).ApplyStyleSheetSkin(((Control)this).Page);
		((Control)val).ID = "Image1";
		val.ImageUrl = "~/images/user.gif";
		return val;
	}

	[DebuggerNonUserCode]
	private LoginStatus __BuildControl__control18()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		LoginStatus val = new LoginStatus();
		((Control)val).TemplateControl = (TemplateControl)(object)this;
		((Control)val).ApplyStyleSheetSkin(((Control)this).Page);
		((Control)val).ID = "LoginStatus1";
		((WebControl)val).Font.Bold = true;
		return val;
	}

	[DebuggerNonUserCode]
	private void __BuildControl__control14(Control __ctrl)
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
		((IParserAccessor)__ctrl).AddParsedSubObject((object)new LiteralControl("\r\n                                                                <strong>Welcome</strong>\r\n                                                                "));
		LoginName val = __BuildControl__control15();
		((IParserAccessor)__ctrl).AddParsedSubObject((object)val);
		((IParserAccessor)__ctrl).AddParsedSubObject((object)new LiteralControl("\r\n                                                                <br />\r\n                                                                "));
		HyperLink val2 = __BuildControl__control16();
		((IParserAccessor)__ctrl).AddParsedSubObject((object)val2);
		((IParserAccessor)__ctrl).AddParsedSubObject((object)new LiteralControl("\r\n                                                            \r\n                                                                <br />\r\n                                                                "));
		Image val3 = __BuildControl__control17();
		((IParserAccessor)__ctrl).AddParsedSubObject((object)val3);
		((IParserAccessor)__ctrl).AddParsedSubObject((object)new LiteralControl("\r\n                                                                "));
		LoginStatus val4 = __BuildControl__control18();
		((IParserAccessor)__ctrl).AddParsedSubObject((object)val4);
		((IParserAccessor)__ctrl).AddParsedSubObject((object)new LiteralControl("\r\n                                                            "));
	}

	[DebuggerNonUserCode]
	private Image __BuildControl__control20()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Image val = new Image();
		((Control)val).TemplateControl = (TemplateControl)(object)this;
		((Control)val).ApplyStyleSheetSkin(((Control)this).Page);
		((Control)val).ID = "Image1";
		val.ImageUrl = "~/images/user.gif";
		return val;
	}

	[DebuggerNonUserCode]
	private LoginStatus __BuildControl__control21()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		LoginStatus val = new LoginStatus();
		((Control)val).TemplateControl = (TemplateControl)(object)this;
		((Control)val).ApplyStyleSheetSkin(((Control)this).Page);
		((Control)val).ID = "LoginStatus1";
		((WebControl)val).EnableTheming = true;
		((WebControl)val).Font.Bold = true;
		return val;
	}

	[DebuggerNonUserCode]
	private Image __BuildControl__control22()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Image val = new Image();
		((Control)val).TemplateControl = (TemplateControl)(object)this;
		((Control)val).ApplyStyleSheetSkin(((Control)this).Page);
		((Control)val).ID = "Image2";
		val.ImageUrl = "~/images/add.gif";
		return val;
	}

	[DebuggerNonUserCode]
	private HyperLink __BuildControl__control23()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Expected Obj, but got Unknown
		HyperLink val = new HyperLink();
		((Control)val).TemplateControl = (TemplateControl)(object)this;
		((Control)val).ApplyStyleSheetSkin(((Control)this).Page);
		((Control)val).ID = "HyperLink1";
		val.NavigateUrl = "~/Regidter.aspx";
		((WebControl)val).Font.Bold = true;
		IParserAccessor val2 = (IParserAccessor)(object)val;
		val2.AddParsedSubObject((object)new LiteralControl("SignUp"));
		return val;
	}

	[DebuggerNonUserCode]
	private HyperLink __BuildControl__control24()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Expected Obj, but got Unknown
		HyperLink val = new HyperLink();
		((Control)val).TemplateControl = (TemplateControl)(object)this;
		((Control)val).ApplyStyleSheetSkin(((Control)this).Page);
		((Control)val).ID = "HyperLink3";
		val.NavigateUrl = "~/revovery.aspx";
		IParserAccessor val2 = (IParserAccessor)(object)val;
		val2.AddParsedSubObject((object)new LiteralControl("Forgot Password?"));
		return val;
	}

	[DebuggerNonUserCode]
	private void __BuildControl__control19(Control __ctrl)
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
		((IParserAccessor)__ctrl).AddParsedSubObject((object)new LiteralControl("\r\n                                                                &nbsp;"));
		Image val = __BuildControl__control20();
		((IParserAccessor)__ctrl).AddParsedSubObject((object)val);
		((IParserAccessor)__ctrl).AddParsedSubObject((object)new LiteralControl("\r\n                                                                "));
		LoginStatus val2 = __BuildControl__control21();
		((IParserAccessor)__ctrl).AddParsedSubObject((object)val2);
		((IParserAccessor)__ctrl).AddParsedSubObject((object)new LiteralControl("\r\n                                                                <br />\r\n                                                                &nbsp;"));
		Image val3 = __BuildControl__control22();
		((IParserAccessor)__ctrl).AddParsedSubObject((object)val3);
		((IParserAccessor)__ctrl).AddParsedSubObject((object)new LiteralControl("\r\n                                                                "));
		HyperLink val4 = __BuildControl__control23();
		((IParserAccessor)__ctrl).AddParsedSubObject((object)val4);
		((IParserAccessor)__ctrl).AddParsedSubObject((object)new LiteralControl("\r\n                                                                    <br />\r\n                                                                "));
		HyperLink val5 = __BuildControl__control24();
		((IParserAccessor)__ctrl).AddParsedSubObject((object)val5);
		((IParserAccessor)__ctrl).AddParsedSubObject((object)new LiteralControl("\r\n                                                            "));
	}

	[DebuggerNonUserCode]
	private LoginView __BuildControlLoginView1()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Expected Obj, but got Unknown
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Expected Obj, but got Unknown
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Expected Obj, but got Unknown
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Expected Obj, but got Unknown
		LoginView val = (LoginView1 = new LoginView());
		((Control)val).ApplyStyleSheetSkin(((Control)this).Page);
		val.LoggedInTemplate = (ITemplate)new CompiledTemplateBuilder((BuildTemplateMethod)__BuildControl__control14);
		val.AnonymousTemplate = (ITemplate)new CompiledTemplateBuilder((BuildTemplateMethod)__BuildControl__control19);
		((Control)val).ID = "LoginView1";
		return val;
	}

	[DebuggerNonUserCode]
	private ContentPlaceHolder __BuildControlContentPlaceHolder1()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Expected Obj, but got Unknown
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Expected Obj, but got Unknown
		ContentPlaceHolder val = (ContentPlaceHolder1 = new ContentPlaceHolder());
		((Control)val).ID = "ContentPlaceHolder1";
		if (((MasterPage)this).ContentTemplates != null)
		{
			__Template_ContentPlaceHolder1 = (ITemplate)((MasterPage)this).ContentTemplates["ContentPlaceHolder1"];
		}
		if (__Template_ContentPlaceHolder1 != null)
		{
			((MasterPage)this).InstantiateInContentPlaceHolder((Control)(object)val, __Template_ContentPlaceHolder1);
		}
		else
		{
			IParserAccessor val3 = (IParserAccessor)(object)val;
			val3.AddParsedSubObject((object)new LiteralControl("\r\n                                        &nbsp;"));
		}
		return val;
	}

	[DebuggerNonUserCode]
	private HtmlForm __BuildControlform1()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		//IL_0086: Unknown result type (might be due to invalid IL or missing references)
		//IL_0090: Expected Obj, but got Unknown
		HtmlForm val = (form1 = new HtmlForm());
		((Control)val).ID = "form1";
		ScriptManager val3 = __BuildControlScriptManager1();
		IParserAccessor val4 = (IParserAccessor)(object)val;
		val4.AddParsedSubObject((object)val3);
		Image val5 = __BuildControlImage3();
		val4.AddParsedSubObject((object)val5);
		SiteMapDataSource val6 = __BuildControlSiteMapDS1();
		val4.AddParsedSubObject((object)val6);
		Menu val7 = __BuildControlMenu1();
		val4.AddParsedSubObject((object)val7);
		LoginView val8 = __BuildControlLoginView1();
		val4.AddParsedSubObject((object)val8);
		ContentPlaceHolder val9 = __BuildControlContentPlaceHolder1();
		val4.AddParsedSubObject((object)val9);
		((Control)val).SetRenderMethodDelegate((RenderMethod)__Renderform1);
		return val;
	}

	private void __Renderform1(HtmlTextWriter __w, Control parameterContainer)
	{
		__w.Write("\r\n            ");
		parameterContainer.Controls[0].RenderControl(__w);
		((TemplateControl)this).WriteUTF8ResourceString(__w, 0, 516, true);
		__w.Write(((Control)((Control)this).Page).ResolveUrl("~/images/bannerbg_06.gif"));
		__w.Write("\">\r\n                                ");
		parameterContainer.Controls[1].RenderControl(__w);
		__w.Write("\r\n                            </td>\r\n                        </tr>\r\n                        <tr>\r\n                            <td align=\"left\" background=\"");
		__w.Write(((Control)((Control)this).Page).ResolveUrl("~/images/spacer.gif"));
		((TemplateControl)this).WriteUTF8ResourceString(__w, 516, 351, true);
		parameterContainer.Controls[2].RenderControl(__w);
		__w.Write("\r\n                                            ");
		parameterContainer.Controls[3].RenderControl(__w);
		((TemplateControl)this).WriteUTF8ResourceString(__w, 867, 756, true);
		parameterContainer.Controls[4].RenderControl(__w);
		((TemplateControl)this).WriteUTF8ResourceString(__w, 1623, 964, true);
		__w.Write(((Control)((Control)this).Page).ResolveUrl("~/images/spacer.gif"));
		__w.Write("\" valign=\"top\"\r\n                                width=\"85%\">\r\n                                <div style=\"height:100%\">\r\n                                    ");
		parameterContainer.Controls[5].RenderControl(__w);
		((TemplateControl)this).WriteUTF8ResourceString(__w, 2587, 1550, true);
	}

	[DebuggerNonUserCode]
	private void __BuildControlTree(master1_master __ctrl)
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Expected Obj, but got Unknown
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Expected Obj, but got Unknown
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_004e: Expected Obj, but got Unknown
		((IParserAccessor)__ctrl).AddParsedSubObject((object)new LiteralControl("\r\n<!DOCTYPE html PUBLIC \"-//W3C//DTD XHTML 1.0 Transitional//EN\" \"http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd\">\r\n<html xmlns=\"http://www.w3.org/1999/xhtml\">\r\n"));
		HtmlHead val = __BuildControl__control2();
		((IParserAccessor)__ctrl).AddParsedSubObject((object)val);
		((IParserAccessor)__ctrl).AddParsedSubObject((object)new LiteralControl("\r\n<body>\r\n    <div style=\"height: 98%;\">\r\n        <table border=\"0\" cellpadding=\"0\" cellspacing=\"0\" \r\n            style=\"width: 100%; height: 100%\">\r\n            "));
		HtmlForm val2 = __BuildControlform1();
		((IParserAccessor)__ctrl).AddParsedSubObject((object)val2);
		((IParserAccessor)__ctrl).AddParsedSubObject((object)new LiteralControl("\r\n        </table>\r\n    </div>\r\n</body>\r\n</html>\r\n"));
	}

	[DebuggerNonUserCode]
	protected override void FrameworkInitialize()
	{
		((TemplateControl)this).FrameworkInitialize();
		((TemplateControl)this).SetStringResourcePointer(RuntimeHelpers.GetObjectValue(__stringResource), 0);
		__BuildControlTree(this);
	}
}
