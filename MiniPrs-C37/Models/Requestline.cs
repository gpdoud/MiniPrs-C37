using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace MiniPrs_C37.Models {
    public class Requestline {
        public int Id { get; set; }
        public int Quantity { get; set; } = 1;
        
        public int RequestId { get; set; }
        [JsonIgnore]
        public virtual Request Request { get; set; }

        public int ProductId { get; set; }
        public virtual Product Product { get; set; }
    }
}
