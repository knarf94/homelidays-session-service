﻿using System;
using System.Threading;
using Homelidays.Web.SessionService;

public partial class SessionService_Test : SessionPage
{
    protected void Page_Load(object sender, EventArgs e)
    {
        var sess = this.AspSession;
        this.AspSession["DotNetIntValue"] = 12;
        foreach (var item in sess)
        {
            LContentSess.Text += "Key : " + item.Key + " Value : " + item.Value + "<br/>"; 
        }

        if (((int)this.AspSession["DotNetIntValue"]) == 12)
        {
            Response.Write("Bug this.AspSession[\"DotNetIntValue\"] == 12 corrigé");
        }

        Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");
        Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("en-US");
        this.AspSession["DotNetDecimal"] = 3.14;
    }
}