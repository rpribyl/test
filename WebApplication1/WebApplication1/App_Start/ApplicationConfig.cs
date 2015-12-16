using Kentico.Web.Mvc;

namespace WebApplication1
{
    public class ApplicationConfig
    {
        public static void RegisterFeatures(ApplicationBuilder builder)
        {
            builder.UsePreview();
            builder.UseDataAnnotationsLocalization();
            builder.UseNotFoundHandler();
        }
    }
}
