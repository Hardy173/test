using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using WebStore1.Domain.Model.Base;
using WebStore1.Models;

namespace WebStore1.Domain.Model
{
    public class Section : NamedEntity, IOrderedEntity
    {


        public int? ParentId { get; set; }

        [ForeignKey("ParentId")]
        public virtual Section ParentSection { get; set; }


        public int Order { get; set; }

        public virtual ICollection<Product> Products { get; set; }


    }
}
