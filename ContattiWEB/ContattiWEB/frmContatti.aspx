<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="frmContatti.aspx.cs" Inherits="ContattiWEB.frmContatti" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>ContattiWEB - Nicola Amadei 2016</title>
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
        .auto-style1 {
            width: 360px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
            <h1 class="titolo">ContattiWEB - Nicola Amadei 2016</h1>
        <center>
            <table border="1">
                <tr>
                    <td>
                        <asp:Label ID="lblQuery" runat="server" Text="Query a manona:"></asp:Label>
                    </td>
                    <td class="auto-style1">
                        <asp:TextBox ID="txtQuery" runat="server" Height="122px" TextMode="MultiLine" Width="354px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="Label1" runat="server" Text="Scelta:"></asp:Label>
                    </td>
                    <td class="auto-style1">                                                  
                    <asp:DropDownList ID="ddlScelta" runat="server">
                            <asp:ListItem>Tutte le chiamate</asp:ListItem>
                            <asp:ListItem>Ultime 15 chiamate</asp:ListItem>
                            <asp:ListItem>Ultime 5 a persone simpatiche</asp:ListItem>
                            <asp:ListItem>Ultime 5 a persone antipatiche</asp:ListItem>
                    </asp:DropDownList>                    
                    </td>
                </tr>
                <tr>
                    <td align="center" colspan="2">
                        <asp:Button ID="btnEsegui" runat="server" Text="Esegui" OnClick="btnEsegui_Click" Width="150"/>  
                    </td>
                </tr>             
            </table>                      
            <br />
            <br />
            <asp:Image ID="imgStato" runat="server" ImageUrl="~/Images/wait.png" />
            <br />
            <asp:GridView ID="gvTabella" runat="server" Height="169px" Width="320px">
            </asp:GridView>
             </center>  
        </div>
    </form>
</body>
</html>
