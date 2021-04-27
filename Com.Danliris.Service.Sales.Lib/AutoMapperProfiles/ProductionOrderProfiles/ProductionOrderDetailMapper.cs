using AutoMapper;
using Com.Danliris.Service.Sales.Lib.Models.ProductionOrder;
using Com.Danliris.Service.Sales.Lib.ViewModels.ProductionOrder;
using System;
using System.Collections.Generic;
using System.Text;

namespace Com.Danliris.Service.Sales.Lib.AutoMapperProfiles.ProductionOrderProfiles
{
    public class ProductionOrderDetailMapper : Profile
    {
        public ProductionOrderDetailMapper()
        {
            CreateMap<ProductionOrder_DetailModel, ProductionOrder_DetailViewModel>()
            .ForPath(d => d.ColorType.Id, opt => opt.MapFrom(s => s.ColorTypeId))
            .ForPath(d => d.ColorType.Name, opt => opt.MapFrom(s => s.ColorType))
            .ForPath(d => d.Uom.Id, opt => opt.MapFrom(s => s.UomId))
            .ForPath(d => d.Uom.Unit, opt => opt.MapFrom(s => s.UomUnit))

            .ReverseMap();
        }
    }
}
