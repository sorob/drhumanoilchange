using System;
using System.Runtime.CompilerServices;
using System.Web;
using System.Web.Profile;
using System.Web.SessionState;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using PayPal.Web.Controls;

public class Services_Assurance : Page, IRequiresSessionState
{
	[AccessedThroughProperty("AddToCartButton3")]
	private AddToCartButton _AddToCartButton3;

	[AccessedThroughProperty("form1")]
	private HtmlForm _form1;

	protected virtual AddToCartButton AddToCartButton3
	{
		get
		{
			return _AddToCartButton3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			EventHandler value2 = AddToCartButton3_Click;
			if (_AddToCartButton3 != null)
			{
				_AddToCartButton3.Click -= value2;
			}
			_AddToCartButton3 = value;
			if (_AddToCartButton3 != null)
			{
				_AddToCartButton3.Click += value2;
			}
		}
	}

	protected virtual HtmlForm form1
	{
		get
		{
			return _form1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_form1 = value;
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

	public Services_Assurance()
	{
		((Control)this).Load += Page_Load;
	}

	protected void Page_Load(object sender, EventArgs e)
	{
		AddToCartButton3.Option1Values = ((Page)this).User.Identity.Name;
	}

	protected void AddToCartButton3_Click(object sender, EventArgs e)
	{
	}
}
