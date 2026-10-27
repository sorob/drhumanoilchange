using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Web;
using System.Web.Profile;
using System.Web.SessionState;
using System.Web.UI;
using System.Web.UI.WebControls;
using AjaxControlToolkit;
using DataSet2TableAdapters;
using DataSet3TableAdapters;
using LabstuffTableAdapters;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using PayPal.Web.Controls;
using tempdataTableAdapters;
using textrefTableAdapters;

public class LabCalc_ResultView : Page, IRequiresSessionState
{
	[AccessedThroughProperty("RadioButtonList2")]
	private RadioButtonList _RadioButtonList2;

	[AccessedThroughProperty("Button2")]
	private Button _Button2;

	[AccessedThroughProperty("Button5")]
	private Button _Button5;

	[AccessedThroughProperty("btnAddtest")]
	private Button _btnAddtest;

	[AccessedThroughProperty("Button6")]
	private Button _Button6;

	[AccessedThroughProperty("GridView1")]
	private GridView _GridView1;

	[AccessedThroughProperty("UpdatePanel1")]
	private UpdatePanel _UpdatePanel1;

	[AccessedThroughProperty("LinkButton1")]
	private LinkButton _LinkButton1;

	[AccessedThroughProperty("GridView5")]
	private GridView _GridView5;

	[AccessedThroughProperty("Sqlref")]
	private SqlDataSource _Sqlref;

	[AccessedThroughProperty("AlwaysVisibleControlExtender1")]
	private AlwaysVisibleControlExtender _AlwaysVisibleControlExtender1;

	[AccessedThroughProperty("Panel1")]
	private Panel _Panel1;

	[AccessedThroughProperty("UpdatePanel2")]
	private UpdatePanel _UpdatePanel2;

	[AccessedThroughProperty("SqlDataSource1")]
	private SqlDataSource _SqlDataSource1;

	[AccessedThroughProperty("Button1")]
	private Button _Button1;

	[AccessedThroughProperty("Button4")]
	private Button _Button4;

	[AccessedThroughProperty("btnAddtest1")]
	private Button _btnAddtest1;

	[AccessedThroughProperty("View1")]
	private View _View1;

	[AccessedThroughProperty("GridView4")]
	private GridView _GridView4;

	[AccessedThroughProperty("GridView3")]
	private GridView _GridView3;

	[AccessedThroughProperty("GridView2")]
	private GridView _GridView2;

	[AccessedThroughProperty("bookPlaceHolder")]
	private PlaceHolder _bookPlaceHolder;

	[AccessedThroughProperty("View2")]
	private View _View2;

	[AccessedThroughProperty("Image2")]
	private Image _Image2;

	[AccessedThroughProperty("RadioButtonList1")]
	private RadioButtonList _RadioButtonList1;

	[AccessedThroughProperty("Button3")]
	private Button _Button3;

	[AccessedThroughProperty("View3")]
	private View _View3;

	[AccessedThroughProperty("Labelusr")]
	private Label _Labelusr;

	[AccessedThroughProperty("Labelamnt")]
	private Label _Labelamnt;

	[AccessedThroughProperty("BuyNowButton1")]
	private BuyNowButton _BuyNowButton1;

	[AccessedThroughProperty("View4")]
	private View _View4;

	[AccessedThroughProperty("MultiView1")]
	private MultiView _MultiView1;

	private tempdataTableAdapters.txtimpTableAdapter txtda;

	private tempdata.txtimpDataTable txtds;

	protected virtual RadioButtonList RadioButtonList2
	{
		get
		{
			return _RadioButtonList2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			EventHandler eventHandler = RadioButtonList2_SelectedIndexChanged;
			if (_RadioButtonList2 != null)
			{
				((ListControl)_RadioButtonList2).SelectedIndexChanged -= eventHandler;
			}
			_RadioButtonList2 = value;
			if (_RadioButtonList2 != null)
			{
				((ListControl)_RadioButtonList2).SelectedIndexChanged += eventHandler;
			}
		}
	}

	protected virtual Button Button2
	{
		get
		{
			return _Button2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			EventHandler eventHandler = Button2_Click;
			if (_Button2 != null)
			{
				_Button2.Click -= eventHandler;
			}
			_Button2 = value;
			if (_Button2 != null)
			{
				_Button2.Click += eventHandler;
			}
		}
	}

	protected virtual Button Button5
	{
		get
		{
			return _Button5;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			EventHandler eventHandler = Button5_Click;
			if (_Button5 != null)
			{
				_Button5.Click -= eventHandler;
			}
			_Button5 = value;
			if (_Button5 != null)
			{
				_Button5.Click += eventHandler;
			}
		}
	}

	protected virtual Button btnAddtest
	{
		get
		{
			return _btnAddtest;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			EventHandler eventHandler = btnAddtest_Click;
			if (_btnAddtest != null)
			{
				_btnAddtest.Click -= eventHandler;
			}
			_btnAddtest = value;
			if (_btnAddtest != null)
			{
				_btnAddtest.Click += eventHandler;
			}
		}
	}

	protected virtual Button Button6
	{
		get
		{
			return _Button6;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			EventHandler eventHandler = Button6_Click;
			if (_Button6 != null)
			{
				_Button6.Click -= eventHandler;
			}
			_Button6 = value;
			if (_Button6 != null)
			{
				_Button6.Click += eventHandler;
			}
		}
	}

