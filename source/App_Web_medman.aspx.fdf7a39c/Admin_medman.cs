using System;
using System.Runtime.CompilerServices;
using System.Web;
using System.Web.Profile;
using System.Web.SessionState;
using System.Web.UI;
using System.Web.UI.WebControls;

public class Admin_medman : Page, IRequiresSessionState
{
	[AccessedThroughProperty("UpdateProgress1")]
	private UpdateProgress _UpdateProgress1;

	[AccessedThroughProperty("DropDownList1")]
	private DropDownList _DropDownList1;

	[AccessedThroughProperty("SqlDataSource4")]
	private SqlDataSource _SqlDataSource4;

	[AccessedThroughProperty("UpdatePanel3")]
	private UpdatePanel _UpdatePanel3;

	[AccessedThroughProperty("GridView1")]
	private GridView _GridView1;

	[AccessedThroughProperty("SqlDataSource2")]
	private SqlDataSource _SqlDataSource2;

	[AccessedThroughProperty("UpdatePanel2")]
	private UpdatePanel _UpdatePanel2;

	[AccessedThroughProperty("TxtAbrev")]
	private TextBox _TxtAbrev;

	[AccessedThroughProperty("ddhl")]
	private DropDownList _ddhl;

	[AccessedThroughProperty("TprodId")]
	private TextBox _TprodId;

	[AccessedThroughProperty("Tprod")]
	private TextBox _Tprod;

	[AccessedThroughProperty("Tdosage")]
	private TextBox _Tdosage;

	[AccessedThroughProperty("TCo")]
	private TextBox _TCo;

	[AccessedThroughProperty("Torder")]
	private TextBox _Torder;

	[AccessedThroughProperty("Tbodyp")]
	private TextBox _Tbodyp;

	[AccessedThroughProperty("Tminscale")]
	private TextBox _Tminscale;

	[AccessedThroughProperty("DropDownList2")]
	private DropDownList _DropDownList2;

	[AccessedThroughProperty("Button1")]
	private Button _Button1;

	[AccessedThroughProperty("UpdatePanel1")]
	private UpdatePanel _UpdatePanel1;

	protected virtual UpdateProgress UpdateProgress1
	{
		get
		{
			return _UpdateProgress1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_UpdateProgress1 = value;
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
			EventHandler eventHandler = DropDownList1_SelectedIndexChanged;
			if (_DropDownList1 != null)
			{
				((ListControl)_DropDownList1).SelectedIndexChanged -= eventHandler;
			}
			_DropDownList1 = value;
			if (_DropDownList1 != null)
			{
				((ListControl)_DropDownList1).SelectedIndexChanged += eventHandler;
			}
		}
	}

	protected virtual SqlDataSource SqlDataSource4
	{
		get
		{
			return _SqlDataSource4;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_SqlDataSource4 = value;
		}
	}

	protected virtual UpdatePanel UpdatePanel3
	{
		get
		{
			return _UpdatePanel3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_UpdatePanel3 = value;
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

	protected virtual TextBox TxtAbrev
	{
		get
		{
			return _TxtAbrev;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_TxtAbrev = value;
		}
	}

	protected virtual DropDownList ddhl
	{
		get
		{
			return _ddhl;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ddhl = value;
		}
	}

	protected virtual TextBox TprodId
	{
		get
		{
			return _TprodId;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_TprodId = value;
		}
	}

	protected virtual TextBox Tprod
	{
		get
		{
			return _Tprod;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_Tprod = value;
		}
	}

	protected virtual TextBox Tdosage
	{
		get
		{
			return _Tdosage;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_Tdosage = value;
		}
	}

	protected virtual TextBox TCo
	{
		get
		{
			return _TCo;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_TCo = value;
		}
	}

	protected virtual TextBox Torder
	{
		get
		{
			return _Torder;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_Torder = value;
		}
	}

	protected virtual TextBox Tbodyp
	{
		get
		{
			return _Tbodyp;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_Tbodyp = value;
		}
	}

	protected virtual TextBox Tminscale
	{
		get
		{
			return _Tminscale;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_Tminscale = value;
		}
	}

	protected virtual DropDownList DropDownList2
	{
		get
		{
			return _DropDownList2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_DropDownList2 = value;
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

	public Admin_medman()
	{
		((Control)this).Load += Page_Load;
	}

	protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
	{
		GridView1.DataBind();
		TxtAbrev.Text = ((ListControl)DropDownList1).SelectedValue;
	}

	protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
	{
	}

	protected void Button1_Click(object sender, EventArgs e)
	{
		SqlDataSource2.Insert();
		GridView1.DataBind();
		Tminscale.Text = "";
		Torder.Text = "";
		Tprod.Text = "";
		TprodId.Text = "";
		TCo.Text = "";
		Tbodyp.Text = "";
		Tdosage.Text = "";
	}

	protected void Page_Load(object sender, EventArgs e)
	{
	}
}
