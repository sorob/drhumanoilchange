using System;
using System.IO;
using System.Net.Mail;
using System.Runtime.CompilerServices;
using System.Web;
using System.Web.Profile;
using System.Web.SessionState;
using System.Web.UI;
using System.Web.UI.WebControls;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Sample.Web.UI.Compatibility;

public class Regidter : Page, IRequiresSessionState
{
	[AccessedThroughProperty("hearlb")]
	private Label _hearlb;

	[AccessedThroughProperty("refertb")]
	private TextBox _refertb;

	[AccessedThroughProperty("AnswerRequired0")]
	private RequiredFieldValidator _AnswerRequired0;

	[AccessedThroughProperty("Tname")]
	private TextBox _Tname;

	[AccessedThroughProperty("RequiredFieldValidator1")]
	private RequiredFieldValidator _RequiredFieldValidator1;

	[AccessedThroughProperty("TsexD")]
	private DropDownList _TsexD;

	[AccessedThroughProperty("Tadd")]
	private TextBox _Tadd;

	[AccessedThroughProperty("Tcity")]
	private TextBox _Tcity;

	[AccessedThroughProperty("TstateD")]
	private DropDownList _TstateD;

	[AccessedThroughProperty("tzip")]
	private TextBox _tzip;

	[AccessedThroughProperty("RequiredFieldValidator4")]
	private RequiredFieldValidator _RequiredFieldValidator4;

	[AccessedThroughProperty("tAera")]
	private TextBox _tAera;

	[AccessedThroughProperty("Tphone1")]
	private TextBox _Tphone1;

	[AccessedThroughProperty("Tphone2")]
	private TextBox _Tphone2;

	[AccessedThroughProperty("RequiredFieldValidator2")]
	private RequiredFieldValidator _RequiredFieldValidator2;

	[AccessedThroughProperty("RequiredFieldValidator3")]
	private RequiredFieldValidator _RequiredFieldValidator3;

	[AccessedThroughProperty("Tplace")]
	private TextBox _Tplace;

	[AccessedThroughProperty("TBDmonth")]
	private DropDownList _TBDmonth;

	[AccessedThroughProperty("TBDday")]
	private DropDownList _TBDday;

	[AccessedThroughProperty("TBDyear")]
	private DropDownList _TBDyear;

	[AccessedThroughProperty("TBDhr")]
	private DropDownList _TBDhr;

	[AccessedThroughProperty("TBDmn")]
	private DropDownList _TBDmn;

	[AccessedThroughProperty("TBDpm")]
	private DropDownList _TBDpm;

	[AccessedThroughProperty("TnumberSIB")]
	private DropDownList _TnumberSIB;

	[AccessedThroughProperty("tPLACEsib")]
	private DropDownList _tPLACEsib;

	[AccessedThroughProperty("TmeriedD")]
	private DropDownList _TmeriedD;

	[AccessedThroughProperty("Tlastgrade")]
	private TextBox _Tlastgrade;

	[AccessedThroughProperty("Tocc")]
	private TextBox _Tocc;

	[AccessedThroughProperty("Tssn")]
	private TextBox _Tssn;

	[AccessedThroughProperty("T_race")]
	private TextBox _T_race;

	[AccessedThroughProperty("RequiredFieldValidator5")]
	private RequiredFieldValidator _RequiredFieldValidator5;

	[AccessedThroughProperty("Thb")]
	private TextBox _Thb;

	[AccessedThroughProperty("Theight")]
	private TextBox _Theight;

	[AccessedThroughProperty("Tweight")]
	private TextBox _Tweight;

	[AccessedThroughProperty("Teye")]
	private TextBox _Teye;

	[AccessedThroughProperty("Thair")]
	private TextBox _Thair;

	[AccessedThroughProperty("TbloodD")]
	private DropDownList _TbloodD;

	[AccessedThroughProperty("Tpsyce")]
	private DropDownList _Tpsyce;

	[AccessedThroughProperty("SqlDataSource1")]
	private SqlDataSource _SqlDataSource1;

	[AccessedThroughProperty("c1")]
	private TextBox _c1;

	[AccessedThroughProperty("o1")]
	private TextBox _o1;

	[AccessedThroughProperty("c2")]
	private TextBox _c2;

	[AccessedThroughProperty("o2")]
	private TextBox _o2;

	[AccessedThroughProperty("c3")]
	private TextBox _c3;

	[AccessedThroughProperty("o3")]
	private TextBox _o3;

	[AccessedThroughProperty("c4")]
	private TextBox _c4;

