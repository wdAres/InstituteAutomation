<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage(admin).master" AutoEventWireup="true" CodeFile="Fee.aspx.cs" Inherits="Fee" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .style1
        {
            width: 46%;
            height: 259px;
        }
        .style2
        {
            font-size: large;
            font-weight: bold;
            font-family: "Comic Sans MS";
            color: #003366;
            width: 239px;
        }
        .style3
        {
            font-family: "Lucida Sans Typewriter";
            font-size: medium;
            font-weight: bold;
            color: #003366;
        }
        .style4
        {
            text-align: left;
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
                
                
                style="text-align: center; font-size: x-large; font-weight: 700; font-family: Castellar;" 
                class="style5">
                Fee Form</td>
        </tr>
        <tr>
            <td class="style2">
                Receipt No</td>
            <td>
                <asp:TextBox ID="TXT_RECEIPT_NO" runat="server" Width="160px" Height="25px" 
                    style="text-align: left"></asp:TextBox>
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style2">
                Session</td>
            <td>
                <asp:TextBox ID="TXT_SESSION" runat="server" Width="160px" Height="25px" 
                    style="text-align: left"></asp:TextBox>
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style2">
                Registration No</td>
            <td>
                <asp:TextBox ID="TXT_REG_NO" runat="server" Width="160px" Height="25px"></asp:TextBox>
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style2">
                Discount</td>
            <td>
                <asp:TextBox ID="TXT_DISCOUNT" runat="server" Width="160px" Height="25px"></asp:TextBox>
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style2">
                Total Fee</td>
            <td>
                <asp:TextBox ID="TXT_TOTAL_FEE" runat="server" Width="160px" Height="25px"></asp:TextBox>
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
                Month</td>
            <td>
                <asp:TextBox ID="TXT_MONTH" runat="server" Width="160px" Height="25px"></asp:TextBox>
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td colspan="3" style="text-align: center">
                <span class="style5">&nbsp;&nbsp;&nbsp;&nbsp;
                </span>
                <asp:Button ID="BTN_SUBMIT" runat="server" Text="SUBMIT" CssClass="style3" 
                    height="28px" width="90px" onclick="BTN_SUBMIT_Click" />
                <span class="style5">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                </span>
                <asp:Button ID="BTN_SEARCH" runat="server" Text="SEARCH" CssClass="style3" 
                    height="28px" width="90px" onclick="BTN_SEARCH_Click" />
                <span class="style5">&nbsp;&nbsp;&nbsp;&nbsp;
                </span>
                <asp:Button ID="BTN_UPDATE" runat="server" Text="UPDATE" CssClass="style3" 
                    height="28px" width="90px" onclick="BTN_UPDATE_Click" />
                <span class="style5">&nbsp;&nbsp;&nbsp;&nbsp;
                </span>
                <asp:Button ID="BTN_DELETE" runat="server" Text="DELETE" CssClass="style3" 
                    onclick="BTN_DELETE_Click" />
            </td>
        </tr>
        <tr>
            <td colspan="3" class="style4">
                <asp:Label ID="LBL_MSG" runat="server" ForeColor="#CC3300" 
                    style="color: #CC3300"></asp:Label>
            </td>
        </tr>
    </table>
</asp:Content>

