<%@ Page Title="Edit the details of a peptide" Language="C#" MasterPageFile="~/Template/MasterPage.master" AutoEventWireup="true" CodeFile="editpeptide.aspx.cs" Inherits="editpeptide" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

     <form id="form1" runat="server">
        <center>
  <div class="form-group col-md-6 div-border">

    <label for="search">Peptide name: (You must enter all three fields)</label>&nbsp;<asp:TextBox CssClass="form-control" ID="txtpname" runat="server"></asp:TextBox>
    <br />

    <label for="search">Source:</label>&nbsp;<asp:TextBox CssClass="form-control" ID="txtsource" runat="server"></asp:TextBox>
    <br />

    <label for="search">Sequence:</label>&nbsp;<asp:TextBox CssClass="form-control" ID="txtsequence" runat="server"></asp:TextBox>
    <br />
      
  </div>

  <%--<button type="submit" class="btn btn-primary" onclick="SSearch.aspx">Search</button>--%>
  <asp:Button ID="btnsearch" CssClass="btn-primary" runat="server" Text="Save" OnClick="btnsearch_Click" />   

<br />
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

            
<br />
    
  <div class="form-group col-md-6 div-border">

    <label for="search">Activity:</label>&nbsp;<asp:TextBox CssClass="form-control" ID="txtactivity" runat="server"></asp:TextBox>
    <br />
     
    <label for="search">Therapy:</label>&nbsp;<asp:TextBox CssClass="form-control" ID="txttherapy" runat="server"></asp:TextBox>
    <br />
    
    <label for="search">Length:</label>&nbsp;<asp:TextBox CssClass="form-control" ID="txtlen" runat="server"></asp:TextBox>
    <br />

    <label for="search">Uniprot:</label>&nbsp;<asp:TextBox CssClass="form-control" ID="txtunip" runat="server"></asp:TextBox>
    <br />

    <label for="search">Pdbid:</label>&nbsp;<asp:TextBox CssClass="form-control" ID="txtpdb" runat="server"></asp:TextBox>
    <br />
    
    <label for="search">Additional Information:</label>&nbsp;<asp:TextBox CssClass="form-control" ID="txtadinf" runat="server"></asp:TextBox>
    <br />

    <label for="search">Reference:</label>&nbsp;<asp:TextBox CssClass="form-control" ID="txtref" runat="server"></asp:TextBox>
    <br />

  </div>
    <asp:Button ID="btnsave" CssClass="btn-warning" runat="server" Text="Save" OnClick="btnsave_Click"/>      
    <asp:Button ID="btnreturn" CssClass="btn-info" runat="server" Text="Return" PostBackUrl="admcp.aspx"/>

</center>
</form>


</asp:Content>

