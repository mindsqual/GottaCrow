using System;

namespace GottaCrowWebUI.Utilities
{
    public interface IDateTime
    {
        DateTime UtcNow { get; }
    }
}