﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using Whf.TuoPu.Controller;

namespace Whf.TuoPu.Web.Portal
{
    public partial class Left : BasePage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                //this.tvMenu.ExpandImageUrl = @"..\images\icons\TreeViewClose.gif";
                //this.tvMenu.CollapseImageUrl = @"..\images\icons\Open.gif";
                this.BindTree();
            }
        }

        private void BindTree()
        {
            FunctionController controller = new FunctionController();
            DataSet dstMenu = controller.GetAllFunctions();
            if (dstMenu == null || dstMenu.Tables[0].Rows.Count <= 0)
            {
                TreeNode node = new TreeNode();
                node.Text = "系统功能";
                node.Value = "";
                node.NavigateUrl = "";
                this.tvMenu.Nodes.Add(node);
            }
            else
            {
                DataRow[] drs = dstMenu.Tables[0].Select("functionparentid='0'");
                if (drs.Length > 0)
                {
                    foreach (DataRow dr in drs)
                    {
                        TreeNode node = new TreeNode();
                        node.Text = Convert.ToString(dr["functionname"]);
                        node.Value = Convert.ToString(dr["oid"]);
                        node.NavigateUrl = Convert.ToString(dr["functionurl"]);
                        node.Target = "main";
                        this.BindChildNode(dstMenu, node);
                        this.tvMenu.Nodes.Add(node);
                    }
                }
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
                        node.NavigateUrl = Convert.ToString(dr["functionurl"]);
                        node.Target = "main";
                        this.BindChildNode(dstMenu, node);
                        parNode.ChildNodes.Add(node);
                    }
                }
            }
        }
    }
}