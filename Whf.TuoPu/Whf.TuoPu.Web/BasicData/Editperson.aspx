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
            <td colspan="2" class="TDTitle">
                <asp:Label ID="lblTitle" Text="新增员工" CssClass="LabelMain" runat="server"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="TDLabel">
                <asp:Label ID="lblPersonAccount" Text="员工账号" CssClass="LabelTitle" runat="server"></asp:Label>
            </td>
            <td class="TDSperate"></td>
            <td class="TDValue">
                <asp:TextBox ID="txtPersonAccount" CssClass="TextBoxMain160" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td colspan="2" height="4"></td>
        </tr>
        <tr>
            <td class="TDLabel">
                <asp:Label ID="lblPersonName" Text="员工姓名" CssClass="LabelTitle" runat="server"></asp:Label>
            </td>
            <td class="TDSperate"></td>
            <td class="TDValue">
                <asp:TextBox ID="txtPersonName" CssClass="TextBoxMain160" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td colspan="2" height="4"></td>
        </tr>
        <tr>
            <td class="TDLabel">
                <asp:Label ID="lblPersonSex" Text="员工性别" CssClass="LabelTitle" runat="server"></asp:Label>
            </td>
            <td class="TDSperate"></td>
            <td class="TDValue">
                <asp:DropDownList ID="drpPersonSex" CssClass="DropDownListMain160" runat="server">
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td colspan="2" height="4"></td>
        </tr>
        <tr>
            <td class="TDLabel">
                <asp:Label ID="lblPersonType" Text="员工类别" CssClass="LabelTitle" runat="server"></asp:Label>
            </td>
            <td class="TDSperate"></td>
            <td class="TDValue">
                <asp:DropDownList ID="drpPersonType" CssClass="DropDownListMain160" runat="server">
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td colspan="2" height="4"></td>
        </tr>
        <tr>
            <td class="TDLabel">
                <asp:Label ID="lblPersonStatus" Text="员工状态" CssClass="LabelTitle" runat="server"></asp:Label>
            </td>
            <td class="TDSperate"></td>
            <td class="TDValue">
                <asp:DropDownList ID="drpPersonStatus" CssClass="DropDownListMain160" runat="server">
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td colspan="2" height="4"></td>
        </tr>
        <tr>
            <td class="TDLabel">
                <asp:Label ID="lblOfficePhone" Text="办公电话" CssClass="LabelTitle" runat="server"></asp:Label>
            </td>
            <td class="TDSperate"></td>
            <td class="TDValue">
                <asp:TextBox ID="txtOfficePhone" CssClass="TextBoxMain160" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td colspan="2" height="4"></td>
        </tr>
        <tr>
            <td class="TDLabel">
                <asp:Label ID="lblMobilPhone" Text="移动电话" CssClass="LabelTitle" runat="server"></asp:Label>
            </td>
            <td class="TDSperate"></td>
            <td class="TDValue">
                <asp:TextBox ID="txtMobilPhone" CssClass="TextBoxMain160" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td colspan="2" height="4"></td>
        </tr>
        <tr>
            <td class="TDLabel">
                <asp:Label ID="lblEmail" Text="电子邮件" CssClass="LabelTitle" runat="server"></asp:Label>
            </td>
            <td class="TDSperate"></td>
            <td class="TDValue">
                <asp:TextBox ID="txtEmail" CssClass="TextBoxMain160" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td colspan="2" height="4"></td>
        </tr>
        <tr>
            <td class="TDLabel">
                <asp:Label ID="lblPersonMemo" Text="菜单说明" CssClass="LabelTitle" runat="server"></asp:Label>
            </td>
            <td class="TDSperate"></td>
            <td class="TDValue">
                <asp:TextBox ID="txtPersonMemo" CssClass="TextBoxMain160" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td colspan="2" height="4">
                <asp:HiddenField ID="hdfPersonID" runat="server" />
            </td>
        </tr>
        <tr>
            <td colspan="3" align="center" width="100%">
                <asp:Button ID="btnAdd" runat="server" Text="保存" CssClass="ButtonMain" />
                <asp:Button ID="btnReturn" runat="server" OnClientClick="window.close();" Text="返回" CssClass="ButtonMain" />
            </td>
        </tr>
    </table>
    </form>
</body>
</html>
