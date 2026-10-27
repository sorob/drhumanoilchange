using System;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Web;
using System.Web.Profile;
using System.Web.SessionState;
using System.Web.UI;
using System.Web.UI.WebControls;
using ConwayControls.Web;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

public class LabCalc_compare : Page, IRequiresSessionState
{
	[AccessedThroughProperty("msglbl")]
	private Label _msglbl;

	[AccessedThroughProperty("GridView1")]
	private GridView _GridView1;

	[AccessedThroughProperty("SqlDataSource1")]
	private SqlDataSource _SqlDataSource1;

	[AccessedThroughProperty("Button1")]
	private Button _Button1;

	[AccessedThroughProperty("Button2")]
	private Button _Button2;

	[AccessedThroughProperty("View1")]
	private View _View1;

	[AccessedThroughProperty("View2")]
	private View _View2;

	[AccessedThroughProperty("MultiView1")]
	private MultiView _MultiView1;

	private DateTime startdate;

	protected virtual Label msglbl
	{
		get
		{
			return _msglbl;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_msglbl = value;
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
			EventHandler eventHandler2 = GridView1_DataBound;
			if (_GridView1 != null)
			{
				_GridView1.SelectedIndexChanged -= eventHandler;
				((BaseDataBoundControl)_GridView1).DataBound -= eventHandler2;
			}
			_GridView1 = value;
			if (_GridView1 != null)
			{
				_GridView1.SelectedIndexChanged += eventHandler;
				((BaseDataBoundControl)_GridView1).DataBound += eventHandler2;
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

	public LabCalc_compare()
	{
		((Control)this).Load += Page_Load;
	}

	protected void Page_Load(object sender, EventArgs e)
	{
		if (((Page)this).User.IsInRole("Admin"))
		{
			if (Conversions.ToBoolean(Operators.AndObject(Operators.CompareObjectNotEqual(((Page)this).Session["userid"], "", TextCompare: false), Operators.CompareString(((Page)this).Request["mode"], "admin", TextCompare: false) == 0)))
			{
				SqlDataSource1.SelectParameters[0].DefaultValue = Conversions.ToString(((Page)this).Session["userid"]);
			}
			else
			{
				SqlDataSource1.SelectParameters[0].DefaultValue = ((Page)this).User.Identity.Name;
			}
		}
		else
		{
			SqlDataSource1.SelectParameters[0].DefaultValue = ((Page)this).User.Identity.Name;
		}
	}

	protected void GridView1_DataBound(object sender, EventArgs e)
	{
		int count = GridView1.Rows.Count;
		checked
		{
			for (int i = 1; i <= count; i++)
			{
				if (i == 1)
				{
					startdate = Conversions.ToDate(((TableRow)GridView1.Rows[i - 1]).Cells[2].Text);
					((TableRow)GridView1.Rows[i - 1]).Cells[4].Text = "Day #1";
				}
				else
				{
					((TableRow)GridView1.Rows[i - 1]).Cells[4].Text = "Day #" + Conversions.ToString((Conversions.ToDate(((TableRow)GridView1.Rows[i - 1]).Cells[2].Text) - startdate).Days);
				}
			}
		}
	}

	protected void Button1_Click(object sender, EventArgs e)
	{
		checked
		{
			int num = GridView1.Rows.Count - 1;
			bool flag = default;
			double num2 = default;
			int num3 = default;
			DateTime t = default;
			bool flag2 = default;
			double num4 = default;
			int num5 = default;
			DateTime t2 = default;
			for (int i = 0; i <= num; i++)
			{
				RadioButton radioButton = new RadioButton();
				radioButton = (RadioButton)(object)((Control)((TableRow)GridView1.Rows[i]).Cells[0]).FindControl("RadioButton1");
				if (radioButton.Checked)
				{
					flag = true;
					num2 = Conversions.ToDouble(GridView1.DataKeys[i].Value);
					num3 = i;
					t = Conversions.ToDate(((TableRow)GridView1.Rows[i]).Cells[2].Text);
				}
				RadioButton radioButton2 = new RadioButton();
				radioButton2 = (RadioButton)(object)((Control)((TableRow)GridView1.Rows[i]).Cells[1]).FindControl("RadioButton2");
				if (radioButton2.Checked)
				{
					flag2 = true;
					num4 = Conversions.ToDouble(GridView1.DataKeys[i].Value);
					num5 = i;
					t2 = Conversions.ToDate(((TableRow)GridView1.Rows[i]).Cells[2].Text);
				}
			}
			if (flag & flag2)
			{
				double num6;
				double num7;
				if (DateTime.Compare(t, t2) > 0)
				{
					num6 = num2;
					num7 = num4;
				}
				else
				{
					num6 = num4;
					num7 = num2;
				}
				((Page)this).Response.Cookies["r1"].Value = Conversions.ToString(num6);
				((Page)this).Response.Cookies["r1"].Expires = DateAndTime.Now.AddDays(1.0);
				((Page)this).Response.Cookies["r2"].Value = Conversions.ToString(num7);
				((Page)this).Response.Cookies["r2"].Expires = DateAndTime.Now.AddDays(1.0);
				((Page)this).Response.Cookies["user"].Value = ((Page)this).User.Identity.Name;
				((Page)this).Response.Cookies["user"].Expires = DateAndTime.Now.AddDays(1.0);
				((Page)this).Response.Redirect("/CR/Getreport.aspx");
			}
			else if (flag | flag2)
			{
				if (flag)
				{
					if (GridView1.Rows.Count > num3 + 1)
					{
						num4 = Conversions.ToDouble(GridView1.DataKeys[num3 + 1].Value);
						t2 = Conversions.ToDate(((TableRow)GridView1.Rows[num3 + 1]).Cells[2].Text);
					}
					else
					{
						num4 = Conversions.ToDouble(GridView1.DataKeys[num3 - 1].Value);
						t2 = Conversions.ToDate(((TableRow)GridView1.Rows[num3 - 1]).Cells[2].Text);
					}
				}
				else if (num5 > 0)
				{
					num2 = Conversions.ToDouble(GridView1.DataKeys[num5 - 1].Value);
					t = Conversions.ToDate(((TableRow)GridView1.Rows[num5 - 1]).Cells[2].Text);
				}
				else
				{
					num2 = Conversions.ToDouble(GridView1.DataKeys[num5 + 1].Value);
					t = Conversions.ToDate(((TableRow)GridView1.Rows[num5 + 1]).Cells[2].Text);
				}
				double num6;
				double num7;
				if (DateTime.Compare(t, t2) > 0)
				{
					num6 = num2;
					num7 = num4;
				}
				else
				{
					num6 = num4;
					num7 = num2;
				}
				((Page)this).Response.Cookies["r1"].Value = Conversions.ToString(num6);
				((Page)this).Response.Cookies["r1"].Expires = DateAndTime.Now.AddDays(1.0);
				((Page)this).Response.Cookies["r2"].Value = Conversions.ToString(num7);
				((Page)this).Response.Cookies["r2"].Expires = DateAndTime.Now.AddDays(1.0);
				((Page)this).Response.Cookies["user"].Value = ((Page)this).User.Identity.Name;
				((Page)this).Response.Cookies["user"].Expires = DateAndTime.Now.AddDays(1.0);
				((Page)this).Response.Redirect("/CR/Getreport.aspx");
			}
			else
			{
				msglbl.Text = "Please select two tests to compare";
				((WebControl)msglbl).ForeColor = Color.Red;
			}
		}
	}

	protected void Button2_Click(object sender, EventArgs e)
	{
		checked
		{
			int num = GridView1.Rows.Count - 1;
			bool flag = default;
			double num2 = default;
			int num3 = default;
			DateTime t = default;
			bool flag2 = default;
			double num4 = default;
			int num5 = default;
			DateTime t2 = default;
			for (int i = 0; i <= num; i++)
			{
				RadioButton radioButton = new RadioButton();
				radioButton = (RadioButton)(object)((Control)((TableRow)GridView1.Rows[i]).Cells[0]).FindControl("RadioButton1");
				if (radioButton.Checked)
				{
					flag = true;
					num2 = Conversions.ToDouble(GridView1.DataKeys[i].Value);
					num3 = i;
					t = Conversions.ToDate(((TableRow)GridView1.Rows[i]).Cells[2].Text);
				}
				RadioButton radioButton2 = new RadioButton();
				radioButton2 = (RadioButton)(object)((Control)((TableRow)GridView1.Rows[i]).Cells[1]).FindControl("RadioButton2");
				if (radioButton2.Checked)
				{
					flag2 = true;
					num4 = Conversions.ToDouble(GridView1.DataKeys[i].Value);
					num5 = i;
					t2 = Conversions.ToDate(((TableRow)GridView1.Rows[i]).Cells[2].Text);
				}
			}
			if (flag & flag2)
			{
				double num6;
				double num7;
				if (DateTime.Compare(t, t2) > 0)
				{
					num6 = num2;
					num7 = num4;
				}
				else
				{
					num6 = num4;
					num7 = num2;
				}
				((Page)this).Response.Cookies["r1"].Value = Conversions.ToString(num6);
				((Page)this).Response.Cookies["r1"].Expires = DateAndTime.Now.AddDays(1.0);
				((Page)this).Response.Cookies["r2"].Value = Conversions.ToString(num7);
				((Page)this).Response.Cookies["r2"].Expires = DateAndTime.Now.AddDays(1.0);
				((Page)this).Response.Cookies["user"].Value = ((Page)this).User.Identity.Name;
				((Page)this).Response.Cookies["user"].Expires = DateAndTime.Now.AddDays(1.0);
				((Page)this).Response.Redirect("/CR/Getreport.aspx");
			}
			else if (flag | flag2)
			{
				if (flag)
				{
					if (GridView1.Rows.Count > num3 + 1)
					{
						num4 = Conversions.ToDouble(GridView1.DataKeys[num3 + 1].Value);
						t2 = Conversions.ToDate(((TableRow)GridView1.Rows[num3 + 1]).Cells[2].Text);
					}
					else
					{
						num4 = Conversions.ToDouble(GridView1.DataKeys[num3 - 1].Value);
						t2 = Conversions.ToDate(((TableRow)GridView1.Rows[num3 - 1]).Cells[2].Text);
					}
				}
				else if (num5 > 0)
				{
					num2 = Conversions.ToDouble(GridView1.DataKeys[num5 - 1].Value);
					t = Conversions.ToDate(((TableRow)GridView1.Rows[num5 - 1]).Cells[2].Text);
				}
				else
				{
					num2 = Conversions.ToDouble(GridView1.DataKeys[num5 + 1].Value);
					t = Conversions.ToDate(((TableRow)GridView1.Rows[num5 + 1]).Cells[2].Text);
				}
				double num6;
				double num7;
				if (DateTime.Compare(t, t2) > 0)
				{
					num6 = num2;
					num7 = num4;
				}
				else
				{
					num6 = num4;
					num7 = num2;
				}
				((Page)this).Response.Cookies["r1"].Value = Conversions.ToString(num6);
				((Page)this).Response.Cookies["r1"].Expires = DateAndTime.Now.AddDays(1.0);
				((Page)this).Response.Cookies["r2"].Value = Conversions.ToString(num7);
				((Page)this).Response.Cookies["r2"].Expires = DateAndTime.Now.AddDays(1.0);
				((Page)this).Response.Cookies["user"].Value = ((Page)this).User.Identity.Name;
				((Page)this).Response.Cookies["user"].Expires = DateAndTime.Now.AddDays(1.0);
				((Page)this).Response.Redirect("/CR/Getreport.aspx");
			}
			else
			{
				msglbl.Text = "Please select two tests to compare";
				((WebControl)msglbl).ForeColor = Color.Red;
			}
		}
	}

	protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
	{
	}
}
