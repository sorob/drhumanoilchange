using System;
using System.Runtime.CompilerServices;
using System.Web;
using System.Web.Profile;
using System.Web.SessionState;
using System.Web.UI;
using System.Web.UI.WebControls;
using Microsoft.VisualBasic.CompilerServices;
using userinfoTableAdapters;

public class Activate : Page, IRequiresSessionState
{
	[AccessedThroughProperty("Label1")]
	private Label _Label1;

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

	public Activate()
	{
		((Control)this).Load += Page_Load;
	}

	protected void Page_Load(object sender, EventArgs e)
	{
		try
		{
			Label1.Text = "Invalid User Name";
			Guid original_UserId = new Guid(((Page)this).Request["a"]);
			aspnet_MembershipTableAdapter aspnet_MembershipTableAdapter2 = new aspnet_MembershipTableAdapter();
			aspnet_MembershipTableAdapter2.changeaprove(IsApproved: true, original_UserId);
			Label1.Text = "Your account has been activated<br>Please login to the website";
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			Label1.Text = ex2.Message;
			ProjectData.ClearProjectError();
		}
	}
}
