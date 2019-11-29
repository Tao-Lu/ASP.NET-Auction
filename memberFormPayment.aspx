<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="memberFormPayment.aspx.cs" Inherits="memberFormPayment" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <p class="text-center">Payment</p>
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
            <asp:GridView ID="gvPayment" runat="server" AutoGenerateColumns="False" OnRowCommand="invoiceSelected">
                <Columns>
                    <asp:BoundField DataField="invoiceId" HeaderText="Invoice Id" ReadOnly="True" />
                    <asp:BoundField DataField="invoiceDate" HeaderText="Invoice Date" ReadOnly="True" DataFormatString="{0:d}" />
                    <asp:BoundField DataField="subtotalPrice" DataFormatString="{0:C}" HeaderText="subtotal Price" ReadOnly="True" />
                    <asp:BoundField DataField="shipment" HeaderText="Shipment" ReadOnly="True" />
                    <asp:BoundField DataField="totalPrice" HeaderText="Total Price" ReadOnly="True" DataFormatString="{0:C}" />
                    <asp:BoundField DataField="creditCardType" HeaderText="Credit Card Type" ReadOnly="True" />
                    <asp:BoundField DataField="creditCardNumber" HeaderText="Credit Card Number" ReadOnly="True" />
                    <asp:BoundField DataField="cvv2Number" HeaderText="CVV2 Number" ReadOnly="True" />
                    <asp:BoundField DataField="expiryDate" DataFormatString="{0:d}" HeaderText="Expiry Date" ReadOnly="True" />
                    <asp:ButtonField CommandName="getInvoiceId" Text="Invoice Details" />
                </Columns>
            </asp:GridView>
        </div>
        <div class="form-group text-center">
            <asp:GridView ID="gvPaymentDetails" runat="server" AutoGenerateColumns="False">
                <Columns>
                    <asp:BoundField DataField="itemId" HeaderText="Item Id" ReadOnly="True" />
                    <asp:BoundField DataField="description" HeaderText="Description" ReadOnly="True" />
                    <asp:ImageField DataImageUrlField="imageFileName" HeaderText="Item image" ReadOnly="True">
                    </asp:ImageField>
                    <asp:BoundField DataField="conditionOfTheItem" HeaderText="Condition of the Item" ReadOnly="True" />
                    <asp:BoundField DataField="price" DataFormatString="{0:C}" HeaderText="Price" ReadOnly="True" />
                </Columns>
            </asp:GridView>
        </div>
    </div>

</asp:Content>

