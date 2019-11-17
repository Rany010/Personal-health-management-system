<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" ValidateRequest="false"  CodeFile="Manage3.aspx.cs" Inherits="applys_List" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
 

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

    <table width="99%" height="100%" align="center" style="border:2px solid #D6F2FE;">
        <tr><td height="28" style="background-color:#D6F2FE;">
            <b style="color:#4F98C6; font-size:12px;vertical-align:middle;">&nbsp;&nbsp;待处理请求</b>
            </td></tr>
            <tr>
                <td>
<table style="height:100%; min-height:500px;"><tr><td valign="top">
    

 <table style="width:100%;">

    <tr>
        <td>
              <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="id" Width="100%"  AllowPaging="True" GridLines="None"   onpageindexchanging="GridView1_PageIndexChanging" EnableModelValidation="True">
        <RowStyle Height="25px" HorizontalAlign="Center" />
        <Columns>       
                <asp:TemplateField ControlStyle-Width="30" HeaderText="选择"    >
                    <ItemTemplate>
                        <asp:CheckBox ID="DeleteThis"  runat="server" />
                    </ItemTemplate>

<ControlStyle Width="30px"></ControlStyle>

                    <ItemStyle Width="30px" />
                </asp:TemplateField> 
            <asp:BoundField HeaderText="用户名" DataField="lname" />
          <asp:BoundField HeaderText="姓名" DataField="uname" />
            <asp:BoundField HeaderText="性别" DataField="sex" />
            <asp:BoundField HeaderText="年龄" DataField="age" />
            <asp:BoundField HeaderText="血型" DataField="xiex" />
            <asp:TemplateField HeaderText="个人照片">
            <ItemTemplate>
            <img alt="" src="../uploads/<%#Eval("pic")%>" width="80"  height="80" />
            </ItemTemplate>
            </asp:TemplateField>
            <asp:BoundField HeaderText="手机号码" DataField="tel" />
            <asp:BoundField HeaderText="请求时间" DataField="atime" />
            <asp:HyperLinkField   DataNavigateUrlFormatString="../users/View3.aspx?id={0}" DataNavigateUrlFields="lname" HeaderText="详情" Text="详情"  >
                <ItemStyle Width="50px" />
            </asp:HyperLinkField>
                <asp:TemplateField HeaderText="操作">
                    <ItemTemplate>
                        <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl='<%# Eval("lname", "Add1.aspx?id={0}") %>' Text="填写患病建议"></asp:HyperLink>

                        <asp:HyperLink ID="HyperLink2" runat="server" NavigateUrl='<%# Eval("lname", "Add2.aspx?id={0}") %>' Text="填写养生建议"></asp:HyperLink>

                        
                        <asp:HyperLink ID="HyperLink3" runat="server" NavigateUrl='<%# Eval("lname", "Add3.aspx?id={0}") %>' Text="填写运动建议"></asp:HyperLink>
                    </ItemTemplate>
                </asp:TemplateField>
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


