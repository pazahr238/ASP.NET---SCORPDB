<%@ Page Title="Add a new peptide" Language="C#" MasterPageFile="~/Template/MasterPage.master" AutoEventWireup="true" CodeFile="AddPeptide.aspx.cs" Inherits="AddPeptide" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

    <form id="form1" runat="server">
        
            <center>
        
        
      
      <div class="card-body p-3">
           
            <div class="form-group font-weight-bold">
    <asp:Label ID="lblmsg" runat="server" ForeColor="#006600" Text="Successfully added!" Visible="False"></asp:Label>

                <br />
  <asp:Button type="button" class="btn btn-info" runat="server" Text="Return" PostBackUrl="admcp.aspx" ID="btnreturn"></asp:Button>

                <br />
            Please enter the details of the Peptide
            </div>

     <div style="direction:ltr" class="col-md-6 div-border">
        <div class="form-group mt-3">
            <label> Peptide Name</label>
            <asp:TextBox ID="txtpepname" runat="server" cssclass="form-control text-center"></asp:TextBox>
      </div>

        <div class="form-group mt-3">
            <label> Source</label>
      <asp:TextBox ID="txtsource" runat="server" cssclass="form-control text-center"></asp:TextBox>
       </div>

        <div class="form-group mt-3">
            <label>Activity</label>
            <asp:TextBox ID="txtactivity" runat="server" cssclass="form-control text-center"></asp:TextBox>
        </div>

  <div class="form-group mt-3">
    <label class="form-control border-0">Therapy</label>
       <asp:DropDownList CssClass="form-control" ID="drptherapy" runat="server">
                <asp:ListItem Selected="True">Yes</asp:ListItem>
                <asp:ListItem>No</asp:ListItem>
                <asp:ListItem>Unknown</asp:ListItem>
       </asp:DropDownList>


  </div>
  
      <div class="form-group mt-3">
         <label class="form-control border-0">Sequence</label>
         <asp:TextBox ID="txtseq" runat="server" cssclass="form-control text-center" TextMode="MultiLine"></asp:TextBox>
      </div>

      <div class="form-group mt-3">
         <label class="form-control border-0">Length</label>
         <asp:TextBox ID="txtlength" runat="server" cssclass="form-control text-center"></asp:TextBox>
      </div>

      <div class="form-group mt-3">
         <label class="form-control border-0">UniProt ID</label>
         <asp:TextBox ID="txtuniprot" runat="server" cssclass="form-control text-center"></asp:TextBox>
      </div>

      <div class="form-group mt-3">
         <label class="form-control border-0">PDB ID</label>
         <asp:TextBox ID="txtpdbid" runat="server" cssclass="form-control text-center"></asp:TextBox>
      </div>

      <div class="form-group mt-3">
         <label class="form-control border-0">Additional Information</label>
         <asp:TextBox ID="txtaddinf" runat="server" cssclass="form-control text-center" TextMode="MultiLine"></asp:TextBox>
      </div>

      <div class="form-group mt-3">
         <label class="form-control border-0">Reference</label>
         <asp:TextBox ID="txtref" runat="server" cssclass="form-control text-center" TextMode="MultiLine"></asp:TextBox>
      </div>
</div>

  <asp:Button type="submit" class="btn btn-primary" runat="server" Text="Add Peptide" ID="btnadd" ></asp:Button>
<br />

     
    </div>
  
    
    </center>
   
</form>


</asp:Content>

