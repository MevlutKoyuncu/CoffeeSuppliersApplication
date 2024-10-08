<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="CoffeeSuppliersApplication.AdminPanel.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Aksaray Kahvecisi Yönetici Paneli</title>
    <link href="CSS/LoginStyle.css" rel="stylesheet" />
    <meta name="robots" content="noindex, nofollow" />
</head>
<body>
    <form id="form1" runat="server">
        <div class="mainpanel">
            <h1>Yönetici Paneli Giriş</h1>
            <label>MAİL İLE GİRİŞ YAPIN</label>
            <asp:TextBox ID="tb_mail" runat="server" CssClass="mailKutu" placeholder="mail@mail.com"></asp:TextBox>
        </div>

    </form>
</body>
</html>
