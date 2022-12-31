using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

public partial class Report_Detail : System.Web.UI.Page
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
    //Method to Insert data into table(Report_Detail)
    protected void BTN_SUBMIT_Click(object sender, EventArgs e)
    {
        if (TXT_REG_NO.Text == "")
        {
            LBL_MSG.Text = "Please Enter Registration No";
            TXT_REG_NO.Focus();
        }
        else if (TXT_SUBJECT.Text == "")
        {
            LBL_MSG.Text = "Please Enter Subject";
            TXT_SUBJECT.Focus();
        }
        else if (TXT_MARKS.Text == "")
        {
            LBL_MSG.Text = "Please Enter Marks";
            TXT_MARKS.Focus();
        }
        else
        {
            try
            {
                Class1.cnn.Open();
                string str = "insert into Report_Detail(Reg_no,Subject,Marks)Values('" + TXT_REG_NO.Text + "','" + TXT_SUBJECT.Text + "','" + TXT_MARKS.Text + "')";
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
    //Method to Select data from table(Report_Detail)
    protected void BTN_SEARCH_Click(object sender, EventArgs e)
    {
        if (TXT_REG_NO.Text == "")
        {
            LBL_MSG.Text = "Please Enter Registration No";
            TXT_REG_NO.Focus();
        }
        else
        {
            Class1.cnn.Open();
            string str = "Select * from Report_Detail";
            SqlCommand cmd = new SqlCommand(str, Class1.cnn);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                if (TXT_REG_NO.Text == dr["reg_no"].ToString())
                {
                    TXT_SUBJECT.Text = dr["subject"].ToString();
                    TXT_MARKS.Text = dr["marks"].ToString();
                }
                else
                {
                    LBL_MSG.Text = "Registration No Not Matched";
                    TXT_MARKS.Focus();
                }
            }
            dr.Close();
            Class1.cnn.Close();
        }
    }
    //Method to Update data from table(Report_Detail)
    protected void BTN_UPDATE_Click(object sender, EventArgs e)
    {
        try
        {
            Class1.cnn.Open();
            string str = "Update Report_Detail set Subject='" + TXT_SUBJECT.Text + "',Marks='" + TXT_MARKS.Text + "' Where Reg_no='" + TXT_REG_NO.Text + "'";
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
    //Method to Delete data from table(Report_Detail)
    protected void BTN_DELETE_Click(object sender, EventArgs e)
    {
        Class1.cnn.Open();
        string str="Delete Report_Detail Where Reg_no='"+TXT_REG_NO.Text+"'";
        SqlCommand cmd = new SqlCommand(str, Class1.cnn);
        cmd.ExecuteNonQuery();
        Class1.cnn.Close();
        LBL_MSG.Text = "Data Deleted";
        blank();
    }
    //Function to blank textboxes
    public void blank()
    {
        TXT_REG_NO.Text = "";
        TXT_SUBJECT.Text = "";
        TXT_MARKS.Text = "";
        TXT_REG_NO.Focus();
    }
}