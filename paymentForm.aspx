<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="paymentForm.aspx.cs" Inherits="paymentForm" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
    <style type="text/css">
        .auto-style2 {
            height: 20px;
        }
        .auto-style4 {
            height: 22px;
        }
        .auto-style7 {
            height: 20px;
            width: 396px;
        }
        .auto-style8 {
            height: 22px;
            width: 396px;
        }
        .auto-style9 {
            width: 396px
        }
        .auto-style10 {
            width: 200px
        }
        .auto-style11 {
            height: 20px;
            width: 200px;
        }
        .auto-style12 {
            height: 22px;
            width: 200px;
        }
    </style>
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div class="form-group text-center">
                <a href="memberFormMember.aspx">Member Profile</a>
                || <a href="memberFormFAQ.aspx">FAQ</a>
                || <a href="memberFormBidding.aspx">Bidding</a>
                || <a href="memberFormPayment.aspx">Payment</a>
                || <a href ="memberUnpay.aspx">UnPay</a>
            </div>
    <div class="form-group">
        <asp:GridView ID="gvInvoice" runat="server" AutoGenerateColumns="False" Width="1183px">
            <Columns>
                <asp:BoundField DataField="itemId" HeaderText="Item Id" ReadOnly="True" />
                <asp:BoundField DataField="description" HeaderText="Description" ReadOnly="True" />
                <asp:ImageField DataImageUrlField="imageFileName" HeaderText="Item image" ReadOnly="True">
                </asp:ImageField>
                <asp:BoundField DataField="conditionOfTheItem" HeaderText="Condition of the item" ReadOnly="True" />
                <asp:BoundField DataField="price" HeaderText="Price" ReadOnly="True" DataFormatString="{0:C}" />
                <asp:BoundField DataField="dueDateToPay" HeaderText="Due date to pay" ReadOnly="True" />
            </Columns>
        </asp:GridView>
    </div>

    <div class="form-group">

        <table class="nav-justified">
            <tr>
                <td class="auto-style9">&nbsp;</td>
                <td class="auto-style10">Invoice ID</td>
                <td>
                    <asp:Label ID="lblInvoiceId" runat="server"></asp:Label>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style9">&nbsp;</td>
                <td class="auto-style10">&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style7"></td>
                <td class="auto-style11">Invoice Date</td>
                <td class="auto-style2">
                    <asp:Label ID="lblInvoiceDate" runat="server"></asp:Label>
                </td>
                <td class="auto-style2"></td>
            </tr>
            <tr>
                <td class="auto-style9">&nbsp;</td>
                <td class="auto-style10">&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style9">&nbsp;</td>
                <td class="auto-style10">Subtotal Price</td>
                <td>
                    <asp:Label ID="lblSubtotalPrice" runat="server"></asp:Label>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style9">&nbsp;</td>
                <td class="auto-style10">&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style9">&nbsp;</td>
                <td class="auto-style10">Shipment</td>
                <td>
                    <asp:RadioButtonList ID="radioBtnListShipment" runat="server" AutoPostBack="True" OnSelectedIndexChanged="radioBtnListShipment_SelectedIndexChanged">
                        <asp:ListItem Selected="True">delivery</asp:ListItem>
                        <asp:ListItem>no delivery</asp:ListItem>
                    </asp:RadioButtonList>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style9">&nbsp;</td>
                <td class="auto-style10">&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style9">&nbsp;</td>
                <td class="auto-style10">Total Price</td>
                <td>
                    <asp:Label ID="lblTotalPrice" runat="server"></asp:Label>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style9">&nbsp;</td>
                <td class="auto-style10">&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style9">&nbsp;</td>
                <td class="auto-style10">Credit Card Type</td>
                <td>
                    <asp:RadioButtonList ID="radioBtnListCreditCardType" runat="server" AutoPostBack="True">
                        <asp:ListItem Selected="True">visa</asp:ListItem>
                        <asp:ListItem>master</asp:ListItem>
                    </asp:RadioButtonList>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style9">&nbsp;</td>
                <td class="auto-style10">&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style9">&nbsp;</td>
                <td class="auto-style10">Credit Card Number</td>
                <td>
                    <asp:TextBox ID="tbxCreditCardNumber" runat="server" TextMode="Number" MaxLength="10"></asp:TextBox>
                    <asp:RegularExpressionValidator ID="RegularExpressionValidator_creditCardNumber" runat="server" ControlToValidate="tbxCreditCardNumber" Display="Dynamic" ErrorMessage="only can key in 10 digits" ForeColor="Red" ValidationExpression="^\d{10}"></asp:RegularExpressionValidator>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator_CreditCardNumber" runat="server" ControlToValidate="tbxCreditCardNumber" Display="Dynamic" ErrorMessage="please key in credit card number" ForeColor="Red"></asp:RequiredFieldValidator>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style9">&nbsp;</td>
                <td class="auto-style10">&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style9">&nbsp;</td>
                <td class="auto-style10">CVV2 Number</td>
                <td>
                    <asp:TextBox ID="tbxCVV2Number" runat="server" TextMode="Number" MaxLength="3"></asp:TextBox>
                    <asp:RegularExpressionValidator ID="RegularExpressionValidator_cvv2Number" runat="server" ControlToValidate="tbxCVV2Number" Display="Dynamic" ErrorMessage="only key in 3 digits" ForeColor="Red" ValidationExpression="^\d{3}"></asp:RegularExpressionValidator>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator_CVV2Number" runat="server" ControlToValidate="tbxCVV2Number" ErrorMessage="please key in CVV2 number" ForeColor="Red"></asp:RequiredFieldValidator>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style9">&nbsp;</td>
                <td class="auto-style10">&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style8"></td>
                <td class="auto-style12">Expiry Date</td>
                <td class="auto-style4">
                    <asp:TextBox ID="tbxExpiryDate" runat="server" TextMode="Date"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator_expiryDate" runat="server" ControlToValidate="tbxExpiryDate" Display="Dynamic" ErrorMessage="please key in expiry date" ForeColor="Red"></asp:RequiredFieldValidator>
                    <asp:Label ID="lblCardExpire" runat="server" ForeColor="Red" Visible="False"></asp:Label>
                </td>
                <td class="auto-style4"></td>
            </tr>
            <tr>
                <td class="auto-style9">&nbsp;</td>
                <td class="auto-style10">&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style9">&nbsp;</td>
                <td colspan="2">
                    <asp:Button ID="btnPay" runat="server" Text="Pay" OnClick="btnPay_Click" />
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style9">&nbsp;</td>
                <td colspan="2">
                    <asp:Label ID="lblOutput" runat="server" ForeColor="Red"></asp:Label>
                </td>
                <td>&nbsp;</td>
            </tr>
        </table>

    </div>
</asp:Content>

