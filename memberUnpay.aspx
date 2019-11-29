<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="memberUnpay.aspx.cs" Inherits="memberUnpay" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <p class="text-center">Bidding</p>
    <div class="container-fluid">
        <div class="row">
            <div class="form-group text-center">
                <a href="memberFormMember.aspx">Member Profile</a>
                || <a href="memberFormFAQ.aspx">FAQ</a>
                || <a href="memberFormBidding.aspx">Bidding</a>
                || <a href="memberFormPayment.aspx">Payment</a>
                || <a href ="memberUnpay.aspx">UnPay</a>
            </div>
        </div>
        <div class="form-group">
            <asp:DataList ID="dtlItemWithHighPrice" runat="server" CellPadding="4" Height="245px" RepeatColumns="5" RepeatDirection="Horizontal" Width="620px">
                <ItemTemplate>
                    <asp:Label ID="lblItemId" runat="server" Text='<%# ""+Eval("itemId") %>'></asp:Label>
                    <br />
                    <asp:Label ID="lblDescription" runat="server" Text='<%# Eval("description") %>'></asp:Label>
                    <br />
                    <asp:Image ID="imageFileName" runat="server" Height="100px" ImageUrl='<%# "~/Images/items/"+Eval("imageFileName") %>' Width="100px" />
                    <br />
                    <asp:Label ID="lblConditionOfTheItem" runat="server" Text='<%# Eval("conditionOfTheItem") %>'></asp:Label>
                    <br />
                    <asp:Label ID="lblPrice" runat="server" Text='<%# Eval("price") %>'></asp:Label>
                    <br />
                    <asp:Label ID="lblDueDateToPay" runat="server" Text='<%# Eval("dueDateToPay") %>'></asp:Label>
                    <br />
                    <asp:CheckBox ID="chxPay" runat="server" Text="Pay?" />
                </ItemTemplate>
            </asp:DataList>
        </div>
        <div class="form-group">


            <asp:Button ID="btnMakeAPayment" runat="server" OnClick="btnMakeAPayment_Click" Text="make a payment" />


            <br />
            <asp:Label ID="lblOutput" runat="server" ForeColor="Red" Visible="False"></asp:Label>


        </div>
    </div>

</asp:Content>

