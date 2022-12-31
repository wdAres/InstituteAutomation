using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

public partial class Staff_Details : System.Web.UI.Page
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
    //Method to Insert data into table(Staff_Details)
    protected void BTN_SUBMIT_Click(object sender, EventArgs e)
    {
        if (TXT_STAFF_ID.Text == "")
        {
            LBL_MSG.Text = "Please enter Staff ID";
            TXT_STAFF_ID.Focus();
        }
        else if (TXT_F_NAME.Text == "")
        {
            LBL_MSG.Text = "Please enter First Name";
            TXT_F_NAME.Focus();
        }
        else if (TXT_QUALIFICATION.Text == "")
        {
            LBL_MSG.Text = "Please enter Qualification";
            TXT_QUALIFICATION.Focus();
        }
        else if (TXT_ADD1.Text == "")
        {
            LBL_MSG.Text = "Please enter Address1";
            TXT_ADD1.Focus();
        }
        else if (TXT_ADD2.Text == "")
        {
            LBL_MSG.Text = "Please enter Address2";
            TXT_ADD2.Focus();
        }
        else if (TXT_CITY.Text == "")
        {
            LBL_MSG.Text = "Please enter City";
            TXT_CITY.Focus();
        }
        else if (TXT_STATE.Text == "")
        {
            LBL_MSG.Text = "Please enter State";
            TXT_STATE.Focus();
        }
        else if (TXT_ZIPCODE.Text == "")
        {
            LBL_MSG.Text = "Please enter Zipcode";
            TXT_ZIPCODE.Focus();
        }
        else if (TXT_PHONE1.Text == "")
        {
            LBL_MSG.Text = "Please enter Phone1";
            TXT_PHONE1.Focus();
        }
        else if (TXT_PHONE2.Text == "")
        {
            LBL_MSG.Text = "Please enter Phone2";
            TXT_PHONE2.Focus();
        }
        else if (TXT_MOBILE.Text == "")
        {
            LBL_MSG.Text = "Please enter Mobile";
            TXT_MOBILE.Focus();
        }
        else if (TXT_EMAIL.Text == "")
        {
            LBL_MSG.Text = "Please enter Email";
            TXT_EMAIL.Focus();
        }
        else if (TXT_D_O_JOIN.Text == "")
        {
            LBL_MSG.Text = "Please enter Date of Joining";
            TXT_D_O_JOIN.Focus();
        }
        else if (TXT_DESIGNATION.Text == "")
        {
            LBL_MSG.Text = "Please enter Designation";
            TXT_DESIGNATION.Focus();
        }
        else if (TXT_B_SALARY.Text == "")
        {
            LBL_MSG.Text = "Please enter Basic Salary";
            TXT_B_SALARY.Focus();
        }
        else if (TXT_HRA.Text == "")
        {
            LBL_MSG.Text = "Please enter Hra";
            TXT_HRA.Focus();
        }
        else if (TXT_TA.Text == "")
        {
            LBL_MSG.Text = "Please enter Ta";
            TXT_TA.Focus();
        }
        else if (TXT_DA.Text == "")
        {
            LBL_MSG.Text = "Please enter Da";
            TXT_DA.Focus();
        }
        else if (TXT_PF.Text == "")
        {
            LBL_MSG.Text = "Please enter Pf";
            TXT_PF.Focus();
        }
        else
        {
            try
            {
                Class1.cnn.Open();
                string str="insert into staff_details(Staff_id,F_name,Qualification,Add1,Add2,City,State,Zipcode,Phone1,Phone2,Mobile,Email,D_o_join,Designation,Bsalary,Hra,Ta,Da,Pf)Values('"+TXT_STAFF_ID.Text+"','"+TXT_F_NAME.Text+"','"+TXT_QUALIFICATION.Text+"','"+TXT_ADD1.Text+"','"+TXT_ADD2.Text+"','"+TXT_CITY.Text+"','"+TXT_STATE.Text+"','"+TXT_ZIPCODE.Text+"','"+TXT_PHONE1.Text+"','"+TXT_PHONE2.Text+"','"+TXT_MOBILE.Text+"','"+TXT_EMAIL.Text+"','"+TXT_D_O_JOIN.Text+"','"+TXT_DESIGNATION.Text+"','"+TXT_B_SALARY.Text+"','"+TXT_HRA.Text+"','"+TXT_TA.Text+"','"+TXT_DA.Text+"','"+TXT_PF.Text+"')";
                SqlCommand cmd=new SqlCommand(str,Class1.cnn);
                cmd.ExecuteNonQuery();
            }
            catch(Exception){}
            finally
            {
                Class1.cnn.Close();
                LBL_MSG.Text="Data Saved...";
                blank();
            }
        }
    }
    //Method to Select data from table(Staff_Details)
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
            string str = "select * from staff_details";
            SqlCommand cmd = new SqlCommand(str, Class1.cnn);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                if (TXT_STAFF_ID.Text == dr["STAFF_ID"].ToString())
                {
                    TXT_F_NAME.Text = dr["F_name"].ToString();
                    TXT_QUALIFICATION.Text = dr["QUALIFICATION"].ToString();
                    TXT_ADD1.Text = dr["ADD1"].ToString();
                    TXT_ADD2.Text = dr["ADD2"].ToString();
                    TXT_CITY.Text = dr["CITY"].ToString();
                    TXT_STATE.Text = dr["STATE"].ToString();
                    TXT_ZIPCODE.Text = dr["ZIPCODE"].ToString();
                    TXT_PHONE1.Text = dr["PHONE1"].ToString();
                    TXT_PHONE2.Text = dr["PHONE2"].ToString();
                    TXT_MOBILE.Text = dr["MOBILE"].ToString();
                    TXT_EMAIL.Text = dr["EMAIL"].ToString();
                    TXT_D_O_JOIN.Text = dr["D_O_JOIN"].ToString();
                    TXT_DESIGNATION.Text = dr["DESIGNATION"].ToString();
                    TXT_B_SALARY.Text = dr["BSALARY"].ToString();
                    TXT_HRA.Text = dr["HRA"].ToString();
                    TXT_TA.Text = dr["TA"].ToString();
                    TXT_DA.Text = dr["DA"].ToString();
                    TXT_PF.Text = dr["PF"].ToString();
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
    //Method to Update data from table(Staff_Details)
    protected void BTN_UPDATE_Click(object sender, EventArgs e)
    {
        try
        {
            Class1.cnn.Open();
            string str = "update staff_details set F_Name='" + TXT_F_NAME.Text + "',QUALIFICATION='" + TXT_QUALIFICATION.Text + "',ADD1='" + TXT_ADD1.Text + "',ADD2='" + TXT_ADD2.Text + "',CITY='" + TXT_CITY.Text + "',STATE='" + TXT_STATE.Text + "',ZIPCODE='" + TXT_ZIPCODE.Text + "',PHONE1='" + TXT_PHONE1.Text + "',PHONE2='" + TXT_PHONE2.Text + "',MOBILE='" + TXT_MOBILE.Text + "',EMAIL='" + TXT_EMAIL.Text + "',D_O_JOIN='" + TXT_D_O_JOIN.Text + "',DESIGNATION='" + TXT_DESIGNATION.Text + "',BSALARY='" + TXT_B_SALARY.Text + "',HRA='" + TXT_HRA.Text + "',TA='" + TXT_TA.Text + "',DA='" + TXT_DA.Text + "',PF='" + TXT_PF.Text + "'where STAFF_ID='" + TXT_STAFF_ID.Text + "'";
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
    //Method to Delete data from table(Staff_Details)
    protected void BTN_DELETE_Click(object sender, EventArgs e)
    {
        Class1.cnn.Open();
        string str = "Delete staff_details where STAFF_ID='" + TXT_STAFF_ID.Text + "'";
        SqlCommand cmd = new SqlCommand(str, Class1.cnn);
        cmd.ExecuteNonQuery();
        Class1.cnn.Close();
        LBL_MSG.Text = "Data Deleted...";
        blank();
    }
    //Function to blank textboxes
    public void blank()
    {
        TXT_STAFF_ID.Text = "";
        TXT_F_NAME.Text = "";
        TXT_QUALIFICATION.Text = "";
        TXT_ADD1.Text = "";
        TXT_ADD2.Text = "";
        TXT_CITY.Text = "";
        TXT_STATE.Text = "";
        TXT_ZIPCODE.Text = "";
        TXT_PHONE1.Text = "";
        TXT_PHONE2.Text = "";
        TXT_MOBILE.Text = "";
        TXT_EMAIL.Text = "";
        TXT_D_O_JOIN.Text = "";
        TXT_DESIGNATION.Text = "";
        TXT_B_SALARY.Text = "";
        TXT_HRA.Text = "";
        TXT_TA.Text = "";
        TXT_DA.Text = "";
        TXT_PF.Text = "";
        TXT_STAFF_ID.Focus();
    }
}