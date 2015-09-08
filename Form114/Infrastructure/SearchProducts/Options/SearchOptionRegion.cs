﻿using DataLayer.Models;
using Form114.Infrastructure.SearchProducts.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Form114.Infrastructure.SearchProducts.Options
{
    internal class SearchOptionRegion : SearchOption
    {
        private readonly int? _region;

        

        public SearchOptionRegion(SearchBase sb, int? Region):base(sb)
        {
            _region = Region;
        }

        public override IEnumerable<Produits> GetResult()
        {
            if (_region == null || _region == 0)
                return SearchBase.GetResult();
            return SearchBase.GetResult().Where(p => p.Villes.Pays.Regions.idRegion == (int)_region);
        }

    }
}