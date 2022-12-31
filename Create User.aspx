<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Create User.aspx.cs" Inherits="Create_User" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .style1
        {
            width: 47%;
            height: 396px;
        }
        .style2
        {
            font-family: "Comic Sans MS";
            font-size: medium;
        }
        .style3
        {
            font-size: medium;
            font-family: "Comic Sans MS";
        }
        .style4
        {
            font-size: medium;
            font-family: "Copperplate Gothic Light";
            font-weight: bold;
        }
        .style6
        {
            font-size: medium;
            font-family: "Comic Sans MS";
            width: 210px;
            height: 27px;
        }
        .style8
        {
            height: 27px;
            font-weight: bold;
        }
        .style9
        {
            font-family: Aparajita;
            font-weight: bold;
        }
        .style10
        {
            font-family: "Comic Sans MS";
            font-size: medium;
            width: 210px;
        }
        .style11
        {
            width: 210px;
        }
        </style>
</head>
<body background="img login,create,forgot/OndXb0.jpg">
    <form id="form1" runat="server">
    <div>
    
        <table align="center" class="style1" cellpadding="5" cellspacing="10" 
            frame="box">
            <tr>
                <td colspan="3" 
                    style="text-align: center; font-weight: 700; font-size: x-large; font-family: Castellar;">
                    Create User Form</td>
            </tr>
            <tr>
                <td class="style2" colspan="3">
                    <asp:Label ID="LBL_MSG" runat="server" ForeColor="#663300"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="style10">
                    User Name</td>
                <td>
                    <asp:TextBox ID="TXT_USER_NAME" runat="server" Width="153px"></asp:TextBox>
                </td>
            <td>
                <asp:RequiredFieldValidator ID="RFV_USERNAME" runat="server" 
                    ControlToValidate="TXT_USER_NAME" ErrorMessage="Please Enter Username" 
                    ForeColor="#CC3300"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="style10">
                    Password</td>
                <td>
                    <asp:TextBox ID="TXT_PASSWORD" runat="server" Width="153px" TextMode="Password"></asp:TextBox>
                </td>
            <td>
                <asp:RequiredFieldValidator ID="RFV_PASSWORD" runat="server" 
                    ControlToValidate="TXT_PASSWORD" ErrorMessage="Please Enter Password" 
                    ForeColor="#CC3300"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
            <td class="style6">
                Member of</td>
                <td>
                <asp:DropDownList ID="DDL_MEMBER_OF" runat="server" Height="22px" Width="150px">
                    <asp:ListItem Value="Student"></asp:ListItem>
                    <asp:ListItem>Admin</asp:ListItem>
                    <asp:ListItem>Teacher</asp:ListItem>
                </asp:DropDownList>
                </td>
            <td class="style8">
                &nbsp;</td>
            </tr>
            <tr>
            <td class="style10">
                Expiry Date</td>
                <td>
                <asp:TextBox ID="TXT_EXPIRY_DATE" runat="server" Width="150px"></asp:TextBox>
                </td>
            <td class="style9">
                &nbsp;</td>
            </tr>
            <tr>
            <td class="style10">
                Login Date</td>
                <td>
                <asp:TextBox ID="TXT_LOGIN_DATE" runat="server" Width="150px"></asp:TextBox>
                </td>
            <td class="style9">
                &nbsp;</td>
            </tr>
            <tr>
                <td class="style11">
                    <b>
                    <asp:LinkButton ID="LNK_LOGIN" runat="server" CssClass="style3" 
                        PostBackUrl="~/Login.aspx">Login</asp:LinkButton>
                    </b>
                </td>
                <td>
                    <asp:Button ID="BTN_SUBMIT" runat="server" style="margin-left: 30px" 
                        Text="Submit" Width="120px" CssClass="style4" onclick="BTN_SUBMIT_Click" />
                </td>
                <td>
                    &nbsp;</td>
            </tr>
        </table>
    
    </div>
    </form>
</body>
</html>
