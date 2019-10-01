<%@ Page Title="Danh Sách Truyện" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Danhsach.aspx.cs" Inherits="ShopTruyenTranh.DanhSach" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
     <body style="background-image:url(../Images/backg.png)"> 
      <section style="margin-top:100px">
         <div>
         <hgroup>
         <h2><%: Page.Title %></h2>
         </hgroup>
         <asp:ListView ID="bookList" runat="server" DataKeyNames="MaTruyen" GroupItemCount="4" ItemType="ShopTruyenTranh.Models.TruyenTranh" SelectMethod="GetBooks">
         <EmptyDataTemplate>
             <table >
                 <tr>
                     <td>Không tìm thấy truyện</td>
                 </tr>
             </table>
         </EmptyDataTemplate>
         <EmptyItemTemplate>
         <td/>
         </EmptyItemTemplate>
         <GroupTemplate>
             <tr id="itemPlaceholderContainer" runat="server">
             <td id="itemPlaceholder" runat="server"></td>
          </tr>
         </GroupTemplate>
         <ItemTemplate>
              <td runat="server">
                  <table>
                     <tr>
                     <td>
                         <a href="ChiTietTruyen.aspx?MaTruyen=<%#:Item.MaTruyen%>">
                         <img src ="/Images/<%#:Item.HinhAnh%>" width="150" height="225" style="border:solid" /></a>
                    </td>
                     </tr>
             <tr>
          <td>
         <a href="Danhsach.aspx?bookID=<%#:Item.MaTruyen%>">
         <span>
         <%#:Item.TenTruyen%>
             </span>
             </a>
             <br />
             <span>
         <b>Giá: </b><%#:String.Format("{0:c}",Item.GiaTruyen)%>
          </span>

             <br />
              <a href="AddToCart.aspx?bookID=<%#:Item.MaTruyen%>">
     <span>
         <b>Thêm vào giỏ sách<b>
            </span>
             </a>
        
             </td>
             </tr>
            <tr>
         <td>&nbsp;</td>
         </tr>
         </table>
         </p>
         </td>
         </ItemTemplate>
         <LayoutTemplate>
                  <table style="width:100%;">
                  <tbody>
                      <tr>
                      <td>
                          <table id="groupPlaceholderContainer" runat="server" style="width:100%">
                            <tr id="groupPlaceholder"></tr>
                     </table>
              </td>
                 </tr>
                 <tr>
             <td></td>
             </tr>
         <tr></tr>
         </tbody>
         </table>
         </LayoutTemplate>
         </asp:ListView>
         </div>
         </section>
        </body>
</asp:Content>
