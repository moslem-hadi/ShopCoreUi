using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Razor;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using Webtina.UI.Core.Infrastructure;
using Webtina.UI.Models;
using Webtina.UI.Services;
using Webtina.UI.Services.Middleware;
using Webtina.UI.Services.Services;

namespace Webtina.UI.Web
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllersWithViews();
            services.AddHttpContextAccessor();
            services.AddScoped<ITenantAccessor, TenantAccessor>();
            services.AddScoped<ITanentService, TanentService>();
            services.AddScoped<IProductService, ProductService>();
            services.AddScoped<IUserService, UserService>();
            services.AddScoped<IDapperService<object>, DapperService<object>>();
            services.AddScoped<ICommonService, CommonService>();
            services.AddScoped<IPageService, PageService>();

            services.Configure<AppSettings>(Configuration.GetSection("AppSettings"));
            services.AddMemoryCache();

            services.AddResponseCaching();

            services.AddMemoryCache();


            //ViewLocationExpander 
            //برای اینکه پوشه ویو ها رو سرچ کنه
            services.Configure<RazorViewEngineOptions>(options =>
            {
                options.ViewLocationExpanders.Add(new TenantViewLocationExpander());
            });

            /////https://mjebrahimi.github.io/SeoTags/
            //services.AddSeoTags(seoInfo =>
            //{
            //    seoInfo.SetSiteInfo(
            //        siteTitle: "Osveh Asia",
            //        robots: "index, follow"  //optional
            //    );
            //});
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            //app.UseCustomExceptionHandler();//باید اولین میدلور باشه که بتونه همه خطاها رو بگیره

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseStatusCodePagesWithReExecute("/error/{0}");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            // app.UseHttpsRedirection();
            app.UseStaticFiles(new StaticFileOptions()
            {
                HttpsCompression = Microsoft.AspNetCore.Http.Features.HttpsCompressionMode.Compress,
                OnPrepareResponse = (context) =>
                {
                    var headers = context.Context.Response.GetTypedHeaders();
                    headers.CacheControl = new Microsoft.Net.Http.Headers.CacheControlHeaderValue
                    {
                        Public = true,
                        MaxAge = TimeSpan.FromDays(30)
                    };
                }
            });

            app.UseMultiTenancy();


            app.UseResponseCaching();

            app.UseRouting();

            //app.UseAuthorization();

            app.UseMiddleware(typeof(VisitorCounterMiddleware));
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "DefaultLocalized",
                    pattern: "{culture=fa}/{controller=Home}/{action=Index}/{id?}");

                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });


        }
    }
}
