using BusinessLayer.Abstract;
using BusinessLayer.Concrete;
using DataAccessLayer.Abstract;
using DataAccessLayer.EntityFramework;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddScoped<IFeatureService,FeatureManager>();
builder.Services.AddScoped<IFeatureDal,EfFeatureDal>();
builder.Services.AddScoped<IAboutService,AbouteManager>();
builder.Services.AddScoped<IAboutDal,EfAboutDal>();
builder.Services.AddScoped<IServiceService,ServiceManager>();
builder.Services.AddScoped<IServiceDal,EfServiceDal>();
builder.Services.AddScoped<ISkillService,SkillManager>();
builder.Services.AddScoped<ISkillDal,EfSkillDal>();
builder.Services.AddScoped<IPortfolioService,PortfolioManager>();
builder.Services.AddScoped<IPortfoiloDal,EfPortfoiloDal>();
builder.Services.AddScoped<IExperienceService,ExperienceManager>();
builder.Services.AddScoped<IExperienceDal,EfExperienceDal>();
builder.Services.AddScoped<ITestimonialService,TestimonialManager>();
builder.Services.AddScoped<ITestimonialDal,EfTestimonialDal>();
builder.Services.AddScoped<IMessageService,MessageManager>();
builder.Services.AddScoped<IMessageDal,EfMessageDal>();
builder.Services.AddScoped<ISocialMediaService,SocialMediaManager>();
builder.Services.AddScoped<ISocialMediaDal,EfSocialMediaDal>();
builder.Services.AddScoped<IContactService,ContactManager>();
builder.Services.AddScoped<IContactDal,EfContactDal>();
builder.Services.AddScoped<IUserService,UserManager>();
builder.Services.AddScoped<IUserDal,EfUserDal>();
builder.Services.AddScoped<IUserMessageService,UserMessageManager>();
builder.Services.AddScoped<IUserMessageDal,EfUserMessageDal>();
builder.Services.AddScoped<IToDoListService,ToDoListManager>();
builder.Services.AddScoped<IToDoListDal,EfToDoListDal>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.UseEndpoints(endpoints =>
{
    endpoints.MapControllerRoute(
      name: "areas",
      pattern: "{area:exists}/{controller=Default}/{action=Index}/{id?}"
    );
});


app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
