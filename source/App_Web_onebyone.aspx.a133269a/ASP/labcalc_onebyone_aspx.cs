using System;
using System.Collections.Specialized;
using System.Diagnostics;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Web;
using System.Web.Compilation;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using AjaxControlToolkit;

namespace ASP;

[CompilerGlobalScope]
public class labcalc_onebyone_aspx : LabCalc_ONEBYONE
{
	private static bool __initialized;

	private static object __stringResource;

	private static object __fileDependencies;

	protected override bool SupportAutoEvents => false;

	[DebuggerNonUserCode]
	public labcalc_onebyone_aspx()
	{
		((TemplateControl)this).AppRelativeVirtualPath = "~/LabCalc/ONEBYONE.aspx";
		if (!__initialized)
		{
			__stringResource = RuntimeHelpers.GetObjectValue(((TemplateControl)this).ReadStringResource());
			__fileDependencies = RuntimeHelpers.GetObjectValue(((Page)this).GetWrappedFileDependencies(new string[4] { "~/LabCalc/ONEBYONE.aspx", "~/master1.master", "~/master1.master.vb", "~/LabCalc/ONEBYONE.aspx.vb" }));
			__initialized = true;
		}
		((Page)this).Server.ScriptTimeout = 30000000;
	}

	[DebuggerNonUserCode]
	private AutoCompleteExtender __BuildControlAutoCompleteExtender1()
	{
		AutoCompleteExtender autoCompleteExtender = (AutoCompleteExtender1 = new AutoCompleteExtender());
		((Control)autoCompleteExtender).TemplateControl = (TemplateControl)(object)this;
		((Control)autoCompleteExtender).ApplyStyleSheetSkin((Page)(object)this);
		((Control)autoCompleteExtender).ID = "AutoCompleteExtender1";
		autoCompleteExtender.ServicePath = "~/AutoComplete.asmx";
		autoCompleteExtender.BehaviorID = "AutoCompleteEx";
		autoCompleteExtender.MinimumPrefixLength = 1;
		autoCompleteExtender.ServiceMethod = "GetCompletionList";
		autoCompleteExtender.CompletionInterval = 1000;
		autoCompleteExtender.CompletionSetCount = 20;
		((ExtenderControl)autoCompleteExtender).TargetControlID = "myTextBox";
		return autoCompleteExtender;
	}

