using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

public partial class Create_User : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    //Method to Insert data into table(Login)
    protected void BTN_SUBMIT_Click(object sender, EventArgs e)
    {
        try
        {
            Class1.cnn.Open();
            string str = "insert into Login values('" + TXT_USER_NAME.Text + "','" + TXT_PASSWORD.Text + "','" + DDL_MEMBER_OF.Text + "','" + TXT_EXPIRY_DATE.Text + "','" + TXT_LOGIN_DATE.Text + "')";
            SqlCommand cmd = new SqlCommand(str, Class1.cnn);
            cmd.ExecuteNonQuery();
        }
        catch (Exception) { }
        finally
        {
            Class1.cnn.Close();
            LBL_MSG.Text = "Thank You For Registration";
        }
    }
}