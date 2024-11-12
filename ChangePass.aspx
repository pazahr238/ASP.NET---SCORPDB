<%@ Page Title="Change Admin password" Language="C#" MasterPageFile="~/Template/MasterPage.master" AutoEventWireup="true" CodeFile="ChangePass.aspx.cs" Inherits="ChangePass" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    

     <center>
    <form id="form1" runat="server">
        <div class="form-group col-md-6 div-border">
        <asp:Label CssClass="form-control text-primary" ID="Label2" runat="server" Text="New Password:" BorderStyle="None"></asp:Label>
            &nbsp;
            
            <asp:TextBox CssClass="form-control" ID="txtnew" runat="server"></asp:TextBox>
            
            <br />
            <asp:Label CssClass="form-control text-primary" ID="Label1" runat="server" Text="Repeat Password:" BorderStyle="None"></asp:Label>
            &nbsp;
            
            <asp:TextBox CssClass="form-control" ID="txtrepeat" runat="server"></asp:TextBox>
            
            &nbsp;<asp:Label CssClass="form-control text-danger" ID="lblmsg" runat="server" Visible="False" BorderStyle="None"></asp:Label>

            <br />
        </div>
        <button type="submit" class="btn btn-primary" onclick="SPSearch.aspx">Change Password</button>

        <a href="admcp.aspx" class="text-primary">Return</a>
        
        

    </form>
    </center>



</asp:Content>

