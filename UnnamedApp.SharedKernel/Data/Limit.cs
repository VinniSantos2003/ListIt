using System;
using System.Collections.Generic;
using System.Text;

namespace UnnamedApp.SharedKernel.Data
{
    /// <summary>
    /// Foi criada a classe "Limit" para representar o limite de cada mês.
    /// Essa classe possui uma data inicial,uma data final e um valor de limite.
    /// A data inicial e final serão utilizadas para determinar o período do mês.
    /// </summary>
    public class Limit
    {
        public DateOnly StartDate { get; set; }
        public DateOnly EndDate { get; set; }
        public decimal Amount { get; set; }
    }
}
