<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Cadastro.aspx.cs" MasterPageFile="~/Site.Master" Inherits="WebApplication3.WebForm1" %>

<asp:Content ID="Content" ContentPlaceHolderId="Content" runat="server">
        <asp:Panel ID="pnlLista" runat="server">
            <asp:Button ID="BtnInserir" runat="server" OnClick="BtnInserir_Click" Text="Inserir"  />
             <hr />
                <asp:GridView ID="GridViewUsuarios" runat="server" OnRowCommand="GridViewUsuarios_RowCommand">
                    <Columns>
                        <asp:TemplateField>
                            <ItemTemplate>
                                <asp:Button ID="btnAlterar" runat="server"
                                    CommandName="Alterar"
                                    CommandArgument="<%# ((GridViewRow) Container).RowIndex %>"
                                    Text="Atualiza" />
                                <asp:Button ID="btnExcluir" runat="server"
                                  CommandName="Excluir"
                                  CommandArgument="<%# ((GridViewRow) Container).RowIndex %>"
                                  Text="Excluir" />
                            </ItemTemplate>
                        </asp:TemplateField>
                    </Columns>
                </asp:GridView>           
        </asp:Panel>
        
        <hr />
</asp:Content>
