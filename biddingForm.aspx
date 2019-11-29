<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="biddingForm.aspx.cs" Inherits="biddingForm" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .auto-style1 {
            width: 163px;
        }
        .auto-style2 {
            width: 163px;
            height: 20px;
        }
        .auto-style3 {
            height: 20px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table class="nav-justified">
        <tr>
            <td class="auto-style1">Item ID</td>
            <td>
                <asp:Label ID="lblItemId" runat="server"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="auto-style1">Image</td>
            <td>
                <asp:Image ID="Image1" runat="server" Height="100px" Width="100px" />
            </td>
        </tr>
        <tr>
            <td class="auto-style1">description</td>
            <td>
                <asp:Label ID="lblDescription" runat="server"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="auto-style1">Condition of Good</td>
            <td>
                <asp:Label ID="lblCondition" runat="server"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="auto-style2">Minimum Bid Price</td>
            <td class="auto-style3">
                <asp:Label ID="lblMinBidPrice" runat="server"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="auto-style1">Start Bid Date</td>
            <td>
                <asp:Label ID="lblStartDate" runat="server"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="auto-style1">Duration</td>
            <td>
                <asp:Label ID="lblDuration" runat="server"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="auto-style1">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style1">current Price</td>
            <td>
                $
                <asp:Label ID="lblCurrentPrice" runat="server"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="auto-style2">Bidding Member</td>
            <td class="auto-style3">
                <asp:Label ID="lblBiddingMember" runat="server"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="auto-style1">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style1">Bid Price</td>
            <td>
                $
                <asp:TextBox ID="tbxBidPrice" runat="server" TextMode="Number"></asp:TextBox>
                <asp:Label ID="lblCheckBidPrice" runat="server" Visible="False" ForeColor="Red"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="auto-style1">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style1">
                <asp:Button ID="btnBid" runat="server" Text="Bid" OnClick="btnBid_Click" />
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style1">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style1">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
    </table>
</asp:Content>

