using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace ConsultaEndereco.Core.Entities
{
    public class PagedEnumerable<T>
    {
        public int Page { get; set; }
        public int Count { get; set; }
        public int PageSize { get; set; }

        public IEnumerable<T> Data { get; }

        public PagedEnumerable(IQueryable<T> query, int page, int pageSize)
        {
            this.Count = query.Count();
            this.Page = page;
            this.PageSize = pageSize;
            this.Data = query.Skip(page * pageSize).Take(pageSize).ToList();
        }

        public PagedEnumerable(IEnumerable<T> query, int page, int pageSize)
        {
            this.Count = query.Count();
            this.Page = page;
            this.PageSize = pageSize;
            this.Data = query.Skip(page * pageSize).Take(pageSize).ToList();
        }

        public PagedEnumerable(IQueryable<T> query, int page, int pageSize, int count)
        {
            this.Count = count;
            this.Page = page;
            this.PageSize = pageSize;
            this.Data = query;
        }

        public PagedEnumerable<TR> MapTo<TR>(Expression<Func<T, TR>> select, int page, int pageSize, int count)
        {
            return new PagedEnumerable<TR>(Data.AsQueryable().Select(select), page, pageSize, count);
        }
    }
}
