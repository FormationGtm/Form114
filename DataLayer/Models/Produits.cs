//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré à partir d'un modèle.
//
//     Des modifications manuelles apportées à ce fichier peuvent conduire à un comportement inattendu de votre application.
//     Les modifications manuelles apportées à ce fichier sont remplacées si le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DataLayer.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Produits
    {
        public Produits()
        {
            this.Photos = new HashSet<Photos>();
            this.Prix = new HashSet<Prix>();
        }
    
        public int IdProduit { get; set; }
        public int IdVille { get; set; }
        public Nullable<int> NbPlaces { get; set; }
        public string Adresse { get; set; }
        public string Description { get; set; }
    
        public virtual ICollection<Photos> Photos { get; set; }
        public virtual ICollection<Prix> Prix { get; set; }
        public virtual Villes Villes { get; set; }
    }
}
