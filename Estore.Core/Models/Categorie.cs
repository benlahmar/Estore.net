﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estore.Core.Models
{
    public class Categorie
    {
        public int Id { get; set; }
        public string Libelle { get; set; }
        public IEnumerable<Produit> Produits { get; set; }
    }
}
