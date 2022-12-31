<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage(admin).master" AutoEventWireup="true" CodeFile="Expense.aspx.cs" Inherits="Expense" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .style1
        {
            width: 46%;
            height: 277px;
            margin-top: 101px;
        }
        .style2
        {
            height: 31px;
        }
        .newStyle1
        {
            font-family: Castellar;
            font-size: x-large;
        }
        .newStyle2
        {
            font-family: "comic Sans MS";
            font-size: large;
        }
        .style4
        {
            font-size: large;
            font-weight: bold;
            font-family: "Comic Sans MS";
            color: #003366;
        }
        .style5
        {
            font-weight: bold;
            font-family: "Lucida Sans Typewriter";
            font-size: medium;
            border-style: double;
            border-width: 3px;
            color: #003366;
        }
        .style6
        {
            height: 31px;
            text-align: left;
        }
        .style7
        {
            color: #003366;
        }
        .style8
        {
            font-family: Castellar;
            font-size: x-large;
            color: #003366;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table align="center" class="style1" cellpadding="5" cellspacing="10" 
        frame="box">
        <tr>
            <td colspan="3" style="text-align: center" class="style8">
                <strong>Expense Form</strong></td>
        </tr>
        <tr>
            <td class="style4">
                Staff ID</td>
            <td>
                <asp:TextBox ID="TXT_STAFF_ID" runat="server" Width="150px" Height="25px"></asp:TextBox>
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style4">
                Date</td>
            <td>
                <asp:TextBox ID="TXT_DATE" runat="server" Width="150px" Height="25px"></asp:TextBox>
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style4">
                Particulars</td>
            <td>
                <asp:TextBox ID="TXT_PARTICULARS" runat="server" Width="150px" Height="25px"></asp:TextBox>
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style4">
                Amount</td>
            <td>
                <asp:TextBox ID="TXT_AMOUNT" runat="server" Width="150px" Height="25px"></asp:TextBox>
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style2" colspan="3" style="text-align: center">
                <span class="style7">&nbsp;&nbsp;&nbsp;&nbsp;
                </span>
                <asp:Button ID="BTN_SUBMIT" runat="server" Text="SUBMIT" CssClass="style5" 
                    height="30px" width="92px" onclick="BTN_SUBMIT_Click" />
                <span class="style7">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                </span>
                <asp:Button ID="BTN_SEARCH" runat="server" Text="SEARCH" CssClass="style5" 
                    height="30px" width="92px" onclick="BTN_SEARCH_Click" />
                <span class="style7">&nbsp;&nbsp;&nbsp;&nbsp;
                </span>
                <asp:Button ID="BTN_UPDATE" runat="server" Text="UPDATE" CssClass="style5" 
                    height="30px" width="92px" onclick="BTN_UPDATE_Click" />
                <span class="style7">&nbsp;&nbsp;&nbsp;&nbsp;
                </span>
                <asp:Button ID="BTN_DELETE" runat="server" Text="DELETE" CssClass="style5" 
                    onclick="BTN_DELETE_Click" />
            </td>
        </tr>
        <tr>
            <td class="style6" colspan="3">
                <asp:Label ID="LBL_MSG" runat="server" ForeColor="#CC3300"></asp:Label>
            </td>
        </tr>
    </table>
</asp:Content>

