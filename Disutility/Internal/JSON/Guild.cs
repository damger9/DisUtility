using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Disutility.Internal.JSON {
    /// <summary>
    /// Class representing a discord guild.
    /// </summary>
    internal class Guild {
        /// <summary>
        /// The id of the guild (technically a snowflake)
        /// </summary>
        public string id { get; set; }
        /// <summary>
        /// The name of the guild.
        /// </summary>
        public string name { get; set; }
        /// <summary>
        /// The guild's icon hash, if any.
        /// </summary>
        public string icon { get; set; }
        /// <summary>
        /// The guild's banner hash, if any.
        /// </summary>
        public string banner { get; set; }
        /// <summary>
        /// True if the authenticated user is the owner of the guild.
        /// </summary>
        public bool owner { get; set; }
        /// <summary>
        /// Permission bits for the authenticated user.
        /// </summary>
        public string permissions { get; set; }
        /// <summary>
        /// A list of enabled guild specific discord features
        /// </summary>
        public List<string> features { get; set; }
        /// <summary>
        /// An approximation of the guild's total member count
        /// </summary>
        public int approximate_member_count { get; set; }
        /// <summary>
        /// An approximation of the guild's total presence count (non-offline users)
        /// </summary>
        public int approximate_presence_count { get; set; }
    }
}
