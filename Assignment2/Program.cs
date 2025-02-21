namespace Assignment2
{
    public class Program
    {
        public static void Main(string[] args)
        {
            #region  ConfigureServices

            var WebApplicationBuilder = WebApplication.CreateBuilder();



            WebApplicationBuilder.Services.AddControllersWithViews();

            //This adds MVC (Model-View-Controller) services in the dependency injection container.




            #endregion



            var app = WebApplicationBuilder.Build();


 

            if (app.Environment.IsDevelopment()) 
            {
                app.UseDeveloperExceptionPage(); //for exceptions in development Mode
            }

            else
            {

                app.UseExceptionHandler("/Home/Error");
 
            }



            //----------------------------------------------------------------------------------------------
            app.UseStaticFiles(); //to use css , imgs

            app.UseRouting(); //->Decides which controller/action to call {Middleware}.







            //app.MapGet("", async context =>

            //await context.Response.WriteAsync("Hello World")
            //);




            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers(); // Maps attribute-routed controllers
            });







            app.MapControllerRoute(
                name: "DefaultRoute",
                pattern: "{Controller=Home}/{action=Index}/{id:int:length(2,4)?}/{title?}"  //segments
                 );

            // Https://url:portNumber/UrlPath/Segment
            //UrlPath-->ControllerName/actionName/Parameter for the Action
            //{Segment} --> static , Variable , Mixed
            //constraints

            app.Run(); 

            //This starts the Kestrel web server and begins listening for HTTP requests.
        }
    }
}
