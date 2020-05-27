using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace WebSiteEngine.Shared
{
    public class TextileDocument
    {
        public static class Tags
        {
            public const string H1 = "# ";

            public const string H2 = "## ";

            public const string H3 = "### ";
        }

        /// <summary>
        /// Textile本体
        /// </summary>
        public string Body { get; set; }
    }
}
