<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="wfrmMain.aspx.cs" Inherits="PortaleQuery.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .titolo {
            font-weight: normal;
            color: #1E90FF;
            letter-spacing: 1pt;
            word-spacing: 2pt;
            font-size: 41px;
            text-align: center;
            font-family: trebuchet MS, sans-serif;
            line-height: 1;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1 class="titolo">QueryWEB - Nicola Amadei 2016</h1>
            <table border="1">
                <tr>
                    <td>
                        <asp:Label ID="lblQuery" runat="server" Text="Query: "></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="txtQuery" runat="server" Height="122px" TextMode="MultiLine" Width="354px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="Label1" runat="server" Text="Parametro 1"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="txtP1" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="Label2" runat="server" Text="Parametro 2"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="txtP2" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="Label3" runat="server" Text="Parametro 3"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="txtP3" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="Label4" runat="server" Text="Parametro 4"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="txtP4" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="Label5" runat="server" Text="Parametro 5"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="txtP5" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="Label6" runat="server" Text="Parametro 6"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="txtP6" runat="server"></asp:TextBox>
                    </td>
                </tr>
            </table>
            <br />
            <asp:Button ID="btnEsegui" runat="server" Text="Esegui" OnClick="btnEsegui_Click" Width="164px" />            
            <br />
            <br />
            <asp:Image ID="imgStato" runat="server" ImageUrl="~/Images/wait.png" />
            <br />
            <asp:GridView ID="gvTabella" runat="server" Height="169px" Width="320px">
            </asp:GridView>
        </div>
    </form>
</body>
</html>
