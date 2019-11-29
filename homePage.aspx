<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="homePage.aspx.cs" Inherits="homePage" %>

<%--<script runat="server">

    void page_loadcomplete(object sender,EventArgs e)

    {
        labelincontent.Text = (Master.FindControl("btnLogin") as LinkButton).Text;

    }

</script>--%>



<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <!--last week item-->
    <div class="form-group">
        <h3>Last Week Items</h3>
        <asp:DataList ID="dtlLastWeekItem" runat="server" CellPadding="4" ForeColor="#333333" RepeatColumns="5" RepeatDirection="Horizontal">
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
                <asp:Label ID="lblStrartDateOfTheBid" runat="server" Text='<%# Eval("startDateOfTheBid") %>'></asp:Label>
                <br />
                &nbsp;&nbsp;&nbsp;
                <asp:Label ID="lblDuration" runat="server" Text='<%# Eval("duration")+"days" %>'></asp:Label>
                <br />
                <br />
                &nbsp;&nbsp;&nbsp;
                <asp:LinkButton ID="lnkBtnQuestionLastWeek" runat="server" OnClick="lnkBtnQuestionLastWeek_Click">Question</asp:LinkButton>
            </ItemTemplate>
            <SelectedItemStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
        </asp:DataList>
    </div>

    <!--current available item-->
    <div class="form-group">
        <h3>Current Available Items</h3>
        <asp:DataList ID="dtlCurrentAvailableItem" runat="server" CellPadding="4" ForeColor="#333333" RepeatColumns="5" RepeatDirection="Horizontal">
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
                <asp:Label ID="lblStrartDateOfTheBid" runat="server" Text='<%# Eval("startDateOfTheBid") %>'></asp:Label>
                <br />
                &nbsp;&nbsp;&nbsp;
                <asp:Label ID="lblDuration" runat="server" Text='<%# Eval("duration")+"days" %>'></asp:Label>
                <br />
                <br />
                &nbsp;&nbsp;&nbsp;
                <asp:LinkButton ID="lnkBtnBid" runat="server" OnClick="lnkBtnBid_Click" >Bid</asp:LinkButton>
                <br />
                &nbsp;&nbsp;&nbsp;
                <asp:LinkButton ID="lnkBtnQuestionCurrent" runat="server" OnClick="lnkBtnQuestionCurrent_Click">Question</asp:LinkButton>
            </ItemTemplate>
            <SelectedItemStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
        </asp:DataList>

    </div>


    <p class="h5 text-center "><a href="#">Links</a> || <a href="#">About</a> || <a href="#">Support</a></p>
    <br />
    <p class="h5 text-center ">© Bid.com All Rights Reserved.</p>

</asp:Content>
