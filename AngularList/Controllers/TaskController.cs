using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using AngularList.Models;
using Omu.ValueInjecter;

namespace AngularList.Controllers
{
    public class TaskController : ApiController
    {
        private AngularContext Db { get; set; }

        public TaskController()
        {
            Db = new AngularContext();
        }

        public IEnumerable<Task> GetTasksByListId(int listId)
        {
            var tasks = Db.Lists.FirstOrDefault(x => x.Id == listId).Tasks.ToList();//.Select(x => new TaskItem {Complete = x.Complete, Label = x.Label});
            return tasks;
        }

        public HttpResponseMessage PostTask(int listId, Task newTask)
        {
            var list = Db.Lists.FirstOrDefault(x => x.Id == listId);

            var task = new Task
                {
                    Label = newTask.Label,
                    List = list
                };

            list.Tasks.Add(task);
            Db.SaveChanges();

            newTask.InjectFrom(task);

            var response = Request.CreateResponse(HttpStatusCode.Created, newTask);
            return response;
        }

        public HttpResponseMessage PutTask(Task updateTask)
        {
            var task = Db.Tasks.FirstOrDefault(x => x.Id == updateTask.Id);
            task.Complete = updateTask.Complete;
            Db.SaveChanges();

            var response = Request.CreateResponse(HttpStatusCode.Created, task);
            return response;
        }

        public HttpResponseMessage DeleteTask(int id)
        {
            var task = Db.Tasks.FirstOrDefault(x => x.Id == id);
            Db.Tasks.Remove(task);
            Db.SaveChanges();

            var response = Request.CreateResponse(HttpStatusCode.Created, task);
            return response;
        }
    }
}
