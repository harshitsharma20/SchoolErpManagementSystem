using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharedLayer
{
    public class ResultDTO
    {
        [Key] public int Id { get; set; }
        public int studentId { get; set; }
        public int teacherId { get; set; }
        public double TotalPercentage { get; set; }
        public bool pass { get; set; }
    }
}
