﻿<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" ValidateRequest="false"  CodeFile="Manage - 复制.aspx.cs" Inherits="foods_List" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
 

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

    <table width="99%" height="100%" align="center" style="border:2px solid #D6F2FE;">
        <tr><td height="28" style="background-color:#D6F2FE;">
            <b style="color:#4F98C6; font-size:12px;vertical-align:middle;">&nbsp;&nbsp;管理膳食搭配信息</b>
            </td></tr>
            <tr>
                <td>
<table style="height:100%; min-height:500px;"><tr><td valign="top">
    

 <table style="width:100%;">
    <tr>
        <td align="center">
            <strong> 用户名:</strong><asp:TextBox ID="txt_lname" runat="server" width="150"></asp:TextBox>
<strong> 类别</strong><asp:DropDownList ID="ddlftype" runat="server" Width="150">
</asp:DropDownList>
    <asp:Button ID="Button1" runat="server" Text="查 找"  class="btn"   onclick="btnSearch_Click" />

        </td>
    </tr>
    <tr>
        <td>
              <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="id" Width="100%"  AllowPaging="True" GridLines="None"   onpageindexchanging="GridView1_PageIndexChanging">
        <RowStyle Height="25px" HorizontalAlign="Center" />
        <Columns>       
                <asp:TemplateField ControlStyle-Width="30" HeaderText="选择"    >
                    <ItemTemplate>
                        <asp:CheckBox ID="DeleteThis"  runat="server" />
                    </ItemTemplate>
                    <ItemStyle Width="30px" />
                </asp:TemplateField> 
            <asp:BoundField HeaderText="用户名" DataField="lname" />
            <asp:BoundField HeaderText="日期" DataField="fdate" />
            <asp:BoundField HeaderText="类别" DataField="ftype" />
            <asp:TemplateField HeaderText="所吃食物">
            <ItemTemplate>
            <%# StringHelper.SubStringHtml( Eval("memo").ToString(),20) %>
            </ItemTemplate>
            </asp:TemplateField>
            <asp:BoundField HeaderText="就餐时间" DataField="ftime" />
            <asp:HyperLinkField   DataNavigateUrlFormatString="View.aspx?id={0}" DataNavigateUrlFields="id" HeaderText="详情" Text="详情"  >
                <ItemStyle Width="50px" />
            </asp:HyperLinkField>
            <asp:HyperLinkField DataNavigateUrlFormatString="Modify.aspx?id={0}"  DataNavigateUrlFields="id" HeaderText="修改" Text="修改"  >                
                <ItemStyle Width="50px" />
            </asp:HyperLinkField>   
        </Columns>
        <HeaderStyle Height="27px" />
        <PagerStyle HorizontalAlign="Center" />
    </asp:GridView>

            
            <table width="100%" height="28"  border="0" cellpadding="0" cellspacing="0">
<tr>                    
<td align="left">
    <asp:Button ID="btnAll" runat="server" Text="全选"  class="btn"   OnClick="btnAll_Click"/>   
    <asp:Button ID="btnUn" runat="server" Text="反选"  class="btn"   OnClick="btnUn_Click"/>   
    <asp:Button ID="btnDelete" runat="server" Text="删除"  class="btn"   OnClick="btnDelete_Click"/>   
                   
</td>
</tr>
</table>

        </td>
    </tr>
</table>
 

    </td></tr></table>
                </td>
            </tr></table>

</asp:Content>


