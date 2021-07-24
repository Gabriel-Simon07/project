<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Logout.aspx.cs" MasterPageFile="~/Site.Master" Inherits="WebApplication3.WebForm2" %>

<asp:Content ID="Content" ContentPlaceHolderId="Content" runat="server">

    
    <asp:Label ID="LabelUsuarioLogado" runat="server" Text="Usuario logado"></asp:Label>
    <hr />
    <asp:Button ID="BtnLogout" runat="server" Text="Logout" OnClick="Logout_Click" />

</asp:Content>

