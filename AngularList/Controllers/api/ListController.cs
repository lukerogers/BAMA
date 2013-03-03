using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web.Http;
using AngularList.Models;
using Omu.ValueInjecter;

namespace AngularList.Controllers.api
{
    public class ListController : ApiController
    {
        private readonly AngularContext _db;

        public ListController()
        {
            _db = new AngularContext();
        }

        // GET api/list
        public IEnumerable<List> Get()
        {
            return _db.Lists.Include(x => x.Tasks).ToList();
        }

        // GET api/list/5
        public List Get(int id)
        {
            return _db.Lists.FirstOrDefault(x => x.Id == id);
        }

        // POST api/list
        public List Post(List value)
        {
            _db.Lists.Add(value);
            _db.SaveChanges();
            return value;
        }

        // PUT api/list/5
        public void Put(List value)
        {
            var list = _db.Lists.FirstOrDefault(x => x.Id == value.Id);
            list.InjectFrom(value);
            _db.SaveChanges();
        }

        // DELETE api/list/5
        public void Delete(int id)
        {
            var list = _db.Lists.FirstOrDefault(x => x.Id == id);
            _db.Lists.Remove(list);
            _db.SaveChanges();
        }
    }
}
