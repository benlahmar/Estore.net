using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estore.Core.Models
{
    public class Produit
    {
        public Guid Id { get; set; }
        public string Designation { get; set; }    
        public double prix { get; set; }
        public int Quantite { get; set; }

        public Categorie categorie;

    }
}
