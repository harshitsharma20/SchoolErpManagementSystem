using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    //make different table for subjects and marks
    public class ResultTable
    {
        [Key] public int Id { get; set; }
        public int studentId { get; set; }
        public StudentTable Student { get; set; } = null!;
        public int teacherId { get; set; }
        public TeacherDetails Teacher { get; set; } = null!;
        public double TotalPercentage { get; set; }
        public bool pass {  get; set; }


        //public int StudentId { get; set; }
        //public virtual StudentDetails Student { get; set; } = null!;
        //[Required] public int MathsMarks { get; set; }
        //[Required] public int PhysicsMarks { get; set; }
        //[Required] public int EnglishMarks { get; set; }
        //[Required] public int ChemistryMarks { get; set; }
        //[Required] public int PhysicalEducationMarks { get; set; }
    }
}
