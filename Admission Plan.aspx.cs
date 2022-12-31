using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

public partial class Admission_Plan : System.Web.UI.Page
{
    //Call Page Load Event,to Check Connection
    protected void Page_Load(object sender, EventArgs e)
    {
        //Exception Handling
        try
        {
            Class1.cnn.Open();
            Response.Write("Database Connected");
        }
        catch (Exception) { }
        finally
        {
            Class1.cnn.Close();
        }
     }
    //Method to Insert data into table(Admission Plan)
    protected void BTN_SUBMIT_Click(object sender, EventArgs e)
    {
        if (TXT_SESSION.Text == "")
        {
            LBL_MSG.Text = "Please Enter Session";
            TXT_SESSION.Focus();
        }
        else if (TXT_STD.Text == "")
        {
            LBL_MSG.Text = "Please Enter Standard";
            TXT_STD.Focus();
        }
        else if (TXT_PARTICULARS.Text == "")
        {
            LBL_MSG.Text = "Please Enter Particulars";
            TXT_PARTICULARS.Focus();
        }
        else if (TXT_CHARGE.Text == "")
        {
            LBL_MSG.Text = "Please Enter Charge";
            TXT_CHARGE.Focus();
        }
        else
        {
            try
            {
                Class1.cnn.Open();
                string str = "insert into Admission_plan(Session,Std,Particulars,Charge)values('" + TXT_SESSION.Text + "','" + TXT_STD.Text + "','" + TXT_PARTICULARS.Text + "','" + TXT_CHARGE.Text + "')";
                SqlCommand cmd = new SqlCommand(str, Class1.cnn);
                cmd.ExecuteNonQuery();
            }
            catch (Exception) { }
            finally
            {
                Class1.cnn.Close();
                LBL_MSG.Text = "Data Saved...";
                blank();
            }
        }
    }
    //Method to Select data from table(Admission Plan)
    protected void BTN_SEARCH_Click(object sender, EventArgs e)
    {
        if (TXT_SESSION.Text == "")
        {
            LBL_MSG.Text = "Please Enter Session";
            TXT_SESSION.Focus();
        }
        else
        {
            Class1.cnn.Open();
            string str = "select * from Admission_plan";
            SqlCommand cmd = new SqlCommand(str, Class1.cnn);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                if (TXT_SESSION.Text == dr["Session"].ToString())
                {
                    TXT_STD.Text = dr["Std"].ToString();
                    TXT_PARTICULARS.Text = dr["Particulars"].ToString();
                    TXT_CHARGE.Text = dr["Charge"].ToString();
                }
                else
                {
                    LBL_MSG.Text = "Session Not Matched";
                    TXT_SESSION.Focus();
                }
            }
            dr.Close();
            Class1.cnn.Close();
        }
    }
    //Method to Update data into table(Admission Plan)
    protected void BTN_UPDATE_Click(object sender, EventArgs e)
    {
        try
        {
            Class1.cnn.Open();
            string str = "update Admission_plan set Std='" + TXT_STD.Text + "',Particulars='" + TXT_PARTICULARS.Text + "',Charge='" + TXT_CHARGE.Text + "'where Session='" + TXT_SESSION.Text + "'";
            SqlCommand cmd = new SqlCommand(str, Class1.cnn);
            cmd.ExecuteNonQuery();
        }
        catch (Exception) { }
        finally
        {
            Class1.cnn.Close();
            LBL_MSG.Text = "Data Updated...";
            blank();
        }
    }
    //Method to Delete data from table(Admission Plan)
    protected void BTN_DELETE_Click(object sender, EventArgs e)
    {
        Class1.cnn.Open();
        string str = "Delete Admission_plan where session='" + TXT_SESSION.Text + "'";
        SqlCommand cmd = new SqlCommand(str, Class1.cnn);
        cmd.ExecuteNonQuery();
        Class1.cnn.Close();
        LBL_MSG.Text = "Data Deleted...";
        blank();
    }
    //Function to blank Textboxes
    public void blank()
    {
        TXT_SESSION.Text = "";
        TXT_STD.Text = "";
        TXT_PARTICULARS.Text = "";
        TXT_CHARGE.Text = "";
        TXT_SESSION.Focus();
    }
}