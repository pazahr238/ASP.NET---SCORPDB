<%@ Page Title="Administration Control Panel" Language="C#" MasterPageFile="~/Template/MasterPage.master" AutoEventWireup="true" CodeFile="admcp.aspx.cs" Inherits="admcp" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">


    <form id="form1" runat="server">
  <center>
        <div class="container mt-3">
        <div class="font-weight-bold">Admin Panel</div>
   
<div class="col-md-8 div-border">
   <table class="table table-hover">
    <thead>
      <tr>
        <th>Delete</th>
        <th>Edit</th>
      </tr>
    </thead>
    <tbody>
        <tr>
          <td><asp:Button ID="btndeletescorpion" CssClass="btn-danger" PostBackUrl="deletescorpion.aspx" runat="server" Text="Delete Scorpion" /></td>
          <td><asp:Button ID="btneditscorpion" CssClass="btn-warning" PostBackUrl="editscorpion.aspx" runat="server" Text="Edit Scorpion" /></td>
          </tr> 
        <tr>
          <td><asp:Button ID="btndeletepeptide" CssClass="btn-danger" PostBackUrl="deletepeptide.aspx" runat="server" Text="Delete Peptide" /></td>
          <td><asp:Button ID="btneditpeptide" CssClass="btn-warning" PostBackUrl="editpeptide.aspx" runat="server" Text="Edit Peptide" /></td>
        </tr>
    </tbody>
    </table>

   <table class="table table-hover">
    <thead>
      <tr>
        <th>Insert</th>
        <th>Return</th>
      </tr>
    </thead>
    <tbody>
        <tr>
          <td><asp:Button ID="Button3" CssClass="btn-success" PostBackUrl="addscorpion.aspx" runat="server" Text="Insert Scorpion" /></td>
          <td><asp:Button ID="Button4" CssClass="btn-info" runat="server" Text="Exit" OnClick="btnexit_Click" Width="97px"/></td>
          </tr> 
        <tr>
          <td><asp:Button ID="Button7" CssClass="btn-success" PostBackUrl="addpeptide.aspx" runat="server" Text="Insert Peptide" /></td>
          <td><asp:Button ID="Button8" CssClass="btn-primary" PostBackUrl="changepass.aspx" runat="server" Text="Change Password" /></td>
        </tr>
    </tbody>
    </table>
</div>
            </div>
        </center>
    </form>






</asp:Content>

