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
    
    public partial class InsRasporadokTB
    {
        public int ID { get; set; }
        public System.DateTime Время_провидения { get; set; }
        public string Занятие { get; set; }
        public int Id_Рота { get; set; }
    
        public virtual InsRotaTB InsRotaTB { get; set; }
    }
}