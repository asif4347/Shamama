﻿using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebPhase2.Startup))]
namespace WebPhase2
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