	protected virtual GridView GridView1
	{
		get
		{
			return _GridView1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			EventHandler eventHandler = GridView1_SelectedIndexChanged;
			if (_GridView1 != null)
			{
				_GridView1.SelectedIndexChanged -= eventHandler;
			}
			_GridView1 = value;
			if (_GridView1 != null)
			{
				_GridView1.SelectedIndexChanged += eventHandler;
			}
		}
	}

	protected virtual UpdatePanel UpdatePanel1
	{
		get
		{
			return _UpdatePanel1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_UpdatePanel1 = value;
		}
	}

	protected virtual LinkButton LinkButton1
	{
		get
		{
			return _LinkButton1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			EventHandler eventHandler = LinkButton1_Click;
			if (_LinkButton1 != null)
			{
				_LinkButton1.Click -= eventHandler;
			}
			_LinkButton1 = value;
			if (_LinkButton1 != null)
			{
				_LinkButton1.Click += eventHandler;
			}
		}
	}

	protected virtual GridView GridView5
	{
		get
		{
			return _GridView5;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_GridView5 = value;
		}
	}

	protected virtual SqlDataSource Sqlref
	{
		get
		{
			return _Sqlref;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_Sqlref = value;
		}
	}

	protected virtual AlwaysVisibleControlExtender AlwaysVisibleControlExtender1
	{
		get
		{
			return _AlwaysVisibleControlExtender1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_AlwaysVisibleControlExtender1 = value;
		}
	}

	protected virtual Panel Panel1
	{
		get
		{
			return _Panel1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_Panel1 = value;
		}
	}

	protected virtual UpdatePanel UpdatePanel2
	{
		get
		{
			return _UpdatePanel2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_UpdatePanel2 = value;
		}
	}

	protected virtual SqlDataSource SqlDataSource1
	{
		get
		{
			return _SqlDataSource1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_SqlDataSource1 = value;
		}
	}

	protected virtual Button Button1
	{
		get
		{
			return _Button1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			EventHandler eventHandler = Button1_Click;
			if (_Button1 != null)
			{
				_Button1.Click -= eventHandler;
			}
			_Button1 = value;
			if (_Button1 != null)
			{
				_Button1.Click += eventHandler;
			}
		}
	}

	protected virtual Button Button4
	{
		get
		{
			return _Button4;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			EventHandler eventHandler = Button4_Click;
			if (_Button4 != null)
			{
				_Button4.Click -= eventHandler;
			}
			_Button4 = value;
			if (_Button4 != null)
			{
				_Button4.Click += eventHandler;
			}
		}
	}

	protected virtual Button btnAddtest1
	{
		get
		{
			return _btnAddtest1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			EventHandler eventHandler = btnAddtest1_Click;
			if (_btnAddtest1 != null)
			{
				_btnAddtest1.Click -= eventHandler;
			}
			_btnAddtest1 = value;
			if (_btnAddtest1 != null)
			{
				_btnAddtest1.Click += eventHandler;
			}
		}
	}

	protected virtual View View1
	{
		get
		{
			return _View1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_View1 = value;
		}
	}

	protected virtual GridView GridView4
	{
		get
		{
			return _GridView4;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_GridView4 = value;
		}
	}

	protected virtual GridView GridView3
	{
		get
		{
			return _GridView3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_GridView3 = value;
		}
	}

	protected virtual GridView GridView2
	{
		get
		{
			return _GridView2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_GridView2 = value;
		}
	}

	protected virtual PlaceHolder bookPlaceHolder
	{
		get
		{
			return _bookPlaceHolder;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_bookPlaceHolder = value;
		}
	}

	protected virtual View View2
	{
		get
		{
			return _View2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_View2 = value;
		}
	}

	protected virtual Image Image2
	{
		get
		{
			return _Image2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_Image2 = value;
		}
	}

	protected virtual RadioButtonList RadioButtonList1
	{
		get
		{
			return _RadioButtonList1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_RadioButtonList1 = value;
		}
	}

	protected virtual Button Button3
	{
		get
		{
			return _Button3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			EventHandler eventHandler = Button3_Click;
			if (_Button3 != null)
			{
				_Button3.Click -= eventHandler;
			}
			_Button3 = value;
			if (_Button3 != null)
			{
				_Button3.Click += eventHandler;
			}
		}
	}

	protected virtual View View3
	{
		get
		{
			return _View3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_View3 = value;
		}
	}

	protected virtual Label Labelusr
	{
		get
		{
			return _Labelusr;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_Labelusr = value;
		}
	}

	protected virtual Label Labelamnt
	{
		get
		{
			return _Labelamnt;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_Labelamnt = value;
		}
	}

	protected virtual BuyNowButton BuyNowButton1
	{
		get
		{
			return _BuyNowButton1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_BuyNowButton1 = value;
		}
	}

	protected virtual View View4
	{
		get
		{
			return _View4;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_View4 = value;
		}
	}

	protected virtual MultiView MultiView1
	{
		get
		{
			return _MultiView1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_MultiView1 = value;
		}
	}

	protected DefaultProfile Profile
	{
		get
		{
			//IL_000b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0011: Expected Obj, but got Unknown
			return (DefaultProfile)((Page)this).Context.Profile;
		}
	}

	protected HttpApplication ApplicationInstance => ((Page)this).Context.ApplicationInstance;

