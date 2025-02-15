using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Sample_Net5
{
    using SKIT.FlurlHttpClient.Wechat.TenpayV3.Settings;

    public class Startup
    {
        public IConfiguration Configuration { get; }

        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();

            // 注入配置项
            services.AddOptions();
            services.Configure<Options.TenpayOptions>(Configuration.GetSection(nameof(Options.TenpayOptions)));

            // 注入工厂 HTTP 客户端
            services.AddHttpClient();
            services.AddSingleton<CertificateManager, InMemoryCertificateManager>();
            services.AddSingleton<Services.HttpClients.IWechatTenpayHttpClientFactory, Services.HttpClients.Implements.WechatTenpayHttpClientFactory>();

            // 注入后台任务
            services.AddHostedService<Services.BackgroundServices.TenpayCertificateRefreshingBackgroundService>();
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
