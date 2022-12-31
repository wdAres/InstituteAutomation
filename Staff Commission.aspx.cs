using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

public partial class Staff_Commission : System.Web.UI.Page
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
    //Method to Insert data into table(Staff_Commission)
    protected void BTN_SUBMIT_Click(object sender, EventArgs e)
    {
        if (TXT_COM_ID.Text == "")
        {
            LBL_MSG.Text = "Please Enter Commission ID";
            TXT_COM_ID.Focus();
        }
        else if (TXT_NAME.Text == "")
        {
            LBL_MSG.Text = "Please Enter Name";
            TXT_NAME.Focus();
        }
        else if (TXT_STAFF_ID.Text == "")
        {
            LBL_MSG.Text = "Please Enter Staff ID";
            TXT_STAFF_ID.Focus();
        }
        else if (TXT_STUD_ID.Text == "")
        {
            LBL_MSG.Text = "Please Enter Student ID";
            TXT_STUD_ID.Focus();
        }
        else if (TXT_DATE.Text == "")
        {
            LBL_MSG.Text = "Please Enter Date";
            TXT_DATE.Focus();
        }
        else if (TXT_AMOUNT_ID.Text == "")
        {
            LBL_MSG.Text = "Please Enter Amount ID";
            TXT_AMOUNT_ID.Focus();
        }
        else
        {
            try
            {
                Class1.cnn.Open();
                string str = "Insert into Staff_Commission(com_id,name,staff_id,stuid,date,amountid)Values('" + TXT_COM_ID.Text + "','" + TXT_NAME.Text + "','" + TXT_STAFF_ID.Text + "','" + TXT_STUD_ID.Text + "','" + TXT_DATE.Text + "','" + TXT_AMOUNT_ID.Text + "')";
                SqlCommand cmd = new SqlCommand(str, Class1.cnn);
                cmd.ExecuteNonQuery();
            }
            catch (Exception) { }
            finally
            {
                Class1.cnn.Close();
                LBL_MSG.Text = "Data Saved";
                blank();
            }
        }
    }
    //Method to Select data from table(Staff_Commission)
    protected void BTN_SEARCH_Click(object sender, EventArgs e)
    {
        if (TXT_COM_ID.Text == "")
        {
            LBL_MSG.Text = "Please Enter Commission ID";
            TXT_COM_ID.Focus();
        }
        else
        {
            Class1.cnn.Open();
            string str = "select * from Staff_Commission";
            SqlCommand cmd = new SqlCommand(str, Class1.cnn);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                if (TXT_COM_ID.Text == dr["COM_ID"].ToString())
                {
                    TXT_NAME.Text = dr["NAME"].ToString();
                    TXT_STAFF_ID.Text = dr["STAFF_ID"].ToString();
                    TXT_STUD_ID.Text = dr["STUID"].ToString();
                    TXT_DATE.Text = dr["DATE"].ToString();
                    TXT_AMOUNT_ID.Text = dr["AMOUNTID"].ToString();
                }
                else
                {
                    LBL_MSG.Text = "Commission ID Not Matched";
                    TXT_COM_ID.Focus();
                }
            }
            dr.Close();
            Class1.cnn.Close();
        }
    }
    //Method to Update data from table(Staff_Commission)
    protected void BTN_UPDATE_Click(object sender, EventArgs e)
    {
        try
        {
            Class1.cnn.Open();
            string str = "update Staff_Commission set NAME='" + TXT_NAME.Text + "',STAFF_ID='" + TXT_STAFF_ID.Text + "',STUID='" + TXT_STUD_ID.Text + "',DATE='"+TXT_DATE.Text+"',AMOUNTID='"+TXT_AMOUNT_ID.Text+"'where COM_ID='" + TXT_COM_ID.Text + "'";
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
    //Method to Delete data from table(Staff_Commission)
    protected void BTN_DELETE_Click(object sender, EventArgs e)
    {
        Class1.cnn.Open();
        string str = "Delete Staff_Commission where COM_ID='" + TXT_COM_ID.Text + "'";
        SqlCommand cmd = new SqlCommand(str, Class1.cnn);
        cmd.ExecuteNonQuery();
        Class1.cnn.Close();
        LBL_MSG.Text = "Data Deleted...";
        blank();
    }
    //Function to blank textboxes
    public void blank()
    {
        TXT_COM_ID.Text = "";
        TXT_NAME.Text = "";
        TXT_STAFF_ID.Text = "";
        TXT_STUD_ID.Text = "";
        TXT_DATE.Text = "";
        TXT_AMOUNT_ID.Text = "";
        TXT_COM_ID.Focus();
    }
}