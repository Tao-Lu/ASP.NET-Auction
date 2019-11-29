<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="memberFormMember.aspx.cs" Inherits="memberForm" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
    <style type="text/css">
        
        .auto-style2 {
            width: 150px;
        }
        .auto-style3 {
            width: 403px
        }
        .auto-style4 {
            width: 357px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <p class="text-center">Member Profile</p>
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
            <table class="nav-justified">
                <tr>
                    <td class="auto-style3">&nbsp;</td>
                    <td class="auto-style2">Name</td>
                    <td class="auto-style4">
                        <asp:TextBox ID="tbxName" runat="server" ReadOnly="True"></asp:TextBox>
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style3">&nbsp;</td>
                    <td class="auto-style2">gender</td>
                    <td class="auto-style4">
                        <asp:TextBox ID="tbxGender" runat="server" ReadOnly="True"></asp:TextBox>
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style3">&nbsp;</td>
                    <td class="auto-style2">date of birth</td>
                    <td class="auto-style4">
                        <asp:TextBox ID="tbxDOB" runat="server" ReadOnly="True"></asp:TextBox>
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style3">&nbsp;</td>
                    <td class="auto-style2">address</td>
                    <td class="auto-style4">
                        <asp:TextBox ID="tbxAddress" runat="server" ReadOnly="True"></asp:TextBox>
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style3">&nbsp;</td>
                    <td class="auto-style2">email</td>
                    <td class="auto-style4">
                        <asp:TextBox ID="tbxEmail" runat="server" ReadOnly="True"></asp:TextBox>
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style3">&nbsp;</td>
                    <td class="auto-style2">password</td>
                    <td class="auto-style4">
                        <asp:TextBox ID="tbxPassword" runat="server" ReadOnly="True"></asp:TextBox>
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style3">&nbsp;</td>
                    <td class="auto-style2">phone</td>
                    <td class="auto-style4">
                        <asp:TextBox ID="tbxPhone" runat="server" TextMode="Number" ReadOnly="True"></asp:TextBox>
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style3">&nbsp;</td>
                    <td class="auto-style2">&nbsp;</td>
                    <td class="auto-style4">&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style3">&nbsp;</td>
                    <td class="auto-style2">
                        <asp:Button ID="btnEdit" runat="server" OnClick="btnEdit_Click" Text="Edit" CausesValidation="False" />
                        &nbsp;&nbsp;&nbsp;
                                <asp:Button ID="btnCancle" runat="server" OnClick="btnCancle_Click" Text="Cancle" />
                    </td>
                    <td class="auto-style4">
                        <asp:Button ID="btnUpdate" runat="server" OnClick="btnUpdate_Click" Text="Update" CausesValidation="False" />
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style3">&nbsp;</td>
                    <td class="auto-style2">&nbsp;</td>
                    <td class="auto-style4">
                        <asp:Label ID="lblOutput" runat="server" ForeColor="Red"></asp:Label>
                    </td>
                    <td>&nbsp;</td>
                </tr>
            </table>
        </div>
        </div>
</asp:Content>
