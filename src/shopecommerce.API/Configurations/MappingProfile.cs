﻿using AutoMapper;
using shopecommerce.Application.Commands.CategoryCommand.CreateCategory;
using shopecommerce.Application.Commands.CategoryCommand.UpdateCategory;
using shopecommerce.Application.Commands.ProductCategoryCommand.CreateProductCategory;
using shopecommerce.Application.Commands.ProductCategoryCommand.UpdateProductCategory;
using shopecommerce.Application.Commands.PromotionCommand.CreatePromotion;
using shopecommerce.Application.Commands.PromotionCommand.UpdatePromotion;
using shopecommerce.Application.Commands.RoleCommand.CreateRole;
using shopecommerce.Application.Commands.UserCommand.RegisterUser;
using shopecommerce.Application.Commands.UserCommand.UpdateUser;
using shopecommerce.Domain.Entities;
using shopecommerce.Domain.Models;

namespace shopecommerce.API.Configurations;

public class MappingProfile : Profile
{
    public MappingProfile()
    {

        //Categories mapper
        CreateMap<CreateCategoryCommand, Categories>().ReverseMap()
          .ForAllMembers(opts
            => opts.Condition((src, dest, srcMember)
              => srcMember != null));

        CreateMap<UpdateCategoryCommand, Categories>().ReverseMap()
          .ForAllMembers(opts
            => opts.Condition((src, dest, srcMember)
              => srcMember != null));

        CreateMap<CategoryDto, Categories>().ReverseMap()
          .ForAllMembers(opts
            => opts.Condition((src, dest, srcMember)
              => srcMember != null));

        //Users mapper
        CreateMap<RegisterUserCommand, Users>().ReverseMap()
            .ForAllMembers(opts
                => opts.Condition((src, dest, srcMember)
                    => srcMember != null));

        CreateMap<UpdateUserCommand, Users>()
            .ForAllMembers(opt => opt.Condition((src, dest, srcMember, destMember) => srcMember != null));

        //Roles mapper
        CreateMap<CreateRoleCommand, Roles>().ReverseMap()
            .ForAllMembers(opts
                => opts.Condition((src, dest, srcMember)
                    => srcMember != null));

        CreateMap<RoleDto, Roles>().ReverseMap()
            .ForAllMembers(opts
                => opts.Condition((src, dest, srcMember)
                    => srcMember != null));

        //Promotion Mapper
        CreateMap<CreatePromotionCommand, Promotions>()
            .ForAllMembers(opt => opt.Condition((src, dest, srcMember, destMember) => srcMember != null));

        CreateMap<UpdatePromotionCommand, Promotions>()
            .ForAllMembers(opt => opt.Condition((src, dest, srcMember, destMember) => srcMember != null));

        CreateMap<PromotionDto, Promotions>().ReverseMap()
            .ForAllMembers(opt => opt.Condition((src, dest, srcMember, destMember) => srcMember != null));

        //Product Category mapper
        CreateMap<CreateProductCategoryCommand, ProductCategories>()
            .ForAllMembers(opt => opt.Condition((src, dest, srcMember, destMember) => srcMember != null));

        CreateMap<UpdateProductCategoryCommand, ProductCategories>()
        .ForAllMembers(opt => opt.Condition((src, dest, srcMember, destMember) => srcMember != null));
    }
}