using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using LearningDiary_IK0._1.Models;

namespace LearningDiary_IK0._1.Data
{
    public class LearningDiary_IK0_1Context : DbContext
    {
        public LearningDiary_IK0_1Context (DbContextOptions<LearningDiary_IK0_1Context> options)
            : base(options)
        {
        }

        public DbSet<LearningDiary_IK0._1.Models.Topics> Topics { get; set; }
    }
}
