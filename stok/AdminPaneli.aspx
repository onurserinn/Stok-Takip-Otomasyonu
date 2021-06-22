<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AdminPaneli.aspx.cs" Inherits="StokTakipOtomasyonu.AdminPaneli" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            font-size: large;
        }
        .auto-style2 {
            font-size: large;
        }
        .auto-style3 {
            width: 100%;
            height: 631px;
        }
        .auto-style4 {
            height: 218px;
        }
        .auto-style5 {
        }
        .auto-style6 {
            height: 30px;
        }
        .auto-style7 {
            height: 30px;
            width: 122px;
        }
        .auto-style8 {
            width: 122px;
        }
        .auto-style10 {
            width: 597px;
            height: 29px;
        }
        .auto-style11 {
            height: 218px;
            width: 600px;
        }
        .auto-style12 {
            width: 83%;
            margin-right: 7px;
            height: 91px;
        }
        .auto-style13 {
            height: 391px;
            width: 597px;
        }
        .auto-style14 {
            height: 391px;
        }
        .auto-style15 {
            width: 122px;
            height: 35px;
        }
        .auto-style16 {
            height: 35px;
            width: 275px;
        }
        .auto-style17 {
            height: 30px;
            width: 171px;
        }
        .auto-style18 {
            height: 29px;
        }
        .auto-style19 {
            height: 30px;
            width: 275px;
        }
        .auto-style20 {
            width: 275px;
        }
        </style>
</head>
<body>
    <form id="form1" runat="server" class="auto-style1">
        <span class="auto-style2"><strong style="background-color: #3366FF"></strong></span><table class="auto-style3">
            <tr>
                <td class="auto-style10" style="background-color: #FFff">
                    <strong>Ürünler</strong></td>
                <td class="auto-style18" style="background-color: #FFff">
                    <strong>Müşteriler</strong></td>
            </tr>
            <tr>
                <td class="auto-style11" style="background-color: #1C61FF">
                    <table class="auto-style5" style="background-color: #1C61FF">
                        <tr>
                            <td class="auto-style7">Ürün Adı:</td>
                            <td class="auto-style19">
                                <asp:TextBox ID="urunAdiTXT" runat="server" Width="239px"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td class="auto-style8">Ürün Açıklama</td>
                            <td class="auto-style20">
                                <asp:TextBox ID="urunAciklamaText" runat="server" Width="237px"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td class="auto-style15">Ürün Fiyat</td>
                            <td class="auto-style16">
                                <asp:TextBox ID="urunFiyatText" runat="server" Width="236px"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td class="auto-style8">
                                <asp:TextBox ID="txtUrunId" runat="server" Width="148px" style="margin-right: 0px">URUN ID</asp:TextBox>
                                <asp:TextBox ID="txtMusteriIadeID" runat="server" Width="146px">MÜŞTERİ ID</asp:TextBox>
                            </td>
                            <td class="auto-style20">
                                <asp:Button ID="urunEkleBTN" runat="server" Font-Bold="True" Text="Ürün Ekle" Width="199px" OnClick="urunEkleBTN_Click" />
                                <asp:Button ID="Button1" runat="server" Font-Bold="True" Text="Güncelle" Width="109px" OnClick="Button1_Click" />
                                <asp:Button ID="Button3" runat="server" Font-Bold="True" OnClick="Button3_Click" Text="Sil" Width="90px" />
                                <asp:Button ID="Button6" runat="server" Font-Bold="True" OnClick="Button6_Click" Text="İade Al" Width="199px" />
                            </td>
                        </tr>
                    </table>
                </td>
                <td class="auto-style4" style="background-color: #1CFFBA">
                    <table class="auto-style12" style="background-color: #1CFFBA">
                        <tr>
                            <td class="auto-style17">Müşteri Adı:</td>
                            <td class="auto-style6">
                                <asp:TextBox ID="musteriAdiText" runat="server" Width="255px"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td class="auto-style17">
                                <asp:Button ID="musteriEkleBTN" runat="server" Font-Bold="True" Text="Müşteri Ekle" Width="165px" OnClick="musteriEkleBTN_Click" />
                            </td>
                            <td class="auto-style6">
                                <asp:TextBox ID="txtMusteriId" runat="server" Width="39px">id</asp:TextBox>
                                <asp:Button ID="Button2" runat="server" Font-Bold="True" Text="Güncelle" Width="121px" OnClick="Button2_Click" />
                                <asp:Button ID="Button4" runat="server" Text="Sil" Width="93px" Font-Bold="True" OnClick="Button4_Click" />
                            </td>
                        </tr>
                        <tr>
                            <td class="auto-style17">
                                Ürün ID:</td>
                            <td class="auto-style6">
                                <asp:TextBox ID="TextBox1" runat="server" Width="39px"></asp:TextBox>
                                <asp:Button ID="Button5" runat="server" Font-Bold="True" OnClick="Button5_Click" Text="Ürünü Sat" Width="121px" />
                            </td>
                        </tr>
                    </table>
                </td>
            </tr>
            <tr>
                <td class="auto-style13" style="background-color: #1CFF42">
                    <asp:Label ID="urunBilgiLabel" runat="server"></asp:Label>
                    <asp:GridView ID="urunGridView" runat="server" Width="438px">
                    </asp:GridView>
                    <asp:SqlDataSource ID="SqlDataSource1" runat="server"></asp:SqlDataSource>
                </td>
                <td class="auto-style14" style="background-color: #FF8D04">
                    <asp:Label ID="musteriBilgiLabel" runat="server"></asp:Label>
                    <asp:GridView ID="musteriGridView" runat="server" Width="495px">
                    </asp:GridView>

                </td>
            </tr>
        </table>
    </form>
</body>
</html>