using System;
using System.Runtime.CompilerServices;
using System.Web;
using System.Web.Profile;
using System.Web.SessionState;
using System.Web.UI;
using System.Web.UI.WebControls;
using DataSet1TableAdapters;
using Microsoft.VisualBasic.CompilerServices;

public class reader : Page, IRequiresSessionState
{
	[AccessedThroughProperty("HyperLink1")]
	private HyperLink _HyperLink1;

	[AccessedThroughProperty("Label1")]
	private Label _Label1;

	[AccessedThroughProperty("Label2")]
	private Label _Label2;

	protected virtual HyperLink HyperLink1
	{
		get
		{
			return _HyperLink1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_HyperLink1 = value;
		}
	}

	protected virtual Label Label1
	{
		get
		{
			return _Label1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_Label1 = value;
		}
	}

	protected virtual Label Label2
	{
		get
		{
			return _Label2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_Label2 = value;
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

	public reader()
	{
		((Control)this).Load += Page_Load;
	}

	protected void Page_Load(object sender, EventArgs e)
	{
		blogTableAdapter blogTableAdapter2 = new blogTableAdapter();
		DataSet1.blogDataTable blogDataTable = new DataSet1.blogDataTable();
		blogTableAdapter2.Fill(blogDataTable, Conversions.ToInteger(((Page)this).Request["id"]));
		Label1.Text = blogDataTable[0].blogtitle;
		Label2.Text = blogDataTable[0].blogtext;
		HyperLink1.ImageUrl = blogDataTable[0].thumb;
		HyperLink1.NavigateUrl = blogDataTable[0].img;
	}
}
