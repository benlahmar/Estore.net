namespace CatalogueService.Entities
{
    public class Produit
    {
        public Guid Id { get; set; }
        public string Designation { get; set; }
        public int Quantite { get; set; }
        public double Prix { get; set; }
        public Categorie Categorie { get; set; }
    }
}
