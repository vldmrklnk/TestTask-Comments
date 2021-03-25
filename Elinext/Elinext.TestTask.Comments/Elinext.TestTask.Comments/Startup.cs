using Elinext.TestTask.Comments.BLL.Interfaces;
using Elinext.TestTask.Comments.BLL.Interfasces;
using Elinext.TestTask.Comments.BLL.Providers;
using Elinext.TestTask.Comments.BLL.Services;
using Elinext.TestTask.Comments.DAL;
using Elinext.TestTask.Comments.DAL.Interfaces;
using Elinext.TestTask.Comments.DAL.Repositories;
using Elinext.TestTask.Comments.DAL.UnitOfWork;
using Elinext.TestTask.Comments.Interfaces;
using Elinext.TestTask.Comments.Providers;
using Elinext.TestTask.Comments.Services;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Elinext.TestTask.Comments
{
	public class Startup
	{
		public Startup(IConfiguration configuration)
		{
			Configuration = configuration;
		}

		public IConfiguration Configuration { get; }

		public void ConfigureServices(IServiceCollection services)
		{
			services.AddControllersWithViews();
			services.AddScoped<ArticleWithCommentsContext>();
			services.AddTransient<IUnitOfWork, UnitOfWork>();
			services.AddTransient<IRepository<Article>, ArticleRepository>();
			services.AddTransient<IRepository<Comment>, CommentRepository>();
			services.AddTransient<IArticleProvider, ArticleProvider>();
			services.AddTransient<ICommentProvider, CommentProvider>();
			services.AddTransient<IArticleViewModelProvider, ArticleViewModelProvider>();
			services.AddTransient<ICommentViewModelProvider, CommentViewModelProvider>();
			services.AddTransient<ICommentCreatorService, CommentCreatorService>();
			services.AddTransient<ICommentCreator, CommentCreator>();
		}

		public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
		{
			if (env.IsDevelopment())
			{
				app.UseDeveloperExceptionPage();
			}
			else
			{
				app.UseExceptionHandler("/Home/Error");

				app.UseHsts();
			}
			app.UseHttpsRedirection();
			app.UseStaticFiles();

			app.UseRouting();

			app.UseAuthorization();

			app.UseEndpoints(endpoints =>
			{
				endpoints.MapControllerRoute(
					name: "default",
					pattern: "{controller=Article}/{action=Article}");
			});
		}
	}
}
