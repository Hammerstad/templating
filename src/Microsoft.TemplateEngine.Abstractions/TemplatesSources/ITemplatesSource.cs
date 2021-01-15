using System;

namespace Microsoft.TemplateEngine.Abstractions.TemplatesSources
{
    public interface ITemplatesSource
    {
        DateTime LastChangeTime { get; }

        string MountPointUri { get; }

        /// <summary>
        /// This is provider that created this source.
        /// This is mostly helper for grouping sources by provider
        /// so caller doesn't need to keep track of provider->source relation.
        /// </summary>
        ITemplatesSourcesProvider Provider { get; }
    }
}
