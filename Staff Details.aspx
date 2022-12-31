<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage(admin).master" AutoEventWireup="true" CodeFile="Staff Details.aspx.cs" Inherits="Staff_Details" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .style1
        {
            width: 57%;
            height: 537px;
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
            font-family: "Comic Sans MS";
            font-size: medium;
            color: #003366;
            width: 317px;
        }
        .style6
        {
            color: #CC3300;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table align="center" class="style1" 
        frame="box">
        <tr>
            <td colspan="3" 
                
                style="text-align: center; font-family: Castellar; font-weight: 700; font-size: large;" 
                class="style6">
                Staff Details Form</td>
        </tr>
        <tr>
            <td class="style5">
                Staff ID</td>
            <td>
                <asp:TextBox ID="TXT_STAFF_ID" runat="server" Width="170px"></asp:TextBox>
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style5">
                First Name</td>
            <td>
                <asp:TextBox ID="TXT_F_NAME" runat="server" Width="170px"></asp:TextBox>
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style5">
                Qualification</td>
            <td>
                <asp:TextBox ID="TXT_QUALIFICATION" runat="server" Width="170px"></asp:TextBox>
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style5">
                Address1</td>
            <td>
                <asp:TextBox ID="TXT_ADD1" runat="server" Width="170px"></asp:TextBox>
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style5">
                Address2</td>
            <td>
                <asp:TextBox ID="TXT_ADD2" runat="server" Width="170px"></asp:TextBox>
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style5">
                City</td>
            <td>
                <asp:TextBox ID="TXT_CITY" runat="server" Width="170px"></asp:TextBox>
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style5">
                State</td>
            <td>
                <asp:TextBox ID="TXT_STATE" runat="server" Width="170px"></asp:TextBox>
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style5">
                Zipcode</td>
            <td>
                <asp:TextBox ID="TXT_ZIPCODE" runat="server" Width="170px"></asp:TextBox>
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style5">
                Phone1</td>
            <td>
                <asp:TextBox ID="TXT_PHONE1" runat="server" Width="170px"></asp:TextBox>
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style5">
                Phone2</td>
            <td>
                <asp:TextBox ID="TXT_PHONE2" runat="server" Width="170px"></asp:TextBox>
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style5">
                Mobile</td>
            <td>
                <asp:TextBox ID="TXT_MOBILE" runat="server" Width="170px"></asp:TextBox>
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style5">
                Email</td>
            <td>
                <asp:TextBox ID="TXT_EMAIL" runat="server" Width="170px"></asp:TextBox>
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style5">
                Date of Joining</td>
            <td>
                <asp:TextBox ID="TXT_D_O_JOIN" runat="server" Width="170px"></asp:TextBox>
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style5">
                Designation</td>
            <td>
                <asp:TextBox ID="TXT_DESIGNATION" runat="server" Width="170px"></asp:TextBox>
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style5">
                Basic salary</td>
            <td>
                <asp:TextBox ID="TXT_B_SALARY" runat="server" Width="170px"></asp:TextBox>
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style5">
                Hra</td>
            <td>
                <asp:TextBox ID="TXT_HRA" runat="server" Width="170px"></asp:TextBox>
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style5">
                Ta</td>
            <td>
                <asp:TextBox ID="TXT_TA" runat="server" Width="170px"></asp:TextBox>
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style5">
                Da</td>
            <td>
                <asp:TextBox ID="TXT_DA" runat="server" Width="170px"></asp:TextBox>
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style5">
                Pf</td>
            <td>
                <asp:TextBox ID="TXT_PF" runat="server" Width="170px"></asp:TextBox>
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
                <span class="style6">&nbsp;</span></td>
        </tr>
        <tr>
            <td colspan="3" style="text-align: left">
                <asp:Label ID="LBL_MSG" runat="server" CssClass="style6"></asp:Label>
            </td>
        </tr>
    </table>
</asp:Content>

