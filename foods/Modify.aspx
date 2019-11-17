<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" ValidateRequest="false"  CodeFile="Modify.aspx.cs" Inherits="foods_Edit" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
 
<script src="../My97DatePicker/WdatePicker.js" type="text/javascript"></script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

    <table width="99%" height="100%" align="center" style="border:2px solid #D6F2FE;">
        <tr><td height="28" style="background-color:#D6F2FE;">
            <b style="color:#4F98C6; font-size:12px;vertical-align:middle;">&nbsp;&nbsp;编辑膳食搭配信息</b>
            </td></tr>
            <tr>
                <td>
<table style="height:100%; min-height:500px;"><tr><td valign="top">
    

 <table style="width:100%;" id="ctl00_ContentPlaceHolder1_GridView1">
<tr>
<td  style=" text-align:right; width:20%;"><font style='color:red'>*&nbsp;</font>日期:</td>
<td class="tbright"><div style="display:inline;float:left;">
<asp:TextBox ID="txt_fdate" runat="server" width="200"  class="Wdate" onfocus="WdatePicker()"></asp:TextBox>
    <asp:RequiredFieldValidator ID="rfvfdate" runat="server" 
        ControlToValidate="txt_fdate" Display="Dynamic" 
        ErrorMessage="非空！"></asp:RequiredFieldValidator></div> 
 </td></tr>

<tr>
<td  style=" text-align:right; width:20%;"><font style='color:red'>*&nbsp;</font>类别:</td>
<td class="tbright"><div style="display:inline;float:left;">
<asp:DropDownList ID="ddlftype" runat="server" Width="200">
    <asp:ListItem>早餐</asp:ListItem>
    <asp:ListItem>午餐</asp:ListItem>
    <asp:ListItem>晚餐</asp:ListItem>
</asp:DropDownList> </td></tr>

<tr>
<td  style=" text-align:right; width:20%;"><font style='color:red'>*&nbsp;</font>所吃食物:</td>
<td class="tbright"><div style="display:inline;float:left;">
<asp:TextBox ID="txt_memo" runat="server" width="342px" Height="85px" TextMode="MultiLine"></asp:TextBox>
    <asp:RequiredFieldValidator ID="rfvmemo" runat="server" 
        ControlToValidate="txt_memo" Display="Dynamic" 
        ErrorMessage="非空！"></asp:RequiredFieldValidator></div> 
 </td></tr>

<tr>
<td  style=" text-align:right; width:20%;"><font style='color:red'>*&nbsp;</font>就餐时间:</td>
<td class="tbright"><div style="display:inline;float:left;">
<asp:TextBox ID="txt_ftime" runat="server" width="200"></asp:TextBox>
    <asp:RequiredFieldValidator ID="rfvftime" runat="server" 
        ControlToValidate="txt_ftime" Display="Dynamic" 
        ErrorMessage="非空！"></asp:RequiredFieldValidator></div> 
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


