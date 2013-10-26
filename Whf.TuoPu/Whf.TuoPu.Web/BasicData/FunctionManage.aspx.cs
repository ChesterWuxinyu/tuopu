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
                this.BindGrid(1);
            }
        }

        protected override void OnInit(EventArgs e)
        {
            this.btnQuery.Click += new EventHandler(btnQuery_Click);
            this.Navigator.Paging += new Web.Controls.Navigator.PagingEventHandler(Navigator_Paging);
            base.OnInit(e);
        }

        private void btnQuery_Click(object sender, EventArgs e)
        {
            this.BindGrid(1);
        }

        private void Navigator_Paging(object sender, Controls.Navigator.PagingEventArgs e)
        {
            this.BindGrid(e.NewPage);
        }
        #endregion

        #region 方法
        private void BindGrid(int pageIndex)
        {
            FunctionController controller = new FunctionController();
            int rowCount = 0;
            DataSet dst = controller.QueryFunctions(pageIndex, 10, out rowCount,this.txtPFunName.Text.Trim(),this.txtFunName.Text.Trim(),this.txtLevel.Text.Trim());
            this.Navigator.TotalCount = rowCount;
            this.gvTest.DataSource = dst.Tables[0];
            this.gvTest.DataBind();
        }
        #endregion
    }
}