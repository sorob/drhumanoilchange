using System;
using System.Diagnostics;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Web;
using System.Web.Compilation;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ASP;

[CompilerGlobalScope]
public class admin_watview_aspx : Admin_WatView
{
	private static bool __initialized;

	private static object __fileDependencies;

	protected override bool SupportAutoEvents => false;

	[DebuggerNonUserCode]
	public admin_watview_aspx()
	{
		((TemplateControl)this).AppRelativeVirtualPath = "~/Admin/WatView.aspx";
		if (!__initialized)
		{
			__fileDependencies = RuntimeHelpers.GetObjectValue(((Page)this).GetWrappedFileDependencies(new string[4] { "~/Admin/WatView.aspx", "~/master1.master", "~/master1.master.vb", "~/Admin/WatView.aspx.vb" }));
			__initialized = true;
		}
		((Page)this).Server.ScriptTimeout = 30000000;
	}

	[DebuggerNonUserCode]
	private BoundField __BuildControl__control3()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		BoundField val = new BoundField();
		val.DataField = "choice_word_nm";
		val.HeaderText = "choice_word_nm";
		((DataControlField)val).SortExpression = "choice_word_nm";
		return val;
	}

	[DebuggerNonUserCode]
	private BoundField __BuildControl__control4()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		BoundField val = new BoundField();
		val.DataField = "Score";
		val.HeaderText = "Score";
		((DataControlField)val).SortExpression = "Score";
		return val;
	}

	[DebuggerNonUserCode]
	private BoundField __BuildControl__control5()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		BoundField val = new BoundField();
		val.DataField = "word_nm";
		val.HeaderText = "word_nm";
		((DataControlField)val).SortExpression = "word_nm";
		return val;
	}

	[DebuggerNonUserCode]
	private void __BuildControl__control2(DataControlFieldCollection __ctrl)
	{
		BoundField val = __BuildControl__control3();
		__ctrl.Add((DataControlField)(object)val);
		BoundField val2 = __BuildControl__control4();
		__ctrl.Add((DataControlField)(object)val2);
		BoundField val3 = __BuildControl__control5();
		__ctrl.Add((DataControlField)(object)val3);
	}

	[DebuggerNonUserCode]
	private GridView __BuildControlGridView1()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		GridView val = (GridView1 = new GridView());
		((Control)val).TemplateControl = (TemplateControl)(object)this;
		((Control)val).ApplyStyleSheetSkin((Page)(object)this);
		((Control)val).ID = "GridView1";
		val.AutoGenerateColumns = false;
		((DataBoundControl)val).DataSourceID = "SqlDataSource1";
		val.EmptyDataText = "There are no data records to display.";
		__BuildControl__control2(val.Columns);
		return val;
	}

	[DebuggerNonUserCode]
	private Parameter __BuildControl__control7()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Parameter val = new Parameter();
		val.Name = "tid";
		return val;
	}

	[DebuggerNonUserCode]
	private void __BuildControl__control6(ParameterCollection __ctrl)
	{
		Parameter val = __BuildControl__control7();
		__ctrl.Add(val);
	}

	[DebuggerNonUserCode]
	private SqlDataSource __BuildControlSqlDataSource1()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		SqlDataSource val = (SqlDataSource1 = new SqlDataSource());
		((Control)val).TemplateControl = (TemplateControl)(object)this;
		((Control)val).ID = "SqlDataSource1";
		val.SelectCommand = "SELECT choiceWord.choice_word_nm, choiceWord.Score, mainWord.word_nm FROM testWordInstance INNER JOIN mainWord ON testWordInstance.main_word_id = mainWord.word_id INNER JOIN choiceWord ON mainWord.word_id = choiceWord.word_id AND testWordInstance.answerd_word_id = choiceWord.choice_word_id WHERE (testWordInstance.test_instance_id = @tid) AND (choiceWord.Score = 1) ORDER BY choiceWord.Score DESC";
		__BuildControl__control6(val.SelectParameters);
		val.ConnectionString = Convert.ToString(ConnectionStringsExpressionBuilder.GetConnectionString("ConnectionString"), CultureInfo.CurrentCulture);
		val.ProviderName = Convert.ToString(ConnectionStringsExpressionBuilder.GetConnectionStringProviderName("LocalSqlServer"), CultureInfo.CurrentCulture);
		return val;
	}

	[DebuggerNonUserCode]
	private Label __BuildControlLabel1()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Label val = (Label1 = new Label());
		((Control)val).TemplateControl = (TemplateControl)(object)this;
		((Control)val).ApplyStyleSheetSkin((Page)(object)this);
		((Control)val).ID = "Label1";
		return val;
	}

	[DebuggerNonUserCode]
	private Parameter __BuildControl__control9()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Parameter val = new Parameter();
		val.Name = "UserName";
		val.Type = TypeCode.String;
		return val;
	}

	[DebuggerNonUserCode]
	private void __BuildControl__control8(ParameterCollection __ctrl)
	{
		Parameter val = __BuildControl__control9();
		__ctrl.Add(val);
	}

	[DebuggerNonUserCode]
	private Parameter __BuildControl__control11()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Parameter val = new Parameter();
		val.Name = "Name";
		val.Type = TypeCode.String;
		return val;
	}

	[DebuggerNonUserCode]
	private Parameter __BuildControl__control12()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Parameter val = new Parameter();
		val.Name = "sex";
		val.Type = TypeCode.String;
		return val;
	}

	[DebuggerNonUserCode]
	private Parameter __BuildControl__control13()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Parameter val = new Parameter();
		val.Name = "RegisterDate";
		val.Type = TypeCode.DateTime;
		return val;
	}

	[DebuggerNonUserCode]
	private Parameter __BuildControl__control14()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Parameter val = new Parameter();
		val.Name = "Address";
		val.Type = TypeCode.String;
		return val;
	}

	[DebuggerNonUserCode]
	private Parameter __BuildControl__control15()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Parameter val = new Parameter();
		val.Name = "Maried";
		val.Type = TypeCode.Boolean;
		return val;
	}

	[DebuggerNonUserCode]
	private Parameter __BuildControl__control16()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Parameter val = new Parameter();
		val.Name = "NumberofChildren";
		val.Type = TypeCode.Int16;
		return val;
	}

	[DebuggerNonUserCode]
	private Parameter __BuildControl__control17()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Parameter val = new Parameter();
		val.Name = "Sybling";
		val.Type = TypeCode.String;
		return val;
	}

	[DebuggerNonUserCode]
	private Parameter __BuildControl__control18()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Parameter val = new Parameter();
		val.Name = "City";
		val.Type = TypeCode.String;
		return val;
	}

	[DebuggerNonUserCode]
	private Parameter __BuildControl__control19()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Parameter val = new Parameter();
		val.Name = "State";
		val.Type = TypeCode.String;
		return val;
	}

	[DebuggerNonUserCode]
	private Parameter __BuildControl__control20()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Parameter val = new Parameter();
		val.Name = "Zipcode";
		val.Type = TypeCode.String;
		return val;
	}

	[DebuggerNonUserCode]
	private Parameter __BuildControl__control21()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Parameter val = new Parameter();
		val.Name = "areacode";
		val.Type = TypeCode.Int32;
		return val;
	}

	[DebuggerNonUserCode]
	private Parameter __BuildControl__control22()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Parameter val = new Parameter();
		val.Name = "phonenumber";
		val.Type = TypeCode.Int32;
		return val;
	}

	[DebuggerNonUserCode]
	private Parameter __BuildControl__control23()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Parameter val = new Parameter();
		val.Name = "occupation";
		val.Type = TypeCode.String;
		return val;
	}

	[DebuggerNonUserCode]
	private Parameter __BuildControl__control24()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Parameter val = new Parameter();
		val.Name = "Habbies";
		val.Type = TypeCode.String;
		return val;
	}

	[DebuggerNonUserCode]
	private Parameter __BuildControl__control25()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Parameter val = new Parameter();
		val.Name = "birthdate";
		val.Type = TypeCode.DateTime;
		return val;
	}

	[DebuggerNonUserCode]
	private Parameter __BuildControl__control26()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Parameter val = new Parameter();
		val.Name = "birthplace";
		val.Type = TypeCode.String;
		return val;
	}

	[DebuggerNonUserCode]
	private Parameter __BuildControl__control27()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Parameter val = new Parameter();
		val.Name = "lastgrad";
		val.Type = TypeCode.String;
		return val;
	}

	[DebuggerNonUserCode]
	private Parameter __BuildControl__control28()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Parameter val = new Parameter();
		val.Name = "SSN";
		val.Type = TypeCode.String;
		return val;
	}

	[DebuggerNonUserCode]
	private Parameter __BuildControl__control29()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Parameter val = new Parameter();
		val.Name = "Labnum";
		val.Type = TypeCode.Int32;
		return val;
	}

	[DebuggerNonUserCode]
	private Parameter __BuildControl__control30()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Parameter val = new Parameter();
		val.Name = "PsychologicallyStress";
		val.Type = TypeCode.Boolean;
		return val;
	}

	[DebuggerNonUserCode]
	private Parameter __BuildControl__control31()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Parameter val = new Parameter();
		val.Name = "height";
		val.Type = TypeCode.String;
		return val;
	}

	[DebuggerNonUserCode]
	private Parameter __BuildControl__control32()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Parameter val = new Parameter();
		val.Name = "weight";
		val.Type = TypeCode.String;
		return val;
	}

	[DebuggerNonUserCode]
	private Parameter __BuildControl__control33()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Parameter val = new Parameter();
		val.Name = "eyecolor";
		val.Type = TypeCode.String;
		return val;
	}

	[DebuggerNonUserCode]
	private Parameter __BuildControl__control34()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Parameter val = new Parameter();
		val.Name = "haircolor";
		val.Type = TypeCode.String;
		return val;
	}

	[DebuggerNonUserCode]
	private Parameter __BuildControl__control35()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Parameter val = new Parameter();
		val.Name = "bloodtype";
		val.Type = TypeCode.String;
		return val;
	}

	[DebuggerNonUserCode]
	private Parameter __BuildControl__control36()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Parameter val = new Parameter();
		val.Name = "Code";
		val.Type = TypeCode.String;
		return val;
	}

	[DebuggerNonUserCode]
	private Parameter __BuildControl__control37()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Parameter val = new Parameter();
		val.Name = "UserName";
		val.Type = TypeCode.String;
		return val;
	}

	[DebuggerNonUserCode]
	private void __BuildControl__control10(ParameterCollection __ctrl)
	{
		Parameter val = __BuildControl__control11();
		__ctrl.Add(val);
		Parameter val2 = __BuildControl__control12();
		__ctrl.Add(val2);
		Parameter val3 = __BuildControl__control13();
		__ctrl.Add(val3);
		Parameter val4 = __BuildControl__control14();
		__ctrl.Add(val4);
		Parameter val5 = __BuildControl__control15();
		__ctrl.Add(val5);
		Parameter val6 = __BuildControl__control16();
		__ctrl.Add(val6);
		Parameter val7 = __BuildControl__control17();
		__ctrl.Add(val7);
		Parameter val8 = __BuildControl__control18();
		__ctrl.Add(val8);
		Parameter val9 = __BuildControl__control19();
		__ctrl.Add(val9);
		Parameter val10 = __BuildControl__control20();
		__ctrl.Add(val10);
		Parameter val11 = __BuildControl__control21();
		__ctrl.Add(val11);
		Parameter val12 = __BuildControl__control22();
		__ctrl.Add(val12);
		Parameter val13 = __BuildControl__control23();
		__ctrl.Add(val13);
		Parameter val14 = __BuildControl__control24();
		__ctrl.Add(val14);
		Parameter val15 = __BuildControl__control25();
		__ctrl.Add(val15);
		Parameter val16 = __BuildControl__control26();
		__ctrl.Add(val16);
		Parameter val17 = __BuildControl__control27();
		__ctrl.Add(val17);
		Parameter val18 = __BuildControl__control28();
		__ctrl.Add(val18);
		Parameter val19 = __BuildControl__control29();
		__ctrl.Add(val19);
		Parameter val20 = __BuildControl__control30();
		__ctrl.Add(val20);
		Parameter val21 = __BuildControl__control31();
		__ctrl.Add(val21);
		Parameter val22 = __BuildControl__control32();
		__ctrl.Add(val22);
		Parameter val23 = __BuildControl__control33();
		__ctrl.Add(val23);
		Parameter val24 = __BuildControl__control34();
		__ctrl.Add(val24);
		Parameter val25 = __BuildControl__control35();
		__ctrl.Add(val25);
		Parameter val26 = __BuildControl__control36();
		__ctrl.Add(val26);
		Parameter val27 = __BuildControl__control37();
		__ctrl.Add(val27);
	}

	[DebuggerNonUserCode]
	private QueryStringParameter __BuildControl__control39()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		QueryStringParameter val = new QueryStringParameter();
		((Parameter)val).Name = "un";
		val.QueryStringField = "un";
		return val;
	}

	[DebuggerNonUserCode]
	private void __BuildControl__control38(ParameterCollection __ctrl)
	{
		QueryStringParameter val = __BuildControl__control39();
		__ctrl.Add((Parameter)(object)val);
	}

	[DebuggerNonUserCode]
	private Parameter __BuildControl__control41()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Parameter val = new Parameter();
		val.Name = "Name";
		val.Type = TypeCode.String;
		return val;
	}

	[DebuggerNonUserCode]
	private Parameter __BuildControl__control42()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Parameter val = new Parameter();
		val.Name = "sex";
		val.Type = TypeCode.String;
		return val;
	}

	[DebuggerNonUserCode]
	private Parameter __BuildControl__control43()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Parameter val = new Parameter();
		val.Name = "RegisterDate";
		val.Type = TypeCode.DateTime;
		return val;
	}

	[DebuggerNonUserCode]
	private Parameter __BuildControl__control44()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Parameter val = new Parameter();
		val.Name = "Address";
		val.Type = TypeCode.String;
		return val;
	}

	[DebuggerNonUserCode]
	private Parameter __BuildControl__control45()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Parameter val = new Parameter();
		val.Name = "Maried";
		val.Type = TypeCode.Boolean;
		return val;
	}

	[DebuggerNonUserCode]
	private Parameter __BuildControl__control46()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Parameter val = new Parameter();
		val.Name = "NumberofChildren";
		val.Type = TypeCode.Int16;
		return val;
	}

	[DebuggerNonUserCode]
	private Parameter __BuildControl__control47()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Parameter val = new Parameter();
		val.Name = "Sybling";
		val.Type = TypeCode.String;
		return val;
	}

	[DebuggerNonUserCode]
	private Parameter __BuildControl__control48()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Parameter val = new Parameter();
		val.Name = "City";
		val.Type = TypeCode.String;
		return val;
	}

	[DebuggerNonUserCode]
	private Parameter __BuildControl__control49()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Parameter val = new Parameter();
		val.Name = "State";
		val.Type = TypeCode.String;
		return val;
	}

	[DebuggerNonUserCode]
	private Parameter __BuildControl__control50()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Parameter val = new Parameter();
		val.Name = "Zipcode";
		val.Type = TypeCode.String;
		return val;
	}

	[DebuggerNonUserCode]
	private Parameter __BuildControl__control51()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Parameter val = new Parameter();
		val.Name = "areacode";
		val.Type = TypeCode.Int32;
		return val;
	}

	[DebuggerNonUserCode]
	private Parameter __BuildControl__control52()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Parameter val = new Parameter();
		val.Name = "phonenumber";
		val.Type = TypeCode.Int32;
		return val;
	}

	[DebuggerNonUserCode]
	private Parameter __BuildControl__control53()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Parameter val = new Parameter();
		val.Name = "occupation";
		val.Type = TypeCode.String;
		return val;
	}

	[DebuggerNonUserCode]
	private Parameter __BuildControl__control54()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Parameter val = new Parameter();
		val.Name = "Habbies";
		val.Type = TypeCode.String;
		return val;
	}

	[DebuggerNonUserCode]
	private Parameter __BuildControl__control55()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Parameter val = new Parameter();
		val.Name = "birthdate";
		val.Type = TypeCode.DateTime;
		return val;
	}

	[DebuggerNonUserCode]
	private Parameter __BuildControl__control56()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Parameter val = new Parameter();
		val.Name = "birthplace";
		val.Type = TypeCode.String;
		return val;
	}

	[DebuggerNonUserCode]
	private Parameter __BuildControl__control57()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Parameter val = new Parameter();
		val.Name = "lastgrad";
		val.Type = TypeCode.String;
		return val;
	}

	[DebuggerNonUserCode]
	private Parameter __BuildControl__control58()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Parameter val = new Parameter();
		val.Name = "SSN";
		val.Type = TypeCode.String;
		return val;
	}

	[DebuggerNonUserCode]
	private Parameter __BuildControl__control59()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Parameter val = new Parameter();
		val.Name = "Labnum";
		val.Type = TypeCode.Int32;
		return val;
	}

	[DebuggerNonUserCode]
	private Parameter __BuildControl__control60()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Parameter val = new Parameter();
		val.Name = "PsychologicallyStress";
		val.Type = TypeCode.Boolean;
		return val;
	}

	[DebuggerNonUserCode]
	private Parameter __BuildControl__control61()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Parameter val = new Parameter();
		val.Name = "height";
		val.Type = TypeCode.String;
		return val;
	}

	[DebuggerNonUserCode]
	private Parameter __BuildControl__control62()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Parameter val = new Parameter();
		val.Name = "weight";
		val.Type = TypeCode.String;
		return val;
	}

	[DebuggerNonUserCode]
	private Parameter __BuildControl__control63()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Parameter val = new Parameter();
		val.Name = "eyecolor";
		val.Type = TypeCode.String;
		return val;
	}

	[DebuggerNonUserCode]
	private Parameter __BuildControl__control64()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Parameter val = new Parameter();
		val.Name = "haircolor";
		val.Type = TypeCode.String;
		return val;
	}

	[DebuggerNonUserCode]
	private Parameter __BuildControl__control65()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Parameter val = new Parameter();
		val.Name = "bloodtype";
		val.Type = TypeCode.String;
		return val;
	}

	[DebuggerNonUserCode]
	private Parameter __BuildControl__control66()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Parameter val = new Parameter();
		val.Name = "UserName";
		val.Type = TypeCode.String;
		return val;
	}

	[DebuggerNonUserCode]
	private Parameter __BuildControl__control67()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Parameter val = new Parameter();
		val.Name = "Code";
		val.Type = TypeCode.String;
		return val;
	}

	[DebuggerNonUserCode]
	private void __BuildControl__control40(ParameterCollection __ctrl)
	{
		Parameter val = __BuildControl__control41();
		__ctrl.Add(val);
		Parameter val2 = __BuildControl__control42();
		__ctrl.Add(val2);
		Parameter val3 = __BuildControl__control43();
		__ctrl.Add(val3);
		Parameter val4 = __BuildControl__control44();
		__ctrl.Add(val4);
		Parameter val5 = __BuildControl__control45();
		__ctrl.Add(val5);
		Parameter val6 = __BuildControl__control46();
		__ctrl.Add(val6);
		Parameter val7 = __BuildControl__control47();
		__ctrl.Add(val7);
		Parameter val8 = __BuildControl__control48();
		__ctrl.Add(val8);
		Parameter val9 = __BuildControl__control49();
		__ctrl.Add(val9);
		Parameter val10 = __BuildControl__control50();
		__ctrl.Add(val10);
		Parameter val11 = __BuildControl__control51();
		__ctrl.Add(val11);
		Parameter val12 = __BuildControl__control52();
		__ctrl.Add(val12);
		Parameter val13 = __BuildControl__control53();
		__ctrl.Add(val13);
		Parameter val14 = __BuildControl__control54();
		__ctrl.Add(val14);
		Parameter val15 = __BuildControl__control55();
		__ctrl.Add(val15);
		Parameter val16 = __BuildControl__control56();
		__ctrl.Add(val16);
		Parameter val17 = __BuildControl__control57();
		__ctrl.Add(val17);
		Parameter val18 = __BuildControl__control58();
		__ctrl.Add(val18);
		Parameter val19 = __BuildControl__control59();
		__ctrl.Add(val19);
		Parameter val20 = __BuildControl__control60();
		__ctrl.Add(val20);
		Parameter val21 = __BuildControl__control61();
		__ctrl.Add(val21);
		Parameter val22 = __BuildControl__control62();
		__ctrl.Add(val22);
		Parameter val23 = __BuildControl__control63();
		__ctrl.Add(val23);
		Parameter val24 = __BuildControl__control64();
		__ctrl.Add(val24);
		Parameter val25 = __BuildControl__control65();
		__ctrl.Add(val25);
		Parameter val26 = __BuildControl__control66();
		__ctrl.Add(val26);
		Parameter val27 = __BuildControl__control67();
		__ctrl.Add(val27);
	}

	[DebuggerNonUserCode]
	private SqlDataSource __BuildControlSqlDataSource2()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		SqlDataSource val = (SqlDataSource2 = new SqlDataSource());
		((Control)val).TemplateControl = (TemplateControl)(object)this;
		((Control)val).ID = "SqlDataSource2";
		val.DeleteCommand = "DELETE FROM [UserInfo] WHERE [UserName] = @UserName";
		val.InsertCommand = "INSERT INTO [UserInfo] ([Name], [sex], [RegisterDate], [Address], [Maried], [NumberofChildren], [Sybling], [City], [State], [Zipcode], [areacode], [phonenumber], [occupation], [Habbies], [birthdate], [birthplace], [lastgrad], [SSN], [Labnum], [PsychologicallyStress], [height], [weight], [eyecolor], [haircolor], [bloodtype], [UserName], [Code]) VALUES (@Name, @sex, @RegisterDate, @Address, @Maried, @NumberofChildren, @Sybling, @City, @State, @Zipcode, @areacode, @phonenumber, @occupation, @Habbies, @birthdate, @birthplace, @lastgrad, @SSN, @Labnum, @PsychologicallyStress, @height, @weight, @eyecolor, @haircolor, @bloodtype, @UserName, @Code)";
		val.SelectCommand = "SELECT UserInfo.Name, UserInfo.sex, UserInfo.RegisterDate, UserInfo.Address, UserInfo.Maried, UserInfo.NumberofChildren, UserInfo.Sybling, UserInfo.City, UserInfo.State, UserInfo.Zipcode, UserInfo.areacode, UserInfo.phonenumber, UserInfo.occupation, UserInfo.Habbies, UserInfo.birthdate, UserInfo.birthplace, UserInfo.lastgrad, UserInfo.SSN, UserInfo.Labnum, UserInfo.PsychologicallyStress, UserInfo.height, UserInfo.weight, UserInfo.eyecolor, UserInfo.haircolor, UserInfo.bloodtype, UserInfo.Code, complaints.c1, complaints.o1, complaints.c2, complaints.o2, complaints.c3, complaints.o3, complaints.c4, complaints.o4, complaints.c5, complaints.o5, complaints.c6, complaints.o6, complaints.c7, complaints.o7, complaints.c8, complaints.o8, complaints.m1, complaints.l1, complaints.m2, complaints.l2, complaints.m3, complaints.l3, complaints.m4, complaints.l4, complaints.m5, complaints.l5, complaints.m6, complaints.l6, complaints.m7, complaints.l7, complaints.m8, complaints.l8, dbo.aspnet_Membership.Email, dbo.aspnet_Membership.CreateDate, dbo.aspnet_Membership.LastLoginDate, UserInfo.race, complaints.comment, aspnet_Users.UserName, UserInfo.referral FROM dbo.aspnet_Users AS aspnet_Users INNER JOIN dbo.aspnet_Membership ON aspnet_Users.UserId = dbo.aspnet_Membership.UserId AND aspnet_Users.UserId = dbo.aspnet_Membership.UserId INNER JOIN complaints ON aspnet_Users.UserName = complaints.UserName RIGHT OUTER JOIN UserInfo ON aspnet_Users.UserName = UserInfo.UserName WHERE (UserInfo.UserName = @un)";
		val.UpdateCommand = "UPDATE [UserInfo] SET [Name] = @Name, [sex] = @sex, [RegisterDate] = @RegisterDate, [Address] = @Address, [Maried] = @Maried, [NumberofChildren] = @NumberofChildren, [Sybling] = @Sybling, [City] = @City, [State] = @State, [Zipcode] = @Zipcode, [areacode] = @areacode, [phonenumber] = @phonenumber, [occupation] = @occupation, [Habbies] = @Habbies, [birthdate] = @birthdate, [birthplace] = @birthplace, [lastgrad] = @lastgrad, [SSN] = @SSN, [Labnum] = @Labnum, [PsychologicallyStress] = @PsychologicallyStress, [height] = @height, [weight] = @weight, [eyecolor] = @eyecolor, [haircolor] = @haircolor, [bloodtype] = @bloodtype, [Code] = @Code WHERE [UserName] = @UserName";
		__BuildControl__control8(val.DeleteParameters);
		__BuildControl__control10(val.UpdateParameters);
		__BuildControl__control38(val.SelectParameters);
		__BuildControl__control40(val.InsertParameters);
		val.ConnectionString = Convert.ToString(ConnectionStringsExpressionBuilder.GetConnectionString("nazdiltarinConnectionString"), CultureInfo.CurrentCulture);
		val.ProviderName = Convert.ToString(ConnectionStringsExpressionBuilder.GetConnectionStringProviderName("LocalSqlServer"), CultureInfo.CurrentCulture);
		return val;
	}

	[DebuggerNonUserCode]
	private Button __BuildControlButton1()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Button val = (Button1 = new Button());
		((Control)val).TemplateControl = (TemplateControl)(object)this;
		((Control)val).ApplyStyleSheetSkin((Page)(object)this);
		((Control)val).ID = "Button1";
		val.Text = "Edit Info";
		return val;
	}

	[DebuggerNonUserCode]
	private Button __BuildControlButton2()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Button val = (Button2 = new Button());
		((Control)val).TemplateControl = (TemplateControl)(object)this;
		((Control)val).ApplyStyleSheetSkin((Page)(object)this);
		((Control)val).ID = "Button2";
		val.Text = "Edt Complaints";
		return val;
	}

	[DebuggerNonUserCode]
	private BoundField __BuildControl__control69()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		BoundField val = new BoundField();
		val.DataField = "Name";
		val.HeaderText = "Name";
		((DataControlField)val).SortExpression = "Name";
		return val;
	}

	[DebuggerNonUserCode]
	private BoundField __BuildControl__control70()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		BoundField val = new BoundField();
		val.DataField = "sex";
		val.HeaderText = "sex";
		((DataControlField)val).SortExpression = "sex";
		return val;
	}

	[DebuggerNonUserCode]
	private BoundField __BuildControl__control71()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		BoundField val = new BoundField();
		val.DataField = "RegisterDate";
		val.HeaderText = "RegisterDate";
		((DataControlField)val).SortExpression = "RegisterDate";
		return val;
	}

	[DebuggerNonUserCode]
	private BoundField __BuildControl__control72()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		BoundField val = new BoundField();
		val.DataField = "referral";
		val.HeaderText = "referral";
		((DataControlField)val).SortExpression = "referral";
		return val;
	}

	[DebuggerNonUserCode]
	private BoundField __BuildControl__control73()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		BoundField val = new BoundField();
		val.DataField = "Address";
		val.HeaderText = "Address";
		((DataControlField)val).SortExpression = "Address";
		return val;
	}

	[DebuggerNonUserCode]
	private CheckBoxField __BuildControl__control74()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		CheckBoxField val = new CheckBoxField();
		val.DataField = "Maried";
		((BoundField)val).HeaderText = "Maried";
		((DataControlField)val).SortExpression = "Maried";
		return val;
	}

	[DebuggerNonUserCode]
	private BoundField __BuildControl__control75()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		BoundField val = new BoundField();
		val.DataField = "NumberofChildren";
		val.HeaderText = "NumberofChildren";
		((DataControlField)val).SortExpression = "NumberofChildren";
		return val;
	}

	[DebuggerNonUserCode]
	private BoundField __BuildControl__control76()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		BoundField val = new BoundField();
		val.DataField = "Sybling";
		val.HeaderText = "Sybling";
		((DataControlField)val).SortExpression = "Sybling";
		return val;
	}

	[DebuggerNonUserCode]
	private BoundField __BuildControl__control77()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		BoundField val = new BoundField();
		val.DataField = "City";
		val.HeaderText = "City";
		((DataControlField)val).SortExpression = "City";
		return val;
	}

	[DebuggerNonUserCode]
	private BoundField __BuildControl__control78()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		BoundField val = new BoundField();
		val.DataField = "State";
		val.HeaderText = "State";
		((DataControlField)val).SortExpression = "State";
		return val;
	}

	[DebuggerNonUserCode]
	private BoundField __BuildControl__control79()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		BoundField val = new BoundField();
		val.DataField = "Zipcode";
		val.HeaderText = "Zipcode";
		((DataControlField)val).SortExpression = "Zipcode";
		return val;
	}

	[DebuggerNonUserCode]
	private BoundField __BuildControl__control80()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		BoundField val = new BoundField();
		val.DataField = "areacode";
		val.HeaderText = "areacode";
		((DataControlField)val).SortExpression = "areacode";
		return val;
	}

	[DebuggerNonUserCode]
	private BoundField __BuildControl__control81()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		BoundField val = new BoundField();
		val.DataField = "phonenumber";
		val.HeaderText = "phonenumber";
		((DataControlField)val).SortExpression = "phonenumber";
		return val;
	}

	[DebuggerNonUserCode]
	private BoundField __BuildControl__control82()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		BoundField val = new BoundField();
		val.DataField = "occupation";
		val.HeaderText = "occupation";
		((DataControlField)val).SortExpression = "occupation";
		return val;
	}

	[DebuggerNonUserCode]
	private BoundField __BuildControl__control83()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		BoundField val = new BoundField();
		val.DataField = "Habbies";
		val.HeaderText = "Habbies";
		((DataControlField)val).SortExpression = "Habbies";
		return val;
	}

	[DebuggerNonUserCode]
	private BoundField __BuildControl__control84()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		BoundField val = new BoundField();
		val.DataField = "birthdate";
		val.HeaderText = "birthdate";
		((DataControlField)val).SortExpression = "birthdate";
		return val;
	}

	[DebuggerNonUserCode]
	private BoundField __BuildControl__control85()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		BoundField val = new BoundField();
		val.DataField = "birthplace";
		val.HeaderText = "birthplace";
		((DataControlField)val).SortExpression = "birthplace";
		return val;
	}

	[DebuggerNonUserCode]
	private BoundField __BuildControl__control86()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		BoundField val = new BoundField();
		val.DataField = "lastgrad";
		val.HeaderText = "lastgrad";
		((DataControlField)val).SortExpression = "lastgrad";
		return val;
	}

	[DebuggerNonUserCode]
	private BoundField __BuildControl__control87()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		BoundField val = new BoundField();
		val.DataField = "SSN";
		val.HeaderText = "SSN";
		((DataControlField)val).SortExpression = "SSN";
		return val;
	}

	[DebuggerNonUserCode]
	private BoundField __BuildControl__control88()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		BoundField val = new BoundField();
		val.DataField = "Labnum";
		val.HeaderText = "Labnum";
		((DataControlField)val).SortExpression = "Labnum";
		return val;
	}

	[DebuggerNonUserCode]
	private CheckBoxField __BuildControl__control89()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		CheckBoxField val = new CheckBoxField();
		val.DataField = "PsychologicallyStress";
		((BoundField)val).HeaderText = "PsychologicallyStress";
		((DataControlField)val).SortExpression = "PsychologicallyStress";
		return val;
	}

	[DebuggerNonUserCode]
	private BoundField __BuildControl__control90()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		BoundField val = new BoundField();
		val.DataField = "height";
		val.HeaderText = "height";
		((DataControlField)val).SortExpression = "height";
		return val;
	}

	[DebuggerNonUserCode]
	private BoundField __BuildControl__control91()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		BoundField val = new BoundField();
		val.DataField = "weight";
		val.HeaderText = "weight";
		((DataControlField)val).SortExpression = "weight";
		return val;
	}

	[DebuggerNonUserCode]
	private BoundField __BuildControl__control92()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		BoundField val = new BoundField();
		val.DataField = "eyecolor";
		val.HeaderText = "eyecolor";
		((DataControlField)val).SortExpression = "eyecolor";
		return val;
	}

	[DebuggerNonUserCode]
	private BoundField __BuildControl__control93()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		BoundField val = new BoundField();
		val.DataField = "haircolor";
		val.HeaderText = "haircolor";
		((DataControlField)val).SortExpression = "haircolor";
		return val;
	}

	[DebuggerNonUserCode]
	private BoundField __BuildControl__control94()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		BoundField val = new BoundField();
		val.DataField = "bloodtype";
		val.HeaderText = "bloodtype";
		((DataControlField)val).SortExpression = "bloodtype";
		return val;
	}

	[DebuggerNonUserCode]
	private BoundField __BuildControl__control95()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		BoundField val = new BoundField();
		val.DataField = "Code";
		val.HeaderText = "Code";
		((DataControlField)val).SortExpression = "Code";
		return val;
	}

	[DebuggerNonUserCode]
	private BoundField __BuildControl__control96()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		BoundField val = new BoundField();
		val.DataField = "c1";
		val.HeaderText = "c1";
		((DataControlField)val).SortExpression = "c1";
		return val;
	}

	[DebuggerNonUserCode]
	private BoundField __BuildControl__control97()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		BoundField val = new BoundField();
		val.DataField = "o1";
		val.HeaderText = "o1";
		((DataControlField)val).SortExpression = "o1";
		return val;
	}

	[DebuggerNonUserCode]
	private BoundField __BuildControl__control98()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		BoundField val = new BoundField();
		val.DataField = "c2";
		val.HeaderText = "c2";
		((DataControlField)val).SortExpression = "c2";
		return val;
	}

	[DebuggerNonUserCode]
	private BoundField __BuildControl__control99()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		BoundField val = new BoundField();
		val.DataField = "o2";
		val.HeaderText = "o2";
		((DataControlField)val).SortExpression = "o2";
		return val;
	}

	[DebuggerNonUserCode]
	private BoundField __BuildControl__control100()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		BoundField val = new BoundField();
		val.DataField = "c3";
		val.HeaderText = "c3";
		((DataControlField)val).SortExpression = "c3";
		return val;
	}

	[DebuggerNonUserCode]
	private BoundField __BuildControl__control101()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		BoundField val = new BoundField();
		val.DataField = "o3";
		val.HeaderText = "o3";
		((DataControlField)val).SortExpression = "o3";
		return val;
	}

	[DebuggerNonUserCode]
	private BoundField __BuildControl__control102()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		BoundField val = new BoundField();
		val.DataField = "c4";
		val.HeaderText = "c4";
		((DataControlField)val).SortExpression = "c4";
		return val;
	}

	[DebuggerNonUserCode]
	private BoundField __BuildControl__control103()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		BoundField val = new BoundField();
		val.DataField = "o4";
		val.HeaderText = "o4";
		((DataControlField)val).SortExpression = "o4";
		return val;
	}

	[DebuggerNonUserCode]
	private BoundField __BuildControl__control104()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		BoundField val = new BoundField();
		val.DataField = "c5";
		val.HeaderText = "c5";
		((DataControlField)val).SortExpression = "c5";
		return val;
	}

	[DebuggerNonUserCode]
	private BoundField __BuildControl__control105()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		BoundField val = new BoundField();
		val.DataField = "o5";
		val.HeaderText = "o5";
		((DataControlField)val).SortExpression = "o5";
		return val;
	}

	[DebuggerNonUserCode]
	private BoundField __BuildControl__control106()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		BoundField val = new BoundField();
		val.DataField = "c6";
		val.HeaderText = "c6";
		((DataControlField)val).SortExpression = "c6";
		return val;
	}

	[DebuggerNonUserCode]
	private BoundField __BuildControl__control107()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		BoundField val = new BoundField();
		val.DataField = "o6";
		val.HeaderText = "o6";
		((DataControlField)val).SortExpression = "o6";
		return val;
	}

	[DebuggerNonUserCode]
	private BoundField __BuildControl__control108()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		BoundField val = new BoundField();
		val.DataField = "c7";
		val.HeaderText = "c7";
		((DataControlField)val).SortExpression = "c7";
		return val;
	}

	[DebuggerNonUserCode]
	private BoundField __BuildControl__control109()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		BoundField val = new BoundField();
		val.DataField = "o7";
		val.HeaderText = "o7";
		((DataControlField)val).SortExpression = "o7";
		return val;
	}

	[DebuggerNonUserCode]
	private BoundField __BuildControl__control110()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		BoundField val = new BoundField();
		val.DataField = "c8";
		val.HeaderText = "c8";
		((DataControlField)val).SortExpression = "c8";
		return val;
	}

	[DebuggerNonUserCode]
	private BoundField __BuildControl__control111()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		BoundField val = new BoundField();
		val.DataField = "o8";
		val.HeaderText = "o8";
		((DataControlField)val).SortExpression = "o8";
		return val;
	}

	[DebuggerNonUserCode]
	private BoundField __BuildControl__control112()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		BoundField val = new BoundField();
		val.DataField = "m1";
		val.HeaderText = "m1";
		((DataControlField)val).SortExpression = "m1";
		return val;
	}

	[DebuggerNonUserCode]
	private BoundField __BuildControl__control113()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		BoundField val = new BoundField();
		val.DataField = "l1";
		val.HeaderText = "l1";
		((DataControlField)val).SortExpression = "l1";
		return val;
	}

	[DebuggerNonUserCode]
	private BoundField __BuildControl__control114()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		BoundField val = new BoundField();
		val.DataField = "m2";
		val.HeaderText = "m2";
		((DataControlField)val).SortExpression = "m2";
		return val;
	}

	[DebuggerNonUserCode]
	private BoundField __BuildControl__control115()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		BoundField val = new BoundField();
		val.DataField = "l2";
		val.HeaderText = "l2";
		((DataControlField)val).SortExpression = "l2";
		return val;
	}

	[DebuggerNonUserCode]
	private BoundField __BuildControl__control116()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		BoundField val = new BoundField();
		val.DataField = "m3";
		val.HeaderText = "m3";
		((DataControlField)val).SortExpression = "m3";
		return val;
	}

	[DebuggerNonUserCode]
	private BoundField __BuildControl__control117()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		BoundField val = new BoundField();
		val.DataField = "l3";
		val.HeaderText = "l3";
		((DataControlField)val).SortExpression = "l3";
		return val;
	}

	[DebuggerNonUserCode]
	private BoundField __BuildControl__control118()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		BoundField val = new BoundField();
		val.DataField = "m4";
		val.HeaderText = "m4";
		((DataControlField)val).SortExpression = "m4";
		return val;
	}

	[DebuggerNonUserCode]
	private BoundField __BuildControl__control119()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		BoundField val = new BoundField();
		val.DataField = "l4";
		val.HeaderText = "l4";
		((DataControlField)val).SortExpression = "l4";
		return val;
	}

	[DebuggerNonUserCode]
	private BoundField __BuildControl__control120()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		BoundField val = new BoundField();
		val.DataField = "m5";
		val.HeaderText = "m5";
		((DataControlField)val).SortExpression = "m5";
		return val;
	}

	[DebuggerNonUserCode]
	private BoundField __BuildControl__control121()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		BoundField val = new BoundField();
		val.DataField = "l5";
		val.HeaderText = "l5";
		((DataControlField)val).SortExpression = "l5";
		return val;
	}

	[DebuggerNonUserCode]
	private BoundField __BuildControl__control122()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		BoundField val = new BoundField();
		val.DataField = "m6";
		val.HeaderText = "m6";
		((DataControlField)val).SortExpression = "m6";
		return val;
	}

	[DebuggerNonUserCode]
	private BoundField __BuildControl__control123()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		BoundField val = new BoundField();
		val.DataField = "l6";
		val.HeaderText = "l6";
		((DataControlField)val).SortExpression = "l6";
		return val;
	}

	[DebuggerNonUserCode]
	private BoundField __BuildControl__control124()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		BoundField val = new BoundField();
		val.DataField = "m7";
		val.HeaderText = "m7";
		((DataControlField)val).SortExpression = "m7";
		return val;
	}

	[DebuggerNonUserCode]
	private BoundField __BuildControl__control125()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		BoundField val = new BoundField();
		val.DataField = "l7";
		val.HeaderText = "l7";
		((DataControlField)val).SortExpression = "l7";
		return val;
	}

	[DebuggerNonUserCode]
	private BoundField __BuildControl__control126()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		BoundField val = new BoundField();
		val.DataField = "m8";
		val.HeaderText = "m8";
		((DataControlField)val).SortExpression = "m8";
		return val;
	}

	[DebuggerNonUserCode]
	private BoundField __BuildControl__control127()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		BoundField val = new BoundField();
		val.DataField = "l8";
		val.HeaderText = "l8";
		((DataControlField)val).SortExpression = "l8";
		return val;
	}

	[DebuggerNonUserCode]
	private BoundField __BuildControl__control128()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		BoundField val = new BoundField();
		val.DataField = "Email";
		val.HeaderText = "Email";
		((DataControlField)val).SortExpression = "Email";
		return val;
	}

	[DebuggerNonUserCode]
	private BoundField __BuildControl__control129()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		BoundField val = new BoundField();
		val.DataField = "CreateDate";
		val.HeaderText = "CreateDate";
		((DataControlField)val).SortExpression = "CreateDate";
		return val;
	}

	[DebuggerNonUserCode]
	private BoundField __BuildControl__control130()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		BoundField val = new BoundField();
		val.DataField = "LastLoginDate";
		val.HeaderText = "LastLoginDate";
		((DataControlField)val).SortExpression = "LastLoginDate";
		return val;
	}

	[DebuggerNonUserCode]
	private BoundField __BuildControl__control131()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		BoundField val = new BoundField();
		val.DataField = "race";
		val.HeaderText = "race";
		((DataControlField)val).SortExpression = "race";
		return val;
	}

	[DebuggerNonUserCode]
	private BoundField __BuildControl__control132()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		BoundField val = new BoundField();
		val.DataField = "comment";
		val.HeaderText = "comment";
		((DataControlField)val).SortExpression = "comment";
		return val;
	}

	[DebuggerNonUserCode]
	private BoundField __BuildControl__control133()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		BoundField val = new BoundField();
		val.DataField = "UserName";
		val.HeaderText = "UserName";
		((DataControlField)val).SortExpression = "UserName";
		return val;
	}

	[DebuggerNonUserCode]
	private void __BuildControl__control68(DataControlFieldCollection __ctrl)
	{
		BoundField val = __BuildControl__control69();
		__ctrl.Add((DataControlField)(object)val);
		BoundField val2 = __BuildControl__control70();
		__ctrl.Add((DataControlField)(object)val2);
		BoundField val3 = __BuildControl__control71();
		__ctrl.Add((DataControlField)(object)val3);
		BoundField val4 = __BuildControl__control72();
		__ctrl.Add((DataControlField)(object)val4);
		BoundField val5 = __BuildControl__control73();
		__ctrl.Add((DataControlField)(object)val5);
		CheckBoxField val6 = __BuildControl__control74();
		__ctrl.Add((DataControlField)(object)val6);
		BoundField val7 = __BuildControl__control75();
		__ctrl.Add((DataControlField)(object)val7);
		BoundField val8 = __BuildControl__control76();
		__ctrl.Add((DataControlField)(object)val8);
		BoundField val9 = __BuildControl__control77();
		__ctrl.Add((DataControlField)(object)val9);
		BoundField val10 = __BuildControl__control78();
		__ctrl.Add((DataControlField)(object)val10);
		BoundField val11 = __BuildControl__control79();
		__ctrl.Add((DataControlField)(object)val11);
		BoundField val12 = __BuildControl__control80();
		__ctrl.Add((DataControlField)(object)val12);
		BoundField val13 = __BuildControl__control81();
		__ctrl.Add((DataControlField)(object)val13);
		BoundField val14 = __BuildControl__control82();
		__ctrl.Add((DataControlField)(object)val14);
		BoundField val15 = __BuildControl__control83();
		__ctrl.Add((DataControlField)(object)val15);
		BoundField val16 = __BuildControl__control84();
		__ctrl.Add((DataControlField)(object)val16);
		BoundField val17 = __BuildControl__control85();
		__ctrl.Add((DataControlField)(object)val17);
		BoundField val18 = __BuildControl__control86();
		__ctrl.Add((DataControlField)(object)val18);
		BoundField val19 = __BuildControl__control87();
		__ctrl.Add((DataControlField)(object)val19);
		BoundField val20 = __BuildControl__control88();
		__ctrl.Add((DataControlField)(object)val20);
		CheckBoxField val21 = __BuildControl__control89();
		__ctrl.Add((DataControlField)(object)val21);
		BoundField val22 = __BuildControl__control90();
		__ctrl.Add((DataControlField)(object)val22);
		BoundField val23 = __BuildControl__control91();
		__ctrl.Add((DataControlField)(object)val23);
		BoundField val24 = __BuildControl__control92();
		__ctrl.Add((DataControlField)(object)val24);
		BoundField val25 = __BuildControl__control93();
		__ctrl.Add((DataControlField)(object)val25);
		BoundField val26 = __BuildControl__control94();
		__ctrl.Add((DataControlField)(object)val26);
		BoundField val27 = __BuildControl__control95();
		__ctrl.Add((DataControlField)(object)val27);
		BoundField val28 = __BuildControl__control96();
		__ctrl.Add((DataControlField)(object)val28);
		BoundField val29 = __BuildControl__control97();
		__ctrl.Add((DataControlField)(object)val29);
		BoundField val30 = __BuildControl__control98();
		__ctrl.Add((DataControlField)(object)val30);
		BoundField val31 = __BuildControl__control99();
		__ctrl.Add((DataControlField)(object)val31);
		BoundField val32 = __BuildControl__control100();
		__ctrl.Add((DataControlField)(object)val32);
		BoundField val33 = __BuildControl__control101();
		__ctrl.Add((DataControlField)(object)val33);
		BoundField val34 = __BuildControl__control102();
		__ctrl.Add((DataControlField)(object)val34);
		BoundField val35 = __BuildControl__control103();
		__ctrl.Add((DataControlField)(object)val35);
		BoundField val36 = __BuildControl__control104();
		__ctrl.Add((DataControlField)(object)val36);
		BoundField val37 = __BuildControl__control105();
		__ctrl.Add((DataControlField)(object)val37);
		BoundField val38 = __BuildControl__control106();
		__ctrl.Add((DataControlField)(object)val38);
		BoundField val39 = __BuildControl__control107();
		__ctrl.Add((DataControlField)(object)val39);
		BoundField val40 = __BuildControl__control108();
		__ctrl.Add((DataControlField)(object)val40);
		BoundField val41 = __BuildControl__control109();
		__ctrl.Add((DataControlField)(object)val41);
		BoundField val42 = __BuildControl__control110();
		__ctrl.Add((DataControlField)(object)val42);
		BoundField val43 = __BuildControl__control111();
		__ctrl.Add((DataControlField)(object)val43);
		BoundField val44 = __BuildControl__control112();
		__ctrl.Add((DataControlField)(object)val44);
		BoundField val45 = __BuildControl__control113();
		__ctrl.Add((DataControlField)(object)val45);
		BoundField val46 = __BuildControl__control114();
		__ctrl.Add((DataControlField)(object)val46);
		BoundField val47 = __BuildControl__control115();
		__ctrl.Add((DataControlField)(object)val47);
		BoundField val48 = __BuildControl__control116();
		__ctrl.Add((DataControlField)(object)val48);
		BoundField val49 = __BuildControl__control117();
		__ctrl.Add((DataControlField)(object)val49);
		BoundField val50 = __BuildControl__control118();
		__ctrl.Add((DataControlField)(object)val50);
		BoundField val51 = __BuildControl__control119();
		__ctrl.Add((DataControlField)(object)val51);
		BoundField val52 = __BuildControl__control120();
		__ctrl.Add((DataControlField)(object)val52);
		BoundField val53 = __BuildControl__control121();
		__ctrl.Add((DataControlField)(object)val53);
		BoundField val54 = __BuildControl__control122();
		__ctrl.Add((DataControlField)(object)val54);
		BoundField val55 = __BuildControl__control123();
		__ctrl.Add((DataControlField)(object)val55);
		BoundField val56 = __BuildControl__control124();
		__ctrl.Add((DataControlField)(object)val56);
		BoundField val57 = __BuildControl__control125();
		__ctrl.Add((DataControlField)(object)val57);
		BoundField val58 = __BuildControl__control126();
		__ctrl.Add((DataControlField)(object)val58);
		BoundField val59 = __BuildControl__control127();
		__ctrl.Add((DataControlField)(object)val59);
		BoundField val60 = __BuildControl__control128();
		__ctrl.Add((DataControlField)(object)val60);
		BoundField val61 = __BuildControl__control129();
		__ctrl.Add((DataControlField)(object)val61);
		BoundField val62 = __BuildControl__control130();
		__ctrl.Add((DataControlField)(object)val62);
		BoundField val63 = __BuildControl__control131();
		__ctrl.Add((DataControlField)(object)val63);
		BoundField val64 = __BuildControl__control132();
		__ctrl.Add((DataControlField)(object)val64);
		BoundField val65 = __BuildControl__control133();
		__ctrl.Add((DataControlField)(object)val65);
	}

	[DebuggerNonUserCode]
	private DetailsView __BuildControlDetailsView1()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		DetailsView val = (DetailsView1 = new DetailsView());
		((Control)val).ApplyStyleSheetSkin((Page)(object)this);
		((Control)val).ID = "DetailsView1";
		val.AutoGenerateRows = false;
		((DataBoundControl)val).DataSourceID = "SqlDataSource2";
		Unit height = new Unit(50.0, (UnitType)1);
		((WebControl)val).Height = height;
		height = new Unit(125.0, (UnitType)1);
		((WebControl)val).Width = height;
		__BuildControl__control68(val.Fields);
		return val;
	}

	[DebuggerNonUserCode]
	private View __BuildControlView1()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Expected Obj, but got Unknown
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Expected Obj, but got Unknown
		View val = (View1 = new View());
		((Control)val).ID = "View1";
		IParserAccessor val3 = (IParserAccessor)(object)val;
		val3.AddParsedSubObject((object)new LiteralControl("\r\n                  "));
		DetailsView val4 = __BuildControlDetailsView1();
		val3.AddParsedSubObject((object)val4);
		val3.AddParsedSubObject((object)new LiteralControl("\r\n                "));
		return val;
	}

	[DebuggerNonUserCode]
	private SessionParameter __BuildControl__control136()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		SessionParameter val = new SessionParameter();
		((Parameter)val).Name = "un";
		val.SessionField = "un";
		return val;
	}

	[DebuggerNonUserCode]
	private void __BuildControl__control135(ParameterCollection __ctrl)
	{
		SessionParameter val = __BuildControl__control136();
		__ctrl.Add((Parameter)(object)val);
	}

	[DebuggerNonUserCode]
	private Parameter __BuildControl__control138()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Parameter val = new Parameter();
		val.Name = "UserName";
		val.Type = TypeCode.String;
		return val;
	}

	[DebuggerNonUserCode]
	private void __BuildControl__control137(ParameterCollection __ctrl)
	{
		Parameter val = __BuildControl__control138();
		__ctrl.Add(val);
	}

	[DebuggerNonUserCode]
	private Parameter __BuildControl__control140()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Parameter val = new Parameter();
		val.Name = "Name";
		val.Type = TypeCode.String;
		return val;
	}

	[DebuggerNonUserCode]
	private Parameter __BuildControl__control141()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Parameter val = new Parameter();
		val.Name = "sex";
		val.Type = TypeCode.String;
		return val;
	}

	[DebuggerNonUserCode]
	private Parameter __BuildControl__control142()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Parameter val = new Parameter();
		val.Name = "RegisterDate";
		val.Type = TypeCode.DateTime;
		return val;
	}

	[DebuggerNonUserCode]
	private Parameter __BuildControl__control143()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Parameter val = new Parameter();
		val.Name = "Address";
		val.Type = TypeCode.String;
		return val;
	}

	[DebuggerNonUserCode]
	private Parameter __BuildControl__control144()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Parameter val = new Parameter();
		val.Name = "Maried";
		val.Type = TypeCode.Boolean;
		return val;
	}

	[DebuggerNonUserCode]
	private Parameter __BuildControl__control145()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Parameter val = new Parameter();
		val.Name = "NumberofChildren";
		val.Type = TypeCode.Int16;
		return val;
	}

	[DebuggerNonUserCode]
	private Parameter __BuildControl__control146()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Parameter val = new Parameter();
		val.Name = "Sybling";
		val.Type = TypeCode.String;
		return val;
	}

	[DebuggerNonUserCode]
	private Parameter __BuildControl__control147()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Parameter val = new Parameter();
		val.Name = "City";
		val.Type = TypeCode.String;
		return val;
	}

	[DebuggerNonUserCode]
	private Parameter __BuildControl__control148()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Parameter val = new Parameter();
		val.Name = "State";
		val.Type = TypeCode.String;
		return val;
	}

	[DebuggerNonUserCode]
	private Parameter __BuildControl__control149()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Parameter val = new Parameter();
		val.Name = "Zipcode";
		val.Type = TypeCode.String;
		return val;
	}

	[DebuggerNonUserCode]
	private Parameter __BuildControl__control150()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Parameter val = new Parameter();
		val.Name = "areacode";
		val.Type = TypeCode.Int32;
		return val;
	}

	[DebuggerNonUserCode]
	private Parameter __BuildControl__control151()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Parameter val = new Parameter();
		val.Name = "phonenumber";
		val.Type = TypeCode.Int32;
		return val;
	}

	[DebuggerNonUserCode]
	private Parameter __BuildControl__control152()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Parameter val = new Parameter();
		val.Name = "occupation";
		val.Type = TypeCode.String;
		return val;
	}

	[DebuggerNonUserCode]
	private Parameter __BuildControl__control153()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Parameter val = new Parameter();
		val.Name = "Habbies";
		val.Type = TypeCode.String;
		return val;
	}

	[DebuggerNonUserCode]
	private Parameter __BuildControl__control154()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Parameter val = new Parameter();
		val.Name = "birthdate";
		val.Type = TypeCode.DateTime;
		return val;
	}

	[DebuggerNonUserCode]
	private Parameter __BuildControl__control155()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Parameter val = new Parameter();
		val.Name = "birthplace";
		val.Type = TypeCode.String;
		return val;
	}

	[DebuggerNonUserCode]
	private Parameter __BuildControl__control156()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Parameter val = new Parameter();
		val.Name = "lastgrad";
		val.Type = TypeCode.String;
		return val;
	}

	[DebuggerNonUserCode]
	private Parameter __BuildControl__control157()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Parameter val = new Parameter();
		val.Name = "SSN";
		val.Type = TypeCode.String;
		return val;
	}

	[DebuggerNonUserCode]
	private Parameter __BuildControl__control158()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Parameter val = new Parameter();
		val.Name = "Labnum";
		val.Type = TypeCode.Int32;
		return val;
	}

	[DebuggerNonUserCode]
	private Parameter __BuildControl__control159()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Parameter val = new Parameter();
		val.Name = "PsychologicallyStress";
		val.Type = TypeCode.Boolean;
		return val;
	}

	[DebuggerNonUserCode]
	private Parameter __BuildControl__control160()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Parameter val = new Parameter();
		val.Name = "height";
		val.Type = TypeCode.String;
		return val;
	}

	[DebuggerNonUserCode]
	private Parameter __BuildControl__control161()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Parameter val = new Parameter();
		val.Name = "weight";
		val.Type = TypeCode.String;
		return val;
	}

	[DebuggerNonUserCode]
	private Parameter __BuildControl__control162()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Parameter val = new Parameter();
		val.Name = "eyecolor";
		val.Type = TypeCode.String;
		return val;
	}

	[DebuggerNonUserCode]
	private Parameter __BuildControl__control163()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Parameter val = new Parameter();
		val.Name = "haircolor";
		val.Type = TypeCode.String;
		return val;
	}

	[DebuggerNonUserCode]
	private Parameter __BuildControl__control164()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Parameter val = new Parameter();
		val.Name = "bloodtype";
		val.Type = TypeCode.String;
		return val;
	}

	[DebuggerNonUserCode]
	private Parameter __BuildControl__control165()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Parameter val = new Parameter();
		val.Name = "UserName";
		val.Type = TypeCode.String;
		return val;
	}

	[DebuggerNonUserCode]
	private Parameter __BuildControl__control166()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Parameter val = new Parameter();
		val.Name = "Code";
		val.Type = TypeCode.String;
		return val;
	}

	[DebuggerNonUserCode]
	private Parameter __BuildControl__control167()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Parameter val = new Parameter();
		val.Name = "race";
		val.Type = TypeCode.String;
		return val;
	}

	[DebuggerNonUserCode]
	private void __BuildControl__control139(ParameterCollection __ctrl)
	{
		Parameter val = __BuildControl__control140();
		__ctrl.Add(val);
		Parameter val2 = __BuildControl__control141();
		__ctrl.Add(val2);
		Parameter val3 = __BuildControl__control142();
		__ctrl.Add(val3);
		Parameter val4 = __BuildControl__control143();
		__ctrl.Add(val4);
		Parameter val5 = __BuildControl__control144();
		__ctrl.Add(val5);
		Parameter val6 = __BuildControl__control145();
		__ctrl.Add(val6);
		Parameter val7 = __BuildControl__control146();
		__ctrl.Add(val7);
		Parameter val8 = __BuildControl__control147();
		__ctrl.Add(val8);
		Parameter val9 = __BuildControl__control148();
		__ctrl.Add(val9);
		Parameter val10 = __BuildControl__control149();
		__ctrl.Add(val10);
		Parameter val11 = __BuildControl__control150();
		__ctrl.Add(val11);
		Parameter val12 = __BuildControl__control151();
		__ctrl.Add(val12);
		Parameter val13 = __BuildControl__control152();
		__ctrl.Add(val13);
		Parameter val14 = __BuildControl__control153();
		__ctrl.Add(val14);
		Parameter val15 = __BuildControl__control154();
		__ctrl.Add(val15);
		Parameter val16 = __BuildControl__control155();
		__ctrl.Add(val16);
		Parameter val17 = __BuildControl__control156();
		__ctrl.Add(val17);
		Parameter val18 = __BuildControl__control157();
		__ctrl.Add(val18);
		Parameter val19 = __BuildControl__control158();
		__ctrl.Add(val19);
		Parameter val20 = __BuildControl__control159();
		__ctrl.Add(val20);
		Parameter val21 = __BuildControl__control160();
		__ctrl.Add(val21);
		Parameter val22 = __BuildControl__control161();
		__ctrl.Add(val22);
		Parameter val23 = __BuildControl__control162();
		__ctrl.Add(val23);
		Parameter val24 = __BuildControl__control163();
		__ctrl.Add(val24);
		Parameter val25 = __BuildControl__control164();
		__ctrl.Add(val25);
		Parameter val26 = __BuildControl__control165();
		__ctrl.Add(val26);
		Parameter val27 = __BuildControl__control166();
		__ctrl.Add(val27);
		Parameter val28 = __BuildControl__control167();
		__ctrl.Add(val28);
	}

	[DebuggerNonUserCode]
	private Parameter __BuildControl__control169()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Parameter val = new Parameter();
		val.Name = "Name";
		val.Type = TypeCode.String;
		return val;
	}

	[DebuggerNonUserCode]
	private Parameter __BuildControl__control170()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Parameter val = new Parameter();
		val.Name = "sex";
		val.Type = TypeCode.String;
		return val;
	}

	[DebuggerNonUserCode]
	private Parameter __BuildControl__control171()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Parameter val = new Parameter();
		val.Name = "RegisterDate";
		val.Type = TypeCode.DateTime;
		return val;
	}

	[DebuggerNonUserCode]
	private Parameter __BuildControl__control172()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Parameter val = new Parameter();
		val.Name = "Address";
		val.Type = TypeCode.String;
		return val;
	}

	[DebuggerNonUserCode]
	private Parameter __BuildControl__control173()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Parameter val = new Parameter();
		val.Name = "Maried";
		val.Type = TypeCode.Boolean;
		return val;
	}

	[DebuggerNonUserCode]
	private Parameter __BuildControl__control174()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Parameter val = new Parameter();
		val.Name = "NumberofChildren";
		val.Type = TypeCode.Int16;
		return val;
	}

	[DebuggerNonUserCode]
	private Parameter __BuildControl__control175()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Parameter val = new Parameter();
		val.Name = "Sybling";
		val.Type = TypeCode.String;
		return val;
	}

	[DebuggerNonUserCode]
	private Parameter __BuildControl__control176()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Parameter val = new Parameter();
		val.Name = "City";
		val.Type = TypeCode.String;
		return val;
	}

	[DebuggerNonUserCode]
	private Parameter __BuildControl__control177()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Parameter val = new Parameter();
		val.Name = "State";
		val.Type = TypeCode.String;
		return val;
	}

	[DebuggerNonUserCode]
	private Parameter __BuildControl__control178()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Parameter val = new Parameter();
		val.Name = "Zipcode";
		val.Type = TypeCode.String;
		return val;
	}

	[DebuggerNonUserCode]
	private Parameter __BuildControl__control179()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Parameter val = new Parameter();
		val.Name = "areacode";
		val.Type = TypeCode.Int32;
		return val;
	}

	[DebuggerNonUserCode]
	private Parameter __BuildControl__control180()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Parameter val = new Parameter();
		val.Name = "phonenumber";
		val.Type = TypeCode.Int32;
		return val;
	}

	[DebuggerNonUserCode]
	private Parameter __BuildControl__control181()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Parameter val = new Parameter();
		val.Name = "occupation";
		val.Type = TypeCode.String;
		return val;
	}

	[DebuggerNonUserCode]
	private Parameter __BuildControl__control182()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Parameter val = new Parameter();
		val.Name = "Habbies";
		val.Type = TypeCode.String;
		return val;
	}

	[DebuggerNonUserCode]
	private Parameter __BuildControl__control183()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Parameter val = new Parameter();
		val.Name = "birthdate";
		val.Type = TypeCode.DateTime;
		return val;
	}

	[DebuggerNonUserCode]
	private Parameter __BuildControl__control184()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Parameter val = new Parameter();
		val.Name = "birthplace";
		val.Type = TypeCode.String;
		return val;
	}

	[DebuggerNonUserCode]
	private Parameter __BuildControl__control185()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Parameter val = new Parameter();
		val.Name = "lastgrad";
		val.Type = TypeCode.String;
		return val;
	}

	[DebuggerNonUserCode]
	private Parameter __BuildControl__control186()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Parameter val = new Parameter();
		val.Name = "SSN";
		val.Type = TypeCode.String;
		return val;
	}

	[DebuggerNonUserCode]
	private Parameter __BuildControl__control187()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Parameter val = new Parameter();
		val.Name = "Labnum";
		val.Type = TypeCode.Int32;
		return val;
	}

	[DebuggerNonUserCode]
	private Parameter __BuildControl__control188()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Parameter val = new Parameter();
		val.Name = "PsychologicallyStress";
		val.Type = TypeCode.Boolean;
		return val;
	}

	[DebuggerNonUserCode]
	private Parameter __BuildControl__control189()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Parameter val = new Parameter();
		val.Name = "height";
		val.Type = TypeCode.String;
		return val;
	}

	[DebuggerNonUserCode]
	private Parameter __BuildControl__control190()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Parameter val = new Parameter();
		val.Name = "weight";
		val.Type = TypeCode.String;
		return val;
	}

	[DebuggerNonUserCode]
	private Parameter __BuildControl__control191()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Parameter val = new Parameter();
		val.Name = "eyecolor";
		val.Type = TypeCode.String;
		return val;
	}

	[DebuggerNonUserCode]
	private Parameter __BuildControl__control192()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Parameter val = new Parameter();
		val.Name = "haircolor";
		val.Type = TypeCode.String;
		return val;
	}

	[DebuggerNonUserCode]
	private Parameter __BuildControl__control193()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Parameter val = new Parameter();
		val.Name = "bloodtype";
		val.Type = TypeCode.String;
		return val;
	}

	[DebuggerNonUserCode]
	private Parameter __BuildControl__control194()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Parameter val = new Parameter();
		val.Name = "Code";
		val.Type = TypeCode.String;
		return val;
	}

	[DebuggerNonUserCode]
	private Parameter __BuildControl__control195()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Parameter val = new Parameter();
		val.Name = "race";
		val.Type = TypeCode.String;
		return val;
	}

	[DebuggerNonUserCode]
	private Parameter __BuildControl__control196()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Parameter val = new Parameter();
		val.Name = "UserName";
		val.Type = TypeCode.String;
		return val;
	}

	[DebuggerNonUserCode]
	private void __BuildControl__control168(ParameterCollection __ctrl)
	{
		Parameter val = __BuildControl__control169();
		__ctrl.Add(val);
		Parameter val2 = __BuildControl__control170();
		__ctrl.Add(val2);
		Parameter val3 = __BuildControl__control171();
		__ctrl.Add(val3);
		Parameter val4 = __BuildControl__control172();
		__ctrl.Add(val4);
		Parameter val5 = __BuildControl__control173();
		__ctrl.Add(val5);
		Parameter val6 = __BuildControl__control174();
		__ctrl.Add(val6);
		Parameter val7 = __BuildControl__control175();
		__ctrl.Add(val7);
		Parameter val8 = __BuildControl__control176();
		__ctrl.Add(val8);
		Parameter val9 = __BuildControl__control177();
		__ctrl.Add(val9);
		Parameter val10 = __BuildControl__control178();
		__ctrl.Add(val10);
		Parameter val11 = __BuildControl__control179();
		__ctrl.Add(val11);
		Parameter val12 = __BuildControl__control180();
		__ctrl.Add(val12);
		Parameter val13 = __BuildControl__control181();
		__ctrl.Add(val13);
		Parameter val14 = __BuildControl__control182();
		__ctrl.Add(val14);
		Parameter val15 = __BuildControl__control183();
		__ctrl.Add(val15);
		Parameter val16 = __BuildControl__control184();
		__ctrl.Add(val16);
		Parameter val17 = __BuildControl__control185();
		__ctrl.Add(val17);
		Parameter val18 = __BuildControl__control186();
		__ctrl.Add(val18);
		Parameter val19 = __BuildControl__control187();
		__ctrl.Add(val19);
		Parameter val20 = __BuildControl__control188();
		__ctrl.Add(val20);
		Parameter val21 = __BuildControl__control189();
		__ctrl.Add(val21);
		Parameter val22 = __BuildControl__control190();
		__ctrl.Add(val22);
		Parameter val23 = __BuildControl__control191();
		__ctrl.Add(val23);
		Parameter val24 = __BuildControl__control192();
		__ctrl.Add(val24);
		Parameter val25 = __BuildControl__control193();
		__ctrl.Add(val25);
		Parameter val26 = __BuildControl__control194();
		__ctrl.Add(val26);
		Parameter val27 = __BuildControl__control195();
		__ctrl.Add(val27);
		Parameter val28 = __BuildControl__control196();
		__ctrl.Add(val28);
	}

	[DebuggerNonUserCode]
	private SqlDataSource __BuildControl__control134()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		SqlDataSource val = new SqlDataSource();
		val.DeleteCommand = "DELETE FROM [UserInfo] WHERE [UserName] = @UserName";
		val.InsertCommand = "INSERT INTO [UserInfo] ([Name], [sex], [RegisterDate], [Address], [Maried], [NumberofChildren], [Sybling], [City], [State], [Zipcode], [areacode], [phonenumber], [occupation], [Habbies], [birthdate], [birthplace], [lastgrad], [SSN], [Labnum], [PsychologicallyStress], [height], [weight], [eyecolor], [haircolor], [bloodtype], [UserName], [Code], [race]) VALUES (@Name, @sex, @RegisterDate, @Address, @Maried, @NumberofChildren, @Sybling, @City, @State, @Zipcode, @areacode, @phonenumber, @occupation, @Habbies, @birthdate, @birthplace, @lastgrad, @SSN, @Labnum, @PsychologicallyStress, @height, @weight, @eyecolor, @haircolor, @bloodtype, @UserName, @Code, @race)";
		val.SelectCommand = "SELECT Name, sex, RegisterDate, Address, Maried, NumberofChildren, Sybling, City, State, Zipcode, areacode, phonenumber, occupation, Habbies, birthdate, birthplace, lastgrad, SSN, Labnum, PsychologicallyStress, height, weight, eyecolor, haircolor, bloodtype, UserName, Code, race FROM UserInfo WHERE (UserName = @un)";
		val.UpdateCommand = "UPDATE [UserInfo] SET [Name] = @Name, [sex] = @sex, [RegisterDate] = @RegisterDate, [Address] = @Address, [Maried] = @Maried, [NumberofChildren] = @NumberofChildren, [Sybling] = @Sybling, [City] = @City, [State] = @State, [Zipcode] = @Zipcode, [areacode] = @areacode, [phonenumber] = @phonenumber, [occupation] = @occupation, [Habbies] = @Habbies, [birthdate] = @birthdate, [birthplace] = @birthplace, [lastgrad] = @lastgrad, [SSN] = @SSN, [Labnum] = @Labnum, [PsychologicallyStress] = @PsychologicallyStress, [height] = @height, [weight] = @weight, [eyecolor] = @eyecolor, [haircolor] = @haircolor, [bloodtype] = @bloodtype, [Code] = @Code, [race] = @race WHERE [UserName] = @UserName";
		__BuildControl__control135(val.SelectParameters);
		__BuildControl__control137(val.DeleteParameters);
		__BuildControl__control139(val.InsertParameters);
		__BuildControl__control168(val.UpdateParameters);
		val.ConnectionString = Convert.ToString(ConnectionStringsExpressionBuilder.GetConnectionString("LocalSqlServer"), CultureInfo.CurrentCulture);
		val.ProviderName = Convert.ToString(ConnectionStringsExpressionBuilder.GetConnectionStringProviderName("LocalSqlServer"), CultureInfo.CurrentCulture);
		return val;
	}

	[DebuggerNonUserCode]
	private CommandField __BuildControl__control198()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		CommandField val = new CommandField();
		val.ShowEditButton = true;
		return val;
	}

	[DebuggerNonUserCode]
	private BoundField __BuildControl__control199()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		BoundField val = new BoundField();
		val.DataField = "Name";
		val.HeaderText = "Name";
		((DataControlField)val).SortExpression = "Name";
		return val;
	}

	[DebuggerNonUserCode]
	private BoundField __BuildControl__control200()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		BoundField val = new BoundField();
		val.DataField = "sex";
		val.HeaderText = "sex";
		((DataControlField)val).SortExpression = "sex";
		return val;
	}

	[DebuggerNonUserCode]
	private BoundField __BuildControl__control201()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		BoundField val = new BoundField();
		val.DataField = "RegisterDate";
		val.HeaderText = "RegisterDate";
		((DataControlField)val).SortExpression = "RegisterDate";
		return val;
	}

	[DebuggerNonUserCode]
	private BoundField __BuildControl__control202()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		BoundField val = new BoundField();
		val.DataField = "referral";
		val.HeaderText = "referral";
		((DataControlField)val).SortExpression = "referral";
		return val;
	}

	[DebuggerNonUserCode]
	private BoundField __BuildControl__control203()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		BoundField val = new BoundField();
		val.DataField = "Address";
		val.HeaderText = "Address";
		((DataControlField)val).SortExpression = "Address";
		return val;
	}

	[DebuggerNonUserCode]
	private CheckBoxField __BuildControl__control204()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		CheckBoxField val = new CheckBoxField();
		val.DataField = "Maried";
		((BoundField)val).HeaderText = "Maried";
		((DataControlField)val).SortExpression = "Maried";
		return val;
	}

	[DebuggerNonUserCode]
	private BoundField __BuildControl__control205()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		BoundField val = new BoundField();
		val.DataField = "NumberofChildren";
		val.HeaderText = "NumberofChildren";
		((DataControlField)val).SortExpression = "NumberofChildren";
		return val;
	}

	[DebuggerNonUserCode]
	private BoundField __BuildControl__control206()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		BoundField val = new BoundField();
		val.DataField = "Sybling";
		val.HeaderText = "Sybling";
		((DataControlField)val).SortExpression = "Sybling";
		return val;
	}

	[DebuggerNonUserCode]
	private BoundField __BuildControl__control207()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		BoundField val = new BoundField();
		val.DataField = "City";
		val.HeaderText = "City";
		((DataControlField)val).SortExpression = "City";
		return val;
	}

	[DebuggerNonUserCode]
	private BoundField __BuildControl__control208()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		BoundField val = new BoundField();
		val.DataField = "State";
		val.HeaderText = "State";
		((DataControlField)val).SortExpression = "State";
		return val;
	}

	[DebuggerNonUserCode]
	private BoundField __BuildControl__control209()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		BoundField val = new BoundField();
		val.DataField = "Zipcode";
		val.HeaderText = "Zipcode";
		((DataControlField)val).SortExpression = "Zipcode";
		return val;
	}

	[DebuggerNonUserCode]
	private BoundField __BuildControl__control210()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		BoundField val = new BoundField();
		val.DataField = "areacode";
		val.HeaderText = "areacode";
		((DataControlField)val).SortExpression = "areacode";
		return val;
	}

	[DebuggerNonUserCode]
	private BoundField __BuildControl__control211()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		BoundField val = new BoundField();
		val.DataField = "phonenumber";
		val.HeaderText = "phonenumber";
		((DataControlField)val).SortExpression = "phonenumber";
		return val;
	}

	[DebuggerNonUserCode]
	private BoundField __BuildControl__control212()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		BoundField val = new BoundField();
		val.DataField = "occupation";
		val.HeaderText = "occupation";
		((DataControlField)val).SortExpression = "occupation";
		return val;
	}

	[DebuggerNonUserCode]
	private BoundField __BuildControl__control213()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		BoundField val = new BoundField();
		val.DataField = "Habbies";
		val.HeaderText = "Habbies";
		((DataControlField)val).SortExpression = "Habbies";
		return val;
	}

	[DebuggerNonUserCode]
	private BoundField __BuildControl__control214()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		BoundField val = new BoundField();
		val.DataField = "birthdate";
		val.HeaderText = "birthdate";
		((DataControlField)val).SortExpression = "birthdate";
		return val;
	}

	[DebuggerNonUserCode]
	private BoundField __BuildControl__control215()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		BoundField val = new BoundField();
		val.DataField = "birthplace";
		val.HeaderText = "birthplace";
		((DataControlField)val).SortExpression = "birthplace";
		return val;
	}

	[DebuggerNonUserCode]
	private BoundField __BuildControl__control216()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		BoundField val = new BoundField();
		val.DataField = "lastgrad";
		val.HeaderText = "lastgrad";
		((DataControlField)val).SortExpression = "lastgrad";
		return val;
	}

	[DebuggerNonUserCode]
	private BoundField __BuildControl__control217()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		BoundField val = new BoundField();
		val.DataField = "SSN";
		val.HeaderText = "SSN";
		((DataControlField)val).SortExpression = "SSN";
		return val;
	}

	[DebuggerNonUserCode]
	private BoundField __BuildControl__control218()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		BoundField val = new BoundField();
		val.DataField = "Labnum";
		val.HeaderText = "Labnum";
		((DataControlField)val).SortExpression = "Labnum";
		return val;
	}

	[DebuggerNonUserCode]
	private CheckBoxField __BuildControl__control219()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		CheckBoxField val = new CheckBoxField();
		val.DataField = "PsychologicallyStress";
		((BoundField)val).HeaderText = "PsychologicallyStress";
		((DataControlField)val).SortExpression = "PsychologicallyStress";
		return val;
	}

	[DebuggerNonUserCode]
	private BoundField __BuildControl__control220()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		BoundField val = new BoundField();
		val.DataField = "height";
		val.HeaderText = "height";
		((DataControlField)val).SortExpression = "height";
		return val;
	}

	[DebuggerNonUserCode]
	private BoundField __BuildControl__control221()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		BoundField val = new BoundField();
		val.DataField = "weight";
		val.HeaderText = "weight";
		((DataControlField)val).SortExpression = "weight";
		return val;
	}

	[DebuggerNonUserCode]
	private BoundField __BuildControl__control222()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		BoundField val = new BoundField();
		val.DataField = "eyecolor";
		val.HeaderText = "eyecolor";
		((DataControlField)val).SortExpression = "eyecolor";
		return val;
	}

	[DebuggerNonUserCode]
	private BoundField __BuildControl__control223()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		BoundField val = new BoundField();
		val.DataField = "haircolor";
		val.HeaderText = "haircolor";
		((DataControlField)val).SortExpression = "haircolor";
		return val;
	}

	[DebuggerNonUserCode]
	private BoundField __BuildControl__control224()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		BoundField val = new BoundField();
		val.DataField = "bloodtype";
		val.HeaderText = "bloodtype";
		((DataControlField)val).SortExpression = "bloodtype";
		return val;
	}

	[DebuggerNonUserCode]
	private BoundField __BuildControl__control225()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		BoundField val = new BoundField();
		val.DataField = "Code";
		val.HeaderText = "Code";
		((DataControlField)val).SortExpression = "Code";
		return val;
	}

	[DebuggerNonUserCode]
	private BoundField __BuildControl__control226()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		BoundField val = new BoundField();
		val.DataField = "c1";
		val.HeaderText = "c1";
		((DataControlField)val).SortExpression = "c1";
		return val;
	}

	[DebuggerNonUserCode]
	private BoundField __BuildControl__control227()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		BoundField val = new BoundField();
		val.DataField = "o1";
		val.HeaderText = "o1";
		((DataControlField)val).SortExpression = "o1";
		return val;
	}

	[DebuggerNonUserCode]
	private BoundField __BuildControl__control228()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		BoundField val = new BoundField();
		val.DataField = "c2";
		val.HeaderText = "c2";
		((DataControlField)val).SortExpression = "c2";
		return val;
	}

	[DebuggerNonUserCode]
	private BoundField __BuildControl__control229()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		BoundField val = new BoundField();
		val.DataField = "o2";
		val.HeaderText = "o2";
		((DataControlField)val).SortExpression = "o2";
		return val;
	}

	[DebuggerNonUserCode]
	private BoundField __BuildControl__control230()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		BoundField val = new BoundField();
		val.DataField = "c3";
		val.HeaderText = "c3";
		((DataControlField)val).SortExpression = "c3";
		return val;
	}

	[DebuggerNonUserCode]
	private BoundField __BuildControl__control231()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		BoundField val = new BoundField();
		val.DataField = "o3";
		val.HeaderText = "o3";
		((DataControlField)val).SortExpression = "o3";
		return val;
	}

	[DebuggerNonUserCode]
	private BoundField __BuildControl__control232()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		BoundField val = new BoundField();
		val.DataField = "c4";
		val.HeaderText = "c4";
		((DataControlField)val).SortExpression = "c4";
		return val;
	}

	[DebuggerNonUserCode]
	private BoundField __BuildControl__control233()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		BoundField val = new BoundField();
		val.DataField = "o4";
		val.HeaderText = "o4";
		((DataControlField)val).SortExpression = "o4";
		return val;
	}

	[DebuggerNonUserCode]
	private BoundField __BuildControl__control234()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		BoundField val = new BoundField();
		val.DataField = "c5";
		val.HeaderText = "c5";
		((DataControlField)val).SortExpression = "c5";
		return val;
	}

	[DebuggerNonUserCode]
	private BoundField __BuildControl__control235()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		BoundField val = new BoundField();
		val.DataField = "o5";
		val.HeaderText = "o5";
		((DataControlField)val).SortExpression = "o5";
		return val;
	}

	[DebuggerNonUserCode]
	private BoundField __BuildControl__control236()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		BoundField val = new BoundField();
		val.DataField = "c6";
		val.HeaderText = "c6";
		((DataControlField)val).SortExpression = "c6";
		return val;
	}

	[DebuggerNonUserCode]
	private BoundField __BuildControl__control237()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		BoundField val = new BoundField();
		val.DataField = "o6";
		val.HeaderText = "o6";
		((DataControlField)val).SortExpression = "o6";
		return val;
	}

	[DebuggerNonUserCode]
	private BoundField __BuildControl__control238()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		BoundField val = new BoundField();
		val.DataField = "c7";
		val.HeaderText = "c7";
		((DataControlField)val).SortExpression = "c7";
		return val;
	}

	[DebuggerNonUserCode]
	private BoundField __BuildControl__control239()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		BoundField val = new BoundField();
		val.DataField = "o7";
		val.HeaderText = "o7";
		((DataControlField)val).SortExpression = "o7";
		return val;
	}

	[DebuggerNonUserCode]
	private BoundField __BuildControl__control240()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		BoundField val = new BoundField();
		val.DataField = "c8";
		val.HeaderText = "c8";
		((DataControlField)val).SortExpression = "c8";
		return val;
	}

	[DebuggerNonUserCode]
	private BoundField __BuildControl__control241()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		BoundField val = new BoundField();
		val.DataField = "o8";
		val.HeaderText = "o8";
		((DataControlField)val).SortExpression = "o8";
		return val;
	}

	[DebuggerNonUserCode]
	private BoundField __BuildControl__control242()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		BoundField val = new BoundField();
		val.DataField = "m1";
		val.HeaderText = "m1";
		((DataControlField)val).SortExpression = "m1";
		return val;
	}

	[DebuggerNonUserCode]
	private BoundField __BuildControl__control243()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		BoundField val = new BoundField();
		val.DataField = "l1";
		val.HeaderText = "l1";
		((DataControlField)val).SortExpression = "l1";
		return val;
	}

	[DebuggerNonUserCode]
	private BoundField __BuildControl__control244()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		BoundField val = new BoundField();
		val.DataField = "m2";
		val.HeaderText = "m2";
		((DataControlField)val).SortExpression = "m2";
		return val;
	}

	[DebuggerNonUserCode]
	private BoundField __BuildControl__control245()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		BoundField val = new BoundField();
		val.DataField = "l2";
		val.HeaderText = "l2";
		((DataControlField)val).SortExpression = "l2";
		return val;
	}

	[DebuggerNonUserCode]
	private BoundField __BuildControl__control246()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		BoundField val = new BoundField();
		val.DataField = "m3";
		val.HeaderText = "m3";
		((DataControlField)val).SortExpression = "m3";
		return val;
	}

	[DebuggerNonUserCode]
	private BoundField __BuildControl__control247()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		BoundField val = new BoundField();
		val.DataField = "l3";
		val.HeaderText = "l3";
		((DataControlField)val).SortExpression = "l3";
		return val;
	}

	[DebuggerNonUserCode]
	private BoundField __BuildControl__control248()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		BoundField val = new BoundField();
		val.DataField = "m4";
		val.HeaderText = "m4";
		((DataControlField)val).SortExpression = "m4";
		return val;
	}

	[DebuggerNonUserCode]
	private BoundField __BuildControl__control249()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		BoundField val = new BoundField();
		val.DataField = "l4";
		val.HeaderText = "l4";
		((DataControlField)val).SortExpression = "l4";
		return val;
	}

	[DebuggerNonUserCode]
	private BoundField __BuildControl__control250()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		BoundField val = new BoundField();
		val.DataField = "m5";
		val.HeaderText = "m5";
		((DataControlField)val).SortExpression = "m5";
		return val;
	}

	[DebuggerNonUserCode]
	private BoundField __BuildControl__control251()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		BoundField val = new BoundField();
		val.DataField = "l5";
		val.HeaderText = "l5";
		((DataControlField)val).SortExpression = "l5";
		return val;
	}

	[DebuggerNonUserCode]
	private BoundField __BuildControl__control252()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		BoundField val = new BoundField();
		val.DataField = "m6";
		val.HeaderText = "m6";
		((DataControlField)val).SortExpression = "m6";
		return val;
	}

	[DebuggerNonUserCode]
	private BoundField __BuildControl__control253()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		BoundField val = new BoundField();
		val.DataField = "l6";
		val.HeaderText = "l6";
		((DataControlField)val).SortExpression = "l6";
		return val;
	}

	[DebuggerNonUserCode]
	private BoundField __BuildControl__control254()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		BoundField val = new BoundField();
		val.DataField = "m7";
		val.HeaderText = "m7";
		((DataControlField)val).SortExpression = "m7";
		return val;
	}

	[DebuggerNonUserCode]
	private BoundField __BuildControl__control255()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		BoundField val = new BoundField();
		val.DataField = "l7";
		val.HeaderText = "l7";
		((DataControlField)val).SortExpression = "l7";
		return val;
	}

	[DebuggerNonUserCode]
	private BoundField __BuildControl__control256()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		BoundField val = new BoundField();
		val.DataField = "m8";
		val.HeaderText = "m8";
		((DataControlField)val).SortExpression = "m8";
		return val;
	}

	[DebuggerNonUserCode]
	private BoundField __BuildControl__control257()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		BoundField val = new BoundField();
		val.DataField = "l8";
		val.HeaderText = "l8";
		((DataControlField)val).SortExpression = "l8";
		return val;
	}

	[DebuggerNonUserCode]
	private BoundField __BuildControl__control258()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		BoundField val = new BoundField();
		val.DataField = "Email";
		val.HeaderText = "Email";
		((DataControlField)val).SortExpression = "Email";
		return val;
	}

	[DebuggerNonUserCode]
	private BoundField __BuildControl__control259()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		BoundField val = new BoundField();
		val.DataField = "CreateDate";
		val.HeaderText = "CreateDate";
		((DataControlField)val).SortExpression = "CreateDate";
		return val;
	}

	[DebuggerNonUserCode]
	private BoundField __BuildControl__control260()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		BoundField val = new BoundField();
		val.DataField = "LastLoginDate";
		val.HeaderText = "LastLoginDate";
		((DataControlField)val).SortExpression = "LastLoginDate";
		return val;
	}

	[DebuggerNonUserCode]
	private BoundField __BuildControl__control261()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		BoundField val = new BoundField();
		val.DataField = "race";
		val.HeaderText = "race";
		((DataControlField)val).SortExpression = "race";
		return val;
	}

	[DebuggerNonUserCode]
	private BoundField __BuildControl__control262()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		BoundField val = new BoundField();
		val.DataField = "comment";
		val.HeaderText = "comment";
		((DataControlField)val).SortExpression = "comment";
		return val;
	}

	[DebuggerNonUserCode]
	private BoundField __BuildControl__control263()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		BoundField val = new BoundField();
		val.DataField = "UserName";
		val.HeaderText = "UserName";
		((DataControlField)val).SortExpression = "UserName";
		return val;
	}

	[DebuggerNonUserCode]
	private CommandField __BuildControl__control264()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		CommandField val = new CommandField();
		val.ShowInsertButton = true;
		return val;
	}

	[DebuggerNonUserCode]
	private void __BuildControl__control197(DataControlFieldCollection __ctrl)
	{
		CommandField val = __BuildControl__control198();
		__ctrl.Add((DataControlField)(object)val);
		BoundField val2 = __BuildControl__control199();
		__ctrl.Add((DataControlField)(object)val2);
		BoundField val3 = __BuildControl__control200();
		__ctrl.Add((DataControlField)(object)val3);
		BoundField val4 = __BuildControl__control201();
		__ctrl.Add((DataControlField)(object)val4);
		BoundField val5 = __BuildControl__control202();
		__ctrl.Add((DataControlField)(object)val5);
		BoundField val6 = __BuildControl__control203();
		__ctrl.Add((DataControlField)(object)val6);
		CheckBoxField val7 = __BuildControl__control204();
		__ctrl.Add((DataControlField)(object)val7);
		BoundField val8 = __BuildControl__control205();
		__ctrl.Add((DataControlField)(object)val8);
		BoundField val9 = __BuildControl__control206();
		__ctrl.Add((DataControlField)(object)val9);
		BoundField val10 = __BuildControl__control207();
		__ctrl.Add((DataControlField)(object)val10);
		BoundField val11 = __BuildControl__control208();
		__ctrl.Add((DataControlField)(object)val11);
		BoundField val12 = __BuildControl__control209();
		__ctrl.Add((DataControlField)(object)val12);
		BoundField val13 = __BuildControl__control210();
		__ctrl.Add((DataControlField)(object)val13);
		BoundField val14 = __BuildControl__control211();
		__ctrl.Add((DataControlField)(object)val14);
		BoundField val15 = __BuildControl__control212();
		__ctrl.Add((DataControlField)(object)val15);
		BoundField val16 = __BuildControl__control213();
		__ctrl.Add((DataControlField)(object)val16);
		BoundField val17 = __BuildControl__control214();
		__ctrl.Add((DataControlField)(object)val17);
		BoundField val18 = __BuildControl__control215();
		__ctrl.Add((DataControlField)(object)val18);
		BoundField val19 = __BuildControl__control216();
		__ctrl.Add((DataControlField)(object)val19);
		BoundField val20 = __BuildControl__control217();
		__ctrl.Add((DataControlField)(object)val20);
		BoundField val21 = __BuildControl__control218();
		__ctrl.Add((DataControlField)(object)val21);
		CheckBoxField val22 = __BuildControl__control219();
		__ctrl.Add((DataControlField)(object)val22);
		BoundField val23 = __BuildControl__control220();
		__ctrl.Add((DataControlField)(object)val23);
		BoundField val24 = __BuildControl__control221();
		__ctrl.Add((DataControlField)(object)val24);
		BoundField val25 = __BuildControl__control222();
		__ctrl.Add((DataControlField)(object)val25);
		BoundField val26 = __BuildControl__control223();
		__ctrl.Add((DataControlField)(object)val26);
		BoundField val27 = __BuildControl__control224();
		__ctrl.Add((DataControlField)(object)val27);
		BoundField val28 = __BuildControl__control225();
		__ctrl.Add((DataControlField)(object)val28);
		BoundField val29 = __BuildControl__control226();
		__ctrl.Add((DataControlField)(object)val29);
		BoundField val30 = __BuildControl__control227();
		__ctrl.Add((DataControlField)(object)val30);
		BoundField val31 = __BuildControl__control228();
		__ctrl.Add((DataControlField)(object)val31);
		BoundField val32 = __BuildControl__control229();
		__ctrl.Add((DataControlField)(object)val32);
		BoundField val33 = __BuildControl__control230();
		__ctrl.Add((DataControlField)(object)val33);
		BoundField val34 = __BuildControl__control231();
		__ctrl.Add((DataControlField)(object)val34);
		BoundField val35 = __BuildControl__control232();
		__ctrl.Add((DataControlField)(object)val35);
		BoundField val36 = __BuildControl__control233();
		__ctrl.Add((DataControlField)(object)val36);
		BoundField val37 = __BuildControl__control234();
		__ctrl.Add((DataControlField)(object)val37);
		BoundField val38 = __BuildControl__control235();
		__ctrl.Add((DataControlField)(object)val38);
		BoundField val39 = __BuildControl__control236();
		__ctrl.Add((DataControlField)(object)val39);
		BoundField val40 = __BuildControl__control237();
		__ctrl.Add((DataControlField)(object)val40);
		BoundField val41 = __BuildControl__control238();
		__ctrl.Add((DataControlField)(object)val41);
		BoundField val42 = __BuildControl__control239();
		__ctrl.Add((DataControlField)(object)val42);
		BoundField val43 = __BuildControl__control240();
		__ctrl.Add((DataControlField)(object)val43);
		BoundField val44 = __BuildControl__control241();
		__ctrl.Add((DataControlField)(object)val44);
		BoundField val45 = __BuildControl__control242();
		__ctrl.Add((DataControlField)(object)val45);
		BoundField val46 = __BuildControl__control243();
		__ctrl.Add((DataControlField)(object)val46);
		BoundField val47 = __BuildControl__control244();
		__ctrl.Add((DataControlField)(object)val47);
		BoundField val48 = __BuildControl__control245();
		__ctrl.Add((DataControlField)(object)val48);
		BoundField val49 = __BuildControl__control246();
		__ctrl.Add((DataControlField)(object)val49);
		BoundField val50 = __BuildControl__control247();
		__ctrl.Add((DataControlField)(object)val50);
		BoundField val51 = __BuildControl__control248();
		__ctrl.Add((DataControlField)(object)val51);
		BoundField val52 = __BuildControl__control249();
		__ctrl.Add((DataControlField)(object)val52);
		BoundField val53 = __BuildControl__control250();
		__ctrl.Add((DataControlField)(object)val53);
		BoundField val54 = __BuildControl__control251();
		__ctrl.Add((DataControlField)(object)val54);
		BoundField val55 = __BuildControl__control252();
		__ctrl.Add((DataControlField)(object)val55);
		BoundField val56 = __BuildControl__control253();
		__ctrl.Add((DataControlField)(object)val56);
		BoundField val57 = __BuildControl__control254();
		__ctrl.Add((DataControlField)(object)val57);
		BoundField val58 = __BuildControl__control255();
		__ctrl.Add((DataControlField)(object)val58);
		BoundField val59 = __BuildControl__control256();
		__ctrl.Add((DataControlField)(object)val59);
		BoundField val60 = __BuildControl__control257();
		__ctrl.Add((DataControlField)(object)val60);
		BoundField val61 = __BuildControl__control258();
		__ctrl.Add((DataControlField)(object)val61);
		BoundField val62 = __BuildControl__control259();
		__ctrl.Add((DataControlField)(object)val62);
		BoundField val63 = __BuildControl__control260();
		__ctrl.Add((DataControlField)(object)val63);
		BoundField val64 = __BuildControl__control261();
		__ctrl.Add((DataControlField)(object)val64);
		BoundField val65 = __BuildControl__control262();
		__ctrl.Add((DataControlField)(object)val65);
		BoundField val66 = __BuildControl__control263();
		__ctrl.Add((DataControlField)(object)val66);
		CommandField val67 = __BuildControl__control264();
		__ctrl.Add((DataControlField)(object)val67);
	}

	[DebuggerNonUserCode]
	private DetailsView __BuildControlDetailsView2()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		DetailsView val = (DetailsView2 = new DetailsView());
		((Control)val).ApplyStyleSheetSkin((Page)(object)this);
		((Control)val).ID = "DetailsView2";
		val.AutoGenerateRows = false;
		((DataBoundControl)val).DataSourceID = "SqlDataSource2";
		Unit height = new Unit(50.0, (UnitType)1);
		((WebControl)val).Height = height;
		height = new Unit(125.0, (UnitType)1);
		((WebControl)val).Width = height;
		__BuildControl__control197(val.Fields);
		return val;
	}

	[DebuggerNonUserCode]
	private View __BuildControlView2()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Expected Obj, but got Unknown
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Expected Obj, but got Unknown
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		//IL_006c: Expected Obj, but got Unknown
		View val = (View2 = new View());
		((Control)val).ID = "View2";
		IParserAccessor val3 = (IParserAccessor)(object)val;
		val3.AddParsedSubObject((object)new LiteralControl("\r\n                    "));
		SqlDataSource val4 = __BuildControl__control134();
		val3.AddParsedSubObject((object)val4);
		val3.AddParsedSubObject((object)new LiteralControl("\r\n                        "));
		DetailsView val5 = __BuildControlDetailsView2();
		val3.AddParsedSubObject((object)val5);
		val3.AddParsedSubObject((object)new LiteralControl("\r\n      "));
		return val;
	}

	[DebuggerNonUserCode]
	private LinkButton __BuildControl__control266()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		LinkButton val = new LinkButton();
		((Control)val).TemplateControl = (TemplateControl)(object)this;
		((Control)val).ApplyStyleSheetSkin((Page)(object)this);
		((Control)val).ID = "LinkButton1";
		val.CausesValidation = false;
		val.CommandName = "New";
		val.Text = "New";
		return val;
	}

	[DebuggerNonUserCode]
	private void __BuildControl__control265(Control __ctrl)
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Expected Obj, but got Unknown
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Expected Obj, but got Unknown
		((IParserAccessor)__ctrl).AddParsedSubObject((object)new LiteralControl("\r\n                                No complaints has entered during the registration.<br />\r\n                                "));
		LinkButton val = __BuildControl__control266();
		((IParserAccessor)__ctrl).AddParsedSubObject((object)val);
		((IParserAccessor)__ctrl).AddParsedSubObject((object)new LiteralControl("\r\n                            "));
	}

	[DebuggerNonUserCode]
	private CommandField __BuildControl__control268()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		CommandField val = new CommandField();
		val.ShowEditButton = true;
		return val;
	}

	[DebuggerNonUserCode]
	private BoundField __BuildControl__control269()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		BoundField val = new BoundField();
		val.DataField = "c1";
		val.HeaderText = "c1";
		((DataControlField)val).SortExpression = "c1";
		return val;
	}

	[DebuggerNonUserCode]
	private BoundField __BuildControl__control270()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		BoundField val = new BoundField();
		val.DataField = "o1";
		val.HeaderText = "o1";
		((DataControlField)val).SortExpression = "o1";
		return val;
	}

	[DebuggerNonUserCode]
	private BoundField __BuildControl__control271()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		BoundField val = new BoundField();
		val.DataField = "c2";
		val.HeaderText = "c2";
		((DataControlField)val).SortExpression = "c2";
		return val;
	}

	[DebuggerNonUserCode]
	private BoundField __BuildControl__control272()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		BoundField val = new BoundField();
		val.DataField = "o2";
		val.HeaderText = "o2";
		((DataControlField)val).SortExpression = "o2";
		return val;
	}

	[DebuggerNonUserCode]
	private BoundField __BuildControl__control273()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		BoundField val = new BoundField();
		val.DataField = "c3";
		val.HeaderText = "c3";
		((DataControlField)val).SortExpression = "c3";
		return val;
	}

	[DebuggerNonUserCode]
	private BoundField __BuildControl__control274()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		BoundField val = new BoundField();
		val.DataField = "o3";
		val.HeaderText = "o3";
		((DataControlField)val).SortExpression = "o3";
		return val;
	}

	[DebuggerNonUserCode]
	private BoundField __BuildControl__control275()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		BoundField val = new BoundField();
		val.DataField = "c4";
		val.HeaderText = "c4";
		((DataControlField)val).SortExpression = "c4";
		return val;
	}

	[DebuggerNonUserCode]
	private BoundField __BuildControl__control276()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		BoundField val = new BoundField();
		val.DataField = "o4";
		val.HeaderText = "o4";
		((DataControlField)val).SortExpression = "o4";
		return val;
	}

	[DebuggerNonUserCode]
	private BoundField __BuildControl__control277()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		BoundField val = new BoundField();
		val.DataField = "c5";
		val.HeaderText = "c5";
		((DataControlField)val).SortExpression = "c5";
		return val;
	}

	[DebuggerNonUserCode]
	private BoundField __BuildControl__control278()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		BoundField val = new BoundField();
		val.DataField = "o5";
		val.HeaderText = "o5";
		((DataControlField)val).SortExpression = "o5";
		return val;
	}

	[DebuggerNonUserCode]
	private BoundField __BuildControl__control279()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		BoundField val = new BoundField();
		val.DataField = "c6";
		val.HeaderText = "c6";
		((DataControlField)val).SortExpression = "c6";
		return val;
	}

	[DebuggerNonUserCode]
	private BoundField __BuildControl__control280()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		BoundField val = new BoundField();
		val.DataField = "o6";
		val.HeaderText = "o6";
		((DataControlField)val).SortExpression = "o6";
		return val;
	}

	[DebuggerNonUserCode]
	private BoundField __BuildControl__control281()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		BoundField val = new BoundField();
		val.DataField = "c7";
		val.HeaderText = "c7";
		((DataControlField)val).SortExpression = "c7";
		return val;
	}

	[DebuggerNonUserCode]
	private BoundField __BuildControl__control282()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		BoundField val = new BoundField();
		val.DataField = "o7";
		val.HeaderText = "o7";
		((DataControlField)val).SortExpression = "o7";
		return val;
	}

	[DebuggerNonUserCode]
	private BoundField __BuildControl__control283()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		BoundField val = new BoundField();
		val.DataField = "c8";
		val.HeaderText = "c8";
		((DataControlField)val).SortExpression = "c8";
		return val;
	}

	[DebuggerNonUserCode]
	private BoundField __BuildControl__control284()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		BoundField val = new BoundField();
		val.DataField = "o8";
		val.HeaderText = "o8";
		((DataControlField)val).SortExpression = "o8";
		return val;
	}

	[DebuggerNonUserCode]
	private BoundField __BuildControl__control285()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		BoundField val = new BoundField();
		val.DataField = "m1";
		val.HeaderText = "m1";
		((DataControlField)val).SortExpression = "m1";
		return val;
	}

	[DebuggerNonUserCode]
	private BoundField __BuildControl__control286()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		BoundField val = new BoundField();
		val.DataField = "l1";
		val.HeaderText = "l1";
		((DataControlField)val).SortExpression = "l1";
		return val;
	}

	[DebuggerNonUserCode]
	private BoundField __BuildControl__control287()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		BoundField val = new BoundField();
		val.DataField = "m2";
		val.HeaderText = "m2";
		((DataControlField)val).SortExpression = "m2";
		return val;
	}

	[DebuggerNonUserCode]
	private BoundField __BuildControl__control288()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		BoundField val = new BoundField();
		val.DataField = "l2";
		val.HeaderText = "l2";
		((DataControlField)val).SortExpression = "l2";
		return val;
	}

	[DebuggerNonUserCode]
	private BoundField __BuildControl__control289()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		BoundField val = new BoundField();
		val.DataField = "m3";
		val.HeaderText = "m3";
		((DataControlField)val).SortExpression = "m3";
		return val;
	}

	[DebuggerNonUserCode]
	private BoundField __BuildControl__control290()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		BoundField val = new BoundField();
		val.DataField = "l3";
		val.HeaderText = "l3";
		((DataControlField)val).SortExpression = "l3";
		return val;
	}

	[DebuggerNonUserCode]
	private BoundField __BuildControl__control291()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		BoundField val = new BoundField();
		val.DataField = "m4";
		val.HeaderText = "m4";
		((DataControlField)val).SortExpression = "m4";
		return val;
	}

	[DebuggerNonUserCode]
	private BoundField __BuildControl__control292()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		BoundField val = new BoundField();
		val.DataField = "l4";
		val.HeaderText = "l4";
		((DataControlField)val).SortExpression = "l4";
		return val;
	}

	[DebuggerNonUserCode]
	private BoundField __BuildControl__control293()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		BoundField val = new BoundField();
		val.DataField = "m5";
		val.HeaderText = "m5";
		((DataControlField)val).SortExpression = "m5";
		return val;
	}

	[DebuggerNonUserCode]
	private BoundField __BuildControl__control294()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		BoundField val = new BoundField();
		val.DataField = "l5";
		val.HeaderText = "l5";
		((DataControlField)val).SortExpression = "l5";
		return val;
	}

	[DebuggerNonUserCode]
	private BoundField __BuildControl__control295()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		BoundField val = new BoundField();
		val.DataField = "m6";
		val.HeaderText = "m6";
		((DataControlField)val).SortExpression = "m6";
		return val;
	}

	[DebuggerNonUserCode]
	private BoundField __BuildControl__control296()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		BoundField val = new BoundField();
		val.DataField = "l6";
		val.HeaderText = "l6";
		((DataControlField)val).SortExpression = "l6";
		return val;
	}

	[DebuggerNonUserCode]
	private BoundField __BuildControl__control297()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		BoundField val = new BoundField();
		val.DataField = "m7";
		val.HeaderText = "m7";
		((DataControlField)val).SortExpression = "m7";
		return val;
	}

	[DebuggerNonUserCode]
	private BoundField __BuildControl__control298()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		BoundField val = new BoundField();
		val.DataField = "l7";
		val.HeaderText = "l7";
		((DataControlField)val).SortExpression = "l7";
		return val;
	}

	[DebuggerNonUserCode]
	private BoundField __BuildControl__control299()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		BoundField val = new BoundField();
		val.DataField = "m8";
		val.HeaderText = "m8";
		((DataControlField)val).SortExpression = "m8";
		return val;
	}

	[DebuggerNonUserCode]
	private BoundField __BuildControl__control300()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		BoundField val = new BoundField();
		val.DataField = "l8";
		val.HeaderText = "l8";
		((DataControlField)val).SortExpression = "l8";
		return val;
	}

	[DebuggerNonUserCode]
	private BoundField __BuildControl__control301()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		BoundField val = new BoundField();
		val.DataField = "UserName";
		val.HeaderText = "UserName";
		val.ReadOnly = true;
		((DataControlField)val).SortExpression = "UserName";
		return val;
	}

	[DebuggerNonUserCode]
	private BoundField __BuildControl__control302()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		BoundField val = new BoundField();
		val.DataField = "comment";
		val.HeaderText = "comment";
		((DataControlField)val).SortExpression = "comment";
		return val;
	}

	[DebuggerNonUserCode]
	private LinkButton __BuildControl__control305()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		LinkButton val = new LinkButton();
		((Control)val).TemplateControl = (TemplateControl)(object)this;
		((Control)val).ApplyStyleSheetSkin((Page)(object)this);
		((Control)val).ID = "LinkButton1";
		val.CausesValidation = true;
		val.CommandName = "Insert";
		val.Text = "Insert";
		return val;
	}

	[DebuggerNonUserCode]
	private LinkButton __BuildControl__control306()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		LinkButton val = new LinkButton();
		((Control)val).TemplateControl = (TemplateControl)(object)this;
		((Control)val).ApplyStyleSheetSkin((Page)(object)this);
		((Control)val).ID = "LinkButton2";
		val.CausesValidation = false;
		val.CommandName = "Cancel";
		val.Text = "Cancel";
		return val;
	}

	[DebuggerNonUserCode]
	private void __BuildControl__control304(Control __ctrl)
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Expected Obj, but got Unknown
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Expected Obj, but got Unknown
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_004e: Expected Obj, but got Unknown
		((IParserAccessor)__ctrl).AddParsedSubObject((object)new LiteralControl("\r\n                                        "));
		LinkButton val = __BuildControl__control305();
		((IParserAccessor)__ctrl).AddParsedSubObject((object)val);
		((IParserAccessor)__ctrl).AddParsedSubObject((object)new LiteralControl("\r\n                                        &nbsp;"));
		LinkButton val2 = __BuildControl__control306();
		((IParserAccessor)__ctrl).AddParsedSubObject((object)val2);
		((IParserAccessor)__ctrl).AddParsedSubObject((object)new LiteralControl("\r\n                                    "));
	}

	[DebuggerNonUserCode]
	private LinkButton __BuildControl__control308()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		LinkButton val = new LinkButton();
		((Control)val).TemplateControl = (TemplateControl)(object)this;
		((Control)val).ApplyStyleSheetSkin((Page)(object)this);
		((Control)val).ID = "LinkButton1";
		val.CausesValidation = false;
		val.CommandName = "New";
		val.Text = "New";
		return val;
	}

	[DebuggerNonUserCode]
	private void __BuildControl__control307(Control __ctrl)
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Expected Obj, but got Unknown
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Expected Obj, but got Unknown
		((IParserAccessor)__ctrl).AddParsedSubObject((object)new LiteralControl("\r\n                                        "));
		LinkButton val = __BuildControl__control308();
		((IParserAccessor)__ctrl).AddParsedSubObject((object)val);
		((IParserAccessor)__ctrl).AddParsedSubObject((object)new LiteralControl("\r\n                                    "));
	}

	[DebuggerNonUserCode]
	private TemplateField __BuildControl__control303()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Expected Obj, but got Unknown
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Expected Obj, but got Unknown
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Expected Obj, but got Unknown
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Expected Obj, but got Unknown
		TemplateField val = new TemplateField();
		val.InsertItemTemplate = (ITemplate)new CompiledBindableTemplateBuilder((BuildTemplateMethod)__BuildControl__control304, (ExtractTemplateValuesMethod)null);
		val.ItemTemplate = (ITemplate)new CompiledBindableTemplateBuilder((BuildTemplateMethod)__BuildControl__control307, (ExtractTemplateValuesMethod)null);
		((DataControlField)val).ShowHeader = false;
		return val;
	}

	[DebuggerNonUserCode]
	private void __BuildControl__control267(DataControlFieldCollection __ctrl)
	{
		CommandField val = __BuildControl__control268();
		__ctrl.Add((DataControlField)(object)val);
		BoundField val2 = __BuildControl__control269();
		__ctrl.Add((DataControlField)(object)val2);
		BoundField val3 = __BuildControl__control270();
		__ctrl.Add((DataControlField)(object)val3);
		BoundField val4 = __BuildControl__control271();
		__ctrl.Add((DataControlField)(object)val4);
		BoundField val5 = __BuildControl__control272();
		__ctrl.Add((DataControlField)(object)val5);
		BoundField val6 = __BuildControl__control273();
		__ctrl.Add((DataControlField)(object)val6);
		BoundField val7 = __BuildControl__control274();
		__ctrl.Add((DataControlField)(object)val7);
		BoundField val8 = __BuildControl__control275();
		__ctrl.Add((DataControlField)(object)val8);
		BoundField val9 = __BuildControl__control276();
		__ctrl.Add((DataControlField)(object)val9);
		BoundField val10 = __BuildControl__control277();
		__ctrl.Add((DataControlField)(object)val10);
		BoundField val11 = __BuildControl__control278();
		__ctrl.Add((DataControlField)(object)val11);
		BoundField val12 = __BuildControl__control279();
		__ctrl.Add((DataControlField)(object)val12);
		BoundField val13 = __BuildControl__control280();
		__ctrl.Add((DataControlField)(object)val13);
		BoundField val14 = __BuildControl__control281();
		__ctrl.Add((DataControlField)(object)val14);
		BoundField val15 = __BuildControl__control282();
		__ctrl.Add((DataControlField)(object)val15);
		BoundField val16 = __BuildControl__control283();
		__ctrl.Add((DataControlField)(object)val16);
		BoundField val17 = __BuildControl__control284();
		__ctrl.Add((DataControlField)(object)val17);
		BoundField val18 = __BuildControl__control285();
		__ctrl.Add((DataControlField)(object)val18);
		BoundField val19 = __BuildControl__control286();
		__ctrl.Add((DataControlField)(object)val19);
		BoundField val20 = __BuildControl__control287();
		__ctrl.Add((DataControlField)(object)val20);
		BoundField val21 = __BuildControl__control288();
		__ctrl.Add((DataControlField)(object)val21);
		BoundField val22 = __BuildControl__control289();
		__ctrl.Add((DataControlField)(object)val22);
		BoundField val23 = __BuildControl__control290();
		__ctrl.Add((DataControlField)(object)val23);
		BoundField val24 = __BuildControl__control291();
		__ctrl.Add((DataControlField)(object)val24);
		BoundField val25 = __BuildControl__control292();
		__ctrl.Add((DataControlField)(object)val25);
		BoundField val26 = __BuildControl__control293();
		__ctrl.Add((DataControlField)(object)val26);
		BoundField val27 = __BuildControl__control294();
		__ctrl.Add((DataControlField)(object)val27);
		BoundField val28 = __BuildControl__control295();
		__ctrl.Add((DataControlField)(object)val28);
		BoundField val29 = __BuildControl__control296();
		__ctrl.Add((DataControlField)(object)val29);
		BoundField val30 = __BuildControl__control297();
		__ctrl.Add((DataControlField)(object)val30);
		BoundField val31 = __BuildControl__control298();
		__ctrl.Add((DataControlField)(object)val31);
		BoundField val32 = __BuildControl__control299();
		__ctrl.Add((DataControlField)(object)val32);
		BoundField val33 = __BuildControl__control300();
		__ctrl.Add((DataControlField)(object)val33);
		BoundField val34 = __BuildControl__control301();
		__ctrl.Add((DataControlField)(object)val34);
		BoundField val35 = __BuildControl__control302();
		__ctrl.Add((DataControlField)(object)val35);
		TemplateField val36 = __BuildControl__control303();
		__ctrl.Add((DataControlField)(object)val36);
	}

	[DebuggerNonUserCode]
	private DetailsView __BuildControlDetailsView3()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Expected Obj, but got Unknown
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Expected Obj, but got Unknown
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0071: Unknown result type (might be due to invalid IL or missing references)
		//IL_0085: Unknown result type (might be due to invalid IL or missing references)
		//IL_008a: Unknown result type (might be due to invalid IL or missing references)
		DetailsView val = (DetailsView3 = new DetailsView());
		((Control)val).ApplyStyleSheetSkin((Page)(object)this);
		val.EmptyDataTemplate = (ITemplate)new CompiledTemplateBuilder((BuildTemplateMethod)__BuildControl__control265);
		((Control)val).ID = "DetailsView3";
		val.AutoGenerateRows = false;
		val.DataKeyNames = new string[1] { "UserName" };
		((DataBoundControl)val).DataSourceID = "SqlDataSource3";
		Unit height = new Unit(50.0, (UnitType)1);
		((WebControl)val).Height = height;
		height = new Unit(125.0, (UnitType)1);
		((WebControl)val).Width = height;
		__BuildControl__control267(val.Fields);
		return val;
	}

	[DebuggerNonUserCode]
	private QueryStringParameter __BuildControl__control310()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		QueryStringParameter val = new QueryStringParameter();
		((Parameter)val).Name = "UserName";
		val.QueryStringField = "un";
		return val;
	}

	[DebuggerNonUserCode]
	private void __BuildControl__control309(ParameterCollection __ctrl)
	{
		QueryStringParameter val = __BuildControl__control310();
		__ctrl.Add((Parameter)(object)val);
	}

	[DebuggerNonUserCode]
	private Parameter __BuildControl__control312()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Parameter val = new Parameter();
		val.Name = "UserName";
		val.Type = TypeCode.String;
		return val;
	}

	[DebuggerNonUserCode]
	private void __BuildControl__control311(ParameterCollection __ctrl)
	{
		Parameter val = __BuildControl__control312();
		__ctrl.Add(val);
	}

	[DebuggerNonUserCode]
	private Parameter __BuildControl__control314()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Parameter val = new Parameter();
		val.Name = "c1";
		val.Type = TypeCode.String;
		return val;
	}

	[DebuggerNonUserCode]
	private Parameter __BuildControl__control315()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Parameter val = new Parameter();
		val.Name = "o1";
		val.Type = TypeCode.String;
		return val;
	}

	[DebuggerNonUserCode]
	private Parameter __BuildControl__control316()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Parameter val = new Parameter();
		val.Name = "c2";
		val.Type = TypeCode.String;
		return val;
	}

	[DebuggerNonUserCode]
	private Parameter __BuildControl__control317()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Parameter val = new Parameter();
		val.Name = "o2";
		val.Type = TypeCode.String;
		return val;
	}

	[DebuggerNonUserCode]
	private Parameter __BuildControl__control318()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Parameter val = new Parameter();
		val.Name = "c3";
		val.Type = TypeCode.String;
		return val;
	}

	[DebuggerNonUserCode]
	private Parameter __BuildControl__control319()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Parameter val = new Parameter();
		val.Name = "o3";
		val.Type = TypeCode.String;
		return val;
	}

	[DebuggerNonUserCode]
	private Parameter __BuildControl__control320()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Parameter val = new Parameter();
		val.Name = "c4";
		val.Type = TypeCode.String;
		return val;
	}

	[DebuggerNonUserCode]
	private Parameter __BuildControl__control321()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Parameter val = new Parameter();
		val.Name = "o4";
		val.Type = TypeCode.String;
		return val;
	}

	[DebuggerNonUserCode]
	private Parameter __BuildControl__control322()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Parameter val = new Parameter();
		val.Name = "c5";
		val.Type = TypeCode.String;
		return val;
	}

	[DebuggerNonUserCode]
	private Parameter __BuildControl__control323()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Parameter val = new Parameter();
		val.Name = "o5";
		val.Type = TypeCode.String;
		return val;
	}

	[DebuggerNonUserCode]
	private Parameter __BuildControl__control324()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Parameter val = new Parameter();
		val.Name = "c6";
		val.Type = TypeCode.String;
		return val;
	}

	[DebuggerNonUserCode]
	private Parameter __BuildControl__control325()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Parameter val = new Parameter();
		val.Name = "o6";
		val.Type = TypeCode.String;
		return val;
	}

	[DebuggerNonUserCode]
	private Parameter __BuildControl__control326()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Parameter val = new Parameter();
		val.Name = "c7";
		val.Type = TypeCode.String;
		return val;
	}

	[DebuggerNonUserCode]
	private Parameter __BuildControl__control327()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Parameter val = new Parameter();
		val.Name = "o7";
		val.Type = TypeCode.String;
		return val;
	}

	[DebuggerNonUserCode]
	private Parameter __BuildControl__control328()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Parameter val = new Parameter();
		val.Name = "c8";
		val.Type = TypeCode.String;
		return val;
	}

	[DebuggerNonUserCode]
	private Parameter __BuildControl__control329()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Parameter val = new Parameter();
		val.Name = "o8";
		val.Type = TypeCode.String;
		return val;
	}

	[DebuggerNonUserCode]
	private Parameter __BuildControl__control330()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Parameter val = new Parameter();
		val.Name = "m1";
		val.Type = TypeCode.String;
		return val;
	}

	[DebuggerNonUserCode]
	private Parameter __BuildControl__control331()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Parameter val = new Parameter();
		val.Name = "l1";
		val.Type = TypeCode.String;
		return val;
	}

	[DebuggerNonUserCode]
	private Parameter __BuildControl__control332()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Parameter val = new Parameter();
		val.Name = "m2";
		val.Type = TypeCode.String;
		return val;
	}

	[DebuggerNonUserCode]
	private Parameter __BuildControl__control333()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Parameter val = new Parameter();
		val.Name = "l2";
		val.Type = TypeCode.String;
		return val;
	}

	[DebuggerNonUserCode]
	private Parameter __BuildControl__control334()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Parameter val = new Parameter();
		val.Name = "m3";
		val.Type = TypeCode.String;
		return val;
	}

	[DebuggerNonUserCode]
	private Parameter __BuildControl__control335()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Parameter val = new Parameter();
		val.Name = "l3";
		val.Type = TypeCode.String;
		return val;
	}

	[DebuggerNonUserCode]
	private Parameter __BuildControl__control336()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Parameter val = new Parameter();
		val.Name = "m4";
		val.Type = TypeCode.String;
		return val;
	}

	[DebuggerNonUserCode]
	private Parameter __BuildControl__control337()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Parameter val = new Parameter();
		val.Name = "l4";
		val.Type = TypeCode.String;
		return val;
	}

	[DebuggerNonUserCode]
	private Parameter __BuildControl__control338()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Parameter val = new Parameter();
		val.Name = "m5";
		val.Type = TypeCode.String;
		return val;
	}

	[DebuggerNonUserCode]
	private Parameter __BuildControl__control339()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Parameter val = new Parameter();
		val.Name = "l5";
		val.Type = TypeCode.String;
		return val;
	}

	[DebuggerNonUserCode]
	private Parameter __BuildControl__control340()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Parameter val = new Parameter();
		val.Name = "m6";
		val.Type = TypeCode.String;
		return val;
	}

	[DebuggerNonUserCode]
	private Parameter __BuildControl__control341()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Parameter val = new Parameter();
		val.Name = "l6";
		val.Type = TypeCode.String;
		return val;
	}

	[DebuggerNonUserCode]
	private Parameter __BuildControl__control342()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Parameter val = new Parameter();
		val.Name = "m7";
		val.Type = TypeCode.String;
		return val;
	}

	[DebuggerNonUserCode]
	private Parameter __BuildControl__control343()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Parameter val = new Parameter();
		val.Name = "l7";
		val.Type = TypeCode.String;
		return val;
	}

	[DebuggerNonUserCode]
	private Parameter __BuildControl__control344()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Parameter val = new Parameter();
		val.Name = "m8";
		val.Type = TypeCode.String;
		return val;
	}

	[DebuggerNonUserCode]
	private Parameter __BuildControl__control345()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Parameter val = new Parameter();
		val.Name = "l8";
		val.Type = TypeCode.String;
		return val;
	}

	[DebuggerNonUserCode]
	private Parameter __BuildControl__control346()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Parameter val = new Parameter();
		val.Name = "UserName";
		val.Type = TypeCode.String;
		return val;
	}

	[DebuggerNonUserCode]
	private Parameter __BuildControl__control347()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Parameter val = new Parameter();
		val.Name = "comment";
		val.Type = TypeCode.String;
		return val;
	}

	[DebuggerNonUserCode]
	private void __BuildControl__control313(ParameterCollection __ctrl)
	{
		Parameter val = __BuildControl__control314();
		__ctrl.Add(val);
		Parameter val2 = __BuildControl__control315();
		__ctrl.Add(val2);
		Parameter val3 = __BuildControl__control316();
		__ctrl.Add(val3);
		Parameter val4 = __BuildControl__control317();
		__ctrl.Add(val4);
		Parameter val5 = __BuildControl__control318();
		__ctrl.Add(val5);
		Parameter val6 = __BuildControl__control319();
		__ctrl.Add(val6);
		Parameter val7 = __BuildControl__control320();
		__ctrl.Add(val7);
		Parameter val8 = __BuildControl__control321();
		__ctrl.Add(val8);
		Parameter val9 = __BuildControl__control322();
		__ctrl.Add(val9);
		Parameter val10 = __BuildControl__control323();
		__ctrl.Add(val10);
		Parameter val11 = __BuildControl__control324();
		__ctrl.Add(val11);
		Parameter val12 = __BuildControl__control325();
		__ctrl.Add(val12);
		Parameter val13 = __BuildControl__control326();
		__ctrl.Add(val13);
		Parameter val14 = __BuildControl__control327();
		__ctrl.Add(val14);
		Parameter val15 = __BuildControl__control328();
		__ctrl.Add(val15);
		Parameter val16 = __BuildControl__control329();
		__ctrl.Add(val16);
		Parameter val17 = __BuildControl__control330();
		__ctrl.Add(val17);
		Parameter val18 = __BuildControl__control331();
		__ctrl.Add(val18);
		Parameter val19 = __BuildControl__control332();
		__ctrl.Add(val19);
		Parameter val20 = __BuildControl__control333();
		__ctrl.Add(val20);
		Parameter val21 = __BuildControl__control334();
		__ctrl.Add(val21);
		Parameter val22 = __BuildControl__control335();
		__ctrl.Add(val22);
		Parameter val23 = __BuildControl__control336();
		__ctrl.Add(val23);
		Parameter val24 = __BuildControl__control337();
		__ctrl.Add(val24);
		Parameter val25 = __BuildControl__control338();
		__ctrl.Add(val25);
		Parameter val26 = __BuildControl__control339();
		__ctrl.Add(val26);
		Parameter val27 = __BuildControl__control340();
		__ctrl.Add(val27);
		Parameter val28 = __BuildControl__control341();
		__ctrl.Add(val28);
		Parameter val29 = __BuildControl__control342();
		__ctrl.Add(val29);
		Parameter val30 = __BuildControl__control343();
		__ctrl.Add(val30);
		Parameter val31 = __BuildControl__control344();
		__ctrl.Add(val31);
		Parameter val32 = __BuildControl__control345();
		__ctrl.Add(val32);
		Parameter val33 = __BuildControl__control346();
		__ctrl.Add(val33);
		Parameter val34 = __BuildControl__control347();
		__ctrl.Add(val34);
	}

	[DebuggerNonUserCode]
	private Parameter __BuildControl__control349()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Parameter val = new Parameter();
		val.Name = "c1";
		val.Type = TypeCode.String;
		return val;
	}

	[DebuggerNonUserCode]
	private Parameter __BuildControl__control350()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Parameter val = new Parameter();
		val.Name = "o1";
		val.Type = TypeCode.String;
		return val;
	}

	[DebuggerNonUserCode]
	private Parameter __BuildControl__control351()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Parameter val = new Parameter();
		val.Name = "c2";
		val.Type = TypeCode.String;
		return val;
	}

	[DebuggerNonUserCode]
	private Parameter __BuildControl__control352()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Parameter val = new Parameter();
		val.Name = "o2";
		val.Type = TypeCode.String;
		return val;
	}

	[DebuggerNonUserCode]
	private Parameter __BuildControl__control353()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Parameter val = new Parameter();
		val.Name = "c3";
		val.Type = TypeCode.String;
		return val;
	}

	[DebuggerNonUserCode]
	private Parameter __BuildControl__control354()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Parameter val = new Parameter();
		val.Name = "o3";
		val.Type = TypeCode.String;
		return val;
	}

	[DebuggerNonUserCode]
	private Parameter __BuildControl__control355()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Parameter val = new Parameter();
		val.Name = "c4";
		val.Type = TypeCode.String;
		return val;
	}

	[DebuggerNonUserCode]
	private Parameter __BuildControl__control356()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Parameter val = new Parameter();
		val.Name = "o4";
		val.Type = TypeCode.String;
		return val;
	}

	[DebuggerNonUserCode]
	private Parameter __BuildControl__control357()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Parameter val = new Parameter();
		val.Name = "c5";
		val.Type = TypeCode.String;
		return val;
	}

	[DebuggerNonUserCode]
	private Parameter __BuildControl__control358()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Parameter val = new Parameter();
		val.Name = "o5";
		val.Type = TypeCode.String;
		return val;
	}

	[DebuggerNonUserCode]
	private Parameter __BuildControl__control359()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Parameter val = new Parameter();
		val.Name = "c6";
		val.Type = TypeCode.String;
		return val;
	}

	[DebuggerNonUserCode]
	private Parameter __BuildControl__control360()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Parameter val = new Parameter();
		val.Name = "o6";
		val.Type = TypeCode.String;
		return val;
	}

	[DebuggerNonUserCode]
	private Parameter __BuildControl__control361()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Parameter val = new Parameter();
		val.Name = "c7";
		val.Type = TypeCode.String;
		return val;
	}

	[DebuggerNonUserCode]
	private Parameter __BuildControl__control362()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Parameter val = new Parameter();
		val.Name = "o7";
		val.Type = TypeCode.String;
		return val;
	}

	[DebuggerNonUserCode]
	private Parameter __BuildControl__control363()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Parameter val = new Parameter();
		val.Name = "c8";
		val.Type = TypeCode.String;
		return val;
	}

	[DebuggerNonUserCode]
	private Parameter __BuildControl__control364()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Parameter val = new Parameter();
		val.Name = "o8";
		val.Type = TypeCode.String;
		return val;
	}

	[DebuggerNonUserCode]
	private Parameter __BuildControl__control365()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Parameter val = new Parameter();
		val.Name = "m1";
		val.Type = TypeCode.String;
		return val;
	}

	[DebuggerNonUserCode]
	private Parameter __BuildControl__control366()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Parameter val = new Parameter();
		val.Name = "l1";
		val.Type = TypeCode.String;
		return val;
	}

	[DebuggerNonUserCode]
	private Parameter __BuildControl__control367()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Parameter val = new Parameter();
		val.Name = "m2";
		val.Type = TypeCode.String;
		return val;
	}

	[DebuggerNonUserCode]
	private Parameter __BuildControl__control368()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Parameter val = new Parameter();
		val.Name = "l2";
		val.Type = TypeCode.String;
		return val;
	}

	[DebuggerNonUserCode]
	private Parameter __BuildControl__control369()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Parameter val = new Parameter();
		val.Name = "m3";
		val.Type = TypeCode.String;
		return val;
	}

	[DebuggerNonUserCode]
	private Parameter __BuildControl__control370()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Parameter val = new Parameter();
		val.Name = "l3";
		val.Type = TypeCode.String;
		return val;
	}

	[DebuggerNonUserCode]
	private Parameter __BuildControl__control371()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Parameter val = new Parameter();
		val.Name = "m4";
		val.Type = TypeCode.String;
		return val;
	}

	[DebuggerNonUserCode]
	private Parameter __BuildControl__control372()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Parameter val = new Parameter();
		val.Name = "l4";
		val.Type = TypeCode.String;
		return val;
	}

	[DebuggerNonUserCode]
	private Parameter __BuildControl__control373()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Parameter val = new Parameter();
		val.Name = "m5";
		val.Type = TypeCode.String;
		return val;
	}

	[DebuggerNonUserCode]
	private Parameter __BuildControl__control374()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Parameter val = new Parameter();
		val.Name = "l5";
		val.Type = TypeCode.String;
		return val;
	}

	[DebuggerNonUserCode]
	private Parameter __BuildControl__control375()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Parameter val = new Parameter();
		val.Name = "m6";
		val.Type = TypeCode.String;
		return val;
	}

	[DebuggerNonUserCode]
	private Parameter __BuildControl__control376()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Parameter val = new Parameter();
		val.Name = "l6";
		val.Type = TypeCode.String;
		return val;
	}

	[DebuggerNonUserCode]
	private Parameter __BuildControl__control377()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Parameter val = new Parameter();
		val.Name = "m7";
		val.Type = TypeCode.String;
		return val;
	}

	[DebuggerNonUserCode]
	private Parameter __BuildControl__control378()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Parameter val = new Parameter();
		val.Name = "l7";
		val.Type = TypeCode.String;
		return val;
	}

	[DebuggerNonUserCode]
	private Parameter __BuildControl__control379()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Parameter val = new Parameter();
		val.Name = "m8";
		val.Type = TypeCode.String;
		return val;
	}

	[DebuggerNonUserCode]
	private Parameter __BuildControl__control380()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Parameter val = new Parameter();
		val.Name = "l8";
		val.Type = TypeCode.String;
		return val;
	}

	[DebuggerNonUserCode]
	private Parameter __BuildControl__control381()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Parameter val = new Parameter();
		val.Name = "comment";
		val.Type = TypeCode.String;
		return val;
	}

	[DebuggerNonUserCode]
	private Parameter __BuildControl__control382()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Parameter val = new Parameter();
		val.Name = "UserName";
		val.Type = TypeCode.String;
		return val;
	}

	[DebuggerNonUserCode]
	private void __BuildControl__control348(ParameterCollection __ctrl)
	{
		Parameter val = __BuildControl__control349();
		__ctrl.Add(val);
		Parameter val2 = __BuildControl__control350();
		__ctrl.Add(val2);
		Parameter val3 = __BuildControl__control351();
		__ctrl.Add(val3);
		Parameter val4 = __BuildControl__control352();
		__ctrl.Add(val4);
		Parameter val5 = __BuildControl__control353();
		__ctrl.Add(val5);
		Parameter val6 = __BuildControl__control354();
		__ctrl.Add(val6);
		Parameter val7 = __BuildControl__control355();
		__ctrl.Add(val7);
		Parameter val8 = __BuildControl__control356();
		__ctrl.Add(val8);
		Parameter val9 = __BuildControl__control357();
		__ctrl.Add(val9);
		Parameter val10 = __BuildControl__control358();
		__ctrl.Add(val10);
		Parameter val11 = __BuildControl__control359();
		__ctrl.Add(val11);
		Parameter val12 = __BuildControl__control360();
		__ctrl.Add(val12);
		Parameter val13 = __BuildControl__control361();
		__ctrl.Add(val13);
		Parameter val14 = __BuildControl__control362();
		__ctrl.Add(val14);
		Parameter val15 = __BuildControl__control363();
		__ctrl.Add(val15);
		Parameter val16 = __BuildControl__control364();
		__ctrl.Add(val16);
		Parameter val17 = __BuildControl__control365();
		__ctrl.Add(val17);
		Parameter val18 = __BuildControl__control366();
		__ctrl.Add(val18);
		Parameter val19 = __BuildControl__control367();
		__ctrl.Add(val19);
		Parameter val20 = __BuildControl__control368();
		__ctrl.Add(val20);
		Parameter val21 = __BuildControl__control369();
		__ctrl.Add(val21);
		Parameter val22 = __BuildControl__control370();
		__ctrl.Add(val22);
		Parameter val23 = __BuildControl__control371();
		__ctrl.Add(val23);
		Parameter val24 = __BuildControl__control372();
		__ctrl.Add(val24);
		Parameter val25 = __BuildControl__control373();
		__ctrl.Add(val25);
		Parameter val26 = __BuildControl__control374();
		__ctrl.Add(val26);
		Parameter val27 = __BuildControl__control375();
		__ctrl.Add(val27);
		Parameter val28 = __BuildControl__control376();
		__ctrl.Add(val28);
		Parameter val29 = __BuildControl__control377();
		__ctrl.Add(val29);
		Parameter val30 = __BuildControl__control378();
		__ctrl.Add(val30);
		Parameter val31 = __BuildControl__control379();
		__ctrl.Add(val31);
		Parameter val32 = __BuildControl__control380();
		__ctrl.Add(val32);
		Parameter val33 = __BuildControl__control381();
		__ctrl.Add(val33);
		Parameter val34 = __BuildControl__control382();
		__ctrl.Add(val34);
	}

	[DebuggerNonUserCode]
	private SqlDataSource __BuildControlSqlDataSource3()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		SqlDataSource val = (SqlDataSource3 = new SqlDataSource());
		((Control)val).ID = "SqlDataSource3";
		val.DeleteCommand = "DELETE FROM [complaints] WHERE [UserName] = @UserName";
		val.InsertCommand = "INSERT INTO [complaints] ([c1], [o1], [c2], [o2], [c3], [o3], [c4], [o4], [c5], [o5], [c6], [o6], [c7], [o7], [c8], [o8], [m1], [l1], [m2], [l2], [m3], [l3], [m4], [l4], [m5], [l5], [m6], [l6], [m7], [l7], [m8], [l8], [UserName], [comment]) VALUES (@c1, @o1, @c2, @o2, @c3, @o3, @c4, @o4, @c5, @o5, @c6, @o6, @c7, @o7, @c8, @o8, @m1, @l1, @m2, @l2, @m3, @l3, @m4, @l4, @m5, @l5, @m6, @l6, @m7, @l7, @m8, @l8, @UserName, @comment)";
		val.SelectCommand = "SELECT [c1], [o1], [c2], [o2], [c3], [o3], [c4], [o4], [c5], [o5], [c6], [o6], [c7], [o7], [c8], [o8], [m1], [l1], [m2], [l2], [m3], [l3], [m4], [l4], [m5], [l5], [m6], [l6], [m7], [l7], [m8], [l8], [UserName], [comment] FROM [complaints] WHERE ([UserName] = @UserName)";
		val.UpdateCommand = "UPDATE [complaints] SET [c1] = @c1, [o1] = @o1, [c2] = @c2, [o2] = @o2, [c3] = @c3, [o3] = @o3, [c4] = @c4, [o4] = @o4, [c5] = @c5, [o5] = @o5, [c6] = @c6, [o6] = @o6, [c7] = @c7, [o7] = @o7, [c8] = @c8, [o8] = @o8, [m1] = @m1, [l1] = @l1, [m2] = @m2, [l2] = @l2, [m3] = @m3, [l3] = @l3, [m4] = @m4, [l4] = @l4, [m5] = @m5, [l5] = @l5, [m6] = @m6, [l6] = @l6, [m7] = @m7, [l7] = @l7, [m8] = @m8, [l8] = @l8, [comment] = @comment WHERE [UserName] = @UserName";
		__BuildControl__control309(val.SelectParameters);
		__BuildControl__control311(val.DeleteParameters);
		__BuildControl__control313(val.InsertParameters);
		__BuildControl__control348(val.UpdateParameters);
		val.ConnectionString = Convert.ToString(ConnectionStringsExpressionBuilder.GetConnectionString("LocalSqlServer"), CultureInfo.CurrentCulture);
		val.ProviderName = Convert.ToString(ConnectionStringsExpressionBuilder.GetConnectionStringProviderName("LocalSqlServer"), CultureInfo.CurrentCulture);
		return val;
	}

	[DebuggerNonUserCode]
	private View __BuildControlView3()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Expected Obj, but got Unknown
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Expected Obj, but got Unknown
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		//IL_006c: Expected Obj, but got Unknown
		View val = (View3 = new View());
		((Control)val).ID = "View3";
		IParserAccessor val3 = (IParserAccessor)(object)val;
		val3.AddParsedSubObject((object)new LiteralControl("\r\n                        "));
		DetailsView val4 = __BuildControlDetailsView3();
		val3.AddParsedSubObject((object)val4);
		val3.AddParsedSubObject((object)new LiteralControl("\r\n                        "));
		SqlDataSource val5 = __BuildControlSqlDataSource3();
		val3.AddParsedSubObject((object)val5);
		val3.AddParsedSubObject((object)new LiteralControl("\r\n                    "));
		return val;
	}

	[DebuggerNonUserCode]
	private MultiView __BuildControlMultiView1()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Expected Obj, but got Unknown
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Expected Obj, but got Unknown
		//IL_0070: Unknown result type (might be due to invalid IL or missing references)
		//IL_007a: Expected Obj, but got Unknown
		//IL_0092: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Expected Obj, but got Unknown
		MultiView val = (MultiView1 = new MultiView());
		((Control)val).TemplateControl = (TemplateControl)(object)this;
		((Control)val).ID = "MultiView1";
		val.ActiveViewIndex = 0;
		IParserAccessor val3 = (IParserAccessor)(object)val;
		val3.AddParsedSubObject((object)new LiteralControl("\r\n              "));
		View val4 = __BuildControlView1();
		val3.AddParsedSubObject((object)val4);
		val3.AddParsedSubObject((object)new LiteralControl("\r\n                    "));
		View val5 = __BuildControlView2();
		val3.AddParsedSubObject((object)val5);
		val3.AddParsedSubObject((object)new LiteralControl(" \r\n                    "));
		View val6 = __BuildControlView3();
		val3.AddParsedSubObject((object)val6);
		val3.AddParsedSubObject((object)new LiteralControl("       "));
		return val;
	}

	[DebuggerNonUserCode]
	private void __BuildControlContent1(Control __ctrl)
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected Obj, but got Unknown
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Expected Obj, but got Unknown
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0054: Expected Obj, but got Unknown
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Expected Obj, but got Unknown
		//IL_008a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0094: Expected Obj, but got Unknown
		//IL_00ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b6: Expected Obj, but got Unknown
		//IL_00ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d8: Expected Obj, but got Unknown
		//IL_00f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fa: Expected Obj, but got Unknown
		((IParserAccessor)__ctrl).AddParsedSubObject((object)new LiteralControl("\r\n    <table border=\"0\" cellpadding=\"0\" cellspacing=\"0\" style=\"width: 100%\">\r\n        <tr>\r\n            <td style=\"width: 100px\">\r\n                "));
		GridView val = __BuildControlGridView1();
		((IParserAccessor)__ctrl).AddParsedSubObject((object)val);
		((IParserAccessor)__ctrl).AddParsedSubObject((object)new LiteralControl("\r\n                "));
		SqlDataSource val2 = __BuildControlSqlDataSource1();
		((IParserAccessor)__ctrl).AddParsedSubObject((object)val2);
		((IParserAccessor)__ctrl).AddParsedSubObject((object)new LiteralControl("\r\n                <br />\r\n                <br />\r\n                "));
		Label val3 = __BuildControlLabel1();
		((IParserAccessor)__ctrl).AddParsedSubObject((object)val3);
		((IParserAccessor)__ctrl).AddParsedSubObject((object)new LiteralControl("<br />\r\n                <br />\r\n            </td>\r\n        </tr>\r\n        <tr>\r\n            <td style=\"width: 100px\">\r\n                User Info :<br />\r\n                &nbsp;"));
		SqlDataSource val4 = __BuildControlSqlDataSource2();
		((IParserAccessor)__ctrl).AddParsedSubObject((object)val4);
		((IParserAccessor)__ctrl).AddParsedSubObject((object)new LiteralControl("\r\n                "));
		Button val5 = __BuildControlButton1();
		((IParserAccessor)__ctrl).AddParsedSubObject((object)val5);
		((IParserAccessor)__ctrl).AddParsedSubObject((object)new LiteralControl("\r\n                "));
		Button val6 = __BuildControlButton2();
		((IParserAccessor)__ctrl).AddParsedSubObject((object)val6);
		((IParserAccessor)__ctrl).AddParsedSubObject((object)new LiteralControl("\r\n                <br />\r\n                "));
		MultiView val7 = __BuildControlMultiView1();
		((IParserAccessor)__ctrl).AddParsedSubObject((object)val7);
		((IParserAccessor)__ctrl).AddParsedSubObject((object)new LiteralControl("\r\n                \r\n            </td>\r\n        </tr>\r\n    </table>\r\n"));
	}

	[DebuggerNonUserCode]
	private void __BuildControlTree(admin_watview_aspx __ctrl)
	{
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Expected Obj, but got Unknown
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Expected Obj, but got Unknown
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Expected Obj, but got Unknown
		((Page)__ctrl).MasterPageFile = "~/master1.master";
		((Page)__ctrl).Title = "Human Oil Change";
		((Page)this).InitializeCulture();
		((Page)this).AddContentTemplate("ContentPlaceHolder1", (ITemplate)new CompiledTemplateBuilder((BuildTemplateMethod)__BuildControlContent1));
		((IParserAccessor)__ctrl).AddParsedSubObject((object)new LiteralControl("\r\n\r\n"));
	}

	[DebuggerNonUserCode]
	protected override void FrameworkInitialize()
	{
		((Page)this).StyleSheetTheme = "Theme1";
		((Page)this).FrameworkInitialize();
		__BuildControlTree(this);
		((Page)this).AddWrappedFileDependencies(RuntimeHelpers.GetObjectValue(__fileDependencies));
		((Page)this).Request.ValidateInput();
	}

	[DebuggerNonUserCode]
	public override int GetTypeHashCode()
	{
		return 1900139916;
	}

	[DebuggerNonUserCode]
	public override void ProcessRequest(HttpContext context)
	{
		((Page)this).ProcessRequest(context);
	}
}
