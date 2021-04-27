using Com.Danliris.Sales.Test.WebApi.Utils;
using Com.Danliris.Service.Sales.Lib.BusinessLogic.Interface.GarmentMasterPlan.GarmentSewingBlockingPlanInterfaces;
using Com.Danliris.Service.Sales.Lib.Models.GarmentSewingBlockingPlanModel;
using Com.Danliris.Service.Sales.Lib.ViewModels.GarmentSewingBlockingPlanViewModels;
using Com.Danliris.Service.Sales.WebApi.Controllers.GarmentMasterPlan.GarmentSewingBlockingPlanControllers;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Com.Danliris.Sales.Test.WebApi.Controllers.GarmentMasterPlan.GarmentSewingBlockingPlanControllerTests
{
    public class GarmentSewingBlockingPlanControllerTest : BaseControllerTest<GarmentSewingBlockingPlanController, GarmentSewingBlockingPlan, GarmentSewingBlockingPlanViewModel, IGarmentSewingBlockingPlan>
    {
        protected override GarmentSewingBlockingPlanViewModel ViewModel
        {
            get
            {
                var viewModel = base.ViewModel;
                viewModel.Items = new List<GarmentSewingBlockingPlanItemViewModel>
                {
                    new GarmentSewingBlockingPlanItemViewModel()
                };
                return viewModel;
            }
        }

        
    }
}
