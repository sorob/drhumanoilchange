using System;
using System.Runtime.CompilerServices;
using System.Web;
using System.Web.Profile;
using System.Web.SessionState;
using System.Web.UI;
using System.Web.UI.WebControls;
using AjaxControlToolkit;

public class Services_Default2 : Page, IRequiresSessionState
{
	[AccessedThroughProperty("TA1G")]
	private TextBox _TA1G;

	[AccessedThroughProperty("MaskedEditExtender15")]
	private MaskedEditExtender _MaskedEditExtender15;

	[AccessedThroughProperty("MaskedEditValidator15")]
	private MaskedEditValidator _MaskedEditValidator15;

	[AccessedThroughProperty("TBILIRUBIN")]
	private TextBox _TBILIRUBIN;

	[AccessedThroughProperty("MaskedEditExtender16")]
	private MaskedEditExtender _MaskedEditExtender16;

	[AccessedThroughProperty("MaskedEditValidator16")]
	private MaskedEditValidator _MaskedEditValidator16;

	[AccessedThroughProperty("TPHOSPHATASE")]
	private TextBox _TPHOSPHATASE;

	[AccessedThroughProperty("MaskedEditExtender17")]
	private MaskedEditExtender _MaskedEditExtender17;

	[AccessedThroughProperty("MaskedEditValidator17")]
	private MaskedEditValidator _MaskedEditValidator17;

	[AccessedThroughProperty("TLD")]
	private TextBox _TLD;

	[AccessedThroughProperty("MaskedEditExtender18")]
	private MaskedEditExtender _MaskedEditExtender18;

	[AccessedThroughProperty("MaskedEditValidator18")]
	private MaskedEditValidator _MaskedEditValidator18;

	[AccessedThroughProperty("TAST")]
	private TextBox _TAST;

	[AccessedThroughProperty("MaskedEditExtender19")]
	private MaskedEditExtender _MaskedEditExtender19;

	[AccessedThroughProperty("MaskedEditValidator19")]
	private MaskedEditValidator _MaskedEditValidator19;

	[AccessedThroughProperty("TALT")]
	private TextBox _TALT;

	[AccessedThroughProperty("MaskedEditExtender20")]
	private MaskedEditExtender _MaskedEditExtender20;

	[AccessedThroughProperty("MaskedEditValidator20")]
	private MaskedEditValidator _MaskedEditValidator20;

	[AccessedThroughProperty("TGGT")]
	private TextBox _TGGT;

	[AccessedThroughProperty("MaskedEditExtender21")]
	private MaskedEditExtender _MaskedEditExtender21;

	[AccessedThroughProperty("MaskedEditValidator21")]
	private MaskedEditValidator _MaskedEditValidator21;

	[AccessedThroughProperty("TIRON")]
	private TextBox _TIRON;

	[AccessedThroughProperty("MaskedEditExtender22")]
	private MaskedEditExtender _MaskedEditExtender22;

	[AccessedThroughProperty("MaskedEditValidator22")]
	private MaskedEditValidator _MaskedEditValidator22;

	[AccessedThroughProperty("TCHOLESTEROL")]
	private TextBox _TCHOLESTEROL;

	[AccessedThroughProperty("MaskedEditExtender23")]
	private MaskedEditExtender _MaskedEditExtender23;

	[AccessedThroughProperty("MaskedEditValidator23")]
	private MaskedEditValidator _MaskedEditValidator23;

	[AccessedThroughProperty("TTRIGLYCERIDES")]
	private TextBox _TTRIGLYCERIDES;

	[AccessedThroughProperty("MaskedEditExtender24")]
	private MaskedEditExtender _MaskedEditExtender24;

	[AccessedThroughProperty("MaskedEditValidator24")]
	private MaskedEditValidator _MaskedEditValidator24;

	[AccessedThroughProperty("THDL")]
	private TextBox _THDL;

	[AccessedThroughProperty("MaskedEditExtender25")]
	private MaskedEditExtender _MaskedEditExtender25;

	[AccessedThroughProperty("MaskedEditValidator25")]
	private MaskedEditValidator _MaskedEditValidator25;

	[AccessedThroughProperty("TLDL")]
	private TextBox _TLDL;

	[AccessedThroughProperty("MaskedEditExtender26")]
	private MaskedEditExtender _MaskedEditExtender26;

