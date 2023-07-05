using HIMS.Data;
using HIMS.Data.Master;
using HIMS.Data.Opd;
using HIMS.Model.Transaction;
using HIMS.Model;

using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Net;
using System.Text;
using HIMS.Data.Opd.OP;
using HIMS.Data.Transaction;
using HIMS.Data.Master.Billing;

namespace HIMS.API.Extensions
{
    public static class ServiceExtension
    {
        public static void AddLinuxApacheConfiguration(this IServiceCollection services, IConfiguration configuration)
        {
            //configuration for linux apache
            services.Configure<ForwardedHeadersOptions>(options =>
            {
                options.KnownProxies.Add(IPAddress.Parse(configuration.GetValue<string>("AppSettings:IPAddress")));
            });
        }

        public static void AddMyCors(this IServiceCollection services)
        {
            services.AddCors(options =>
            {
                options.AddPolicy("CorsPolicy",
                    builder => builder.AllowAnyOrigin()
                    .AllowAnyMethod()
                    .AllowAnyHeader()
                    //.AllowCredentials()
                    );
            });
        }

        public static void AddMyConfiguration(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddOptions();
            services.Configure<AppSettings>(configuration.GetSection(nameof(AppSettings)));
            services.AddSingleton(resolver => resolver.GetRequiredService<IOptions<AppSettings>>().Value);
        }

        public static void AddMyDependancies(this IServiceCollection services, IConfiguration configuration)
        {
            //var conn = configuration.GetValue<string>("AppSettings:ConnectionString");
            //Get Env from EnvVariable
            var conn = configuration.GetValue<string>("AppSettings:CONNECTION_STRING");
            services.AddScoped(sqc => new SqlConnection(conn));
            services.AddScoped<IUnitofWork, UnitofWork>();
            services.AddScoped<IGenericRepository, GenericRepository>();
           
            services.AddTransient<IGenericComboRepository, GenericComboRepository>();
            services.AddTransient<IComboboxRepository, ComboboxRepository>();
            services.AddTransient<I_MenuMaster, R_MenuMaster>();
            services.AddTransient<I_MenuMasterDetails, R_MenuMasterDetails>();
            services.AddTransient<I_MenuMasterDetails_Details, R_MenuMasterDetails_Details>();
            services.AddTransient<I_SS_RoleTemplateMaster, R_SS_RoleTemplateMaster>();
            services.AddTransient<I_DynamicExecuteSchedule, R_DynamicExecuteSchedule>();
           
            services.AddTransient<I_Configsetting, R_Configsetting>();
            services.AddTransient<IGenericComboRepository, GenericComboRepository>();
            services.AddTransient<IComboboxRepository, ComboboxRepository>();
           
            services.AddTransient<I_LoginManager, R_LoginManager>();
            services.AddTransient<I_IssueTracking_Sw, R_IssueTracking_Sw>();
            services.AddTransient<I_MenuMaster, R_MenuMaster>();
            services.AddTransient<I_MenuMasterDetails, R_MenuMasterDetails>();
            services.AddTransient<I_MenuMasterDetails_Details, R_MenuMasterDetails_Details>();
            //services.AddTransient<I_PayTranModeMaster, R_PayTranModeMaster>();
            services.AddTransient<I_ProjectInformation, R_ProjectInformation>();
            services.AddTransient<I_Sw_Bill_info, R_Sw_Bill_info>();

            //CRMS
            services.AddTransient<I_Department, R_Department>();
            services.AddTransient<I_DepartmentType, R_DepartmentType>();
            services.AddTransient<I_Registration, R_Registration>();
            services.AddTransient<I_Bill, R_Bill>();
           services.AddTransient<I_StateMaster, R_StateMaster>();
            services.AddTransient<I_AreaMaster, R_AreaMaster>();
            services.AddTransient<I_CountryMaster, R_CountryMaster>();
            services.AddTransient<I_ReligienMaster, R_ReliginMaster>();
            services.AddTransient<I_CaseDetail, R_CaseDetail>();
            services.AddTransient<I_DoctorMaster, R_DoctorMaster>();

            services.AddTransient<I_AreaMaster, R_AreaMaster>();
            services.AddTransient<I_CityMaster, R_CityMaster>();
            services.AddTransient<I_CountryMaster, R_CountryMaster>();
            services.AddTransient<I_ReligienMaster, R_ReliginMaster>();
           // services.AddTransient<I_RelationshipMaster, R_RelationshipMaster>(); 
            services.AddTransient<I_StateMaster, R_StateMaster>();
            // services.AddTransient<I_CaseDetail, R_CaseDetail>();

            services.AddTransient<I_ClassMaster,R_ClassMaster>();
            services.AddTransient<I_ConcessionReasion, R_ConcessionReasion>();
            services.AddTransient<I_CompanyMaster, R_CompanyMaster>();
            services.AddTransient<I_ServiceMaster, R_ServiceMaster>();
            services.AddTransient<I_BankMaster, R_BankMaster>();
            services.AddTransient<I_PatientType, R_PatientType>();
            services.AddTransient<I_DoctorTypeMaster, R_DoctorTypeMaster>();
            services.AddTransient<I_CompanyTypeMaster, R_CompanyTypeMaster>();
            services.AddTransient<I_Payment, R_Payment>();
            services.AddTransient<I_VisitMaster, R_VisitMaster>();
            services.AddTransient<I_CashCounterMaster, R_CashCounterMaster>();
            services.AddTransient<I_TariffMaster, R_TariffMaster>();
            services.AddTransient<I_GroupMaster, R_GroupMaster>();
            services.AddTransient<I_SubGroupMaster, R_SubGroupMaster>();
            services.AddTransient<I_PrefixMaster,R_PrefixMaster>();
            services.AddTransient<I_MaritalStatusMaster, R_MaritalStatusMaster>();
            services.AddTransient<I_GenderMaster, R_GenderMaster>();

            services.AddTransient<I_CompanyDetail, R_CompanyDetail>();
            services.AddTransient<I_InvoiceBillMapping, R_InvoiceBillMapping>();
        }

