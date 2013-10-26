<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FunctionManage.aspx.cs"
    Inherits="Whf.TuoPu.Web.BasicData.FunctionManage" %>

<%@ Register Src="..\Controls\Navigator.ascx" TagName="Navigator" TagPrefix="uc1" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN" >
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>function</title>
    <link href="../css/adminCss.css" rel="stylesheet" type="text/css" />
    <script src="../Script/Function.js" type="text/javascript"></script>
    <script language="javascript" type="text/javascript">
        function AddFunction() {
            showdialog("EditFunction.aspx", 480, 500);
        }
    </script>
</head>
<body>
    <form id="form1" runat="server">
    <table cellpadding="0" cellspacing="0" class="TableMain">
        <tr>
            <td class="TDTitle">
                <asp:Label ID="lblTitle" CssClass="LabelMain" runat="server" Text="功能管理"></asp:Label>
            </td>
        </tr>
        <tr>
            <td>
                <table class="TableMain" cellpadding="0" cellspacing="0">
                    <tr>
                        <td class="TDLabel">
                            <asp:Label ID="lblFunName" CssClass="LabelTitle" Text="菜单名称" runat="server"></asp:Label>
                        </td>
                        <td class="TDValue">
                            <asp:TextBox ID="txtFunName" runat="server" CssClass="TextBoxMain160"></asp:TextBox>
                        </td>
                        <td width="4">
                        </td>
                        <td class="TDLabel">
                            <asp:Label ID="lblPFunName" CssClass="LabelTitle" Text="父菜单名称" runat="server"></asp:Label>
                        </td>
                        <td class="TDValue">
                            <asp:TextBox ID="txtPFunName" CssClass="TextBoxMain160" runat="server"></asp:TextBox>
                        </td>
                        <td width="4">
                        </td>
                        <td class="TDLabel">
                            <asp:Label ID="lblLevel" CssClass="LabelTitle" Text="菜单层级" runat="server"></asp:Label>
                        </td>
                        <td class="TDValue">
                            <asp:TextBox ID="txtLevel" runat="server" CssClass="TextBoxMain160"></asp:TextBox>
                        </td>
                        <td align="right">
                            <asp:Button ID="btnQuery" runat="server" Text="查询" CssClass="ButtonMain" />
                        </td>
                    </tr>
                </table>
            </td>
        </tr>
        <tr>
            <td class="TDMain">
                <div class="DivGridView">
                    <asp:GridView CssClass="gridview_list" ID="gvTest" AutoGenerateColumns="false" runat="server"
                        BackColor="White" BorderColor="White" BorderStyle="Ridge" BorderWidth="2px" CellPadding="3"
                        CellSpacing="1" GridLines="None">
                        <Columns>
                            <asp:BoundField Visible="false" DataField="oid" HeaderText="" />
                            <asp:BoundField DataField="funcName" HeaderText="菜单名称" />
                            <asp:BoundField DataField="functionlevel" HeaderText="菜单层级" />
                            <asp:BoundField DataField="functionstatus" HeaderText="状态" />
                            <asp:BoundField DataField="functionurl" HeaderText="菜单链接" />
                            <asp:BoundField DataField="PFucnName" HeaderText="父菜单名称" />
                            <asp:BoundField DataField="memo" HeaderText="备注" />
                        </Columns>
                        <HeaderStyle CssClass="gridview_header" />
                        <RowStyle CssClass="gridview_row" />
                        <AlternatingRowStyle CssClass="altrow" />
                        <SelectedRowStyle CssClass="gridviewRowSelected" />
                    </asp:GridView>
                </div>
                <div class="DivNavigatior">
                    <uc1:Navigator ID="Navigator" runat="server" />
                </div>
            </td>
        </tr>
        <tr>
            <td class="TDOperate">
                <asp:Button ID="btnAdd" runat="server" Text="新增" OnClientClick="AddFunction();" CssClass="ButtonMain" />
            </td>
        </tr>
    </table>
    </form>
</body>
</html>
