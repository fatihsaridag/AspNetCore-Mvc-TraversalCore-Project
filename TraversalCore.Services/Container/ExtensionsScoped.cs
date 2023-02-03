using FluentValidation;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TraversalCore.Data.EntityFramework.Repository.Abstract;
using TraversalCore.Data.EntityFramework.Repository.Concrete;
using TraversalCore.DTOs.AnnouncementDTOs;
using TraversalCore.Services.Abstract;
using TraversalCore.Services.Concrete;
using TraversalCore.Services.ValidationRules;

namespace TraversalCore.Services.Container
{
    public static class ExtensionsScoped
    {
        public static void ContainerDependencies(this IServiceCollection services)
        {
            services.AddScoped<IDestinationService, DestinationManager>();
            services.AddScoped<IDestinationRepository, EfDestinationRepository>();

            services.AddScoped<ICommentService, CommentManager>();
            services.AddScoped<ICommentRepository, EfCommentRepository>();

            services.AddScoped<IReservationService, ReservationService>();
            services.AddScoped<IReservationRepository, EfReservationRepository>();

            services.AddScoped<IGuideService, GuideManager>();
            services.AddScoped<IGuideRepository, EfGuideRepository>();

            services.AddScoped<IExcelService, ExcelManager>();
            services.AddScoped<IPdfService, PdfManager>();

            services.AddScoped<IContactUsRepository, EfContactUsRepository>();
            services.AddScoped<IContactUsService, ContactUsManager>();


            services.AddScoped<IAnnouncementRepository, EfAnnouncementRepository>();
            services.AddScoped<IAnnouncementService, AnnouncementManager>();

        }

        public static void CustomerValidator(this IServiceCollection services)
        {
            services.AddTransient<IValidator<AnnouncementAddDto>, AnnouncementValidator>();
            services.AddTransient<IValidator<AnnouncementUpdateDto>, AnnouncementUpdateValidator>();

        }

    }
}
