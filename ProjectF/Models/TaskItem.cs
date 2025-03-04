using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectF.Models
{
    public enum TaskStatus
    {
        Pending,
        InProgress,
        Completed
    }

    public enum TaskPriority
    {
        Low,
        Medium,
        High
    }
    public class TaskItem
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime DueDate { get; set; }
        public DateTime CreatedDate { get; set; }= DateTime.Now;

        public TaskPriority Priority { get; set; } 
        private TaskStatus _status;
        public TaskStatus Status 
        {
            get { return _status; }
            set
            {
                _status = value;
                if(_status==TaskStatus.Completed && CompletedDate==null)
                {
                    CompletedDate=DateTime.Now;
                }
            }
        
        }
        public DateTime? CompletedDate { get; private set; } 

        public TimeSpan? CompletionTime => CompletedDate.HasValue ? CompletedDate - CreatedDate : null;

        public int UserId { get; set; }
        public User User { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }



    }

}
