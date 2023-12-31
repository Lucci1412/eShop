﻿using eShop.Data.Entities;
using eShopSolution.Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace eShop.Data.Entities
{
    public class Language
    {
        public string Id { get; set; }

        public string Name { get; set; }

        public bool IsDefault { get; set; }

        public List<ProductTranslation> ProductTranslation { get; set; }

        public List<CategoryTranslation> CategoryTranslations { get; set; }
    }
}