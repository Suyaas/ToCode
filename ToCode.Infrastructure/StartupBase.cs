using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Suyaa;
using Suyaa.Hosting;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToCode.Infrastructure
{
    /// <summary>
    /// 启动器
    /// </summary>
    public abstract class StartupBase : Suyaa.Hosting.StartupBase
    {

        /// <summary>
        /// 启动器
        /// </summary>
        /// <param name="configuration"></param>
        public StartupBase(IConfiguration configuration) : base(configuration)
        {
        }

        protected override void OnConfigure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            //throw new NotImplementedException();
        }

        protected override void OnConfigureServices(IServiceCollection services)
        {
            //throw new NotImplementedException();
        }

        protected override void OnInitialize()
        {
            //throw new NotImplementedException();
        }
    }
}
