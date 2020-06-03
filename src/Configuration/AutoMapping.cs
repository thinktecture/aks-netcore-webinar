using System;
using AutoMapper;
using Thinktecture.AKS.Webinar.Entities;
using Thinktecture.AKS.Webinar.Models;

namespace Thinktecture.AKS.Webinar.Configuration
{
    public class AutoMapping: Profile
    {
        public AutoMapping()
        {
            CreateMap<Product, ProductListItem>();
            CreateMap<Product, ProductDetailsItem>();
            CreateMap<NewProductItem, Product>();
            CreateMap<UpdateProductItem, Product>();

        }
    }
}
