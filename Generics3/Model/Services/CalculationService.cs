using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics3.Model.Services
{
    class CalculationService
    {

        public  T Max<T> (List<T> lista) where T : IComparable

        {
            if (lista.Count == 0)
            {
                throw new ArgumentException("Lista vazia !!!");
            }

            T max = lista[0];

            for (int x = 1; x < lista.Count; x++)

                if (lista[x].CompareTo(max) >0)
                {
                    max = lista[x];
                }

            return max;
        }

    }

}
