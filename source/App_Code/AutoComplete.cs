using System;
using System.Collections.Generic;
using System.Web.Script.Services;
using System.Web.Services;
using textrefTableAdapters;

[ScriptService]
[WebServiceBinding(/*Could not decode attribute arguments.*/)]
[WebService(Namespace = "http://tempuri.org/")]
public class AutoComplete : WebService
{
	[WebMethod]
	public string[] GetCompletionList(string prefixText, int count, string contextKey)
	{
		if (count == 0)
		{
			count = 10;
		}
		TestRefTableAdapter testRefTableAdapter = new TestRefTableAdapter();
		textref.TestRefDataTable testRefDataTable = new textref.TestRefDataTable();
		testRefTableAdapter.FillBy(testRefDataTable, prefixText);
		Random random = new Random();
		List<string> list = new List<string>();
		if (testRefDataTable.Rows.Count < count)
		{
			count = testRefDataTable.Rows.Count;
		}
		int num = count;
		for (int i = 1; i <= num; i = checked(i + 1))
		{
			list.Add("ddd");
		}
		return list.ToArray();
	}
}
