using System;
using System.Collections.Specialized;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Web;
using System.Web.Compilation;
using System.Web.UI;
using System.Web.UI.WebControls;
using AjaxControlToolkit;
using PayPal.Web.Controls;

namespace ASP;

[CompilerGlobalScope]
public class labcalc_resultview_aspx : LabCalc_ResultView
{
	private static bool __initialized;

	private static object __stringResource;

	private static object __fileDependencies;

	protected override bool SupportAutoEvents => false;

	[DebuggerNonUserCode]
	public labcalc_resultview_aspx()
	{
		((TemplateControl)this).AppRelativeVirtualPath = "~/LabCalc/ResultView.aspx";
		if (!__initialized)
		{
			__stringResource = RuntimeHelpers.GetObjectValue(((TemplateControl)this).ReadStringResource());
			__fileDependencies = RuntimeHelpers.GetObjectValue(((Page)this).GetWrappedFileDependencies(new string[4] { "~/LabCalc/ResultView.aspx", "~/master1.master", "~/master1.master.vb", "~/LabCalc/ResultView.aspx.vb" }));
			__initialized = true;
		}
		((Page)this).Server.ScriptTimeout = 30000000;
	}

	[DebuggerNonUserCode]
	private ListItem __BuildControl__control3()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		ListItem val = new ListItem();
		val.Value = "DScale";
		val.Text = "Sort By Doctor's Scale";
		return val;
	}

	[DebuggerNonUserCode]
	private ListItem __BuildControl__control4()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		ListItem val = new ListItem();
		val.Text = "Medical Scale";
		return val;
	}

	[DebuggerNonUserCode]
	private ListItem __BuildControl__control5()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		ListItem val = new ListItem();
		val.Value = "DBoth";
		val.Text = "Doctor's & Category";
		return val;
	}

	[DebuggerNonUserCode]
	private ListItem __BuildControl__control6()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		ListItem val = new ListItem();
		val.Value = "Mboth";
		val.Text = "Mediccal & Category";
		return val;
	}

	[DebuggerNonUserCode]
	private ListItem __BuildControl__control7()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		ListItem val = new ListItem();
		val.Value = "Category";
		val.Text = "Sort By Category & DocScale Over 70%";
		return val;
	}

	[DebuggerNonUserCode]
	private ListItem __BuildControl__control8()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		ListItem val = new ListItem();
		val.Text = "Sort By Category & MedScale Over 70%";
		return val;
	}

	[DebuggerNonUserCode]
	private void __BuildControl__control2(ListItemCollection __ctrl)
	{
		ListItem val = __BuildControl__control3();
		__ctrl.Add(val);
		ListItem val2 = __BuildControl__control4();
		__ctrl.Add(val2);
		ListItem val3 = __BuildControl__control5();
		__ctrl.Add(val3);
		ListItem val4 = __BuildControl__control6();
		__ctrl.Add(val4);
		ListItem val5 = __BuildControl__control7();
		__ctrl.Add(val5);
		ListItem val6 = __BuildControl__control8();
		__ctrl.Add(val6);
	}

	[DebuggerNonUserCode]
	private RadioButtonList __BuildControlRadioButtonList2()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		RadioButtonList val = (RadioButtonList2 = new RadioButtonList());
		((Control)val).ApplyStyleSheetSkin((Page)(object)this);
		((Control)val).ID = "RadioButtonList2";
		((ListControl)val).AutoPostBack = true;
		val.RepeatDirection = (RepeatDirection)0;
		__BuildControl__control2(((ListControl)val).Items);
		return val;
	}

	[DebuggerNonUserCode]
	private Button __BuildControlButton2()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Button val = (Button2 = new Button());
		((Control)val).ApplyStyleSheetSkin((Page)(object)this);
		((Control)val).ID = "Button2";
		val.Text = "Get advice for selected item(s)  (max=6)";
		return val;
	}

	[DebuggerNonUserCode]
	private Button __BuildControlButton5()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Button val = (Button5 = new Button());
		((Control)val).ApplyStyleSheetSkin((Page)(object)this);
		((Control)val).ID = "Button5";
		val.OnClientClick = "return confirm('Are you sure you want to delete this record? There will be no way to recover a deleted test.');";
		val.Text = "Delete selected item(s)";
		return val;
	}

	[DebuggerNonUserCode]
	private Button __BuildControlbtnAddtest()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Button val = (btnAddtest = new Button());
		((Control)val).ApplyStyleSheetSkin((Page)(object)this);
		((Control)val).ID = "btnAddtest";
		val.Text = "Add / Update";
		return val;
	}

	[DebuggerNonUserCode]
	private Button __BuildControlButton6()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Button val = (Button6 = new Button());
		((Control)val).ApplyStyleSheetSkin((Page)(object)this);
		((Control)val).ID = "Button6";
		val.Text = "Recalculate Ratios";
		return val;
	}

	[DebuggerNonUserCode]
	private CheckBox __BuildControl__control13()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		CheckBox val = new CheckBox();
		((Control)val).TemplateControl = (TemplateControl)(object)this;
		((Control)val).ApplyStyleSheetSkin((Page)(object)this);
		((Control)val).ID = "CheckBox1";
		return val;
	}

	[DebuggerNonUserCode]
	private void __BuildControl__control12(Control __ctrl)
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Expected Obj, but got Unknown
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Expected Obj, but got Unknown
		((IParserAccessor)__ctrl).AddParsedSubObject((object)new LiteralControl("\r\n                                    "));
		CheckBox val = __BuildControl__control13();
		((IParserAccessor)__ctrl).AddParsedSubObject((object)val);
		((IParserAccessor)__ctrl).AddParsedSubObject((object)new LiteralControl("\r\n                                "));
	}

	[DebuggerNonUserCode]
	private CheckBox __BuildControl__control15()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		CheckBox val = new CheckBox();
		((Control)val).TemplateControl = (TemplateControl)(object)this;
		((Control)val).ApplyStyleSheetSkin((Page)(object)this);
		((Control)val).ID = "CBoks1";
		((Control)val).DataBinding += __DataBinding__control15;
		return val;
	}

	public void __DataBinding__control15(object sender, EventArgs e)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Expected Obj, but got Unknown
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Expected Obj, but got Unknown
		CheckBox val = (CheckBox)sender;
		IDataItemContainer val2 = (IDataItemContainer)((Control)val).BindingContainer;
		val.Text = Convert.ToString(RuntimeHelpers.GetObjectValue(((TemplateControl)this).Eval("rid")), CultureInfo.CurrentCulture);
	}

	[DebuggerNonUserCode]
	private void __BuildControl__control14(Control __ctrl)
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Expected Obj, but got Unknown
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Expected Obj, but got Unknown
		((IParserAccessor)__ctrl).AddParsedSubObject((object)new LiteralControl("\r\n                                    "));
		CheckBox val = __BuildControl__control15();
		((IParserAccessor)__ctrl).AddParsedSubObject((object)val);
		((IParserAccessor)__ctrl).AddParsedSubObject((object)new LiteralControl("\r\n                                "));
	}

	[DebuggerNonUserCode]
	private TemplateField __BuildControl__control11()
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
		TemplateField val = new TemplateField();
		val.EditItemTemplate = (ITemplate)new CompiledBindableTemplateBuilder((BuildTemplateMethod)__BuildControl__control12, (ExtractTemplateValuesMethod)null);
		val.ItemTemplate = (ITemplate)new CompiledBindableTemplateBuilder((BuildTemplateMethod)__BuildControl__control14, (ExtractTemplateValuesMethod)null);
		((DataControlField)val).HeaderText = "Select";
		return val;
	}

	[DebuggerNonUserCode]
	private BoundField __BuildControl__control16()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		BoundField val = new BoundField();
		val.DataField = "Result";
		val.HeaderText = "Result";
		((DataControlField)val).SortExpression = "Result";
		return val;
	}

	[DebuggerNonUserCode]
	private BoundField __BuildControl__control17()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		BoundField val = new BoundField();
		val.DataField = "TestAbrev";
		val.HeaderText = "ABR";
		((DataControlField)val).SortExpression = "TestAbrev";
		return val;
	}

	[DebuggerNonUserCode]
	private BoundField __BuildControl__control18()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		BoundField val = new BoundField();
		val.DataField = "Category";
		val.HeaderText = "Category";
		((DataControlField)val).SortExpression = "Category";
		return val;
	}

	[DebuggerNonUserCode]
	private void __BuildControl__control20(TableItemStyle __ctrl)
	{
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		((Style)__ctrl).BorderColor = Color.FromArgb(255, 128, 0);
		((Style)__ctrl).BorderStyle = (BorderStyle)4;
		Unit borderWidth = new Unit(1.0, (UnitType)1);
		((Style)__ctrl).BorderWidth = borderWidth;
	}

	[DebuggerNonUserCode]
	private BoundField __BuildControl__control19()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		BoundField val = new BoundField();
		val.DataField = "MedLow";
		val.HeaderText = "MedLow";
		((DataControlField)val).SortExpression = "MedLow";
		__BuildControl__control20(((DataControlField)val).ItemStyle);
		return val;
	}

	[DebuggerNonUserCode]
	private void __BuildControl__control22(TableItemStyle __ctrl)
	{
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		((Style)__ctrl).BorderColor = Color.FromArgb(255, 128, 0);
		((Style)__ctrl).BorderStyle = (BorderStyle)4;
		Unit borderWidth = new Unit(1.0, (UnitType)1);
		((Style)__ctrl).BorderWidth = borderWidth;
	}

	[DebuggerNonUserCode]
	private BoundField __BuildControl__control21()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		BoundField val = new BoundField();
		val.DataField = "MedHigh";
		val.HeaderText = "MedHigh";
		((DataControlField)val).SortExpression = "MedHigh";
		__BuildControl__control22(((DataControlField)val).ItemStyle);
		return val;
	}

	[DebuggerNonUserCode]
	private void __BuildControl__control24(TableItemStyle __ctrl)
	{
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		((Style)__ctrl).BorderColor = Color.Gold;
		((Style)__ctrl).BorderStyle = (BorderStyle)4;
		Unit borderWidth = new Unit(1.0, (UnitType)1);
		((Style)__ctrl).BorderWidth = borderWidth;
	}

	[DebuggerNonUserCode]
	private BoundField __BuildControl__control23()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		BoundField val = new BoundField();
		val.DataField = "Medopt";
		val.HeaderText = "MedOpt";
		((DataControlField)val).SortExpression = "Medopt";
		__BuildControl__control24(((DataControlField)val).ItemStyle);
		return val;
	}

	[DebuggerNonUserCode]
	private BoundField __BuildControl__control25()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		BoundField val = new BoundField();
		val.DataField = "MedScale";
		val.HeaderText = "MedScale";
		((DataControlField)val).SortExpression = "MedScale";
		return val;
	}

	[DebuggerNonUserCode]
	private void __BuildControl__control27(TableItemStyle __ctrl)
	{
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		((Style)__ctrl).BorderColor = Color.Lime;
		((Style)__ctrl).BorderStyle = (BorderStyle)4;
		Unit borderWidth = new Unit(1.0, (UnitType)1);
		((Style)__ctrl).BorderWidth = borderWidth;
	}

	[DebuggerNonUserCode]
	private BoundField __BuildControl__control26()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		BoundField val = new BoundField();
		val.DataField = "DocLow";
		val.HeaderText = "DocLow";
		((DataControlField)val).SortExpression = "DocLow";
		__BuildControl__control27(((DataControlField)val).ItemStyle);
		return val;
	}

	[DebuggerNonUserCode]
	private void __BuildControl__control29(TableItemStyle __ctrl)
	{
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		((Style)__ctrl).BorderColor = Color.Lime;
		((Style)__ctrl).BorderStyle = (BorderStyle)4;
		Unit borderWidth = new Unit(1.0, (UnitType)1);
		((Style)__ctrl).BorderWidth = borderWidth;
	}

	[DebuggerNonUserCode]
	private BoundField __BuildControl__control28()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		BoundField val = new BoundField();
		val.DataField = "DocHigh";
		val.HeaderText = "DocHigh";
		((DataControlField)val).SortExpression = "DocHigh";
		__BuildControl__control29(((DataControlField)val).ItemStyle);
		return val;
	}

	[DebuggerNonUserCode]
	private void __BuildControl__control31(TableItemStyle __ctrl)
	{
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		((Style)__ctrl).BorderColor = Color.GreenYellow;
		((Style)__ctrl).BorderStyle = (BorderStyle)4;
		Unit borderWidth = new Unit(1.0, (UnitType)1);
		((Style)__ctrl).BorderWidth = borderWidth;
	}

	[DebuggerNonUserCode]
	private BoundField __BuildControl__control30()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		BoundField val = new BoundField();
		val.DataField = "DocOpt";
		val.HeaderText = "DocOpt";
		((DataControlField)val).SortExpression = "DocOpt";
		__BuildControl__control31(((DataControlField)val).ItemStyle);
		return val;
	}

	[DebuggerNonUserCode]
	private void __BuildControl__control33(TableItemStyle __ctrl)
	{
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		((Style)__ctrl).BorderColor = Color.White;
		((Style)__ctrl).BorderStyle = (BorderStyle)2;
		Unit borderWidth = new Unit(1.0, (UnitType)1);
		((Style)__ctrl).BorderWidth = borderWidth;
	}

	[DebuggerNonUserCode]
	private BoundField __BuildControl__control32()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		BoundField val = new BoundField();
		val.DataField = "DocScale";
		val.HeaderText = "DocScale";
		((DataControlField)val).SortExpression = "DocScale";
		__BuildControl__control33(((DataControlField)val).ItemStyle);
		return val;
	}

	[DebuggerNonUserCode]
	private TextBox __BuildControl__control36()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		TextBox val = new TextBox();
		((Control)val).TemplateControl = (TemplateControl)(object)this;
		((Control)val).ApplyStyleSheetSkin((Page)(object)this);
		((Control)val).ID = "TextBox1";
		((Control)val).DataBinding += __DataBinding__control36;
		return val;
	}

	public void __DataBinding__control36(object sender, EventArgs e)
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
	private void __BuildControl__control35(Control __ctrl)
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Expected Obj, but got Unknown
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Expected Obj, but got Unknown
		((IParserAccessor)__ctrl).AddParsedSubObject((object)new LiteralControl("\r\n                                    "));
		TextBox val = __BuildControl__control36();
		((IParserAccessor)__ctrl).AddParsedSubObject((object)val);
		((IParserAccessor)__ctrl).AddParsedSubObject((object)new LiteralControl("\r\n                                "));
	}

	[DebuggerNonUserCode]
	public IOrderedDictionary __ExtractValues__control35(Control __container)
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
	private Image __BuildControl__control38()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Image val = new Image();
		((Control)val).TemplateControl = (TemplateControl)(object)this;
		((Control)val).ApplyStyleSheetSkin((Page)(object)this);
		((Control)val).ID = "Image1";
		((Control)val).DataBinding += __DataBinding__control38;
		return val;
	}

	public void __DataBinding__control38(object sender, EventArgs e)
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
	private void __BuildControl__control37(Control __ctrl)
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Expected Obj, but got Unknown
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Expected Obj, but got Unknown
		((IParserAccessor)__ctrl).AddParsedSubObject((object)new LiteralControl("\r\n                                    "));
		Image val = __BuildControl__control38();
		((IParserAccessor)__ctrl).AddParsedSubObject((object)val);
		((IParserAccessor)__ctrl).AddParsedSubObject((object)new LiteralControl("\r\n                                "));
	}

	[DebuggerNonUserCode]
	private TemplateField __BuildControl__control34()
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
		TemplateField val = new TemplateField();
		val.EditItemTemplate = (ITemplate)new CompiledBindableTemplateBuilder((BuildTemplateMethod)__BuildControl__control35, (ExtractTemplateValuesMethod)__ExtractValues__control35);
		val.ItemTemplate = (ITemplate)new CompiledBindableTemplateBuilder((BuildTemplateMethod)__BuildControl__control37, (ExtractTemplateValuesMethod)null);
		((DataControlField)val).HeaderText = "Result";
		((DataControlField)val).SortExpression = "Result";
		return val;
	}

	[DebuggerNonUserCode]
	private CommandField __BuildControl__control39()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		CommandField val = new CommandField();
		((DataControlField)val).HeaderText = "References";
		val.SelectText = "Learn More";
		val.ShowSelectButton = true;
		return val;
	}

	[DebuggerNonUserCode]
	private void __BuildControl__control10(DataControlFieldCollection __ctrl)
	{
		TemplateField val = __BuildControl__control11();
		__ctrl.Add((DataControlField)(object)val);
		BoundField val2 = __BuildControl__control16();
		__ctrl.Add((DataControlField)(object)val2);
		BoundField val3 = __BuildControl__control17();
		__ctrl.Add((DataControlField)(object)val3);
		BoundField val4 = __BuildControl__control18();
		__ctrl.Add((DataControlField)(object)val4);
		BoundField val5 = __BuildControl__control19();
		__ctrl.Add((DataControlField)(object)val5);
		BoundField val6 = __BuildControl__control21();
		__ctrl.Add((DataControlField)(object)val6);
		BoundField val7 = __BuildControl__control23();
		__ctrl.Add((DataControlField)(object)val7);
		BoundField val8 = __BuildControl__control25();
		__ctrl.Add((DataControlField)(object)val8);
		BoundField val9 = __BuildControl__control26();
		__ctrl.Add((DataControlField)(object)val9);
		BoundField val10 = __BuildControl__control28();
		__ctrl.Add((DataControlField)(object)val10);
		BoundField val11 = __BuildControl__control30();
		__ctrl.Add((DataControlField)(object)val11);
		BoundField val12 = __BuildControl__control32();
		__ctrl.Add((DataControlField)(object)val12);
		TemplateField val13 = __BuildControl__control34();
		__ctrl.Add((DataControlField)(object)val13);
		CommandField val14 = __BuildControl__control39();
		__ctrl.Add((DataControlField)(object)val14);
	}

	[DebuggerNonUserCode]
	private GridView __BuildControlGridView1()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		GridView val = (GridView1 = new GridView());
		((Control)val).TemplateControl = (TemplateControl)(object)this;
		((Control)val).ApplyStyleSheetSkin((Page)(object)this);
		((Control)val).ID = "GridView1";
		val.AutoGenerateColumns = false;
		Unit borderWidth = new Unit(1.0, (UnitType)1);
		((WebControl)val).BorderWidth = borderWidth;
		val.DataKeyNames = new string[1] { "Testid" };
		((DataBoundControl)val).DataSourceID = "SqlDataSource1";
		val.EmptyDataText = "There are no data records to display.";
		__BuildControl__control10(val.Columns);
		return val;
	}

	[DebuggerNonUserCode]
	private void __BuildControl__control9(Control __ctrl)
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Expected Obj, but got Unknown
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Expected Obj, but got Unknown
		((IParserAccessor)__ctrl).AddParsedSubObject((object)new LiteralControl("\r\n                    "));
		GridView val = __BuildControlGridView1();
		((IParserAccessor)__ctrl).AddParsedSubObject((object)val);
		((IParserAccessor)__ctrl).AddParsedSubObject((object)new LiteralControl("\r\n                "));
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
		val.ContentTemplate = (ITemplate)new CompiledTemplateBuilder((BuildTemplateMethod)__BuildControl__control9);
		((Control)val).ID = "UpdatePanel1";
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
		val3.AddParsedSubObject((object)new LiteralControl("Close [X]"));
		return val;
	}

	[DebuggerNonUserCode]
	private BoundField __BuildControl__control42()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		BoundField val = new BoundField();
		val.DataField = "bookname";
		val.HeaderText = "Book Name";
		((DataControlField)val).SortExpression = "bookname";
		return val;
	}

	[DebuggerNonUserCode]
	private BoundField __BuildControl__control43()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		BoundField val = new BoundField();
		val.DataField = "pagenum";
		val.HeaderText = "Page Number";
		((DataControlField)val).SortExpression = "pagenum";
		return val;
	}

	[DebuggerNonUserCode]
	private BoundField __BuildControl__control44()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		BoundField val = new BoundField();
		val.DataField = "authur";
		val.HeaderText = "Author";
		((DataControlField)val).SortExpression = "authur";
		return val;
	}

	[DebuggerNonUserCode]
	private BoundField __BuildControl__control45()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		BoundField val = new BoundField();
		val.DataField = "datepublished";
		val.HeaderText = "Date Published";
		((DataControlField)val).SortExpression = "datepublished";
		return val;
	}

	[DebuggerNonUserCode]
	private BoundField __BuildControl__control46()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		BoundField val = new BoundField();
		val.DataField = "note";
		val.HeaderText = "note";
		((DataControlField)val).SortExpression = "note";
		return val;
	}

	[DebuggerNonUserCode]
	private BoundField __BuildControl__control47()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		BoundField val = new BoundField();
		val.DataField = "F1";
		val.HeaderText = "Researcher";
		((DataControlField)val).SortExpression = "F1";
		return val;
	}

	[DebuggerNonUserCode]
	private void __BuildControl__control41(DataControlFieldCollection __ctrl)
	{
		BoundField val = __BuildControl__control42();
		__ctrl.Add((DataControlField)(object)val);
		BoundField val2 = __BuildControl__control43();
		__ctrl.Add((DataControlField)(object)val2);
		BoundField val3 = __BuildControl__control44();
		__ctrl.Add((DataControlField)(object)val3);
		BoundField val4 = __BuildControl__control45();
		__ctrl.Add((DataControlField)(object)val4);
		BoundField val5 = __BuildControl__control46();
		__ctrl.Add((DataControlField)(object)val5);
		BoundField val6 = __BuildControl__control47();
		__ctrl.Add((DataControlField)(object)val6);
	}

	[DebuggerNonUserCode]
	private GridView __BuildControlGridView5()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		GridView val = (GridView5 = new GridView());
		((Control)val).ApplyStyleSheetSkin((Page)(object)this);
		((Control)val).ID = "GridView5";
		val.AutoGenerateColumns = false;
		val.DataKeyNames = new string[1] { "bookreid" };
		((DataBoundControl)val).DataSourceID = "Sqlref";
		val.EmptyDataText = "There are no data records to display.";
		__BuildControl__control41(val.Columns);
		return val;
	}

	[DebuggerNonUserCode]
	private Parameter __BuildControl__control49()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Parameter val = new Parameter();
		val.Name = "testAbrev";
		val.Type = TypeCode.String;
		return val;
	}

	[DebuggerNonUserCode]
	private void __BuildControl__control48(ParameterCollection __ctrl)
	{
		Parameter val = __BuildControl__control49();
		__ctrl.Add(val);
	}

	[DebuggerNonUserCode]
	private Parameter __BuildControl__control51()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Parameter val = new Parameter();
		val.Name = "bookreid";
		val.Type = TypeCode.Int32;
		return val;
	}

	[DebuggerNonUserCode]
	private void __BuildControl__control50(ParameterCollection __ctrl)
	{
		Parameter val = __BuildControl__control51();
		__ctrl.Add(val);
	}

	[DebuggerNonUserCode]
	private Parameter __BuildControl__control53()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Parameter val = new Parameter();
		val.Name = "testAbrev";
		val.Type = TypeCode.String;
		return val;
	}

	[DebuggerNonUserCode]
	private Parameter __BuildControl__control54()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Parameter val = new Parameter();
		val.Name = "bookname";
		val.Type = TypeCode.String;
		return val;
	}

	[DebuggerNonUserCode]
	private Parameter __BuildControl__control55()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Parameter val = new Parameter();
		val.Name = "authur";
		val.Type = TypeCode.String;
		return val;
	}

	[DebuggerNonUserCode]
	private Parameter __BuildControl__control56()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Parameter val = new Parameter();
		val.Name = "datepublished";
		val.Type = TypeCode.String;
		return val;
	}

	[DebuggerNonUserCode]
	private Parameter __BuildControl__control57()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Parameter val = new Parameter();
		val.Name = "pagenum";
		val.Type = TypeCode.String;
		return val;
	}

	[DebuggerNonUserCode]
	private Parameter __BuildControl__control58()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Parameter val = new Parameter();
		val.Name = "note";
		val.Type = TypeCode.String;
		return val;
	}

	[DebuggerNonUserCode]
	private Parameter __BuildControl__control59()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Parameter val = new Parameter();
		val.Name = "F1";
		val.Type = TypeCode.String;
		return val;
	}

	[DebuggerNonUserCode]
	private void __BuildControl__control52(ParameterCollection __ctrl)
	{
		Parameter val = __BuildControl__control53();
		__ctrl.Add(val);
		Parameter val2 = __BuildControl__control54();
		__ctrl.Add(val2);
		Parameter val3 = __BuildControl__control55();
		__ctrl.Add(val3);
		Parameter val4 = __BuildControl__control56();
		__ctrl.Add(val4);
		Parameter val5 = __BuildControl__control57();
		__ctrl.Add(val5);
		Parameter val6 = __BuildControl__control58();
		__ctrl.Add(val6);
		Parameter val7 = __BuildControl__control59();
		__ctrl.Add(val7);
	}

	[DebuggerNonUserCode]
	private Parameter __BuildControl__control61()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Parameter val = new Parameter();
		val.Name = "testAbrev";
		val.Type = TypeCode.String;
		return val;
	}

	[DebuggerNonUserCode]
	private Parameter __BuildControl__control62()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Parameter val = new Parameter();
		val.Name = "bookname";
		val.Type = TypeCode.String;
		return val;
	}

	[DebuggerNonUserCode]
	private Parameter __BuildControl__control63()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Parameter val = new Parameter();
		val.Name = "authur";
		val.Type = TypeCode.String;
		return val;
	}

	[DebuggerNonUserCode]
	private Parameter __BuildControl__control64()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Parameter val = new Parameter();
		val.Name = "datepublished";
		val.Type = TypeCode.String;
		return val;
	}

	[DebuggerNonUserCode]
	private Parameter __BuildControl__control65()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Parameter val = new Parameter();
		val.Name = "pagenum";
		val.Type = TypeCode.String;
		return val;
	}

	[DebuggerNonUserCode]
	private Parameter __BuildControl__control66()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Parameter val = new Parameter();
		val.Name = "note";
		val.Type = TypeCode.String;
		return val;
	}

	[DebuggerNonUserCode]
	private Parameter __BuildControl__control67()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Parameter val = new Parameter();
		val.Name = "F1";
		val.Type = TypeCode.String;
		return val;
	}

	[DebuggerNonUserCode]
	private Parameter __BuildControl__control68()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Parameter val = new Parameter();
		val.Name = "bookreid";
		val.Type = TypeCode.Int32;
		return val;
	}

	[DebuggerNonUserCode]
	private void __BuildControl__control60(ParameterCollection __ctrl)
	{
		Parameter val = __BuildControl__control61();
		__ctrl.Add(val);
		Parameter val2 = __BuildControl__control62();
		__ctrl.Add(val2);
		Parameter val3 = __BuildControl__control63();
		__ctrl.Add(val3);
		Parameter val4 = __BuildControl__control64();
		__ctrl.Add(val4);
		Parameter val5 = __BuildControl__control65();
		__ctrl.Add(val5);
		Parameter val6 = __BuildControl__control66();
		__ctrl.Add(val6);
		Parameter val7 = __BuildControl__control67();
		__ctrl.Add(val7);
		Parameter val8 = __BuildControl__control68();
		__ctrl.Add(val8);
	}

	[DebuggerNonUserCode]
	private SqlDataSource __BuildControlSqlref()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		SqlDataSource val = (Sqlref = new SqlDataSource());
		((Control)val).ID = "Sqlref";
		val.DeleteCommand = "DELETE FROM [testbookref] WHERE [bookreid] = @bookreid";
		val.InsertCommand = "INSERT INTO [testbookref] ([testAbrev], [bookname], [authur], [datepublished], [pagenum], [note], [F1]) VALUES (@testAbrev, @bookname, @authur, @datepublished, @pagenum, @note, @F1)";
		val.SelectCommand = "SELECT [testAbrev], [bookname], [authur], [datepublished], [pagenum], [note], [F1], [bookreid] FROM [testbookref] WHERE ([testAbrev] = @testAbrev)";
		val.UpdateCommand = "UPDATE [testbookref] SET [testAbrev] = @testAbrev, [bookname] = @bookname, [authur] = @authur, [datepublished] = @datepublished, [pagenum] = @pagenum, [note] = @note, [F1] = @F1 WHERE [bookreid] = @bookreid";
		__BuildControl__control48(val.SelectParameters);
		__BuildControl__control50(val.DeleteParameters);
		__BuildControl__control52(val.InsertParameters);
		__BuildControl__control60(val.UpdateParameters);
		val.ConnectionString = Convert.ToString(ConnectionStringsExpressionBuilder.GetConnectionString("nazdiltarinConnectionString"), CultureInfo.CurrentCulture);
		val.ProviderName = Convert.ToString(ConnectionStringsExpressionBuilder.GetConnectionStringProviderName("LocalSqlServer"), CultureInfo.CurrentCulture);
		return val;
	}

	[DebuggerNonUserCode]
	private AlwaysVisibleControlExtender __BuildControlAlwaysVisibleControlExtender1()
	{
		AlwaysVisibleControlExtender alwaysVisibleControlExtender = (AlwaysVisibleControlExtender1 = new AlwaysVisibleControlExtender());
		((Control)alwaysVisibleControlExtender).ApplyStyleSheetSkin((Page)(object)this);
		((Control)alwaysVisibleControlExtender).ID = "AlwaysVisibleControlExtender1";
		alwaysVisibleControlExtender.HorizontalSide = HorizontalSide.Right;
		((ExtenderControl)alwaysVisibleControlExtender).TargetControlID = "Panel1";
		alwaysVisibleControlExtender.VerticalSide = VerticalSide.Middle;
		return alwaysVisibleControlExtender;
	}

	[DebuggerNonUserCode]
	private Panel __BuildControlPanel1()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Expected Obj, but got Unknown
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Expected Obj, but got Unknown
		//IL_0077: Unknown result type (might be due to invalid IL or missing references)
		//IL_0081: Expected Obj, but got Unknown
		//IL_0099: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a3: Expected Obj, but got Unknown
		//IL_00bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c5: Expected Obj, but got Unknown
		Panel val = (Panel1 = new Panel());
		((Control)val).TemplateControl = (TemplateControl)(object)this;
		((Control)val).ApplyStyleSheetSkin((Page)(object)this);
		((Control)val).ID = "Panel1";
		((Control)val).Visible = false;
		IParserAccessor val3 = (IParserAccessor)(object)val;
		val3.AddParsedSubObject((object)new LiteralControl("\r\n                        <div style=\"background-color:Black;\">\r\n                            <div style=\"background-color :#003333; text-align:right;\">\r\n                                "));
		LinkButton val4 = __BuildControlLinkButton1();
		val3.AddParsedSubObject((object)val4);
		val3.AddParsedSubObject((object)new LiteralControl("\r\n                            </div>\r\n                            "));
		GridView val5 = __BuildControlGridView5();
		val3.AddParsedSubObject((object)val5);
		val3.AddParsedSubObject((object)new LiteralControl("\r\n                            "));
		SqlDataSource val6 = __BuildControlSqlref();
		val3.AddParsedSubObject((object)val6);
		val3.AddParsedSubObject((object)new LiteralControl("\r\n                            "));
		AlwaysVisibleControlExtender alwaysVisibleControlExtender = __BuildControlAlwaysVisibleControlExtender1();
		val3.AddParsedSubObject((object)alwaysVisibleControlExtender);
		val3.AddParsedSubObject((object)new LiteralControl("\r\n                        </div>\r\n                    "));
		return val;
	}

	[DebuggerNonUserCode]
	private void __BuildControl__control40(Control __ctrl)
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Expected Obj, but got Unknown
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Expected Obj, but got Unknown
		((IParserAccessor)__ctrl).AddParsedSubObject((object)new LiteralControl("\r\n                    "));
		Panel val = __BuildControlPanel1();
		((IParserAccessor)__ctrl).AddParsedSubObject((object)val);
		((IParserAccessor)__ctrl).AddParsedSubObject((object)new LiteralControl("\r\n                "));
	}

	[DebuggerNonUserCode]
	private UpdatePanel __BuildControlUpdatePanel2()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Expected Obj, but got Unknown
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Expected Obj, but got Unknown
		UpdatePanel val = (UpdatePanel2 = new UpdatePanel());
		val.ContentTemplate = (ITemplate)new CompiledTemplateBuilder((BuildTemplateMethod)__BuildControl__control40);
		((Control)val).ID = "UpdatePanel2";
		return val;
	}

	[DebuggerNonUserCode]
	private Parameter __BuildControl__control70()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Parameter val = new Parameter();
		val.Name = "Result";
		val.Type = TypeCode.Double;
		return val;
	}

	[DebuggerNonUserCode]
	private Parameter __BuildControl__control71()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Parameter val = new Parameter();
		val.Name = "rid";
		val.Type = TypeCode.Int32;
		return val;
	}

	[DebuggerNonUserCode]
	private Parameter __BuildControl__control72()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Parameter val = new Parameter();
		val.Name = "TestAbrev";
		val.Type = TypeCode.String;
		return val;
	}

	[DebuggerNonUserCode]
	private Parameter __BuildControl__control73()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Parameter val = new Parameter();
		val.Name = "MedLow";
		val.Type = TypeCode.Double;
		return val;
	}

	[DebuggerNonUserCode]
	private Parameter __BuildControl__control74()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Parameter val = new Parameter();
		val.Name = "MedHigh";
		val.Type = TypeCode.Double;
		return val;
	}

	[DebuggerNonUserCode]
	private Parameter __BuildControl__control75()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Parameter val = new Parameter();
		val.Name = "Medopt";
		val.Type = TypeCode.Double;
		return val;
	}

	[DebuggerNonUserCode]
	private Parameter __BuildControl__control76()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Parameter val = new Parameter();
		val.Name = "MedScale";
		val.Type = TypeCode.Double;
		return val;
	}

	[DebuggerNonUserCode]
	private Parameter __BuildControl__control77()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Parameter val = new Parameter();
		val.Name = "UserName";
		val.Type = TypeCode.String;
		return val;
	}

	[DebuggerNonUserCode]
	private Parameter __BuildControl__control78()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Parameter val = new Parameter();
		val.Name = "DocLow";
		val.Type = TypeCode.Double;
		return val;
	}

	[DebuggerNonUserCode]
	private Parameter __BuildControl__control79()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Parameter val = new Parameter();
		val.Name = "DocHigh";
		val.Type = TypeCode.Double;
		return val;
	}

	[DebuggerNonUserCode]
	private Parameter __BuildControl__control80()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Parameter val = new Parameter();
		val.Name = "DocOpt";
		val.Type = TypeCode.Double;
		return val;
	}

	[DebuggerNonUserCode]
	private Parameter __BuildControl__control81()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Parameter val = new Parameter();
		val.Name = "DocScale";
		val.Type = TypeCode.Double;
		return val;
	}

	[DebuggerNonUserCode]
	private void __BuildControl__control69(ParameterCollection __ctrl)
	{
		Parameter val = __BuildControl__control70();
		__ctrl.Add(val);
		Parameter val2 = __BuildControl__control71();
		__ctrl.Add(val2);
		Parameter val3 = __BuildControl__control72();
		__ctrl.Add(val3);
		Parameter val4 = __BuildControl__control73();
		__ctrl.Add(val4);
		Parameter val5 = __BuildControl__control74();
		__ctrl.Add(val5);
		Parameter val6 = __BuildControl__control75();
		__ctrl.Add(val6);
		Parameter val7 = __BuildControl__control76();
		__ctrl.Add(val7);
		Parameter val8 = __BuildControl__control77();
		__ctrl.Add(val8);
		Parameter val9 = __BuildControl__control78();
		__ctrl.Add(val9);
		Parameter val10 = __BuildControl__control79();
		__ctrl.Add(val10);
		Parameter val11 = __BuildControl__control80();
		__ctrl.Add(val11);
		Parameter val12 = __BuildControl__control81();
		__ctrl.Add(val12);
	}

	[DebuggerNonUserCode]
	private Parameter __BuildControl__control83()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Parameter val = new Parameter();
		val.Name = "Result";
		val.Type = TypeCode.Double;
		return val;
	}

	[DebuggerNonUserCode]
	private Parameter __BuildControl__control84()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Parameter val = new Parameter();
		val.Name = "rid";
		val.Type = TypeCode.Int32;
		return val;
	}

	[DebuggerNonUserCode]
	private Parameter __BuildControl__control85()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Parameter val = new Parameter();
		val.Name = "TestAbrev";
		val.Type = TypeCode.String;
		return val;
	}

	[DebuggerNonUserCode]
	private Parameter __BuildControl__control86()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Parameter val = new Parameter();
		val.Name = "MedLow";
		val.Type = TypeCode.Double;
		return val;
	}

	[DebuggerNonUserCode]
	private Parameter __BuildControl__control87()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Parameter val = new Parameter();
		val.Name = "MedHigh";
		val.Type = TypeCode.Double;
		return val;
	}

	[DebuggerNonUserCode]
	private Parameter __BuildControl__control88()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Parameter val = new Parameter();
		val.Name = "Medopt";
		val.Type = TypeCode.Double;
		return val;
	}

	[DebuggerNonUserCode]
	private Parameter __BuildControl__control89()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Parameter val = new Parameter();
		val.Name = "MedScale";
		val.Type = TypeCode.Double;
		return val;
	}

	[DebuggerNonUserCode]
	private Parameter __BuildControl__control90()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Parameter val = new Parameter();
		val.Name = "UserName";
		val.Type = TypeCode.String;
		return val;
	}

	[DebuggerNonUserCode]
	private Parameter __BuildControl__control91()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Parameter val = new Parameter();
		val.Name = "DocLow";
		val.Type = TypeCode.Double;
		return val;
	}

	[DebuggerNonUserCode]
	private Parameter __BuildControl__control92()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Parameter val = new Parameter();
		val.Name = "DocHigh";
		val.Type = TypeCode.Double;
		return val;
	}

	[DebuggerNonUserCode]
	private Parameter __BuildControl__control93()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Parameter val = new Parameter();
		val.Name = "DocOpt";
		val.Type = TypeCode.Double;
		return val;
	}

	[DebuggerNonUserCode]
	private Parameter __BuildControl__control94()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Parameter val = new Parameter();
		val.Name = "DocScale";
		val.Type = TypeCode.Double;
		return val;
	}

	[DebuggerNonUserCode]
	private Parameter __BuildControl__control95()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Parameter val = new Parameter();
		val.Name = "Testid";
		val.Type = TypeCode.Int32;
		return val;
	}

	[DebuggerNonUserCode]
	private void __BuildControl__control82(ParameterCollection __ctrl)
	{
		Parameter val = __BuildControl__control83();
		__ctrl.Add(val);
		Parameter val2 = __BuildControl__control84();
		__ctrl.Add(val2);
		Parameter val3 = __BuildControl__control85();
		__ctrl.Add(val3);
		Parameter val4 = __BuildControl__control86();
		__ctrl.Add(val4);
		Parameter val5 = __BuildControl__control87();
		__ctrl.Add(val5);
		Parameter val6 = __BuildControl__control88();
		__ctrl.Add(val6);
		Parameter val7 = __BuildControl__control89();
		__ctrl.Add(val7);
		Parameter val8 = __BuildControl__control90();
		__ctrl.Add(val8);
		Parameter val9 = __BuildControl__control91();
		__ctrl.Add(val9);
		Parameter val10 = __BuildControl__control92();
		__ctrl.Add(val10);
		Parameter val11 = __BuildControl__control93();
		__ctrl.Add(val11);
		Parameter val12 = __BuildControl__control94();
		__ctrl.Add(val12);
		Parameter val13 = __BuildControl__control95();
		__ctrl.Add(val13);
	}

	[DebuggerNonUserCode]
	private Parameter __BuildControl__control97()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Parameter val = new Parameter();
		val.Name = "Testid";
		val.Type = TypeCode.Int32;
		return val;
	}

	[DebuggerNonUserCode]
	private void __BuildControl__control96(ParameterCollection __ctrl)
	{
		Parameter val = __BuildControl__control97();
		__ctrl.Add(val);
	}

	[DebuggerNonUserCode]
	private Parameter __BuildControl__control99()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Parameter val = new Parameter();
		val.Name = "Testid";
		return val;
	}

	[DebuggerNonUserCode]
	private void __BuildControl__control98(ParameterCollection __ctrl)
	{
		Parameter val = __BuildControl__control99();
		__ctrl.Add(val);
	}

	[DebuggerNonUserCode]
	private SqlDataSource __BuildControlSqlDataSource1()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		SqlDataSource val = (SqlDataSource1 = new SqlDataSource());
		((Control)val).ID = "SqlDataSource1";
		val.DeleteCommand = "DELETE FROM [ResultRef] WHERE [Testid] = @Testid";
		val.InsertCommand = "INSERT INTO [ResultRef] ([Result], [rid], [TestAbrev], [MedLow], [MedHigh], [Medopt], [MedScale], [UserName], [DocLow], [DocHigh], [DocOpt], [DocScale]) VALUES (@Result, @rid, @TestAbrev, @MedLow, @MedHigh, @Medopt, @MedScale, @UserName, @DocLow, @DocHigh, @DocOpt, @DocScale)";
		val.SelectCommand = "SELECT ResultRef.Result, ResultRef.rid, ResultRef.TestAbrev, ResultRef.MedLow, ResultRef.MedHigh, ResultRef.Medopt, ResultRef.MedScale, ResultRef.UserName, ResultRef.DocLow, ResultRef.DocHigh, ResultRef.DocOpt, ResultRef.DocScale, ResultRef.Testid, TestRef.Category FROM ResultRef LEFT OUTER JOIN TestRef ON ResultRef.TestAbrev = TestRef.testAbrev WHERE (ResultRef.Testid = @Testid) ORDER BY ABS(ResultRef.DocScale) DESC";
		val.UpdateCommand = "UPDATE [ResultRef] SET [Result] = @Result, [rid] = @rid, [TestAbrev] = @TestAbrev, [MedLow] = @MedLow, [MedHigh] = @MedHigh, [Medopt] = @Medopt, [MedScale] = @MedScale, [UserName] = @UserName, [DocLow] = @DocLow, [DocHigh] = @DocHigh, [DocOpt] = @DocOpt, [DocScale] = @DocScale WHERE [Testid] = @Testid";
		__BuildControl__control69(val.InsertParameters);
		__BuildControl__control82(val.UpdateParameters);
		__BuildControl__control96(val.DeleteParameters);
		__BuildControl__control98(val.SelectParameters);
		val.ConnectionString = Convert.ToString(ConnectionStringsExpressionBuilder.GetConnectionString("nazdiltarinConnectionString"), CultureInfo.CurrentCulture);
		return val;
	}

	[DebuggerNonUserCode]
	private Button __BuildControlButton1()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Button val = (Button1 = new Button());
		((Control)val).ApplyStyleSheetSkin((Page)(object)this);
		((Control)val).ID = "Button1";
		val.Text = "Get advice for selected item(s)  (max=6)";
		return val;
	}

	[DebuggerNonUserCode]
	private Button __BuildControlButton4()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Button val = (Button4 = new Button());
		((Control)val).ApplyStyleSheetSkin((Page)(object)this);
		((Control)val).ID = "Button4";
		val.OnClientClick = "return confirm('Are you sure you want to delete this record? There will be no way to recover a deleted test.');";
		val.Text = "Delete selected item(s)";
		return val;
	}

	[DebuggerNonUserCode]
	private Button __BuildControlbtnAddtest1()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Button val = (btnAddtest1 = new Button());
		((Control)val).ApplyStyleSheetSkin((Page)(object)this);
		((Control)val).ID = "btnAddtest1";
		val.Text = "Add / Update";
		return val;
	}

	[DebuggerNonUserCode]
	private View __BuildControlView1()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Expected Obj, but got Unknown
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Expected Obj, but got Unknown
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Expected Obj, but got Unknown
		//IL_0086: Unknown result type (might be due to invalid IL or missing references)
		//IL_0090: Expected Obj, but got Unknown
		//IL_00a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b2: Expected Obj, but got Unknown
		//IL_00ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d4: Expected Obj, but got Unknown
		//IL_00ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f6: Expected Obj, but got Unknown
		//IL_010e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0118: Expected Obj, but got Unknown
		//IL_0130: Unknown result type (might be due to invalid IL or missing references)
		//IL_013a: Expected Obj, but got Unknown
		//IL_0152: Unknown result type (might be due to invalid IL or missing references)
		//IL_015c: Expected Obj, but got Unknown
		//IL_0172: Unknown result type (might be due to invalid IL or missing references)
		//IL_017c: Expected Obj, but got Unknown
		//IL_0194: Unknown result type (might be due to invalid IL or missing references)
		//IL_019e: Expected Obj, but got Unknown
		View val = (View1 = new View());
		((Control)val).ID = "View1";
		IParserAccessor val3 = (IParserAccessor)(object)val;
		val3.AddParsedSubObject((object)new LiteralControl("\r\n     \r\n    <br />\r\n            "));
		RadioButtonList val4 = __BuildControlRadioButtonList2();
		val3.AddParsedSubObject((object)val4);
		val3.AddParsedSubObject((object)new LiteralControl("\r\n            <br />\r\n            &nbsp; ** You can select up to 6 tests in order get treatments.<br />\r\n            "));
		Button val5 = __BuildControlButton2();
		val3.AddParsedSubObject((object)val5);
		val3.AddParsedSubObject((object)new LiteralControl("\r\n            &nbsp;\r\n            "));
		Button val6 = __BuildControlButton5();
		val3.AddParsedSubObject((object)val6);
		val3.AddParsedSubObject((object)new LiteralControl("\r\n&nbsp;&nbsp;"));
		Button val7 = __BuildControlbtnAddtest();
		val3.AddParsedSubObject((object)val7);
		val3.AddParsedSubObject((object)new LiteralControl("\r\n&nbsp;\r\n            "));
		Button val8 = __BuildControlButton6();
		val3.AddParsedSubObject((object)val8);
		val3.AddParsedSubObject((object)new LiteralControl("\r\n            <br />\r\n            "));
		UpdatePanel val9 = __BuildControlUpdatePanel1();
		val3.AddParsedSubObject((object)val9);
		val3.AddParsedSubObject((object)new LiteralControl("\r\n            "));
		UpdatePanel val10 = __BuildControlUpdatePanel2();
		val3.AddParsedSubObject((object)val10);
		val3.AddParsedSubObject((object)new LiteralControl("\r\n            "));
		SqlDataSource val11 = __BuildControlSqlDataSource1();
		val3.AddParsedSubObject((object)val11);
		val3.AddParsedSubObject((object)new LiteralControl("\r\n            "));
		Button val12 = __BuildControlButton1();
		val3.AddParsedSubObject((object)val12);
		val3.AddParsedSubObject((object)new LiteralControl("\r\n&nbsp;\r\n            "));
		Button val13 = __BuildControlButton4();
		val3.AddParsedSubObject((object)val13);
		val3.AddParsedSubObject((object)new LiteralControl("\r\n            &nbsp;\r\n            "));
		Button val14 = __BuildControlbtnAddtest1();
		val3.AddParsedSubObject((object)val14);
		val3.AddParsedSubObject((object)new LiteralControl("\r\n        "));
		return val;
	}

	[DebuggerNonUserCode]
	private void __BuildControl__control100(Control __ctrl)
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Expected Obj, but got Unknown
		((IParserAccessor)__ctrl).AddParsedSubObject((object)new LiteralControl("\r\n                    No TPR Test Result is available.\r\n                "));
	}

	[DebuggerNonUserCode]
	private GridView __BuildControlGridView4()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Expected Obj, but got Unknown
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Expected Obj, but got Unknown
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		GridView val = (GridView4 = new GridView());
		((Control)val).ApplyStyleSheetSkin((Page)(object)this);
		val.EmptyDataTemplate = (ITemplate)new CompiledTemplateBuilder((BuildTemplateMethod)__BuildControl__control100);
		((Control)val).ID = "GridView4";
		Unit width = new Unit(100.0, (UnitType)7);
		((WebControl)val).Width = width;
		return val;
	}

	[DebuggerNonUserCode]
	private void __BuildControl__control101(Control __ctrl)
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Expected Obj, but got Unknown
		((IParserAccessor)__ctrl).AddParsedSubObject((object)new LiteralControl("\r\n                    No significant treatment for Calcium Phosphorus Ratio Test\r\n                "));
	}

	[DebuggerNonUserCode]
	private GridView __BuildControlGridView3()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Expected Obj, but got Unknown
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Expected Obj, but got Unknown
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		GridView val = (GridView3 = new GridView());
		((Control)val).ApplyStyleSheetSkin((Page)(object)this);
		val.EmptyDataTemplate = (ITemplate)new CompiledTemplateBuilder((BuildTemplateMethod)__BuildControl__control101);
		((Control)val).ID = "GridView3";
		Unit width = new Unit(100.0, (UnitType)7);
		((WebControl)val).Width = width;
		return val;
	}

	[DebuggerNonUserCode]
	private BoundField __BuildControl__control103()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		BoundField val = new BoundField();
		val.DataField = "Prod-ID";
		val.HeaderText = "Prod-ID";
		((DataControlField)val).SortExpression = "Prod-ID";
		((DataControlField)val).Visible = false;
		return val;
	}

	[DebuggerNonUserCode]
	private BoundField __BuildControl__control104()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		BoundField val = new BoundField();
		val.DataField = "Product";
		val.HeaderText = "Product";
		((DataControlField)val).SortExpression = "Product";
		return val;
	}

	[DebuggerNonUserCode]
	private BoundField __BuildControl__control105()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		BoundField val = new BoundField();
		val.DataField = "Dosage";
		val.HeaderText = "Dosage";
		((DataControlField)val).SortExpression = "Dosage";
		return val;
	}

	[DebuggerNonUserCode]
	private BoundField __BuildControl__control106()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		BoundField val = new BoundField();
		val.DataField = "Co";
		val.HeaderText = "Co";
		((DataControlField)val).SortExpression = "Co";
		((DataControlField)val).Visible = false;
		return val;
	}

	[DebuggerNonUserCode]
	private BoundField __BuildControl__control107()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		BoundField val = new BoundField();
		val.DataField = "Order";
		val.HeaderText = "Order";
		((DataControlField)val).SortExpression = "Order";
		((DataControlField)val).Visible = false;
		return val;
	}

	[DebuggerNonUserCode]
	private BoundField __BuildControl__control108()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		BoundField val = new BoundField();
		val.DataField = "Body_Part";
		val.HeaderText = "Body_Part";
		((DataControlField)val).SortExpression = "Body_Part";
		return val;
	}

	[DebuggerNonUserCode]
	private void __BuildControl__control102(DataControlFieldCollection __ctrl)
	{
		BoundField val = __BuildControl__control103();
		__ctrl.Add((DataControlField)(object)val);
		BoundField val2 = __BuildControl__control104();
		__ctrl.Add((DataControlField)(object)val2);
		BoundField val3 = __BuildControl__control105();
		__ctrl.Add((DataControlField)(object)val3);
		BoundField val4 = __BuildControl__control106();
		__ctrl.Add((DataControlField)(object)val4);
		BoundField val5 = __BuildControl__control107();
		__ctrl.Add((DataControlField)(object)val5);
		BoundField val6 = __BuildControl__control108();
		__ctrl.Add((DataControlField)(object)val6);
	}

	[DebuggerNonUserCode]
	private GridView __BuildControlGridView2()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		GridView val = (GridView2 = new GridView());
		((Control)val).ApplyStyleSheetSkin((Page)(object)this);
		((Control)val).ID = "GridView2";
		val.AutoGenerateColumns = false;
		val.EmptyDataText = "No Significant Advise For Selected Item(s).";
		Unit width = new Unit(100.0, (UnitType)7);
		((WebControl)val).Width = width;
		__BuildControl__control102(val.Columns);
		return val;
	}

	[DebuggerNonUserCode]
	private PlaceHolder __BuildControlbookPlaceHolder()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		PlaceHolder val = (bookPlaceHolder = new PlaceHolder());
		((Control)val).ID = "bookPlaceHolder";
		return val;
	}

	[DebuggerNonUserCode]
	private View __BuildControlView2()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Expected Obj, but got Unknown
		View val = (View2 = new View());
		((Control)val).ID = "View2";
		IParserAccessor val3 = (IParserAccessor)(object)val;
		val3.AddParsedSubObject((object)((TemplateControl)this).CreateResourceBasedLiteralControl(0, 2740, false));
		GridView val4 = __BuildControlGridView4();
		val3.AddParsedSubObject((object)val4);
		val3.AddParsedSubObject((object)new LiteralControl("\r\n            <br />\r\n            "));
		GridView val5 = __BuildControlGridView3();
		val3.AddParsedSubObject((object)val5);
		val3.AddParsedSubObject((object)((TemplateControl)this).CreateResourceBasedLiteralControl(2740, 619, false));
		GridView val6 = __BuildControlGridView2();
		val3.AddParsedSubObject((object)val6);
		val3.AddParsedSubObject((object)((TemplateControl)this).CreateResourceBasedLiteralControl(3359, 1532, true));
		PlaceHolder val7 = __BuildControlbookPlaceHolder();
		val3.AddParsedSubObject((object)val7);
		val3.AddParsedSubObject((object)((TemplateControl)this).CreateResourceBasedLiteralControl(4891, 1042, true));
		return val;
	}

	[DebuggerNonUserCode]
	private Image __BuildControlImage2()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Image val = (Image2 = new Image());
		((Control)val).ApplyStyleSheetSkin((Page)(object)this);
		((Control)val).ID = "Image2";
		val.ImageUrl = "~/images/del.png";
		return val;
	}

	[DebuggerNonUserCode]
	private ListItem __BuildControl__control110()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		ListItem val = new ListItem();
		val.Value = "80";
		val.Text = "Buy Doctor’s Advice for picked problem-$80/each selection";
		return val;
	}

	[DebuggerNonUserCode]
	private ListItem __BuildControl__control111()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		ListItem val = new ListItem();
		val.Value = "400";
		val.Text = "Buy Doctor’s Advice for complete test evaluation-$400";
		return val;
	}

	[DebuggerNonUserCode]
	private ListItem __BuildControl__control112()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		ListItem val = new ListItem();
		val.Value = "590";
		val.Text = "Subscribe to a trial Health Assurance Plan $590";
		return val;
	}

	[DebuggerNonUserCode]
	private ListItem __BuildControl__control113()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		ListItem val = new ListItem();
		val.Value = "2780";
		val.Text = "Subscribe Health Assurance 2-yr. Plan- $2780";
		return val;
	}

	[DebuggerNonUserCode]
	private ListItem __BuildControl__control114()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		ListItem val = new ListItem();
		val.Value = "5100";
		val.Text = "Subscribe Family Health Assurance 4-yr. Plan- $5100";
		return val;
	}

	[DebuggerNonUserCode]
	private void __BuildControl__control109(ListItemCollection __ctrl)
	{
		ListItem val = __BuildControl__control110();
		__ctrl.Add(val);
		ListItem val2 = __BuildControl__control111();
		__ctrl.Add(val2);
		ListItem val3 = __BuildControl__control112();
		__ctrl.Add(val3);
		ListItem val4 = __BuildControl__control113();
		__ctrl.Add(val4);
		ListItem val5 = __BuildControl__control114();
		__ctrl.Add(val5);
	}

	[DebuggerNonUserCode]
	private RadioButtonList __BuildControlRadioButtonList1()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		RadioButtonList val = (RadioButtonList1 = new RadioButtonList());
		((Control)val).ApplyStyleSheetSkin((Page)(object)this);
		((Control)val).ID = "RadioButtonList1";
		__BuildControl__control109(((ListControl)val).Items);
		return val;
	}

	[DebuggerNonUserCode]
	private Button __BuildControlButton3()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		Button val = (Button3 = new Button());
		((Control)val).ApplyStyleSheetSkin((Page)(object)this);
		((Control)val).ID = "Button3";
		val.Text = "Next";
		Unit width = new Unit(79.0, (UnitType)1);
		((WebControl)val).Width = width;
		return val;
	}

	[DebuggerNonUserCode]
	private View __BuildControlView3()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Expected Obj, but got Unknown
		View val = (View3 = new View());
		((Control)val).ID = "View3";
		IParserAccessor val3 = (IParserAccessor)(object)val;
		val3.AddParsedSubObject((object)new LiteralControl("\r\n            <table border=\"0\" style=\"width: 100%\">\r\n                <tr>\r\n                    <td colspan=\"2\">\r\n                    </td>\r\n                </tr>\r\n                <tr>\r\n                    <td>\r\n                        "));
		Image val4 = __BuildControlImage2();
		val3.AddParsedSubObject((object)val4);
		val3.AddParsedSubObject((object)((TemplateControl)this).CreateResourceBasedLiteralControl(5933, 693, true));
		RadioButtonList val5 = __BuildControlRadioButtonList1();
		val3.AddParsedSubObject((object)val5);
		Button val6 = __BuildControlButton3();
		val3.AddParsedSubObject((object)val6);
		val3.AddParsedSubObject((object)((TemplateControl)this).CreateResourceBasedLiteralControl(6626, 362, true));
		return val;
	}

	[DebuggerNonUserCode]
	private Label __BuildControlLabelusr()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		Label val = (Labelusr = new Label());
		((Control)val).ApplyStyleSheetSkin((Page)(object)this);
		((Control)val).ID = "Labelusr";
		Unit width = new Unit(149.0, (UnitType)1);
		((WebControl)val).Width = width;
		return val;
	}

	[DebuggerNonUserCode]
	private Label __BuildControlLabelamnt()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		Label val = (Labelamnt = new Label());
		((Control)val).ApplyStyleSheetSkin((Page)(object)this);
		((Control)val).ID = "Labelamnt";
		Unit width = new Unit(149.0, (UnitType)1);
		((WebControl)val).Width = width;
		return val;
	}

	[DebuggerNonUserCode]
	private BuyNowButton __BuildControlBuyNowButton1()
	{
		BuyNowButton buyNowButton = (BuyNowButton1 = new BuyNowButton());
		((Control)buyNowButton).ApplyStyleSheetSkin((Page)(object)this);
		((Control)buyNowButton).ID = "BuyNowButton1";
		buyNowButton.BusinessEmail = "dralaguirre2@hotmail.com";
		buyNowButton.DoNotAskShipping = true;
		buyNowButton.Option1FieldName = "Username";
		buyNowButton.ReturnUrl = "http://HumanOilChange.com/buy.aspx";
		buyNowButton.UseFormGet = true;
		return buyNowButton;
	}

	[DebuggerNonUserCode]
	private View __BuildControlView4()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Expected Obj, but got Unknown
		//IL_0092: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Expected Obj, but got Unknown
		View val = (View4 = new View());
		((Control)val).ID = "View4";
		IParserAccessor val3 = (IParserAccessor)(object)val;
		val3.AddParsedSubObject((object)((TemplateControl)this).CreateResourceBasedLiteralControl(6988, 915, true));
		Label val4 = __BuildControlLabelusr();
		val3.AddParsedSubObject((object)val4);
		val3.AddParsedSubObject((object)new LiteralControl("</td></tr><tr>\r\n                    <td>\r\n                        Amount of payment:</td><td>\r\n                        $"));
		Label val5 = __BuildControlLabelamnt();
		val3.AddParsedSubObject((object)val5);
		val3.AddParsedSubObject((object)((TemplateControl)this).CreateResourceBasedLiteralControl(7903, 335, true));
		BuyNowButton buyNowButton = __BuildControlBuyNowButton1();
		val3.AddParsedSubObject((object)buyNowButton);
		val3.AddParsedSubObject((object)new LiteralControl("&nbsp;</form></td></tr></table>"));
		return val;
	}

	[DebuggerNonUserCode]
	private MultiView __BuildControlMultiView1()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Expected Obj, but got Unknown
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Expected Obj, but got Unknown
		//IL_0081: Unknown result type (might be due to invalid IL or missing references)
		//IL_008b: Expected Obj, but got Unknown
		MultiView val = (MultiView1 = new MultiView());
		((Control)val).TemplateControl = (TemplateControl)(object)this;
		((Control)val).ID = "MultiView1";
		val.ActiveViewIndex = 0;
		IParserAccessor val3 = (IParserAccessor)(object)val;
		val3.AddParsedSubObject((object)new LiteralControl("\r\n        "));
		View val4 = __BuildControlView1();
		val3.AddParsedSubObject((object)val4);
		val3.AddParsedSubObject((object)new LiteralControl("\r\n        "));
		View val5 = __BuildControlView2();
		val3.AddParsedSubObject((object)val5);
		View val6 = __BuildControlView3();
		val3.AddParsedSubObject((object)val6);
		val3.AddParsedSubObject((object)new LiteralControl("\r\n        "));
		View val7 = __BuildControlView4();
		val3.AddParsedSubObject((object)val7);
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
		((IParserAccessor)__ctrl).AddParsedSubObject((object)new LiteralControl("<br />\r\n"));
	}

	[DebuggerNonUserCode]
	private void __BuildControlContent2(Control __ctrl)
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Expected Obj, but got Unknown
		((IParserAccessor)__ctrl).AddParsedSubObject((object)new LiteralControl("\r\n\r\n    \r\n"));
	}

	[DebuggerNonUserCode]
	private void __BuildControlTree(labcalc_resultview_aspx __ctrl)
	{
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Expected Obj, but got Unknown
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Expected Obj, but got Unknown
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_0051: Expected Obj, but got Unknown
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0056: Expected Obj, but got Unknown
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0068: Expected Obj, but got Unknown
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0078: Expected Obj, but got Unknown
		((Page)__ctrl).MasterPageFile = "~/master1.master";
		((Page)__ctrl).Title = "Mental StressTester :: Online Lab";
		((Page)this).InitializeCulture();
		((Page)this).AddContentTemplate("ContentPlaceHolder1", (ITemplate)new CompiledTemplateBuilder((BuildTemplateMethod)__BuildControlContent1));
		((Page)this).AddContentTemplate("head", (ITemplate)new CompiledTemplateBuilder((BuildTemplateMethod)__BuildControlContent2));
		((IParserAccessor)__ctrl).AddParsedSubObject((object)new LiteralControl("\r\n\r\n"));
		((IParserAccessor)__ctrl).AddParsedSubObject((object)new LiteralControl("\r\n\r\n\r\n"));
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
		return -83722557;
	}

	[DebuggerNonUserCode]
	public override void ProcessRequest(HttpContext context)
	{
		((Page)this).ProcessRequest(context);
	}
}
