<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" ValidateRequest="false"  CodeFile="Add.aspx.cs" Inherits="sports_Add" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
 
<script src="../My97DatePicker/WdatePicker.js" type="text/javascript"></script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

    <table width="99%" height="100%" align="center" style="border:2px solid #D6F2FE;">
        <tr><td height="28" style="background-color:#D6F2FE;">
            <b style="color:#4F98C6; font-size:12px;vertical-align:middle;">&nbsp;&nbsp;添加日常运动量信息</b>
            </td></tr>
            <tr>
                <td>
<table style="height:100%; min-height:500px;"><tr><td valign="top">
    

 <table style="width:100%;" id="ctl00_ContentPlaceHolder1_GridView1">
 
<tr>
<td  style=" text-align:right; width:20%;"><font style='color:red'>*&nbsp;</font>日期:</td>
<td class="tbright"><div style="display:inline;float:left;">
<asp:TextBox ID="txt_sdate" runat="server" width="200"  class="Wdate" onfocus="WdatePicker()"></asp:TextBox>
    <asp:RequiredFieldValidator ID="rfvsdate" runat="server" 
        ControlToValidate="txt_sdate" Display="Dynamic" 
        ErrorMessage="非空！"></asp:RequiredFieldValidator></div> 
 </td></tr>

<tr>
<td  style=" text-align:right; width:20%;"><font style='color:red'>*&nbsp;</font>行走步数:</td>
<td class="tbright"><div style="display:inline;float:left;">
<asp:TextBox ID="txt_squan" runat="server" width="200"></asp:TextBox>
    <asp:RequiredFieldValidator ID="rfvsquan" runat="server" 
        ControlToValidate="txt_squan" Display="Dynamic" 
        ErrorMessage="非空！"></asp:RequiredFieldValidator>
    <asp:RangeValidator ID="rvsquan" runat="server" 
        ControlToValidate="txt_squan" Display="Dynamic" ErrorMessage="行走步数格式不正确！" 
        MaximumValue="32767" MinimumValue="0" Type="Integer"></asp:RangeValidator></div>
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


