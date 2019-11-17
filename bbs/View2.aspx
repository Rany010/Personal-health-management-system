<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" ValidateRequest="false"  CodeFile="View2.aspx.cs" Inherits="bbs_Show" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
 
    <script src="../xheditor/jquery/jquery-1.4.4.min.js" type="text/javascript"></script>
<script src="../xheditor/xheditor-1.2.1.min.js" type="text/javascript"></script> 
<script src="../xheditor/xheditor_lang/zh-cn.js" type="text/javascript"></script>

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

    <table width="99%" height="100%" align="center" style="border:2px solid #D6F2FE;">
        <tr><td height="28" style="background-color:#D6F2FE;">
            <b style="color:#4F98C6; font-size:12px;vertical-align:middle;">&nbsp;&nbsp;查看话题信息</b>
            </td></tr>
            <tr>
                <td>
<table style="height:100%; min-height:500px;"><tr><td valign="top">
    

 <table style="width:100%;" id="ctl00_ContentPlaceHolder1_GridView1">
     <tr>
	<td height="25" width="20%" align="right">话题编号：</td>
	<td height="25" width="*" align="left" style="text-align:left"><asp:Label ID="lblbid" runat="server" Text=""></asp:Label></td>
	</tr>
 <tr>
	<td height="25" width="20%" align="right">话题标题：</td>
	<td height="25" width="*" align="left" style="text-align:left"><asp:Label ID="lbltitle" runat="server" Text=""></asp:Label></td>
	</tr>
 <tr>
	<td height="25" width="20%" align="right">话题内容：</td>
	<td height="25" width="*" align="left" style="text-align:left"><asp:Label ID="lblmemo" runat="server" Text=""></asp:Label></td>
	</tr>
 <tr>
	<td height="25" width="20%" align="right">发布时间：</td>
	<td height="25" width="*" align="left" style="text-align:left"><asp:Label ID="lblatime" runat="server" Text=""></asp:Label></td>
	</tr>



</table><asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="id" Width="100%"  AllowPaging="True" GridLines="None"   onpageindexchanging="GridView1_PageIndexChanging">
        <RowStyle Height="25px" HorizontalAlign="Center" />
        <Columns>       
                <asp:TemplateField  HeaderText=""    >
                    <ItemTemplate>
                        
                               <table width="100%" style="    border-bottom: 1px dashed #e5e5e5;">
                            <tr><td rowspan="2" width="70" align="center" valign="middle">
                                <img src="../uploads/<%# Eval("pic") %>" width="62" height="62" alt="">
                                   </td><td>
                                    <b> <%# Eval("lname") %>(身份：<%# Eval("sf") %>)</b>
                                       <span style="float:right;">回复时间：<%# Eval("vtime") %></span></td></tr>
                              <tr><td>
                                <%# Eval("vmemo") %>
                                   </td></tr>

                        </table>

                    </ItemTemplate>
                </asp:TemplateField> 
        
        </Columns>
        <HeaderStyle Height="27px" />
        <PagerStyle HorizontalAlign="Center" />
    </asp:GridView>
 <table style="width:100%;" id="ctl00_ContentPlaceHolder1_GridView1">


<tr>
<td  style=" text-align:right; width:15%;"><font style='color:red'>*&nbsp;</font>回复内容:</td>
<td class="tbright"><div style="display:inline;float:left;">
<textarea id="elm1" name="elm1" class="xheditor" rows="12" cols="80" style="width: 100%" runat="server"></textarea>
 </td></tr>



    <tr>
        <td>&nbsp;</td>
        <td align="left">
            <asp:Button ID="btnAdd" runat="server" Text="提 交"  class="btn"  OnClick="btnSave_Click"  />
            
            <asp:Button ID="btnReturn" runat="server" Text="返回列表"  class="btn"  CausesValidation="false" OnClick="btnReturn_Click" />
        </td>
    </tr>
</table>

    </td></tr></table>
                </td>
            </tr></table>

</asp:Content>


