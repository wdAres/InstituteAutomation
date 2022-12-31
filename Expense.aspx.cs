using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

public partial class Expense : System.Web.UI.Page
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
    //Method to Insert data into table(Expense)
    protected void BTN_SUBMIT_Click(object sender, EventArgs e)
    {
        if (TXT_STAFF_ID.Text == "")
        {
            LBL_MSG.Text = "Please Enter Staff ID";
            TXT_STAFF_ID.Focus();
        }
        else if (TXT_DATE.Text == "")
        {
            LBL_MSG.Text = "Please Enter Date";
            TXT_DATE.Focus();
        }
        else if (TXT_PARTICULARS.Text == "")
        {
            LBL_MSG.Text = "Please Enter Particulars";
            TXT_PARTICULARS.Focus();
        }
        else if (TXT_AMOUNT.Text == "")
        {
            LBL_MSG.Text = "Please Enter Amount";
            TXT_AMOUNT.Focus();
        }
        else
        {
            try
            {
                Class1.cnn.Open();
                string str="Insert into Expense(Staff_id,date,particulars,amount)Values('"+TXT_STAFF_ID.Text+"','"+TXT_DATE.Text+"','"+TXT_PARTICULARS.Text+"','"+TXT_AMOUNT.Text+"')";
                SqlCommand cmd=new SqlCommand(str,Class1.cnn);
                cmd.ExecuteNonQuery();
            }
            catch(Exception){}
            finally
            {
                Class1.cnn.Close();
                LBL_MSG.Text="Data Saved";
                blank();
            }
    }
}
    //Method to Select data from table(Expense)
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
            string str = "Select * from Expense";
            SqlCommand cmd = new SqlCommand(str, Class1.cnn);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                if (TXT_STAFF_ID.Text == dr["Staff_ID"].ToString())
                {
                    TXT_DATE.Text = dr["Date"].ToString();
                    TXT_PARTICULARS.Text = dr["Particulars"].ToString();
                    TXT_AMOUNT.Text = dr["Amount"].ToString();
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
    //Method to Update data from table(Expense)
    protected void BTN_UPDATE_Click(object sender, EventArgs e)
    {
        try
        {
            Class1.cnn.Open();
            string str = "Update Expense Set Date='" + TXT_DATE.Text + "',Particulars='" + TXT_PARTICULARS.Text + "',Amount='" + TXT_AMOUNT.Text + "' Where Staff_ID='" + TXT_STAFF_ID.Text + "'";
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
    //Method to Delete data from table(Expense)
    protected void BTN_DELETE_Click(object sender, EventArgs e)
    {
        Class1.cnn.Open();
        string str="Delete Expense Where Staff_Id='"+TXT_STAFF_ID.Text+"'";
        SqlCommand cmd=new SqlCommand(str,Class1.cnn);
        cmd.ExecuteNonQuery();
        Class1.cnn.Close();
        LBL_MSG.Text = "Data Deleted";
        blank();
    }
    //Function to blank textboxes
    public void blank()
    {
        TXT_STAFF_ID.Text = "";
        TXT_DATE.Text = "";
        TXT_PARTICULARS.Text = "";
        TXT_AMOUNT.Text = "";
        TXT_STAFF_ID.Focus();
    }
}
