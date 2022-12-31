using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

public partial class Teacher_Subject : System.Web.UI.Page
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
    //Method to Insert data into table(Teacher_Subject)
    protected void BTN_SUBMIT_Click(object sender, EventArgs e)
    {
        if (TXT_STAFF_ID.Text == "")
        {
            LBL_MSG.Text = "Please Enter Staff ID";
            TXT_STAFF_ID.Focus();
        }
        else if (TXT_SUBJECT.Text == "")
        {
            LBL_MSG.Text = "Please Enter Subject";
            TXT_SUBJECT.Focus();
        }
        else
        {
            try
            {
                Class1.cnn.Open();
                string str = "insert into Teacher_Subject(Staff_ID,Subject)Values('" + TXT_STAFF_ID.Text + "','" + TXT_SUBJECT.Text + "')";
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
    //Method to Select data from table(Teacher_Subject)
    protected void BTN_SEARCH_Click(object sender, EventArgs e)
    {
        if(TXT_STAFF_ID.Text=="")
        {
            LBL_MSG.Text="Please Enter Staff ID";
            TXT_STAFF_ID.Focus();
        }
        else
        {
            Class1.cnn.Open();
            string str="Select * from Teacher_Subject";
            SqlCommand cmd=new SqlCommand(str,Class1.cnn);
            SqlDataReader dr=cmd.ExecuteReader();
            while(dr.Read())
            {
                if(TXT_STAFF_ID.Text==dr["staff_id"].ToString())
                {
                    TXT_SUBJECT.Text=dr["subject"].ToString();
                }
                else
                {
                    LBL_MSG.Text="Staff ID Not Matched";
                    TXT_STAFF_ID.Focus();
                }
            }
            dr.Close();
            Class1.cnn.Close();
        }
    }
    //Method to Update data from table(Teacher_Subject)
    protected void BTN_UPDATE_Click(object sender, EventArgs e)
    {
        try
        {
            Class1.cnn.Open();
            string str="Update Teacher_Subject set Subject='"+TXT_SUBJECT.Text+"' Where Staff_ID='"+TXT_STAFF_ID.Text+"'";
            SqlCommand cmd=new SqlCommand(str,Class1.cnn);
            cmd.ExecuteNonQuery();
        }
        catch(Exception){}
        finally
        {
            Class1.cnn.Close();
            LBL_MSG.Text="Data Updated";
            blank();
        }
    }
    //Method to Delete data from table(Teacher_Subject)
    protected void BTN_DELETE_Click(object sender, EventArgs e)
    {
        Class1.cnn.Open();
        string str="Delete Teacher_Subject Where Staff_Id='"+TXT_STAFF_ID.Text+"'";
        SqlCommand cmd=new SqlCommand(str,Class1.cnn);
        cmd.ExecuteNonQuery();
        Class1.cnn.Close();
        LBL_MSG.Text="Data Deleted...";
        blank();
    }
    //Function to blank textboxes
    public void blank()
    {
        TXT_STAFF_ID.Text="";
        TXT_SUBJECT.Text="";
        TXT_STAFF_ID.Focus();
    }
}