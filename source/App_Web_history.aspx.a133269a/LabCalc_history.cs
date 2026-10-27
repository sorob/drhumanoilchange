using System;
using System.Runtime.CompilerServices;
using System.Web;
using System.Web.Profile;
using System.Web.SessionState;
using System.Web.UI;
using System.Web.UI.WebControls;
using Microsoft.VisualBasic.CompilerServices;

public class LabCalc_history : Page, IRequiresSessionState
{
	[AccessedThroughProperty("GridView1")]
	private GridView _GridView1;

	[AccessedThroughProperty("SqlDataSource1")]
	private SqlDataSource _SqlDataSource1;

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
			GridViewCommandEventHandler val = GridView1_RowCommand;
			EventHandler eventHandler = GridView1_SelectedIndexChanged;
			if (_GridView1 != null)
			{
				_GridView1.RowCommand -= val;
				_GridView1.SelectedIndexChanged -= eventHandler;
			}
			_GridView1 = value;
			if (_GridView1 != null)
			{
				_GridView1.RowCommand += val;
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
			_SqlDataSource1 = value;
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

	public LabCalc_history()
	{
		((Control)this).Load += Page_Load;
	}

	protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
	{
	}

	protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
	{
		((Page)this).Session.Add("TestId", RuntimeHelpers.GetObjectValue(GridView1.SelectedDataKey.Value));
		((Page)this).Response.Redirect("ResultView.aspx");
	}

	protected void Page_Load(object sender, EventArgs e)
	{
		if (((Page)this).User.IsInRole("Admin"))
		{
			GridView1.Columns[4].Visible = true;
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
}
