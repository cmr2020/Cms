using MyCms.Domain.Model.Page;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyCms.Domain.Interfaces
{
    public interface IPageRepository
    {
        IEnumerable<Page> GetAllPage();
        IEnumerable<Page> GetTopPage(int take = 4);
        IEnumerable<Page> GetPagesInSlider();
        IEnumerable<Page> GetLatesPage();
        Page GetPageById(int pageId);
        void InsertPage(Page page);
        void UpdatePage(Page page);
        void DeletePage(Page page);
        void DeletePage(int pageId);
        bool PageExists(int pageId);
        void Save();
    }
}
