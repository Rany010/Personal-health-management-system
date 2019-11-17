<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" ValidateRequest="false"  CodeFile="View.aspx.cs" Inherits="historys_Show" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
 

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

    <table width="99%" height="100%" align="center" style="border:2px solid #D6F2FE;">
        <tr><td height="28" style="background-color:#D6F2FE;">
            <b style="color:#4F98C6; font-size:12px;vertical-align:middle;">&nbsp;&nbsp;查看病历信息</b>
            </td></tr>
            <tr>
                <td>
<table style="height:100%; min-height:500px;"><tr><td valign="top">
    

 <table style="width:100%;" id="ctl00_ContentPlaceHolder1_GridView1">
     <tr>
	<td height="25" width="20%" align="right">编号：</td>
	<td height="25" width="*" align="left" style="text-align:left"><asp:Label ID="lblid" runat="server" Text=""></asp:Label></td>
	</tr>
 <tr>
	<td height="25" width="20%" align="right">用户名：</td>
	<td height="25" width="*" align="left" style="text-align:left"><asp:Label ID="lbllname" runat="server" Text=""></asp:Label></td>
	</tr>
 <tr>
	<td height="25" width="20%" align="right">患病时间：</td>
	<td height="25" width="*" align="left" style="text-align:left"><asp:Label ID="lblodate" runat="server" Text=""></asp:Label></td>
	</tr>
 <tr>
	<td height="25" width="20%" align="right">就诊医院：</td>
	<td height="25" width="*" align="left" style="text-align:left"><asp:Label ID="lblhname" runat="server" Text=""></asp:Label></td>
	</tr>
 <tr>
	<td height="25" width="20%" align="right">就诊医师：</td>
	<td height="25" width="*" align="left" style="text-align:left"><asp:Label ID="lbldoctor" runat="server" Text=""></asp:Label></td>
	</tr>
 <tr>
	<td height="25" width="20%" align="right">所给处方：</td>
	<td height="25" width="*" align="left" style="text-align:left"><asp:Label ID="lblchuf" runat="server" Text=""></asp:Label></td>
	</tr>
 <tr>
	<td height="25" width="20%" align="right">痊愈时间：</td>
	<td height="25" width="*" align="left" style="text-align:left"><asp:Label ID="lblqdate" runat="server" Text=""></asp:Label></td>
	</tr>
 <tr>
	<td height="25" width="20%" align="right">记录时间：</td>
	<td height="25" width="*" align="left" style="text-align:left"><asp:Label ID="lblatime" runat="server" Text=""></asp:Label></td>
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


