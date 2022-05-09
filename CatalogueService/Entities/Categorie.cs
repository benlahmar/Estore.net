namespace CatalogueService.Entities
{
    public class Categorie
    {
        public int Id { get; set; }
        public string Libelle { get; set; }
        public IEnumerable<Produit> Produits { get; set; }   
    }
}
