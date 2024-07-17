using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiscordUtilities.Timestamps {
    public class Timestamp : ITimestamp {
        /// <summary>
        /// Returns a relative timestamp that will for example render as "5 seconds ago" on Discord.
        /// Will default to the current time if none is supplied. Overloads for DateTime and DateTimeOffset are available
        /// </summary>
        /// <returns>The relative timestamp string</returns>
        public string GetRelative() {
            long now = new DateTimeOffset().ToUnixTimeSeconds();
            return $"<t:{now.ToString()}:R>";

        }
        /// <summary>
        /// Returns a relative timestamp that will for example render as "5 seconds ago" on Discord.
        /// </summary>
        /// <param name="timestamp">The Date to use for the timestamp</param>
        /// <returns>The relative timestamp string</returns>
        public string GetRelative(DateTime timestamp) {
            long time = ((DateTimeOffset)timestamp).ToUnixTimeSeconds();
            return $"<t:{time.ToString()}:R>";
        }
        /// <summary>
        /// Returns a relative timestamp that will for example render as "5 seconds ago" on Discord.
        /// </summary>
        /// <param name="timestamp">The Date to use for the timestamp</param>
        /// <returns>The relative timestamp string</returns>
        public string GetRelative(DateTimeOffset timestamp) {
            return $"<t:{timestamp.ToUnixTimeSeconds().ToString()}:R>";
        }
        /// <summary>
        /// Returns an absolute timestamp that will for example render as "10:12AM" on Discord, there are also types for full dates instead of just the hour and minute. 
        /// </summary>
        /// <param name="timestamp">The Date to use for the timestamp</param>
        /// <param name="timestampVariant">The timestamp variant to use for the timestamp</param>
        /// <returns>The absolute timestamp string</returns>
        public string GetAbsolute(DateTime timestamp, ETimestampVariant timestampVariant) {
            long time = ((DateTimeOffset)timestamp).ToUnixTimeSeconds();
            return $"<T:{time.ToString()}:{(char)timestampVariant}>";
        }
    }
}
