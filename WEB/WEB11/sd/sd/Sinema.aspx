<%@ Page Title="Sinema" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Sinema.aspx.cs" Inherits="sd.Sinema" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <section>

        <asp:DataList ID="DataList_Filmler" runat="server" OnDeleteCommand="DataList_Filmler_DeleteCommand" OnCancelCommand="DataList_Filmler_CancelCommand" OnUpdateCommand="DataList_Filmler_UpdateCommand" OnEditCommand="DataList_Filmler_EditCommand">

            <HeaderTemplate>
                <table border="1">
            </HeaderTemplate>
            <ItemTemplate>
                
                    <%# Eval("FilmID") %>
                    <td><%# Eval("FilmAdi") %></td>
                    <td><%# Eval("FilmKisaBilgi") %></td>
                    <td><%# Eval("FilmFragmanLink") %></td>
                    <td>
                        <asp:LinkButton ID="btn_Guncelle" runat="server" CommandName="Edit">Güncelle</asp:LinkButton>
                    </td>

                     <td>
                        <asp:LinkButton ID="btn_Sil" runat="server" CommandName="Delete" CommandArgument='<%# Eval("FilmID") %>'>Sil</asp:LinkButton>
                    </td>

               
            </ItemTemplate>
            <EditItemTemplate>
                <tr>
                    <td><asp:TextBox ID="txt_Guncelle_FilmID" runat="server" ReadOnly="true" Text='<%# Eval("FilmID") %>'></asp:TextBox></td>
                    <td><asp:TextBox ID="txt_Guncelle_FilmAdi" runat="server" Text='<%# Eval("FilmAdi") %>'></asp:TextBox></td>
                    <td><asp:TextBox ID="txt_Guncelle_FilmKisaBilgi" runat="server" Text='<%# Eval("FilmKisaBilgi") %>'></asp:TextBox></td>
                    <td><asp:TextBox ID="txt_Guncelle_FilmFragmanLink" runat="server" Text='<%# Eval("FilmFragmanLink") %>'></asp:TextBox></td>
                   
                    <td><asp:LinkButton ID="LinkButton1" runat="server" CommandName="Update" CommandArgument='<%# Eval("FilmID") %>'>Kaydet</asp:LinkButton></td>
                     <td>
                        <asp:LinkButton ID="LinkButton2" runat="server" CommandName="Cancel">İptal</asp:LinkButton>
                    </td>
                </tr>
                
            </EditItemTemplate>
          
            

      


            <FooterTemplate></table></FooterTemplate>

        </asp:DataList>
        <section class="film_kaydet">


            <asp:TextBox ID="txt_filmAd" runat="server"></asp:TextBox>
            <asp:TextBox ID="txt_FilmFragman" runat="server"></asp:TextBox>
            <asp:TextBox ID="txt_Filmkisabilgi" runat="server"></asp:TextBox>


            <asp:Button ID="btn_FilmKaydet" runat="server" Text="Film Kaydet" OnClick="btn_FilmKaydet_Click"></asp:Button>

        </section>









    </section>
</asp:Content>

