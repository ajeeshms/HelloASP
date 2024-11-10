﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HelloASP.Customization {
    public class CustomHeaderModule : IHttpModule {
        public void Dispose() {
            
        }

        public void Init(HttpApplication context) {
            context.EndRequest += Context_EndRequest;
        }

        private void Context_EndRequest(object sender, EventArgs e) {
            HttpContext context = ((HttpApplication)sender).Context;
            context.Response.Headers.Add("X-Server-Time", DateTime.Now.ToString("o"));
        }
    }
}