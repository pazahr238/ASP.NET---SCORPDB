<%@ Page Title="Search for the Scorpions" Language="C#" MasterPageFile="~/Template/MasterPage.master" AutoEventWireup="true" CodeFile="SSearch.aspx.cs" Inherits="SSearch" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

     <form id="form1" runat="server">
        <center>
            <br />
            <div class="col-md-6 text-center justify-content-center">Pictures of some scorpions living in Iran have been taken by Dr. Fatemeh Salabi and Mr. Mohammad Hossein Jahan-Mahin. The rest were mainly retrieved from the websites <a href="https://guatemala.inaturalist.org" target="_blank">iNaturalistGT</a> and <a href="https://www.gbif.org" target="_blank">GBIF</a>, and in some cases taken from articles which described those scorpion species. The related article/s will be sent to the user upon request.</div>
  <div class="form-group col-md-6 div-border">

    <label for="search">Family:</label>&nbsp;<asp:DropDownList CssClass="form-control" ID="drpfamily" runat="server" AutoPostBack="True" OnSelectedIndexChanged="drpfamily_SelectedIndexChanged">
      </asp:DropDownList>

    <br />
      
    <label for="search">Genus:</label>
    <asp:DropDownList CssClass="form-control" ID="drpgenus" runat="server" AutoPostBack="True" OnSelectedIndexChanged="drpgenus_SelectedIndexChanged"></asp:DropDownList>

    <br />

    <label for="search">Species</label>
    <asp:DropDownList CssClass="form-control" ID="drpspecies" runat="server" AutoPostBack="True"></asp:DropDownList>
  
  </div>

  <button type="submit" class="btn btn-primary" onclick="SSearch.aspx">Search</button>
<br />

          <div class="col-md-6 div-border">
            <asp:Label CssClass="text-danger border-0" ID="lbltik" runat="server" Text="To see the details of each scorpion, please click on " Visible="False"></asp:Label>
              <asp:Image ID="imgtik" runat="server" Visible="False" Height="20px" ImageUrl="~/pic/ok.png" Width="20px"/>
          <asp:Label CssClass="form-control text-danger" ID="lblmsg" runat="server" Text="Not found!" Visible="False"></asp:Label>

            <asp:GridView ID="gv" runat="server" CellPadding="4" ForeColor="#333333" GridLines="None" OnSelectedIndexChanging="gv_SelectedIndexChanging" OnDataBinding="gv_DataBinding">
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

   <div class="col-md-8 div-border">
        <asp:Image ID="imgscorpion" Width="50%" runat="server" />
        <br />
    
   <div class="container mt-3">
    <table class="table table-hover text-justify">
    <thead>
      <tr>
        <th class="text-center">Sting Symptoms</th>
        <!-- <th>Reproduction</th> -->
        <!-- <th>Feed</th> -->
        <th class="text-center">Behavior and Personality</th>
        <th class="text-center">Reference/s</th>
      </tr>
    </thead>
    <tbody>
      <tr>
        <td style="width:33%"><asp:Label ID="lbllocation" runat="server"></asp:Label></td>
        <!-- <td><asp:Label ID="lblreproduction" runat="server"></asp:Label></td>  -->
        <!-- <td><asp:Label ID="lblfeed" runat="server"></asp:Label></td> -->
        <td style="width:33%"><asp:Label ID="lblinjury" runat="server"></asp:Label></td>
        <td style="width:33%"><asp:Label ID="lblreference" runat="server"></asp:Label></td>
      </tr>  
    </tbody>
    </table>
    </div>
    </div>
</center>
</form>

</asp:Content>

