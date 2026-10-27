using System.Runtime.CompilerServices;
using System.Web;
using System.Web.Profile;
using System.Web.SessionState;
using System.Web.UI;
using System.Web.UI.WebControls;

public class Products : Page, IRequiresSessionState
{
	[AccessedThroughProperty("TreeView1")]
	private TreeView _TreeView1;

	[AccessedThroughProperty("SiteMapDataSource1")]
	private SiteMapDataSource _SiteMapDataSource1;

	protected virtual TreeView TreeView1
	{
		get
		{
			return _TreeView1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_TreeView1 = value;
		}
	}

	protected virtual SiteMapDataSource SiteMapDataSource1
	{
		get
		{
			return _SiteMapDataSource1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_SiteMapDataSource1 = value;
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
}
