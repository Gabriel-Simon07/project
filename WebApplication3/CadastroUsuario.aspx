<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CadastroUsuario.aspx.cs" MasterPageFile="~/Site.Master" Inherits="WebApplication3.CadastroUsuario" %>

<asp:Content ID="Content" ContentPlaceHolderId="Content" runat="server">
        <div>
            <asp:Panel ID="pnlCadastro" runat="server">
                <asp:Label ID="lblOperacao" runat="server" Text="Operacao"></asp:Label>
                
                <table ID="tblCadastro" runat="server">
                    <tr>
                        <td>
                            <asp:Label ID="LabelId" runat="server" Text="ID" Visible="false"></asp:Label>
                        </td>
                        <td>
                            <asp:TextBox ID="inputId" runat="server" ReadOnly="true" Visible="false"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Label ID="LabelNome" runat="server" Text="Nome"></asp:Label>
                        </td>
                        <td>
                            <asp:TextBox ID="inputUsuarioNome" runat="server"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        
                        <td>
                            <asp:Label ID="LabelEmail" runat="server" Text="Email"></asp:Label>
                        </td>
                        <td>
                            <asp:TextBox ID="inputUsuarioEmail" runat="server" ></asp:TextBox>                            
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Label ID="LabelLogin" runat="server" Text="Login"></asp:Label>
                        </td>
                        <td>
                            <asp:TextBox ID="inputCadastroLogin" runat="server" ></asp:TextBox>                            
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Label ID="LabelSenha" runat="server" Text="Senha"></asp:Label>
                        </td>
                        <td>
                            <asp:TextBox ID="inputCadastroSenha" type="password" runat="server" ></asp:TextBox>                            
                        </td>
                    </tr>
                </table>
                 <hr />
                <asp:Button ID="btnIncluir" runat="server" Text="Incluir" OnClick="BtnIncluir_Click" />
                <asp:Button ID="btnAtualiza" runat="server" Text="Atualizar" OnClick="BtnAtualizar_Click" />
                <asp:Button ID="btnExcluir" runat="server" Text="Excluir" OnClick="BtnExcluir_Click" />
            </asp:Panel>
        </div>

</asp:Content>