	public LabCalc_ResultView()
	{
		((Control)this).Load += Page_Load;
		txtda = new tempdataTableAdapters.txtimpTableAdapter();
		txtds = new tempdata.txtimpDataTable();
	}

	protected void SaveData(object sender, EventArgs e)
	{
	}

	protected void Button2_Click(object sender, EventArgs e)
	{
		geadvices();
	}

	private void geadvices()
	{
		//IL_00a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ac: Expected Obj, but got Unknown
		//IL_00e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e8: Expected Obj, but got Unknown
		//IL_010f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0116: Expected Obj, but got Unknown
		//IL_039b: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a2: Expected Obj, but got Unknown
		//IL_03ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c1: Expected Obj, but got Unknown
		//IL_03d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_03dd: Expected Obj, but got Unknown
		//IL_03f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_03f9: Expected Obj, but got Unknown
		//IL_03f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0400: Expected Obj, but got Unknown
		string text = ((!Conversions.ToBoolean(Operators.AndObject(Operators.CompareObjectNotEqual(((Page)this).Session["userid"], "", TextCompare: false), Operators.CompareString(((Page)this).Request["mode"], "admin", TextCompare: false) == 0))) ? ((Page)this).User.Identity.Name : Conversions.ToString(((Page)this).Session["userid"]));
		UserInfoTableAdapter userInfoTableAdapter = new UserInfoTableAdapter();
		int num = Conversions.ToInteger(userInfoTableAdapter.ScalarQuery(text));
		gotadviseTableAdapter gotadviseTableAdapter2 = new gotadviseTableAdapter();
		int num2 = (int)gotadviseTableAdapter2.getgot(text);
		Dictionary<string, Labstuff.testbookref1DataTable> dictionary = new Dictionary<string, Labstuff.testbookref1DataTable>();
		Table val = new Table();
		checked
		{
			if (num > num2)
			{
				Labstuff.Rx1DataTable rx1DataTable = new Labstuff.Rx1DataTable();
				int num3 = GridView1.Rows.Count - 1;
				int num4 = default;
				for (int i = 0; i <= num3 && num4 < 6; i++)
				{
					CheckBox val2 = new CheckBox();
					val2 = (CheckBox)((Control)((TableRow)GridView1.Rows[i]).Cells[0]).FindControl("CBoks1");
					string text2 = ((TableRow)GridView1.Rows[i]).Cells[2].Text;
					string text3 = ((TableRow)GridView1.Rows[i]).Cells[3].Text;
					if (Operators.CompareString(text2, "C/P", TextCompare: false) == 0)
					{
						double num5 = Conversions.ToDouble(((TableRow)GridView1.Rows[i]).Cells[1].Text);
						CPRxTableAdapter cPRxTableAdapter = new CPRxTableAdapter();
						DataSet3.CPRxDataTable cPRxDataTable = new DataSet3.CPRxDataTable();
						cPRxTableAdapter.Fill(cPRxDataTable, (float)num5);
						((BaseDataBoundControl)GridView3).DataSource = cPRxDataTable;
						GridView3.DataBind();
					}
					else if (Operators.CompareString(text2, "TPR", TextCompare: false) == 0)
					{
						double num6 = Conversions.ToDouble(((TableRow)GridView1.Rows[i]).Cells[1].Text);
						TPRTableAdapter tPRTableAdapter = new TPRTableAdapter();
						DataSet3.TPRDataTable tPRDataTable = new DataSet3.TPRDataTable();
						tPRTableAdapter.Fill(tPRDataTable, num6);
						((BaseDataBoundControl)GridView4).DataSource = tPRDataTable;
						GridView4.DataBind();
					}
					if (!val2.Checked)
					{
						continue;
					}
					num4++;
					double num7 = Conversions.ToDouble(((TableRow)GridView1.Rows[i]).Cells[11].Text);
					double num8 = Math.Abs(num7);
					if (num8 >= 500.0)
					{
						int num9 = 5;
					}
					else if (num8 >= 250.0)
					{
						int num9 = 4;
					}
					else if (num8 >= 100.0)
					{
						int num9 = 3;
					}
					else if (num8 >= 80.0)
					{
						int num9 = 2;
					}
					else
					{
						if (!(num8 >= 70.0))
						{
							continue;
						}
						int num9 = 1;
					}
					string lh = ((!(num7 < 0.0)) ? "High" : "Low");
					Rx1TableAdapter rx1TableAdapter = new Rx1TableAdapter();
					rx1DataTable.Merge(rx1TableAdapter.GetData(text2, lh, new decimal(num7)));
					if (dictionary.ContainsKey(text3))
					{
						Labstuff.testbookref1DataTable testbookref1DataTable = dictionary[text3];
						testbookref1DataTable.Merge(fillMyGrid(text2));
						dictionary[text3] = testbookref1DataTable;
					}
					else
					{
						dictionary.Add(text3, fillMyGrid(text2));
					}
				}
				((BaseDataBoundControl)GridView2).DataSource = rx1DataTable;
				GridView2.DataBind();
				foreach (KeyValuePair<string, Labstuff.testbookref1DataTable> item in dictionary)
				{
					Label val3 = new Label();
					val3.Text = item.Key + "<br />";
					Style val4 = new Style();
					val4.CssClass = "bookCategory";
					((WebControl)val3).ApplyStyle(val4);
					GridView val5 = new GridView();
					((BaseDataBoundControl)val5).DataSource = item.Value;
					val5.DataBind();
					TableRow val6 = new TableRow();
					TableCell val7 = new TableCell();
					((Control)val7).Controls.Add((Control)(object)val3);
					((Control)val7).Controls.Add((Control)(object)val5);
					((Control)val6).Controls.Add((Control)(object)val7);
					val.Rows.Add(val6);
				}
				((Control)bookPlaceHolder).Controls.Add((Control)(object)val);
				MultiView1.SetActiveView(View2);
			}
			else
			{
				MultiView1.SetActiveView(View3);
			}
		}
	}

