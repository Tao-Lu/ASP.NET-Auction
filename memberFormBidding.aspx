<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="memberFormBidding.aspx.cs" Inherits="memberFormBidding" %>

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
        <div class="form-group text-center">
            <asp:GridView ID="gvMemberBidding" runat="server" AutoGenerateColumns="False" Width="826px">
                <Columns>
                    <asp:BoundField DataField="description" HeaderText="Description" ReadOnly="True" />
                    <asp:ImageField DataImageUrlField="imageFileName" HeaderText="Image" ReadOnly="True">
                    </asp:ImageField>
                    <asp:BoundField DataField="bidPrice" DataFormatString="{0:C}" HeaderText="Bid Price" ReadOnly="True" />
                    <asp:BoundField DataField="bidDate" HeaderText="Bid Date" ReadOnly="True" DataFormatString="{0:dd/MM/yyyy}" />
                </Columns>
            </asp:GridView>
        </div>
    </div>

</asp:Content>