	[AccessedThroughProperty("o4")]
	private TextBox _o4;

	[AccessedThroughProperty("c5")]
	private TextBox _c5;

	[AccessedThroughProperty("o5")]
	private TextBox _o5;

	[AccessedThroughProperty("c6")]
	private TextBox _c6;

	[AccessedThroughProperty("o6")]
	private TextBox _o6;

	[AccessedThroughProperty("c7")]
	private TextBox _c7;

	[AccessedThroughProperty("o7")]
	private TextBox _o7;

	[AccessedThroughProperty("c8")]
	private TextBox _c8;

	[AccessedThroughProperty("o8")]
	private TextBox _o8;

	[AccessedThroughProperty("m1")]
	private TextBox _m1;

	[AccessedThroughProperty("l1")]
	private TextBox _l1;

	[AccessedThroughProperty("m2")]
	private TextBox _m2;

	[AccessedThroughProperty("l2")]
	private TextBox _l2;

	[AccessedThroughProperty("m3")]
	private TextBox _m3;

	[AccessedThroughProperty("l3")]
	private TextBox _l3;

	[AccessedThroughProperty("m4")]
	private TextBox _m4;

	[AccessedThroughProperty("l4")]
	private TextBox _l4;

	[AccessedThroughProperty("m5")]
	private TextBox _m5;

	[AccessedThroughProperty("l5")]
	private TextBox _l5;

	[AccessedThroughProperty("m6")]
	private TextBox _m6;

	[AccessedThroughProperty("l6")]
	private TextBox _l6;

	[AccessedThroughProperty("m7")]
	private TextBox _m7;

	[AccessedThroughProperty("l7")]
	private TextBox _l7;

	[AccessedThroughProperty("m8")]
	private TextBox _m8;

	[AccessedThroughProperty("l8")]
	private TextBox _l8;

	[AccessedThroughProperty("TextBox1")]
	private TextBox _TextBox1;

	[AccessedThroughProperty("SqlDataSource2")]
	private SqlDataSource _SqlDataSource2;

	[AccessedThroughProperty("CreateUserWizard1")]
	private CreateUserWizard _CreateUserWizard1;

	protected virtual Label hearlb
	{
		get
		{
			return _hearlb;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_hearlb = value;
		}
	}

	protected virtual TextBox refertb
	{
		get
		{
			return _refertb;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_refertb = value;
		}
	}

	protected virtual RequiredFieldValidator AnswerRequired0
	{
		get
		{
			return _AnswerRequired0;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_AnswerRequired0 = value;
		}
	}

