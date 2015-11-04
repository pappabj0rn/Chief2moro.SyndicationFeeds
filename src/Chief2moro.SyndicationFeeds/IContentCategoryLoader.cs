using System.Collections.Generic;
using EPiServer.Core;

namespace Chief2moro.SyndicationFeeds
{
    public interface IContentCategoryLoader
    {
        IEnumerable<string> GetContentCategories(IContent content);
    }
}