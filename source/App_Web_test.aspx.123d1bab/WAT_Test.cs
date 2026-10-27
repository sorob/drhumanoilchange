using System;
using System.Runtime.CompilerServices;
using System.Web;
using System.Web.Profile;
using System.Web.SessionState;
using System.Web.UI;
using System.Web.UI.WebControls;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Sahil.WebControls;
using WATTableAdapters;

public class WAT_Test : Page, IRequiresSessionState
{
	[AccessedThroughProperty("Label1")]
	private Label _Label1;

	[AccessedThroughProperty("Button1")]
	private Button _Button1;

	[AccessedThroughProperty("Button2")]
	private Button _Button2;

	[AccessedThroughProperty("Label2")]
	private Label _Label2;

	[AccessedThroughProperty("ProgressBar1")]
	private ProgressBar _ProgressBar1;

	[AccessedThroughProperty("UpdatePanel2")]
	private UpdatePanel _UpdatePanel2;

	[AccessedThroughProperty("UpdateProgress1")]
	private UpdateProgress _UpdateProgress1;

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

	protected virtual Button Button1
	{
		get
		{
			return _Button1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_Button1 = value;
		}
	}

	protected virtual Button Button2
	{
		get
		{
			return _Button2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_Button2 = value;
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

	protected virtual ProgressBar ProgressBar1
	{
		get
		{
			return _ProgressBar1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ProgressBar1 = value;
		}
	}

	protected virtual UpdatePanel UpdatePanel2
	{
		get
		{
			return _UpdatePanel2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_UpdatePanel2 = value;
		}
	}

	protected virtual UpdateProgress UpdateProgress1
	{
		get
		{
			return _UpdateProgress1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_UpdateProgress1 = value;
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

	public WAT_Test()
	{
		((Control)this).Load += Page_Load;
	}

	protected void Button2_Click(object sender, EventArgs e)
	{
		donext(Conversions.ToInteger(((Control)this).ViewState["b2"]));
	}

	private void donext(int aid)
	{
		int num = Conversions.ToInteger(((Control)this).ViewState["rowid"]);
		checked
		{
			int? num2 = default;
			if (num < 79)
			{
				testWordInstanceTableAdapter testWordInstanceTableAdapter2 = new testWordInstanceTableAdapter();
				int? choise = aid;
				object obj = ((Control)this).ViewState["tstID"];
				int? tid = ((obj != null) ? ((int?)obj) : num2);
				object obj2 = ((Control)this).ViewState["mid"];
				testWordInstanceTableAdapter2.Updateanswer(choise, tid, (obj2 != null) ? ((int?)obj2) : num2);
				bindtexts(getwid(Conversions.ToInteger(((Control)this).ViewState["tstID"]), num + 1));
				ProgressBar1.Value = (int)Math.Round((double)(num + 2) * 1.5);
				Label2.Text = Conversions.ToString(num + 2) + " of 80";
			}
			else if (num == 79)
			{
				testWordInstanceTableAdapter testWordInstanceTableAdapter3 = new testWordInstanceTableAdapter();
				int? choise2 = aid;
				object obj3 = ((Control)this).ViewState["tstID"];
				int? tid2 = ((obj3 != null) ? ((int?)obj3) : num2);
				object obj4 = ((Control)this).ViewState["mid"];
				testWordInstanceTableAdapter3.Updateanswer(choise2, tid2, (obj4 != null) ? ((int?)obj4) : num2);
				DataTable1TableAdapter dataTable1TableAdapter = new DataTable1TableAdapter();
				object obj5 = ((Control)this).ViewState["tstID"];
				int num3 = Conversions.ToInteger(dataTable1TableAdapter.getscore((obj5 != null) ? ((int?)obj5) : num2));
				testInstanceTableAdapter testInstanceTableAdapter2 = new testInstanceTableAdapter();
				testInstanceTableAdapter2.UpdateQuery(num3, Conversions.ToInteger(((Control)this).ViewState["tstID"]));
				((Page)this).Response.Redirect(Conversions.ToString(Operators.ConcatenateObject(string.Concat("score.aspx?s=" + Conversions.ToString(num3), "&testid="), ((Control)this).ViewState["tstID"])));
			}
			else
			{
				DataTable1TableAdapter dataTable1TableAdapter2 = new DataTable1TableAdapter();
				object obj6 = ((Control)this).ViewState["tstID"];
				int num4 = Conversions.ToInteger(dataTable1TableAdapter2.getscore((obj6 != null) ? ((int?)obj6) : num2));
				testInstanceTableAdapter testInstanceTableAdapter3 = new testInstanceTableAdapter();
				testInstanceTableAdapter3.UpdateQuery(num4, Conversions.ToInteger(((Control)this).ViewState["tstID"]));
				((Page)this).Response.Redirect(Conversions.ToString(Operators.ConcatenateObject(string.Concat("score.aspx?s=" + Conversions.ToString(num4), "&testid="), ((Control)this).ViewState["tstID"])));
			}
		}
	}

	protected void Page_Load(object sender, EventArgs e)
	{
		if (!((Control)this).Page.IsPostBack)
		{
			int num = Conversions.ToInteger(((Page)this).Context.Items["tstId"]);
			((Control)this).ViewState.Add("tstID", (object)num);
			bindtexts(getwid(num, 0));
		}
	}

	private int getwid(int tid, int rowid)
	{
		testWordInstanceTableAdapter testWordInstanceTableAdapter2 = new testWordInstanceTableAdapter();
		WAT.testWordInstanceDataTable testWordInstanceDataTable = new WAT.testWordInstanceDataTable();
		testWordInstanceTableAdapter2.FillBywid(testWordInstanceDataTable, tid);
		int main_word_id = testWordInstanceDataTable[rowid].main_word_id;
		((Control)this).ViewState.Add("rowid", (object)rowid);
		return main_word_id;
	}

	private void bindtexts(int q)
	{
		DataTable1TableAdapter dataTable1TableAdapter = new DataTable1TableAdapter();
		WAT.DataTable1DataTable dataTable1DataTable = new WAT.DataTable1DataTable();
		dataTable1TableAdapter.FillById(dataTable1DataTable, q);
		Random random = new Random();
		VBMath.Randomize();
		int num = random.Next(0, 6);
		if (num > 3)
		{
			Label1.Text = dataTable1DataTable[0].word_nm;
			Button1.Text = dataTable1DataTable[0].choice_word_nm;
			Button2.Text = dataTable1DataTable[1].choice_word_nm;
			((Control)this).ViewState.Add("b1", (object)dataTable1DataTable[0].choice_word_id);
			((Control)this).ViewState.Add("b2", (object)dataTable1DataTable[1].choice_word_id);
		}
		else
		{
			Label1.Text = dataTable1DataTable[0].word_nm;
			Button2.Text = dataTable1DataTable[0].choice_word_nm;
			Button1.Text = dataTable1DataTable[1].choice_word_nm;
			((Control)this).ViewState.Add("b1", (object)dataTable1DataTable[1].choice_word_id);
			((Control)this).ViewState.Add("b2", (object)dataTable1DataTable[0].choice_word_id);
		}
		((Control)this).ViewState.Add("mid", (object)q);
	}

	protected void Button1_Click(object sender, EventArgs e)
	{
		donext(Conversions.ToInteger(((Control)this).ViewState["b1"]));
	}
}
