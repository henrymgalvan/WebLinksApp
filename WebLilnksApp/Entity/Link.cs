using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebLilnksApp.Entity
{
    public class Link
    {
        public int Id { get; set; }
        public string WebLinkName { get; set; }
        public Uri HttpLink { get; set; }
        public string Description { get; set; }
        public string Comment { get; set; }
        public string Category { get; set; }
        public string Tags { get; set; }
        public DateTime DateSubmitted { get; set; }
        public DateTime PublishedDate { get; set; }

    }
}
