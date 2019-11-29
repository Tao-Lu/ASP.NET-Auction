<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="forgetPassword.aspx.cs" Inherits="forgetPassword" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server" >
    <div class="container">
        <p>Forget your account's password? Enter your email address and we will send you a recovery link.</p>
        <p>&nbsp;</p>
        <p>please enter your email:
            <asp:TextBox ID="tbxEmail" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator_Email" runat="server" ControlToValidate="tbxEmail" Display="Dynamic" ErrorMessage="please enter your email" ForeColor="Red"></asp:RequiredFieldValidator>
            <asp:RegularExpressionValidator ID="RegularExpressionValidator_Email" runat="server" ControlToValidate="tbxEmail" Display="Dynamic" ErrorMessage="please enter a valid email" ForeColor="Red" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
        </p>
        <p>&nbsp;</p>
        <p>
            <asp:Button ID="btnSendRecoveryEmail" runat="server" class="btn btn-primary btn-lg btn btn-info" Text="Send Recovery Email" OnClick="btnSendRecoveryEmail_Click" />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="lblOutput" runat="server" ForeColor="Red" Visible="False"></asp:Label>
        </p>
        <p>
            &nbsp;</p>
            
    </div>
</asp:Content>

