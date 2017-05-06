<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AESClient.aspx.cs" Inherits="Cryptography.WebClient.AESClient" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <table>
            <tr>
                <td><asp:Label ID="lblPlainText" runat="server" Text="Plain Text: " /></td>
                <td><asp:TextBox ID="txtPlainText" runat="server" Width="260px" /></td>
                <td><asp:Button ID="Button1" runat="server" Text="Generate Process" OnClick="Button1_Click" /></td>
            </tr>
            <tr>
                <td><asp:Label ID="lblPrivateKey" runat="server" Text="Private Key: " /></td>
                <td><asp:TextBox ID="txtPrivateKey" runat="server" Width="260px" /></td>
            </tr>
            <tr>
                <td><asp:Label ID="lblEncryptText" runat="server" Text="Encrypted Text: " /></td>
                <td><asp:TextBox ID="txtEncryptText" runat="server" Width="260px" /></td>
            </tr>
            <tr>
                
                <td><asp:Label ID="lblDecryptText" runat="server" Text="Decrypted Text: " /></td>
                <td><asp:TextBox ID="txtDecryptText" runat="server" Width="260px"/></td>
            </tr>
        </table>
        <br />
        <asp:TextBox ID="txtAesLog" runat="server" TextMode="MultiLine" Width="500px" Height="800px"/>
    </div>
    </form>
</body>
</html>
