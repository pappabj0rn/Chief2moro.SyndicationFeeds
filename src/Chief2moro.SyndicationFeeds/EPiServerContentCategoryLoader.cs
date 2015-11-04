using System.Collections.Generic;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.ServiceLocation;

namespace Chief2moro.SyndicationFeeds
{
    public class EPiServerContentCategoryLoader : IContentCategoryLoader
    {
        public IEnumerable<string> GetContentCategories(IContent content)
        {
            var categorizable = content as ICategorizable;
            if (categorizable == null) yield break;

            var categoryRepository = ServiceLocator.Current.GetInstance<CategoryRepository>();
            foreach (var category in categorizable.Category)
            {
                yield return categoryRepository.Get(category).Description;
            }
        }
    }
}