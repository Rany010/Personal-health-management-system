<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" ValidateRequest="false"  CodeFile="Manage2.aspx.cs" Inherits="applys_List" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
 

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

    <table width="99%" height="100%" align="center" style="border:2px solid #D6F2FE;">
        <tr><td height="28" style="background-color:#D6F2FE;">
            <b style="color:#4F98C6; font-size:12px;vertical-align:middle;">&nbsp;&nbsp;我请求的专家</b>
            </td></tr>
            <tr>
                <td>
<table style="height:100%; min-height:500px;"><tr><td valign="top">
    

 <table style="width:100%;">
 
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
            <asp:BoundField HeaderText="请求时间" DataField="atime" />
            
               
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