	private Labstuff.testbookref1DataTable fillMyGrid(string abrev)
	{
		Labstuff.testbookref1DataTable testbookref1DataTable = new Labstuff.testbookref1DataTable();
		testbookref1TableAdapter testbookref1TableAdapter2 = new testbookref1TableAdapter();
		testbookref1TableAdapter2.Fill(testbookref1DataTable, abrev);
		return testbookref1DataTable;
	}

	public double roundIt(double num, int inPower)
	{
		int num2 = checked((int)Math.Round(Math.Pow(10.0, inPower)));
		num *= (double)num2;
		num = Math.Round(num);
		num /= (double)num2;
		return num;
	}

	private double getDif(double low, double high)
	{
		return high - low;
	}

	private double getOpt(double low, double high)
	{
		return (high - low) / 2.0 + low;
	}

	private double getScale(double low, double high, double result)
	{
		return roundIt((result - getOpt(low, high)) / getDif(low, high) * 100.0, 4);
	}

	protected void Button1_Click(object sender, EventArgs e)
	{
		geadvices();
	}

	protected void Page_Load(object sender, EventArgs e)
	{
		string userName = ((!Conversions.ToBoolean(Operators.AndObject(Operators.CompareObjectNotEqual(((Page)this).Session["userid"], "", TextCompare: false), Operators.CompareString(((Page)this).Request["mode"], "admin", TextCompare: false) == 0))) ? ((Page)this).User.Identity.Name : Conversions.ToString(((Page)this).Session["userid"]));
		if (((Control)this).Page.IsPostBack)
		{
			return;
		}
		checked
		{
			if (((Page)this).Session["TestId"] != null)
			{
				SqlDataSource1.SelectParameters[0].DefaultValue = Conversions.ToString(((Page)this).Session["TestId"]);
				GridView1.DataBind();
				if (((Control)this).Page.IsPostBack)
				{
					return;
				}
				ResultRefTableAdapter resultRefTableAdapter = new ResultRefTableAdapter();
				int num = GridView1.Rows.Count - 1;
				bool flag18 = default;
				double num14 = default;
				bool flag17 = default;
				double num13 = default;
				bool flag16 = default;
				double num12 = default;
				bool flag15 = default;
				double num11 = default;
				bool flag14 = default;
				double num10 = default;
				bool flag13 = default;
				double num9 = default;
				bool flag11 = default;
				double num7 = default;
				bool flag10 = default;
				double num6 = default;
				bool flag6 = default;
				bool flag5 = default;
				bool flag4 = default;
				bool flag3 = default;
				for (int i = 0; i <= num; i++)
				{
					string text = ((TableRow)GridView1.Rows[i]).Cells[2].Text;
					double num2 = Conversions.ToDouble(((TableRow)GridView1.Rows[i]).Cells[1].Text);
					switch (text)
					{
					case "ALB":
						flag18 = true;
						num14 = num2;
						break;
					case "GLB":
						flag17 = true;
						num13 = num2;
						break;
					case "BUN":
						flag16 = true;
						num12 = num2;
						break;
					case "CRT":
						flag15 = true;
						num11 = num2;
						break;
					case "CHO":
						flag14 = true;
						num10 = num2;
						break;
					case "HDL":
						flag13 = true;
						num9 = num2;
						break;
					case "LDL":
					{
						bool flag12 = true;
						double num8 = num2;
						break;
					}
					case "CA":
						flag11 = true;
						num7 = num2;
						break;
					case "P":
						flag10 = true;
						num6 = num2;
						break;
					case "K":
					{
						bool flag9 = true;
						double num5 = num2;
						break;
					}
					case "NA":
					{
						bool flag8 = true;
						double num4 = num2;
						break;
					}
					case "CL":
					{
						bool flag7 = true;
						double num3 = num2;
						break;
					}
					case "B/C":
						flag6 = true;
						break;
					case "A/G":
						flag5 = true;
						break;
					case "C/H":
						flag4 = true;
						break;
					case "C/P":
						flag3 = true;
						break;
					case "N/K":
					{
						bool flag2 = true;
						break;
					}
					case "L/H":
					{
						bool flag = true;
						break;
					}
					}
				}
				TestRefTableAdapter testRefTableAdapter = new TestRefTableAdapter();
				textref.TestRefDataTable testRefDataTable = new textref.TestRefDataTable();
				testRefTableAdapter.Fill(testRefDataTable);
				if (flag18 && flag17 && !flag5)
				{
					double num15 = roundIt(num14 / num13, 3);
					resultRefTableAdapter.InsertResults((float)num15, testRefDataTable.FindBytestAbrev("A/G").rid, "A/G", (float)testRefDataTable.FindBytestAbrev("A/G").MedLow, (float)testRefDataTable.FindBytestAbrev("A/G").MedHigh, (float)getOpt(testRefDataTable.FindBytestAbrev("A/G").MedLow, testRefDataTable.FindBytestAbrev("A/G").MedHigh), (float)getScale(testRefDataTable.FindBytestAbrev("A/G").MedLow, testRefDataTable.FindBytestAbrev("A/G").MedHigh, num15), userName, (float)testRefDataTable.FindBytestAbrev("A/G").DocLow, (float)getOpt(testRefDataTable.FindBytestAbrev("A/G").DocLow, testRefDataTable.FindBytestAbrev("A/G").DocHigh), (float)testRefDataTable.FindBytestAbrev("A/G").DocHigh, (float)getScale(testRefDataTable.FindBytestAbrev("A/G").DocLow, testRefDataTable.FindBytestAbrev("A/G").DocHigh, num15), Conversions.ToInteger(((Page)this).Session["TestId"]));
				}
				if (flag16 && flag15 && !flag6)
				{
					double num16 = roundIt(num12 / num11, 3);
					resultRefTableAdapter.InsertResults((float)num16, testRefDataTable.FindBytestAbrev("B/C").rid, "B/C", (float)testRefDataTable.FindBytestAbrev("B/C").MedLow, (float)testRefDataTable.FindBytestAbrev("B/C").MedHigh, (float)getOpt(testRefDataTable.FindBytestAbrev("B/C").MedLow, testRefDataTable.FindBytestAbrev("B/C").MedHigh), (float)getScale(testRefDataTable.FindBytestAbrev("B/C").MedLow, testRefDataTable.FindBytestAbrev("B/C").MedHigh, num16), userName, (float)testRefDataTable.FindBytestAbrev("B/C").DocLow, (float)getOpt(testRefDataTable.FindBytestAbrev("B/C").DocLow, testRefDataTable.FindBytestAbrev("B/C").DocHigh), (float)testRefDataTable.FindBytestAbrev("B/C").DocHigh, (float)getScale(testRefDataTable.FindBytestAbrev("B/C").DocLow, testRefDataTable.FindBytestAbrev("B/C").DocHigh, num16), Conversions.ToInteger(((Page)this).Session["TestId"]));
				}
				if (flag14 && flag13 && !flag4)
				{
					double num17 = roundIt(num10 / num9, 3);
					resultRefTableAdapter.InsertResults((float)num17, testRefDataTable.FindBytestAbrev("C/H").rid, "C/H", (float)testRefDataTable.FindBytestAbrev("C/H").MedLow, (float)testRefDataTable.FindBytestAbrev("C/H").MedHigh, (float)getOpt(testRefDataTable.FindBytestAbrev("C/H").MedLow, testRefDataTable.FindBytestAbrev("C/H").MedHigh), (float)getScale(testRefDataTable.FindBytestAbrev("C/H").MedLow, testRefDataTable.FindBytestAbrev("C/H").MedHigh, num17), userName, (float)testRefDataTable.FindBytestAbrev("C/H").DocLow, (float)getOpt(testRefDataTable.FindBytestAbrev("C/H").DocLow, testRefDataTable.FindBytestAbrev("C/H").DocHigh), (float)testRefDataTable.FindBytestAbrev("C/H").DocHigh, (float)getScale(testRefDataTable.FindBytestAbrev("C/H").DocLow, testRefDataTable.FindBytestAbrev("C/H").DocHigh, num17), Conversions.ToInteger(((Page)this).Session["TestId"]));
				}
				if (flag11 && flag10 && !flag3)
				{
					double num18 = roundIt(num7 / num6, 3);
					resultRefTableAdapter.InsertResults((float)num18, testRefDataTable.FindBytestAbrev("C/P").rid, "C/P", (float)testRefDataTable.FindBytestAbrev("C/P").MedLow, (float)testRefDataTable.FindBytestAbrev("C/P").MedHigh, (float)getOpt(testRefDataTable.FindBytestAbrev("C/P").MedLow, testRefDataTable.FindBytestAbrev("C/P").MedHigh), (float)getScale(testRefDataTable.FindBytestAbrev("C/P").MedLow, testRefDataTable.FindBytestAbrev("C/P").MedHigh, num18), userName, (float)testRefDataTable.FindBytestAbrev("C/P").DocLow, (float)getOpt(testRefDataTable.FindBytestAbrev("C/P").DocLow, testRefDataTable.FindBytestAbrev("C/P").DocHigh), (float)testRefDataTable.FindBytestAbrev("C/P").DocHigh, (float)getScale(testRefDataTable.FindBytestAbrev("C/P").DocLow, testRefDataTable.FindBytestAbrev("C/P").DocHigh, num18), Conversions.ToInteger(((Page)this).Session["TestId"]));
				}
				SqlDataSource1.SelectParameters[0].DefaultValue = Conversions.ToString(Conversions.ToInteger(((Page)this).Session["TestId"]));
				GridView1.DataBind();
			}
			else
			{
				((Page)this).Response.Redirect("default.aspx");
			}
		}
	}

