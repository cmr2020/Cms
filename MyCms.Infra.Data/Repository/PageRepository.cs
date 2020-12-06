using Microsoft.EntityFrameworkCore;
using MyCms.Domain.Interfaces;
using MyCms.Domain.Model.Page;
using MyCms.Infra.Data.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyCms.Infra.Data.Repository
{
    public class PageRepository : IPageRepository
    {
        private MyCmsContext _ctx;

        public PageRepository(MyCmsContext ctx)
        {
            _ctx = ctx;
        }

        public IEnumerable<Page> GetAllPage()
        {
            return _ctx.Pages.ToList();
        }

        public Page GetPageById(int pageId)
        {
            return _ctx.Pages.Find(pageId);
        }

        public void InsertPage(Page page)
        {
            _ctx.Pages.Add(page);
        }

        public void UpdatePage(Page page)
        {
            _ctx.Entry(page).State = EntityState.Modified;
        }

        public void DeletePage(Page page)
        {
            _ctx.Entry(page).State = EntityState.Deleted;
        }

        public void DeletePage(int pageId)
        {
            var page = GetPageById(pageId);
            DeletePage(page);
        }

        public void Save()
        {
            _ctx.SaveChanges();
        }

        public bool PageExists(int pageId)
        {
            return _ctx.Pages.Any(p => p.PageID == pageId);
        }
    }
}
