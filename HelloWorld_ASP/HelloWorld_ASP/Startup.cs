﻿using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(HelloWorld_ASP.Startup))]
namespace HelloWorld_ASP
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
