using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

public partial class Student_Master : System.Web.UI.Page
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
    //Method to Insert data into table(Student_Master)
    protected void BTN_SUBMIT_Click1(object sender, EventArgs e)
    {
        if (TXT_ROLLNO.Text == "")
        {
            LBL_MSG.Text = "Please Enter Roll No";
            TXT_ROLLNO.Focus();
        }
        else if (TXT_NAME.Text == "")
        {
            LBL_MSG.Text = "Please Enter Name";
            TXT_NAME.Focus();
        }
        else if (TXT_F_NAME.Text == "")
        {
            LBL_MSG.Text = "Please Enter Father Name";
            TXT_F_NAME.Focus();
        }
        else if (TXT_GENDER.Text == "")
        {
            LBL_MSG.Text = "Please Enter Gender";
            TXT_GENDER.Focus();
        }
        else if (TXT_DOB.Text == "")
        {
            LBL_MSG.Text = "Please Enter Date of Birth";
            TXT_DOB.Focus();
        }
        else if (TXT_ADD1.Text == "")
        {
            LBL_MSG.Text = "Please Enter Address1";
            TXT_ADD1.Focus();
        }
        else if (TXT_ADD2.Text == "")
        {
            LBL_MSG.Text = "Please Enter Address2";
            TXT_ADD2.Focus();
        }
        else if (TXT_CITY.Text == "")
        {
            LBL_MSG.Text = "Please Enter Charge";
            TXT_CITY.Focus();
        }
        else if (TXT_STATE.Text == "")
        {
            LBL_MSG.Text = "Please Enter State";
            TXT_STATE.Focus();
        }
        else if (TXT_ZIPCODE.Text == "")
        {
            LBL_MSG.Text = "Please Enter Zipcode";
            TXT_ZIPCODE.Focus();
        }
        else if (TXT_PHONE1.Text == "")
        {
            LBL_MSG.Text = "Please Enter Phone1";
            TXT_PHONE1.Focus();
        }
        else if (TXT_PHONE2.Text == "")
        {
            LBL_MSG.Text = "Please Enter Phone2";
            TXT_PHONE2.Focus();
        }
        else
        {
            try
            {
                Class1.cnn.Open();
                string str = "insert into Student_Master(Roll_no,Name,F_Name,Gender,D_o_birth,Add1,Add2,City,State,Zipcode,Phone1,Phone2)values('" + TXT_ROLLNO.Text + "','" + TXT_NAME.Text + "','" + TXT_F_NAME.Text + "','" + TXT_GENDER.Text + "','" + TXT_DOB.Text + "','" + TXT_ADD1.Text + "','" + TXT_ADD2.Text + "','" + TXT_CITY.Text + "','" + TXT_STATE.Text + "','" + TXT_ZIPCODE.Text + "','" + TXT_PHONE1.Text + "','" + TXT_PHONE2.Text + "')";
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
    //Method to Select data from table(Student_Master)
    protected void BTN_SEARCH_Click(object sender, EventArgs e)
    {
        if (TXT_ROLLNO.Text == "")
        {
            LBL_MSG.Text = "Please Enter RollNo";
            TXT_ROLLNO.Focus();
        }
        else
        {
            Class1.cnn.Open();
            string str = "select * from Student_Master";
            SqlCommand cmd = new SqlCommand(str, Class1.cnn);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                if (TXT_ROLLNO.Text == dr["ROLL_NO"].ToString())
                {
                    TXT_NAME.Text = dr["NAME"].ToString();
                    TXT_F_NAME.Text = dr["F_NAME"].ToString();
                    TXT_GENDER.Text = dr["GENDER"].ToString();
                    TXT_DOB.Text = dr["D_O_BIRTH"].ToString();
                    TXT_ADD1.Text = dr["ADD1"].ToString();
                    TXT_ADD2.Text = dr["ADD2"].ToString();
                    TXT_CITY.Text = dr["CITY"].ToString();
                    TXT_STATE.Text = dr["STATE"].ToString();
                    TXT_ZIPCODE.Text = dr["ZIPCODE"].ToString();
                    TXT_PHONE1.Text = dr["PHONE1"].ToString();
                    TXT_PHONE2.Text = dr["PHONE2"].ToString();
                }
                else
                {
                    LBL_MSG.Text = "Roll No Not Matched";
                    TXT_ROLLNO.Focus();
                }
            }
            dr.Close();
            Class1.cnn.Close();
        }
    }
    //Method to Update data from table(Student_Master)
    protected void BTN_UPDATE_Click(object sender, EventArgs e)
    {
        try
        {
            Class1.cnn.Open();
            string str = "update Student_Master set NAME='" + TXT_NAME.Text + "',F_NAME='" + TXT_F_NAME.Text + "',GENDER='" + TXT_GENDER.Text +"',D_O_BIRTH='"+TXT_DOB.Text+"',ADD1='"+TXT_ADD1.Text+"',ADD2='"+TXT_ADD2.Text+"',CITY='"+TXT_CITY.Text+"',STATE='"+TXT_STATE.Text+"',ZIPCODE='"+TXT_ZIPCODE.Text+"',PHONE1='"+TXT_PHONE1.Text+"',PHONE2='"+TXT_PHONE2.Text+"'where Roll_no='" + TXT_ROLLNO.Text + "'";
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
    //Method to Delete data from table(Student_Master)
    protected void BTN_DELETE_Click(object sender, EventArgs e)
    {
        Class1.cnn.Open();
        string str = "Delete Student_Master where Roll_no='" + TXT_ROLLNO.Text + "'";
        SqlCommand cmd = new SqlCommand(str, Class1.cnn);
        cmd.ExecuteNonQuery();
        Class1.cnn.Close();
        LBL_MSG.Text = "Data Deleted...";
        blank();
    }
    //Function to blank textboxes
    public void blank()
    {
        TXT_ROLLNO.Text = "";
        TXT_NAME.Text = "";
        TXT_F_NAME.Text = "";
        TXT_GENDER.Text = "";
        TXT_DOB.Text = "";
        TXT_ADD1.Text = "";
        TXT_ADD2.Text = "";
        TXT_CITY.Text = "";
        TXT_STATE.Focus();
        TXT_ZIPCODE.Text = "";
        TXT_PHONE1.Text = "";
        TXT_PHONE2.Text = "";
    }
}