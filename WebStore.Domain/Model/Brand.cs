using System.Collections.Generic;
using WebStore1.Domain.Model.Base;
using WebStore1.Models;

namespace WebStore1.Domain.Model
{
    public class Brand : NamedEntity, IOrderedEntity
    {
        /// <inheritdoc cref="NamedEntity" />
        /// <summary>
        /// Сущность бренд
        /// </summary>
        
        public int Order { get; set; }

        public virtual ICollection<Product> Products { get; set; }
    }
}