	protected void Button3_Click(object sender, EventArgs e)
	{
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0065: Expected Obj, but got Unknown
		int try0000_dispatch = -1;
		checked
		{
			int num3 = default;
			int num = default;
			int num2 = default;
			int num5 = default;
			int num6 = default;
			int num7 = default;
			CheckBox val = default;
			while (true)
			{
				try
				{
					/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
					switch (try0000_dispatch)
					{
					default:
						ProjectData.ClearProjectError();
						num3 = 1;
						goto IL_0008;
					case 664:
						{
							num = num2;
							switch (num3)
							{
							case 1:
								break;
							default:
								goto end_IL_0000;
							}
							int num4 = unchecked(num + 1);
							num = 0;
							switch (num4)
							{
							case 1:
								break;
							case 2:
								goto IL_0008;
							case 3:
								goto IL_001c;
							case 4:
								goto IL_0036;
							case 5:
								goto IL_0065;
							case 6:
								goto IL_0070;
							case 7:
							case 8:
								goto IL_0077;
							case 9:
								goto IL_0082;
							case 10:
								goto IL_008a;
							case 11:
							case 12:
								goto IL_0090;
							case 13:
								goto IL_00b7;
							case 14:
								goto IL_00d6;
							case 15:
								goto IL_00f5;
							case 16:
								goto IL_0114;
							case 17:
								goto IL_0148;
							case 19:
								goto IL_0162;
							case 20:
								goto IL_0166;
							case 21:
								goto IL_0180;
							case 22:
								goto IL_019f;
							case 23:
								goto IL_01be;
							case 24:
								goto IL_01dd;
							case 25:
								goto end_IL_0000_2;
							default:
								goto end_IL_0000;
							case 18:
							case 26:
							case 27:
								goto end_IL_0000_3;
							}
							goto default;
						}
						IL_01dd:
						num2 = 24;
						BuyNowButton1.ItemName = ((ListControl)RadioButtonList1).SelectedItem.Text;
						break;
						IL_0008:
						num2 = 2;
						if (((ListControl)RadioButtonList1).SelectedIndex == 0)
						{
							goto IL_001c;
						}
						goto IL_0162;
						IL_001c:
						num2 = 3;
						num5 = GridView1.Rows.Count - 1;
						num6 = 0;
						goto IL_007e;
						IL_007e:
						if (num6 <= num5)
						{
							goto IL_0036;
						}
						goto IL_0082;
						IL_0082:
						num2 = 9;
						if (num7 < 1)
						{
							goto IL_008a;
						}
						goto IL_0090;
						IL_008a:
						num2 = 10;
						num7 = 1;
						goto IL_0090;
						IL_0090:
						num2 = 12;
						Labelamnt.Text = Conversions.ToString((double)num7 * Conversions.ToDouble(((ListControl)RadioButtonList1).SelectedValue));
						goto IL_00b7;
						IL_00b7:
						num2 = 13;
						Labelusr.Text = ((Page)this).User.Identity.Name;
						goto IL_00d6;
						IL_00d6:
						num2 = 14;
						BuyNowButton1.Amount = Conversion.Val(Labelamnt.Text);
						goto IL_00f5;
						IL_00f5:
						num2 = 15;
						BuyNowButton1.Option1Values = ((Page)this).User.Identity.Name;
						goto IL_0114;
						IL_0114:
						num2 = 16;
						BuyNowButton1.ItemName = ((ListControl)RadioButtonList1).SelectedItem.Text + ". For " + Conversions.ToString(num7) + " Item(s)";
						goto IL_0148;
						IL_0148:
						num2 = 17;
						MultiView1.SetActiveView(View4);
						goto end_IL_0000_3;
						IL_0036:
						num2 = 4;
						val = (CheckBox)((Control)((TableRow)GridView1.Rows[num6]).Cells[0]).FindControl("CheckBox1");
						goto IL_0065;
						IL_0065:
						num2 = 5;
						if (val.Checked)
						{
							goto IL_0070;
						}
						goto IL_0077;
						IL_0070:
						num2 = 6;
						num7++;
						goto IL_0077;
						IL_0077:
						num2 = 8;
						num6++;
						goto IL_007e;
						IL_0162:
						num2 = 19;
						goto IL_0166;
						IL_0166:
						num2 = 20;
						Labelamnt.Text = ((ListControl)RadioButtonList1).SelectedValue;
						goto IL_0180;
						IL_0180:
						num2 = 21;
						Labelusr.Text = ((Page)this).User.Identity.Name;
						goto IL_019f;
						IL_019f:
						num2 = 22;
						BuyNowButton1.Amount = Conversion.Val(Labelamnt.Text);
						goto IL_01be;
						IL_01be:
						num2 = 23;
						BuyNowButton1.Option1Values = ((Page)this).User.Identity.Name;
						goto IL_01dd;
						end_IL_0000_2:
						break;
					}
					num2 = 25;
					MultiView1.SetActiveView(View4);
					break;
					end_IL_0000:;
				}
				catch (Exception ex) when ((num3 != 0) & (num == 0))
				{
					ProjectData.SetProjectError(ex);
					try0000_dispatch = 664;
					continue;
				}
				throw ProjectData.CreateProjectError(-2146828237);
				continue;
				end_IL_0000_3:
				break;
			}
			if (num != 0)
			{
				ProjectData.ClearProjectError();
			}
		}
	}

