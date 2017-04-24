using System;

namespace JobSearch.Common
{
    public interface IDateTime
    {
        DateTime UtcNow { get; }
    }
}