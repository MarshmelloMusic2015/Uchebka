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
    
    public partial class Equipment
    {
        public string Model { get; set; }
        public Nullable<int> IdTypeEquipment { get; set; }
        public string Characteristic { get; set; }
    
        public virtual TypeEquipment TypeEquipment { get; set; }
    }
}
