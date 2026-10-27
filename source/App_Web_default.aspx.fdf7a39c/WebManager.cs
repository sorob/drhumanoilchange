using System;
using System.IO;
using System.Runtime.CompilerServices;
using System.Web;
using System.Web.Profile;
using System.Web.SessionState;
using System.Web.UI;
using System.Web.UI.WebControls;
using FreeTextBoxControls;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Sample.Web.UI.Compatibility;
using blogupdateTableAdapters;

public class WebManager : Page, IRequiresSessionState
{
	[AccessedThroughProperty("HyperLink4")]
	private HyperLink _HyperLink4;

	[AccessedThroughProperty("HyperLink5")]
	private HyperLink _HyperLink5;

	[AccessedThroughProperty("EditView")]
	private View _EditView;

	[AccessedThroughProperty("HyperLink3")]
	private HyperLink _HyperLink3;

	[AccessedThroughProperty("addView")]
	private View _addView;

	[AccessedThroughProperty("MultiView2")]
	private MultiView _MultiView2;

	[AccessedThroughProperty("lblmsg")]
	private Label _lblmsg;

	[AccessedThroughProperty("SqlDataSource1")]
	private SqlDataSource _SqlDataSource1;

	[AccessedThroughProperty("GridView1")]
	private GridView _GridView1;

	[AccessedThroughProperty("View1")]
	private View _View1;

	[AccessedThroughProperty("Label1")]
	private Label _Label1;

	[AccessedThroughProperty("txtsubject")]
	private TextBox _txtsubject;

	[AccessedThroughProperty("RequiredFieldValidator1")]
	private RequiredFieldValidator _RequiredFieldValidator1;

	[AccessedThroughProperty("Label3")]
	private Label _Label3;

	[AccessedThroughProperty("FileUpload1")]
	private FileUpload _FileUpload1;

	[AccessedThroughProperty("Label2")]
	private Label _Label2;

	[AccessedThroughProperty("Image1")]
	private Image _Image1;

	[AccessedThroughProperty("drcat")]
	private DropDownList _drcat;

	[AccessedThroughProperty("FreeTextBox1")]
	private FreeTextBox _FreeTextBox1;

	[AccessedThroughProperty("CheckBox1")]
	private CheckBox _CheckBox1;

	[AccessedThroughProperty("View2")]
	private View _View2;

	[AccessedThroughProperty("MultiView1")]
	private MultiView _MultiView1;

	private string a;

	private string b;

	protected virtual HyperLink HyperLink4
	{
		get
		{
			return _HyperLink4;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_HyperLink4 = value;
		}
	}

	protected virtual HyperLink HyperLink5
	{
		get
		{
			return _HyperLink5;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_HyperLink5 = value;
		}
	}

	protected virtual View EditView
	{
		get
		{
			return _EditView;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_EditView = value;
		}
	}

	protected virtual HyperLink HyperLink3
	{
		get
		{
			return _HyperLink3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_HyperLink3 = value;
		}
	}

	protected virtual View addView
	{
		get
		{
			return _addView;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_addView = value;
		}
	}

	protected virtual MultiView MultiView2
	{
		get
		{
			return _MultiView2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_MultiView2 = value;
		}
	}

	protected virtual Label lblmsg
	{
		get
		{
			return _lblmsg;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_lblmsg = value;
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
			//IL_0016: Unknown result type (might be due to invalid IL or missing references)
			//IL_001c: Expected Obj, but got Unknown
			GridViewRowEventHandler val = GridView1_RowDataBound;
			GridViewCommandEventHandler val2 = GridView1_RowCommand;
			EventHandler eventHandler = GridView1_SelectedIndexChanged;
			if (_GridView1 != null)
			{
				_GridView1.RowDataBound -= val;
				_GridView1.RowCommand -= val2;
				_GridView1.SelectedIndexChanged -= eventHandler;
			}
			_GridView1 = value;
			if (_GridView1 != null)
			{
				_GridView1.RowDataBound += val;
				_GridView1.RowCommand += val2;
				_GridView1.SelectedIndexChanged += eventHandler;
			}
		}
	}

