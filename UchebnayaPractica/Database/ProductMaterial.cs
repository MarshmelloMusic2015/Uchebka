//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace UchebnayaPractica.Database
{
    using System;
    using System.Collections.Generic;
    
    public partial class ProductMaterial
    {
        public int Id { get; set; }
        public Nullable<int> IdProduct { get; set; }
        public string MaterialArticle { get; set; }
        public decimal Count { get; set; }
    
        public virtual Product Product { get; set; }
        public virtual Material Material { get; set; }
    }
}
