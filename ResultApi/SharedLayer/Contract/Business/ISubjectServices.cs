using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharedLayer
{
    public interface ISubjectServices
    {
        public IList<SubjectDTO> GetAll();
        public SubjectDTO GetById(string subjectCode);
        public bool Create(SubjectDTO subjectDTO);
        public bool DeleteSubject(int id);
        public bool DeleteAll();
        public bool updateSubject(string subjectCode, SubjectDTO subjectDTO);
        public IList<SubjectDTO> GetByStandard(int standard);

    }
}
