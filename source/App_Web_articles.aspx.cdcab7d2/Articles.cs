using System;
using System.Runtime.CompilerServices;
using System.Web;
using System.Web.Profile;
using System.Web.SessionState;
using System.Web.UI;
using System.Web.UI.WebControls;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

public class Articles : Page, IRequiresSessionState
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
			GridViewRowEventHandler val = GridView1_RowDataBound;
			if (_GridView1 != null)
			{
				_GridView1.RowDataBound -= val;
			}
			_GridView1 = value;
			if (_GridView1 != null)
			{
				_GridView1.RowDataBound += val;
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

	public Articles()
	{
		((Control)this).Load += Page_Load;
	}

	protected void GridView1_RowDataBound(object sender, GridViewRowEventArgs e)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Invalid comparison between Unknown and I4
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Invalid comparison between Unknown and I4
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Expected Obj, but got Unknown
		if (((int)e.Row.RowType == 2) | ((int)e.Row.RowType == 3))
		{
			Label val = (Label)((Control)((TableRow)e.Row).Cells[0]).FindControl("TextLbl");
			string text = val.Text;
			text = Utilities.RemoveHTML(text);
			text = selecttext(text);
			val.Text = text;
		}
	}

	private string selecttext(string text)
	{
		int num = Strings.Len(text);
		checked
		{
			int num2 = default;
			string text2 = default;
			for (int i = 1; i <= num; i++)
			{
				if (Operators.CompareString(Strings.Mid(text, i, 1), " ", TextCompare: false) == 0)
				{
					num2++;
					if (num2 > 13)
					{
						break;
					}
				}
				text2 = Strings.Mid(text, 1, i);
			}
			return text2 + "...";
		}
	}

	protected void Page_Load(object sender, EventArgs e)
	{
	}
}
