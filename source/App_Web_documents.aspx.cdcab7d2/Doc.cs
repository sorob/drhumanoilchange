using System;
using System.Runtime.CompilerServices;
using System.Web;
using System.Web.Profile;
using System.Web.SessionState;
using System.Web.UI;
using System.Web.UI.HtmlControls;

public class Doc : Page, IRequiresSessionState
{
	[AccessedThroughProperty("IFRAME1")]
	private HtmlGenericControl _IFRAME1;

	protected virtual HtmlGenericControl IFRAME1
	{
		get
		{
			return _IFRAME1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_IFRAME1 = value;
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

	public Doc()
	{
		((Control)this).Load += Page_Load;
	}

	protected void Page_Load(object sender, EventArgs e)
	{
	}
}
