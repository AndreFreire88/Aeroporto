using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libary
{
    public class BaggageModel
    {
        public int Id { get; set; }
        public ClientModel ClientId { get; set; }
        public decimal Weight { get; set; }
    }
}
