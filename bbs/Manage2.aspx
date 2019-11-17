<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" ValidateRequest="false"  CodeFile="Manage2.aspx.cs" Inherits="bbs_List" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
 

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

    <table width="99%" height="100%" align="center" style="border:2px solid #D6F2FE;">
        <tr><td height="28" style="background-color:#D6F2FE;">
            <b style="color:#4F98C6; font-size:12px;vertical-align:middle;">&nbsp;&nbsp;话题列表</b>
            </td></tr>
            <tr>
                <td>
<table style="height:100%; min-height:500px;"><tr><td valign="top">
    

 <table style="width:100%;">
    <tr>
        <td align="center">
            <strong> 话题标题:</strong><asp:TextBox ID="txt_title" runat="server" width="150"></asp:TextBox>

    <asp:Button ID="Button1" runat="server" Text="查 找"  class="btn"   onclick="btnSearch_Click" />

        </td>
    </tr>
    <tr>
        <td>
              <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="bid" Width="100%"  AllowPaging="True" GridLines="None"   onpageindexchanging="GridView1_PageIndexChanging">
        <RowStyle Height="25px" HorizontalAlign="Center" />
        <Columns>       
                 
            <asp:BoundField HeaderText="话题标题" DataField="title" />
            <asp:TemplateField HeaderText="话题内容">
            <ItemTemplate>
            <%# StringHelper.SubStringHtml( Eval("memo").ToString(),20) %>
            </ItemTemplate>
            </asp:TemplateField>
            <asp:BoundField HeaderText="发布时间" DataField="atime" />
            <asp:HyperLinkField   DataNavigateUrlFormatString="View2.aspx?id={0}" DataNavigateUrlFields="bid" HeaderText="详情" Text="详情"  >
                <ItemStyle Width="50px" />
            </asp:HyperLinkField>
               
        </Columns>
        <HeaderStyle Height="27px" />
        <PagerStyle HorizontalAlign="Center" />
    </asp:GridView>

            
            

        </td>
    </tr>
</table>
 

    </td></tr></table>
                </td>
            </tr></table>

</asp:Content>


