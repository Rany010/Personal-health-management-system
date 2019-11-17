<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" ValidateRequest="false"  CodeFile="Add.aspx.cs" Inherits="historys_Add" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
 
<script src="../My97DatePicker/WdatePicker.js" type="text/javascript"></script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

    <table width="99%" height="100%" align="center" style="border:2px solid #D6F2FE;">
        <tr><td height="28" style="background-color:#D6F2FE;">
            <b style="color:#4F98C6; font-size:12px;vertical-align:middle;">&nbsp;&nbsp;添加病历信息</b>
            </td></tr>
            <tr>
                <td>
<table style="height:100%; min-height:500px;"><tr><td valign="top">
    

 <table style="width:100%;" id="ctl00_ContentPlaceHolder1_GridView1">


<tr>
<td  style=" text-align:right; width:20%;"><font style='color:red'>*&nbsp;</font>患病时间:</td>
<td class="tbright"><div style="display:inline;float:left;">
<asp:TextBox ID="txt_odate" runat="server" width="200"  class="Wdate" onfocus="WdatePicker()"></asp:TextBox>
    <asp:RequiredFieldValidator ID="rfvodate" runat="server" 
        ControlToValidate="txt_odate" Display="Dynamic" 
        ErrorMessage="非空！"></asp:RequiredFieldValidator></div> 
 </td></tr>

<tr>
<td  style=" text-align:right; width:20%;"><font style='color:red'>*&nbsp;</font>就诊医院:</td>
<td class="tbright"><div style="display:inline;float:left;">
<asp:TextBox ID="txt_hname" runat="server" width="200"></asp:TextBox>
    <asp:RequiredFieldValidator ID="rfvhname" runat="server" 
        ControlToValidate="txt_hname" Display="Dynamic" 
        ErrorMessage="非空！"></asp:RequiredFieldValidator></div> 
 </td></tr>

<tr>
<td  style=" text-align:right; width:20%;"><font style='color:red'>*&nbsp;</font>就诊医师:</td>
<td class="tbright"><div style="display:inline;float:left;">
<asp:TextBox ID="txt_doctor" runat="server" width="200"></asp:TextBox>
    <asp:RequiredFieldValidator ID="rfvdoctor" runat="server" 
        ControlToValidate="txt_doctor" Display="Dynamic" 
        ErrorMessage="非空！"></asp:RequiredFieldValidator></div> 
 </td></tr>

<tr>
<td  style=" text-align:right; width:20%;"><font style='color:red'>*&nbsp;</font>所给处方:</td>
<td class="tbright"><div style="display:inline;float:left;">
<asp:TextBox ID="txt_chuf" runat="server" width="426px" Height="136px" TextMode="MultiLine"></asp:TextBox>
    <asp:RequiredFieldValidator ID="rfvchuf" runat="server" 
        ControlToValidate="txt_chuf" Display="Dynamic" 
        ErrorMessage="非空！"></asp:RequiredFieldValidator></div> 
 </td></tr>

<tr>
<td  style=" text-align:right; width:20%;"><font style='color:red'>*&nbsp;</font>痊愈时间:</td>
<td class="tbright"><div style="display:inline;float:left;">
<asp:TextBox ID="txt_qdate" runat="server" width="200"  class="Wdate" onfocus="WdatePicker()"></asp:TextBox>
    <asp:RequiredFieldValidator ID="rfvqdate" runat="server" 
        ControlToValidate="txt_qdate" Display="Dynamic" 
        ErrorMessage="非空！"></asp:RequiredFieldValidator></div> 
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