	[AccessedThroughProperty("MaskedEditValidator26")]
	private MaskedEditValidator _MaskedEditValidator26;

	[AccessedThroughProperty("TCHO")]
	private TextBox _TCHO;

	[AccessedThroughProperty("MaskedEditExtender27")]
	private MaskedEditExtender _MaskedEditExtender27;

	[AccessedThroughProperty("MaskedEditValidator27")]
	private MaskedEditValidator _MaskedEditValidator27;

	[AccessedThroughProperty("TTHYROID")]
	private TextBox _TTHYROID;

	[AccessedThroughProperty("MaskedEditExtender28")]
	private MaskedEditExtender _MaskedEditExtender28;

	[AccessedThroughProperty("MaskedEditValidator28")]
	private MaskedEditValidator _MaskedEditValidator28;

	[AccessedThroughProperty("THORMONE")]
	private TextBox _THORMONE;

	[AccessedThroughProperty("MaskedEditExtender29")]
	private MaskedEditExtender _MaskedEditExtender29;

	[AccessedThroughProperty("MaskedEditValidator29")]
	private MaskedEditValidator _MaskedEditValidator29;

	protected virtual TextBox TA1G
	{
		get
		{
			return _TA1G;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_TA1G = value;
		}
	}

	protected virtual MaskedEditExtender MaskedEditExtender15
	{
		get
		{
			return _MaskedEditExtender15;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_MaskedEditExtender15 = value;
		}
	}

	protected virtual MaskedEditValidator MaskedEditValidator15
	{
		get
		{
			return _MaskedEditValidator15;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_MaskedEditValidator15 = value;
		}
	}

	protected virtual TextBox TBILIRUBIN
	{
		get
		{
			return _TBILIRUBIN;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_TBILIRUBIN = value;
		}
	}

	protected virtual MaskedEditExtender MaskedEditExtender16
	{
		get
		{
			return _MaskedEditExtender16;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_MaskedEditExtender16 = value;
		}
	}

	protected virtual MaskedEditValidator MaskedEditValidator16
	{
		get
		{
			return _MaskedEditValidator16;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_MaskedEditValidator16 = value;
		}
	}

	protected virtual TextBox TPHOSPHATASE
	{
		get
		{
			return _TPHOSPHATASE;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_TPHOSPHATASE = value;
		}
	}

	protected virtual MaskedEditExtender MaskedEditExtender17
	{
		get
		{
			return _MaskedEditExtender17;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_MaskedEditExtender17 = value;
		}
	}

	protected virtual MaskedEditValidator MaskedEditValidator17
	{
		get
		{
			return _MaskedEditValidator17;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_MaskedEditValidator17 = value;
		}
	}

	protected virtual TextBox TLD
	{
		get
		{
			return _TLD;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_TLD = value;
		}
	}

	protected virtual MaskedEditExtender MaskedEditExtender18
	{
		get
		{
			return _MaskedEditExtender18;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_MaskedEditExtender18 = value;
		}
	}

	protected virtual MaskedEditValidator MaskedEditValidator18
	{
		get
		{
			return _MaskedEditValidator18;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_MaskedEditValidator18 = value;
		}
	}

	protected virtual TextBox TAST
	{
		get
		{
			return _TAST;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_TAST = value;
		}
	}

	protected virtual MaskedEditExtender MaskedEditExtender19
	{
		get
		{
			return _MaskedEditExtender19;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_MaskedEditExtender19 = value;
		}
	}

	protected virtual MaskedEditValidator MaskedEditValidator19
	{
		get
		{
			return _MaskedEditValidator19;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_MaskedEditValidator19 = value;
		}
	}

	protected virtual TextBox TALT
	{
		get
		{
			return _TALT;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_TALT = value;
		}
	}

	protected virtual MaskedEditExtender MaskedEditExtender20
	{
		get
		{
			return _MaskedEditExtender20;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_MaskedEditExtender20 = value;
		}
	}

	protected virtual MaskedEditValidator MaskedEditValidator20
	{
		get
		{
			return _MaskedEditValidator20;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_MaskedEditValidator20 = value;
		}
	}

	protected virtual TextBox TGGT
	{
		get
		{
			return _TGGT;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_TGGT = value;
		}
	}

	protected virtual MaskedEditExtender MaskedEditExtender21
	{
		get
		{
			return _MaskedEditExtender21;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_MaskedEditExtender21 = value;
		}
	}

