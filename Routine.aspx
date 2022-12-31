<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage(Student).master" AutoEventWireup="true" CodeFile="Routine.aspx.cs" Inherits="Routine" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .style1
        {
            width: 47%;
            height: 352px;
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
            width: 208px;
            font-size: large;
            font-family: "Comic Sans MS";
            font-weight: 700;
            color: #003366;
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
                Routine Form</td>
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
                Standard</td>
            <td>
                <asp:TextBox ID="TXT_STD" runat="server" Width="160px" Height="25px"></asp:TextBox>
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style3">
                Section</td>
            <td>
                <asp:TextBox ID="TXT_SEC" runat="server" Width="160px" Height="25px"></asp:TextBox>
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style3">
                Day</td>
            <td>
                <asp:TextBox ID="TXT_DAY" runat="server" Width="160px" Height="25px"></asp:TextBox>
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style3">
                Period</td>
            <td>
                <asp:TextBox ID="TXT_PERIOD" runat="server" Width="160px" Height="25px"></asp:TextBox>
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
                <asp:Label ID="LBL_MSG" runat="server" ForeColor="#CC3300" 
                    style="font-weight: 700; font-size: large"></asp:Label>
            </td>
        </tr>
    </table>
</asp:Content>

