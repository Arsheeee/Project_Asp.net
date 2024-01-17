<%@ Page Title="" Language="C#" MasterPageFile="~/shop.Master" AutoEventWireup="true" CodeBehind="Product_details.aspx.cs" Inherits="Project1.Product_details" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            width: 644px;
        }
        .auto-style3 {
            height: 567px;
        }
        .auto-style4 {
            width: 644px;
            height: 567px;
        }
        .auto-style5 {
            width: 783px;
        }
        .auto-style6 {
            width: 783px;
            height: 63px;
        }
        .auto-style7 {
            width: 100%;
            margin-right: 109px;
        }
        .auto-style8 {
            width: 783px;
            height: 51px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table class="auto-style1">
        <tr>
            <td>&nbsp;</td>
            <td class="auto-style2">&nbsp;</td>
            <td>products</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td class="auto-style2">&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style3"></td>
            <td class="auto-style4">
                <asp:Image ID="Image1" runat="server" Height="624px" Width="569px" />
            </td>
            <td class="auto-style3">
                <table class="auto-style7">
                    <tr>
                        <td class="auto-style5">&nbsp;
                            <asp:Label ID="Label1" runat="server" Text="product name"></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style5">&nbsp;
                            <asp:Label ID="Label2" runat="server" Text="price"></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style5">&nbsp;
                            <asp:Label ID="Label3" runat="server" Text="description"></asp:Label>
&nbsp;&nbsp; </td>
                    </tr>
                    <tr>
                        <td class="auto-style8">&nbsp; quantity&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                            <asp:TextBox ID="TextBox1" runat="server" Height="25px" Width="93px"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style6">
                            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Add To Cart" />
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style6">&nbsp;</td>
                    </tr>
                    <tr>
                        <td class="auto-style6">
                            <asp:Label ID="Label4" runat="server" ForeColor="Red"></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style6">&nbsp;</td>
                    </tr>
                </table>
            </td>
            <td class="auto-style3"></td>
            <td class="auto-style3"></td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td class="auto-style2">&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td class="auto-style2">&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td class="auto-style2">&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td class="auto-style2">&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td class="auto-style2">&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td class="auto-style2">&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td class="auto-style2">&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
    </table>
</asp:Content>
