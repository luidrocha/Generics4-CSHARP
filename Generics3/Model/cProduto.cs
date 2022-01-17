using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Generics3.Model
{
    class cProduto : IComparable
    {


        public string Produto { get; set; }
        public double Preco { get; set; }

        public cProduto(string produto, double preco)
        {
            Produto = produto;
            Preco = preco;
        }

        public cProduto()
        {

        }
        public override string ToString()
        {
            return "Produto :" + Produto + " Preço: " + Preco.ToString("F2", CultureInfo.InvariantCulture);
        }

        public int CompareTo(object obj)
        {
            if (!(obj is cProduto))
            {
                throw new ArgumentException("Objetos diferentes de produto, não pode ser comparados !!");
            }

            cProduto outro = obj as cProduto; // Downcast
            
            return this.Preco.CompareTo(outro.Preco);
        }
    }
}
