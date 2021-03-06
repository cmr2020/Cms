﻿using Microsoft.EntityFrameworkCore;
using MyCms.Domain.Interfaces;
using MyCms.Domain.Model.PageGroup;
using MyCms.Domain.ViewModel;
using MyCms.Infra.Data.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyCms.Infra.Data.Repository
{
    public class PageGroupRepository : IPageGroupRepository
    {
        private MyCmsContext _db;

        public PageGroupRepository(MyCmsContext db)
        {
            _db = db;
        }


        public List<PageGroup> GetAllPageGroups()
        {
            return _db.PageGroups.ToList();
        }

        public PageGroup GetPageGroupById(int groupId)
        {
            return _db.PageGroups.Find(groupId);
        }

        public void InsertPageGroup(PageGroup pageGroup)
        {
            _db.PageGroups.Add(pageGroup);
        }

        public void UpdatePageGroup(PageGroup pageGroup)
        {
            _db.Entry(pageGroup).State = EntityState.Modified;
        }

        public void DeletePageGroup(PageGroup pageGroup)
        {
            _db.Entry(pageGroup).State = EntityState.Deleted;
        }

        public void DeletePageGroup(int groupId)
        {
            var group = GetPageGroupById(groupId);
            DeletePageGroup(group);
        }

        public bool PageGroupExists(int pageGroupId)
        {
            return _db.PageGroups.Any(p => p.GroupID == pageGroupId);
        }

        public List<ShowGroupsViewModel> GetListGroups()
        {
            List<ShowGroupsViewModel> listgroups;
            listgroups= _db.PageGroups.Select(g => new ShowGroupsViewModel()
            {
                GroupID = g.GroupID,
                GroupTitle = g.GroupTitle,
                PageCount = _db.Pages.Where(p=>p.GroupID==g.GroupID).Count()
            }).ToList();
            return listgroups;
        }

        public void Save()
        {
            _db.SaveChanges();
        }
    }
}
