using AutoMapper;
using Com.Danliris.Service.Sales.Lib.Models.GarmentBookingOrderModel;
using Com.Danliris.Service.Sales.Lib.ViewModels.GarmentBookingOrderViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace Com.Danliris.Service.Sales.Lib.AutoMapperProfiles.GarmentBookingOrderProfiles
{
    public class GarmentBookingOrderItemMapper : Profile
    {
        public GarmentBookingOrderItemMapper()
        {
            CreateMap<GarmentBookingOrderItem, GarmentBookingOrderItemViewModel>()
            .ReverseMap();
        }
    }
}