	protected virtual TextBox Tname
	{
		get
		{
			return _Tname;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_Tname = value;
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

	protected virtual DropDownList TsexD
	{
		get
		{
			return _TsexD;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_TsexD = value;
		}
	}

	protected virtual TextBox Tadd
	{
		get
		{
			return _Tadd;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_Tadd = value;
		}
	}

	protected virtual TextBox Tcity
	{
		get
		{
			return _Tcity;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_Tcity = value;
		}
	}

	protected virtual DropDownList TstateD
	{
		get
		{
			return _TstateD;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_TstateD = value;
		}
	}

	protected virtual TextBox tzip
	{
		get
		{
			return _tzip;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_tzip = value;
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

	protected virtual TextBox tAera
	{
		get
		{
			return _tAera;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_tAera = value;
		}
	}

	protected virtual TextBox Tphone1
	{
		get
		{
			return _Tphone1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_Tphone1 = value;
		}
	}

	protected virtual TextBox Tphone2
	{
		get
		{
			return _Tphone2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_Tphone2 = value;
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

	protected virtual TextBox Tplace
	{
		get
		{
			return _Tplace;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_Tplace = value;
		}
	}

	protected virtual DropDownList TBDmonth
	{
		get
		{
			return _TBDmonth;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_TBDmonth = value;
		}
	}

	protected virtual DropDownList TBDday
	{
		get
		{
			return _TBDday;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_TBDday = value;
		}
	}

	protected virtual DropDownList TBDyear
	{
		get
		{
			return _TBDyear;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_TBDyear = value;
		}
	}

	protected virtual DropDownList TBDhr
	{
		get
		{
			return _TBDhr;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_TBDhr = value;
		}
	}

	protected virtual DropDownList TBDmn
	{
		get
		{
			return _TBDmn;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_TBDmn = value;
		}
	}

	protected virtual DropDownList TBDpm
	{
		get
		{
			return _TBDpm;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_TBDpm = value;
		}
	}

	protected virtual DropDownList TnumberSIB
	{
		get
		{
			return _TnumberSIB;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_TnumberSIB = value;
		}
	}

	protected virtual DropDownList tPLACEsib
	{
		get
		{
			return _tPLACEsib;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_tPLACEsib = value;
		}
	}

	protected virtual DropDownList TmeriedD
	{
		get
		{
			return _TmeriedD;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_TmeriedD = value;
		}
	}

	protected virtual TextBox Tlastgrade
	{
		get
		{
			return _Tlastgrade;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_Tlastgrade = value;
		}
	}

	protected virtual TextBox Tocc
	{
		get
		{
			return _Tocc;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_Tocc = value;
		}
	}

	protected virtual TextBox Tssn
	{
		get
		{
			return _Tssn;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_Tssn = value;
		}
	}

	protected virtual TextBox T_race
	{
		get
		{
			return _T_race;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_T_race = value;
		}
	}

	protected virtual RequiredFieldValidator RequiredFieldValidator5
	{
		get
		{
			return _RequiredFieldValidator5;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_RequiredFieldValidator5 = value;
		}
	}

	protected virtual TextBox Thb
	{
		get
		{
			return _Thb;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_Thb = value;
		}
	}

	protected virtual TextBox Theight
	{
		get
		{
			return _Theight;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_Theight = value;
		}
	}

	protected virtual TextBox Tweight
	{
		get
		{
			return _Tweight;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_Tweight = value;
		}
	}

	protected virtual TextBox Teye
	{
		get
		{
			return _Teye;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_Teye = value;
		}
	}

	protected virtual TextBox Thair
	{
		get
		{
			return _Thair;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_Thair = value;
		}
	}

	protected virtual DropDownList TbloodD
	{
		get
		{
			return _TbloodD;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_TbloodD = value;
		}
	}

	protected virtual DropDownList Tpsyce
	{
		get
		{
			return _Tpsyce;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_Tpsyce = value;
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

	protected virtual TextBox c1
	{
		get
		{
			return _c1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_c1 = value;
		}
	}

	protected virtual TextBox o1
	{
		get
		{
			return _o1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_o1 = value;
		}
	}

	protected virtual TextBox c2
	{
		get
		{
			return _c2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_c2 = value;
		}
	}

	protected virtual TextBox o2
	{
		get
		{
			return _o2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_o2 = value;
		}
	}

	protected virtual TextBox c3
	{
		get
		{
			return _c3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_c3 = value;
		}
	}

	protected virtual TextBox o3
	{
		get
		{
			return _o3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_o3 = value;
		}
	}

	protected virtual TextBox c4
	{
		get
		{
			return _c4;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_c4 = value;
		}
	}

	protected virtual TextBox o4
	{
		get
		{
			return _o4;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_o4 = value;
		}
	}

	protected virtual TextBox c5
	{
		get
		{
			return _c5;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_c5 = value;
		}
	}

	protected virtual TextBox o5
	{
		get
		{
			return _o5;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_o5 = value;
		}
	}

	protected virtual TextBox c6
	{
		get
		{
			return _c6;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_c6 = value;
		}
	}

	protected virtual TextBox o6
	{
		get
		{
			return _o6;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_o6 = value;
		}
	}

	protected virtual TextBox c7
	{
		get
		{
			return _c7;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_c7 = value;
		}
	}

	protected virtual TextBox o7
	{
		get
		{
			return _o7;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_o7 = value;
		}
	}

	protected virtual TextBox c8
	{
		get
		{
			return _c8;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_c8 = value;
		}
	}

	protected virtual TextBox o8
	{
		get
		{
			return _o8;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_o8 = value;
		}
	}

	protected virtual TextBox m1
	{
		get
		{
			return _m1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_m1 = value;
		}
	}

	protected virtual TextBox l1
	{
		get
		{
			return _l1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_l1 = value;
		}
	}

	protected virtual TextBox m2
	{
		get
		{
			return _m2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_m2 = value;
		}
	}

	protected virtual TextBox l2
	{
		get
		{
			return _l2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_l2 = value;
		}
	}

	protected virtual TextBox m3
	{
		get
		{
			return _m3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_m3 = value;
		}
	}

	protected virtual TextBox l3
	{
		get
		{
			return _l3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_l3 = value;
		}
	}

	protected virtual TextBox m4
	{
		get
		{
			return _m4;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_m4 = value;
		}
	}

	protected virtual TextBox l4
	{
		get
		{
			return _l4;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_l4 = value;
		}
	}

	protected virtual TextBox m5
	{
		get
		{
			return _m5;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_m5 = value;
		}
	}

	protected virtual TextBox l5
	{
		get
		{
			return _l5;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_l5 = value;
		}
	}

	protected virtual TextBox m6
	{
		get
		{
			return _m6;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_m6 = value;
		}
	}

	protected virtual TextBox l6
	{
		get
		{
			return _l6;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_l6 = value;
		}
	}

	protected virtual TextBox m7
	{
		get
		{
			return _m7;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_m7 = value;
		}
	}

	protected virtual TextBox l7
	{
		get
		{
			return _l7;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_l7 = value;
		}
	}

	protected virtual TextBox m8
	{
		get
		{
			return _m8;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_m8 = value;
		}
	}

	protected virtual TextBox l8
	{
		get
		{
			return _l8;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_l8 = value;
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

	protected virtual CreateUserWizard CreateUserWizard1
	{
		get
		{
			return _CreateUserWizard1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected Obj, but got Unknown
			//IL_0024: Unknown result type (might be due to invalid IL or missing references)
			//IL_002a: Expected Obj, but got Unknown
			WizardNavigationEventHandler val = CreateUserWizard1_FinishButtonClick;
			EventHandler eventHandler = CreateUserWizard1_CreatedUser;
			WizardNavigationEventHandler val2 = CreateUserWizard1_NextButtonClick;
			EventHandler eventHandler2 = CreateUserWizard1_Load;
			if (_CreateUserWizard1 != null)
			{
				((Wizard)_CreateUserWizard1).FinishButtonClick -= val;
				_CreateUserWizard1.CreatedUser -= eventHandler;
				((Wizard)_CreateUserWizard1).NextButtonClick -= val2;
				((Control)_CreateUserWizard1).Load -= eventHandler2;
			}
			_CreateUserWizard1 = value;
			if (_CreateUserWizard1 != null)
			{
				((Wizard)_CreateUserWizard1).FinishButtonClick += val;
				_CreateUserWizard1.CreatedUser += eventHandler;
				((Wizard)_CreateUserWizard1).NextButtonClick += val2;
				((Control)_CreateUserWizard1).Load += eventHandler2;
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

	public Regidter()
	{
		((Control)this).Load += Page_Load;
	}

	private string fixlen(string instr, int mlenght)
	{
		string text = instr;
		for (int i = 1; i <= mlenght; i = checked(i + 1))
		{
			if (mlenght <= text.Length)
			{
				break;
			}
			text = "0" + text;
		}
		return text;
	}

	private void addnum(int num, ref DropDownList dr)
	{
		int num2 = num;
		for (int i = 1; i <= num2; i = checked(i + 1))
		{
			((ListControl)dr).Items.Add(fixlen(Conversions.ToString(i), num.ToString().Length));
		}
	}

	private string getScode()
	{
		DateTime dateTime = new DateTime(Conversions.ToInteger(((ListControl)TBDyear).SelectedValue), Conversions.ToInteger(((ListControl)TBDmonth).SelectedValue), Conversions.ToInteger(((ListControl)TBDday).SelectedValue), Conversions.ToInteger(((ListControl)TBDhr).SelectedValue), Conversions.ToInteger(((ListControl)TBDmn).SelectedValue), 0);
		if (TBDpm.SelectedIndex == 1)
		{
			dateTime.AddHours(Conversions.ToDouble(((ListControl)TBDhr).SelectedValue)).AddHours(12.0);
		}
		string text = ((checked(DateAndTime.Now.Year - dateTime.Year) <= 12) ? "C" : "A");
		string text2 = ((ListControl)TsexD).SelectedValue.Substring(0, 1) + text + upsidedown(tAera.Text.Trim()) + Strings.Replace(dateTime.AddMonths(3).AddYears(-1).ToShortDateString(), "/", "") + upsidedown(tzip.Text.Trim());
		return text2.ToUpper();
	}

	private string upsidedown(string str)
	{
		int length = str.Length;
		checked
		{
			string text = default;
			for (int i = 1; i <= length; i++)
			{
				text += Strings.Mid(str, str.Length - i + 1, 1);
			}
			return text;
		}
	}

	private bool cb(TextBox tb)
	{
		if (Operators.CompareString(tb.Text, "", TextCompare: false) != 0)
		{
			return true;
		}
		return false;
	}

	protected void CreateUserWizard1_FinishButtonClick(object sender, WizardNavigationEventArgs e)
	{
		try
		{
			SqlDataSource2.InsertParameters["UserName"].DefaultValue = CreateUserWizard1.UserName;
			SqlDataSource2.InsertParameters["comment"].DefaultValue = Strings.Replace(TextBox1.Text, "\r", "<br>");
			SqlDataSource2.Insert();
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			((Page)this).Response.Write(ex2.Message);
			ProjectData.ClearProjectError();
		}
	}

	protected void CreateUserWizard1_Load(object sender, EventArgs e)
	{
		DropDownList dr = TBDday;
		addnum(31, ref dr);
		TBDday = dr;
		dr = TBDmonth;
		addnum(12, ref dr);
		TBDmonth = dr;
		dr = TBDhr;
		addnum(12, ref dr);
		TBDhr = dr;
		dr = TBDmn;
		addnum(59, ref dr);
		TBDmn = dr;
		int num = 1900;
		do
		{
			((ListControl)TBDyear).Items.Add(Conversions.ToString(num));
			num = checked(num + 1);
		}
		while (num <= 2008);
	}

	protected void CreateUserWizard1_NextButtonClick(object sender, WizardNavigationEventArgs e)
	{
		if (((Control)this).Page.IsValid & (e.CurrentStepIndex == 1))
		{
			DateTime dateTime = new DateTime(Conversions.ToInteger(((ListControl)TBDyear).SelectedValue), Conversions.ToInteger(((ListControl)TBDmonth).SelectedValue), Conversions.ToInteger(((ListControl)TBDday).SelectedValue), Conversions.ToInteger(((ListControl)TBDhr).SelectedValue), Conversions.ToInteger(((ListControl)TBDmn).SelectedValue), 0);
			if (TBDpm.SelectedIndex == 1)
			{
				dateTime.AddHours(Conversions.ToDouble(((ListControl)TBDhr).SelectedValue)).AddHours(12.0);
			}
			SqlDataSource1.InsertParameters["RegisterDate"].DefaultValue = Conversions.ToString(DateAndTime.Now);
			if (TmeriedD.SelectedIndex == 1)
			{
				SqlDataSource1.InsertParameters["Maried"].DefaultValue = bool.FalseString;
			}
			else
			{
				SqlDataSource1.InsertParameters["Maried"].DefaultValue = bool.TrueString;
			}
			SqlDataSource1.InsertParameters["phonenumber"].DefaultValue = Tphone1.Text + Tphone2.Text;
			if (TmeriedD.SelectedIndex == 0)
			{
				SqlDataSource1.InsertParameters["PsychologicallyStress"].DefaultValue = bool.FalseString;
			}
			else
			{
				SqlDataSource1.InsertParameters["Maried"].DefaultValue = bool.TrueString;
			}
			SqlDataSource1.InsertParameters["UserName"].DefaultValue = CreateUserWizard1.UserName;
			SqlDataSource1.InsertParameters["Code"].DefaultValue = getScode();
			SqlDataSource1.InsertParameters["birthdate"].DefaultValue = Conversions.ToString(dateTime);
			SqlDataSource1.InsertParameters["Labnum"].DefaultValue = Conversions.ToString(0);
			SqlDataSource1.InsertParameters["referral"].DefaultValue = refertb.Text;
			SqlDataSource1.Insert();
		}
	}

	private string getbody(string nm)
	{
		string path = ((Page)this).Server.MapPath("cnf.htm");
		StreamReader streamReader = File.OpenText(path);
		string expression = streamReader.ReadToEnd();
		streamReader.Close();
		return Strings.Replace(expression, "--link--", nm);
	}

	protected void CreateUserWizard1_CreatedUser(object sender, EventArgs e)
	{
		try
		{
			string email = CreateUserWizard1.Email;
			MailMessage mailMessage = new MailMessage();
			MailAddress mailAddress = new MailAddress("Support@HumanOilChange.com");
			MailAddress item = new MailAddress(email);
			mailMessage.To.Add(item);
			mailMessage.From = mailAddress;
			mailMessage.Bcc.Add("sibabi@gmail.com");
			mailMessage.Bcc.Add("dralaguirre2@aol.com");
			mailMessage.Bcc.Add("sibabi@gmail.com");
			mailMessage.Subject = "Comfirm Registeration at Mental Stress Tester";
			mailMessage.Body = "reffered by : " + refertb.Text + "<br>" + getbody(CreateUserWizard1.UserName);
			((Control)refertb).Visible = false;
			((Control)hearlb).Visible = false;
			mailMessage.IsBodyHtml = true;
			SmtpClient smtpClient = new SmtpClient();
			smtpClient.Send(mailMessage);
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			((Page)this).Response.Write(ex2.ToString());
			ProjectData.ClearProjectError();
		}
	}

	protected void Page_Load(object sender, EventArgs e)
	{
	}
}
