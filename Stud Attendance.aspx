<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage(Student).master" AutoEventWireup="true" CodeFile="Stud Attendance.aspx.cs" Inherits="Stud_Attendance" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .style1
        {
            width: 46%;
            height: 244px;
        margin-top: 0px;
    }
        .style2
        {
            width: 262px;
        }
        .style3
        {
            font-family: "Comic Sans MS";
            font-size: large;
            color: #003366;
            width: 246px;
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
            color: #CC3300;
        font-weight: 700;
        font-size: large;
    }
        .style7
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
                
                style="text-align: center; font-weight: 700; font-family: Castellar; font-size: x-large;" 
                class="style7">
                Student Attendance Form</td>
        </tr>
        <tr>
            <td class="style3">
                Session</td>
            <td class="style2">
                <asp:TextBox ID="TXT_SESSION" runat="server" Width="160px" Height="25px"></asp:TextBox>
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style3">
                Registration No</td>
            <td class="style2">
                <asp:TextBox ID="TXT_REG_NO" runat="server" Width="160px" Height="25px"></asp:TextBox>
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style3">
                Standard</td>
            <td class="style2">
                <asp:TextBox ID="TXT_STD" runat="server" Width="160px" Height="25px"></asp:TextBox>
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style3">
                Section</td>
            <td class="style2">
                <asp:TextBox ID="TXT_SEC" runat="server" Width="160px" Height="25px"></asp:TextBox>
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style3">
                Roll No</td>
            <td class="style2">
                <asp:TextBox ID="TXT_ROLL_NO" runat="server" Width="160px" Height="25px"></asp:TextBox>
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style3">
                Date</td>
            <td class="style2">
                <asp:TextBox ID="TXT_DATE" runat="server" Width="160px" Height="25px"></asp:TextBox>
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td colspan="3" style="text-align: center">
                <asp:Button ID="BTN_SUBMIT" runat="server" Text="SUBMIT" CssClass="style4" 
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
                <asp:Label ID="LBL_MSG" runat="server" CssClass="style6"></asp:Label>
            </td>
        </tr>
    </table>
</asp:Content>

