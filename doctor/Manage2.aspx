<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" ValidateRequest="false"  CodeFile="Manage2.aspx.cs" Inherits="doctor_List" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
 

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

    <table width="99%" height="100%" align="center" style="border:2px solid #D6F2FE;">
        <tr><td height="28" style="background-color:#D6F2FE;">
            <b style="color:#4F98C6; font-size:12px;vertical-align:middle;">&nbsp;&nbsp;专家列表</b>
            </td></tr>
            <tr>
                <td>
<table style="height:100%; min-height:500px;"><tr><td valign="top">
    

 <table style="width:100%;">
    <tr>
        <td align="center">
            <strong> 专家编号:</strong><asp:TextBox ID="txt_dno" runat="server" width="150"></asp:TextBox>
<strong> 专家姓名:</strong><asp:TextBox ID="txt_dname" runat="server" width="150"></asp:TextBox>
<strong> 所属医院:</strong><asp:TextBox ID="txt_cname" runat="server" width="150"></asp:TextBox>

    <asp:Button ID="Button1" runat="server" Text="查 找"  class="btn"   onclick="btnSearch_Click" />

        </td>
    </tr>
    <tr>
        <td>
              <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="dno" Width="100%"  AllowPaging="True" GridLines="None"   onpageindexchanging="GridView1_PageIndexChanging" EnableModelValidation="True">
        <RowStyle Height="25px" HorizontalAlign="Center" />
        <Columns>       
                 
            <asp:BoundField HeaderText="专家编号" DataField="dno" />
            <asp:BoundField HeaderText="专家姓名" DataField="dname" />
            <asp:BoundField HeaderText="性别" DataField="sex" />
            <asp:BoundField HeaderText="年龄" DataField="age" />
            <asp:TemplateField HeaderText="个人照片">
            <ItemTemplate>
            <img alt="" src="../uploads/<%#Eval("pic")%>" width="80"  height="80" />
            </ItemTemplate>
            </asp:TemplateField>
            <asp:BoundField HeaderText="所属医院" DataField="cname" />
            <asp:BoundField HeaderText="职称" DataField="job" />
            <asp:BoundField HeaderText="手机号码" DataField="tel" />
            
            <asp:HyperLinkField   DataNavigateUrlFormatString="View2.aspx?id={0}" DataNavigateUrlFields="dno" HeaderText="详情" Text="详情"  >
                <ItemStyle Width="50px" />
            </asp:HyperLinkField>
            <asp:TemplateField HeaderText="操作">
                <ItemTemplate>
                    
                    <asp:LinkButton ID="LinkButton1" runat="server" CommandName='<%# Eval("dno") %>' OnClick="LinkButton1_Click">请求帮忙</asp:LinkButton>

                </ItemTemplate>
                <ItemStyle Width="50px" />
            </asp:TemplateField>
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


