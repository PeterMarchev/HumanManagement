using AutoMapper;
using HumanManagement.Extensions;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Services.Profiles;

namespace HumanManagement
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
            services.AddNHibernateSessionFactory(Configuration.GetConnectionString("DbConnection"));
            services.AddNHibernateIdentity();

            services.AddAutoMapper(/*typeof(EmployeeProfile), */typeof(EmployeeSMProfile),
                                  /*typeof(AttendanceProfile),*/ typeof(AttendanceSMProfile),
                                  /*typeof(CompanyProfile),*/ typeof(CompanySMProfile),
                                  /*typeof(CountryProfile),*/ typeof(CountrySMProfile),
                                  /*typeof(DepartmentManagerProfile),*/ typeof(DepartmentManagerSMProfile),
                                  /*typeof(DepartmentProfile),*/ typeof(DepartmentSMProfile),
                                  /*typeof(EmergencyContactsProfile),*/ typeof(EmergencyContactsSMProfile),
                                  /*typeof(JobProfile),*/ typeof(JobSMProfile),
                                  /*typeof(LocationProfile), */typeof(LocationSMProfile),
                                  /*typeof(SalaryHistoryProfile),*/ typeof(SalaryHistorySMProfile),
                                  /*typeof(SalaryProfile),*/ typeof(SalarySMProfile),
                                  /*typeof(ScheduleProfile),*/ typeof(ScheduleSMProfile),
                                  typeof(UserSMProfile), typeof(UserSMProfile),
                                  //typeof(UserProfile), typeof(RoleProfile),
                                  /*typeof(PeriodicityProfile),*/ typeof(PeriodicitySMProfile));
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseRouting();
            app.UseAuthentication();
            app.UseAuthorization();


            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
