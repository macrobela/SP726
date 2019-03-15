<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="iletisim.aspx.cs" Inherits="sd.iletisim" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
       <style>
        body{
            background-color:honeydew;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <section class="img_sections">
        <img src="IMG/iletisim.png" alt="iletisim Görsel" /> 
    </section>
    <input id="ad" type="text" />
    <input id="email" type="email" />
    <textarea id="mesaj"></textarea>
    <button type="submit">Gönder</button>
</asp:Content>
