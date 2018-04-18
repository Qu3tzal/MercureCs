using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mercure.Models
{
    class Article
    {
        public string Ref_Article { get; set; }
        public string Description { get; set; }
        public string Sub_Familly_Name { get; set; }
        public string Brand_Name { get; set; }
        public float Price_HT { get; set; }
        public int Quantity { get; set; }
    }
}
