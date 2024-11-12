<%@ Page Title="Login to the Administration page" Language="C#" MasterPageFile="~/Template/MasterPage.master" AutoEventWireup="true" CodeFile="loginadm.aspx.cs" Inherits="loginadm" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">


     <form id="form1" runat="server">
        <center>
  <div class="form-group col-md-6 div-border">

    <label for="search">User Name:</label>
    <asp:TextBox CssClass="form-control" ID="username" runat="server"></asp:TextBox>
      <br />
      <label for="search">Password:</label>
      
    <asp:TextBox CssClass="form-control" ID="password" runat="server" TextMode="Password"></asp:TextBox>
  </div>
 
  <button type="submit" class="btn btn-primary" onclick="loginadm.aspx">Login</button>

   
</center>
</form>

</asp:Content>

