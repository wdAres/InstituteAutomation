<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage(admin).master" AutoEventWireup="true" CodeFile="Teacher Subject.aspx.cs" Inherits="Teacher_Subject" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .style1
        {
            width: 47%;
            height: 217px;
        }
        .style2
        {
            font-family: "Comic Sans MS";
            font-size: medium;
            color: #003366;
            width: 210px;
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
            color: #003366;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table align="center" class="style1" cellpadding="5" cellspacing="10" 
        frame="box">
        <tr>
            <td colspan="3" 
                
                style="text-align: center; font-weight: 700; font-size: x-large; font-family: Castellar;" 
                class="style5">
                Teacher Subject Form</td>
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
                Subject</td>
            <td>
                <asp:TextBox ID="TXT_SUBJECT" runat="server" Width="160px" Height="25px"></asp:TextBox>
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td colspan="3" style="text-align: center">
                <asp:Button ID="BTN_SUBMIT" runat="server" Text="SUBMIT" CssClass="style4" 
                    height="28px" width="90px" onclick="BTN_SUBMIT_Click" />
                <span class="style5">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                </span>
                <asp:Button ID="BTN_SEARCH" runat="server" Text="SEARCH" CssClass="style4" 
                    height="28px" width="90px" onclick="BTN_SEARCH_Click" />
                <span class="style5">&nbsp;&nbsp;&nbsp;&nbsp;
                </span>
                <asp:Button ID="BTN_UPDATE" runat="server" Text="UPDATE" CssClass="style4" 
                    onclick="BTN_UPDATE_Click" />
                <span class="style5">&nbsp;&nbsp;&nbsp;
                </span>
                <asp:Button ID="BTN_DELETE" runat="server" Text="DELETE" CssClass="style4" 
                    height="28px" width="90px" onclick="BTN_DELETE_Click" />
            </td>
        </tr>
        <tr>
            <td colspan="3" style="text-align: left">
                <asp:Label ID="LBL_MSG" runat="server" style="color: #CC3300"></asp:Label>
            </td>
        </tr>
    </table>
</asp:Content>

