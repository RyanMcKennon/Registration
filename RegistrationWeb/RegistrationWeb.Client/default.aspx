<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Site1.Master" CodeBehind="default.aspx.cs" Inherits="RegistrationWeb.Client._default" %>


<asp:Content runat="server" ContentPlaceHolderID="head">
</asp:Content>

<asp:Content runat="server" ContentPlaceHolderID ="body">
    
    <div>Choose your poison</div>
    
    <div>
        <asp:Button runat="server" ID="studentView" Text="Student Please" Postbackurl="~/StudentView.aspx" />
        <asp:Button runat="server" ID="registrarView" Text="Registrar Please" PostBackurl="~/RegistrarView.aspx" />
    </div>
</asp:Content>