	protected virtual View View1
	{
		get
		{
			return _View1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_View1 = value;
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

	protected virtual TextBox txtsubject
	{
		get
		{
			return _txtsubject;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_txtsubject = value;
		}
	}

	protected virtual RequiredFieldValidator RequiredFieldValidator1
	{
		get
		{
			return _RequiredFieldValidator1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_RequiredFieldValidator1 = value;
		}
	}

	protected virtual Label Label3
	{
		get
		{
			return _Label3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_Label3 = value;
		}
	}

	protected virtual FileUpload FileUpload1
	{
		get
		{
			return _FileUpload1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_FileUpload1 = value;
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

	protected virtual Image Image1
	{
		get
		{
			return _Image1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_Image1 = value;
		}
	}

	protected virtual DropDownList drcat
	{
		get
		{
			return _drcat;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_drcat = value;
		}
	}

	protected virtual FreeTextBox FreeTextBox1
	{
		get
		{
			return _FreeTextBox1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			EventHandler value2 = FreeTextBox1_SaveClick;
			if (_FreeTextBox1 != null)
			{
				_FreeTextBox1.SaveClick -= value2;
			}
			_FreeTextBox1 = value;
			if (_FreeTextBox1 != null)
			{
				_FreeTextBox1.SaveClick += value2;
			}
		}
	}

	protected virtual CheckBox CheckBox1
	{
		get
		{
			return _CheckBox1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_CheckBox1 = value;
		}
	}

	protected virtual View View2
	{
		get
		{
			return _View2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			EventHandler eventHandler = View2_Load;
			if (_View2 != null)
			{
				((Control)_View2).Load -= eventHandler;
			}
			_View2 = value;
			if (_View2 != null)
			{
				((Control)_View2).Load += eventHandler;
			}
		}
	}

	protected virtual MultiView MultiView1
	{
		get
		{
			return _MultiView1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_MultiView1 = value;
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

	public WebManager()
	{
		((Control)this).Load += Page_Load;
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

	protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
	{
		if (Operators.CompareString(((CommandEventArgs)e).CommandName, "Delete", TextCompare: false) == 0)
		{
			((Page)this).Session.Add("Un", (object)((Page)this).User.Identity.Name);
			SqlDataSource1.DeleteParameters["bid"].DefaultValue = Conversions.ToString(Conversions.ToInteger(((CommandEventArgs)e).CommandArgument));
			SqlDataSource1.Delete();
			((Page)this).Response.Redirect("default.aspx");
		}
	}

	protected void GridView1_RowDataBound(object sender, GridViewRowEventArgs e)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Invalid comparison between Unknown and I4
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Invalid comparison between Unknown and I4
		//IL_0063: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Invalid comparison between Unknown and I4
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Expected Obj, but got Unknown
		//IL_008d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0093: Expected Obj, but got Unknown
		//IL_00c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cb: Expected Obj, but got Unknown
		int try0000_dispatch = -1;
		int num2 = default;
		int num = default;
		while (true)
		{
			try
			{
				/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
				switch (try0000_dispatch)
				{
				default:
					if (((int)e.Row.RowType == 2) | ((int)e.Row.RowType == 3))
					{
						Label val2 = (Label)((Control)((TableRow)e.Row).Cells[0]).FindControl("TextLbl");
						string text = val2.Text;
						text = Utilities.RemoveHTML(text);
						text = selecttext(text);
						val2.Text = text;
					}
					if ((int)e.Row.RowType == 2)
					{
						ProjectData.ClearProjectError();
						num2 = 2;
						ImageButton val = (ImageButton)((Control)((TableRow)e.Row).Cells[0]).FindControl("cmdDel2");
						((WebControl)val).Attributes.Add("onclick", "return getconfirm();");
					}
					goto end_IL_0000;
				case 226:
					num = -1;
					switch (num2)
					{
					case 2:
					{
						ImageButton val = (ImageButton)((Control)((TableRow)e.Row).Cells[0]).FindControl("cmdDel1");
						((WebControl)val).Attributes.Add("onclick", "return getconfirm();");
						goto end_IL_0000;
					}
					}
					break;
				}
			}
			catch (Exception ex) when ((num2 != 0) & (num == 0))
			{
				ProjectData.SetProjectError(ex);
				try0000_dispatch = 226;
				continue;
			}
			throw ProjectData.CreateProjectError(-2146828237);
			continue;
			end_IL_0000:
			break;
		}
		if (num != 0)
		{
			ProjectData.ClearProjectError();
		}
	}

	private bool imgsaver(FileUpload file1, string Uniqename)
	{
		bool result = false;
		string text = Path.GetExtension(file1.PostedFile.FileName).ToLower();
		if (Operators.CompareString(text, ".jpg", TextCompare: false) == 0)
		{
			string text2 = Path.Combine(((Page)this).Server.MapPath("../images"), "blog" + Uniqename + text);
			string thumbpath = Path.Combine(((Page)this).Server.MapPath("../images"), "thumb-blog" + Uniqename + text);
			string text3 = "images/blog" + Uniqename + text;
			string text4 = "images/thumb-blog" + Uniqename + text;
			file1.PostedFile.SaveAs(text2);
			if (imager.makethumb(text2, thumbpath, 100))
			{
				a = text3;
				b = text4;
				result = true;
			}
		}
		return result;
	}

	protected void Page_Load(object sender, EventArgs e)
	{
		if (!((Control)this).Page.IsPostBack)
		{
			if (Operators.CompareString(((Page)this).Request["editid"], "", TextCompare: false) != 0)
			{
				MultiView1.ActiveViewIndex = 1;
			}
			else if (Operators.CompareString(((Page)this).Request["msg"], "updated", TextCompare: false) == 0)
			{
				lblmsg.Text = "Documents have been updated successfully";
			}
			else if (Operators.CompareString(((Page)this).Request["msg"], "inserted", TextCompare: false) == 0)
			{
				lblmsg.Text = "Document has been added successfully";
			}
			else if (Operators.CompareString(((Page)this).Request["msg"], "errorimage", TextCompare: false) == 0)
			{
				lblmsg.Text = "* Error! *";
			}
			else if (Operators.CompareString(((Page)this).Request["mode"], "new", TextCompare: false) == 0)
			{
				MultiView2.ActiveViewIndex = 0;
				MultiView1.ActiveViewIndex = 1;
			}
			else
			{
				MultiView2.ActiveViewIndex = 1;
				lblmsg.Text = "";
			}
		}
	}

	protected void View2_Load(object sender, EventArgs e)
	{
		if (((Control)this).Page.IsPostBack)
		{
			return;
		}
		if (Operators.CompareString(((Page)this).Request["editid"], "", TextCompare: false) != 0)
		{
			blogTableAdapter blogTableAdapter2 = new blogTableAdapter();
			blogupdate.blogDataTable blogDataTable = new blogupdate.blogDataTable();
			blogTableAdapter2.Fill(blogDataTable, ((Page)this).User.Identity.Name, Conversions.ToInteger(((Page)this).Request["editid"]));
			txtsubject.Text = blogDataTable[0].blogtitle.ToString();
			if (!blogDataTable[0].IscommentingNull())
			{
				CheckBox1.Checked = blogDataTable[0].commenting;
			}
			if (!blogDataTable[0].IsthumbNull())
			{
				Image1.ImageUrl = blogDataTable[0].thumb;
			}
			FreeTextBox1.Text = blogDataTable[0].blogtext.ToString();
			((ListControl)drcat).Items.FindByValue(blogDataTable[0].lang).Selected = true;
		}
		((Control)txtsubject).Focus();
	}

	protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
	{
	}

	private string t2h(string text)
	{
		return Strings.Replace(text, "\r", "<br>");
	}

	protected void FreeTextBox1_SaveClick(object sender, EventArgs e)
	{
		((BaseValidator)RequiredFieldValidator1).Validate();
		if (((BaseValidator)RequiredFieldValidator1).IsValid)
		{
			if (Operators.CompareString(((Page)this).Request["editid"], "", TextCompare: false) != 0)
			{
				blogTableAdapter blogTableAdapter2 = new blogTableAdapter();
				blogTableAdapter2.updateWOimg(FreeTextBox1.Text, t2h(txtsubject.Text), CheckBox1.Checked, ((ListControl)drcat).SelectedValue, Conversions.ToInteger(((Page)this).Request["editid"]));
			}
			else
			{
				blogTableAdapter blogTableAdapter3 = new blogTableAdapter();
				int num = blogTableAdapter3.InsertAndget(FreeTextBox1.Text, t2h(txtsubject.Text), "", "", CheckBox1.Checked, DateAndTime.Now, ((ListControl)drcat).SelectedValue, ((Page)this).User.Identity.Name.ToString());
				((Page)this).Response.Redirect("default.aspx?msg=inserted");
			}
		}
	}
}
