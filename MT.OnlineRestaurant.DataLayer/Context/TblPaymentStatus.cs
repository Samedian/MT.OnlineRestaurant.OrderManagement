using System;
using System.Collections.Generic;

namespace MT.OnlineRestaurant.DataLayer.Context
{
    public partial class TblPaymentStatus
    {
        public TblPaymentStatus()
        {
            TblOrderPayment = new HashSet<TblOrderPayment>();
        }

        public string Status { get; set; }
        public int Id { get; set; }
        public int UserCreated { get; set; }
        public int UserModified { get; set; }
        public DateTime RecordTimeStamp { get; set; }
        public DateTime RecordTimeStampCreated { get; set; }

        public virtual ICollection<TblOrderPayment> TblOrderPayment { get; set; }
    }
}
