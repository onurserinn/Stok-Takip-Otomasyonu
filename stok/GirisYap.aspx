<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="GirisYap.aspx.cs" Inherits="StokTakipOtomasyonu.GirisYap" %>

<!DOCTYPE html> 
<html> 
<head>
<meta name="viewport" content="width=device-width, initial-scale=1">
<title> Giriş Sayfası </title>
<style> 
Body {
  font-family: Calibri, Helvetica, sans-serif;
  background-color: turquoise;
}
button { 
       background-color: #4CAF50; 
       width: 100%;
        color: orange; 
        padding: 15px; 
        margin: 10px 0px; 
        border: none; 
        cursor: pointer; 
         } 
 form { 
        border: 3px solid #f1f1f1; 
    } 
 input[type=text], input[type=password] { 
        width: 100%; 
        margin: 8px 0;
        padding: 12px 20px; 
        display: inline-block; 
        border: 2px solid black; 
        box-sizing: border-box; 
    }
 button:hover { 
        opacity: 0.7; 
    }  
      
   
 .container { 
        padding: 25px; 
        background-color: lightblue;
    } 
    .auto-style5 {}
</style> 
</head>  
<body>  
    <center> <h1> Stok Takip Yönetici Giriş Paneli </h1> </center> 
    <form runat="server">
        <div class="container"> 
            <label>Kullanıcı Adı : </label> 
            <asp:TextBox ID="txtKullaniciadi1"  OnTextChanged="TextBox1_TextChanged" runat="server"></asp:TextBox>
            <label>Şifre : </label> 
            <asp:TextBox ID="txtSifre1" runat="server" TextMode="Password"></asp:TextBox>
            <asp:Button type="submit" ID="Button1" runat="server" OnClick="Button1_Click" Text="Giriş Yap" Width="92px" CssClass="auto-style5" />
            <asp:Label ID="girisBilgi" runat="server"></asp:Label>
        </div> 
    </form>   
</body>   
</html>