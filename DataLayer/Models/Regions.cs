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
    
    public partial class Regions
    {
        public Regions()
        {
            this.Pays = new HashSet<Pays>();
        }
    
        public int idRegion { get; set; }
        public string name { get; set; }
        public int idContinent { get; set; }
    
        public virtual Continents Continents { get; set; }
        public virtual ICollection<Pays> Pays { get; set; }
    }
}
