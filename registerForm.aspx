<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="registerForm.aspx.cs" Inherits="registerForm" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }

        .auto-style3 {
        }

        .auto-style9 {
        }

        .auto-style10 {
            height: 20px;
            width: 310px;
        }

        .auto-style11 {
            width: 310px;
            height: 39px;
        }

        .auto-style12 {
            width: 763px;
        }

        .auto-style13 {
            height: 20px;
            width: 763px;
        }

        .auto-style14 {
            height: 39px;
            width: 763px;
        }


        .auto-style15 {
        }

        .auto-style16 {
            height: 20px;
            width: 1202px;
        }

        .auto-style17 {
            width: 1202px;
            height: 39px;
        }
        .auto-style18 {
            width: 938px;
        }
        .auto-style19 {
            height: 20px;
            width: 938px;
        }
        .auto-style20 {
            height: 39px;
            width: 938px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div class="container">
        <table class="auto-style1">
            <tr>
                <td class="auto-style15" colspan="4">
                    <p class="h1 text-center ">Register Form</p>
                </td>
            </tr>
            <tr>
                <td class="auto-style15">&nbsp;</td>
                <td class="auto-style9">&nbsp;</td>
                <td class="auto-style18">&nbsp;</td>
                <td class="auto-style12">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style15">&nbsp;</td>
                <td class="auto-style9">Name</td>
                <td class="auto-style18">
                    <asp:TextBox ID="tbxName" runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator_Name" runat="server" ControlToValidate="tbxName" ErrorMessage="please enter your name" Display="Dynamic" ForeColor="Red"></asp:RequiredFieldValidator>
                    <asp:RegularExpressionValidator ID="RegularExpressionValidator_Name" runat="server" ControlToValidate="tbxName" Display="Dynamic" ErrorMessage="only can key in letter" ForeColor="Red" ValidationExpression="^[A-Za-z]*"></asp:RegularExpressionValidator>
                </td>
                <td class="auto-style12">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style16">&nbsp;</td>
                <td class="auto-style10"></td>
                <td class="auto-style19"></td>
                <td class="auto-style13">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style15">&nbsp;</td>
                <td class="auto-style9">Gender</td>
                <td class="auto-style18">
                    <asp:RadioButtonList ID="RadioButtonList_Gender" runat="server" Width="92px">
                        <asp:ListItem>Male</asp:ListItem>
                        <asp:ListItem>Female</asp:ListItem>
                    </asp:RadioButtonList>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator_Gender" runat="server" ControlToValidate="RadioButtonList_Gender" Display="Dynamic" ErrorMessage="please choose your gender" ForeColor="Red"></asp:RequiredFieldValidator>
                </td>
                <td class="auto-style12">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style15">&nbsp;</td>
                <td class="auto-style9">&nbsp;</td>
                <td class="auto-style18">&nbsp;</td>
                <td class="auto-style12">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style15">&nbsp;</td>
                <td class="auto-style9">Date of Birth</td>
                <td class="auto-style18">
                    <asp:TextBox ID="tbxDOB" runat="server" type="date"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator_DOB" runat="server" ControlToValidate="tbxDOB" Display="Dynamic" ErrorMessage="please enter your birthday" ForeColor="Red"></asp:RequiredFieldValidator>
                    <asp:Label ID="lblAgeValidation" runat="server" ForeColor="Red" Visible="False"></asp:Label>
                </td>
                <td class="auto-style12">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style15">&nbsp;</td>
                <td class="auto-style9">&nbsp;</td>
                <td class="auto-style18">&nbsp;</td>
                <td class="auto-style12">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style17">&nbsp;</td>
                <td class="auto-style11">Address</td>
                <td class="auto-style20">
                    <asp:TextBox ID="tbxAddress" runat="server" TextMode="MultiLine"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator_Address" runat="server" ControlToValidate="tbxAddress" Display="Dynamic" ErrorMessage="please enter your address" ForeColor="Red"></asp:RequiredFieldValidator>
                </td>
                <td class="auto-style14">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style15">&nbsp;</td>
                <td class="auto-style9">&nbsp;</td>
                <td class="auto-style18">&nbsp;</td>
                <td class="auto-style12">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style15">&nbsp;</td>
                <td class="auto-style9">Email</td>
                <td class="auto-style18">
                    <asp:TextBox ID="tbxEmail" runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator_Email" runat="server" ControlToValidate="tbxEmail" Display="Dynamic" ErrorMessage="please enter your email" ForeColor="Red"></asp:RequiredFieldValidator>
                    <asp:RegularExpressionValidator ID="RegularExpressionValidator_Email" runat="server" ControlToValidate="tbxEmail" Display="Dynamic" ErrorMessage="please enter a valid email" ForeColor="Red" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
                    <asp:Label ID="lblCheckEmail" runat="server" ForeColor="Red" Visible="False"></asp:Label>
                </td>
                <td class="auto-style12">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style15">&nbsp;</td>
                <td class="auto-style9">&nbsp;</td>
                <td class="auto-style18">&nbsp;</td>
                <td class="auto-style12">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style15">&nbsp;</td>
                <td class="auto-style9">Phone</td>
                <td class="auto-style18">
                    <asp:TextBox ID="tbxPhone" runat="server" TextMode="Number"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator_Phone" runat="server" ControlToValidate="tbxPhone" Display="Dynamic" ErrorMessage="please enter your phone number" ForeColor="Red"></asp:RequiredFieldValidator>
                    <asp:RegularExpressionValidator ID="RegularExpressionValidator_Phone" runat="server" ControlToValidate="tbxPhone" Display="Dynamic" ErrorMessage="please enter a valid phone number" ForeColor="Red" ValidationExpression="^(8|9)?\d{7}"></asp:RegularExpressionValidator>
                </td>
                <td class="auto-style12">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style16">&nbsp;</td>
                <td class="auto-style10"></td>
                <td class="auto-style19"></td>
                <td class="auto-style13">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style15">&nbsp;</td>
                <td class="auto-style9">Password</td>
                <td class="auto-style18">
                    <asp:TextBox ID="tbxPassword" runat="server" TextMode="Password"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator_Password" runat="server" ControlToValidate="tbxPassword" Display="Dynamic" ErrorMessage="please enter your password" ForeColor="Red"></asp:RequiredFieldValidator>
                </td>
                <td class="auto-style12">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style15">&nbsp;</td>
                <td class="auto-style9">&nbsp;</td>
                <td class="auto-style18">&nbsp;</td>
                <td class="auto-style12">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style15">&nbsp;</td>
                <td class="auto-style9">Password verify</td>
                <td class="auto-style18">
                    <asp:TextBox ID="tbxPasswordVerify" runat="server" TextMode="Password"></asp:TextBox>
                    <asp:CompareValidator ID="CompareValidator_PasswordVerify" runat="server" ControlToCompare="tbxPassword" ControlToValidate="tbxPasswordVerify" Display="Dynamic" ErrorMessage="please enter same password" ForeColor="Red"></asp:CompareValidator>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator_PasswordVerify" runat="server" ControlToValidate="tbxPasswordVerify" Display="Dynamic" ErrorMessage="please re-enter your password" ForeColor="Red"></asp:RequiredFieldValidator>
                </td>
                <td class="auto-style12">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style15">&nbsp;</td>
                <td class="auto-style9">&nbsp;</td>
                <td class="auto-style18">&nbsp;</td>
                <td class="auto-style12">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style15">&nbsp;</td>
                <td class="auto-style3" colspan="2">&nbsp;</td>
                <td class="auto-style3">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style15" colspan="4">
                    <asp:Button ID="btnRegister" runat="server" class="btn btn-primary btn-lg btn btn-info center-block" Text="Register" OnClick="btnRegister_Click" />
                </td>
            </tr>
            <tr>
                <td class="auto-style15" colspan="4">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style15">
                    &nbsp;</td>
                <td class="auto-style15">
                    &nbsp;</td>
                <td class="auto-style15">
                    <asp:Label ID="lblSuccessful" runat="server" ForeColor="Red" Visible="False"></asp:Label>
                </td>
                <td class="auto-style15">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style15">
                    &nbsp;</td>
                <td class="auto-style15">
                    &nbsp;</td>
                <td class="auto-style15">
                    &nbsp;</td>
                <td class="auto-style15">
                    &nbsp;</td>
            </tr>
        </table>
    </div>
</asp:Content>

