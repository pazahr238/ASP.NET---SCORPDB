<%@ Page Title="Edit the details of a peptide" Language="C#" MasterPageFile="~/Template/MasterPage.master" AutoEventWireup="true" CodeFile="editpeptide.aspx.cs" Inherits="editpeptide" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

     <form id="form1" runat="server">
        <center>
 <%-- <div class="form-group col-md-6 div-border">--%>

    <%--<label for="search">Peptide name: (You must enter all fields)</label>&nbsp;<asp:TextBox CssClass="form-control" ID="txtpname" runat="server"></asp:TextBox>
    <br />--%>

    <%--<label for="search">Source:</label>&nbsp;<asp:TextBox CssClass="form-control" ID="txtsource" runat="server"></asp:TextBox>--%>
      <%--<button type="submit" class="btn btn-primary" onclick="SSearch.aspx">Search</button>--%>

    <%--<label for="search">Sequence:</label>&nbsp;<asp:TextBox CssClass="form-control" ID="txtsequence" runat="server"></asp:TextBox>
    <br />--%>
      
<%--  </div>--%>

  <%--<button type="submit" class="btn btn-primary" onclick="SSearch.aspx">Search</button>--%>
  <%--<asp:Button ID="btnsearch" CssClass="btn-primary" runat="server" Text="Search" OnClick="btnsearch_Click" />--%>   

<br />
     <%--     <asp:Label CssClass="form-control text-danger" ID="lblmsg" runat="server" Text="Not found!" Visible="False"></asp:Label>

            
<br />--%>
    
    <%--<asp:Button ID="btnsave" CssClass="btn-warning" runat="server" Text="Save" OnClick="btnsave_Click"/>--%>      
    <asp:Button ID="btnreturn" CssClass="btn-info" runat="server" Text="Return" PostBackUrl="admcp.aspx"/>

            <asp:SqlDataSource ID="SqlDSPeptide" runat="server" ConnectionString="<%$ ConnectionStrings:ajumst %>" SelectCommand="SELECT * FROM [peptides]" UpdateCommand="UPDATE peptides SET [pname]=@pname, [source]=@source, [activity]=@activity, [therapy]=@therapy, [seq]=@seq, [length]=@length, [uniprot]=@uniprot, [pdbid]=@pdbid, [addinf]=@addinf, [ref]=@ref WHERE [uniprot]=@uniprot"></asp:SqlDataSource>

            <br />
            <asp:GridView ID="gv" runat="server" AutoGenerateColumns="False" AutoGenerateEditButton="True" CellPadding="4" DataSourceID="SqlDSPeptide" ForeColor="#333333" GridLines="None">
                <AlternatingRowStyle BackColor="White" />
                <Columns>
                    <asp:BoundField DataField="pname" HeaderText="pname" SortExpression="pname" />
                    <asp:BoundField DataField="source" HeaderText="source" SortExpression="source" />
                    <asp:BoundField DataField="activity" HeaderText="activity" SortExpression="activity" />
                    <asp:BoundField DataField="therapy" HeaderText="therapy" SortExpression="therapy" />
                    <asp:BoundField DataField="seq" HeaderText="seq" SortExpression="seq" />
                    <asp:BoundField DataField="length" HeaderText="length" SortExpression="length" />
                    <asp:BoundField DataField="uniprot" HeaderText="uniprot" SortExpression="uniprot" />
                    <asp:BoundField DataField="pdbid" HeaderText="pdbid" SortExpression="pdbid" />
                    <asp:BoundField DataField="addinf" HeaderText="addinf" SortExpression="addinf" />
                    <asp:BoundField DataField="ref" HeaderText="ref" SortExpression="ref" />
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

</center>
</form>


</asp:Content>

