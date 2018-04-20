using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mercure.Models
{
    /// <summary>
    /// Model class of a subFamily
    /// </summary>
    class SubFamily
    {
        public int Id { get; set; }
        public int Family_Id { get; set; }
        public string Name { get; set; }
    }
}
