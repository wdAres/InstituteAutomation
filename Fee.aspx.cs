using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

public partial class Fee : System.Web.UI.Page
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
    //Method to Insert data into table(Fee)
    protected void BTN_SUBMIT_Click(object sender, EventArgs e)
    {
        if (TXT_RECEIPT_NO.Text == "")
        {
            LBL_MSG.Text = "Please Enter Receipt No";
            TXT_RECEIPT_NO.Focus();
        }
        else if (TXT_SESSION.Text == "")
        {
            LBL_MSG.Text = "Please Enter Session";
            TXT_SESSION.Focus();
        }
        else if (TXT_REG_NO.Text == "")
        {
            LBL_MSG.Text = "Please Enter Registration No";
            TXT_REG_NO.Focus();
        }
        else if (TXT_DISCOUNT.Text == "")
        {
            LBL_MSG.Text = "Please Enter Discount";
            TXT_DISCOUNT.Focus();
        }
        else if (TXT_TOTAL_FEE.Text == "")
        {
            LBL_MSG.Text = "Please Enter Total Fee";
            TXT_TOTAL_FEE.Focus();
        }
        else if (TXT_DATE.Text == "")
        {
            LBL_MSG.Text = "Please Enter Date";
            TXT_DATE.Focus();
        }
        else if (TXT_MONTH.Text == "")
        {
            LBL_MSG.Text = "Please Enter Month";
            TXT_MONTH.Focus();
        }
        else
        {
            try
            {
                Class1.cnn.Open();
                string str = "insert into Fee(Receipt_no,Session,Reg_no,Discount,Total_fee,Date,Month) Values('" + TXT_RECEIPT_NO.Text + "','" + TXT_SESSION.Text + "','" + TXT_REG_NO.Text + "','" + TXT_DISCOUNT.Text + "','" + TXT_TOTAL_FEE.Text + "','" + TXT_DATE.Text + "','" + TXT_MONTH.Text +"')";
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
    //Method to Select data from table(Fee)
    protected void BTN_SEARCH_Click(object sender, EventArgs e)
    {
        if (TXT_RECEIPT_NO.Text == "")
        {
            LBL_MSG.Text = "Please Enter Receipt No";
            TXT_RECEIPT_NO.Focus();
        }
        else
        {
            Class1.cnn.Open();
            string str = "select * from Fee";
            SqlCommand cmd = new SqlCommand(str, Class1.cnn);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                if (TXT_RECEIPT_NO.Text == dr["RECEIPT_NO"].ToString())
                {
                    TXT_SESSION.Text = dr["SESSION"].ToString();
                    TXT_REG_NO.Text = dr["REG_NO"].ToString();
                    TXT_DISCOUNT.Text = dr["DISCOUNT"].ToString();
                    TXT_TOTAL_FEE.Text = dr["TOTAL_FEE"].ToString();
                    TXT_DATE.Text = dr["DATE"].ToString();
                    TXT_MONTH.Text = dr["MONTH"].ToString();
                }
                else
                {
                    LBL_MSG.Text = "Receipt No Not Matched";
                    TXT_RECEIPT_NO.Focus();
                }
            }
            dr.Close();
            Class1.cnn.Close();
        }
    }
    //Method to Update data from table(Fee)
    protected void BTN_UPDATE_Click(object sender, EventArgs e)
    {
        try
        {
            Class1.cnn.Open();
            string str = "update Fee set SESSION='" + TXT_SESSION.Text + "',REG_NO='" + TXT_REG_NO.Text + "',DISCOUNT='" + TXT_DISCOUNT.Text + "',TOTAL_FEE='" + TXT_TOTAL_FEE.Text + "',DATE='" + TXT_DATE.Text + "',MONTH='" + TXT_MONTH.Text + "'where RECEIPT_NO='" + TXT_RECEIPT_NO.Text + "'";
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
    //Method to Delete data from table(Fee)
    protected void BTN_DELETE_Click(object sender, EventArgs e)
    {
        Class1.cnn.Open();
        string str = "Delete Fee where RECEIPT_NO='" + TXT_RECEIPT_NO.Text + "'";
        SqlCommand cmd = new SqlCommand(str, Class1.cnn);
        cmd.ExecuteNonQuery();
        Class1.cnn.Close();
        LBL_MSG.Text = "Data Deleted...";
        blank();
    }
    //Function to blank textboxes
    public void blank()
    {
        TXT_RECEIPT_NO.Text = "";
        TXT_SESSION.Text = "";
        TXT_REG_NO.Text = "";
        TXT_DISCOUNT.Text = "";
        TXT_TOTAL_FEE.Text = "";
        TXT_DATE.Text = "";
        TXT_MONTH.Text = "";
        TXT_RECEIPT_NO.Focus();
    }
}