        public static void AddMyAuthentication(this IServiceCollection services, IConfiguration configuration)
        {
            // configure strongly typed settings objects
            //var appSettingsSection = configuration.GetSection("AppSettings");
            //services.Configure<AppSettings>(appSettingsSection);

            // configure jwt authentication
            //var appSettings = appSettingsSection.Get<AppSettings>();
            var secret = configuration.GetValue<string>("AppSettings:SECRET");
            //var secret = Environment.GetEnvironmentVariable("SECRET");
            var key = Encoding.ASCII.GetBytes(secret);

            services.AddAuthentication(x =>
            {
                x.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                x.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
            })
            .AddJwtBearer(x =>
            {
                x.RequireHttpsMetadata = false;
                x.SaveToken = true;
                x.TokenValidationParameters = new TokenValidationParameters
                {
                    ValidateIssuerSigningKey = true,
                    IssuerSigningKey = new SymmetricSecurityKey(key),
                    ValidateIssuer = false,
                    ValidateAudience = false
                };
            });

            services.AddAuthorization();
        }

        public static void AddMySwagger(this IServiceCollection services)
        {
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo
                {
                    Version = "v1",
                    Title = "CRMS API",
                    Description = "Clinical Management System"
                });
                c.AddSecurityDefinition("Bearer",
                    new OpenApiSecurityScheme
                    {
                        Description = "JWT Authorization header using the Bearer scheme. \r\n\r\n Enter 'Bearer' [space] and then your token in the text input below.\r\n\r\nExample: \"Bearer 12345abcdef\"",
                        Name = "Authorization",
                        In = ParameterLocation.Header,
                        Type = SecuritySchemeType.ApiKey,
                        Scheme = "Bearer"
                    });
                c.AddSecurityRequirement(
                    new OpenApiSecurityRequirement {
                        {
                            new OpenApiSecurityScheme
                            {
                                Reference = new OpenApiReference
                                {
                                    Type = ReferenceType.SecurityScheme,
                                    Id = "Bearer"
                                },
                                Scheme = "oauth2",
                                Name = "Bearer",
                                In = ParameterLocation.Header,
                            },
                            new List<string>()
                        }
                    });
            });
        }

    }
}