	protected void RadioButtonList2_SelectedIndexChanged(object sender, EventArgs e)
	{
		switch (((ListControl)RadioButtonList2).SelectedIndex)
		{
		case 0:
			SqlDataSource1.SelectCommand = "SELECT ResultRef.Result, ResultRef.rid, ResultRef.TestAbrev, ResultRef.MedLow, ResultRef.MedHigh, ResultRef.Medopt, ResultRef.MedScale, ResultRef.UserName, ResultRef.DocLow, ResultRef.DocHigh, ResultRef.DocOpt, ResultRef.DocScale, ResultRef.Testid, TestRef.Category FROM ResultRef LEFT OUTER JOIN TestRef ON ResultRef.TestAbrev = TestRef.testAbrev WHERE (ResultRef.Testid = @Testid) ORDER BY ABS(ResultRef.DocScale) DESC";
			break;
		case 1:
			SqlDataSource1.SelectCommand = "SELECT ResultRef.Result, ResultRef.rid, ResultRef.TestAbrev, ResultRef.MedLow, ResultRef.MedHigh, ResultRef.Medopt, ResultRef.MedScale, ResultRef.UserName, ResultRef.DocLow, ResultRef.DocHigh, ResultRef.DocOpt, ResultRef.DocScale, ResultRef.Testid, TestRef.Category FROM ResultRef LEFT OUTER JOIN TestRef ON ResultRef.TestAbrev = TestRef.testAbrev WHERE (ResultRef.Testid = @Testid) ORDER BY ABS(ResultRef.MedScale) DESC";
			break;
		case 2:
			SqlDataSource1.SelectCommand = "SELECT ResultRef.Result, ResultRef.rid, ResultRef.TestAbrev, ResultRef.MedLow, ResultRef.MedHigh, ResultRef.Medopt, ResultRef.MedScale, ResultRef.UserName, ResultRef.DocLow, ResultRef.DocHigh, ResultRef.DocOpt, ResultRef.DocScale, ResultRef.Testid, TestRef.Category FROM ResultRef LEFT OUTER JOIN TestRef ON ResultRef.TestAbrev = TestRef.testAbrev WHERE (ResultRef.Testid = @Testid) ORDER BY  TestRef.Category ,ABS(ResultRef.DocScale) DESC";
			break;
		case 3:
			SqlDataSource1.SelectCommand = "SELECT ResultRef.Result, ResultRef.rid, ResultRef.TestAbrev, ResultRef.MedLow, ResultRef.MedHigh, ResultRef.Medopt, ResultRef.MedScale, ResultRef.UserName, ResultRef.DocLow, ResultRef.DocHigh, ResultRef.DocOpt, ResultRef.DocScale, ResultRef.Testid, TestRef.Category FROM ResultRef LEFT OUTER JOIN TestRef ON ResultRef.TestAbrev = TestRef.testAbrev WHERE (ResultRef.Testid = @Testid) ORDER BY  TestRef.Category ,ABS(ResultRef.MedScale) DESC";
			break;
		case 4:
			SqlDataSource1.SelectCommand = "SELECT ResultRef.Result, ResultRef.rid, ResultRef.TestAbrev, ResultRef.MedLow, ResultRef.MedHigh, ResultRef.Medopt, ResultRef.MedScale, ResultRef.UserName, ResultRef.DocLow, ResultRef.DocHigh, ResultRef.DocOpt, ResultRef.DocScale, ResultRef.Testid, TestRef.Category FROM ResultRef LEFT OUTER JOIN TestRef ON ResultRef.TestAbrev = TestRef.testAbrev WHERE (ResultRef.Testid = @Testid) AND ResultRef.DocScale > 69 ORDER BY  TestRef.Category ";
			break;
		case 5:
			SqlDataSource1.SelectCommand = "SELECT ResultRef.Result, ResultRef.rid, ResultRef.TestAbrev, ResultRef.MedLow, ResultRef.MedHigh, ResultRef.Medopt, ResultRef.MedScale, ResultRef.UserName, ResultRef.DocLow, ResultRef.DocHigh, ResultRef.DocOpt, ResultRef.DocScale, ResultRef.Testid, TestRef.Category FROM ResultRef LEFT OUTER JOIN TestRef ON ResultRef.TestAbrev = TestRef.testAbrev WHERE (ResultRef.Testid = @Testid) AND ResultRef.MedScale > 69 ORDER BY  TestRef.Category ";
			break;
		}
		GridView1.DataBind();
	}

