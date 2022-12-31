using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;

/// <summary>
/// Summary description for Class1
/// </summary>
public class Class1
{
    public static SqlConnection cnn=new SqlConnection(@" Data Source= MANOJ-PC\SQLEXPRESS; Database= IAS_DB; Integrated Security= True");
	public Class1()
	{
		//
		// TODO: Add constructor logic here
		//
	}
}