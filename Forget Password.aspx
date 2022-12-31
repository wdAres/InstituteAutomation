<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Forget Password.aspx.cs" Inherits="Forget_Password" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .style1
        {
            width: 42%;
            height: 373px;
            margin-left: 6px;
            margin-top: 5px;
        }
        .style2
        {
            font-family: "Comic Sans MS";
            font-size: medium;
        }
        .style3
        {
            font-family: "Copperplate Gothic Light";
            font-weight: bold;
        }
        .style4
        {
            height: 32px;
        }
    </style>
</head>
<body background="img login,create,forgot/maxresdefault (1).jpg">
    <form id="form1" runat="server">
    <div>
    
        <table align="left" class="style1" cellpadding="5" cellspacing="10" 
            frame="box">
            <tr>
                <td colspan="2" 
                    style="text-align: center; font-weight: 700; font-family: Castellar; font-size: large;">
                    Forget Password</td>
            </tr>
            <tr>
                <td class="style2" colspan="2">
                    <asp:Label ID="LBL_MSG" runat="server" ForeColor="#663300"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="style2">
                    User Name</td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td>
                    <asp:TextBox ID="TXT_USER_NAME" runat="server" Width="342px" Height="28px"></asp:TextBox>
                </td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td>
                    &nbsp;<asp:Button ID="BTN_GET_PWD" runat="server" Height="27px" style="margin-left: 0px" 
                        Text="Get Password" Width="135px" CssClass="style3" 
                        onclick="BTN_GET_PWD_Click" />
                </td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="style2">
                    Password</td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="style4">
                    <asp:TextBox ID="TXT_PASSWORD" runat="server" Width="342px" Height="24px"></asp:TextBox>
                </td>
                <td class="style4">
                    </td>
            </tr>
            <tr>
                <td><asp:LinkButton ID="LNK_LOGIN" runat="server" CssClass="style3" 
                    PostBackUrl="~/Login.aspx">Login</asp:LinkButton></td>
                <td>&nbsp;</td>
            </tr>
        </table>
    </div>
    </form>
</body>
</html>
