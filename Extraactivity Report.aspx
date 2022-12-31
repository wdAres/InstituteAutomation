<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage(admin).master" AutoEventWireup="true" CodeFile="Extraactivity Report.aspx.cs" Inherits="Extraactivity_Report" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .style1
        {
            width: 47%;
            height: 236px;
        }
        .style2
        {
            text-align: center;
            font-size: x-large;
            font-weight: 700;
            font-family: Castellar;
            color: #003366;
        }
        .style3
        {
            font-size: large;
            font-weight: bold;
            font-family: "Comic Sans MS";
            color: #003366;
            width: 240px;
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
            <td class="style2" colspan="3">
                Extra Activity Report Form</td>
        </tr>
        <tr>
            <td class="style3">
                Session</td>
            <td>
                <asp:TextBox ID="TXT_SESSION" runat="server" Width="160px" Height="25px"></asp:TextBox>
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style3">
                Registration No</td>
            <td>
                <asp:TextBox ID="TXT_REG_NO" runat="server" Width="160px" Height="25px"></asp:TextBox>
            </td>
            <td class="style6">
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style3">
                Remarks</td>
            <td>
                <asp:TextBox ID="TXT_REMARKS" runat="server" Width="160px" Height="25px"></asp:TextBox>
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style3">
                Date</td>
            <td>
                <asp:TextBox ID="TXT_DATE" runat="server" Width="160px" Height="25px"></asp:TextBox>
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style3">
                Staff ID</td>
            <td>
                <asp:TextBox ID="TXT_STAFF_ID" runat="server" Width="160px" Height="25px"></asp:TextBox>
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td colspan="3" style="text-align: center">
                <span class="style6">&nbsp;</span><asp:Button ID="BTN_SUBMIT" runat="server" Text="SUBMIT" 
                    CssClass="style4" height="28px" width="90px" onclick="BTN_SUBMIT_Click" />
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
                <asp:Label ID="LBL_MSG" runat="server" ForeColor="#CC3300"></asp:Label>
            </td>
        </tr>
    </table>
</asp:Content>

