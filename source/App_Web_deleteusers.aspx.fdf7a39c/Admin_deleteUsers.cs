using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Runtime.CompilerServices;
using System.Web;
using System.Web.Profile;
using System.Web.SessionState;
using System.Web.UI;
using System.Web.UI.WebControls;
using Microsoft.VisualBasic.CompilerServices;
using userinfoTableAdapters;

public class Admin_deleteUsers : Page, IRequiresSessionState
{
	[AccessedThroughProperty("testList")]
	private DropDownList _testList;

	[AccessedThroughProperty("remveUserBtn")]
	private Button _remveUserBtn;

	protected virtual DropDownList testList
	{
		get
		{
			return _testList;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_testList = value;
		}
	}

	protected virtual Button remveUserBtn
	{
		get
		{
			return _remveUserBtn;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			EventHandler eventHandler = remveUserBtn_Click;
			if (_remveUserBtn != null)
			{
				_remveUserBtn.Click -= eventHandler;
			}
			_remveUserBtn = value;
			if (_remveUserBtn != null)
			{
				_remveUserBtn.Click += eventHandler;
			}
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

	public Admin_deleteUsers()
	{
		((Control)this).Load += Page_Load;
	}

	private void deleteAUser(string uname, string inSysUn)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Expected Obj, but got Unknown
		SqlCommand val = new SqlCommand();
		SqlConnection val2 = (val.Connection = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString));
		val2.Open();
		string[] array = new string[5] { "DELETE FROM aspnet_Profile WHERE UserID = @UserId", "DELETE FROM aspnet_UsersInRoles WHERE UserID = @UserId", "DELETE FROM aspnet_PersonalizationPerUser WHERE UserID = @UserId", "DELETE FROM dbo.aspnet_Membership WHERE UserID = @UserId", "DELETE FROM aspnet_users WHERE UserID = @UserId" };
		string[] array2 = new string[4] { "DELETE FROM testInstance WHERE UserID = @UserName", "DELETE FROM ResultRef WHERE UserID = @UserName", "DELETE FROM UserInfo WHERE UserID = @UserName", "DELETE FROM complaints WHERE UserID = @UserName" };
		try
		{
			val.Parameters.Add("@UserId", SqlDbType.NVarChar, 256);
			string[] array3 = array;
			foreach (string commandText in array3)
			{
				val.CommandText = commandText;
				val.Parameters[0].Value = uname;
				val.ExecuteNonQuery();
			}
			val.Parameters.Clear();
			val.Parameters.Add("@UserName", SqlDbType.NVarChar, 256);
			string[] array4 = array2;
			foreach (string commandText2 in array4)
			{
				val.CommandText = commandText2;
				val.Parameters[0].Value = inSysUn;
				val.ExecuteNonQuery();
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			ProjectData.ClearProjectError();
		}
		val2.Close();
		((ListControl)testList).Items.Clear();
		refillUserList();
	}

	protected void Page_Load(object sender, EventArgs e)
	{
		if (!((Control)this).Page.IsPostBack)
		{
			refillUserList();
			((WebControl)remveUserBtn).Attributes.Add("onclick", "return confirm('Are you sure you want to delete?');");
		}
	}

	protected void remveUserBtn_Click(object sender, EventArgs e)
	{
		string text = ((ListControl)testList).SelectedItem.Text;
		string[] array = text.Split(new char[1] { '-' });
		text = array[0].Trim();
		deleteAUser(((ListControl)testList).SelectedValue, text);
	}

	private void refillUserList()
	{
		//IL_008b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0095: Expected Obj, but got Unknown
		userListTableAdapter userListTableAdapter2 = new userListTableAdapter();
		userinfo.userListDataTable userListDataTable = new userinfo.userListDataTable();
		userListTableAdapter2.Fill(userListDataTable);
		int count = userListDataTable.Count;
		checked
		{
			for (int i = 1; i <= count; i++)
			{
				((ListControl)testList).Items.Add(new ListItem(userListDataTable.Rows[i - 1]["UserName"].ToString() + " - " + userListDataTable.Rows[i - 1]["Name"].ToString(), userListDataTable.Rows[i - 1]["UserId"].ToString()));
			}
		}
	}
}
