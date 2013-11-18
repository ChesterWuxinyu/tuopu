using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Whf.TuoPu.Controller;
using System.Data;

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
        }

        private void btnQuery_Click(object sender, EventArgs e)
        {
            this.BindTree();
        }

        #endregion

        #region 方法
        private void BindTree()
        {
            FunctionController controller = new FunctionController();
            DataSet dstMenu = controller.QueryFunctions(this.txtFunCode.Text.Trim(), this.txtFunName.Text.Trim());
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