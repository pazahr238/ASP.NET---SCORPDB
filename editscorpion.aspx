<%@ Page Title="Edit the details of a scorpion" Language="C#" MasterPageFile="~/Template/MasterPage.master" AutoEventWireup="true" CodeFile="editscorpion.aspx.cs" Inherits="editscorpion" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

   <form id="form1" runat="server">
        <center>
  <div class="form-group col-md-6 div-border">

    <label for="search">Species: (You must enter it)</label>&nbsp;<asp:TextBox CssClass="form-control" ID="txtspecies" runat="server"></asp:TextBox>

    <br />
      
  </div>

  <button type="submit" class="btn btn-primary" onclick="SSearch.aspx">Search</button>
<br />

<div class="col-md-6 div-border">
          <asp:Label CssClass="form-control text-danger" ID="lblmsg" runat="server" Text="Not found!" Visible="False"></asp:Label>

            <asp:GridView ID="gv" runat="server" CellPadding="4" ForeColor="#333333" GridLines="None" OnSelectedIndexChanging="gv_SelectedIndexChanging">
                <AlternatingRowStyle BackColor="White" />
                <Columns>
                    <asp:CommandField ButtonType="Image" SelectImageUrl="~/pic/ok.png" ShowSelectButton="True">
                    <ControlStyle Height="20px" Width="20px" />
                    </asp:CommandField>
                </Columns>
                <EditRowStyle BackColor="#2461BF" />
                <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
                <RowStyle BackColor="#EFF3FB" />
                <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
                <SortedAscendingCellStyle BackColor="#F5F7FB" />
                <SortedAscendingHeaderStyle BackColor="#6D95E1" />
                <SortedDescendingCellStyle BackColor="#E9EBEF" />
                <SortedDescendingHeaderStyle BackColor="#4870BE" />
            </asp:GridView>
</div>
            
            <br />

<div class="col-md-6 div-border">
<asp:Image ID="imgscorpion" Width="20%" runat="server" />
            
            <br />
<label class="form-control border-0">New Image</label>
<asp:FileUpload ID="fu" runat="server" />
    
  <div class="form-group">

    <label for="search">Family:</label>&nbsp;<asp:TextBox CssClass="form-control" ID="txtfamily" runat="server"></asp:TextBox>
    <br />
     
    <label for="search">Genus:</label>&nbsp;<asp:TextBox CssClass="form-control" ID="txtgenus" runat="server"></asp:TextBox>
    <br />
    
    <label for="search">Country:</label>&nbsp;<asp:TextBox CssClass="form-control" ID="txtcountry" runat="server"></asp:TextBox>
    <br />

    <label for="search">Location:</label>&nbsp;<asp:TextBox CssClass="form-control" ID="txtlocation" runat="server"></asp:TextBox>
    <br />

    <label for="search">Reproduction:</label>&nbsp;<asp:TextBox CssClass="form-control" ID="txtrepro" runat="server"></asp:TextBox>
    <br />
    
    <label for="search">Feed:</label>&nbsp;<asp:TextBox CssClass="form-control" ID="txtfeed" runat="server"></asp:TextBox>
    <br />

    <label for="search">Injury:</label>&nbsp;<asp:TextBox CssClass="form-control" ID="txtinjury" runat="server"></asp:TextBox>
    <br />

   </div>

</div>    
            
    <asp:Button ID="btnsave" CssClass="btn-warning" runat="server" Text="Save" OnClick="btnsave_Click"/>  
    <asp:Button ID="btnreturn" CssClass="btn-info" runat="server" Text="Return" PostBackUrl="admcp.aspx"/>



</center>
</form>


</asp:Content>

