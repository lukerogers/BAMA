using System.Linq;
using System.Web.Http;
using AngularList.Models;
using Omu.ValueInjecter;

namespace AngularList.Controllers.api
{
    public class TaskController : ApiController
    {
        private readonly AngularContext _db;

        public TaskController()
        {
            _db = new AngularContext();
        }

        // POST api/task
        public Task Post(int id, [FromBody] Task value)
        {
            var list = _db.Lists.FirstOrDefault(x => x.Id == id);

            list.Tasks.Add(value);

            _db.SaveChanges();

            return value;
        }

        // PUT api/task/5
        public void Put(Task value)
        {
            var task = _db.Tasks.FirstOrDefault(x => x.Id == value.Id);
            task.Complete = value.Complete;
            task.Label = value.Label;
            _db.SaveChanges();
        }

        // DELETE api/task/5
        public void Delete(int id)
        {
            var task = _db.Tasks.FirstOrDefault(x => x.Id == id);
            _db.Tasks.Remove(task);
            _db.SaveChanges();
        }
    }
}
