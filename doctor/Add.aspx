<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" ValidateRequest="false"  CodeFile="Add.aspx.cs" Inherits="doctor_Add" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
 

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

    <table width="99%" height="100%" align="center" style="border:2px solid #D6F2FE;">
        <tr><td height="28" style="background-color:#D6F2FE;">
            <b style="color:#4F98C6; font-size:12px;vertical-align:middle;">&nbsp;&nbsp;添加专家信息</b>
            </td></tr>
            <tr>
                <td>
<table style="height:100%; min-height:500px;"><tr><td valign="top">
    

 <table style="width:100%;" id="ctl00_ContentPlaceHolder1_GridView1">
    <tr>
<td  style=" text-align:right; width:20%;"><font style='color:red'>*&nbsp;</font>专家编号:</td>
<td class="tbright"><div style="display:inline;float:left;">
<asp:TextBox ID="txt_dno" runat="server" width="200"></asp:TextBox>
    <asp:RequiredFieldValidator ID="rfvdno" runat="server" 
        ControlToValidate="txt_dno" Display="Dynamic" 
        ErrorMessage="非空！"></asp:RequiredFieldValidator></div> 
 </td></tr>

<tr>
<td  style=" text-align:right; width:20%;"><font style='color:red'>*&nbsp;</font>登录密码:</td>
<td class="tbright"><div style="display:inline;float:left;">
<asp:TextBox ID="txt_pass" runat="server" width="200"></asp:TextBox>
    <asp:RequiredFieldValidator ID="rfvpass" runat="server" 
        ControlToValidate="txt_pass" Display="Dynamic" 
        ErrorMessage="非空！"></asp:RequiredFieldValidator></div> 
 </td></tr>

<tr>
<td  style=" text-align:right; width:20%;"><font style='color:red'>*&nbsp;</font>专家姓名:</td>
<td class="tbright"><div style="display:inline;float:left;">
<asp:TextBox ID="txt_dname" runat="server" width="200"></asp:TextBox>
    <asp:RequiredFieldValidator ID="rfvdname" runat="server" 
        ControlToValidate="txt_dname" Display="Dynamic" 
        ErrorMessage="非空！"></asp:RequiredFieldValidator></div> 
 </td></tr>

<tr>
<td  style=" text-align:right; width:20%;"><font style='color:red'>*&nbsp;</font>性别:</td>
<td class="tbright"><div style="display:inline;float:left;">
<asp:RadioButtonList ID="rtsex" runat="server" RepeatDirection="Horizontal">
    <asp:ListItem Selected="True">男</asp:ListItem>
    <asp:ListItem>女</asp:ListItem>
</asp:RadioButtonList>
 </td></tr>

<tr>
<td  style=" text-align:right; width:20%;"><font style='color:red'>*&nbsp;</font>年龄:</td>
<td class="tbright"><div style="display:inline;float:left;">
<asp:TextBox ID="txt_age" runat="server" width="200"></asp:TextBox>
    <asp:RequiredFieldValidator ID="rfvage" runat="server" 
        ControlToValidate="txt_age" Display="Dynamic" 
        ErrorMessage="非空！"></asp:RequiredFieldValidator></div> 
 </td></tr>

<tr>
<td  style=" text-align:right; width:20%;"><font style='color:red'>*&nbsp;</font>个人照片:</td>
<td class="tbright"><div style="display:inline;float:left;">
<asp:FileUpload ID="fppic" runat="server" Width="250" />支持格式为：.jpg | .gif | .png
 </td></tr>

<tr>
<td  style=" text-align:right; width:20%;"><font style='color:red'>*&nbsp;</font>所属医院:</td>
<td class="tbright"><div style="display:inline;float:left;">
<asp:TextBox ID="txt_cname" runat="server" width="200"></asp:TextBox>
    <asp:RequiredFieldValidator ID="rfvcname" runat="server" 
        ControlToValidate="txt_cname" Display="Dynamic" 
        ErrorMessage="非空！"></asp:RequiredFieldValidator></div> 
 </td></tr>

<tr>
<td  style=" text-align:right; width:20%;"><font style='color:red'>*&nbsp;</font>职称:</td>
<td class="tbright"><div style="display:inline;float:left;">
<asp:RadioButtonList ID="rdljob" runat="server" RepeatDirection="Horizontal" RepeatLayout="Flow">
    <asp:ListItem>主治医师</asp:ListItem>
    <asp:ListItem>副主任医师</asp:ListItem>
    <asp:ListItem Selected="True">主任医师</asp:ListItem>
</asp:RadioButtonList> </td></tr>

<tr>
<td  style=" text-align:right; width:20%;"><font style='color:red'>*&nbsp;</font>手机号码:</td>
<td class="tbright"><div style="display:inline;float:left;">
<asp:TextBox ID="txt_tel" runat="server" width="200"></asp:TextBox>
    <asp:RequiredFieldValidator ID="rfvtel" runat="server" 
        ControlToValidate="txt_tel" Display="Dynamic" 
        ErrorMessage="非空！"></asp:RequiredFieldValidator></div> 
 </td></tr>

<tr>
<td  style=" text-align:right; width:20%;">个人简介:</td>
<td class="tbright"><div style="display:inline;float:left;">
<asp:TextBox ID="txt_memo" runat="server" width="347px" Height="141px" TextMode="MultiLine"></asp:TextBox>
</div> 
 </td></tr>



    <tr>
        <td>&nbsp;</td>
        <td align="left">
            <asp:Button ID="btnAdd" runat="server" Text="提 交"  class="btn"  OnClick="btnSave_Click"  />
            <asp:Button ID="btnCan" runat="server" Text="返 回"  class="btn" OnClientClick="document.location='Manage.aspx';return false;" CausesValidation="false" />
        </td>
    </tr>
</table>
 

    </td></tr></table>
                </td>
            </tr></table>

</asp:Content>


