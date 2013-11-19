using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Whf.TuoPu.Controller;
using System.Data;
using Whf.TuoPu.Common;
using Whf.TuoPu.Entity;

namespace Whf.TuoPu.Web.BasicData
{
    public partial class FunctionManage : BasePage
    {
        #region 事件
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                this.BindTree();
                this.BindDropdownList();
            }
        }

        protected override void OnInit(EventArgs e)
        {
            this.btnQuery.Click += new EventHandler(btnQuery_Click);
            this.tvMenu.SelectedNodeChanged += new EventHandler(tvMenu_SelectedNodeChanged);
            base.OnInit(e);
        }

        private void tvMenu_SelectedNodeChanged(object sender, EventArgs e)
        {
            TreeNode selectedNode = this.tvMenu.SelectedNode;
            if (selectedNode.Value == "0")
            {
                btnSave.Visible = false;
            }
            else
            {
                FunctionEntity fun = new FunctionController().GetFunc(selectedNode.Value);
                if (fun != null)
                {
                    txtFuncCode.Text = fun.FUNCTIONKEY;
                    txtFuncMemo.Text = fun.MEMO;
                    txtFuncName.Text = fun.FUNCTIONNAME;
                    txtFuncOrder.Text = fun.FUNCTIONORDER.ToString();
                    txtFuncUrl.Text = fun.FUNCTIONURL;
                }
            }
        }

        private void btnQuery_Click(object sender, EventArgs e)
        {
            this.BindTree();
        }
        #endregion

        #region 操作
        
        #endregion

        #region 方法
        private void BindDropdownList()
        {
            this.drpFuncStatus.Items.Clear();
            ListItem lst1 = new ListItem();
            lst1.Text = CommonMessage.EnableStatus;
            lst1.Value = CommonStatus.Enable.GetHashCode().ToString();
            this.drpFuncStatus.Items.Add(lst1);

            ListItem lst2 = new ListItem();
            lst2.Text = CommonMessage.DisableStatus;
            lst2.Value = CommonStatus.Disable.GetHashCode().ToString();
            this.drpFuncStatus.Items.Add(lst2);
        }

        private void BindTree()
        {
            FunctionController controller = new FunctionController();
            DataSet dstMenu = controller.QueryFunctions(this.txtQueryFunCode.Text.Trim(), this.txtQueryFunName.Text.Trim());
            TreeNode node = new TreeNode();
            node.Text = "系统功能";
            node.Value = "0";
            node.NavigateUrl = "";
            this.tvMenu.Nodes.Add(node);
            if (dstMenu != null && dstMenu.Tables[0].Rows.Count > 0)
            {
                this.BindChildNode(dstMenu, node);
            }
        }

        private void BindChildNode(DataSet dstMenu, TreeNode parNode)
        {
            if (parNode != null && dstMenu != null)
            {
                string parID = parNode.Value;
                DataRow[] drs = dstMenu.Tables[0].Select(string.Format("functionparentid='{0}'", parID));
                if (drs.Length > 0)
                {
                    foreach (DataRow dr in drs)
                    {
                        TreeNode node = new TreeNode();
                        node.Text = Convert.ToString(dr["functionname"]);
                        node.Value = Convert.ToString(dr["oid"]);
                        node.NavigateUrl = "";
                        parNode.ChildNodes.Add(node);
                        this.BindChildNode(dstMenu, node);
                    }
                }
            }
        }
        #endregion
    }
}