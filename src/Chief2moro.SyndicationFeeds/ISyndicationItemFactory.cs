using System.Collections.Generic;
using System.ServiceModel.Syndication;
using Chief2moro.SyndicationFeeds.Models;

namespace Chief2moro.SyndicationFeeds
{
    public interface ISyndicationItemFactory
    {
        /// <summary>
        /// Gets a list of populated syndication items created from the dependent content references on the gived SyndicationFeedPage.
        /// </summary>
        /// <returns></returns>
        IEnumerable<SyndicationItem> GetSyndicationItems(SyndicationFeedPageType feedPage);
    }
}