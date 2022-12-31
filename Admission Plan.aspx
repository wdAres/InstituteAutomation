<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage(admin).master" AutoEventWireup="true" CodeFile="Admission Plan.aspx.cs" Inherits="Admission_Plan" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .style1
        {
            width: 49%;
            height: 589px;
            margin-top: 72px;
        }
        .style2
        {
            width: 38px;
        }
        .style3
        {
            text-align: center;
            color: #003366;
        }
        .style4
        {
            font-family: Castellar;
            font-size: x-large;
            height: 49px;
            color: #003366;
        }
        .style5
        {
            font-family: "Comic Sans MS";
            font-size: large;
            width: 269px;
            color: #003366;
        }
        .style7
        {
            width: 269px;
            font-family: "Comic Sans MS";
            height: 45px;
            font-size: large;
            color: #003366;
        }
        .style8
        {
            width: 38px;
            height: 45px;
        }
        .style9
        {
            height: 45px;
        }
        .style10
        {
            font-weight: bold;
            font-family: "Lucida Sans Typewriter";
            font-size: medium;
            border-style: double;
            border-width: 3px;
            color: #003366;
        }
        .style11
        {
            text-align: left;
        }
        .style12
        {
            color: #003366;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table align="center" class="style1" cellpadding="5" cellspacing="10" dir="ltr" 
        frame="box">
        <tr>
            <td colspan="3" style="text-align: center; font-weight: 700;" class="style4">
                Admission Plan Form</td>
        </tr>
        <tr>
            <td class="style5">
                Session</td>
            <td class="style2">
                <asp:TextBox ID="TXT_SESSION" runat="server" Width="150px" Height="25px"></asp:TextBox>
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style5">
                Standard</td>
            <td class="style2">
                <asp:TextBox ID="TXT_STD" runat="server" Width="150px" Height="25px"></asp:TextBox>
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style7">
                Particulars</td>
            <td class="style8">
                <asp:TextBox ID="TXT_PARTICULARS" runat="server" Width="150px" Height="25px"></asp:TextBox>
            </td>
            <td class="style9">
                </td>
        </tr>
        <tr>
            <td class="style5">
                Charge</td>
            <td class="style2">
                <asp:TextBox ID="TXT_CHARGE" runat="server" Width="150px" Height="25px"></asp:TextBox>
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style3" colspan="3">
                <span class="style12">&nbsp;&nbsp;&nbsp;&nbsp;
                </span>
                <asp:Button ID="BTN_SUBMIT" runat="server" Text="SUBMIT" CssClass="style10" 
                    height="26px" width="90px" onclick="BTN_SUBMIT_Click" />
                <span class="style12">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                </span>
                <asp:Button ID="BTN_SEARCH" runat="server" Text="SEARCH" CssClass="style10" 
                    height="26px" width="90px" onclick="BTN_SEARCH_Click" />
                <span class="style12">&nbsp;&nbsp;&nbsp;&nbsp;
                </span>
                <asp:Button ID="BTN_UPDATE" runat="server" Text="Update" CssClass="style10" 
                    height="26px" width="90px" onclick="BTN_UPDATE_Click" />
                <span class="style12">&nbsp;&nbsp;&nbsp;&nbsp;
                </span>
                <asp:Button ID="BTN_DELETE" runat="server" Text="Delete" CssClass="style10" 
                    height="26px" width="90px" onclick="BTN_DELETE_Click" />
            </td>
        </tr>
        <tr>
            <td class="style11" colspan="3">
                <asp:Label ID="LBL_MSG" runat="server" ForeColor="#CC3300"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="style11" colspan="3">
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style11" colspan="3">
                <br style="text-align: center" />
                <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" 
                    DataKeyNames="Session" DataSourceID="SqlDataSource1" CellPadding="0" 
                    ForeColor="#333333" GridLines="None" Height="164px" style="text-align: center" 
                    Width="369px">
                    <AlternatingRowStyle BackColor="White" />
                    <Columns>
                        <asp:CommandField ShowDeleteButton="True" ShowEditButton="True" />
                        <asp:BoundField DataField="Session" HeaderText="Session" ReadOnly="True" 
                            SortExpression="Session" />
                        <asp:BoundField DataField="Std" HeaderText="Std" SortExpression="Std" />
                        <asp:BoundField DataField="Particulars" HeaderText="Particulars" 
                            SortExpression="Particulars" />
                        <asp:BoundField DataField="Charge" HeaderText="Charge" 
                            SortExpression="Charge" />
                    </Columns>
                    <EditRowStyle BackColor="#2461BF" />
                    <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                    <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                    <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
                    <RowStyle BackColor="#EFF3FB" />
                    <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
                    <SortedAscendingCellStyle BackColor="#F5F7FB" />
                    <SortedAscendingHeaderStyle BackColor="#6D95E1" />
                    <SortedDescendingCellStyle BackColor="#E9EBEF" />
                    <SortedDescendingHeaderStyle BackColor="#4870BE" />
                </asp:GridView>
                <asp:SqlDataSource ID="SqlDataSource1" runat="server" 
                    ConnectionString="<%$ ConnectionStrings:IAS_DBConnectionString %>" 
                    SelectCommand="SELECT * FROM [Admission_plan]" 
                    DeleteCommand="DELETE FROM [Admission_plan] WHERE [Session] = @Session" 
                    InsertCommand="INSERT INTO [Admission_plan] ([Session], [Std], [Particulars], [Charge]) VALUES (@Session, @Std, @Particulars, @Charge)" 
                    UpdateCommand="UPDATE [Admission_plan] SET [Std] = @Std, [Particulars] = @Particulars, [Charge] = @Charge WHERE [Session] = @Session">
                    <DeleteParameters>
                        <asp:Parameter Name="Session" Type="String" />
                    </DeleteParameters>
                    <InsertParameters>
                        <asp:Parameter Name="Session" Type="String" />
                        <asp:Parameter Name="Std" Type="String" />
                        <asp:Parameter Name="Particulars" Type="String" />
                        <asp:Parameter Name="Charge" Type="Int32" />
                    </InsertParameters>
                    <UpdateParameters>
                        <asp:Parameter Name="Std" Type="String" />
                        <asp:Parameter Name="Particulars" Type="String" />
                        <asp:Parameter Name="Charge" Type="Int32" />
                        <asp:Parameter Name="Session" Type="String" />
                    </UpdateParameters>
                </asp:SqlDataSource>
            </td>
        </tr>
    </table>
</asp:Content>