	[DebuggerNonUserCode]
	private TextBox __BuildControlmyTextBox()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		TextBox val = (myTextBox = new TextBox());
		((Control)val).TemplateControl = (TemplateControl)(object)this;
		((Control)val).ApplyStyleSheetSkin((Page)(object)this);
		((Control)val).ID = "myTextBox";
		Unit width = new Unit(118.0, (UnitType)1);
		((WebControl)val).Width = width;
		return val;
	}

	[DebuggerNonUserCode]
	private Button __BuildControlButton1()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		Button val = (Button1 = new Button());
		((Control)val).TemplateControl = (TemplateControl)(object)this;
		((Control)val).ApplyStyleSheetSkin((Page)(object)this);
		((Control)val).ID = "Button1";
		Unit width = new Unit(62.0, (UnitType)1);
		((WebControl)val).Width = width;
		val.Text = "Go";
		if (((TemplateControl)this).TestDeviceFilter("__designer"))
		{
			((IAttributeAccessor)val).SetAttribute("wfdid", "w1");
		}
		val.Click += Button1_Click;
		return val;
	}

	[DebuggerNonUserCode]
	private HtmlTableCell __BuildControl__control5()
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected Obj, but got Unknown
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected Obj, but got Unknown
		HtmlTableCell val = new HtmlTableCell("td");
		IParserAccessor val2 = (IParserAccessor)(object)val;
		val2.AddParsedSubObject((object)new LiteralControl("\r\n                                                        Low\r\n                                                    "));
		return val;
	}

	[DebuggerNonUserCode]
	private HtmlTableCell __BuildControl__control6()
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected Obj, but got Unknown
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected Obj, but got Unknown
		HtmlTableCell val = new HtmlTableCell("td");
		IParserAccessor val2 = (IParserAccessor)(object)val;
		val2.AddParsedSubObject((object)new LiteralControl("\r\n                                                        Test Result\r\n                                                    "));
		return val;
	}

	[DebuggerNonUserCode]
	private HtmlTableCell __BuildControl__control7()
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected Obj, but got Unknown
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected Obj, but got Unknown
		HtmlTableCell val = new HtmlTableCell("td");
		IParserAccessor val2 = (IParserAccessor)(object)val;
		val2.AddParsedSubObject((object)new LiteralControl("\r\n                                                        High\r\n                                                    "));
		return val;
	}

	[DebuggerNonUserCode]
	private void __BuildControl__control4(HtmlTableCellCollection __ctrl)
	{
		HtmlTableCell val = __BuildControl__control5();
		__ctrl.Add(val);
		HtmlTableCell val2 = __BuildControl__control6();
		__ctrl.Add(val2);
		HtmlTableCell val3 = __BuildControl__control7();
		__ctrl.Add(val3);
	}

	[DebuggerNonUserCode]
	private HtmlTableRow __BuildControl__control3()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		HtmlTableRow val = new HtmlTableRow();
		__BuildControl__control4(val.Cells);
		return val;
	}

	[DebuggerNonUserCode]
	private TextBox __BuildControlTLow()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		TextBox val = (TLow = new TextBox());
		((Control)val).ApplyStyleSheetSkin((Page)(object)this);
		((Control)val).ID = "TLow";
		((WebControl)val).TabIndex = 2;
		Unit width = new Unit(75.0, (UnitType)1);
		((WebControl)val).Width = width;
		if (((TemplateControl)this).TestDeviceFilter("__designer"))
		{
			((IAttributeAccessor)val).SetAttribute("wfdid", "w7");
		}
		return val;
	}

	[DebuggerNonUserCode]
	private HtmlTableCell __BuildControl__control10()
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected Obj, but got Unknown
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected Obj, but got Unknown
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Expected Obj, but got Unknown
		HtmlTableCell val = new HtmlTableCell("td");
		IParserAccessor val2 = (IParserAccessor)(object)val;
		val2.AddParsedSubObject((object)new LiteralControl("\r\n                                                        "));
		TextBox val3 = __BuildControlTLow();
		val2.AddParsedSubObject((object)val3);
		val2.AddParsedSubObject((object)new LiteralControl("\r\n                                                    "));
		return val;
	}

	[DebuggerNonUserCode]
	private TextBox __BuildControlTopt()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		TextBox val = (Topt = new TextBox());
		((Control)val).ApplyStyleSheetSkin((Page)(object)this);
		((Control)val).ID = "Topt";
		((WebControl)val).TabIndex = 1;
		Unit width = new Unit(75.0, (UnitType)1);
		((WebControl)val).Width = width;
		if (((TemplateControl)this).TestDeviceFilter("__designer"))
		{
			((IAttributeAccessor)val).SetAttribute("wfdid", "w8");
		}
		return val;
	}

	[DebuggerNonUserCode]
	private HtmlTableCell __BuildControl__control11()
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected Obj, but got Unknown
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected Obj, but got Unknown
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Expected Obj, but got Unknown
		HtmlTableCell val = new HtmlTableCell("td");
		IParserAccessor val2 = (IParserAccessor)(object)val;
		val2.AddParsedSubObject((object)new LiteralControl("\r\n                                                        "));
		TextBox val3 = __BuildControlTopt();
		val2.AddParsedSubObject((object)val3);
		val2.AddParsedSubObject((object)new LiteralControl("\r\n                                                    "));
		return val;
	}

	[DebuggerNonUserCode]
	private TextBox __BuildControlThigh()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		TextBox val = (Thigh = new TextBox());
		((Control)val).ApplyStyleSheetSkin((Page)(object)this);
		((Control)val).ID = "Thigh";
		((WebControl)val).TabIndex = 3;
		Unit width = new Unit(75.0, (UnitType)1);
		((WebControl)val).Width = width;
		if (((TemplateControl)this).TestDeviceFilter("__designer"))
		{
			((IAttributeAccessor)val).SetAttribute("wfdid", "w9");
		}
		return val;
	}

	[DebuggerNonUserCode]
	private HtmlTableCell __BuildControl__control12()
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected Obj, but got Unknown
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected Obj, but got Unknown
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Expected Obj, but got Unknown
		HtmlTableCell val = new HtmlTableCell("td");
		IParserAccessor val2 = (IParserAccessor)(object)val;
		val2.AddParsedSubObject((object)new LiteralControl("\r\n                                                        "));
		TextBox val3 = __BuildControlThigh();
		val2.AddParsedSubObject((object)val3);
		val2.AddParsedSubObject((object)new LiteralControl("\r\n                                                    "));
		return val;
	}

	[DebuggerNonUserCode]
	private void __BuildControl__control9(HtmlTableCellCollection __ctrl)
	{
		HtmlTableCell val = __BuildControl__control10();
		__ctrl.Add(val);
		HtmlTableCell val2 = __BuildControl__control11();
		__ctrl.Add(val2);
		HtmlTableCell val3 = __BuildControl__control12();
		__ctrl.Add(val3);
	}

	[DebuggerNonUserCode]
	private HtmlTableRow __BuildControl__control8()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		HtmlTableRow val = new HtmlTableRow();
		__BuildControl__control9(val.Cells);
		return val;
	}

	[DebuggerNonUserCode]
	private HtmlTableCell __BuildControl__control15()
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected Obj, but got Unknown
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected Obj, but got Unknown
		HtmlTableCell val = new HtmlTableCell("td");
		IParserAccessor val2 = (IParserAccessor)(object)val;
		val2.AddParsedSubObject((object)new LiteralControl("\r\n                                                        Doctor's Low Value\r\n                                                    "));
		return val;
	}

	[DebuggerNonUserCode]
	private HtmlTableCell __BuildControl__control16()
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected Obj, but got Unknown
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected Obj, but got Unknown
		HtmlTableCell val = new HtmlTableCell("td");
		IParserAccessor val2 = (IParserAccessor)(object)val;
		val2.AddParsedSubObject((object)new LiteralControl("\r\n                                                    "));
		return val;
	}

	[DebuggerNonUserCode]
	private HtmlTableCell __BuildControl__control17()
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected Obj, but got Unknown
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected Obj, but got Unknown
		HtmlTableCell val = new HtmlTableCell("td");
		IParserAccessor val2 = (IParserAccessor)(object)val;
		val2.AddParsedSubObject((object)new LiteralControl("\r\n                                                        Doctor's High Value\r\n                                                    "));
		return val;
	}

	[DebuggerNonUserCode]
	private void __BuildControl__control14(HtmlTableCellCollection __ctrl)
	{
		HtmlTableCell val = __BuildControl__control15();
		__ctrl.Add(val);
		HtmlTableCell val2 = __BuildControl__control16();
		__ctrl.Add(val2);
		HtmlTableCell val3 = __BuildControl__control17();
		__ctrl.Add(val3);
	}

	[DebuggerNonUserCode]
	private HtmlTableRow __BuildControl__control13()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		HtmlTableRow val = new HtmlTableRow();
		__BuildControl__control14(val.Cells);
		return val;
	}

	[DebuggerNonUserCode]
	private Label __BuildControldLow()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Label val = (dLow = new Label());
		((Control)val).ApplyStyleSheetSkin((Page)(object)this);
		((Control)val).ID = "dLow";
		if (((TemplateControl)this).TestDeviceFilter("__designer"))
		{
			((IAttributeAccessor)val).SetAttribute("wfdid", "w10");
		}
		return val;
	}

	[DebuggerNonUserCode]
	private HtmlTableCell __BuildControl__control20()
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected Obj, but got Unknown
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected Obj, but got Unknown
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Expected Obj, but got Unknown
		HtmlTableCell val = new HtmlTableCell("td");
		IParserAccessor val2 = (IParserAccessor)(object)val;
		val2.AddParsedSubObject((object)new LiteralControl("\r\n                                                        "));
		Label val3 = __BuildControldLow();
		val2.AddParsedSubObject((object)val3);
		val2.AddParsedSubObject((object)new LiteralControl("\r\n                                                    "));
		return val;
	}

	[DebuggerNonUserCode]
	private HtmlTableCell __BuildControl__control21()
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected Obj, but got Unknown
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected Obj, but got Unknown
		HtmlTableCell val = new HtmlTableCell("td");
		IParserAccessor val2 = (IParserAccessor)(object)val;
		val2.AddParsedSubObject((object)new LiteralControl("\r\n                                                    "));
		return val;
	}

	[DebuggerNonUserCode]
	private Label __BuildControldHigh()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Label val = (dHigh = new Label());
		((Control)val).ApplyStyleSheetSkin((Page)(object)this);
		((Control)val).ID = "dHigh";
		if (((TemplateControl)this).TestDeviceFilter("__designer"))
		{
			((IAttributeAccessor)val).SetAttribute("wfdid", "w11");
		}
		return val;
	}

	[DebuggerNonUserCode]
	private HtmlTableCell __BuildControl__control22()
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected Obj, but got Unknown
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected Obj, but got Unknown
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Expected Obj, but got Unknown
		HtmlTableCell val = new HtmlTableCell("td");
		IParserAccessor val2 = (IParserAccessor)(object)val;
		val2.AddParsedSubObject((object)new LiteralControl("\r\n                                                        "));
		Label val3 = __BuildControldHigh();
		val2.AddParsedSubObject((object)val3);
		val2.AddParsedSubObject((object)new LiteralControl("\r\n                                                    "));
		return val;
	}

	[DebuggerNonUserCode]
	private void __BuildControl__control19(HtmlTableCellCollection __ctrl)
	{
		HtmlTableCell val = __BuildControl__control20();
		__ctrl.Add(val);
		HtmlTableCell val2 = __BuildControl__control21();
		__ctrl.Add(val2);
		HtmlTableCell val3 = __BuildControl__control22();
		__ctrl.Add(val3);
	}

	[DebuggerNonUserCode]
	private HtmlTableRow __BuildControl__control18()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		HtmlTableRow val = new HtmlTableRow();
		__BuildControl__control19(val.Cells);
		return val;
	}

	[DebuggerNonUserCode]
	private HtmlTableCell __BuildControl__control25()
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected Obj, but got Unknown
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected Obj, but got Unknown
		HtmlTableCell val = new HtmlTableCell("td");
		IParserAccessor val2 = (IParserAccessor)(object)val;
		val2.AddParsedSubObject((object)new LiteralControl("\r\n                                                    "));
		return val;
	}

	[DebuggerNonUserCode]
	private HtmlTableCell __BuildControl__control26()
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected Obj, but got Unknown
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected Obj, but got Unknown
		HtmlTableCell val = new HtmlTableCell("td");
		IParserAccessor val2 = (IParserAccessor)(object)val;
		val2.AddParsedSubObject((object)new LiteralControl("\r\n                                                    "));
		return val;
	}

	[DebuggerNonUserCode]
	private Button __BuildControlButton4()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		Button val = (Button4 = new Button());
		((Control)val).ApplyStyleSheetSkin((Page)(object)this);
		((Control)val).ID = "Button4";
		((WebControl)val).TabIndex = 4;
		Unit width = new Unit(80.0, (UnitType)1);
		((WebControl)val).Width = width;
		val.Text = "Add";
		if (((TemplateControl)this).TestDeviceFilter("__designer"))
		{
			((IAttributeAccessor)val).SetAttribute("wfdid", "w12");
		}
		val.Click += Button2_Click;
		return val;
	}

	[DebuggerNonUserCode]
	private HtmlTableCell __BuildControl__control27()
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected Obj, but got Unknown
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected Obj, but got Unknown
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Expected Obj, but got Unknown
		HtmlTableCell val = new HtmlTableCell("td");
		IParserAccessor val2 = (IParserAccessor)(object)val;
		val2.AddParsedSubObject((object)new LiteralControl("\r\n                                                        "));
		Button val3 = __BuildControlButton4();
		val2.AddParsedSubObject((object)val3);
		val2.AddParsedSubObject((object)new LiteralControl("\r\n                                                    "));
		return val;
	}

	[DebuggerNonUserCode]
	private void __BuildControl__control24(HtmlTableCellCollection __ctrl)
	{
		HtmlTableCell val = __BuildControl__control25();
		__ctrl.Add(val);
		HtmlTableCell val2 = __BuildControl__control26();
		__ctrl.Add(val2);
		HtmlTableCell val3 = __BuildControl__control27();
		__ctrl.Add(val3);
	}

	[DebuggerNonUserCode]
	private HtmlTableRow __BuildControl__control23()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		HtmlTableRow val = new HtmlTableRow();
		__BuildControl__control24(val.Cells);
		return val;
	}

	[DebuggerNonUserCode]
	private HtmlTableCell __BuildControl__control30()
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected Obj, but got Unknown
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected Obj, but got Unknown
		HtmlTableCell val = new HtmlTableCell("td");
		IParserAccessor val2 = (IParserAccessor)(object)val;
		val2.AddParsedSubObject((object)new LiteralControl("\r\n                                                    "));
		return val;
	}

	[DebuggerNonUserCode]
	private HtmlTableCell __BuildControl__control31()
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected Obj, but got Unknown
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected Obj, but got Unknown
		HtmlTableCell val = new HtmlTableCell("td");
		IParserAccessor val2 = (IParserAccessor)(object)val;
		val2.AddParsedSubObject((object)new LiteralControl("\r\n                                                    "));
		return val;
	}

	[DebuggerNonUserCode]
	private Button __BuildControlButton5()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		Button val = (Button5 = new Button());
		((Control)val).ApplyStyleSheetSkin((Page)(object)this);
		((Control)val).ID = "Button5";
		((WebControl)val).TabIndex = 5;
		Unit width = new Unit(81.0, (UnitType)1);
		((WebControl)val).Width = width;
		val.Text = "Cancel";
		if (((TemplateControl)this).TestDeviceFilter("__designer"))
		{
			((IAttributeAccessor)val).SetAttribute("wfdid", "w13");
		}
		val.Click += Button3_Click;
		return val;
	}

	[DebuggerNonUserCode]
	private HtmlTableCell __BuildControl__control32()
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected Obj, but got Unknown
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected Obj, but got Unknown
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Expected Obj, but got Unknown
		HtmlTableCell val = new HtmlTableCell("td");
		IParserAccessor val2 = (IParserAccessor)(object)val;
		val2.AddParsedSubObject((object)new LiteralControl("\r\n                                                        "));
		Button val3 = __BuildControlButton5();
		val2.AddParsedSubObject((object)val3);
		val2.AddParsedSubObject((object)new LiteralControl("\r\n                                                    "));
		return val;
	}

	[DebuggerNonUserCode]
	private void __BuildControl__control29(HtmlTableCellCollection __ctrl)
	{
		HtmlTableCell val = __BuildControl__control30();
		__ctrl.Add(val);
		HtmlTableCell val2 = __BuildControl__control31();
		__ctrl.Add(val2);
		HtmlTableCell val3 = __BuildControl__control32();
		__ctrl.Add(val3);
	}

	[DebuggerNonUserCode]
	private HtmlTableRow __BuildControl__control28()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		HtmlTableRow val = new HtmlTableRow();
		__BuildControl__control29(val.Cells);
		return val;
	}

	[DebuggerNonUserCode]
	private HtmlTableCell __BuildControl__control35()
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected Obj, but got Unknown
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Expected Obj, but got Unknown
		HtmlTableCell val = new HtmlTableCell("td");
		val.ColSpan = 3;
		IParserAccessor val2 = (IParserAccessor)(object)val;
		val2.AddParsedSubObject((object)new LiteralControl("\r\n                                                    "));
		return val;
	}

	[DebuggerNonUserCode]
	private void __BuildControl__control34(HtmlTableCellCollection __ctrl)
	{
		HtmlTableCell val = __BuildControl__control35();
		__ctrl.Add(val);
	}

	[DebuggerNonUserCode]
	private HtmlTableRow __BuildControl__control33()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		HtmlTableRow val = new HtmlTableRow();
		__BuildControl__control34(val.Cells);
		return val;
	}

	[DebuggerNonUserCode]
	private void __BuildControl__control2(HtmlTableRowCollection __ctrl)
	{
		HtmlTableRow val = __BuildControl__control3();
		__ctrl.Add(val);
		HtmlTableRow val2 = __BuildControl__control8();
		__ctrl.Add(val2);
		HtmlTableRow val3 = __BuildControl__control13();
		__ctrl.Add(val3);
		HtmlTableRow val4 = __BuildControl__control18();
		__ctrl.Add(val4);
		HtmlTableRow val5 = __BuildControl__control23();
		__ctrl.Add(val5);
		HtmlTableRow val6 = __BuildControl__control28();
		__ctrl.Add(val6);
		HtmlTableRow val7 = __BuildControl__control33();
		__ctrl.Add(val7);
	}

	[DebuggerNonUserCode]
	private HtmlTable __BuildControlTABLE1()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		HtmlTable val = (TABLE1 = new HtmlTable());
		((Control)val).TemplateControl = (TemplateControl)(object)this;
		((Control)val).ID = "TABLE1";
		val.Width = "400";
		__BuildControl__control2(val.Rows);
		return val;
	}

	[DebuggerNonUserCode]
	private CheckBox __BuildControl__control39()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		CheckBox val = new CheckBox();
		((Control)val).TemplateControl = (TemplateControl)(object)this;
		((Control)val).ApplyStyleSheetSkin((Page)(object)this);
		if (((TemplateControl)this).TestDeviceFilter("__designer"))
		{
			((IAttributeAccessor)val).SetAttribute("dtid", "1125899906842634");
		}
		((Control)val).ID = "CheckBox1";
		return val;
	}

	[DebuggerNonUserCode]
	private void __BuildControl__control38(Control __ctrl)
	{
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Expected Obj, but got Unknown
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Expected Obj, but got Unknown
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		if (((TemplateControl)this).TestDeviceFilter("__designer"))
		{
			((IAttributeAccessor)__ctrl).SetAttribute("dtid", "1125899906842633");
		}
		((IParserAccessor)__ctrl).AddParsedSubObject((object)new LiteralControl("\r\n                                        "));
		CheckBox val = __BuildControl__control39();
		((IParserAccessor)__ctrl).AddParsedSubObject((object)val);
		((IParserAccessor)__ctrl).AddParsedSubObject((object)new LiteralControl("\r\n                                    "));
	}

	[DebuggerNonUserCode]
	private CheckBox __BuildControl__control41()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		CheckBox val = new CheckBox();
		((Control)val).TemplateControl = (TemplateControl)(object)this;
		((Control)val).ApplyStyleSheetSkin((Page)(object)this);
		if (((TemplateControl)this).TestDeviceFilter("__designer"))
		{
			((IAttributeAccessor)val).SetAttribute("dtid", "1125899906842636");
		}
		((Control)val).ID = "CheckBox1";
		return val;
	}

	[DebuggerNonUserCode]
	private void __BuildControl__control40(Control __ctrl)
	{
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Expected Obj, but got Unknown
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Expected Obj, but got Unknown
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		if (((TemplateControl)this).TestDeviceFilter("__designer"))
		{
			((IAttributeAccessor)__ctrl).SetAttribute("dtid", "1125899906842635");
		}
		((IParserAccessor)__ctrl).AddParsedSubObject((object)new LiteralControl("\r\n                                        "));
		CheckBox val = __BuildControl__control41();
		((IParserAccessor)__ctrl).AddParsedSubObject((object)val);
		((IParserAccessor)__ctrl).AddParsedSubObject((object)new LiteralControl("\r\n                                    "));
	}

	[DebuggerNonUserCode]
	private TemplateField __BuildControl__control37()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Expected Obj, but got Unknown
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Expected Obj, but got Unknown
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Expected Obj, but got Unknown
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Expected Obj, but got Unknown
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		TemplateField val = new TemplateField();
		val.EditItemTemplate = (ITemplate)new CompiledBindableTemplateBuilder((BuildTemplateMethod)__BuildControl__control38, (ExtractTemplateValuesMethod)null);
		val.ItemTemplate = (ITemplate)new CompiledBindableTemplateBuilder((BuildTemplateMethod)__BuildControl__control40, (ExtractTemplateValuesMethod)null);
		((DataControlField)val).HeaderText = "Select";
		((DataControlField)val).Visible = false;
		if (((TemplateControl)this).TestDeviceFilter("__designer"))
		{
			((IAttributeAccessor)val).SetAttribute("dtid", "1125899906842632");
		}
		return val;
	}

	[DebuggerNonUserCode]
	private BoundField __BuildControl__control42()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		BoundField val = new BoundField();
		val.DataField = "Result";
		val.HeaderText = "Result";
		((DataControlField)val).SortExpression = "Result";
		if (((TemplateControl)this).TestDeviceFilter("__designer"))
		{
			((IAttributeAccessor)val).SetAttribute("dtid", "1125899906842637");
		}
		return val;
	}

	[DebuggerNonUserCode]
	private BoundField __BuildControl__control43()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		BoundField val = new BoundField();
		val.DataField = "TestAbrev";
		val.HeaderText = "TestAbrev";
		((DataControlField)val).SortExpression = "TestAbrev";
		if (((TemplateControl)this).TestDeviceFilter("__designer"))
		{
			((IAttributeAccessor)val).SetAttribute("dtid", "1125899906842638");
		}
		return val;
	}

	[DebuggerNonUserCode]
	private BoundField __BuildControl__control44()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		BoundField val = new BoundField();
		val.DataField = "MedLow";
		val.HeaderText = "MedLow";
		((DataControlField)val).SortExpression = "MedLow";
		if (((TemplateControl)this).TestDeviceFilter("__designer"))
		{
			((IAttributeAccessor)val).SetAttribute("dtid", "1125899906842639");
		}
		return val;
	}

	[DebuggerNonUserCode]
	private BoundField __BuildControl__control45()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		BoundField val = new BoundField();
		val.DataField = "MedHigh";
		val.HeaderText = "MedHigh";
		((DataControlField)val).SortExpression = "MedHigh";
		if (((TemplateControl)this).TestDeviceFilter("__designer"))
		{
			((IAttributeAccessor)val).SetAttribute("dtid", "1125899906842640");
		}
		return val;
	}

	[DebuggerNonUserCode]
	private BoundField __BuildControl__control46()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		BoundField val = new BoundField();
		val.DataField = "Medopt";
		val.HeaderText = "Medopt";
		((DataControlField)val).SortExpression = "Medopt";
		if (((TemplateControl)this).TestDeviceFilter("__designer"))
		{
			((IAttributeAccessor)val).SetAttribute("dtid", "1125899906842641");
		}
		return val;
	}

	[DebuggerNonUserCode]
	private BoundField __BuildControl__control47()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		BoundField val = new BoundField();
		val.DataField = "MedScale";
		val.HeaderText = "MedScale";
		((DataControlField)val).SortExpression = "MedScale";
		if (((TemplateControl)this).TestDeviceFilter("__designer"))
		{
			((IAttributeAccessor)val).SetAttribute("dtid", "1125899906842642");
		}
		return val;
	}

	[DebuggerNonUserCode]
	private BoundField __BuildControl__control48()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		BoundField val = new BoundField();
		val.DataField = "DocLow";
		val.HeaderText = "DocLow";
		((DataControlField)val).SortExpression = "DocLow";
		if (((TemplateControl)this).TestDeviceFilter("__designer"))
		{
			((IAttributeAccessor)val).SetAttribute("dtid", "1125899906842643");
		}
		return val;
	}

	[DebuggerNonUserCode]
	private BoundField __BuildControl__control49()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		BoundField val = new BoundField();
		val.DataField = "DocHigh";
		val.HeaderText = "DocHigh";
		((DataControlField)val).SortExpression = "DocHigh";
		if (((TemplateControl)this).TestDeviceFilter("__designer"))
		{
			((IAttributeAccessor)val).SetAttribute("dtid", "1125899906842644");
		}
		return val;
	}

	[DebuggerNonUserCode]
	private BoundField __BuildControl__control50()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		BoundField val = new BoundField();
		val.DataField = "DocOpt";
		val.HeaderText = "DocOpt";
		((DataControlField)val).SortExpression = "DocOpt";
		if (((TemplateControl)this).TestDeviceFilter("__designer"))
		{
			((IAttributeAccessor)val).SetAttribute("dtid", "1125899906842645");
		}
		return val;
	}

	[DebuggerNonUserCode]
	private BoundField __BuildControl__control51()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		BoundField val = new BoundField();
		val.DataField = "DocScale";
		val.HeaderText = "DocScale";
		((DataControlField)val).SortExpression = "DocScale";
		if (((TemplateControl)this).TestDeviceFilter("__designer"))
		{
			((IAttributeAccessor)val).SetAttribute("dtid", "1125899906842646");
		}
		return val;
	}

	[DebuggerNonUserCode]
	private TextBox __BuildControl__control54()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		TextBox val = new TextBox();
		((Control)val).TemplateControl = (TemplateControl)(object)this;
		((Control)val).ApplyStyleSheetSkin((Page)(object)this);
		if (((TemplateControl)this).TestDeviceFilter("__designer"))
		{
			((IAttributeAccessor)val).SetAttribute("dtid", "1125899906842649");
		}
		((Control)val).ID = "TextBox1";
		((Control)val).DataBinding += __DataBinding__control54;
		return val;
	}

	public void __DataBinding__control54(object sender, EventArgs e)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Expected Obj, but got Unknown
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Expected Obj, but got Unknown
		TextBox val = (TextBox)sender;
		IDataItemContainer val2 = (IDataItemContainer)((Control)val).BindingContainer;
		if (((Control)this).Page.GetDataItem() != null)
		{
			val.Text = Convert.ToString(RuntimeHelpers.GetObjectValue(((TemplateControl)this).Eval("Result")), CultureInfo.CurrentCulture);
		}
	}

	[DebuggerNonUserCode]
	private void __BuildControl__control53(Control __ctrl)
	{
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Expected Obj, but got Unknown
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Expected Obj, but got Unknown
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		if (((TemplateControl)this).TestDeviceFilter("__designer"))
		{
			((IAttributeAccessor)__ctrl).SetAttribute("dtid", "1125899906842648");
		}
		((IParserAccessor)__ctrl).AddParsedSubObject((object)new LiteralControl("\r\n                                        "));
		TextBox val = __BuildControl__control54();
		((IParserAccessor)__ctrl).AddParsedSubObject((object)val);
		((IParserAccessor)__ctrl).AddParsedSubObject((object)new LiteralControl("\r\n                                    "));
	}

	[DebuggerNonUserCode]
	public IOrderedDictionary __ExtractValues__control53(Control __container)
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Expected Obj, but got Unknown
		TextBox val = (TextBox)__container.FindControl("TextBox1");
		OrderedDictionary orderedDictionary = new OrderedDictionary();
		if (val != null)
		{
			orderedDictionary["Result"] = val.Text;
		}
		return orderedDictionary;
	}

	[DebuggerNonUserCode]
	private Image __BuildControl__control56()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Image val = new Image();
		((Control)val).TemplateControl = (TemplateControl)(object)this;
		((Control)val).ApplyStyleSheetSkin((Page)(object)this);
		if (((TemplateControl)this).TestDeviceFilter("__designer"))
		{
			((IAttributeAccessor)val).SetAttribute("dtid", "1125899906842651");
		}
		((Control)val).ID = "Image1";
		((Control)val).DataBinding += __DataBinding__control56;
		return val;
	}

	public void __DataBinding__control56(object sender, EventArgs e)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Expected Obj, but got Unknown
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Expected Obj, but got Unknown
		Image val = (Image)sender;
		IDataItemContainer val2 = (IDataItemContainer)((Control)val).BindingContainer;
		val.ImageUrl = Convert.ToString(((TemplateControl)this).Eval("Result", "bar.aspx?scale={0}&") + ((TemplateControl)this).Eval("DocLow", "dl={0}&") + ((TemplateControl)this).Eval("DocHigh", "dh={0}&") + ((TemplateControl)this).Eval("MedLow", "ml={0}&") + ((TemplateControl)this).Eval("MedHigh", "mh={0}&"), CultureInfo.CurrentCulture);
	}

	[DebuggerNonUserCode]
	private void __BuildControl__control55(Control __ctrl)
	{
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Expected Obj, but got Unknown
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Expected Obj, but got Unknown
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		if (((TemplateControl)this).TestDeviceFilter("__designer"))
		{
			((IAttributeAccessor)__ctrl).SetAttribute("dtid", "1125899906842650");
		}
		((IParserAccessor)__ctrl).AddParsedSubObject((object)new LiteralControl("\r\n                                        "));
		Image val = __BuildControl__control56();
		((IParserAccessor)__ctrl).AddParsedSubObject((object)val);
		((IParserAccessor)__ctrl).AddParsedSubObject((object)new LiteralControl("\r\n                                    "));
	}

	[DebuggerNonUserCode]
	private TemplateField __BuildControl__control52()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Expected Obj, but got Unknown
		//IL_0026: Expected Obj, but got Unknown
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Expected Obj, but got Unknown
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Expected Obj, but got Unknown
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Expected Obj, but got Unknown
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		TemplateField val = new TemplateField();
		val.EditItemTemplate = (ITemplate)new CompiledBindableTemplateBuilder((BuildTemplateMethod)__BuildControl__control53, (ExtractTemplateValuesMethod)__ExtractValues__control53);
		val.ItemTemplate = (ITemplate)new CompiledBindableTemplateBuilder((BuildTemplateMethod)__BuildControl__control55, (ExtractTemplateValuesMethod)null);
		((DataControlField)val).HeaderText = "Result";
		((DataControlField)val).SortExpression = "Result";
		if (((TemplateControl)this).TestDeviceFilter("__designer"))
		{
			((IAttributeAccessor)val).SetAttribute("dtid", "1125899906842647");
		}
		return val;
	}

	[DebuggerNonUserCode]
	private void __BuildControl__control36(DataControlFieldCollection __ctrl)
	{
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		if (((TemplateControl)this).TestDeviceFilter("__designer"))
		{
			((IAttributeAccessor)__ctrl).SetAttribute("dtid", "1125899906842631");
		}
		TemplateField val = __BuildControl__control37();
		__ctrl.Add((DataControlField)(object)val);
		BoundField val2 = __BuildControl__control42();
		__ctrl.Add((DataControlField)(object)val2);
		BoundField val3 = __BuildControl__control43();
		__ctrl.Add((DataControlField)(object)val3);
		BoundField val4 = __BuildControl__control44();
		__ctrl.Add((DataControlField)(object)val4);
		BoundField val5 = __BuildControl__control45();
		__ctrl.Add((DataControlField)(object)val5);
		BoundField val6 = __BuildControl__control46();
		__ctrl.Add((DataControlField)(object)val6);
		BoundField val7 = __BuildControl__control47();
		__ctrl.Add((DataControlField)(object)val7);
		BoundField val8 = __BuildControl__control48();
		__ctrl.Add((DataControlField)(object)val8);
		BoundField val9 = __BuildControl__control49();
		__ctrl.Add((DataControlField)(object)val9);
		BoundField val10 = __BuildControl__control50();
		__ctrl.Add((DataControlField)(object)val10);
		BoundField val11 = __BuildControl__control51();
		__ctrl.Add((DataControlField)(object)val11);
		TemplateField val12 = __BuildControl__control52();
		__ctrl.Add((DataControlField)(object)val12);
	}

	[DebuggerNonUserCode]
	private GridView __BuildControlGridView2()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		GridView val = (GridView2 = new GridView());
		((Control)val).TemplateControl = (TemplateControl)(object)this;
		((Control)val).ApplyStyleSheetSkin((Page)(object)this);
		((Control)val).ID = "GridView2";
		((DataBoundControl)val).DataSourceID = "SqlDataSource1";
		val.EmptyDataText = "There are no data records to display.";
		val.DataKeyNames = new string[1] { "Testid" };
		val.AutoGenerateColumns = false;
		if (((TemplateControl)this).TestDeviceFilter("__designer"))
		{
			((IAttributeAccessor)val).SetAttribute("dtid", "1125899906842630");
		}
		if (((TemplateControl)this).TestDeviceFilter("__designer"))
		{
			((IAttributeAccessor)val).SetAttribute("wfdid", "w1");
		}
		__BuildControl__control36(val.Columns);
		return val;
	}

	[DebuggerNonUserCode]
	private Parameter __BuildControl__control58()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		Parameter val = new Parameter();
		val.Name = "Testid";
		if (((TemplateControl)this).TestDeviceFilter("__designer"))
		{
			((IAttributeAccessor)val).SetAttribute("dtid", "1125899906842684");
		}
		return val;
	}

	[DebuggerNonUserCode]
	private void __BuildControl__control57(ParameterCollection __ctrl)
	{
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		if (((TemplateControl)this).TestDeviceFilter("__designer"))
		{
			((IAttributeAccessor)__ctrl).SetAttribute("dtid", "1125899906842683");
		}
		Parameter val = __BuildControl__control58();
		__ctrl.Add(val);
	}

	[DebuggerNonUserCode]
	private Parameter __BuildControl__control60()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		Parameter val = new Parameter();
		val.Name = "Testid";
		val.Type = TypeCode.Int32;
		if (((TemplateControl)this).TestDeviceFilter("__designer"))
		{
			((IAttributeAccessor)val).SetAttribute("dtid", "1125899906842682");
		}
		return val;
	}

	[DebuggerNonUserCode]
	private void __BuildControl__control59(ParameterCollection __ctrl)
	{
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		if (((TemplateControl)this).TestDeviceFilter("__designer"))
		{
			((IAttributeAccessor)__ctrl).SetAttribute("dtid", "1125899906842681");
		}
		Parameter val = __BuildControl__control60();
		__ctrl.Add(val);
	}

	[DebuggerNonUserCode]
	private Parameter __BuildControl__control62()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		Parameter val = new Parameter();
		val.Name = "Result";
		val.Type = TypeCode.Double;
		if (((TemplateControl)this).TestDeviceFilter("__designer"))
		{
			((IAttributeAccessor)val).SetAttribute("dtid", "1125899906842668");
		}
		return val;
	}

	[DebuggerNonUserCode]
	private Parameter __BuildControl__control63()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		Parameter val = new Parameter();
		val.Name = "rid";
		val.Type = TypeCode.Int32;
		if (((TemplateControl)this).TestDeviceFilter("__designer"))
		{
			((IAttributeAccessor)val).SetAttribute("dtid", "1125899906842669");
		}
		return val;
	}

	[DebuggerNonUserCode]
	private Parameter __BuildControl__control64()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		Parameter val = new Parameter();
		val.Name = "TestAbrev";
		val.Type = TypeCode.String;
		if (((TemplateControl)this).TestDeviceFilter("__designer"))
		{
			((IAttributeAccessor)val).SetAttribute("dtid", "1125899906842670");
		}
		return val;
	}

	[DebuggerNonUserCode]
	private Parameter __BuildControl__control65()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		Parameter val = new Parameter();
		val.Name = "MedLow";
		val.Type = TypeCode.Double;
		if (((TemplateControl)this).TestDeviceFilter("__designer"))
		{
			((IAttributeAccessor)val).SetAttribute("dtid", "1125899906842671");
		}
		return val;
	}

	[DebuggerNonUserCode]
	private Parameter __BuildControl__control66()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		Parameter val = new Parameter();
		val.Name = "MedHigh";
		val.Type = TypeCode.Double;
		if (((TemplateControl)this).TestDeviceFilter("__designer"))
		{
			((IAttributeAccessor)val).SetAttribute("dtid", "1125899906842672");
		}
		return val;
	}

	[DebuggerNonUserCode]
	private Parameter __BuildControl__control67()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		Parameter val = new Parameter();
		val.Name = "Medopt";
		val.Type = TypeCode.Double;
		if (((TemplateControl)this).TestDeviceFilter("__designer"))
		{
			((IAttributeAccessor)val).SetAttribute("dtid", "1125899906842673");
		}
		return val;
	}

	[DebuggerNonUserCode]
	private Parameter __BuildControl__control68()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		Parameter val = new Parameter();
		val.Name = "MedScale";
		val.Type = TypeCode.Double;
		if (((TemplateControl)this).TestDeviceFilter("__designer"))
		{
			((IAttributeAccessor)val).SetAttribute("dtid", "1125899906842674");
		}
		return val;
	}

	[DebuggerNonUserCode]
	private Parameter __BuildControl__control69()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		Parameter val = new Parameter();
		val.Name = "UserName";
		val.Type = TypeCode.String;
		if (((TemplateControl)this).TestDeviceFilter("__designer"))
		{
			((IAttributeAccessor)val).SetAttribute("dtid", "1125899906842675");
		}
		return val;
	}

	[DebuggerNonUserCode]
	private Parameter __BuildControl__control70()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		Parameter val = new Parameter();
		val.Name = "DocLow";
		val.Type = TypeCode.Double;
		if (((TemplateControl)this).TestDeviceFilter("__designer"))
		{
			((IAttributeAccessor)val).SetAttribute("dtid", "1125899906842676");
		}
		return val;
	}

	[DebuggerNonUserCode]
	private Parameter __BuildControl__control71()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		Parameter val = new Parameter();
		val.Name = "DocHigh";
		val.Type = TypeCode.Double;
		if (((TemplateControl)this).TestDeviceFilter("__designer"))
		{
			((IAttributeAccessor)val).SetAttribute("dtid", "1125899906842677");
		}
		return val;
	}

	[DebuggerNonUserCode]
	private Parameter __BuildControl__control72()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		Parameter val = new Parameter();
		val.Name = "DocOpt";
		val.Type = TypeCode.Double;
		if (((TemplateControl)this).TestDeviceFilter("__designer"))
		{
			((IAttributeAccessor)val).SetAttribute("dtid", "1125899906842678");
		}
		return val;
	}

	[DebuggerNonUserCode]
	private Parameter __BuildControl__control73()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		Parameter val = new Parameter();
		val.Name = "DocScale";
		val.Type = TypeCode.Double;
		if (((TemplateControl)this).TestDeviceFilter("__designer"))
		{
			((IAttributeAccessor)val).SetAttribute("dtid", "1125899906842679");
		}
		return val;
	}

	[DebuggerNonUserCode]
	private Parameter __BuildControl__control74()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		Parameter val = new Parameter();
		val.Name = "Testid";
		val.Type = TypeCode.Int32;
		if (((TemplateControl)this).TestDeviceFilter("__designer"))
		{
			((IAttributeAccessor)val).SetAttribute("dtid", "1125899906842680");
		}
		return val;
	}

	[DebuggerNonUserCode]
	private void __BuildControl__control61(ParameterCollection __ctrl)
	{
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		if (((TemplateControl)this).TestDeviceFilter("__designer"))
		{
			((IAttributeAccessor)__ctrl).SetAttribute("dtid", "1125899906842667");
		}
		Parameter val = __BuildControl__control62();
		__ctrl.Add(val);
		Parameter val2 = __BuildControl__control63();
		__ctrl.Add(val2);
		Parameter val3 = __BuildControl__control64();
		__ctrl.Add(val3);
		Parameter val4 = __BuildControl__control65();
		__ctrl.Add(val4);
		Parameter val5 = __BuildControl__control66();
		__ctrl.Add(val5);
		Parameter val6 = __BuildControl__control67();
		__ctrl.Add(val6);
		Parameter val7 = __BuildControl__control68();
		__ctrl.Add(val7);
		Parameter val8 = __BuildControl__control69();
		__ctrl.Add(val8);
		Parameter val9 = __BuildControl__control70();
		__ctrl.Add(val9);
		Parameter val10 = __BuildControl__control71();
		__ctrl.Add(val10);
		Parameter val11 = __BuildControl__control72();
		__ctrl.Add(val11);
		Parameter val12 = __BuildControl__control73();
		__ctrl.Add(val12);
		Parameter val13 = __BuildControl__control74();
		__ctrl.Add(val13);
	}

	[DebuggerNonUserCode]
	private ControlParameter __BuildControl__control76()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		ControlParameter val = new ControlParameter();
		val.ControlID = "Topt";
		val.PropertyName = "Text";
		((Parameter)val).Name = "Result";
		((Parameter)val).Type = TypeCode.Double;
		return val;
	}

	[DebuggerNonUserCode]
	private Parameter __BuildControl__control77()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		Parameter val = new Parameter();
		val.Name = "rid";
		val.Type = TypeCode.Int32;
		if (((TemplateControl)this).TestDeviceFilter("__designer"))
		{
			((IAttributeAccessor)val).SetAttribute("dtid", "1125899906842656");
		}
		return val;
	}

	[DebuggerNonUserCode]
	private Parameter __BuildControl__control78()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		Parameter val = new Parameter();
		val.Name = "TestAbrev";
		val.Type = TypeCode.String;
		if (((TemplateControl)this).TestDeviceFilter("__designer"))
		{
			((IAttributeAccessor)val).SetAttribute("dtid", "1125899906842657");
		}
		return val;
	}

	[DebuggerNonUserCode]
	private ControlParameter __BuildControl__control79()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		ControlParameter val = new ControlParameter();
		val.ControlID = "TLow";
		val.PropertyName = "Text";
		((Parameter)val).Name = "MedLow";
		((Parameter)val).Type = TypeCode.Double;
		return val;
	}

	[DebuggerNonUserCode]
	private ControlParameter __BuildControl__control80()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		ControlParameter val = new ControlParameter();
		val.ControlID = "Thigh";
		val.PropertyName = "Text";
		((Parameter)val).Name = "MedHigh";
		((Parameter)val).Type = TypeCode.Double;
		return val;
	}

	[DebuggerNonUserCode]
	private Parameter __BuildControl__control81()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		Parameter val = new Parameter();
		val.Name = "Medopt";
		val.Type = TypeCode.Double;
		if (((TemplateControl)this).TestDeviceFilter("__designer"))
		{
			((IAttributeAccessor)val).SetAttribute("dtid", "1125899906842660");
		}
		return val;
	}

	[DebuggerNonUserCode]
	private Parameter __BuildControl__control82()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		Parameter val = new Parameter();
		val.Name = "MedScale";
		val.Type = TypeCode.Double;
		if (((TemplateControl)this).TestDeviceFilter("__designer"))
		{
			((IAttributeAccessor)val).SetAttribute("dtid", "1125899906842661");
		}
		return val;
	}

	[DebuggerNonUserCode]
	private Parameter __BuildControl__control83()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		Parameter val = new Parameter();
		val.Name = "UserName";
		val.Type = TypeCode.String;
		if (((TemplateControl)this).TestDeviceFilter("__designer"))
		{
			((IAttributeAccessor)val).SetAttribute("dtid", "1125899906842662");
		}
		return val;
	}

	[DebuggerNonUserCode]
	private Parameter __BuildControl__control84()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		Parameter val = new Parameter();
		val.Name = "DocLow";
		val.Type = TypeCode.Double;
		if (((TemplateControl)this).TestDeviceFilter("__designer"))
		{
			((IAttributeAccessor)val).SetAttribute("dtid", "1125899906842663");
		}
		return val;
	}

	[DebuggerNonUserCode]
	private Parameter __BuildControl__control85()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		Parameter val = new Parameter();
		val.Name = "DocOpt";
		val.Type = TypeCode.Double;
		if (((TemplateControl)this).TestDeviceFilter("__designer"))
		{
			((IAttributeAccessor)val).SetAttribute("dtid", "1125899906842665");
		}
		return val;
	}

	[DebuggerNonUserCode]
	private Parameter __BuildControl__control86()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		Parameter val = new Parameter();
		val.Name = "DocHigh";
		val.Type = TypeCode.Double;
		if (((TemplateControl)this).TestDeviceFilter("__designer"))
		{
			((IAttributeAccessor)val).SetAttribute("dtid", "1125899906842664");
		}
		return val;
	}

	[DebuggerNonUserCode]
	private Parameter __BuildControl__control87()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		Parameter val = new Parameter();
		val.Name = "DocScale";
		val.Type = TypeCode.Double;
		if (((TemplateControl)this).TestDeviceFilter("__designer"))
		{
			((IAttributeAccessor)val).SetAttribute("dtid", "1125899906842666");
		}
		return val;
	}

	[DebuggerNonUserCode]
	private Parameter __BuildControl__control88()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Parameter val = new Parameter();
		val.Name = "Testid";
		return val;
	}

	[DebuggerNonUserCode]
	private void __BuildControl__control75(ParameterCollection __ctrl)
	{
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		if (((TemplateControl)this).TestDeviceFilter("__designer"))
		{
			((IAttributeAccessor)__ctrl).SetAttribute("dtid", "1125899906842654");
		}
		ControlParameter val = __BuildControl__control76();
		__ctrl.Add((Parameter)(object)val);
		Parameter val2 = __BuildControl__control77();
		__ctrl.Add(val2);
		Parameter val3 = __BuildControl__control78();
		__ctrl.Add(val3);
		ControlParameter val4 = __BuildControl__control79();
		__ctrl.Add((Parameter)(object)val4);
		ControlParameter val5 = __BuildControl__control80();
		__ctrl.Add((Parameter)(object)val5);
		Parameter val6 = __BuildControl__control81();
		__ctrl.Add(val6);
		Parameter val7 = __BuildControl__control82();
		__ctrl.Add(val7);
		Parameter val8 = __BuildControl__control83();
		__ctrl.Add(val8);
		Parameter val9 = __BuildControl__control84();
		__ctrl.Add(val9);
		Parameter val10 = __BuildControl__control85();
		__ctrl.Add(val10);
		Parameter val11 = __BuildControl__control86();
		__ctrl.Add(val11);
		Parameter val12 = __BuildControl__control87();
		__ctrl.Add(val12);
		Parameter val13 = __BuildControl__control88();
		__ctrl.Add(val13);
	}

	[DebuggerNonUserCode]
	private SqlDataSource __BuildControlSqlDataSource1()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		SqlDataSource val = (SqlDataSource1 = new SqlDataSource());
		((Control)val).TemplateControl = (TemplateControl)(object)this;
		((Control)val).ID = "SqlDataSource1";
		val.UpdateCommand = "UPDATE [ResultRef] SET [Result] = @Result, [rid] = @rid, [TestAbrev] = @TestAbrev, [MedLow] = @MedLow, [MedHigh] = @MedHigh, [Medopt] = @Medopt, [MedScale] = @MedScale, [UserName] = @UserName, [DocLow] = @DocLow, [DocHigh] = @DocHigh, [DocOpt] = @DocOpt, [DocScale] = @DocScale WHERE [Testid] = @Testid";
		val.SelectCommand = "SELECT Result, rid, TestAbrev, MedLow, MedHigh, Medopt, MedScale, UserName, DocLow, DocHigh, DocOpt, DocScale, Testid FROM ResultRef WHERE (Testid = @Testid) ORDER BY ABS(DocScale) DESC";
		val.InsertCommand = "addedit";
		val.DeleteCommand = "DELETE FROM [ResultRef] WHERE [Testid] = @Testid";
		val.InsertCommandType = (SqlDataSourceCommandType)1;
		if (((TemplateControl)this).TestDeviceFilter("__designer"))
		{
			((IAttributeAccessor)val).SetAttribute("dtid", "1125899906842653");
		}
		if (((TemplateControl)this).TestDeviceFilter("__designer"))
		{
			((IAttributeAccessor)val).SetAttribute("wfdid", "w15");
		}
		__BuildControl__control57(val.SelectParameters);
		__BuildControl__control59(val.DeleteParameters);
		__BuildControl__control61(val.UpdateParameters);
		__BuildControl__control75(val.InsertParameters);
		val.ConnectionString = Convert.ToString(ConnectionStringsExpressionBuilder.GetConnectionString("nazdiltarinConnectionString"), CultureInfo.CurrentCulture);
		return val;
	}

	[DebuggerNonUserCode]
	private Button __BuildControlButton2()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		Button val = (Button2 = new Button());
		((Control)val).TemplateControl = (TemplateControl)(object)this;
		((Control)val).ApplyStyleSheetSkin((Page)(object)this);
		((Control)val).ID = "Button2";
		Unit width = new Unit(122.0, (UnitType)1);
		((WebControl)val).Width = width;
		val.Text = "Done";
		if (((TemplateControl)this).TestDeviceFilter("__designer"))
		{
			((IAttributeAccessor)val).SetAttribute("wfdid", "w16");
		}
		val.Click += Button2_Click1;
		return val;
	}

	[DebuggerNonUserCode]
	private void __BuildControlContent1(Control __ctrl)
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected Obj, but got Unknown
		//IL_0083: Unknown result type (might be due to invalid IL or missing references)
		//IL_008d: Expected Obj, but got Unknown
		//IL_00a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00af: Expected Obj, but got Unknown
		//IL_00c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d1: Expected Obj, but got Unknown
		//IL_00e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f3: Expected Obj, but got Unknown
		((IParserAccessor)__ctrl).AddParsedSubObject((object)new LiteralControl("\r\n    <table border=\"0\" cellpadding=\"0\" cellspacing=\"0\" style=\"width: 100%; height: 100%\">\r\n        <tr>\r\n            <td align=\"center\">\r\n                &nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;\r\n                "));
		AutoCompleteExtender autoCompleteExtender = __BuildControlAutoCompleteExtender1();
		((IParserAccessor)__ctrl).AddParsedSubObject((object)autoCompleteExtender);
		((IParserAccessor)__ctrl).AddParsedSubObject((object)((TemplateControl)this).CreateResourceBasedLiteralControl(0, 399, true));
		TextBox val = __BuildControlmyTextBox();
		((IParserAccessor)__ctrl).AddParsedSubObject((object)val);
		Button val2 = __BuildControlButton1();
		((IParserAccessor)__ctrl).AddParsedSubObject((object)val2);
		((IParserAccessor)__ctrl).AddParsedSubObject((object)((TemplateControl)this).CreateResourceBasedLiteralControl(399, 321, true));
		HtmlTable val3 = __BuildControlTABLE1();
		((IParserAccessor)__ctrl).AddParsedSubObject((object)val3);
		((IParserAccessor)__ctrl).AddParsedSubObject((object)new LiteralControl("\r\n                                    </td>\r\n                                </tr>\r\n                            </tbody>\r\n                        </table>\r\n                        <br />\r\n                        &nbsp;\r\n                        "));
		GridView val4 = __BuildControlGridView2();
		((IParserAccessor)__ctrl).AddParsedSubObject((object)val4);
		((IParserAccessor)__ctrl).AddParsedSubObject((object)new LiteralControl("\r\n                        "));
		SqlDataSource val5 = __BuildControlSqlDataSource1();
		((IParserAccessor)__ctrl).AddParsedSubObject((object)val5);
		((IParserAccessor)__ctrl).AddParsedSubObject((object)new LiteralControl("\r\n                        "));
		Button val6 = __BuildControlButton2();
		((IParserAccessor)__ctrl).AddParsedSubObject((object)val6);
		((IParserAccessor)__ctrl).AddParsedSubObject((object)new LiteralControl("\r\n                    </ContentTemplate>\r\n               \r\n                &nbsp; &nbsp;&nbsp;\r\n            </td>\r\n        </tr>\r\n        <tr>\r\n            <td>\r\n             \r\n            </td>\r\n        </tr>\r\n    </table>\r\n"));
	}

	[DebuggerNonUserCode]
	private void __BuildControlTree(labcalc_onebyone_aspx __ctrl)
	{
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Expected Obj, but got Unknown
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Expected Obj, but got Unknown
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Expected Obj, but got Unknown
		((Page)__ctrl).MasterPageFile = "~/master1.master";
		((Page)__ctrl).Title = "Mental Stress Tester :: Add results";
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
		return -1659973222;
	}

	[DebuggerNonUserCode]
	public override void ProcessRequest(HttpContext context)
	{
		((Page)this).ProcessRequest(context);
	}
}
