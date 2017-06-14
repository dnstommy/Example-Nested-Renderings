using Sitecore.Data.Items;
using Sitecore.Mvc.Presentation;
using System.Linq;

namespace ExampleRendering.Repositories
{
    public class BannerRepository : IBannerRepository
    {
        public Models.BannerModel GetBanners()
        {
            var datasource = RenderingContext.Current.Rendering.Item;

            if (datasource.TemplateID != Constants.Templates.Banners)
                return null;

            return new Models.BannerModel { Banners = datasource.Children.Cast<Item>().ToList() };

        }
    }
}