<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Login.aspx.cs" Inherits="Logi" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">

        .style1
        {
            width: 49%;
            text-align: left;
            height: 372px;
        }
        .style2
        {
            text-align: center;
            font-family: Castellar;
            font-weight: 700;
            font-size: large;
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
        .style5
        {
            width: 227px;
        }
        .style6
        {
            font-size: medium;
            font-family: "Comic Sans MS";
            width: 227px;
            height: 27px;
        }
        .style7
        {
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
            font-size: medium;
            font-family: "Comic Sans MS";
            width: 227px;
        }
        </style>
</head>
<body background="img login,create,forgot/7000a5fb8e12b5cd7db628dcc3f84454.jpg" height="768px" width="1000px">
    <form id="form1" runat="server">
    <div>
    
        </p>
        <br />
    
    <table img alt="" src="images/imagination-675.jpg"  align="center" class="style1" 
            frame="box" cellpadding="5" cellspacing="10">
        <tr>
            <td class="style2" colspan="3">
                LOGIN FORM</td>
        </tr>
        <tr>
            <td class="style3" colspan="3">
                <asp:Label ID="LBL_ALERT" runat="server" ForeColor="#CC3300"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="style10">
                Username</td>
            <td>
                <asp:TextBox ID="TXT_USER_NAME" runat="server" Width="150px"></asp:TextBox>
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
                <asp:TextBox ID="TXT_PASSWORD" runat="server" Width="150px" TextMode="Password"></asp:TextBox>
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
            <td class="style7">
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
            <td class="style5">
                <asp:LinkButton ID="LNK_CREATE_USER" runat="server" CssClass="style4" 
                    PostBackUrl="~/Create User.aspx">Create User</asp:LinkButton>
            </td>
            <td>
                <asp:Button ID="BTN_LOGIN" runat="server" style="margin-left: 25px" Text="Login" 
                    Width="109px" CssClass="style4" onclick="BTN_LOGIN_Click" />
            </td>
            <td>
                <asp:LinkButton ID="LNK_FORGET_PWD" runat="server" CssClass="style4" 
                    PostBackUrl="~/Forget Password.aspx">Forgot Password?</asp:LinkButton>
            </td>
        </tr>
    </table>
    
    </div>
    </form>
    <p>
</body>
</html>
