//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ProjectAndSolutions.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Worker
    {
        public byte ID_Worker { get; set; }
        public string FIO { get; set; }
        public string ServiceNum { get; set; }
        public string Position { get; set; }
        public short ID_Devision { get; set; }
        public string Email { get; set; }
        public string TelephoneNum { get; set; }
        public System.DateTime DateOfAdd { get; set; }
        public Nullable<System.DateTime> DateOfDis { get; set; }
        public Nullable<bool> Status { get; set; }
    
        public virtual Devision Devision { get; set; }

        public string GetStatus
        {
            get
            {
                if ((bool)Status)
                    return "Действует";
                else
                    return "Закрыт";
            }
        }
    }
}