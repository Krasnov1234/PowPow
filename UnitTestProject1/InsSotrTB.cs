//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace UnitTestProject1
{
    using System;
    using System.Collections.Generic;
    
    public partial class InsSotrTB
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public InsSotrTB()
        {
            this.Vhod_SotrudnicaTB = new HashSet<Vhod_SotrudnicaTB>();
            this.Vhod_SotrudnicaTB1 = new HashSet<Vhod_SotrudnicaTB>();
            this.InsSpisokTBs = new HashSet<InsSpisokTB>();
        }
    
        public int ID { get; set; }
        public string Id_Сотрудник { get; set; }
        public string Id_Пароль { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Vhod_SotrudnicaTB> Vhod_SotrudnicaTB { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Vhod_SotrudnicaTB> Vhod_SotrudnicaTB1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<InsSpisokTB> InsSpisokTBs { get; set; }
    }
}
