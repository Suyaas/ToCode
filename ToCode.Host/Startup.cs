using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Suyaa.Hosting.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToCode.Infrastructure;

namespace ToCode.Host
{
    /// <summary>
    /// 启动器
    /// </summary>
    public class Startup : StartupBase
    {
        /// <summary>
        /// 启动器
        /// </summary>
        /// <param name="configuration"></param>
        public Startup(IConfiguration configuration) : base(configuration)
        {
        }

        protected override void OnConfigureServices(IServiceCollection services)
        {
            base.OnConfigureServices(services);
            // 添加模块注册
            services.AddModuler<Base.Apps.ModuleStartup>();
        }
    }
}
