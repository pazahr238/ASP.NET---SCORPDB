<%@ Page Title="Search for the Peptides" Language="C#" MasterPageFile="~/Template/MasterPage.master" AutoEventWireup="true" CodeFile="SPSearch.aspx.cs" Inherits="SPSearch" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    
   
    <center>
    <form id="form1" runat="server">
        <div class="form-group col-md-6 div-border">
            Peptide Name<label for="search">:</label>&nbsp;
            
            <asp:TextBox CssClass="form-control" ID="txtpepname" runat="server"></asp:TextBox>
            
            <br />
            Source Scorpion<label for="search">:</label>
            <asp:DropDownList CssClass="form-control" ID="drpsource" runat="server" AutoPostBack="True" OnSelectedIndexChanged="drpsource_SelectedIndexChanged">
            </asp:DropDownList>
            <br />
            Activity:
            <asp:DropDownList CssClass="form-control" ID="drpactivity" runat="server" AutoPostBack="True">
            </asp:DropDownList>
            <%--<br />--%>
            <%--Therapeutic Potential:--%>
            <asp:DropDownList CssClass="form-control" ID="drppotential" runat="server" AutoPostBack="True" Visible="False">
                <asp:ListItem Selected="True">Yes</asp:ListItem>
                <asp:ListItem>No</asp:ListItem>
                <asp:ListItem>Unknown</asp:ListItem>
            </asp:DropDownList>
        </div>
        <button type="submit" class="btn btn-primary" onclick="SPSearch.aspx">Search</button>
        
        <div class="col-md-6 div-border">
        <asp:Label CssClass="text-danger border-0" ID="lblclicktik" runat="server" Text="To see the details of each peptide, please click on " Visible="False"></asp:Label>
        <asp:Image ID="imgtik" runat="server" Visible="False" Height="20px" ImageUrl="~/pic/ok.png" Width="20px"/>
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
         <div class="container mt-3 col-md-6 div-border">
                <div class="font-weight-bold">Source:</div>
                <div style="font-style:italic"><asp:Label ID="lblsource" runat="server"></asp:Label></div>
             <br />
                <div class="font-weight-bold">Activity:</div>
                <div><asp:Label ID="lblactivity" runat="server"></asp:Label></div>
             <%-- <br />
                <div class="font-weight-bold">Therapeutic:</div>
                <div><asp:Label ID="lbltherapic" runat="server" Visible="False"></asp:Label></div> --%>
             <br />
                <div class="font-weight-bold">Sequence:</div>
                <div style="word-wrap: break-word"><asp:Label ID="lblseq" runat="server"></asp:Label></div>
             <br />
                <div class="font-weight-bold">Length:</div>
                <div><asp:Label ID="lbllength" runat="server"></asp:Label></div>
             <br />
                <div class="font-weight-bold"><span>GenBank Accession Number</span>:</div>
                <div><asp:Label ID="lbluniprot" runat="server"></asp:Label></div>
             <br />
                <div class="font-weight-bold">PDB ID:</div>
                <div><asp:Label ID="lblpdbid" runat="server"></asp:Label></div>
             <br />
                 <div class="font-weight-bold" style="display: none">Additional Info.:</div>
                 <div style="word-wrap: break-word"><asp:Label ID="lbladdinf" runat="server" Visible="False"></asp:Label></div>
             <br />
                <div class="font-weight-bold" style="display: none">Reference:</div>
                <div style="word-wrap: break-word"><asp:Label ID="lblref" runat="server" Visible="False"></asp:Label></div>
             <br />
         </div>

    </form>
    </center>
   
    
</asp:Content>

