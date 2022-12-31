using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

public partial class Fee_Details : System.Web.UI.Page
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
    //Method to Insert data into table(Fee_Details)
    protected void BTN_SUBMIT_Click(object sender, EventArgs e)
    {
        if (TXT_RECEIPT_NO.Text == "")
        {
            LBL_MSG.Text = "Please Enter Receipt_No";
            TXT_RECEIPT_NO.Focus();
        }
        else if (TXT_PARTICULARS.Text == "")
        {
            LBL_MSG.Text = "Please Enter Particulars";
            TXT_PARTICULARS.Focus();
        }
        else if (TXT_FEE.Text == "")
        {
            LBL_MSG.Text = "Please Enter Fee";
            TXT_FEE.Focus();
        }
        else
        {
            try
            {
                Class1.cnn.Open();
                string str = "insert into Fee_Details(Receipt_No,Particulars,Fee)values('" + TXT_RECEIPT_NO.Text + "','"  + TXT_PARTICULARS.Text + "','" + TXT_FEE.Text + "')";
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
    //Method to Select data from table(Fee_Details)
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
            string str = "select * from Fee_Details";
            SqlCommand cmd = new SqlCommand(str, Class1.cnn);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                if (TXT_RECEIPT_NO.Text == dr["RECEIPT_NO"].ToString())
                {
                    TXT_PARTICULARS.Text = dr["Particulars"].ToString();
                    TXT_FEE.Text = dr["FEE"].ToString();
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
    //Method to Update data from table(Fee_Details)
    protected void BTN_UPDATE_Click(object sender, EventArgs e)
    {
        try
        {
            Class1.cnn.Open();
            string str = "update Fee_Details set Particulars='" + TXT_PARTICULARS.Text + "',Fee='" + TXT_FEE.Text + "'where Receipt_no='" + TXT_RECEIPT_NO.Text + "'";
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
    //Method to Delete data from table(Fee_Details)
    protected void BTN_DELETE_Click(object sender, EventArgs e)
    {
        Class1.cnn.Open();
        string str = "Delete Fee_Details where Receipt_no='" + TXT_RECEIPT_NO.Text + "'";
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
        TXT_PARTICULARS.Text = "";
        TXT_FEE.Text = "";
        TXT_RECEIPT_NO.Focus();
    }
}