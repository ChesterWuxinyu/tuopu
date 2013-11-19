<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Editperson.aspx.cs" Inherits="Whf.TuoPu.Web.BasicData.Editperson" %>

<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN" >
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>EditFunction</title>
    <link href="../css/adminCss.css" rel="stylesheet" type="text/css" />
    <base target="_self" />
</head>
<body>
    <form id="form1" runat="server">
    <table class="TableMain">
        <tr>
            <td colspan="2" class="TDTitle"><asp:Label ID="lblTitle" Text="新增菜单" CssClass="LabelMain" runat="server"></asp:Label></td>
        </tr>
        <tr>
            <td class="TDLabel"><asp:Label ID="lblFuncName" Text="菜单名称" CssClass="LabelTitle" runat="server"></asp:Label></td>
            <td class="TDSperate"></td>
            <td class="TDValue"><asp:TextBox ID="txtFuncName" CssClass="TextBoxMain160" runat="server"></asp:TextBox></td>
        </tr>
        <tr>
            <td colspan="2" height="4"></td>
        </tr>
        <tr>
            <td class="TDLabel"><asp:Label ID="lblFuncLevel" Text="菜单层级" CssClass="LabelTitle" runat="server"></asp:Label></td>
            <td class="TDSperate"></td>
            <td class="TDValue"><asp:DropDownList ID="drpLevel" CssClass="DropDownListMain160" runat="server"></asp:DropDownList></td>
        </tr>
        <tr>
            <td colspan="2" height="4"></td>
        </tr>
        <tr>
            <td class="TDLabel"><asp:Label ID="lblFuncUrl" Text="菜单地址" CssClass="LabelTitle" runat="server"></asp:Label></td>
            <td class="TDSperate"></td>
            <td class="TDValue"><asp:TextBox ID="txtFuncUrl" CssClass="TextBoxMain160" runat="server"></asp:TextBox></td>
        </tr>
        <tr>
            <td colspan="2" height="4"></td>
        </tr>
        <tr>
            <td class="TDLabel"><asp:Label ID="lblFuncMemo" Text="菜单说明" CssClass="LabelTitle" runat="server"></asp:Label></td>
            <td class="TDSperate"></td>
            <td class="TDValue"><asp:TextBox ID="txtFuncMemo" CssClass="TextBoxMain160" runat="server"></asp:TextBox></td>
        </tr>
        <tr>
            <td colspan="2" height="4"></td>
        </tr>
        <tr>
            <td colspan="3" align="center" width="100%"><asp:Button ID="btnAdd" runat="server" Text="保存" CssClass="ButtonMain" />
            <asp:Button ID="btnReturn" runat="server" Text="返回" CssClass="ButtonMain" />
            </td>
        </tr>
    </table>
    </form>
</body>
</html>
