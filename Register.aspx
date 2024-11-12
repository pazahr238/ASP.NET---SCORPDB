<%@ Page Title="" Language="C#" MasterPageFile="~/Template/MasterPage.master" AutoEventWireup="true" CodeFile="Register.aspx.cs" Inherits="Register" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">

   

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">



    
    <form id="form1" runat="server">
        
            <center>
        <div style="direction:rtl" class="card border-primary rounded p-3">
            <div class="card-body p-3">
           
        <div class="form-group ">
            Name:
      <asp:TextBox ID="fname" runat="server" cssclass="form-control col-md-4 text-center"></asp:TextBox>
      </div>

        <div class="form-group">
    <label>Last Name:</label>
      <asp:TextBox ID="lname" runat="server" cssclass="form-control col-md-4 text-center"></asp:TextBox>
  </div>

        <div class="form-group">
            <label> Email:</label>
      <asp:TextBox ID="email" runat="server" cssclass="form-control col-md-4 text-center"></asp:TextBox>
  </div>

  <div class="form-group">
      Password<label>:</label>
      <asp:TextBox ID="password" runat="server" cssclass="form-control col-md-4 text-center" type="password"></asp:TextBox>
  </div>
  <%--<button type="button" class="btn btn-info">بازگشت</button>--%>
  <asp:Button type="button" class="btn btn-info" runat="server" Text="Return" PostBackUrl="~/homeft.aspx"></asp:Button>
  <asp:Button type="submit" class="btn btn-primary" runat="server" Text="Register" ></asp:Button>
&nbsp;
    <asp:Label ID="lblmsg" runat="server" ForeColor="#006600" Text="Successfully Registered!" Visible="False"></asp:Label>

     </div>
    </div>
    </center>
   
</form>
  
</asp:Content>

