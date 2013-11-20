using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Whf.TuoPu.Entity;
using Whf.TuoPu.Controller;
using Whf.TuoPu.Common;

namespace Whf.TuoPu.Web.BasicData
{
    public partial class Editperson : System.Web.UI.Page
    {
        #region 事件
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                string personID = Request.QueryString["PersonID"] ?? "";
                hdfPersonID.Value = personID;
                if (!string.IsNullOrEmpty(personID))
                { 
                    
                }
            }
        }
        #endregion

        #region 方法
        private void BindControls()
        {
            PersonEntity person = new PersonController().GetPersonInfo(this.hdfPersonID.Value);
            if (person != null)
            {
                txtEmail.Text = person.PERSONEMAIL;
                txtMobilPhone.Text = person.PERSONMOBILEPHONE;
                txtOfficePhone.Text = person.PERSONOFFICEPHONE;
                txtPersonAccount.Text = person.PERSONACCOUNT;
                txtPersonMemo.Text = person.PERSONMEMO;
                txtPersonName.Text = person.PERSONNAME;
                drpPersonSex.SelectedValue = person.PERSONSEX.ToString();
                drpPersonStatus.SelectedValue = person.PERSONSTATUS.ToString();
                drpPersonType.SelectedValue = person.PERSONTYPE.ToString();
            }
        }

        private void BindDropdownList()
        { 
            drpPersonSex.Items.Clear();
            drpPersonSex.Items.Add(new ListItem(CommonMessage.Male,PersonSex.Male.GetHashCode().ToString());
            drpPersonSex.Items.Add(new ListItem(CommonMessage.Female,PersonSex.Female.GetHashCode().ToString());
        }
        #endregion
    }
}