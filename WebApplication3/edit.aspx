<%@ Page Language="C#" AutoEventWireup="true"  MasterPageFile="~/Site.Master" CodeBehind="edit.aspx.cs" Inherits="WebApplication3.edit" %>



<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <table style="width: 100%">
    <tr>
        <td><asp:Label ID="Label1" runat="server" Text="Name"></asp:Label></td>
        <td><asp:TextBox ID="Pr_Name" runat="server" Height="25px" Text="Hello"></asp:TextBox>
            <asp:TextBox type="hidden" ID="hiddenid" runat="server" Height="25px"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td><asp:Label ID="Label2" runat="server" Text="Price"></asp:Label></td>
        <td><asp:TextBox ID="Pr_Price" runat="server" Height="25px"></asp:TextBox></td>
    </tr>
    <tr>
        <td><asp:Label ID="Label3" runat="server" Text="Description"></asp:Label></td>
        <td><asp:TextBox ID="Pr_Description" runat="server" Height="25px"></asp:TextBox></td>
    </tr>
    <tr>
        <td><asp:Label ID="Label4" runat="server" Text="Category"></asp:Label></td>
        <td><asp:TextBox ID="Pr_Category" runat="server" Height="25px"></asp:TextBox></td>
    </tr>
    <tr>
        <td><asp:Label ID="Label5" runat="server" Text="Stock"></asp:Label></td>
        <td><asp:TextBox ID="Pr_Stock" runat="server" Height="25px"></asp:TextBox></td>
    </tr>
</table>
    <asp:Button ID="Button1" runat="server" Text="UPDATE PRODUCT" OnClick="updateproduct"  />
    <asp:Label ID="Status" runat="server" Text=""></asp:Label>
</asp:Content>