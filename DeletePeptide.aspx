<%@ Page Title="Delete the peptides" Language="C#" MasterPageFile="~/Template/MasterPage.master" AutoEventWireup="true" CodeFile="DeletePeptide.aspx.cs" Inherits="DeletePeptide" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

     <form id="form1" runat="server">
        <center>
  <div class="form-group col-md-6 div-border">
     
      <label for="search">Peptide Name</label>
    <asp:TextBox CssClass="form-control text-center" ID="txtpepname" runat="server"></asp:TextBox>
      <br />

  </div>
 
  <%--<Button type="submit" Class="btn btn-primary" disabled onclick="SearchPeptide()">Search</Button>--%>
    
  <asp:Button type="button" class="btn btn-primary" runat="server" Text="Search" ID="btnsearch" OnClick="btnsearch_Click"></asp:Button>



  <asp:Button type="button" class="btn btn-info" runat="server" Text="Return" PostBackUrl="admcp.aspx" ID="btnReturn"></asp:Button>



<div class="mt-3 mb-3">
    <asp:GridView ID="gv" runat="server" BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" CellPadding="3" OnSelectedIndexChanging="gv_SelectedIndexChanging">
        <Columns>
            <asp:CommandField ButtonType="Image" ShowSelectButton="True" SelectImageUrl="~/imgs/delete.jpg" >
            <ControlStyle Height="30px" Width="30px" />
            </asp:CommandField>
        </Columns>
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

  <asp:Button ID="btndelete" type="submit" runat="server" CssClass="btn btn-danger" onclick="btndelete_Click" Text="Delete Peptide"></asp:Button>

</center>
</form>

</asp:Content>

