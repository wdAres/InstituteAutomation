<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage(admin).master" AutoEventWireup="true" CodeFile="Student_Master.aspx.cs" Inherits="Student_Master" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .style1
        {
            width: 61%;
            height: 449px;
        }
        .style2
        {
            height: 26px;
        }
        .style3
        {
            width: 328px;
        }
        .style4
        {
            height: 26px;
            width: 328px;
        }
        .style5
        {
            width: 312px;
            font-family: "Comic Sans MS";
            font-size: large;
            color: #003366;
        }
        .style6
        {
            height: 26px;
            width: 312px;
            font-family: "Comic Sans MS";
            font-size: large;
            color: #003366;
        }
        .style7
        {
            height: 22px;
            text-align: left;
        }
        .style8
        {
            width: 312px;
            height: 28px;
            font-family: "Comic Sans MS";
            font-size: large;
            color: #003366;
        }
        .style9
        {
            width: 328px;
            height: 28px;
        }
        .style10
        {
            height: 28px;
        }
        .style11
        {
            height: 22px;
            text-align: center;
        }
        .style12
        {
            height: 26px;
            width: 328px;
            font-family: "Lucida Sans Typewriter";
            font-size: medium;
            font-weight: bold;
            color: #003366;
        }
        .style13
        {
            color: #CC3300;
        }
        .style14
        {
            color: #003366;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

    <table align="center" class="style1" cellpadding="2" cellspacing="4" 
        frame="box">
        <tr>
            <td colspan="3" 
                
                style="text-align: center; font-family: Castellar; font-weight: 700; font-size: x-large;" 
                class="style14">
                Student Master fORM</td>
        </tr>
        <tr>
            <td class="style8">
                Roll No</td>
            <td class="style9">
                <asp:TextBox ID="TXT_ROLLNO" runat="server" Width="221px"></asp:TextBox>
            </td>
            <td class="style10">
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style8">
                Name</td>
            <td class="style9">
                <asp:TextBox ID="TXT_NAME" runat="server" Width="221px"></asp:TextBox>
            </td>
            <td class="style10">
                </td>
        </tr>
        <tr>
            <td class="style5">
                Father Name</td>
            <td class="style3">
                <asp:TextBox ID="TXT_F_NAME" runat="server" Width="221px"></asp:TextBox>
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style5">
                Gender</td>
            <td class="style3">
                <asp:TextBox ID="TXT_GENDER" runat="server" Width="221px"></asp:TextBox>
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style5">
                Date Of Birth</td>
            <td class="style3">
                <asp:TextBox ID="TXT_DOB" runat="server" Width="221px"></asp:TextBox>
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style6">
                Address1</td>
            <td class="style4">
                <asp:TextBox ID="TXT_ADD1" runat="server" Width="221px"></asp:TextBox>
            </td>
            <td class="style2">
            </td>
        </tr>
        <tr>
            <td class="style5">
                Address2</td>
            <td class="style3">
                <asp:TextBox ID="TXT_ADD2" runat="server" Width="221px"></asp:TextBox>
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style5">
                City</td>
            <td class="style3">
                <asp:TextBox ID="TXT_CITY" runat="server" Width="221px"></asp:TextBox>
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style5">
                State</td>
            <td class="style3">
                <asp:TextBox ID="TXT_STATE" runat="server" Width="221px"></asp:TextBox>
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style5">
                Zipcode</td>
            <td class="style3">
                <asp:TextBox ID="TXT_ZIPCODE" runat="server" Width="221px"></asp:TextBox>
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style6">
                Phone1</td>
            <td class="style4">
                <asp:TextBox ID="TXT_PHONE1" runat="server" Width="221px"></asp:TextBox>
            </td>
            <td class="style2">
            </td>
        </tr>
        <tr>
            <td class="style5">
                Phone2</td>
            <td class="style3">
                <asp:TextBox ID="TXT_PHONE2" runat="server" Width="221px"></asp:TextBox>
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style11" colspan="3">
                <asp:Button ID="BTN_SUBMIT" runat="server" Text="SUBMIT" CssClass="style12" 
                    height="28px" width="90px" onclick="BTN_SUBMIT_Click1" />
                <span class="style13">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                </span>
                <asp:Button ID="BTN_SEARCH" runat="server" Text="SEARCH" CssClass="style12" 
                    height="28px" width="90px" onclick="BTN_SEARCH_Click" />
                <span class="style13">&nbsp;&nbsp;&nbsp;&nbsp;
                </span>
                <asp:Button ID="BTN_UPDATE" runat="server" Text="UPDATE" CssClass="style12" 
                    height="28px" width="90px" onclick="BTN_UPDATE_Click" />
                <span class="style13">&nbsp;&nbsp;&nbsp;
                </span>
                <asp:Button ID="BTN_DELETE" runat="server" Text="DELETE" CssClass="style12" 
                    height="28px" width="90px" onclick="BTN_DELETE_Click" />
            </td>
        </tr>
        <tr>
            <td class="style7" colspan="3">
                <asp:Label ID="LBL_MSG" runat="server" style="text-align: left" 
                    CssClass="style13"></asp:Label>
            </td>
        </tr>
    </table>

</asp:Content>

