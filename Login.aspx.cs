using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

public partial class Logi : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    //Method to Select data from table(Login)
    protected void BTN_LOGIN_Click(object sender, EventArgs e)
    {
        try
        {
            Class1.cnn.Open();
            string str = "select * from login";
            SqlCommand cmd = new SqlCommand(str, Class1.cnn);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                if (DDL_MEMBER_OF.SelectedItem.Text=="Student")
                {
                    Response.Redirect("Student Home.aspx");
                }
                else if (DDL_MEMBER_OF.SelectedItem.Text == "Admin" && TXT_PASSWORD.Text=="admin")
                {
                    Response.Redirect("Home.aspx");
                }
                else if (DDL_MEMBER_OF.SelectedItem.Text == "Teacher" && TXT_PASSWORD.Text == "teacher")
                {
                    Response.Redirect("Teacher Home.aspx");
                }
                else
                {
                    LBL_ALERT.Text = "Invalid Password ";
                }
            }
            dr.Close();
        }
        catch (Exception) { }
        finally
        {
            
            Class1.cnn.Close();
        }
    }
}