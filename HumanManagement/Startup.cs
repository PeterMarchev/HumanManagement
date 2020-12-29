using AutoMapper;
using HumanManagement.Data.Patterns;
using HumanManagement.Extensions;
using HumanManagement.Models.Profiles;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc.Authorization;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Services.Implementations;
using Services.Interfaces;
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
            services.AddNHibernateSessionFactory(Configuration.GetConnectionString("DbConnection"));
            services.AddNHibernateIdentity();

            services.AddAutoMapper(typeof(EmployeeProfile), typeof(EmployeeSMProfile),
                                  typeof(AttendanceProfile), typeof(AttendanceSMProfile),
                                  typeof(CompanyProfile), typeof(CompanySMProfile),
                                  typeof(CountryProfile), typeof(CountrySMProfile),
                                  typeof(DepartmentManagerProfile), typeof(DepartmentManagerSMProfile),
                                  typeof(DepartmentProfile), typeof(DepartmentSMProfile),
                                  typeof(EmergencyContactsProfile), typeof(EmergencyContactsSMProfile),
                                  typeof(JobProfile), typeof(JobSMProfile),
                                  typeof(LocationProfile), typeof(LocationSMProfile),
                                  typeof(SalaryHistoryProfile), typeof(SalaryHistorySMProfile),
                                  typeof(SalaryProfile), typeof(SalarySMProfile),
                                  typeof(ScheduleProfile), typeof(ScheduleSMProfile),
                                  typeof(UserSMProfile), typeof(RoleSMProfile),
                                  typeof(UserProfile), typeof(RoleProfile),
                                  typeof(PeriodicityProfile), typeof(PeriodicitySMProfile));

services.AddTransient<IEmployeeService, EmployeeService>();


services.ConfigureApplicationCookie(options => options.LoginPath = "/Account/Login");


services.AddScoped(typeof(IRepository<>), typeof(Repository<>))
.AddScoped(typeof(IUnitOfWork), typeof(UnitOfWork));
services.AddMvc(options =>
{
// This pushes users to login if not authenticated
options.Filters.Add(new AuthorizeFilter());
});
services.AddControllersWithViews();

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
