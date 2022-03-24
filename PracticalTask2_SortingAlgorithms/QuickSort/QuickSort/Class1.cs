using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace BuiltInSort
{
    class CatalogueItem
    {
        public Int32 Id { get; set; }
        public String ItemName { get; set; }
        public String Category { get; set; }
        // constructor
        public CatalogueItem(Int32 newId, String newName, String newCategory)
        {
            Id = newId;
            ItemName = newName;
            Category = newCategory;
        }
    }
}