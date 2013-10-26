using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using Whf.TuoPu.Controller;

namespace Whf.TuoPu.Web.BasicData
{
    public partial class PersonManage : BasePage
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
            this.Navigator.Paging += new Web.Controls.Navigator.PagingEventHandler(Navigator_Paging);
            this.btnQuery.Click += new EventHandler(btnQuery_Click);
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
            PersonController controller = new PersonController();
            int rowCount = 0;
            DataSet dst = controller.QueryPersons(pageIndex, 10, out rowCount,this.txtEmpNO.Text.Trim(),this.txtEmpName.Text.Trim());
            this.Navigator.TotalCount = rowCount;
            this.gvTest.DataSource = dst.Tables[0];
            this.gvTest.DataBind();
        }
        #endregion
    }
}