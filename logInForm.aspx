<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="logInForm.aspx.cs" Inherits="logInForm" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div class="row">
        <div class="col-md-2"></div>
        <div class="col-md-6">
            <div class="form-group">
                <label for="name">Email:</label>
                <asp:TextBox ID="tbxEmail" class="form-control" runat="server"></asp:TextBox>
                <br />
                <asp:RequiredFieldValidator ID="RequiredFieldValidator_Name" runat="server" ControlToValidate="tbxEmail" Display="Dynamic" ErrorMessage="please enter your Email" ForeColor="Red"></asp:RequiredFieldValidator>
                <asp:RegularExpressionValidator ID="RegularExpressionValidator_Email" runat="server" ControlToValidate="tbxEmail" Display="Dynamic" ErrorMessage="please enter a valid email" ForeColor="Red" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
            </div>
            <div class="form-group">
                <label for="pwd">Password:</label>
                <asp:TextBox ID="tbxPassword" type="password" class="form-control" runat="server" TextMode="Password"></asp:TextBox>
                <br />
                <a href="forgetPassword.aspx">forget password?</a>
                <br />
                <br />
                <asp:RequiredFieldValidator ID="RequiredFieldValidator_Password" runat="server" ControlToValidate="tbxPassword" Display="Dynamic" ErrorMessage="please enter your password" ForeColor="Red"></asp:RequiredFieldValidator>
            </div>
            <div class="form-group">
                <asp:Button ID="btnLogin" class="btn btn-primary btn-lg btn btn-info" runat="server" Text="Login" OnClick="btnLogin_Click" />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Label ID="lblOutput" runat="server" ForeColor="Red" Visible="False"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            </div>
            <div class="form-group">
                <br />
                <span>Don't have an account?</span>
                <a href="registerForm.aspx">Sign up</a>
                <br />
            </div>
        </div>
        <div class="col-md-4"></div>
    </div>
</asp:Content>

