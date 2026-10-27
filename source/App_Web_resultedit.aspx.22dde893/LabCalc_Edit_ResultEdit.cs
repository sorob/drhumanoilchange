using System;
using System.Runtime.CompilerServices;
using System.Web;
using System.Web.Profile;
using System.Web.SessionState;
using System.Web.UI;
using System.Web.UI.WebControls;
using LabstuffTableAdapters;
using Microsoft.VisualBasic.CompilerServices;

public class LabCalc_Edit_ResultEdit : Page, IRequiresSessionState
{
	[AccessedThroughProperty("SqlDataSource1")]
	private SqlDataSource _SqlDataSource1;

	[AccessedThroughProperty("GridView1")]
	private GridView _GridView1;

	[AccessedThroughProperty("View1")]
	private View _View1;

	[AccessedThroughProperty("T_result")]
	private TextBox _T_result;

	[AccessedThroughProperty("T_abrev")]
	private Label _T_abrev;

	[AccessedThroughProperty("T_medlow")]
	private TextBox _T_medlow;

	[AccessedThroughProperty("medhigh")]
	private TextBox _medhigh;

	[AccessedThroughProperty("T_doclow")]
	private TextBox _T_doclow;

	[AccessedThroughProperty("T_dochigh")]
	private TextBox _T_dochigh;

	[AccessedThroughProperty("updatebtn")]
	private Button _updatebtn;

	[AccessedThroughProperty("Button1")]
	private Button _Button1;

	[AccessedThroughProperty("View2")]
	private View _View2;

	[AccessedThroughProperty("MultiView1")]
	private MultiView _MultiView1;

	private ResultRefTableAdapter resref;

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

	protected virtual TextBox T_result
	{
		get
		{
			return _T_result;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_T_result = value;
		}
	}

	protected virtual Label T_abrev
	{
		get
		{
			return _T_abrev;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_T_abrev = value;
		}
	}

	protected virtual TextBox T_medlow
	{
		get
		{
			return _T_medlow;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_T_medlow = value;
		}
	}

	protected virtual TextBox medhigh
	{
		get
		{
			return _medhigh;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_medhigh = value;
		}
	}

	protected virtual TextBox T_doclow
	{
		get
		{
			return _T_doclow;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_T_doclow = value;
		}
	}

	protected virtual TextBox T_dochigh
	{
		get
		{
			return _T_dochigh;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_T_dochigh = value;
		}
	}

	protected virtual Button updatebtn
	{
		get
		{
			return _updatebtn;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			EventHandler eventHandler = updatebtn_Click;
			if (_updatebtn != null)
			{
				_updatebtn.Click -= eventHandler;
			}
			_updatebtn = value;
			if (_updatebtn != null)
			{
				_updatebtn.Click += eventHandler;
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

	public LabCalc_Edit_ResultEdit()
	{
		((Control)this).Load += Page_Load;
		resref = new ResultRefTableAdapter();
	}

	protected void Page_Load(object sender, EventArgs e)
	{
		SqlDataSource1.SelectParameters[1].DefaultValue = ((Page)this).User.Identity.Name;
	}

	protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
	{
		T_abrev.Text = ((TableRow)GridView1.Rows[GridView1.SelectedIndex]).Cells[3].Text;
		T_dochigh.Text = ((TableRow)GridView1.Rows[GridView1.SelectedIndex]).Cells[10].Text;
		T_doclow.Text = ((TableRow)GridView1.Rows[GridView1.SelectedIndex]).Cells[9].Text;
		T_medlow.Text = ((TableRow)GridView1.Rows[GridView1.SelectedIndex]).Cells[4].Text;
		medhigh.Text = ((TableRow)GridView1.Rows[GridView1.SelectedIndex]).Cells[5].Text;
		T_result.Text = ((TableRow)GridView1.Rows[GridView1.SelectedIndex]).Cells[1].Text;
		MultiView1.ActiveViewIndex = 1;
	}

	private double getDif(double low, double high)
	{
		return (high - low) / 2.0;
	}

	private double getOpt(double low, double high)
	{
		return (high - low) / 2.0 + low;
	}

	private double getScale(double low, double high, double result)
	{
		return roundIt((result - getOpt(low, high)) / getDif(low, high), 3) * 100.0;
	}

	protected void Button1_Click(object sender, EventArgs e)
	{
		MultiView1.ActiveViewIndex = 0;
	}

	protected void updatebtn_Click(object sender, EventArgs e)
	{
		int rid = Conversions.ToInteger(((TableRow)GridView1.Rows[GridView1.SelectedIndex]).Cells[2].Text);
		resref.UpdateQuery(Conversions.ToDouble(T_result.Text), rid, Conversions.ToDouble(T_medlow.Text), Conversions.ToDouble(medhigh.Text), getOpt(Conversions.ToDouble(T_medlow.Text), Conversions.ToDouble(medhigh.Text)), getScale(Conversions.ToDouble(T_medlow.Text), Conversions.ToDouble(medhigh.Text), Conversions.ToDouble(T_result.Text)), Conversions.ToDouble(T_doclow.Text), getOpt(Conversions.ToDouble(T_doclow.Text), Conversions.ToDouble(T_dochigh.Text)), Conversions.ToDouble(T_dochigh.Text), getScale(Conversions.ToDouble(T_doclow.Text), Conversions.ToDouble(T_dochigh.Text), Conversions.ToDouble(T_result.Text)), ((Page)this).User.Identity.Name, Conversions.ToInteger(((Page)this).Request["tid"]), T_abrev.Text);
		GridView1.DataBind();
		MultiView1.ActiveViewIndex = 0;
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
