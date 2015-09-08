using DataLayer.Models;
using Form114.Infrastructure.SearchProducts.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Form114.Infrastructure.SearchProducts.Options
{
    internal class SearchOptionPays : SearchOption
    {
        private readonly string _pays;

        

        public SearchOptionPays(SearchBase sb, string pays):base(sb)
        {
            _pays = pays;
        }

        public override IEnumerable<Produits> GetResult()
        {
            //return _Ville != null ? new Form114Entities().Produits.Where(p => p.IdVille == _Ville).OrderBy(p => p.IdProduit) : new Form114Entities().Produits.OrderBy();
            if (_pays == "" || _pays == null)
                return SearchBase.GetResult();
            return SearchBase.GetResult().Where(p => p.Villes.Pays.CodeIso3 == _pays);
        }

    }
}