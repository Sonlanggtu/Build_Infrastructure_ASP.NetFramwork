using AutoMapper;
using Build_Infrastructure_ASP.NetFramework.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Tier.Model.Models;

namespace Build_Infrastructure_ASP.NetFramework.Mappings
{
    public class AutoMapperConfiguration
    {
        public static void Configure()
        {
            var config = new MapperConfiguration(cfg => {
                cfg.CreateMap<Post, PostViewModel>();
                cfg.CreateMap<PostCategory, PostCategoryViewModel>();
                cfg.CreateMap<Tag, TagViewModel>();
                cfg.CreateMap<ProductCategory, ProductCategoryViewModel>();
                cfg.CreateMap<Product, ProductViewModel>();
                cfg.CreateMap<ProductTag, ProductTagViewModel>();
            });
        }
    }
}