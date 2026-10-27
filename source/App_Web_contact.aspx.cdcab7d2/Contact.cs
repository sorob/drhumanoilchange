using System;
using System.Net.Mail;
using System.Runtime.CompilerServices;
using System.Web;
using System.Web.Profile;
using System.Web.SessionState;
using System.Web.UI;
using System.Web.UI.WebControls;
using Microsoft.VisualBasic.CompilerServices;
using Sample.Web.UI.Compatibility;

public class Contact : Page, IRequiresSessionState
{
	[AccessedThroughProperty("ValidationSummary1")]
	private ValidationSummary _ValidationSummary1;

	[AccessedThroughProperty("Label1")]
	private Label _Label1;

	[AccessedThroughProperty("DropDownList1")]
	private DropDownList _DropDownList1;

	[AccessedThroughProperty("TextBox1")]
	private TextBox _TextBox1;

	[AccessedThroughProperty("RequiredFieldValidator2")]
	private RequiredFieldValidator _RequiredFieldValidator2;

	[AccessedThroughProperty("TextBox4")]
	private TextBox _TextBox4;

	[AccessedThroughProperty("RequiredFieldValidator3")]
	private RequiredFieldValidator _RequiredFieldValidator3;

	[AccessedThroughProperty("CustomValidator1")]
	private CustomValidator _CustomValidator1;

	[AccessedThroughProperty("TextBox2")]
	private TextBox _TextBox2;

	[AccessedThroughProperty("RequiredFieldValidator1")]
	private RequiredFieldValidator _RequiredFieldValidator1;

	[AccessedThroughProperty("TextBox3")]
	private TextBox _TextBox3;

	[AccessedThroughProperty("RequiredFieldValidator4")]
	private RequiredFieldValidator _RequiredFieldValidator4;

	[AccessedThroughProperty("Button1")]
	private Button _Button1;

	[AccessedThroughProperty("View1")]
	private View _View1;

	[AccessedThroughProperty("View2")]
	private View _View2;

	[AccessedThroughProperty("MultiView1")]
	private MultiView _MultiView1;

	protected virtual ValidationSummary ValidationSummary1
	{
		get
		{
			return _ValidationSummary1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ValidationSummary1 = value;
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

	protected virtual DropDownList DropDownList1
	{
		get
		{
			return _DropDownList1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_DropDownList1 = value;
		}
	}

	protected virtual TextBox TextBox1
	{
		get
		{
			return _TextBox1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_TextBox1 = value;
		}
	}

	protected virtual RequiredFieldValidator RequiredFieldValidator2
	{
		get
		{
			return _RequiredFieldValidator2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_RequiredFieldValidator2 = value;
		}
	}

	protected virtual TextBox TextBox4
	{
		get
		{
			return _TextBox4;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_TextBox4 = value;
		}
	}

	protected virtual RequiredFieldValidator RequiredFieldValidator3
	{
		get
		{
			return _RequiredFieldValidator3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_RequiredFieldValidator3 = value;
		}
	}

	protected virtual CustomValidator CustomValidator1
	{
		get
		{
			return _CustomValidator1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_CustomValidator1 = value;
		}
	}

	protected virtual TextBox TextBox2
	{
		get
		{
			return _TextBox2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_TextBox2 = value;
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

	protected virtual TextBox TextBox3
	{
		get
		{
			return _TextBox3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_TextBox3 = value;
		}
	}

	protected virtual RequiredFieldValidator RequiredFieldValidator4
	{
		get
		{
			return _RequiredFieldValidator4;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_RequiredFieldValidator4 = value;
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
			EventHandler eventHandler = Button1_Click;
			if (_Button1 != null)
			{
				_Button1.Click -= eventHandler;
			}
			_Button1 = value;
			if (_Button1 != null)
			{
				_Button1.Click += eventHandler;
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

	protected virtual View View2
	{
		get
		{
			return _View2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_View2 = value;
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
			EventHandler eventHandler = MultiView1_ActiveViewChanged;
			if (_MultiView1 != null)
			{
				_MultiView1.ActiveViewChanged -= eventHandler;
			}
			_MultiView1 = value;
			if (_MultiView1 != null)
			{
				_MultiView1.ActiveViewChanged += eventHandler;
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

	public Contact()
	{
		((Control)this).Load += Page_Load;
	}

	protected void Button1_Click(object sender, EventArgs e)
	{
		if (!((Control)this).Page.IsValid)
		{
			return;
		}
		try
		{
			MailMessage mailMessage = new MailMessage();
			MailAddress mailAddress = new MailAddress("Support@HumanOilChange.com");
			string address;
			if (Operators.CompareString(((ListControl)DropDownList1).SelectedValue.ToUpper(), "MANAGEMENT", TextCompare: false) == 0)
			{
				address = "dralaguirre2@aol.com";
			}
			else
			{
				address = "dralaguirre2@aol.com";
				mailMessage.Bcc.Add("sibabi@gmail.com");
			}
			mailMessage.From = mailAddress;
			MailAddress item = new MailAddress(address);
			mailMessage.To.Add(item);
			mailMessage.Bcc.Add("sibabi@gmail.com");
			MailAddress replyTo = new MailAddress(TextBox4.Text);
			mailMessage.ReplyTo = replyTo;
			mailMessage.Subject = "Contact to " + ((ListControl)DropDownList1).SelectedValue + " : " + TextBox2.Text;
			mailMessage.Body = "Name: " + TextBox1.Text + "\r\nEmail Address: " + TextBox4.Text + "\r\n" + TextBox3.Text;
			mailMessage.IsBodyHtml = false;
			SmtpClient smtpClient = new SmtpClient();
			smtpClient.Send(mailMessage);
			MultiView1.SetActiveView(View2);
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			Label1.Text = ex2.Message;
			ProjectData.ClearProjectError();
		}
	}

	protected void MultiView1_ActiveViewChanged(object sender, EventArgs e)
	{
	}

	protected void Page_Load(object sender, EventArgs e)
	{
	}
}
