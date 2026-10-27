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
using Sample.Web.UI.Compatibility;

namespace ASP;

[CompilerGlobalScope]
public class labcalc_resultin_aspx : LabCalc_ResultIn
{
	private static bool __initialized;

	private static object __stringResource;

	private static object __fileDependencies;

	protected override bool SupportAutoEvents => false;

	[DebuggerNonUserCode]
	public labcalc_resultin_aspx()
	{
		((TemplateControl)this).AppRelativeVirtualPath = "~/LabCalc/ResultIn.aspx";
		if (!__initialized)
		{
			__stringResource = RuntimeHelpers.GetObjectValue(((TemplateControl)this).ReadStringResource());
			__fileDependencies = RuntimeHelpers.GetObjectValue(((Page)this).GetWrappedFileDependencies(new string[6] { "~/LabCalc/ResultIn.aspx", "~/master1.master", "~/master1.master.vb", "~/LabCalc/ResultIn.aspx.vb", "~/LabCalc/Default.aspx", "~/LabCalc/Default.aspx.vb" }));
			__initialized = true;
		}
		((Page)this).Server.ScriptTimeout = 30000000;
	}

	[DebuggerNonUserCode]
	private TextBox __BuildControl__control5()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		TextBox val = new TextBox();
		((Control)val).TemplateControl = (TemplateControl)(object)this;
		((Control)val).ApplyStyleSheetSkin((Page)(object)this);
		((Control)val).ID = "TextBox3";
		((Control)val).DataBinding += __DataBinding__control5;
		return val;
	}

	public void __DataBinding__control5(object sender, EventArgs e)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Expected Obj, but got Unknown
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Expected Obj, but got Unknown
		TextBox val = (TextBox)sender;
		IDataItemContainer val2 = (IDataItemContainer)((Control)val).BindingContainer;
		if (((Control)this).Page.GetDataItem() != null)
		{
			val.Text = Convert.ToString(RuntimeHelpers.GetObjectValue(((TemplateControl)this).Eval("rid")), CultureInfo.CurrentCulture);
		}
	}

	[DebuggerNonUserCode]
	private void __BuildControl__control4(Control __ctrl)
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Expected Obj, but got Unknown
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Expected Obj, but got Unknown
		((IParserAccessor)__ctrl).AddParsedSubObject((object)new LiteralControl("\r\n                                "));
		TextBox val = __BuildControl__control5();
		((IParserAccessor)__ctrl).AddParsedSubObject((object)val);
		((IParserAccessor)__ctrl).AddParsedSubObject((object)new LiteralControl("\r\n                            "));
	}

	[DebuggerNonUserCode]
	public IOrderedDictionary __ExtractValues__control4(Control __container)
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Expected Obj, but got Unknown
		TextBox val = (TextBox)__container.FindControl("TextBox3");
		OrderedDictionary orderedDictionary = new OrderedDictionary();
		if (val != null)
		{
			orderedDictionary["rid"] = val.Text;
		}
		return orderedDictionary;
	}

	[DebuggerNonUserCode]
	private Label __BuildControl__control7()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Label val = new Label();
		((Control)val).TemplateControl = (TemplateControl)(object)this;
		((Control)val).ApplyStyleSheetSkin((Page)(object)this);
		((Control)val).ID = "Label1";
		((Control)val).DataBinding += __DataBinding__control7;
		return val;
	}

	public void __DataBinding__control7(object sender, EventArgs e)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Expected Obj, but got Unknown
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Expected Obj, but got Unknown
		Label val = (Label)sender;
		IDataItemContainer val2 = (IDataItemContainer)((Control)val).BindingContainer;
		if (((Control)this).Page.GetDataItem() != null)
		{
			val.Text = Convert.ToString(RuntimeHelpers.GetObjectValue(((TemplateControl)this).Eval("rid")), CultureInfo.CurrentCulture);
		}
	}

	[DebuggerNonUserCode]
	private void __BuildControl__control6(Control __ctrl)
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Expected Obj, but got Unknown
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Expected Obj, but got Unknown
		((IParserAccessor)__ctrl).AddParsedSubObject((object)new LiteralControl("\r\n                                "));
		Label val = __BuildControl__control7();
		((IParserAccessor)__ctrl).AddParsedSubObject((object)val);
		((IParserAccessor)__ctrl).AddParsedSubObject((object)new LiteralControl("\r\n                            "));
	}

	[DebuggerNonUserCode]
	public IOrderedDictionary __ExtractValues__control6(Control __container)
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Expected Obj, but got Unknown
		Label val = (Label)__container.FindControl("Label1");
		OrderedDictionary orderedDictionary = new OrderedDictionary();
		if (val != null)
		{
			orderedDictionary["rid"] = val.Text;
		}
		return orderedDictionary;
	}

	[DebuggerNonUserCode]
	private TemplateField __BuildControl__control3()
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
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Expected Obj, but got Unknown
		//IL_004b: Expected Obj, but got Unknown
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Expected Obj, but got Unknown
		TemplateField val = new TemplateField();
		val.EditItemTemplate = (ITemplate)new CompiledBindableTemplateBuilder((BuildTemplateMethod)__BuildControl__control4, (ExtractTemplateValuesMethod)__ExtractValues__control4);
		val.ItemTemplate = (ITemplate)new CompiledBindableTemplateBuilder((BuildTemplateMethod)__BuildControl__control6, (ExtractTemplateValuesMethod)__ExtractValues__control6);
		((DataControlField)val).HeaderText = "rid";
		((DataControlField)val).SortExpression = "rid";
		((DataControlField)val).Visible = false;
		return val;
	}

	[DebuggerNonUserCode]
	private TextBox __BuildControl__control10()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		TextBox val = new TextBox();
		((Control)val).TemplateControl = (TemplateControl)(object)this;
		((Control)val).ApplyStyleSheetSkin((Page)(object)this);
		((Control)val).ID = "TextBox4";
		((Control)val).DataBinding += __DataBinding__control10;
		return val;
	}

	public void __DataBinding__control10(object sender, EventArgs e)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Expected Obj, but got Unknown
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Expected Obj, but got Unknown
		TextBox val = (TextBox)sender;
		IDataItemContainer val2 = (IDataItemContainer)((Control)val).BindingContainer;
		if (((Control)this).Page.GetDataItem() != null)
		{
			val.Text = Convert.ToString(RuntimeHelpers.GetObjectValue(((TemplateControl)this).Eval("testAbrev")), CultureInfo.CurrentCulture);
		}
	}

	[DebuggerNonUserCode]
	private void __BuildControl__control9(Control __ctrl)
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Expected Obj, but got Unknown
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Expected Obj, but got Unknown
		((IParserAccessor)__ctrl).AddParsedSubObject((object)new LiteralControl("\r\n                                "));
		TextBox val = __BuildControl__control10();
		((IParserAccessor)__ctrl).AddParsedSubObject((object)val);
		((IParserAccessor)__ctrl).AddParsedSubObject((object)new LiteralControl("\r\n                            "));
	}

	[DebuggerNonUserCode]
	public IOrderedDictionary __ExtractValues__control9(Control __container)
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Expected Obj, but got Unknown
		TextBox val = (TextBox)__container.FindControl("TextBox4");
		OrderedDictionary orderedDictionary = new OrderedDictionary();
		if (val != null)
		{
			orderedDictionary["testAbrev"] = val.Text;
		}
		return orderedDictionary;
	}

	[DebuggerNonUserCode]
	private Label __BuildControl__control12()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Label val = new Label();
		((Control)val).TemplateControl = (TemplateControl)(object)this;
		((Control)val).ApplyStyleSheetSkin((Page)(object)this);
		((Control)val).ID = "tstAbrev";
		((Control)val).DataBinding += __DataBinding__control12;
		return val;
	}

	public void __DataBinding__control12(object sender, EventArgs e)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Expected Obj, but got Unknown
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Expected Obj, but got Unknown
		Label val = (Label)sender;
		IDataItemContainer val2 = (IDataItemContainer)((Control)val).BindingContainer;
		if (((Control)this).Page.GetDataItem() != null)
		{
			val.Text = Convert.ToString(RuntimeHelpers.GetObjectValue(((TemplateControl)this).Eval("testAbrev")), CultureInfo.CurrentCulture);
		}
	}

	[DebuggerNonUserCode]
	private void __BuildControl__control11(Control __ctrl)
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Expected Obj, but got Unknown
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Expected Obj, but got Unknown
		((IParserAccessor)__ctrl).AddParsedSubObject((object)new LiteralControl("\r\n                                "));
		Label val = __BuildControl__control12();
		((IParserAccessor)__ctrl).AddParsedSubObject((object)val);
		((IParserAccessor)__ctrl).AddParsedSubObject((object)new LiteralControl("\r\n                            "));
	}

	[DebuggerNonUserCode]
	public IOrderedDictionary __ExtractValues__control11(Control __container)
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Expected Obj, but got Unknown
		Label val = (Label)__container.FindControl("tstAbrev");
		OrderedDictionary orderedDictionary = new OrderedDictionary();
		if (val != null)
		{
			orderedDictionary["testAbrev"] = val.Text;
		}
		return orderedDictionary;
	}

	[DebuggerNonUserCode]
	private TemplateField __BuildControl__control8()
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
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Expected Obj, but got Unknown
		//IL_004b: Expected Obj, but got Unknown
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Expected Obj, but got Unknown
		TemplateField val = new TemplateField();
		val.EditItemTemplate = (ITemplate)new CompiledBindableTemplateBuilder((BuildTemplateMethod)__BuildControl__control9, (ExtractTemplateValuesMethod)__ExtractValues__control9);
		val.ItemTemplate = (ITemplate)new CompiledBindableTemplateBuilder((BuildTemplateMethod)__BuildControl__control11, (ExtractTemplateValuesMethod)__ExtractValues__control11);
		((DataControlField)val).HeaderText = "testAbrev";
		((DataControlField)val).SortExpression = "testAbrev";
		return val;
	}

	[DebuggerNonUserCode]
	private TextBox __BuildControl__control15()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		TextBox val = new TextBox();
		((Control)val).TemplateControl = (TemplateControl)(object)this;
		((Control)val).ApplyStyleSheetSkin((Page)(object)this);
		((Control)val).ID = "TextBox5";
		((Control)val).DataBinding += __DataBinding__control15;
		return val;
	}

	public void __DataBinding__control15(object sender, EventArgs e)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Expected Obj, but got Unknown
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Expected Obj, but got Unknown
		TextBox val = (TextBox)sender;
		IDataItemContainer val2 = (IDataItemContainer)((Control)val).BindingContainer;
		if (((Control)this).Page.GetDataItem() != null)
		{
			val.Text = Convert.ToString(RuntimeHelpers.GetObjectValue(((TemplateControl)this).Eval("testName")), CultureInfo.CurrentCulture);
		}
	}

	[DebuggerNonUserCode]
	private void __BuildControl__control14(Control __ctrl)
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Expected Obj, but got Unknown
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Expected Obj, but got Unknown
		((IParserAccessor)__ctrl).AddParsedSubObject((object)new LiteralControl("\r\n                                "));
		TextBox val = __BuildControl__control15();
		((IParserAccessor)__ctrl).AddParsedSubObject((object)val);
		((IParserAccessor)__ctrl).AddParsedSubObject((object)new LiteralControl("\r\n                            "));
	}

	[DebuggerNonUserCode]
	public IOrderedDictionary __ExtractValues__control14(Control __container)
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Expected Obj, but got Unknown
		TextBox val = (TextBox)__container.FindControl("TextBox5");
		OrderedDictionary orderedDictionary = new OrderedDictionary();
		if (val != null)
		{
			orderedDictionary["testName"] = val.Text;
		}
		return orderedDictionary;
	}

	[DebuggerNonUserCode]
	private Label __BuildControl__control17()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Label val = new Label();
		((Control)val).TemplateControl = (TemplateControl)(object)this;
		((Control)val).ApplyStyleSheetSkin((Page)(object)this);
		((Control)val).ID = "tstname";
		((Control)val).DataBinding += __DataBinding__control17;
		return val;
	}

	public void __DataBinding__control17(object sender, EventArgs e)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Expected Obj, but got Unknown
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Expected Obj, but got Unknown
		Label val = (Label)sender;
		IDataItemContainer val2 = (IDataItemContainer)((Control)val).BindingContainer;
		if (((Control)this).Page.GetDataItem() != null)
		{
			val.Text = Convert.ToString(RuntimeHelpers.GetObjectValue(((TemplateControl)this).Eval("testName")), CultureInfo.CurrentCulture);
		}
	}

	[DebuggerNonUserCode]
	private void __BuildControl__control16(Control __ctrl)
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Expected Obj, but got Unknown
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Expected Obj, but got Unknown
		((IParserAccessor)__ctrl).AddParsedSubObject((object)new LiteralControl("\r\n                                "));
		Label val = __BuildControl__control17();
		((IParserAccessor)__ctrl).AddParsedSubObject((object)val);
		((IParserAccessor)__ctrl).AddParsedSubObject((object)new LiteralControl("\r\n                            "));
	}

	[DebuggerNonUserCode]
	public IOrderedDictionary __ExtractValues__control16(Control __container)
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Expected Obj, but got Unknown
		Label val = (Label)__container.FindControl("tstname");
		OrderedDictionary orderedDictionary = new OrderedDictionary();
		if (val != null)
		{
			orderedDictionary["testName"] = val.Text;
		}
		return orderedDictionary;
	}

	[DebuggerNonUserCode]
	private TemplateField __BuildControl__control13()
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
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Expected Obj, but got Unknown
		//IL_004b: Expected Obj, but got Unknown
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Expected Obj, but got Unknown
		TemplateField val = new TemplateField();
		val.EditItemTemplate = (ITemplate)new CompiledBindableTemplateBuilder((BuildTemplateMethod)__BuildControl__control14, (ExtractTemplateValuesMethod)__ExtractValues__control14);
		val.ItemTemplate = (ITemplate)new CompiledBindableTemplateBuilder((BuildTemplateMethod)__BuildControl__control16, (ExtractTemplateValuesMethod)__ExtractValues__control16);
		((DataControlField)val).HeaderText = "testName";
		((DataControlField)val).SortExpression = "testName";
		return val;
	}

	[DebuggerNonUserCode]
	private TextBox __BuildControl__control20()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		TextBox val = new TextBox();
		((Control)val).TemplateControl = (TemplateControl)(object)this;
		((Control)val).ApplyStyleSheetSkin((Page)(object)this);
		((Control)val).ID = "TextBox6";
		((Control)val).DataBinding += __DataBinding__control20;
		return val;
	}

	public void __DataBinding__control20(object sender, EventArgs e)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Expected Obj, but got Unknown
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Expected Obj, but got Unknown
		TextBox val = (TextBox)sender;
		IDataItemContainer val2 = (IDataItemContainer)((Control)val).BindingContainer;
		if (((Control)this).Page.GetDataItem() != null)
		{
			val.Text = Convert.ToString(RuntimeHelpers.GetObjectValue(((TemplateControl)this).Eval("DocLow")), CultureInfo.CurrentCulture);
		}
	}

	[DebuggerNonUserCode]
	private void __BuildControl__control19(Control __ctrl)
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Expected Obj, but got Unknown
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Expected Obj, but got Unknown
		((IParserAccessor)__ctrl).AddParsedSubObject((object)new LiteralControl("\r\n                                "));
		TextBox val = __BuildControl__control20();
		((IParserAccessor)__ctrl).AddParsedSubObject((object)val);
		((IParserAccessor)__ctrl).AddParsedSubObject((object)new LiteralControl("\r\n                            "));
	}

	[DebuggerNonUserCode]
	public IOrderedDictionary __ExtractValues__control19(Control __container)
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Expected Obj, but got Unknown
		TextBox val = (TextBox)__container.FindControl("TextBox6");
		OrderedDictionary orderedDictionary = new OrderedDictionary();
		if (val != null)
		{
			orderedDictionary["DocLow"] = val.Text;
		}
		return orderedDictionary;
	}

	[DebuggerNonUserCode]
	private Label __BuildControl__control22()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Label val = new Label();
		((Control)val).TemplateControl = (TemplateControl)(object)this;
		((Control)val).ApplyStyleSheetSkin((Page)(object)this);
		((Control)val).ID = "dl1";
		((Control)val).DataBinding += __DataBinding__control22;
		return val;
	}

	public void __DataBinding__control22(object sender, EventArgs e)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Expected Obj, but got Unknown
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Expected Obj, but got Unknown
		Label val = (Label)sender;
		IDataItemContainer val2 = (IDataItemContainer)((Control)val).BindingContainer;
		if (((Control)this).Page.GetDataItem() != null)
		{
			val.Text = Convert.ToString(RuntimeHelpers.GetObjectValue(((TemplateControl)this).Eval("DocLow")), CultureInfo.CurrentCulture);
		}
	}

	[DebuggerNonUserCode]
	private void __BuildControl__control21(Control __ctrl)
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Expected Obj, but got Unknown
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Expected Obj, but got Unknown
		((IParserAccessor)__ctrl).AddParsedSubObject((object)new LiteralControl("\r\n                                "));
		Label val = __BuildControl__control22();
		((IParserAccessor)__ctrl).AddParsedSubObject((object)val);
		((IParserAccessor)__ctrl).AddParsedSubObject((object)new LiteralControl("\r\n                            "));
	}

	[DebuggerNonUserCode]
	public IOrderedDictionary __ExtractValues__control21(Control __container)
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Expected Obj, but got Unknown
		Label val = (Label)__container.FindControl("dl1");
		OrderedDictionary orderedDictionary = new OrderedDictionary();
		if (val != null)
		{
			orderedDictionary["DocLow"] = val.Text;
		}
		return orderedDictionary;
	}

	[DebuggerNonUserCode]
	private TemplateField __BuildControl__control18()
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
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Expected Obj, but got Unknown
		//IL_004b: Expected Obj, but got Unknown
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Expected Obj, but got Unknown
		TemplateField val = new TemplateField();
		val.EditItemTemplate = (ITemplate)new CompiledBindableTemplateBuilder((BuildTemplateMethod)__BuildControl__control19, (ExtractTemplateValuesMethod)__ExtractValues__control19);
		val.ItemTemplate = (ITemplate)new CompiledBindableTemplateBuilder((BuildTemplateMethod)__BuildControl__control21, (ExtractTemplateValuesMethod)__ExtractValues__control21);
		((DataControlField)val).HeaderText = "DocLow";
		((DataControlField)val).SortExpression = "DocLow";
		return val;
	}

	[DebuggerNonUserCode]
	private TextBox __BuildControl__control25()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		TextBox val = new TextBox();
		((Control)val).TemplateControl = (TemplateControl)(object)this;
		((Control)val).ApplyStyleSheetSkin((Page)(object)this);
		((Control)val).ID = "TextBox7";
		((Control)val).DataBinding += __DataBinding__control25;
		return val;
	}

	public void __DataBinding__control25(object sender, EventArgs e)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Expected Obj, but got Unknown
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Expected Obj, but got Unknown
		TextBox val = (TextBox)sender;
		IDataItemContainer val2 = (IDataItemContainer)((Control)val).BindingContainer;
		if (((Control)this).Page.GetDataItem() != null)
		{
			val.Text = Convert.ToString(RuntimeHelpers.GetObjectValue(((TemplateControl)this).Eval("DocHigh")), CultureInfo.CurrentCulture);
		}
	}

	[DebuggerNonUserCode]
	private void __BuildControl__control24(Control __ctrl)
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Expected Obj, but got Unknown
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Expected Obj, but got Unknown
		((IParserAccessor)__ctrl).AddParsedSubObject((object)new LiteralControl("\r\n                                "));
		TextBox val = __BuildControl__control25();
		((IParserAccessor)__ctrl).AddParsedSubObject((object)val);
		((IParserAccessor)__ctrl).AddParsedSubObject((object)new LiteralControl("\r\n                            "));
	}

	[DebuggerNonUserCode]
	public IOrderedDictionary __ExtractValues__control24(Control __container)
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Expected Obj, but got Unknown
		TextBox val = (TextBox)__container.FindControl("TextBox7");
		OrderedDictionary orderedDictionary = new OrderedDictionary();
		if (val != null)
		{
			orderedDictionary["DocHigh"] = val.Text;
		}
		return orderedDictionary;
	}

	[DebuggerNonUserCode]
	private Label __BuildControl__control27()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Label val = new Label();
		((Control)val).TemplateControl = (TemplateControl)(object)this;
		((Control)val).ApplyStyleSheetSkin((Page)(object)this);
		((Control)val).ID = "dh1";
		((Control)val).DataBinding += __DataBinding__control27;
		return val;
	}

	public void __DataBinding__control27(object sender, EventArgs e)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Expected Obj, but got Unknown
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Expected Obj, but got Unknown
		Label val = (Label)sender;
		IDataItemContainer val2 = (IDataItemContainer)((Control)val).BindingContainer;
		if (((Control)this).Page.GetDataItem() != null)
		{
			val.Text = Convert.ToString(RuntimeHelpers.GetObjectValue(((TemplateControl)this).Eval("DocHigh")), CultureInfo.CurrentCulture);
		}
	}

	[DebuggerNonUserCode]
	private void __BuildControl__control26(Control __ctrl)
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Expected Obj, but got Unknown
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Expected Obj, but got Unknown
		((IParserAccessor)__ctrl).AddParsedSubObject((object)new LiteralControl("\r\n                                "));
		Label val = __BuildControl__control27();
		((IParserAccessor)__ctrl).AddParsedSubObject((object)val);
		((IParserAccessor)__ctrl).AddParsedSubObject((object)new LiteralControl("\r\n                            "));
	}

	[DebuggerNonUserCode]
	public IOrderedDictionary __ExtractValues__control26(Control __container)
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Expected Obj, but got Unknown
		Label val = (Label)__container.FindControl("dh1");
		OrderedDictionary orderedDictionary = new OrderedDictionary();
		if (val != null)
		{
			orderedDictionary["DocHigh"] = val.Text;
		}
		return orderedDictionary;
	}

	[DebuggerNonUserCode]
	private TemplateField __BuildControl__control23()
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
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Expected Obj, but got Unknown
		//IL_004b: Expected Obj, but got Unknown
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Expected Obj, but got Unknown
		TemplateField val = new TemplateField();
		val.EditItemTemplate = (ITemplate)new CompiledBindableTemplateBuilder((BuildTemplateMethod)__BuildControl__control24, (ExtractTemplateValuesMethod)__ExtractValues__control24);
		val.ItemTemplate = (ITemplate)new CompiledBindableTemplateBuilder((BuildTemplateMethod)__BuildControl__control26, (ExtractTemplateValuesMethod)__ExtractValues__control26);
		((DataControlField)val).HeaderText = "DocHigh";
		((DataControlField)val).SortExpression = "DocHigh";
		return val;
	}

	[DebuggerNonUserCode]
	private TextBox __BuildControl__control30()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		TextBox val = new TextBox();
		((Control)val).TemplateControl = (TemplateControl)(object)this;
		((Control)val).ApplyStyleSheetSkin((Page)(object)this);
		((Control)val).ID = "TextBox1";
		((Control)val).DataBinding += __DataBinding__control30;
		return val;
	}

	public void __DataBinding__control30(object sender, EventArgs e)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Expected Obj, but got Unknown
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Expected Obj, but got Unknown
		TextBox val = (TextBox)sender;
		IDataItemContainer val2 = (IDataItemContainer)((Control)val).BindingContainer;
		if (((Control)this).Page.GetDataItem() != null)
		{
			val.Text = Convert.ToString(RuntimeHelpers.GetObjectValue(((TemplateControl)this).Eval("MedLow")), CultureInfo.CurrentCulture);
		}
	}

	[DebuggerNonUserCode]
	private void __BuildControl__control29(Control __ctrl)
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Expected Obj, but got Unknown
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Expected Obj, but got Unknown
		((IParserAccessor)__ctrl).AddParsedSubObject((object)new LiteralControl("\r\n                                "));
		TextBox val = __BuildControl__control30();
		((IParserAccessor)__ctrl).AddParsedSubObject((object)val);
		((IParserAccessor)__ctrl).AddParsedSubObject((object)new LiteralControl("\r\n                            "));
	}

	[DebuggerNonUserCode]
	public IOrderedDictionary __ExtractValues__control29(Control __container)
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Expected Obj, but got Unknown
		TextBox val = (TextBox)__container.FindControl("TextBox1");
		OrderedDictionary orderedDictionary = new OrderedDictionary();
		if (val != null)
		{
			orderedDictionary["MedLow"] = val.Text;
		}
		return orderedDictionary;
	}

	[DebuggerNonUserCode]
	private TextBox __BuildControl__control32()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		TextBox val = new TextBox();
		((Control)val).TemplateControl = (TemplateControl)(object)this;
		((Control)val).ApplyStyleSheetSkin((Page)(object)this);
		((Control)val).ID = "TextBox1";
		Unit width = new Unit(75.0, (UnitType)1);
		((WebControl)val).Width = width;
		((Control)val).DataBinding += __DataBinding__control32;
		return val;
	}

	public void __DataBinding__control32(object sender, EventArgs e)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Expected Obj, but got Unknown
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Expected Obj, but got Unknown
		TextBox val = (TextBox)sender;
		IDataItemContainer val2 = (IDataItemContainer)((Control)val).BindingContainer;
		if (((Control)this).Page.GetDataItem() != null)
		{
			val.Text = Convert.ToString(RuntimeHelpers.GetObjectValue(((TemplateControl)this).Eval("MedLow")), CultureInfo.CurrentCulture);
		}
	}

	[DebuggerNonUserCode]
	private void __BuildControl__control31(Control __ctrl)
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Expected Obj, but got Unknown
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Expected Obj, but got Unknown
		((IParserAccessor)__ctrl).AddParsedSubObject((object)new LiteralControl("\r\n                                "));
		TextBox val = __BuildControl__control32();
		((IParserAccessor)__ctrl).AddParsedSubObject((object)val);
		((IParserAccessor)__ctrl).AddParsedSubObject((object)new LiteralControl("\r\n                            "));
	}

	[DebuggerNonUserCode]
	public IOrderedDictionary __ExtractValues__control31(Control __container)
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Expected Obj, but got Unknown
		TextBox val = (TextBox)__container.FindControl("TextBox1");
		OrderedDictionary orderedDictionary = new OrderedDictionary();
		if (val != null)
		{
			orderedDictionary["MedLow"] = val.Text;
		}
		return orderedDictionary;
	}

	[DebuggerNonUserCode]
	private TemplateField __BuildControl__control28()
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
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Expected Obj, but got Unknown
		//IL_004b: Expected Obj, but got Unknown
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Expected Obj, but got Unknown
		TemplateField val = new TemplateField();
		val.EditItemTemplate = (ITemplate)new CompiledBindableTemplateBuilder((BuildTemplateMethod)__BuildControl__control29, (ExtractTemplateValuesMethod)__ExtractValues__control29);
		val.ItemTemplate = (ITemplate)new CompiledBindableTemplateBuilder((BuildTemplateMethod)__BuildControl__control31, (ExtractTemplateValuesMethod)__ExtractValues__control31);
		((DataControlField)val).HeaderText = "MedLow";
		((DataControlField)val).SortExpression = "MedLow";
		return val;
	}

	[DebuggerNonUserCode]
	private TextBox __BuildControl__control35()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		TextBox val = new TextBox();
		((Control)val).TemplateControl = (TemplateControl)(object)this;
		((Control)val).ApplyStyleSheetSkin((Page)(object)this);
		((Control)val).ID = "TextBox2";
		((Control)val).DataBinding += __DataBinding__control35;
		return val;
	}

	public void __DataBinding__control35(object sender, EventArgs e)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Expected Obj, but got Unknown
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Expected Obj, but got Unknown
		TextBox val = (TextBox)sender;
		IDataItemContainer val2 = (IDataItemContainer)((Control)val).BindingContainer;
		if (((Control)this).Page.GetDataItem() != null)
		{
			val.Text = Convert.ToString(RuntimeHelpers.GetObjectValue(((TemplateControl)this).Eval("MedHigh")), CultureInfo.CurrentCulture);
		}
	}

	[DebuggerNonUserCode]
	private void __BuildControl__control34(Control __ctrl)
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Expected Obj, but got Unknown
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Expected Obj, but got Unknown
		((IParserAccessor)__ctrl).AddParsedSubObject((object)new LiteralControl("\r\n                                "));
		TextBox val = __BuildControl__control35();
		((IParserAccessor)__ctrl).AddParsedSubObject((object)val);
		((IParserAccessor)__ctrl).AddParsedSubObject((object)new LiteralControl("\r\n                            "));
	}

	[DebuggerNonUserCode]
	public IOrderedDictionary __ExtractValues__control34(Control __container)
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Expected Obj, but got Unknown
		TextBox val = (TextBox)__container.FindControl("TextBox2");
		OrderedDictionary orderedDictionary = new OrderedDictionary();
		if (val != null)
		{
			orderedDictionary["MedHigh"] = val.Text;
		}
		return orderedDictionary;
	}

	[DebuggerNonUserCode]
	private TextBox __BuildControl__control37()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		TextBox val = new TextBox();
		((Control)val).TemplateControl = (TemplateControl)(object)this;
		((Control)val).ApplyStyleSheetSkin((Page)(object)this);
		((Control)val).ID = "TextBox2";
		Unit width = new Unit(75.0, (UnitType)1);
		((WebControl)val).Width = width;
		((Control)val).DataBinding += __DataBinding__control37;
		return val;
	}

	public void __DataBinding__control37(object sender, EventArgs e)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Expected Obj, but got Unknown
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Expected Obj, but got Unknown
		TextBox val = (TextBox)sender;
		IDataItemContainer val2 = (IDataItemContainer)((Control)val).BindingContainer;
		if (((Control)this).Page.GetDataItem() != null)
		{
			val.Text = Convert.ToString(RuntimeHelpers.GetObjectValue(((TemplateControl)this).Eval("MedHigh")), CultureInfo.CurrentCulture);
		}
	}

	[DebuggerNonUserCode]
	private void __BuildControl__control36(Control __ctrl)
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Expected Obj, but got Unknown
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Expected Obj, but got Unknown
		((IParserAccessor)__ctrl).AddParsedSubObject((object)new LiteralControl("\r\n                                "));
		TextBox val = __BuildControl__control37();
		((IParserAccessor)__ctrl).AddParsedSubObject((object)val);
		((IParserAccessor)__ctrl).AddParsedSubObject((object)new LiteralControl("\r\n                            "));
	}

	[DebuggerNonUserCode]
	public IOrderedDictionary __ExtractValues__control36(Control __container)
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Expected Obj, but got Unknown
		TextBox val = (TextBox)__container.FindControl("TextBox2");
		OrderedDictionary orderedDictionary = new OrderedDictionary();
		if (val != null)
		{
			orderedDictionary["MedHigh"] = val.Text;
		}
		return orderedDictionary;
	}

	[DebuggerNonUserCode]
	private TemplateField __BuildControl__control33()
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
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Expected Obj, but got Unknown
		//IL_004b: Expected Obj, but got Unknown
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Expected Obj, but got Unknown
		TemplateField val = new TemplateField();
		val.EditItemTemplate = (ITemplate)new CompiledBindableTemplateBuilder((BuildTemplateMethod)__BuildControl__control34, (ExtractTemplateValuesMethod)__ExtractValues__control34);
		val.ItemTemplate = (ITemplate)new CompiledBindableTemplateBuilder((BuildTemplateMethod)__BuildControl__control36, (ExtractTemplateValuesMethod)__ExtractValues__control36);
		((DataControlField)val).HeaderText = "MedHigh";
		((DataControlField)val).SortExpression = "MedHigh";
		return val;
	}

	[DebuggerNonUserCode]
	private TextBox __BuildControl__control40()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		TextBox val = new TextBox();
		((Control)val).TemplateControl = (TemplateControl)(object)this;
		((Control)val).ApplyStyleSheetSkin((Page)(object)this);
		((Control)val).ID = "ResultTXT";
		((Control)val).DataBinding += __DataBinding__control40;
		return val;
	}

	public void __DataBinding__control40(object sender, EventArgs e)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Expected Obj, but got Unknown
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Expected Obj, but got Unknown
		TextBox val = (TextBox)sender;
		IDataItemContainer val2 = (IDataItemContainer)((Control)val).BindingContainer;
		if (((Control)this).Page.GetDataItem() != null)
		{
			val.Text = Convert.ToString(RuntimeHelpers.GetObjectValue(((TemplateControl)this).Eval("Defaultval")), CultureInfo.CurrentCulture);
		}
	}

	[DebuggerNonUserCode]
	private RegularExpressionValidator __BuildControl__control41()
	{
		RegularExpressionValidator regularExpressionValidator = new RegularExpressionValidator();
		((Control)regularExpressionValidator).TemplateControl = (TemplateControl)(object)this;
		((Control)regularExpressionValidator).ApplyStyleSheetSkin((Page)(object)this);
		((Control)regularExpressionValidator).ID = "RegularExpressionValidator1";
		((BaseValidator)regularExpressionValidator).ControlToValidate = "ResultTXT";
		((BaseValidator)regularExpressionValidator).Display = (ValidatorDisplay)2;
		((BaseValidator)regularExpressionValidator).ErrorMessage = "<br>Only numbers are acceptable";
		((RegularExpressionValidator)regularExpressionValidator).ValidationExpression = "\\d+(\\.\\d{1,11})?";
		((WebControl)regularExpressionValidator).BackColor = Color.WhiteSmoke;
		return regularExpressionValidator;
	}

	[DebuggerNonUserCode]
	private void __BuildControl__control39(Control __ctrl)
	{
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Expected Obj, but got Unknown
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_0051: Expected Obj, but got Unknown
		((IParserAccessor)__ctrl).AddParsedSubObject((object)((TemplateControl)this).CreateResourceBasedLiteralControl(0, 260, true));
		TextBox val = __BuildControl__control40();
		((IParserAccessor)__ctrl).AddParsedSubObject((object)val);
		((IParserAccessor)__ctrl).AddParsedSubObject((object)new LiteralControl("\r\n                                        \r\n                                            "));
		RegularExpressionValidator regularExpressionValidator = __BuildControl__control41();
		((IParserAccessor)__ctrl).AddParsedSubObject((object)regularExpressionValidator);
		((IParserAccessor)__ctrl).AddParsedSubObject((object)new LiteralControl("</td>\r\n                                    </tr>\r\n                                </table>\r\n                            "));
	}

	[DebuggerNonUserCode]
	public IOrderedDictionary __ExtractValues__control39(Control __container)
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Expected Obj, but got Unknown
		TextBox val = (TextBox)__container.FindControl("ResultTXT");
		OrderedDictionary orderedDictionary = new OrderedDictionary();
		if (val != null)
		{
			orderedDictionary["Defaultval"] = val.Text;
		}
		return orderedDictionary;
	}

	[DebuggerNonUserCode]
	private TemplateField __BuildControl__control38()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Expected Obj, but got Unknown
		//IL_0026: Expected Obj, but got Unknown
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Expected Obj, but got Unknown
		TemplateField val = new TemplateField();
		val.ItemTemplate = (ITemplate)new CompiledBindableTemplateBuilder((BuildTemplateMethod)__BuildControl__control39, (ExtractTemplateValuesMethod)__ExtractValues__control39);
		return val;
	}

	[DebuggerNonUserCode]
	private void __BuildControl__control2(DataControlFieldCollection __ctrl)
	{
		TemplateField val = __BuildControl__control3();
		__ctrl.Add((DataControlField)(object)val);
		TemplateField val2 = __BuildControl__control8();
		__ctrl.Add((DataControlField)(object)val2);
		TemplateField val3 = __BuildControl__control13();
		__ctrl.Add((DataControlField)(object)val3);
		TemplateField val4 = __BuildControl__control18();
		__ctrl.Add((DataControlField)(object)val4);
		TemplateField val5 = __BuildControl__control23();
		__ctrl.Add((DataControlField)(object)val5);
		TemplateField val6 = __BuildControl__control28();
		__ctrl.Add((DataControlField)(object)val6);
		TemplateField val7 = __BuildControl__control33();
		__ctrl.Add((DataControlField)(object)val7);
		TemplateField val8 = __BuildControl__control38();
		__ctrl.Add((DataControlField)(object)val8);
	}

	[DebuggerNonUserCode]
	private void __BuildControl__control42(TableItemStyle __ctrl)
	{
		__ctrl.VerticalAlign = (VerticalAlign)1;
	}

	[DebuggerNonUserCode]
	private GridView __BuildControlGridView1()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		GridView val = (GridView1 = new GridView());
		((Control)val).TemplateControl = (TemplateControl)(object)this;
		((Control)val).ApplyStyleSheetSkin((Page)(object)this);
		((Control)val).ID = "GridView1";
		val.AutoGenerateColumns = false;
		((DataBoundControl)val).DataSourceID = "SqlDataSource1";
		val.EmptyDataText = "There are no data records to display.";
		val.DataKeyNames = new string[1] { "rid" };
		((DataBoundControl)val).DataMember = "DefaultView";
		__BuildControl__control2(val.Columns);
		__BuildControl__control42(val.RowStyle);
		return val;
	}

	[DebuggerNonUserCode]
	private Parameter __BuildControl__control44()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Parameter val = new Parameter();
		val.DefaultValue = "Male";
		val.Name = "sex";
		return val;
	}

	[DebuggerNonUserCode]
	private void __BuildControl__control43(ParameterCollection __ctrl)
	{
		Parameter val = __BuildControl__control44();
		__ctrl.Add(val);
	}

	[DebuggerNonUserCode]
	private SqlDataSource __BuildControlSqlDataSource1()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		SqlDataSource val = (SqlDataSource1 = new SqlDataSource());
		((Control)val).TemplateControl = (TemplateControl)(object)this;
		((Control)val).ID = "SqlDataSource1";
		val.SelectCommand = "SELECT testName, testAbrev, DocLow, DocHigh, MedLow, MedHigh, rid, Defaultval FROM TestRef WHERE (Sex = @sex) AND (rid > 0)";
		__BuildControl__control43(val.SelectParameters);
		val.ConnectionString = Convert.ToString(ConnectionStringsExpressionBuilder.GetConnectionString("nazdiltarinConnectionString"), CultureInfo.CurrentCulture);
		val.ProviderName = Convert.ToString(ConnectionStringsExpressionBuilder.GetConnectionStringProviderName("LocalSqlServer"), CultureInfo.CurrentCulture);
		return val;
	}

	[DebuggerNonUserCode]
	private Button __BuildControlButton1()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Button val = (Button1 = new Button());
		((Control)val).TemplateControl = (TemplateControl)(object)this;
		((Control)val).ApplyStyleSheetSkin((Page)(object)this);
		((Control)val).ID = "Button1";
		val.Text = "Submit";
		return val;
	}

	[DebuggerNonUserCode]
	private ConfirmButtonExtender __BuildControlConfirmButtonExtender1()
	{
		ConfirmButtonExtender confirmButtonExtender = (ConfirmButtonExtender1 = new ConfirmButtonExtender());
		((Control)confirmButtonExtender).TemplateControl = (TemplateControl)(object)this;
		((Control)confirmButtonExtender).ApplyStyleSheetSkin((Page)(object)this);
		((Control)confirmButtonExtender).ID = "ConfirmButtonExtender1";
		((ExtenderControl)confirmButtonExtender).TargetControlID = "Button1";
		confirmButtonExtender.ConfirmText = "Are you sure that you want to submit your lab result? *Use Tab button to move over the textboxes!";
		return confirmButtonExtender;
	}

	[DebuggerNonUserCode]
	private void __BuildControlContent1(Control __ctrl)
	{
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Expected Obj, but got Unknown
		//IL_0051: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Expected Obj, but got Unknown
		//IL_0071: Unknown result type (might be due to invalid IL or missing references)
		//IL_007b: Expected Obj, but got Unknown
		((IParserAccessor)__ctrl).AddParsedSubObject((object)((TemplateControl)this).CreateResourceBasedLiteralControl(260, 313, true));
		GridView val = __BuildControlGridView1();
		((IParserAccessor)__ctrl).AddParsedSubObject((object)val);
		((IParserAccessor)__ctrl).AddParsedSubObject((object)new LiteralControl("\r\n                "));
		SqlDataSource val2 = __BuildControlSqlDataSource1();
		((IParserAccessor)__ctrl).AddParsedSubObject((object)val2);
		((IParserAccessor)__ctrl).AddParsedSubObject((object)new LiteralControl("\r\n            </td>\r\n        </tr>\r\n        <tr>\r\n            <td style=\"width: 100px\">\r\n                "));
		Button val3 = __BuildControlButton1();
		((IParserAccessor)__ctrl).AddParsedSubObject((object)val3);
		((IParserAccessor)__ctrl).AddParsedSubObject((object)new LiteralControl("\r\n                "));
		ConfirmButtonExtender confirmButtonExtender = __BuildControlConfirmButtonExtender1();
		((IParserAccessor)__ctrl).AddParsedSubObject((object)confirmButtonExtender);
		((IParserAccessor)__ctrl).AddParsedSubObject((object)((TemplateControl)this).CreateResourceBasedLiteralControl(573, 336, true));
	}

	[DebuggerNonUserCode]
	private void __BuildControlTree(labcalc_resultin_aspx __ctrl)
	{
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Expected Obj, but got Unknown
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Expected Obj, but got Unknown
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Expected Obj, but got Unknown
		((Page)__ctrl).MasterPageFile = "~/master1.master";
		((Page)__ctrl).Title = "Mental StressTester :: Online Lab";
		((Page)this).InitializeCulture();
		((Page)this).AddContentTemplate("ContentPlaceHolder1", (ITemplate)new CompiledTemplateBuilder((BuildTemplateMethod)__BuildControlContent1));
		((IParserAccessor)__ctrl).AddParsedSubObject((object)new LiteralControl("\r\n\r\n"));
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
		return -1112009766;
	}

	[DebuggerNonUserCode]
	public override void ProcessRequest(HttpContext context)
	{
		((Page)this).ProcessRequest(context);
	}
}
