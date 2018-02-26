namespace Sitecore.Support.Web.Pipelines.InitializeSpeakLayout
{
  using System.Web;
  using Sitecore.Configuration;
  using Sitecore.Web.Pipelines.InitializeSpeakLayout;

  public class DisableCaching
  {
    public void Process(InitializeSpeakLayoutArgs args)
    {
      if (Settings.DisableBrowserCaching)
      {
        HttpContext.Current.Response.Cache.SetNoStore();
        HttpContext.Current.Response.Cache.SetCacheability(HttpCacheability.NoCache);
      }
    }
  }
}