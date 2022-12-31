<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage(admin).master" AutoEventWireup="true" CodeFile="Staff Salary.aspx.cs" Inherits="Staff_Salary" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .style1
        {
            width: 49%;
            height: 461px;
        }
        .style2
        {
            text-align: center;
            font-weight: 700;
        }
        .style3
        {
            font-family: "Comic Sans MS";
            font-size: large;
            color: #003366;
            width: 215px;
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
            text-align: center;
            font-weight: 700;
            font-family: Castellar;
            font-size: x-large;
            color: #003366;
        }
        .style6
        {
            text-align: left;
            font-weight: 700;
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
            <td class="style5" colspan="3">
                Staff Salary Form</td>
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
            <td class="style3">
                Basic Salary</td>
            <td>
                <asp:TextBox ID="TXT_B_SALARY" runat="server" style="text-align: left" 
                    Width="160px" Height="25px"></asp:TextBox>
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style3">
                Hra</td>
            <td>
                <asp:TextBox ID="TXT_HRA" runat="server" Width="160px" Height="25px"></asp:TextBox>
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style3">
                Ta</td>
            <td>
                <asp:TextBox ID="TXT_TA" runat="server" Width="160px" Height="25px"></asp:TextBox>
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style3">
                Da</td>
            <td>
                <asp:TextBox ID="TXT_DA" runat="server" Width="160px" Height="25px"></asp:TextBox>
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style3">
                Other</td>
            <td>
                <asp:TextBox ID="TXT_OTHER" runat="server" Width="160px" Height="25px"></asp:TextBox>
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style3">
                Pf</td>
            <td>
                <asp:TextBox ID="TXT_PF" runat="server" Width="160px" Height="25px"></asp:TextBox>
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
                Voucher No</td>
            <td>
                <asp:TextBox ID="TXT_VOUCHER_NO" runat="server" Width="160px" Height="25px"></asp:TextBox>
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style2" colspan="3">
                <asp:Button ID="BTN_SUBMIT" runat="server" Text="SUBMIT" CssClass="style4" 
                    height="28px" width="90px" onclick="BTN_SUBMIT_Click" />
                <span class="style7">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                </span>
                <asp:Button ID="BTN_SEARCH" runat="server" Text="SEARCH" CssClass="style4" 
                    height="28px" width="90px" onclick="BTN_SEARCH_Click" />
                <span class="style7">&nbsp;&nbsp;&nbsp;&nbsp;
                </span>
                <asp:Button ID="BTN_UPDATE" runat="server" Text="UPDATE" CssClass="style4" 
                    onclick="BTN_UPDATE_Click" />
                <span class="style7">&nbsp;&nbsp;&nbsp;
                </span>
                <asp:Button ID="BTN_DELETE" runat="server" Text="DELETE" CssClass="style4" 
                    height="28px" width="90px" onclick="BTN_DELETE_Click" />
            </td>
        </tr>
        <tr>
            <td class="style6" colspan="3">
                <asp:Label ID="LBL_MSG" runat="server" style="color: #CC3300"></asp:Label>
            </td>
        </tr>
    </table>
</asp:Content>

