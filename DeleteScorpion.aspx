<%@ Page Title="Delete the scorpions" Language="C#" MasterPageFile="~/Template/MasterPage.master" AutoEventWireup="true" CodeFile="DeleteScorpion.aspx.cs" Inherits="DeleteScorpion" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

     <form id="form1" runat="server">
        <center>
  <div class="form-group col-md-6 div-border">
     
      <label for="search"> Family</label>
    <asp:TextBox CssClass="form-control text-center" ID="txtfamily" runat="server"></asp:TextBox>
      <br />

      <label for="search">Genus</label>
    <asp:TextBox CssClass="form-control text-center" ID="txtgenus" runat="server"></asp:TextBox>
       <br />

      <label for="search">Species</label>
    <asp:TextBox CssClass="form-control text-center" ID="txtspecies" runat="server"></asp:TextBox>
  </div>
 
  <Button type="submit" Class="btn btn-primary" onclick="deletescorpion.aspx">Search</Button>

<div class="mb-3 mt-3">
    <asp:GridView ID="gv" runat="server" BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" CellPadding="3">
        <FooterStyle BackColor="White" ForeColor="#000066" />
        <HeaderStyle BackColor="#006699" Font-Bold="True" ForeColor="White" />
        <PagerStyle BackColor="White" ForeColor="#000066" HorizontalAlign="Left" />
        <RowStyle ForeColor="#000066" />
        <SelectedRowStyle BackColor="#669999" Font-Bold="True" ForeColor="White" />
        <SortedAscendingCellStyle BackColor="#F1F1F1" />
        <SortedAscendingHeaderStyle BackColor="#007DBB" />
        <SortedDescendingCellStyle BackColor="#CAC9C9" />
        <SortedDescendingHeaderStyle BackColor="#00547E" />
     </asp:GridView>
</div>

            <asp:Label ID="lblmsg" runat="server" ForeColor="Red" Text="Successfully Deleted!" Visible="False"></asp:Label>

  <asp:Button ID="btndelete" type="submit" runat="server" CssClass="btn btn-danger" onclick="btndelete_Click" Text="Delete Scorpion"></asp:Button>

  <asp:Button type="button" class="btn btn-info" runat="server" Text="Return" PostBackUrl="admcp.aspx" ID="Button1"></asp:Button>

</center>
</form>

</asp:Content>

