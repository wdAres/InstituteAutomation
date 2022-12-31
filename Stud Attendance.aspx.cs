using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

public partial class Stud_Attendance : System.Web.UI.Page
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
    //Method to Insert data into table(Stud_Attendance)
    protected void BTN_SUBMIT_Click(object sender, EventArgs e)
    {
        if (TXT_SESSION.Text == "")
        {
            LBL_MSG.Text = "Please Enter Session";
            TXT_SESSION.Focus();
        }
        else if (TXT_REG_NO.Text == "")
        {
            LBL_MSG.Text = "Please Enter Registration No";
            TXT_REG_NO.Focus();
        }
        else if (TXT_STD.Text == "")
        {
            LBL_MSG.Text = "Please Enter Standard";
            TXT_STD.Focus();
        }
        else if (TXT_SEC.Text == "")
        {
            LBL_MSG.Text = "Please Enter Section";
            TXT_SEC.Focus();
        }
        else if (TXT_ROLL_NO.Text == "")
        {
            LBL_MSG.Text = "Please Enter Roll No";
            TXT_ROLL_NO.Focus();
        }
        else if (TXT_DATE.Text == "")
        {
            LBL_MSG.Text = "Please Enter Date";
            TXT_DATE.Focus();
        }
        else
        {
            try
            {
                Class1.cnn.Open();
                string str = "insert into Stud_Attendance(Session,Reg_no,std,sec,roll_no,Date)Values('" + TXT_SESSION.Text + "','" + TXT_REG_NO.Text + "','" + TXT_STD.Text + "','" + TXT_SEC.Text + "','" + TXT_ROLL_NO.Text + "','" + TXT_DATE.Text + "')";
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
    //Method to Select data from table(Stud_Attendance)
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
            string str = "Select * from Stud_Attendance";
            SqlCommand cmd = new SqlCommand(str, Class1.cnn);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                if (TXT_SESSION.Text == dr["Session"].ToString())
                {
                    TXT_REG_NO.Text = dr["Reg_no"].ToString();
                    TXT_STD.Text = dr["std"].ToString();
                    TXT_SEC.Text = dr["sec"].ToString();
                    TXT_ROLL_NO.Text = dr["Roll_no"].ToString();
                    TXT_DATE.Text = dr["date"].ToString();
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
    //Method to Update data from table(Stud_Attendance)
    protected void BTN_UPDATE_Click(object sender, EventArgs e)
    {
        try
        {
            Class1.cnn.Open();
            string str = "Update Stud_Attendance set Reg_no='" + TXT_REG_NO.Text + "',Std='" + TXT_STD.Text + "',Sec='" + TXT_SEC.Text + "',Roll_no='" + TXT_ROLL_NO.Text + "',Date='" + TXT_DATE.Text + "' Where Session='" + TXT_SESSION.Text + "'";
            SqlCommand cmd = new SqlCommand(str, Class1.cnn);
            cmd.ExecuteNonQuery();
        }
        catch (Exception) { }
        finally
        {
            Class1.cnn.Close();
            LBL_MSG.Text = "Data Updated";
            blank();
        }
    }
    //Method to Delete data from table(Stud_Attendance)
    protected void BTN_DELETE_Click(object sender, EventArgs e)
    {
        Class1.cnn.Open();
        string str = "Delete Stud_Attendance Where Session='" + TXT_SESSION.Text + "'";
        SqlCommand cmd = new SqlCommand(str, Class1.cnn);
        cmd.ExecuteNonQuery();
        Class1.cnn.Close();
        LBL_MSG.Text = "Data Deleted...";
        blank();
    }
    //Function to blank textboxes
    public void blank()
    {
        TXT_SESSION.Text = "";
        TXT_REG_NO.Text = "";
        TXT_STD.Text = "";
        TXT_SEC.Text = "";
        TXT_ROLL_NO.Text = "";
        TXT_DATE.Text = "";
        TXT_SESSION.Focus();
    }
}
