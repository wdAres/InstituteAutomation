<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage(admin).master" AutoEventWireup="true" CodeFile="Staff Commission.aspx.cs" Inherits="Staff_Commission" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .style1
        {
            width: 49%;
            height: 361px;
        }
        .style2
        {
            font-size: large;
            font-family: "Comic Sans MS";
            color: #003366;
            width: 239px;
        }
        .style4
        {
            font-weight: bold;
            font-family: "Lucida Sans Typewriter";
            font-size: medium;
            color: #003366;
        }
        .style5
        {
            text-align: left;
        }
        .style6
        {
            color: #003366;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table align="center" class="style1" cellpadding="5" cellspacing="10" 
        frame="box">
        <tr>
            <td colspan="3" 
                
                style="text-align: center; font-size: x-large; font-weight: 700; font-family: Castellar;" 
                class="style6">
                Staff Commission Form</td>
        </tr>
        <tr>
            <td class="style2">
                Commision ID</td>
            <td>
                <asp:TextBox ID="TXT_COM_ID" runat="server" Width="160px" Height="25px"></asp:TextBox>
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style2">
                Name</td>
            <td>
                <asp:TextBox ID="TXT_NAME" runat="server" Width="160px" Height="25px"></asp:TextBox>
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style2">
                Staff ID</td>
            <td>
                <asp:TextBox ID="TXT_STAFF_ID" runat="server" Width="160px" Height="25px"></asp:TextBox>
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style2">
                Student ID</td>
            <td>
                <asp:TextBox ID="TXT_STUD_ID" runat="server" Width="160px" Height="25px"></asp:TextBox>
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style2">
                Date</td>
            <td>
                <asp:TextBox ID="TXT_DATE" runat="server" Width="160px" Height="25px"></asp:TextBox>
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style2">
                Amount ID</td>
            <td>
                <asp:TextBox ID="TXT_AMOUNT_ID" runat="server" Width="160px" Height="25px"></asp:TextBox>
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td colspan="3" style="text-align: center">
                <span class="style6">&nbsp;&nbsp;</span><asp:Button ID="BTN_SUBMIT" runat="server" Text="SUBMIT" CssClass="style4" 
                    height="28px" width="90px" onclick="BTN_SUBMIT_Click" />
                <span class="style6">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                </span>
                <asp:Button ID="BTN_SEARCH" runat="server" Text="SEARCH" CssClass="style4" 
                    height="28px" width="90px" onclick="BTN_SEARCH_Click" />
                <span class="style6">&nbsp;&nbsp;&nbsp;&nbsp;
                </span>
                <asp:Button ID="BTN_UPDATE" runat="server" Text="UPDATE" CssClass="style4" 
                    onclick="BTN_UPDATE_Click" />
                <span class="style6">&nbsp;&nbsp;&nbsp;
                </span>
                <asp:Button ID="BTN_DELETE" runat="server" Text="DELETE" CssClass="style4" 
                    height="28px" width="90px" onclick="BTN_DELETE_Click" />
            </td>
        </tr>
        <tr>
            <td colspan="3" class="style5">
                <asp:Label ID="LBL_MSG" runat="server" style="color: #CC3300"></asp:Label>
            </td>
        </tr>
    </table>
</asp:Content>

