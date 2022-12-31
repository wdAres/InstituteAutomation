using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

public partial class Forget_Password : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void BTN_GET_PWD_Click(object sender, EventArgs e)
    {
        try
        {
        Class1.cnn.Open();
        string str = "select * from login";
        SqlCommand cmd = new SqlCommand(str, Class1.cnn);
        SqlDataReader dr = cmd.ExecuteReader();
        while (dr.Read())
        {
            if (TXT_USER_NAME.Text == dr["username"].ToString())
            {
                TXT_PASSWORD.Text = dr["password"].ToString();
            }
            else
            {
            LBL_MSG.Text="Invalid User Name";
            }
        }
        dr.Close();
        }
        catch(Exception){}
        finally
        {
        Class1.cnn.Close();
        }
    }
}