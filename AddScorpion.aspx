<%@ Page Title="Add a new scorpion" Language="C#" MasterPageFile="~/Template/MasterPage.master" AutoEventWireup="true" CodeFile="AddScorpion.aspx.cs" Inherits="AddScorpion" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

      <form id="form1" runat="server">
        
       <center>
 
            <div class="form-group font-weight-bold">
                <asp:Label ID="lblmsg" runat="server" ForeColor="#006600" Text="Successfully added!" Visible="False"></asp:Label>
                <br />
            Please enter the details of the scorpion
            </div>
        
 <div style="direction:ltr" class="col-md-6 div-border">
        <div class="form-group ">
            Family<asp:TextBox ID="txtfamily" runat="server" cssclass="form-control text-center"></asp:TextBox>
      </div>

        <div class="form-group">
            Genus<label> </label>
      <asp:TextBox ID="txtgenus" runat="server" cssclass="form-control text-center"></asp:TextBox>
  </div>

        <div class="form-group">
            <label>Species</label>
            <asp:TextBox ID="txtspecies" runat="server" cssclass="form-control text-center"></asp:TextBox>
        </div>

  <div class="form-group">
    <label class="form-control border-0">Country</label>
    <asp:TextBox ID="txtcountry" runat="server" cssclass="form-control text-center"></asp:TextBox>
  </div>
  
      <div class="form-group">
         <label class="form-control border-0">Location</label>
         <asp:TextBox ID="txtLocation" runat="server" cssclass="form-control text-center" TextMode="MultiLine"></asp:TextBox>
      </div>

      <div class="form-group">
         <label class="form-control border-0">Reproduction</label>
         <asp:TextBox ID="txtReproduction" runat="server" cssclass="form-control text-center" TextMode="MultiLine"></asp:TextBox>
      </div>

      <div class="form-group">
         <label class="form-control border-0">Feed</label>
         <asp:TextBox ID="txtFeed" runat="server" cssclass="form-control text-center" TextMode="MultiLine"></asp:TextBox>
      </div>

      <div class="form-group">
         <label class="form-control border-0">Injury</label>
         <asp:TextBox ID="txtInjury" runat="server" cssclass="form-control text-center" TextMode="MultiLine"></asp:TextBox>
      </div>

      <div class="form-group">
         <label class="form-control border-0">Image</label>
         <asp:FileUpload ID="fu" runat="server" />
      </div>    
 </div>

  <asp:Button type="button" class="btn btn-info" runat="server" Text="Return" PostBackUrl="admcp.aspx"></asp:Button>
  <asp:Button type="submit" class="btn btn-primary" runat="server" Text="Add Scorpion" ></asp:Button>
<br />

    
    
  
    
    </center>
   
</form>


</asp:Content>

