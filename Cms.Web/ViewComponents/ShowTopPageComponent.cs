using Microsoft.AspNetCore.Mvc;
using MyCms.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cms.Web.ViewComponents
{
    public class ShowTopPageComponent : ViewComponent
    {
        IPageRepository _pageRepository;
        public ShowTopPageComponent(IPageRepository pageRepository)
        {
            _pageRepository = pageRepository;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            return await Task.FromResult((IViewComponentResult)View("ShowTopPageComponent",
                _pageRepository.GetTopPage()));
        }
    }
}
