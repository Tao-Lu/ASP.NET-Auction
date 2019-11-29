<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="ItemForm.aspx.cs" Inherits="ItemForm" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div class="form-group">
    </div>

    <div class="form-group">
        <asp:DropDownList ID="ddlCategory" runat="server" Height="16px" Width="151px" DataSourceID="SqlDataSource1" DataTextField="shortName" DataValueField="shortName">
        </asp:DropDownList>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:INFT3050Assignment3ConnectionString %>" SelectCommand="SELECT [shortName] FROM [Category]"></asp:SqlDataSource>
        <asp:Button ID="Category" runat="server" OnClick="Button1_Click" Text="show" />
        <asp:Button ID="btnAllItems" runat="server" OnClick="btnAllItems_Click" Text="All Items" />
        <br />
        <asp:DataList ID="dtlItem" runat="server" CellPadding="4" ForeColor="#333333" RepeatColumns="5" RepeatDirection="Horizontal">
            <AlternatingItemStyle BackColor="White" />
            <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
            <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
            <ItemStyle BackColor="#EFF3FB" />
            <ItemTemplate>
                &nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Label ID="lblItemId" runat="server" Text='<%# ""+Eval("itemId") %>'></asp:Label>
                <br />
                &nbsp;&nbsp;&nbsp;
                <asp:Label ID="lblDescription" runat="server" Text='<%# Eval("description") %>'></asp:Label>
                <br />
                &nbsp;&nbsp;&nbsp;
                <asp:Label ID="lblConditionOfTheItem" runat="server" Text='<%# Eval("conditionOfTheItem") %>'></asp:Label>
                <br />
                &nbsp;&nbsp;&nbsp;
                <asp:Image ID="imgItem" runat="server" Height="100px" ImageUrl='<%# "~/Images/items/"+Eval("imageFileName") %>' Width="100px" />
                <br />
                &nbsp;&nbsp;&nbsp;
                <asp:Label ID="lblMinBidPrice" runat="server" Text='<%# String.Format("{0:c}", Eval("minBidPrice")) %>'></asp:Label>
                <br />
                &nbsp;&nbsp;&nbsp;
                <asp:Label ID="lblStrartDateOfTheBid" runat="server" Text='<%# String.Format("{0:dd-MM-yyyy} ", Eval("startDateOfTheBid")) %>'></asp:Label>
                <br />
                &nbsp;&nbsp;&nbsp;
                <asp:Label ID="lblDuration" runat="server" Text='<%# Eval("duration") %>'></asp:Label>
                &nbsp;days<br />
                <br />
                &nbsp;&nbsp;&nbsp;
                <asp:LinkButton ID="lnkBtnBid" runat="server" CommandName="select" OnClick="LinkButton1_Click" >Bid</asp:LinkButton>
                <br />
                &nbsp;&nbsp;&nbsp;
                <asp:LinkButton ID="lnkBtnQuestion" runat="server" CommandName="select" OnClick="LinkButton2_Click" >Question</asp:LinkButton>
            </ItemTemplate>
            <SelectedItemStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
        </asp:DataList>
    </div>


</asp:Content>

