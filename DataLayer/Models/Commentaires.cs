//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DataLayer.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Commentaires
    {
        public Commentaires()
        {
            this.Commentaires1 = new HashSet<Commentaires>();
        }
    
        public int idComment { get; set; }
        public Nullable<int> idParent { get; set; }
        public string idAuteur { get; set; }
        public int idProduit { get; set; }
        public System.DateTime datePoste { get; set; }
        public string texte { get; set; }
    
        public virtual AspNetUsers AspNetUsers { get; set; }
        public virtual ICollection<Commentaires> Commentaires1 { get; set; }
        public virtual Commentaires Commentaires2 { get; set; }
        public virtual Produits Produits { get; set; }
    }
}