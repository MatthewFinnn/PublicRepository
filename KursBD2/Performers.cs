//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace KursBD
{
    using System;
    using System.Collections.Generic;
    
    public partial class Performers
    {
        public int id_performer { get; set; }
        public string alias { get; set; }
        public string name { get; set; }
        public Nullable<System.DateTime> birthdate { get; set; }
        public string birthplace { get; set; }
        public Nullable<short> height { get; set; }
        public Nullable<short> weight { get; set; }
        public string position { get; set; }
        public string image { get; set; }
        public string additional { get; set; }
        public int id_group { get; set; }
    
        public virtual Groups Groups { get; set; }
    }
}
