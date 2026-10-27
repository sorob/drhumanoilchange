using System;
using System.Runtime.CompilerServices;
using System.Web;
using System.Web.Profile;
using System.Web.SessionState;
using System.Web.UI;
using System.Web.UI.WebControls;
using LabstuffTableAdapters;

public class Admin_ratioEditor : Page, IRequiresSessionState
{
	[AccessedThroughProperty("GridView1")]
	private GridView _GridView1;

	[AccessedThroughProperty("testSelector1")]
	private DropDownList _testSelector1;

	[AccessedThroughProperty("SqlDataSource2")]
	private SqlDataSource _SqlDataSource2;

	[AccessedThroughProperty("testSelector2")]
	private DropDownList _testSelector2;

	[AccessedThroughProperty("SqlDataSource3")]
	private SqlDataSource _SqlDataSource3;

	[AccessedThroughProperty("testSelectorRatio")]
	private DropDownList _testSelectorRatio;

	[AccessedThroughProperty("SqlDataSource4")]
	private SqlDataSource _SqlDataSource4;

	[AccessedThroughProperty("addRatio")]
	private Button _addRatio;

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
			_GridView1 = value;
		}
	}

	protected virtual DropDownList testSelector1
	{
		get
		{
			return _testSelector1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_testSelector1 = value;
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

	protected virtual DropDownList testSelector2
	{
		get
		{
			return _testSelector2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_testSelector2 = value;
		}
	}

	protected virtual SqlDataSource SqlDataSource3
	{
		get
		{
			return _SqlDataSource3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_SqlDataSource3 = value;
		}
	}

	protected virtual DropDownList testSelectorRatio
	{
		get
		{
			return _testSelectorRatio;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_testSelectorRatio = value;
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

	protected virtual Button addRatio
	{
		get
		{
			return _addRatio;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			EventHandler eventHandler = addRatio_Click;
			if (_addRatio != null)
			{
				_addRatio.Click -= eventHandler;
			}
			_addRatio = value;
			if (_addRatio != null)
			{
				_addRatio.Click += eventHandler;
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

	protected void addRatio_Click(object sender, EventArgs e)
	{
		ratioRefTableAdapter ratioRefTableAdapter2 = new ratioRefTableAdapter();
		ratioRefTableAdapter2.AddRatio(((ListControl)testSelector1).SelectedValue, ((ListControl)testSelector2).SelectedValue, ((ListControl)testSelectorRatio).SelectedValue);
		GridView1.DataBind();
	}
}
