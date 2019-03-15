<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="navustcontrol.ascx.cs" Inherits="sd.navustcontrol" %>

<ul class="ustNavUl">
    <li><asp:HyperLink ID="LinkAnasayfa" runat="server" NavigateUrl="~/default.aspx">AnaSayfa</asp:HyperLink></li>
    <li><asp:HyperLink ID="LinkSinema" runat="server" NavigateUrl="~/Sinema.aspx">Sinema</asp:HyperLink></li>    
    <li><asp:HyperLink ID="Linkİletisim" runat="server" NavigateUrl="~/iletisim.aspx">İletisim</asp:HyperLink></li>    
</ul>