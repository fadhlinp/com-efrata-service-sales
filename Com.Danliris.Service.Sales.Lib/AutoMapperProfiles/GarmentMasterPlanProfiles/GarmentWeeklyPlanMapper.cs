using AutoMapper;
using Com.Danliris.Service.Sales.Lib.Models.GarmentMasterPlan.WeeklyPlanModels;
using Com.Danliris.Service.Sales.Lib.ViewModels.Garment.WeeklyPlanViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace Com.Danliris.Service.Sales.Lib.AutoMapperProfiles.GarmentMasterPlanProfiles
{
    public class GarmentWeeklyPlanMapper : Profile
    {
        public GarmentWeeklyPlanMapper()
        {
            CreateMap<GarmentWeeklyPlan, GarmentWeeklyPlanViewModel>()
                .ForPath(d => d.Unit.Id, opt => opt.MapFrom(s => s.UnitId))
                .ForPath(d => d.Unit.Code, opt => opt.MapFrom(s => s.UnitCode))
                .ForPath(d => d.Unit.Name, opt => opt.MapFrom(s => s.UnitName))
                .ReverseMap();

            CreateMap<GarmentWeeklyPlanItem, GarmentWeeklyPlanItemViewModel>()
                .ReverseMap();
        }
    }
}