	protected virtual MaskedEditValidator MaskedEditValidator21
	{
		get
		{
			return _MaskedEditValidator21;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_MaskedEditValidator21 = value;
		}
	}

	protected virtual TextBox TIRON
	{
		get
		{
			return _TIRON;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_TIRON = value;
		}
	}

	protected virtual MaskedEditExtender MaskedEditExtender22
	{
		get
		{
			return _MaskedEditExtender22;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_MaskedEditExtender22 = value;
		}
	}

	protected virtual MaskedEditValidator MaskedEditValidator22
	{
		get
		{
			return _MaskedEditValidator22;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_MaskedEditValidator22 = value;
		}
	}

	protected virtual TextBox TCHOLESTEROL
	{
		get
		{
			return _TCHOLESTEROL;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_TCHOLESTEROL = value;
		}
	}

	protected virtual MaskedEditExtender MaskedEditExtender23
	{
		get
		{
			return _MaskedEditExtender23;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_MaskedEditExtender23 = value;
		}
	}

	protected virtual MaskedEditValidator MaskedEditValidator23
	{
		get
		{
			return _MaskedEditValidator23;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_MaskedEditValidator23 = value;
		}
	}

	protected virtual TextBox TTRIGLYCERIDES
	{
		get
		{
			return _TTRIGLYCERIDES;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_TTRIGLYCERIDES = value;
		}
	}

	protected virtual MaskedEditExtender MaskedEditExtender24
	{
		get
		{
			return _MaskedEditExtender24;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_MaskedEditExtender24 = value;
		}
	}

	protected virtual MaskedEditValidator MaskedEditValidator24
	{
		get
		{
			return _MaskedEditValidator24;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_MaskedEditValidator24 = value;
		}
	}

	protected virtual TextBox THDL
	{
		get
		{
			return _THDL;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_THDL = value;
		}
	}

	protected virtual MaskedEditExtender MaskedEditExtender25
	{
		get
		{
			return _MaskedEditExtender25;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_MaskedEditExtender25 = value;
		}
	}

	protected virtual MaskedEditValidator MaskedEditValidator25
	{
		get
		{
			return _MaskedEditValidator25;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_MaskedEditValidator25 = value;
		}
	}

	protected virtual TextBox TLDL
	{
		get
		{
			return _TLDL;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_TLDL = value;
		}
	}

	protected virtual MaskedEditExtender MaskedEditExtender26
	{
		get
		{
			return _MaskedEditExtender26;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_MaskedEditExtender26 = value;
		}
	}

	protected virtual MaskedEditValidator MaskedEditValidator26
	{
		get
		{
			return _MaskedEditValidator26;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_MaskedEditValidator26 = value;
		}
	}

	protected virtual TextBox TCHO
	{
		get
		{
			return _TCHO;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_TCHO = value;
		}
	}

	protected virtual MaskedEditExtender MaskedEditExtender27
	{
		get
		{
			return _MaskedEditExtender27;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_MaskedEditExtender27 = value;
		}
	}

	protected virtual MaskedEditValidator MaskedEditValidator27
	{
		get
		{
			return _MaskedEditValidator27;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_MaskedEditValidator27 = value;
		}
	}

	protected virtual TextBox TTHYROID
	{
		get
		{
			return _TTHYROID;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_TTHYROID = value;
		}
	}

	protected virtual MaskedEditExtender MaskedEditExtender28
	{
		get
		{
			return _MaskedEditExtender28;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_MaskedEditExtender28 = value;
		}
	}

	protected virtual MaskedEditValidator MaskedEditValidator28
	{
		get
		{
			return _MaskedEditValidator28;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_MaskedEditValidator28 = value;
		}
	}

	protected virtual TextBox THORMONE
	{
		get
		{
			return _THORMONE;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_THORMONE = value;
		}
	}

	protected virtual MaskedEditExtender MaskedEditExtender29
	{
		get
		{
			return _MaskedEditExtender29;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_MaskedEditExtender29 = value;
		}
	}

	protected virtual MaskedEditValidator MaskedEditValidator29
	{
		get
		{
			return _MaskedEditValidator29;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_MaskedEditValidator29 = value;
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

	public Services_Default2()
	{
		((Control)this).Load += Page_Load;
	}

	protected void Page_Load(object sender, EventArgs e)
	{
	}
}
