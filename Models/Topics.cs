using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LearningDiary_IK0._1.Models
{
    public class Topics
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public double EstimatedTimeToMaster { get; set; }
        public double TimeSpent { get; set; }
        public string Source { get; set; }
        public DateTime? StartLearningDate { get; set; }
        public bool inProgress { get; set; }
        public DateTime? CompletionDate { get; set; }


    }
}
