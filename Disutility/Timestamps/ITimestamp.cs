using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiscordUtilities.Timestamps {
    public interface ITimestamp {
        string GetRelative(DateTimeOffset timestamp);
        string GetRelative(DateTime timestamp);
        string GetRelative();
        string GetAbsolute(DateTime timestamp, ETimestampVariant timestampVariant);
    }
}
