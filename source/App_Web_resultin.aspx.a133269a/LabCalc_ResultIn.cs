using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.Profile;
using System.Web.SessionState;
using System.Web.UI;
using System.Web.UI.WebControls;
using AjaxControlToolkit;
using LabstuffTableAdapters;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using iTextSharp.text.pdf;
using iTextSharp.text.pdf.parser;
using tempdataTableAdapters;
using textrefTableAdapters;

public class LabCalc_ResultIn : Page, IRequiresSessionState
{
	[AccessedThroughProperty("GridView1")]
	private GridView _GridView1;

	[AccessedThroughProperty("SqlDataSource1")]
	private SqlDataSource _SqlDataSource1;

	[AccessedThroughProperty("Button1")]
	private Button _Button1;

	[AccessedThroughProperty("ConfirmButtonExtender1")]
	private ConfirmButtonExtender _ConfirmButtonExtender1;

	private tempdataTableAdapters.txtimpTableAdapter txtda;

	private tempdata.txtimpDataTable txtds;

	private tempdata.impdataDataTable dataimp;

	protected virtual GridView GridView1
	{
		get
		{
			return _GridView1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected Obj, but got Unknown
			GridViewRowEventHandler val = GridView1_RowDataBound;
			EventHandler eventHandler = GridView1_SelectedIndexChanged;
			if (_GridView1 != null)
			{
				_GridView1.RowDataBound -= val;
				_GridView1.SelectedIndexChanged -= eventHandler;
			}
			_GridView1 = value;
			if (_GridView1 != null)
			{
				_GridView1.RowDataBound += val;
				_GridView1.SelectedIndexChanged += eventHandler;
			}
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
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected Obj, but got Unknown
			SqlDataSourceSelectingEventHandler val = SqlDataSource1_Selecting;
			if (_SqlDataSource1 != null)
			{
				_SqlDataSource1.Selecting -= val;
			}
			_SqlDataSource1 = value;
			if (_SqlDataSource1 != null)
			{
				_SqlDataSource1.Selecting += val;
			}
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

	protected virtual ConfirmButtonExtender ConfirmButtonExtender1
	{
		get
		{
			return _ConfirmButtonExtender1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ConfirmButtonExtender1 = value;
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

	public LabCalc_ResultIn()
	{
		((Control)this).Load += Page_Load;
		txtda = new tempdataTableAdapters.txtimpTableAdapter();
		txtds = new tempdata.txtimpDataTable();
		dataimp = new tempdata.impdataDataTable();
	}

	protected void Button1_Click(object sender, EventArgs e)
	{
		calcDataV1();
	}

	public void calcDataV2()
	{
		//IL_00ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d5: Expected Obj, but got Unknown
		//IL_0128: Unknown result type (might be due to invalid IL or missing references)
		//IL_012f: Expected Obj, but got Unknown
		//IL_0166: Unknown result type (might be due to invalid IL or missing references)
		//IL_016d: Expected Obj, but got Unknown
		//IL_01a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ab: Expected Obj, but got Unknown
		//IL_01e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e9: Expected Obj, but got Unknown
		//IL_03e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_03eb: Expected Obj, but got Unknown
		//IL_0422: Unknown result type (might be due to invalid IL or missing references)
		//IL_0429: Expected Obj, but got Unknown
		string userName = ((!Conversions.ToBoolean(Operators.AndObject(Operators.CompareObjectNotEqual(((Page)this).Session["userid"], "", TextCompare: false), Operators.CompareString(((Page)this).Request["mode"], "admin", TextCompare: false) == 0))) ? ((Page)this).User.Identity.Name : Conversions.ToString(((Page)this).Session["userid"]));
		ResultRefTableAdapter resultRefTableAdapter = new ResultRefTableAdapter();
		Dictionary<string, double> dictionary = new Dictionary<string, double>();
		string[] array = new string[0];
		int count = GridView1.Rows.Count;
		checked
		{
			bool flag18 = default;
			double num16 = default;
			bool flag17 = default;
			double num15 = default;
			bool flag16 = default;
			double num14 = default;
			bool flag15 = default;
			double num13 = default;
			bool flag14 = default;
			double num12 = default;
			bool flag13 = default;
			double num11 = default;
			bool flag11 = default;
			double num9 = default;
			bool flag10 = default;
			double num8 = default;
			bool flag6 = default;
			bool flag5 = default;
			bool flag4 = default;
			bool flag3 = default;
			int? num19 = default;
			for (int i = 1; i <= count; i++)
			{
				TextBox val = (TextBox)((Control)((TableRow)GridView1.Rows[i - 1]).Cells[7]).FindControl("Resulttxt");
				if (Operators.CompareString(val.Text, "", TextCompare: false) != 0)
				{
					double num = Conversions.ToDouble(val.Text);
					TextBox val2 = (TextBox)((Control)((TableRow)GridView1.Rows[i - 1]).Cells[5]).FindControl("TextBox1");
					double num2 = Conversions.ToDouble(val2.Text);
					TextBox val3 = (TextBox)((Control)((TableRow)GridView1.Rows[i - 1]).Cells[6]).FindControl("TextBox2");
					double num3 = Conversions.ToDouble(val3.Text);
					Label val4 = (Label)((Control)((TableRow)GridView1.Rows[i - 1]).Cells[0]).FindControl("Label1");
					int num4 = Conversions.ToInteger(val4.Text);
					Label val5 = (Label)((Control)((TableRow)GridView1.Rows[i - 1]).Cells[1]).FindControl("tstAbrev");
					string text = val5.Text;
					switch (text)
					{
					case "ALB":
						flag18 = true;
						num16 = num;
						break;
					case "GLB":
						flag17 = true;
						num15 = num;
						break;
					case "BUN":
						flag16 = true;
						num14 = num;
						break;
					case "CRT":
						flag15 = true;
						num13 = num;
						break;
					case "CHO":
						flag14 = true;
						num12 = num;
						break;
					case "HDL":
						flag13 = true;
						num11 = num;
						break;
					case "LDL":
					{
						bool flag12 = true;
						double num10 = num;
						break;
					}
					case "CA":
						flag11 = true;
						num9 = num;
						break;
					case "P":
						flag10 = true;
						num8 = num;
						break;
					case "K":
					{
						bool flag9 = true;
						double num7 = num;
						break;
					}
					case "NA":
					{
						bool flag8 = true;
						double num6 = num;
						break;
					}
					case "CL":
					{
						bool flag7 = true;
						double num5 = num;
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
					Label val6 = (Label)((Control)((TableRow)GridView1.Rows[i - 1]).Cells[3]).FindControl("dl1");
					double num17 = Conversions.ToDouble(val6.Text);
					Label val7 = (Label)((Control)((TableRow)GridView1.Rows[i - 1]).Cells[4]).FindControl("dh1");
					double num18 = Conversions.ToDouble(val7.Text);
					try
					{
						float? result = (float)num;
						int? rid = num4;
						float? medLow = (float)num2;
						float? medHigh = (float)num3;
						float? medopt = (float)getOpt(num2, num3);
						float? medScale = (float)getScale(num2, num3, num);
						float? docLow = (float)num17;
						float? docOpt = (float)getOpt(num17, num18);
						float? docHigh = (float)num18;
						float? docScale = (float)getScale(num17, num18, num);
						object obj = ((Control)this).ViewState["TestId"];
						resultRefTableAdapter.InsertResults(result, rid, text, medLow, medHigh, medopt, medScale, userName, docLow, docOpt, docHigh, docScale, (obj != null) ? ((int?)obj) : num19);
					}
					catch (Exception ex)
					{
						ProjectData.SetProjectError(ex);
						Exception ex2 = ex;
						resultRefTableAdapter.UpdateQuery(num, num4, num2, num3, getOpt(num2, num3), getScale(num2, num3, num), num17, getOpt(num17, num18), num18, getScale(num17, num18, num), ((Page)this).User.Identity.Name, Conversions.ToInteger(((Control)this).ViewState["TestId"]), text);
						ProjectData.ClearProjectError();
					}
				}
			}
			TestRefTableAdapter testRefTableAdapter = new TestRefTableAdapter();
			textref.TestRefDataTable testRefDataTable = new textref.TestRefDataTable();
			testRefTableAdapter.Fill(testRefDataTable);
			if (flag18 && flag17 && !flag5)
			{
				double num20 = roundIt(num16 / num15, 3);
				float? result2 = (float)num20;
				int? rid2 = testRefDataTable.FindBytestAbrev("A/G").rid;
				float? medLow2 = (float)testRefDataTable.FindBytestAbrev("A/G").MedLow;
				float? medHigh2 = (float)testRefDataTable.FindBytestAbrev("A/G").MedHigh;
				float? medopt2 = (float)getOpt(testRefDataTable.FindBytestAbrev("A/G").MedLow, testRefDataTable.FindBytestAbrev("A/G").MedHigh);
				float? medScale2 = (float)getScale(testRefDataTable.FindBytestAbrev("A/G").MedLow, testRefDataTable.FindBytestAbrev("A/G").MedHigh, num20);
				string? name = ((Page)this).User.Identity.Name;
				float? docLow2 = (float)testRefDataTable.FindBytestAbrev("A/G").DocLow;
				float? docOpt2 = (float)getOpt(testRefDataTable.FindBytestAbrev("A/G").DocLow, testRefDataTable.FindBytestAbrev("A/G").DocHigh);
				float? docHigh2 = (float)testRefDataTable.FindBytestAbrev("A/G").DocHigh;
				float? docScale2 = (float)getScale(testRefDataTable.FindBytestAbrev("A/G").DocLow, testRefDataTable.FindBytestAbrev("A/G").DocHigh, num20);
				object obj2 = ((Control)this).ViewState["TestId"];
				resultRefTableAdapter.InsertResults(result2, rid2, "A/G", medLow2, medHigh2, medopt2, medScale2, name, docLow2, docOpt2, docHigh2, docScale2, (obj2 != null) ? ((int?)obj2) : num19);
			}
			if (flag16 && flag15 && !flag6)
			{
				double num21 = roundIt(num14 / num13, 3);
				float? result3 = (float)num21;
				int? rid3 = testRefDataTable.FindBytestAbrev("B/C").rid;
				float? medLow3 = (float)testRefDataTable.FindBytestAbrev("B/C").MedLow;
				float? medHigh3 = (float)testRefDataTable.FindBytestAbrev("B/C").MedHigh;
				float? medopt3 = (float)getOpt(testRefDataTable.FindBytestAbrev("B/C").MedLow, testRefDataTable.FindBytestAbrev("B/C").MedHigh);
				float? medScale3 = (float)getScale(testRefDataTable.FindBytestAbrev("B/C").MedLow, testRefDataTable.FindBytestAbrev("B/C").MedHigh, num21);
				string? name2 = ((Page)this).User.Identity.Name;
				float? docLow3 = (float)testRefDataTable.FindBytestAbrev("B/C").DocLow;
				float? docOpt3 = (float)getOpt(testRefDataTable.FindBytestAbrev("B/C").DocLow, testRefDataTable.FindBytestAbrev("B/C").DocHigh);
				float? docHigh3 = (float)testRefDataTable.FindBytestAbrev("B/C").DocHigh;
				float? docScale3 = (float)getScale(testRefDataTable.FindBytestAbrev("B/C").DocLow, testRefDataTable.FindBytestAbrev("B/C").DocHigh, num21);
				object obj3 = ((Control)this).ViewState["TestId"];
				resultRefTableAdapter.InsertResults(result3, rid3, "B/C", medLow3, medHigh3, medopt3, medScale3, name2, docLow3, docOpt3, docHigh3, docScale3, (obj3 != null) ? ((int?)obj3) : num19);
			}
			if (flag14 && flag13 && !flag4)
			{
				double num22 = roundIt(num12 / num11, 3);
				float? result4 = (float)num22;
				int? rid4 = testRefDataTable.FindBytestAbrev("C/H").rid;
				float? medLow4 = (float)testRefDataTable.FindBytestAbrev("C/H").MedLow;
				float? medHigh4 = (float)testRefDataTable.FindBytestAbrev("C/H").MedHigh;
				float? medopt4 = (float)getOpt(testRefDataTable.FindBytestAbrev("C/H").MedLow, testRefDataTable.FindBytestAbrev("C/H").MedHigh);
				float? medScale4 = (float)getScale(testRefDataTable.FindBytestAbrev("C/H").MedLow, testRefDataTable.FindBytestAbrev("C/H").MedHigh, num22);
				string? name3 = ((Page)this).User.Identity.Name;
				float? docLow4 = (float)testRefDataTable.FindBytestAbrev("C/H").DocLow;
				float? docOpt4 = (float)getOpt(testRefDataTable.FindBytestAbrev("C/H").DocLow, testRefDataTable.FindBytestAbrev("C/H").DocHigh);
				float? docHigh4 = (float)testRefDataTable.FindBytestAbrev("C/H").DocHigh;
				float? docScale4 = (float)getScale(testRefDataTable.FindBytestAbrev("C/H").DocLow, testRefDataTable.FindBytestAbrev("C/H").DocHigh, num22);
				object obj4 = ((Control)this).ViewState["TestId"];
				resultRefTableAdapter.InsertResults(result4, rid4, "C/H", medLow4, medHigh4, medopt4, medScale4, name3, docLow4, docOpt4, docHigh4, docScale4, (obj4 != null) ? ((int?)obj4) : num19);
			}
			if (flag11 && flag10 && !flag3)
			{
				double num23 = roundIt(num9 / num8, 3);
				float? result5 = (float)num23;
				int? rid5 = testRefDataTable.FindBytestAbrev("C/P").rid;
				float? medLow5 = (float)testRefDataTable.FindBytestAbrev("C/P").MedLow;
				float? medHigh5 = (float)testRefDataTable.FindBytestAbrev("C/P").MedHigh;
				float? medopt5 = (float)getOpt(testRefDataTable.FindBytestAbrev("C/P").MedLow, testRefDataTable.FindBytestAbrev("C/P").MedHigh);
				float? medScale5 = (float)getScale(testRefDataTable.FindBytestAbrev("C/P").MedLow, testRefDataTable.FindBytestAbrev("C/P").MedHigh, num23);
				string? name4 = ((Page)this).User.Identity.Name;
				float? docLow5 = (float)testRefDataTable.FindBytestAbrev("C/P").DocLow;
				float? docOpt5 = (float)getOpt(testRefDataTable.FindBytestAbrev("C/P").DocLow, testRefDataTable.FindBytestAbrev("C/P").DocHigh);
				float? docHigh5 = (float)testRefDataTable.FindBytestAbrev("C/P").DocHigh;
				float? docScale5 = (float)getScale(testRefDataTable.FindBytestAbrev("C/P").DocLow, testRefDataTable.FindBytestAbrev("C/P").DocHigh, num23);
				object obj5 = ((Control)this).ViewState["TestId"];
				resultRefTableAdapter.InsertResults(result5, rid5, "C/P", medLow5, medHigh5, medopt5, medScale5, name4, docLow5, docOpt5, docHigh5, docScale5, (obj5 != null) ? ((int?)obj5) : num19);
			}
			((Page)this).Session.Add("TestId", RuntimeHelpers.GetObjectValue(((Control)this).ViewState["TestId"]));
			((Page)this).Response.Redirect("ResultView.aspx");
		}
	}

	private void calcDataV1()
	{
		//IL_00bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c6: Expected Obj, but got Unknown
		//IL_0119: Unknown result type (might be due to invalid IL or missing references)
		//IL_0120: Expected Obj, but got Unknown
		//IL_0157: Unknown result type (might be due to invalid IL or missing references)
		//IL_015e: Expected Obj, but got Unknown
		//IL_0195: Unknown result type (might be due to invalid IL or missing references)
		//IL_019c: Expected Obj, but got Unknown
		//IL_01d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01da: Expected Obj, but got Unknown
		//IL_03d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_03dc: Expected Obj, but got Unknown
		//IL_0413: Unknown result type (might be due to invalid IL or missing references)
		//IL_041a: Expected Obj, but got Unknown
		string userName = ((!Conversions.ToBoolean(Operators.AndObject(Operators.CompareObjectNotEqual(((Page)this).Session["userid"], "", TextCompare: false), Operators.CompareString(((Page)this).Request["mode"], "admin", TextCompare: false) == 0))) ? ((Page)this).User.Identity.Name : Conversions.ToString(((Page)this).Session["userid"]));
		ResultRefTableAdapter resultRefTableAdapter = new ResultRefTableAdapter();
		int count = GridView1.Rows.Count;
		checked
		{
			bool flag18 = default;
			double num16 = default;
			bool flag17 = default;
			double num15 = default;
			bool flag16 = default;
			double num14 = default;
			bool flag15 = default;
			double num13 = default;
			bool flag14 = default;
			double num12 = default;
			bool flag13 = default;
			double num11 = default;
			bool flag11 = default;
			double num9 = default;
			bool flag10 = default;
			double num8 = default;
			bool flag6 = default;
			bool flag5 = default;
			bool flag4 = default;
			bool flag3 = default;
			int? num19 = default;
			for (int i = 1; i <= count; i++)
			{
				TextBox val = (TextBox)((Control)((TableRow)GridView1.Rows[i - 1]).Cells[7]).FindControl("Resulttxt");
				if (Operators.CompareString(val.Text, "", TextCompare: false) != 0)
				{
					double num = Conversions.ToDouble(val.Text);
					TextBox val2 = (TextBox)((Control)((TableRow)GridView1.Rows[i - 1]).Cells[5]).FindControl("TextBox1");
					double num2 = Conversions.ToDouble(val2.Text);
					TextBox val3 = (TextBox)((Control)((TableRow)GridView1.Rows[i - 1]).Cells[6]).FindControl("TextBox2");
					double num3 = Conversions.ToDouble(val3.Text);
					Label val4 = (Label)((Control)((TableRow)GridView1.Rows[i - 1]).Cells[0]).FindControl("Label1");
					int num4 = Conversions.ToInteger(val4.Text);
					Label val5 = (Label)((Control)((TableRow)GridView1.Rows[i - 1]).Cells[1]).FindControl("tstAbrev");
					string text = val5.Text;
					switch (text)
					{
					case "ALB":
						flag18 = true;
						num16 = num;
						break;
					case "GLB":
						flag17 = true;
						num15 = num;
						break;
					case "BUN":
						flag16 = true;
						num14 = num;
						break;
					case "CRT":
						flag15 = true;
						num13 = num;
						break;
					case "CHO":
						flag14 = true;
						num12 = num;
						break;
					case "HDL":
						flag13 = true;
						num11 = num;
						break;
					case "LDL":
					{
						bool flag12 = true;
						double num10 = num;
						break;
					}
					case "CA":
						flag11 = true;
						num9 = num;
						break;
					case "P":
						flag10 = true;
						num8 = num;
						break;
					case "K":
					{
						bool flag9 = true;
						double num7 = num;
						break;
					}
					case "NA":
					{
						bool flag8 = true;
						double num6 = num;
						break;
					}
					case "CL":
					{
						bool flag7 = true;
						double num5 = num;
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
					Label val6 = (Label)((Control)((TableRow)GridView1.Rows[i - 1]).Cells[3]).FindControl("dl1");
					double num17 = Conversions.ToDouble(val6.Text);
					Label val7 = (Label)((Control)((TableRow)GridView1.Rows[i - 1]).Cells[4]).FindControl("dh1");
					double num18 = Conversions.ToDouble(val7.Text);
					try
					{
						float? result = (float)roundIt(num, 3);
						int? rid = num4;
						float? medLow = (float)num2;
						float? medHigh = (float)num3;
						float? medopt = (float)getOpt(num2, num3);
						float? medScale = (float)getScale(num2, num3, num);
						float? docLow = (float)num17;
						float? docOpt = (float)getOpt(num17, num18);
						float? docHigh = (float)num18;
						float? docScale = (float)getScale(num17, num18, num);
						object obj = ((Control)this).ViewState["TestId"];
						resultRefTableAdapter.InsertResults(result, rid, text, medLow, medHigh, medopt, medScale, userName, docLow, docOpt, docHigh, docScale, (obj != null) ? ((int?)obj) : num19);
					}
					catch (Exception ex)
					{
						ProjectData.SetProjectError(ex);
						Exception ex2 = ex;
						resultRefTableAdapter.UpdateQuery(roundIt(num, 3), num4, num2, num3, getOpt(num2, num3), getScale(num2, num3, num), num17, getOpt(num17, num18), num18, getScale(num17, num18, num), ((Page)this).User.Identity.Name, Conversions.ToInteger(((Control)this).ViewState["TestId"]), text);
						ProjectData.ClearProjectError();
					}
				}
			}
			TestRefTableAdapter testRefTableAdapter = new TestRefTableAdapter();
			textref.TestRefDataTable testRefDataTable = new textref.TestRefDataTable();
			testRefTableAdapter.Fill(testRefDataTable);
			if (flag18 && flag17 && !flag5)
			{
				double num20 = roundIt(num16 / num15, 3);
				float? result2 = (float)num20;
				int? rid2 = testRefDataTable.FindBytestAbrev("A/G").rid;
				float? medLow2 = (float)testRefDataTable.FindBytestAbrev("A/G").MedLow;
				float? medHigh2 = (float)testRefDataTable.FindBytestAbrev("A/G").MedHigh;
				float? medopt2 = (float)getOpt(testRefDataTable.FindBytestAbrev("A/G").MedLow, testRefDataTable.FindBytestAbrev("A/G").MedHigh);
				float? medScale2 = (float)getScale(testRefDataTable.FindBytestAbrev("A/G").MedLow, testRefDataTable.FindBytestAbrev("A/G").MedHigh, num20);
				string? name = ((Page)this).User.Identity.Name;
				float? docLow2 = (float)testRefDataTable.FindBytestAbrev("A/G").DocLow;
				float? docOpt2 = (float)getOpt(testRefDataTable.FindBytestAbrev("A/G").DocLow, testRefDataTable.FindBytestAbrev("A/G").DocHigh);
				float? docHigh2 = (float)testRefDataTable.FindBytestAbrev("A/G").DocHigh;
				float? docScale2 = (float)getScale(testRefDataTable.FindBytestAbrev("A/G").DocLow, testRefDataTable.FindBytestAbrev("A/G").DocHigh, num20);
				object obj2 = ((Control)this).ViewState["TestId"];
				resultRefTableAdapter.InsertResults(result2, rid2, "A/G", medLow2, medHigh2, medopt2, medScale2, name, docLow2, docOpt2, docHigh2, docScale2, (obj2 != null) ? ((int?)obj2) : num19);
			}
			if (flag16 && flag15 && !flag6)
			{
				double num21 = roundIt(num14 / num13, 3);
				float? result3 = (float)num21;
				int? rid3 = testRefDataTable.FindBytestAbrev("B/C").rid;
				float? medLow3 = (float)testRefDataTable.FindBytestAbrev("B/C").MedLow;
				float? medHigh3 = (float)testRefDataTable.FindBytestAbrev("B/C").MedHigh;
				float? medopt3 = (float)getOpt(testRefDataTable.FindBytestAbrev("B/C").MedLow, testRefDataTable.FindBytestAbrev("B/C").MedHigh);
				float? medScale3 = (float)getScale(testRefDataTable.FindBytestAbrev("B/C").MedLow, testRefDataTable.FindBytestAbrev("B/C").MedHigh, num21);
				string? name2 = ((Page)this).User.Identity.Name;
				float? docLow3 = (float)testRefDataTable.FindBytestAbrev("B/C").DocLow;
				float? docOpt3 = (float)getOpt(testRefDataTable.FindBytestAbrev("B/C").DocLow, testRefDataTable.FindBytestAbrev("B/C").DocHigh);
				float? docHigh3 = (float)testRefDataTable.FindBytestAbrev("B/C").DocHigh;
				float? docScale3 = (float)getScale(testRefDataTable.FindBytestAbrev("B/C").DocLow, testRefDataTable.FindBytestAbrev("B/C").DocHigh, num21);
				object obj3 = ((Control)this).ViewState["TestId"];
				resultRefTableAdapter.InsertResults(result3, rid3, "B/C", medLow3, medHigh3, medopt3, medScale3, name2, docLow3, docOpt3, docHigh3, docScale3, (obj3 != null) ? ((int?)obj3) : num19);
			}
			if (flag14 && flag13 && !flag4)
			{
				double num22 = roundIt(num12 / num11, 3);
				float? result4 = (float)num22;
				int? rid4 = testRefDataTable.FindBytestAbrev("C/H").rid;
				float? medLow4 = (float)testRefDataTable.FindBytestAbrev("C/H").MedLow;
				float? medHigh4 = (float)testRefDataTable.FindBytestAbrev("C/H").MedHigh;
				float? medopt4 = (float)getOpt(testRefDataTable.FindBytestAbrev("C/H").MedLow, testRefDataTable.FindBytestAbrev("C/H").MedHigh);
				float? medScale4 = (float)getScale(testRefDataTable.FindBytestAbrev("C/H").MedLow, testRefDataTable.FindBytestAbrev("C/H").MedHigh, num22);
				string? name3 = ((Page)this).User.Identity.Name;
				float? docLow4 = (float)testRefDataTable.FindBytestAbrev("C/H").DocLow;
				float? docOpt4 = (float)getOpt(testRefDataTable.FindBytestAbrev("C/H").DocLow, testRefDataTable.FindBytestAbrev("C/H").DocHigh);
				float? docHigh4 = (float)testRefDataTable.FindBytestAbrev("C/H").DocHigh;
				float? docScale4 = (float)getScale(testRefDataTable.FindBytestAbrev("C/H").DocLow, testRefDataTable.FindBytestAbrev("C/H").DocHigh, num22);
				object obj4 = ((Control)this).ViewState["TestId"];
				resultRefTableAdapter.InsertResults(result4, rid4, "C/H", medLow4, medHigh4, medopt4, medScale4, name3, docLow4, docOpt4, docHigh4, docScale4, (obj4 != null) ? ((int?)obj4) : num19);
			}
			if (flag11 && flag10 && !flag3)
			{
				double num23 = roundIt(num9 / num8, 3);
				float? result5 = (float)num23;
				int? rid5 = testRefDataTable.FindBytestAbrev("C/P").rid;
				float? medLow5 = (float)testRefDataTable.FindBytestAbrev("C/P").MedLow;
				float? medHigh5 = (float)testRefDataTable.FindBytestAbrev("C/P").MedHigh;
				float? medopt5 = (float)getOpt(testRefDataTable.FindBytestAbrev("C/P").MedLow, testRefDataTable.FindBytestAbrev("C/P").MedHigh);
				float? medScale5 = (float)getScale(testRefDataTable.FindBytestAbrev("C/P").MedLow, testRefDataTable.FindBytestAbrev("C/P").MedHigh, num23);
				string? name4 = ((Page)this).User.Identity.Name;
				float? docLow5 = (float)testRefDataTable.FindBytestAbrev("C/P").DocLow;
				float? docOpt5 = (float)getOpt(testRefDataTable.FindBytestAbrev("C/P").DocLow, testRefDataTable.FindBytestAbrev("C/P").DocHigh);
				float? docHigh5 = (float)testRefDataTable.FindBytestAbrev("C/P").DocHigh;
				float? docScale5 = (float)getScale(testRefDataTable.FindBytestAbrev("C/P").DocLow, testRefDataTable.FindBytestAbrev("C/P").DocHigh, num23);
				object obj5 = ((Control)this).ViewState["TestId"];
				resultRefTableAdapter.InsertResults(result5, rid5, "C/P", medLow5, medHigh5, medopt5, medScale5, name4, docLow5, docOpt5, docHigh5, docScale5, (obj5 != null) ? ((int?)obj5) : num19);
			}
			((Page)this).Session.Add("TestId", RuntimeHelpers.GetObjectValue(((Control)this).ViewState["TestId"]));
			((Page)this).Response.Redirect("ResultView.aspx");
		}
	}

	private double getDif(double low, double high)
	{
		return (high - low) / 2.0;
	}

	private double getOpt(double low, double high)
	{
		return roundIt((high - low) / 2.0 + low, 3);
	}

	private double getScale(double low, double high, double result)
	{
		double num = roundIt((result - getOpt(low, high)) / getDif(low, high), 3) * 100.0;
		if (double.IsNaN(num) | double.IsInfinity(num))
		{
			return 0.0;
		}
		return roundIt(num, 3);
	}

	public string ReadPdfFile(Stream fileName)
	{
		StringBuilder stringBuilder = new StringBuilder();
		PdfReader pdfReader = new PdfReader(fileName);
		int numberOfPages = pdfReader.NumberOfPages;
		for (int i = 1; i <= numberOfPages; i = checked(i + 1))
		{
			ITextExtractionStrategy strategy = new SimpleTextExtractionStrategy();
			string textFromPage = PdfTextExtractor.GetTextFromPage(pdfReader, i, strategy);
			textFromPage = Encoding.UTF8.GetString(Encoding.Convert(Encoding.Default, Encoding.UTF8, Encoding.Default.GetBytes(textFromPage)));
			stringBuilder.Append(textFromPage);
			pdfReader.Close();
		}
		return stringBuilder.ToString();
	}

	protected void Page_Load(object sender, EventArgs e)
	{
		if (((Page)this).IsPostBack)
		{
			return;
		}
		if ((Operators.CompareString(((Page)this).Request["package"], "", TextCompare: false) != 0) & (Operators.CompareString(((Page)this).Request["package"], "Everything", TextCompare: false) != 0))
		{
			if (((Page)this).Request["package"].IndexOf("'") > -1)
			{
				return;
			}
			SqlDataSource1.SelectCommand = "SELECT        TestRef.testName, TestRef.testAbrev, TestRef.DocLow, TestRef.DocHigh, TestRef.MedLow, TestRef.MedHigh, TestRef.rid, TestRef.Defaultval      FROM            TestRef INNER JOIN packagedata ON TestRef.testAbrev = packagedata.testAbrev     WHERE        (TestRef.Sex = @sex) AND (TestRef.rid > 0) AND (packagedata.packid =" + ((Page)this).Request["package"] + ")";
		}
		LabCalc_Default labCalc_Default = default;
		HttpPostedFile upfile = default;
		int contentLength = default;
		string fileName = default;
		try
		{
			labCalc_Default = (LabCalc_Default)(object)((Page)this).Context.PreviousHandler;
			upfile = labCalc_Default.upfile;
			contentLength = labCalc_Default.upfile.ContentLength;
			fileName = labCalc_Default.upfile.FileName;
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			ProjectData.ClearProjectError();
		}
		if (((Page)this).Session["TestId"] != null)
		{
			((Control)this).ViewState.Add("TestId", RuntimeHelpers.GetObjectValue(((Page)this).Session["TestId"]));
			if (contentLength <= 0)
			{
				return;
			}
			txtda.Fill(txtds);
			FileInfo fileInfo = new FileInfo(fileName);
			if (Operators.CompareString(fileInfo.Extension, ".pdf", TextCompare: false) == 0)
			{
				string text = ReadPdfFile(labCalc_Default.upfile.InputStream);
				string[] array = text.Split(Environment.NewLine.ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
				string[] array2 = array;
				foreach (string data in array2)
				{
					process(data);
				}
			}
			else
			{
				StreamReader streamReader = new StreamReader(upfile.InputStream);
				while (streamReader.Peek() != -1)
				{
					process(streamReader.ReadLine());
				}
			}
		}
		else
		{
			((Page)this).Response.Redirect("default.aspx");
		}
	}

	private void process(string data)
	{
		int try0000_dispatch = -1;
		checked
		{
			int num2 = default;
			bool flag = default;
			int num = default;
			while (true)
			{
				try
				{
					/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
					switch (try0000_dispatch)
					{
					default:
					{
						ProjectData.ClearProjectError();
						num2 = 2;
						data = data.TrimStart(new char[0]);
						data = Strings.Replace(data, "Negative", "-1");
						Regex regex = new Regex("\\d");
						if (Operators.CompareString(Strings.Mid(data, 1, 13), "Patient Code:", TextCompare: false) != 0 && ((data.IndexOf(" ") > -1) & regex.IsMatch(data)))
						{
							if (data.IndexOf("Not Estab") > -1)
							{
								flag = true;
							}
							data = data.TrimStart(new char[0]);
							if (Operators.CompareString(Strings.Mid(data, 1, 2), "**", TextCompare: false) == 0)
							{
								break;
							}
							Regex regex2 = new Regex("\\d");
							Regex regex3 = new Regex("\\d");
							Regex regex4 = new Regex("\\s");
							Regex regex5 = new Regex("\\s");
							Regex regex6 = new Regex("\\w");
							string text = Strings.Mid(data, 1, regex2.Matches(data)[0].Index).Trim();
							string text2 = Strings.Mid(data, regex2.Matches(data)[0].Index + 1).TrimStart(new char[0]);
							string text3 = Strings.Mid(text2, 1, regex4.Matches(text2)[0].Index + 1).TrimStart(new char[0]);
							text3.Replace(">", "");
							text3.Replace("<", "");
							double value = Conversion.Val(text3);
							string text4 = Strings.Mid(text2, regex4.Matches(text2)[0].Index + 1).TrimStart(new char[0]);
							int i = 0;
							if (!flag)
							{
								if (text4.IndexOf("-") > -1)
								{
									string[] array = Regex.Split(text4, "\\s");
									int num3 = array.Length - 1;
									for (i = 0; i <= num3; i++)
									{
										if (array[i].IndexOf("-") == 0)
										{
											dataimp.AddimpdataRow(text, value, 1.0, 1.0);
										}
										else if (array[i].IndexOf("-") > 0)
										{
											string[] array2 = Regex.Split(array[i], "-");
											double min = Conversion.Val(array2[0]);
											double max = Conversion.Val(array2[1]);
											dataimp.AddimpdataRow(text, value, min, max);
										}
									}
								}
								else
								{
									dataimp.AddimpdataRow(text, value, 1.0, 1.0);
								}
							}
							else
							{
								for (; regex6.Matches(text4)[0].Index > regex5.Matches(text4)[i].Index; i++)
								{
								}
								((Page)this).Response.Write("<font color=\"red\">" + text + " Low/High Value:" + Strings.Mid(text4, regex6.Matches(text4)[0].Index + 1, regex5.Matches(text4)[i].Index + 1) + "</font>");
								dataimp.AddimpdataRow(text, value, 1.0, 1.0);
							}
						}
						else if (!Information.IsDate(data.Trim()) && Operators.CompareString(Strings.Mid(data, 1, 13), "Patient Code:", TextCompare: false) != 0)
						{
						}
						break;
					}
					case 922:
						num = -1;
						switch (num2)
						{
						case 2:
							break;
						default:
							goto IL_03d4;
						}
						break;
					}
				}
				catch (Exception ex) when ((num2 != 0) & (num == 0))
				{
					ProjectData.SetProjectError(ex);
					try0000_dispatch = 922;
					continue;
				}
				break;
				IL_03d4:
				throw ProjectData.CreateProjectError(-2146828237);
			}
			if (num != 0)
			{
				ProjectData.ClearProjectError();
			}
		}
	}

	protected void GridView1_RowDataBound(object sender, GridViewRowEventArgs e)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Invalid comparison between Unknown and I4
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Invalid comparison between Unknown and I4
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0118: Unknown result type (might be due to invalid IL or missing references)
		//IL_0143: Unknown result type (might be due to invalid IL or missing references)
		//IL_018e: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b9: Unknown result type (might be due to invalid IL or missing references)
		if ((int)e.Row.RowType == 2 && (int)e.Row.RowType == 2)
		{
			try
			{
				string text = ((Label)((Control)((TableRow)e.Row).Cells[1]).FindControl("tstAbrev")).Text;
				string key = Conversions.ToString(txtds.Rows.Find(text)["testname"]);
				string text2 = Conversions.ToString(dataimp.Rows.Find(key)["value"]);
				((TextBox)((Control)((TableRow)e.Row).Cells[7]).FindControl("ResultTXT")).Text = text2;
				((WebControl)(TextBox)((Control)((TableRow)e.Row).Cells[7]).FindControl("ResultTXT")).BackColor = Color.LawnGreen;
				double num = Conversions.ToDouble(dataimp.Rows.Find(key)["min"]);
				((TextBox)((Control)((TableRow)e.Row).Cells[5]).FindControl("TextBox1")).Text = Conversions.ToString(num);
				((WebControl)(TextBox)((Control)((TableRow)e.Row).Cells[5]).FindControl("TextBox1")).BackColor = Color.LawnGreen;
				double num2 = Conversions.ToDouble(dataimp.Rows.Find(key)["max"]);
				((TextBox)((Control)((TableRow)e.Row).Cells[6]).FindControl("TextBox2")).Text = Conversions.ToString(num2);
				((WebControl)(TextBox)((Control)((TableRow)e.Row).Cells[6]).FindControl("TextBox2")).BackColor = Color.LawnGreen;
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ProjectData.ClearProjectError();
			}
		}
	}

	protected void SqlDataSource1_Selecting(object sender, SqlDataSourceSelectingEventArgs e)
	{
	}

	protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
	{
	}

	public double roundIt(double num, int inPower)
	{
		int num2 = checked((int)Math.Round(Math.Pow(10.0, inPower)));
		num *= (double)num2;
		num = Math.Round(num);
		num /= (double)num2;
		return num;
	}
}
