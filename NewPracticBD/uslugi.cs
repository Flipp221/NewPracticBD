//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace NewPracticBD
{
    using System;
    using System.Collections.Generic;
    
    public partial class uslugi
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public uslugi()
        {
            this.Zakazi = new HashSet<Zakazi>();
        }
    
        public int id_usluga { get; set; }
        public string name { get; set; }
        public int id_price { get; set; }
        public int id_time { get; set; }
        public int id_sprice { get; set; }
        public Nullable<int> id_star { get; set; }
        public int id_image { get; set; }
    
        public virtual images images { get; set; }
        public virtual price price { get; set; }
        public virtual sprice sprice { get; set; }
        public virtual Star Star { get; set; }
        public virtual time time { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Zakazi> Zakazi { get; set; }
    }
}
