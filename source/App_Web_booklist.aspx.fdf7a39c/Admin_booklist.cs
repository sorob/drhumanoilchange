using System;
using System.Runtime.CompilerServices;
using System.Web;
using System.Web.Profile;
using System.Web.SessionState;
using System.Web.UI;
using System.Web.UI.WebControls;
using AjaxControlToolkit;
using LabstuffTableAdapters;

public class Admin_booklist : Page, IRequiresSessionState
{
	[AccessedThroughProperty("SqlDataSource1")]
	private SqlDataSource _SqlDataSource1;

	[AccessedThroughProperty("GridView1")]
	private GridView _GridView1;

	[AccessedThroughProperty("TabPanel1")]
	private TabPanel _TabPanel1;

	[AccessedThroughProperty("DropDownList1")]
	private DropDownList _DropDownList1;

	[AccessedThroughProperty("SqlDataSource2")]
	private SqlDataSource _SqlDataSource2;

	[AccessedThroughProperty("tbookname")]
	private TextBox _tbookname;

	[AccessedThroughProperty("Tpnum")]
	private TextBox _Tpnum;

	[AccessedThroughProperty("tdatepub")]
	private TextBox _tdatepub;

	[AccessedThroughProperty("tAuthor")]
	private TextBox _tAuthor;

	[AccessedThroughProperty("tnote")]
	private TextBox _tnote;

	[AccessedThroughProperty("tresearch")]
	private TextBox _tresearch;

	[AccessedThroughProperty("Submitbtn")]
	private Button _Submitbtn;

	[AccessedThroughProperty("TabPanel2")]
	private TabPanel _TabPanel2;

	[AccessedThroughProperty("TabContainer1")]
	private TabContainer _TabContainer1;

	[AccessedThroughProperty("UpdatePanel1")]
	private UpdatePanel _UpdatePanel1;

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
			_GridView1 = value;
		}
	}

	protected virtual TabPanel TabPanel1
	{
		get
		{
			return _TabPanel1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_TabPanel1 = value;
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

	protected virtual TextBox tbookname
	{
		get
		{
			return _tbookname;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_tbookname = value;
		}
	}

	protected virtual TextBox Tpnum
	{
		get
		{
			return _Tpnum;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_Tpnum = value;
		}
	}

	protected virtual TextBox tdatepub
	{
		get
		{
			return _tdatepub;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_tdatepub = value;
		}
	}

	protected virtual TextBox tAuthor
	{
		get
		{
			return _tAuthor;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_tAuthor = value;
		}
	}

	protected virtual TextBox tnote
	{
		get
		{
			return _tnote;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_tnote = value;
		}
	}

	protected virtual TextBox tresearch
	{
		get
		{
			return _tresearch;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_tresearch = value;
		}
	}

	protected virtual Button Submitbtn
	{
		get
		{
			return _Submitbtn;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			EventHandler eventHandler = Submitbtn_Click;
			if (_Submitbtn != null)
			{
				_Submitbtn.Click -= eventHandler;
			}
			_Submitbtn = value;
			if (_Submitbtn != null)
			{
				_Submitbtn.Click += eventHandler;
			}
		}
	}

	protected virtual TabPanel TabPanel2
	{
		get
		{
			return _TabPanel2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_TabPanel2 = value;
		}
	}

	protected virtual TabContainer TabContainer1
	{
		get
		{
			return _TabContainer1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_TabContainer1 = value;
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

	public Admin_booklist()
	{
		((Control)this).Load += Page_Load;
	}

	protected void Submitbtn_Click(object sender, EventArgs e)
	{
		testbookrefTableAdapter testbookrefTableAdapter2 = new testbookrefTableAdapter();
		testbookrefTableAdapter2.Insertbooks(((ListControl)DropDownList1).SelectedValue, tbookname.Text, tAuthor.Text, tdatepub.Text, Tpnum.Text, tnote.Text, tresearch.Text);
		tbookname.Text = "";
		Tpnum.Text = "";
		tresearch.Text = "";
		tAuthor.Text = "";
		tdatepub.Text = "";
		tnote.Text = "";
		GridView1.DataBind();
	}

	protected void Page_Load(object sender, EventArgs e)
	{
	}
}
