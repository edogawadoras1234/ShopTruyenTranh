<%@ Page Title="Chi Tiết" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ChiTietTruyen.aspx.cs" Inherits="ShopTruyenTranh.ChiTietSach" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
     <div style="margin-top:100px">
    <asp:FormView ID="bookList" runat="server" ItemType="ShopTruyenTranh.Models.TruyenTranh" SelectMethod ="GetDetails" RenderOuterTable="false">
 <ItemTemplate >
 <div >
 <h1><%#:Item.TenTruyen %></h1>
 </div>
 <br />
 <table>
 <tr>
 <td>
 <img src="/Images/<%#:Item.HinhAnh %>"
 style="border:solid; height:225px" alt="<%#:Item.TenTruyen %>"/>
 </td>
 <td>&nbsp;</td>
 <td style="vertical-align: top; text-align:left;">
 <b>Mô tả sách:</b><br /><%#:Item.MoTa %>
 <br />
 <span><b>Giá:</b>&nbsp;<%#: String.Format("{0:c}",Item.GiaTruyen)%></span>
 <br />
 <span><b>Mã sách:</b>&nbsp;<%#:Item.MaTruyen %></span>
 <br />
 <br />
 </td>
 </tr>
 </table>
 </ItemTemplate>
 </asp:FormView>
        </div>
</asp:Content>
