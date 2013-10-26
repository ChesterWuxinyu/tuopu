using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using Whf.TuoPu.Common;

namespace Whf.TuoPu.Web
{
    public class BasePage : Page
    {
        protected override void OnPreInit(EventArgs e)
        {
            if (Session["PersonOID"] == null)
            {
                Response.Redirect(@"..\RedirectPage.aspx");
            }
            base.OnInit(e);
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
        }
    }
}