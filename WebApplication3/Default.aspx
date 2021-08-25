<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebApplication3._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
        <h1>ASP.NET</h1>
        <button type="button" class="btn btn-primary" data-toggle="modal" data-target="#exampleModal">
 Add Product
</button>
        <table class="table">
        <asp:Repeater ID="Repeater1" runat="server">
            <HeaderTemplate>
                <tr>
                    <th>Name</th>
                    <th>Price</th>
                    <th>Desc</th>
                    <th>Cat</th>
                    <th>Stock</th>
                    <th>Action</th>
                    </tr>
            </HeaderTemplate>

            <ItemTemplate>
                <tr>
                    <td><%# Eval("name") %></td>
                    <td><%# Eval("price") %></td>
                    <td><%# Eval("descp") %></td>
                    <td><%# Eval("category") %></td>
                    <td><%# Eval("stock") %></td>
                    <td><a href="edit?id=<%# Eval("id") %>"><i class="bi bi-pencil-square"></i></a>
                        <a href="Default?id=<%# Eval("id") %>"> <i  class="bi bi-trash"></i></a>
                    </td>
                    </tr>
            </ItemTemplate>
            <FooterTemplate>
                <th>Name</th>
                    <th>Price</th>
                    <th>Desc</th>
                    <th>Cat</th>
                    <th>Stock</th>
                    <th>Action</th>
                    </tr>
            </FooterTemplate>
        </asp:Repeater>
            </table>
    </div>
    
    <!-- Modal -->
<div class="modal fade" id="exampleModal" tabindex="-1" aria-labelledby="exampleModalLabel" aria-hidden="true">
  <div class="modal-dialog  modal-dialog-centered">
    <div class="modal-content">
      <div class="modal-header">
        <h5 class="modal-title" id="exampleModalLabel">Modal title</h5>
        <button type="button" class="close" data-dismiss="modal" aria-label="Close">
          <span aria-hidden="true">&times;</span>
        </button>
      </div>
      <div class="modal-body">
     <table style="width: 100%;">
    <tr>
        <td><asp:Label ID="Label1" runat="server" Text="Name"></asp:Label></td>
        <td><asp:TextBox ID="Pr_Name" runat="server" Height="25px"></asp:TextBox></td>
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
    <asp:Button ID="Button1" runat="server" Text="ADD PRODUCT" OnClick="addProducts" style="margin-top: 8" />
    <asp:Label ID="Status" runat="server" Text=""></asp:Label>
      </div>
      <div class="modal-footer">
        <button type="button" class="btn btn-secondary" data-dismiss="modal">Close</button>
        <button type="button" class="btn btn-primary">Save changes</button>
      </div>
    </div>
  </div>
</div>

    <input id="btnGetTime" type="button" value="Show Current Time"
    onclick = "ShowCurrentTime()" />


   <script src="https://code.jquery.com/jquery-3.6.0.js"></script>
<script type = "text/javascript">
function ShowCurrentTime() {
    $.ajax({
        type: "POST",
        url: "Default.aspx/GetCurrentTime",
        data: '{name: "suraj" }',
        contentType: "application/json; charset=utf-8",
        dataType: "json",
        success: OnSuccess,
        failure: function(response) {
            alert(response.d);
        }
    });
}
function OnSuccess(response) {
    alert(response.d);
}
</script>

</asp:Content>
