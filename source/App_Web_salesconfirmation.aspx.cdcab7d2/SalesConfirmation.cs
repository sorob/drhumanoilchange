using System.Web;
using System.Web.Profile;
using System.Web.SessionState;
using System.Web.UI;

public class SalesConfirmation : Page, IRequiresSessionState
{
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
}
