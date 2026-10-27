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
public class admin_watlist_aspx : Admin_watList
{
	private static bool __initialized;

	private static object __fileDependencies;

	protected override bool SupportAutoEvents => false;

	[DebuggerNonUserCode]
	public admin_watlist_aspx()
	{
		((TemplateControl)this).AppRelativeVirtualPath = "~/Admin/watList.aspx";
		if (!__initialized)
		{
			__fileDependencies = RuntimeHelpers.GetObjectValue(((Page)this).GetWrappedFileDependencies(new string[4] { "~/Admin/watList.aspx", "~/master1.master", "~/master1.master.vb", "~/Admin/watList.aspx.vb" }));
			__initialized = true;
		}
		((Page)this).Server.ScriptTimeout = 30000000;
	}

	[DebuggerNonUserCode]
	private void __BuildControlContent1(Control __ctrl)
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Expected Obj, but got Unknown
		((IParserAccessor)__ctrl).AddParsedSubObject((object)new LiteralControl("\r\n"));
	}

	[DebuggerNonUserCode]
	private BoundField __BuildControl__control3()
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
	private BoundField __BuildControl__control4()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		BoundField val = new BoundField();
		val.DataField = "test_instance_id";
		val.HeaderText = "test_instance_id";
		val.ReadOnly = true;
		((DataControlField)val).SortExpression = "test_instance_id";
		return val;
	}

	[DebuggerNonUserCode]
	private BoundField __BuildControl__control5()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		BoundField val = new BoundField();
		val.DataField = "test_type_id";
		val.HeaderText = "test_type_id";
		((DataControlField)val).SortExpression = "test_type_id";
		return val;
	}

	[DebuggerNonUserCode]
	private BoundField __BuildControl__control6()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		BoundField val = new BoundField();
		val.DataField = "start_date";
		val.HeaderText = "start_date";
		((DataControlField)val).SortExpression = "start_date";
		return val;
	}

	[DebuggerNonUserCode]
	private BoundField __BuildControl__control7()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		BoundField val = new BoundField();
		val.DataField = "end_date";
		val.HeaderText = "end_date";
		((DataControlField)val).SortExpression = "end_date";
		return val;
	}

	[DebuggerNonUserCode]
	private BoundField __BuildControl__control8()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		BoundField val = new BoundField();
		val.DataField = "total_score";
		val.HeaderText = "total_score";
		((DataControlField)val).SortExpression = "total_score";
		return val;
	}

	[DebuggerNonUserCode]
	private CommandField __BuildControl__control9()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		CommandField val = new CommandField();
		val.SelectText = "More Details";
		val.ShowSelectButton = true;
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
		BoundField val4 = __BuildControl__control6();
		__ctrl.Add((DataControlField)(object)val4);
		BoundField val5 = __BuildControl__control7();
		__ctrl.Add((DataControlField)(object)val5);
		BoundField val6 = __BuildControl__control8();
		__ctrl.Add((DataControlField)(object)val6);
		CommandField val7 = __BuildControl__control9();
		__ctrl.Add((DataControlField)(object)val7);
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
		val.DataKeyNames = new string[1] { "test_instance_id" };
		((DataBoundControl)val).DataSourceID = "SqlDataSource1";
		val.EmptyDataText = "There are no data records to display.";
		__BuildControl__control2(val.Columns);
		return val;
	}

	[DebuggerNonUserCode]
	private QueryStringParameter __BuildControl__control11()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		QueryStringParameter val = new QueryStringParameter();
		((Parameter)val).Name = "un";
		val.QueryStringField = "un";
		return val;
	}

	[DebuggerNonUserCode]
	private void __BuildControl__control10(ParameterCollection __ctrl)
	{
		QueryStringParameter val = __BuildControl__control11();
		__ctrl.Add((Parameter)(object)val);
	}

	[DebuggerNonUserCode]
	private Parameter __BuildControl__control13()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Parameter val = new Parameter();
		val.Name = "test_instance_id";
		val.Type = TypeCode.Int32;
		return val;
	}

	[DebuggerNonUserCode]
	private void __BuildControl__control12(ParameterCollection __ctrl)
	{
		Parameter val = __BuildControl__control13();
		__ctrl.Add(val);
	}

	[DebuggerNonUserCode]
	private Parameter __BuildControl__control15()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Parameter val = new Parameter();
		val.Name = "UserName";
		val.Type = TypeCode.String;
		return val;
	}

	[DebuggerNonUserCode]
	private Parameter __BuildControl__control16()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Parameter val = new Parameter();
		val.Name = "test_type_id";
		val.Type = TypeCode.Int32;
		return val;
	}

	[DebuggerNonUserCode]
	private Parameter __BuildControl__control17()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Parameter val = new Parameter();
		val.Name = "start_date";
		val.Type = TypeCode.DateTime;
		return val;
	}

	[DebuggerNonUserCode]
	private Parameter __BuildControl__control18()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Parameter val = new Parameter();
		val.Name = "end_date";
		val.Type = TypeCode.DateTime;
		return val;
	}

	[DebuggerNonUserCode]
	private Parameter __BuildControl__control19()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Parameter val = new Parameter();
		val.Name = "total_score";
		val.Type = TypeCode.Int32;
		return val;
	}

	[DebuggerNonUserCode]
	private void __BuildControl__control14(ParameterCollection __ctrl)
	{
		Parameter val = __BuildControl__control15();
		__ctrl.Add(val);
		Parameter val2 = __BuildControl__control16();
		__ctrl.Add(val2);
		Parameter val3 = __BuildControl__control17();
		__ctrl.Add(val3);
		Parameter val4 = __BuildControl__control18();
		__ctrl.Add(val4);
		Parameter val5 = __BuildControl__control19();
		__ctrl.Add(val5);
	}

	[DebuggerNonUserCode]
	private Parameter __BuildControl__control21()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Parameter val = new Parameter();
		val.Name = "UserName";
		val.Type = TypeCode.String;
		return val;
	}

	[DebuggerNonUserCode]
	private Parameter __BuildControl__control22()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Parameter val = new Parameter();
		val.Name = "test_type_id";
		val.Type = TypeCode.Int32;
		return val;
	}

	[DebuggerNonUserCode]
	private Parameter __BuildControl__control23()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Parameter val = new Parameter();
		val.Name = "start_date";
		val.Type = TypeCode.DateTime;
		return val;
	}

	[DebuggerNonUserCode]
	private Parameter __BuildControl__control24()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Parameter val = new Parameter();
		val.Name = "end_date";
		val.Type = TypeCode.DateTime;
		return val;
	}

	[DebuggerNonUserCode]
	private Parameter __BuildControl__control25()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Parameter val = new Parameter();
		val.Name = "total_score";
		val.Type = TypeCode.Int32;
		return val;
	}

	[DebuggerNonUserCode]
	private Parameter __BuildControl__control26()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		Parameter val = new Parameter();
		val.Name = "test_instance_id";
		val.Type = TypeCode.Int32;
		return val;
	}

	[DebuggerNonUserCode]
	private void __BuildControl__control20(ParameterCollection __ctrl)
	{
		Parameter val = __BuildControl__control21();
		__ctrl.Add(val);
		Parameter val2 = __BuildControl__control22();
		__ctrl.Add(val2);
		Parameter val3 = __BuildControl__control23();
		__ctrl.Add(val3);
		Parameter val4 = __BuildControl__control24();
		__ctrl.Add(val4);
		Parameter val5 = __BuildControl__control25();
		__ctrl.Add(val5);
		Parameter val6 = __BuildControl__control26();
		__ctrl.Add(val6);
	}

	[DebuggerNonUserCode]
	private SqlDataSource __BuildControlSqlDataSource1()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		SqlDataSource val = (SqlDataSource1 = new SqlDataSource());
		((Control)val).TemplateControl = (TemplateControl)(object)this;
		((Control)val).ID = "SqlDataSource1";
		val.DeleteCommand = "DELETE FROM [testInstance] WHERE [test_instance_id] = @test_instance_id";
		val.InsertCommand = "INSERT INTO [testInstance] ([UserName], [test_type_id], [start_date], [end_date], [total_score]) VALUES (@UserName, @test_type_id, @start_date, @end_date, @total_score)";
		val.SelectCommand = "SELECT UserName, test_instance_id, test_type_id, start_date, end_date, total_score FROM testInstance WHERE (UserName = @un)";
		val.UpdateCommand = "UPDATE [testInstance] SET [UserName] = @UserName, [test_type_id] = @test_type_id, [start_date] = @start_date, [end_date] = @end_date, [total_score] = @total_score WHERE [test_instance_id] = @test_instance_id";
		__BuildControl__control10(val.SelectParameters);
		__BuildControl__control12(val.DeleteParameters);
		__BuildControl__control14(val.InsertParameters);
		__BuildControl__control20(val.UpdateParameters);
		val.ConnectionString = Convert.ToString(ConnectionStringsExpressionBuilder.GetConnectionString("LocalSqlServer"), CultureInfo.CurrentCulture);
		val.ProviderName = Convert.ToString(ConnectionStringsExpressionBuilder.GetConnectionStringProviderName("LocalSqlServer"), CultureInfo.CurrentCulture);
		return val;
	}

	[DebuggerNonUserCode]
	private void __BuildControlContent2(Control __ctrl)
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Expected Obj, but got Unknown
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Expected Obj, but got Unknown
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_004e: Expected Obj, but got Unknown
		((IParserAccessor)__ctrl).AddParsedSubObject((object)new LiteralControl("\r\n    "));
		GridView val = __BuildControlGridView1();
		((IParserAccessor)__ctrl).AddParsedSubObject((object)val);
		((IParserAccessor)__ctrl).AddParsedSubObject((object)new LiteralControl("\r\n    "));
		SqlDataSource val2 = __BuildControlSqlDataSource1();
		((IParserAccessor)__ctrl).AddParsedSubObject((object)val2);
		((IParserAccessor)__ctrl).AddParsedSubObject((object)new LiteralControl("\r\n"));
	}

	[DebuggerNonUserCode]
	private void __BuildControlTree(admin_watlist_aspx __ctrl)
	{
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Expected Obj, but got Unknown
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Expected Obj, but got Unknown
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_0051: Expected Obj, but got Unknown
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0056: Expected Obj, but got Unknown
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0068: Expected Obj, but got Unknown
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0078: Expected Obj, but got Unknown
		((Page)__ctrl).Title = "";
		((Page)__ctrl).MasterPageFile = "~/master1.master";
		((Page)this).InitializeCulture();
		((Page)this).AddContentTemplate("head", (ITemplate)new CompiledTemplateBuilder((BuildTemplateMethod)__BuildControlContent1));
		((Page)this).AddContentTemplate("ContentPlaceHolder1", (ITemplate)new CompiledTemplateBuilder((BuildTemplateMethod)__BuildControlContent2));
		((IParserAccessor)__ctrl).AddParsedSubObject((object)new LiteralControl("\r\n"));
		((IParserAccessor)__ctrl).AddParsedSubObject((object)new LiteralControl("\r\n\r\n"));
	}

	[DebuggerNonUserCode]
	protected override void FrameworkInitialize()
	{
		((Page)this).FrameworkInitialize();
		__BuildControlTree(this);
		((Page)this).AddWrappedFileDependencies(RuntimeHelpers.GetObjectValue(__fileDependencies));
		((Page)this).Request.ValidateInput();
	}

	[DebuggerNonUserCode]
	public override int GetTypeHashCode()
	{
		return 635113663;
	}

	[DebuggerNonUserCode]
	public override void ProcessRequest(HttpContext context)
	{
		((Page)this).ProcessRequest(context);
	}
}
