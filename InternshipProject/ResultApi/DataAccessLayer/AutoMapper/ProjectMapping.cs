using AutoMapper;
using SharedLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class ProjectMapping : Profile
    {
        public ProjectMapping()
        {
            CreateMap<StudentTable, StudentDTO>().ReverseMap();//formember
            CreateMap<TeacherDetails, TeacherDTO>().ReverseMap();
            CreateMap<ResultTable, ResultDTO>().ReverseMap();
            CreateMap<SubjectTable, SubjectDTO>().ReverseMap();
            CreateMap<StudentSubject, StudentSubjectDTO>().ReverseMap();
        }
    }
}
