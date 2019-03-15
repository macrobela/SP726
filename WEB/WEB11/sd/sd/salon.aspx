<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="salon.aspx.cs" Inherits="sd.salon" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <section>

        <asp:DataList ID="DataList_salon" runat="server" OnCancelCommand="DataList_salon_CancelCommand" OnDeleteCommand="DataList_salon_DeleteCommand" OnEditCommand="DataList_salon_EditCommand" OnUpdateCommand="DataList_salon_UpdateCommand">

            <HeaderTemplate>
                <table border="1">
            </HeaderTemplate>
            <ItemTemplate>
                <tr>
                    <td><%# Eval("SalonID")%></td>
                    <td><%# Eval("SalonAdi")%></td>
                    <td>
                        <asp:LinkButton ID="btn_SalonGuncelle" runat="server" CommandName="Edit">Güncelle</asp:LinkButton>
                    </td>

                     <td> 
                         <asp:LinkButton ID="btn_SalonSil" runat="server" CommandName="Delete" CommandArgument='<%# Eval("SalonID") %>'>Sil</asp:LinkButton>
                    </td>
                </tr>
            </ItemTemplate>
            <EditItemTemplate>
                    <td>
                        <asp:TextBox ID="txt_Guncelle_ID" runat="server" Text='<%# Eval("SalonID")%>'></asp:TextBox>    
                    </td>

                    <td>   
                        <asp:TextBox ID="txt_Guncelle_SalonAdi" runat="server" Text='<%# Eval("SalonAdi")%>'></asp:TextBox>   
                    </td>
                <td>
                    <asp:LinkButton ID="LinkButton1" runat="server" CommandName="Update" CommandArgument='<%# Eval("SalonID") %>'> >Kaydet</asp:LinkButton>
                </td>

                <td>
                    <asp:LinkButton ID="LinkButton2" runat="server" CommandName="Cancel">İptal</asp:LinkButton>
                </td>

            </EditItemTemplate>
            <FooterTemplate></table></FooterTemplate>
        </asp:DataList>

        <section class="salon_kaydet">

        <asp:TextBox ID="txt_salonAd" runat="server"></asp:TextBox>


        <asp:Button ID="btn_SalonKaydet" runat="server" Text="Salon Kaydet" OnClick="btn_SalonKaydet_Click"></asp:Button>
        </section>


    </section>



</asp:Content>

