//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace pz18
{
    using System;
    using System.Collections.Generic;
    
    public partial class AddedDesk
    {
        public int AddedDeskID { get; set; }
        public string message { get; set; }
        public Nullable<System.DateTime> creationDate { get; set; }
        public int clientID { get; set; }
        public int requestID { get; set; }
    
        public virtual Clients Clients { get; set; }
        public virtual RepairRequests RepairRequests { get; set; }
    }
}
