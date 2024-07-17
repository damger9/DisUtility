using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiscordUtilities.Timestamps {
    public enum ETimestampVariant {
        /// <summary>
        /// Example: "10:12AM" 
        /// </summary>
        ShortTime = 116,
        /// <summary>
        /// Example: "10:12:00AM" 
        /// </summary>
        LongTime = 84,
        /// <summary>
        /// Example: "7/17/24" or "17/7/24" (Depends on the user that sees the timestamp, Discord localizes it. 
        /// </summary>
        ShortDate = 100,
        /// <summary>
        /// Example: "July 17, 2024" 
        /// </summary>
        LongDate = 68,
        /// <summary>
        /// Example: "July 17, 2024 at 10:12AM" 
        /// </summary>
        ShortDateTime = 102,
        /// <summary>
        /// Example: "Wednesday, July 17, 2024 at 10:12AM" 
        /// </summary>
        LongDateTime = 70,
    }
}
