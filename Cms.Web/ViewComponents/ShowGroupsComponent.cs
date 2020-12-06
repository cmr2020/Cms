using Microsoft.AspNetCore.Mvc;
using MyCms.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cms.Web.ViewComponents
{
    public class ShowGroupsComponent:ViewComponent
    {
        IPageGroupRepository _pageGroupRepository;
        public ShowGroupsComponent(IPageGroupRepository pageGroupRepository)
        {
            _pageGroupRepository = pageGroupRepository;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            return await Task.FromResult((IViewComponentResult)View("ShowGroupsComponent",
                _pageGroupRepository.GetListGroups()));
        }

    }
}
