<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" ValidateRequest="false"  CodeFile="Modify.aspx.cs" Inherits="bbs_Edit" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
 
<script src="../xheditor/jquery/jquery-1.4.4.min.js" type="text/javascript"></script>
<script src="../xheditor/xheditor-1.2.1.min.js" type="text/javascript"></script> 
<script src="../xheditor/xheditor_lang/zh-cn.js" type="text/javascript"></script>

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

    <table width="99%" height="100%" align="center" style="border:2px solid #D6F2FE;">
        <tr><td height="28" style="background-color:#D6F2FE;">
            <b style="color:#4F98C6; font-size:12px;vertical-align:middle;">&nbsp;&nbsp;编辑话题信息</b>
            </td></tr>
            <tr>
                <td>
<table style="height:100%; min-height:500px;"><tr><td valign="top">
    

 <table style="width:100%;" id="ctl00_ContentPlaceHolder1_GridView1">
    <tr>
<td  style=" text-align:right; width:15%;"><font style='color:red'>*&nbsp;</font>话题标题:</td>
<td class="tbright"><div style="display:inline;float:left;">
<asp:TextBox ID="txt_title" runat="server" width="200"></asp:TextBox>
    <asp:RequiredFieldValidator ID="rfvtitle" runat="server" 
        ControlToValidate="txt_title" Display="Dynamic" 
        ErrorMessage="非空！"></asp:RequiredFieldValidator></div> 
 </td></tr>

<tr>
<td  style=" text-align:right; width:15%;"><font style='color:red'>*&nbsp;</font>话题内容:</td>
<td class="tbright"><div style="display:inline;float:left;">
<textarea id="elm1" name="elm1" class="xheditor" rows="15" cols="80" style="width: 100%" runat="server"></textarea>
 </td></tr>



    <tr>
        <td>&nbsp;</td>
        <td align="left">
            <asp:Button ID="btnUpdate" runat="server" Text="提 交"  class="btn"  OnClick="btnSave_Click" />
            <asp:Button ID="btnCan" runat="server" Text="返 回"  class="btn" OnClientClick="document.location='Manage.aspx';return false;" CausesValidation="false" />
        </td>
    </tr>
</table>
 

    </td></tr></table>
                </td>
            </tr></table>

</asp:Content>


