﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Consumidor
{
    public partial class Principal : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            WebServiceBD.WebService1SoapClient WS = new WebServiceBD.WebService1SoapClient();
                DataSet ds = WS.GetData();
            GridView1.DataSource = ds.Tables[0];
            GridView1.DataBind();
        }
    }
}