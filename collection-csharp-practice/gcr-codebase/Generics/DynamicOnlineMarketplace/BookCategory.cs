using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics.DynamicOnlineMarketplace
{
    class BookCategory
    {
        public string Genre { get; set; }

        public BookCategory(string genre)
        {
            Genre = genre;
        }

        public override string ToString()
        {
            return Genre;
        }
    }
}
