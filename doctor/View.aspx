<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" ValidateRequest="false"  CodeFile="View.aspx.cs" Inherits="doctor_Show" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
 

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

    <table width="99%" height="100%" align="center" style="border:2px solid #D6F2FE;">
        <tr><td height="28" style="background-color:#D6F2FE;">
            <b style="color:#4F98C6; font-size:12px;vertical-align:middle;">&nbsp;&nbsp;查看专家信息</b>
            </td></tr>
            <tr>
                <td>
<table style="height:100%; min-height:500px;"><tr><td valign="top">
    

 <table style="width:100%;" id="ctl00_ContentPlaceHolder1_GridView1">
     <tr>
	<td height="25" width="20%" align="right">专家编号：</td>
	<td height="25" width="*" align="left" style="text-align:left"><asp:Label ID="lbldno" runat="server" Text=""></asp:Label></td>
	</tr>
 <tr>
	<td height="25" width="20%" align="right">登录密码：</td>
	<td height="25" width="*" align="left" style="text-align:left"><asp:Label ID="lblpass" runat="server" Text=""></asp:Label></td>
	</tr>
 <tr>
	<td height="25" width="20%" align="right">专家姓名：</td>
	<td height="25" width="*" align="left" style="text-align:left"><asp:Label ID="lbldname" runat="server" Text=""></asp:Label></td>
	</tr>
 <tr>
	<td height="25" width="20%" align="right">性别：</td>
	<td height="25" width="*" align="left" style="text-align:left"><asp:Label ID="lblsex" runat="server" Text=""></asp:Label></td>
	</tr>
 <tr>
	<td height="25" width="20%" align="right">年龄：</td>
	<td height="25" width="*" align="left" style="text-align:left"><asp:Label ID="lblage" runat="server" Text=""></asp:Label></td>
	</tr>
 <tr>
	<td height="25" width="20%" align="right">个人照片：</td>
	<td height="25" width="*" align="left" style="text-align:left"><asp:Image ID="imgpic" runat="server" Width="120" Height="120" /></td>
	</tr>
 <tr>
	<td height="25" width="20%" align="right">所属医院：</td>
	<td height="25" width="*" align="left" style="text-align:left"><asp:Label ID="lblcname" runat="server" Text=""></asp:Label></td>
	</tr>
 <tr>
	<td height="25" width="20%" align="right">职称：</td>
	<td height="25" width="*" align="left" style="text-align:left"><asp:Label ID="lbljob" runat="server" Text=""></asp:Label></td>
	</tr>
 <tr>
	<td height="25" width="20%" align="right">手机号码：</td>
	<td height="25" width="*" align="left" style="text-align:left"><asp:Label ID="lbltel" runat="server" Text=""></asp:Label></td>
	</tr>
 <tr>
	<td height="25" width="20%" align="right">个人简介：</td>
	<td height="25" width="*" align="left" style="text-align:left"><asp:Label ID="lblmemo" runat="server" Text=""></asp:Label></td>
	</tr>


    <tr>
        <td>&nbsp;</td>
        <td align="left">   

            <asp:Button ID="btnReturn" runat="server" Text="返回列表"  class="btn" OnClientClick="history.go(-1); return false;" CausesValidation="false" />
        </td>
    </tr>
</table>
 

    </td></tr></table>
                </td>
            </tr></table>

</asp:Content>


