using ExpressNetCore;
using Microsoft.AspNetCore.Authentication;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using React.Data;
using React.Models;

ExpressApp app = new ExpressApp(args);

app.AddDbContext<ApplicationDbContext>((options, configuration) => {
	options.UseSqlServer(configuration.GetConnectionString("DefaultConnection"));
});

app.AddDefaultIdentity<ApplicationUser>(options => options.SignIn.RequireConfirmedAccount = true)
	.AddEntityFrameworkStores<ApplicationDbContext>();

app.AddIdentityServer()
	.AddApiAuthorization<ApplicationUser, ApplicationDbContext>();

app.AddAuthentication()
	.AddIdentityServerJwt();

app.AddSpa(sourcePath: "ClientApp", buildPath: "ClientApp/build", devServerNpmScript: "start");

app.Run();
