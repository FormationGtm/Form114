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
    
    public partial class Ville
    {
        public Ville()
        {
            this.Produit = new HashSet<Produit>();
        }
    
        public int IdVille { get; set; }
        public Nullable<int> IdRegion { get; set; }
        public string Libelle { get; set; }
    
        public virtual ICollection<Produit> Produit { get; set; }
        public virtual Region Region { get; set; }
    }
}