<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="FAQForm.aspx.cs" Inherits="FAQForm" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div class="form-group">
        <asp:GridView ID="gvFAQ" runat="server" AllowSorting="True" AutoGenerateColumns="False" EnableSortingAndPagingCallbacks="True" Width="1213px">
            <Columns>
                <asp:BoundField DataField="faqId" HeaderText="FAQ ID" ReadOnly="True" />
                <asp:BoundField DataField="question" HeaderText="Question" ReadOnly="True" />
                <asp:BoundField DataField="date" HeaderText="Post Date" ReadOnly="True" DataFormatString="{0:dd/MM/yyyy}" />
                <asp:BoundField DataField="reply" HeaderText="Reply" ReadOnly="True" />
                <asp:BoundField DataField="itemId" HeaderText="Item Id" ReadOnly="True" />
                <asp:BoundField DataField="memberId" HeaderText="Member Id" ReadOnly="True" />
            </Columns>
        </asp:GridView>
    </div>
    <div class="form-group">



        <asp:TextBox ID="tbxAskQuestion" runat="server" TextMode="MultiLine"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator_question" runat="server" ControlToValidate="tbxAskQuestion" Display="Dynamic" ErrorMessage="please enter a question" ForeColor="Red"></asp:RequiredFieldValidator>
        <br />
        <asp:Button ID="btnAsk" runat="server" OnClick="btnAsk_Click" Text="ASK" />
        <asp:Label ID="lblOutput" runat="server" ForeColor="Red" Visible="False"></asp:Label>



    </div>
</asp:Content>

