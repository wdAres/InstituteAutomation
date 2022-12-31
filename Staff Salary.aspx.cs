using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

public partial class Staff_Salary : System.Web.UI.Page
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
    //Method to Insert data into table(Staff_Salary)
    protected void BTN_SUBMIT_Click(object sender, EventArgs e)
    {
        if (TXT_STAFF_ID.Text == "")
        {
            LBL_MSG.Text = "Please Enter Staff ID";
            TXT_STAFF_ID.Focus();
        }
        else if (TXT_B_SALARY.Text == "")
        {
            LBL_MSG.Text = "Please Enter Basic Salary";
            TXT_B_SALARY.Focus();
        }
        else if (TXT_HRA.Text == "")
        {
            LBL_MSG.Text = "Please Enter HRA";
            TXT_HRA.Focus();
        }
        else if (TXT_TA.Text == "")
        {
            LBL_MSG.Text = "Please Enter TA";
            TXT_TA.Focus();
        }
        else if (TXT_DA.Text == "")
        {
            LBL_MSG.Text = "Please Enter DA";
            TXT_DA.Focus();
        }
        else if (TXT_OTHER.Text == "")
        {
            LBL_MSG.Text = "Please Enter Other";
            TXT_OTHER.Focus();
        }
        else if (TXT_PF.Text == "")
        {
            LBL_MSG.Text = "Please Enter PF";
            TXT_PF.Focus();
        }
        else if (TXT_DATE.Text == "")
        {
            LBL_MSG.Text = "Please Enter Date";
            TXT_DATE.Focus();
        }
        else if (TXT_VOUCHER_NO.Text == "")
        {
            LBL_MSG.Text = "Please Enter Voucher No";
            TXT_VOUCHER_NO.Focus();
        }
        else
        {
            try
            {
                Class1.cnn.Open();
                string str = "insert into Staff_Salary(Staff_id,Bs,Hra,Ta,Da,Other,Pf,Date,Voucher_no)Values('" + TXT_STAFF_ID.Text + "','" + TXT_B_SALARY.Text + "','" + TXT_HRA.Text + "','" + TXT_TA.Text + "','"+TXT_DA.Text+"','"+TXT_OTHER.Text+"','"+TXT_PF.Text+"','"+TXT_DATE.Text+"','"+TXT_VOUCHER_NO.Text+"')";
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
    //Method to Select data from table(Staff_Salary)
    protected void BTN_SEARCH_Click(object sender, EventArgs e)
    {
        if (TXT_STAFF_ID.Text == "")
        {
            LBL_MSG.Text = "Please Enter Staff ID";
            TXT_STAFF_ID.Focus();
        }
        else
        {
            Class1.cnn.Open();
            string str = "select * from Staff_Salary";
            SqlCommand cmd = new SqlCommand(str, Class1.cnn);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                if (TXT_STAFF_ID.Text == dr["STAFF_ID"].ToString())
                {
                    TXT_B_SALARY.Text = dr["BS"].ToString();
                    TXT_HRA.Text = dr["HRA"].ToString();
                    TXT_TA.Text = dr["TA"].ToString();
                    TXT_DA.Text = dr["DA"].ToString();
                    TXT_OTHER.Text = dr["OTHER"].ToString();
                    TXT_PF.Text = dr["PF"].ToString();
                    TXT_DATE.Text = dr["DATE"].ToString();
                    TXT_VOUCHER_NO.Text = dr["VOUCHER_NO"].ToString();
                }
                else
                {
                    LBL_MSG.Text = "Staff ID Not Matched";
                    TXT_STAFF_ID.Focus();
                }
            }
            dr.Close();
            Class1.cnn.Close();
        }
    }
    //Method to Update data from table(Staff_Salary)
    protected void BTN_UPDATE_Click(object sender, EventArgs e)
    {
        try
        {
            Class1.cnn.Open();
            string str = "Update Staff_Salary Set Bs='" + TXT_B_SALARY.Text + "',Hra='" + TXT_HRA.Text + "',Ta='" + TXT_TA.Text + "',Da='" + TXT_DA.Text + "',Other='" + TXT_OTHER.Text + "',Pf='" + TXT_PF.Text + "',Date='" + TXT_DATE.Text + "',Voucher_No='" + TXT_VOUCHER_NO.Text + "' Where Staff_id='" + TXT_STAFF_ID.Text + "'";
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
    //Method to Delete data from table(Staff_Salary)
    protected void BTN_DELETE_Click(object sender, EventArgs e)
    {
        Class1.cnn.Open();
        string str = "Delete Staff_Salary where STAFF_ID='" + TXT_STAFF_ID.Text + "'";
        SqlCommand cmd = new SqlCommand(str, Class1.cnn);
        cmd.ExecuteNonQuery();
        Class1.cnn.Close();
        LBL_MSG.Text = "Data Deleted...";
        blank();
    }
    //Function to blank textboxes.
    public void blank()
    {
        TXT_STAFF_ID.Text = "";
        TXT_B_SALARY.Text = "";
        TXT_HRA.Text = "";
        TXT_TA.Text = "";
        TXT_DA.Text = "";
        TXT_OTHER.Text = ""; 
        TXT_PF.Text = "";
        TXT_DATE.Text = "";
        TXT_VOUCHER_NO.Text = "";
        TXT_STAFF_ID.Focus();
    }
}