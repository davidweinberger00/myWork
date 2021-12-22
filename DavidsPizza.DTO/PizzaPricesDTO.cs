using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DavidsPizza.DTO
{
    public class PizzaPricesDTO
    {
        public int Id { get; set; }
        public decimal SmallSizeCost { get; set; }
        public decimal MediumSizeCost { get; set; }
        public decimal LargeSizeCost { get; set; }
        public decimal ThickCrustCost { get; set; }
        public decimal ThinCrustCost { get; set; }
        public decimal RagularCrustCost { get; set; }
        public decimal SausageCost { get; set; }
        public decimal PepperoniCost { get; set; }
        public decimal OnionsCost { get; set; }
        public decimal GreenPeppersCost { get; set; }
    }
}
