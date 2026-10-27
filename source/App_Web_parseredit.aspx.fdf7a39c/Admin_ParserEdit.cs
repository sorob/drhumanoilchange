using System;
using System.Runtime.CompilerServices;
using System.Web;
using System.Web.Profile;
using System.Web.SessionState;
using System.Web.UI;
using System.Web.UI.WebControls;
using Microsoft.VisualBasic.CompilerServices;
using textrefTableAdapters;

public class Admin_ParserEdit : Page, IRequiresSessionState
{
	[AccessedThroughProperty("GridView1")]
	private GridView _GridView1;

	[AccessedThroughProperty("SqlDataSource1")]
	private SqlDataSource _SqlDataSource1;

	[AccessedThroughProperty("Button2")]
	private Button _Button2;

	[AccessedThroughProperty("View1")]
	private View _View1;

	[AccessedThroughProperty("DropDownList1")]
	private DropDownList _DropDownList1;

	[AccessedThroughProperty("SqlDataSource2")]
	private SqlDataSource _SqlDataSource2;

	[AccessedThroughProperty("Tname")]
	private TextBox _Tname;

	[AccessedThroughProperty("Tresult")]
	private TextBox _Tresult;

	[AccessedThroughProperty("Tflag")]
	private TextBox _Tflag;

	[AccessedThroughProperty("Tlow")]
	private TextBox _Tlow;

	[AccessedThroughProperty("Thigh")]
	private TextBox _Thigh;

	[AccessedThroughProperty("DropDownList3")]
	private DropDownList _DropDownList3;

	[AccessedThroughProperty("SqlDataSource3")]
	private SqlDataSource _SqlDataSource3;

	[AccessedThroughProperty("Tdefault")]
	private TextBox _Tdefault;

	[AccessedThroughProperty("Tunits")]
	private TextBox _Tunits;

	[AccessedThroughProperty("Tdefopt")]
	private TextBox _Tdefopt;

	[AccessedThroughProperty("Button1")]
	private Button _Button1;

	[AccessedThroughProperty("View2")]
	private View _View2;

	[AccessedThroughProperty("MultiView1")]
	private MultiView _MultiView1;

	protected virtual GridView GridView1
	{
		get
		{
			return _GridView1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_GridView1 = value;
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

	protected virtual DropDownList DropDownList1
	{
		get
		{
			return _DropDownList1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_DropDownList1 = value;
		}
	}

	protected virtual SqlDataSource SqlDataSource2
	{
		get
		{
			return _SqlDataSource2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_SqlDataSource2 = value;
		}
	}

	protected virtual TextBox Tname
	{
		get
		{
			return _Tname;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_Tname = value;
		}
	}

	protected virtual TextBox Tresult
	{
		get
		{
			return _Tresult;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_Tresult = value;
		}
	}

	protected virtual TextBox Tflag
	{
		get
		{
			return _Tflag;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_Tflag = value;
		}
	}

	protected virtual TextBox Tlow
	{
		get
		{
			return _Tlow;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_Tlow = value;
		}
	}

	protected virtual TextBox Thigh
	{
		get
		{
			return _Thigh;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_Thigh = value;
		}
	}

	protected virtual DropDownList DropDownList3
	{
		get
		{
			return _DropDownList3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_DropDownList3 = value;
		}
	}

	protected virtual SqlDataSource SqlDataSource3
	{
		get
		{
			return _SqlDataSource3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_SqlDataSource3 = value;
		}
	}

	protected virtual TextBox Tdefault
	{
		get
		{
			return _Tdefault;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_Tdefault = value;
		}
	}

	protected virtual TextBox Tunits
	{
		get
		{
			return _Tunits;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_Tunits = value;
		}
	}

	protected virtual TextBox Tdefopt
	{
		get
		{
			return _Tdefopt;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_Tdefopt = value;
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

	protected void Button1_Click(object sender, EventArgs e)
	{
		txtimpTableAdapter txtimpTableAdapter2 = new txtimpTableAdapter();
		txtimpTableAdapter2.insertq("", "", "", "", ((ListControl)DropDownList1).SelectedValue, Tname.Text, Conversions.ToDouble(Tresult.Text), Tflag.Text, Conversions.ToDouble(Tlow.Text), Conversions.ToDouble(Thigh.Text), ((ListControl)DropDownList3).SelectedValue, Tdefault.Text, Tunits.Text, Tdefopt.Text, "");
		((Page)this).Response.Redirect("ParserEdit.aspx?added=1");
	}

	protected void Button2_Click(object sender, EventArgs e)
	{
		MultiView1.ActiveViewIndex = 1;
	}
}