	protected void Button4_Click(object sender, EventArgs e)
	{
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Expected Obj, but got Unknown
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Expected Obj, but got Unknown
		ResultRefTableAdapter resultRefTableAdapter = new ResultRefTableAdapter();
		checked
		{
			int num = GridView1.Rows.Count - 1;
			for (int i = 0; i <= num; i++)
			{
				CheckBox val = new CheckBox();
				val = (CheckBox)((Control)((TableRow)GridView1.Rows[i]).Cells[0]).FindControl("CBoks1");
				int num2 = Conversions.ToInteger(GridView1.DataKeys[i].Value);
				string text = ((TableRow)GridView1.Rows[i]).Cells[2].Text;
				if (val.Checked)
				{
					if (Operators.ConditionalCompareObjectEqual(((Page)this).Session["TestId"], num2, TextCompare: false))
					{
						resultRefTableAdapter.DeleteQuery(text, num2);
					}
					GridView1.DataBind();
				}
			}
		}
	}

	protected void Button5_Click(object sender, EventArgs e)
	{
		Button4_Click(RuntimeHelpers.GetObjectValue(sender), e);
	}

	protected void btnAddtest_Click(object sender, EventArgs e)
	{
		((Page)this).Response.Redirect("OneByOne.aspx");
	}

	protected void btnAddtest1_Click(object sender, EventArgs e)
	{
		((Page)this).Response.Redirect("OneByOne.aspx");
	}

	protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
	{
		Sqlref.SelectParameters[0].DefaultValue = ((TableRow)GridView1.SelectedRow).Cells[2].Text;
		GridView5.DataBind();
		((Control)Panel1).Visible = true;
	}

	protected void LinkButton1_Click(object sender, EventArgs e)
	{
		((Control)Panel1).Visible = false;
	}

	public void RecalculateRatios()
	{
		ratioRefTableAdapter ratioRefTableAdapter2 = new ratioRefTableAdapter();
		Labstuff.ratioRefDataTable ratioRefDataTable = new Labstuff.ratioRefDataTable();
		ratioRefTableAdapter2.Fill(ratioRefDataTable);
		string userName = ((!Conversions.ToBoolean(Operators.AndObject(Operators.CompareObjectNotEqual(((Page)this).Session["userid"], "", TextCompare: false), Operators.CompareString(((Page)this).Request["mode"], "admin", TextCompare: false) == 0))) ? ((Page)this).User.Identity.Name : Conversions.ToString(((Page)this).Session["userid"]));
		if (((Page)this).Session["TestId"] == null)
		{
			return;
		}
		int num = Conversions.ToInteger(((Page)this).Session["TestId"]);
		ResultRefTableAdapter resultRefTableAdapter = new ResultRefTableAdapter();
		TestRefTableAdapter testRefTableAdapter = new TestRefTableAdapter();
		textref.TestRefDataTable testRefDataTable = new textref.TestRefDataTable();
		testRefTableAdapter.Fill(testRefDataTable);
		checked
		{
			int num2 = ratioRefDataTable.Count - 1;
			for (int i = 0; i <= num2; i++)
			{
				string testAbrev = Conversions.ToString(ratioRefDataTable.Rows[i]["ratioAbrev"]);
				string testAbrev2 = Conversions.ToString(ratioRefDataTable.Rows[i]["testAbrev1"]);
				string testAbrev3 = Conversions.ToString(ratioRefDataTable.Rows[i]["testAbrev2"]);
				double num3 = Conversions.ToDouble(resultRefTableAdapter.fillByTestId_TestAbrev(num, testAbrev2).Rows[0]["Result"]);
				double num4 = Conversions.ToDouble(resultRefTableAdapter.fillByTestId_TestAbrev(num, testAbrev3).Rows[0]["Result"]);
				double num5 = roundIt(num3 / num4, 3);
				if (!(!resultRefTableAdapter.ifTestAdded(testAbrev2, num).HasValue | !resultRefTableAdapter.ifTestAdded(testAbrev3, num).HasValue))
				{
					if (resultRefTableAdapter.ifTestAdded(testAbrev, num).HasValue)
					{
						resultRefTableAdapter.update4Ratios(num5, testRefDataTable.FindBytestAbrev(testAbrev).MedLow, testRefDataTable.FindBytestAbrev(testAbrev).MedHigh, getOpt(testRefDataTable.FindBytestAbrev(testAbrev).MedLow, testRefDataTable.FindBytestAbrev(testAbrev).MedHigh), getScale(testRefDataTable.FindBytestAbrev(testAbrev).MedLow, testRefDataTable.FindBytestAbrev(testAbrev).MedHigh, num5), userName, testRefDataTable.FindBytestAbrev(testAbrev).DocLow, getOpt(testRefDataTable.FindBytestAbrev(testAbrev).DocLow, testRefDataTable.FindBytestAbrev(testAbrev).DocHigh), testRefDataTable.FindBytestAbrev(testAbrev).DocHigh, getScale(testRefDataTable.FindBytestAbrev(testAbrev).DocLow, testRefDataTable.FindBytestAbrev(testAbrev).DocHigh, num5), testAbrev, Conversions.ToInteger(((Page)this).Session["TestId"]));
					}
					else
					{
						resultRefTableAdapter.InsertResults((float)num5, testRefDataTable.FindBytestAbrev(testAbrev).rid, testAbrev, (float)testRefDataTable.FindBytestAbrev(testAbrev).MedLow, (float)testRefDataTable.FindBytestAbrev(testAbrev).MedHigh, (float)getOpt(testRefDataTable.FindBytestAbrev(testAbrev).MedLow, testRefDataTable.FindBytestAbrev(testAbrev).MedHigh), (float)getScale(testRefDataTable.FindBytestAbrev(testAbrev).MedLow, testRefDataTable.FindBytestAbrev(testAbrev).MedHigh, num5), userName, (float)testRefDataTable.FindBytestAbrev(testAbrev).DocLow, (float)getOpt(testRefDataTable.FindBytestAbrev(testAbrev).DocLow, testRefDataTable.FindBytestAbrev(testAbrev).DocHigh), (float)testRefDataTable.FindBytestAbrev(testAbrev).DocHigh, (float)getScale(testRefDataTable.FindBytestAbrev(testAbrev).DocLow, testRefDataTable.FindBytestAbrev(testAbrev).DocHigh, num5), Conversions.ToInteger(((Page)this).Session["TestId"]));
					}
				}
			}
		}
	}

	protected void Button6_Click(object sender, EventArgs e)
	{
		RecalculateRatios();
	}
}
