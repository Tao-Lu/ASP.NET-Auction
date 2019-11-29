<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="memberFormFAQ.aspx.cs" Inherits="memberFormFAQ" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <p class="text-center">FAQ</p>
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
            <br />
            <asp:GridView ID="gvFaq" runat="server" AutoGenerateColumns="False" Width="844px">
                <Columns>
                    <asp:BoundField DataField="FAQId" HeaderText="FAQ ID" ReadOnly="True" />
                    <asp:BoundField DataField="question" HeaderText="Question" ReadOnly="True" />
                    <asp:BoundField DataField="reply" HeaderText="Reply" ReadOnly="True" />
                    <asp:BoundField DataField="date" HeaderText="Date" ReadOnly="True" DataFormatString="{0:dd/MM/yyyy}" />
                </Columns>
            </asp:GridView>
            <br />
        </div>
    </div>

</asp:Content>

