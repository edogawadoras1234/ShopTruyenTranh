﻿<%@ Page Title="Đăng Kí" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Dangki.aspx.cs" Inherits="ShopTruyenTranh.About" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
     <body> 
    <div style="margin-top:120px;">
    <h2><%: Title %></h2>
        <style type="text/css">
    .auto-style1 {
        width: auto;
    }
    .auto-style3 {
        height: 23px;
    }
    .auto-style6 {
        height: 24px;
        width: 229px;
    }
    .auto-style7 {
        height: 23px;
        width: auto;
    }
    .auto-style17 {
        height: 18px;
        width: 229px;
    }
    .auto-style22 {
        height: 26px;
        width: auto;
    }
    .auto-style23 {
        height: 6px;
        width: 229px;
    }
    .auto-style24 {
        height: 23px;
        width: auto;
    }
    .auto-style25 {
        width: auto;
    }
    .auto-style26 {
        height: 24px;
        width: auto;
    }
    .auto-style27 {
        height: 18px;
        width: auto;
    }
    .auto-style31 {
        width: 229px;
    }
    .auto-style32 {
        height: 23px;
        width: 174px;
    }
    .auto-style33 {
        height: 6px;
        width: 174px;
    }
    .auto-style34 {
        width: 174px;
    }
    .auto-style35 {
        height: 24px;
        width: 174px;
    }
    .auto-style36 {
        height: 18px;
        width: 174px;
    }
    </style>

   <div id="TableWrapper">
<table class="auto-style1" runat="server" id="FormTable">
    <tr>
        <td class="auto-style24">
            <p style="width: 127px">Tên</p>
        </td>
        <td class="auto-style32">
            <asp:TextBox ID="Name" runat="server" BackColor="White" BorderColor="Black" BorderStyle="Solid" BorderWidth="1px" ForeColor="Black" Height="18px"></asp:TextBox>
        </td>
        <td class="auto-style7">
            <asp:Label ID="ten" runat="server" Text="Nhập&nbsp;tên" CssClass="ErrorMessage" Visible ="False" BorderStyle="None"></asp:Label>         
        </td>
    </tr>
    <tr>
        <td class="auto-style22">
            <p style="width: 178px">Tài khoản email</p>
        </td>
        <td class="auto-style33">
            <asp:TextBox ID="EmailAddress" runat="server" BackColor="White" BorderColor="Black" BorderStyle="Solid" BorderWidth="1px" ForeColor="Black"></asp:TextBox>
        </td>
        <td class="auto-style23">
            <asp:Label ID="email" runat="server" Text="Nhập&nbsp;Email" CssClass="ErrorMessage" Visible ="False" BorderStyle="None"></asp:Label>
           </td>
    </tr>  
    <tr>
        <td class="auto-style26">
            <p style="width: 157px">Mật Khẩu</p>
        </td>
        <td class="auto-style35">
            <asp:TextBox ID="Password" runat="server" BackColor="White" BorderColor="Black" BorderStyle="Solid" BorderWidth="1px" ForeColor="Black"></asp:TextBox>
        </td>
        <td class="auto-style6">
        <asp:Label ID="mk" runat="server" Text="Nhập mật khẩu" CssClass="ErrorMessage" Visible ="false"></asp:Label>    
        </td>
    </tr>
    <tr>
        <td class="auto-style26">
           <p style="width: 168px">Địa chỉ</p>           
        </td>
        <td class="auto-style35">
            <asp:TextBox ID="DiaChi" runat="server" BackColor="White" BorderColor="Black" BorderStyle="Solid" BorderWidth="1px" ForeColor="Black"></asp:TextBox>
        </td>
        <td class="auto-style6"><asp:Label ID="xndc" runat="server" Text="Nhập&nbsp;Địa&nbsp;Chỉ" CssClass="ErrorMessage" Visible ="false"></asp:Label>    
        </td>
    </tr>
    <tr>
        <td>

        </td>
        <td>
            <asp:Button runat="server" OnClick="dangki_onClick" Text="Đăng Kí"/>
        </td>
    </tr>
    <tr>
        <td>

        </td>
        <td>
            <asp:Label ID="Label1" runat="server" Text=""></asp:Label>
        </td>
    </tr>
</table>
        </div>
        </body>
</asp:Content>