<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebApplication3.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div> 
          <table>
                <tr>
                    <td>    
                        <asp:Label ID="LabelNome" runat="server" Text="Nome:"></asp:Label>
                    </td>
                    <td>    
                        <asp:TextBox ID="InputNome" runat="server"></asp:TextBox> 
                    </td>
                </tr>
                <tr>
                    <td>    
                        <asp:Label ID="LabelSobreNome" runat="server" Text="Sobrenome:"></asp:Label>
                    </td>
                    <td>    
                        <asp:TextBox ID="InputSobrenome" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>    
                        <asp:Label ID="LabelTelefone" runat="server" Text="Telefone:"></asp:Label>
                    </td>
                    <td>    
                        <asp:TextBox ID="InpuTelefone" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="LabelDatanasc" runat="server" Text="Data nasc.:" placeholder="dd/mm/yyyy"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="InputDatanasc" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="LabelEmail" runat="server" Text="E-mail:"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="inputEmail" runat="server"></asp:TextBox>            
                    </td>
                </tr>
            </table>
            <asp:Button ID="BtnOK" runat="server" OnClick="BtnOK_Click" style="height: 26px" Text="Processar" />
        </div>

    </form>
</body>
</html>
