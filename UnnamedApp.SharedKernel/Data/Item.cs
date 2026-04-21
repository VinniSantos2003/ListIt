using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using UnnamedApp.SharedKernel.Enum;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace UnnamedApp.SharedKernel.Data
{
    public class Item : Entity
    {
        public Item()
        {

        }
        public string Name { get; set; } = string.Empty;
        public string Link { get; set; } = string.Empty;
        public Priority Priority { get; set; }
        public string? InitialDate { get; set; }
        public DateOnly ExpectedDate { get; set; }
        public DateOnly WhenItWasBought { get; set; }
        public decimal TotalPrice { get; set; }
        /// <summary>
        /// Foi parcelado?
        /// </summary>
        public bool Isinstallment { get; set; }
        /// <summary>
        /// Quantidade de parcelas
        /// </summary>
        public int Installments { get; set; }
        public bool Bought { get; set; }
        public ItemList? ItemList { get; set; }
        public string? ItemListId { get; set; }
    }
}
