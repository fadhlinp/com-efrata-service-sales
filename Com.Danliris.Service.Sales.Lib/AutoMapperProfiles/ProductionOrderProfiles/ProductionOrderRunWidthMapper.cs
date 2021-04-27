using AutoMapper;
using Com.Danliris.Service.Sales.Lib.Models.ProductionOrder;
using Com.Danliris.Service.Sales.Lib.ViewModels.ProductionOrder;
using System;
using System.Collections.Generic;
using System.Text;

namespace Com.Danliris.Service.Sales.Lib.AutoMapperProfiles.ProductionOrderProfiles
{
    public class ProductionOrderRunWidthMapper : Profile
    {
        public ProductionOrderRunWidthMapper()
        {
            CreateMap<ProductionOrder_RunWidthModel, ProductionOrder_RunWidthViewModel>()
            .ReverseMap();
        }
    }
}
