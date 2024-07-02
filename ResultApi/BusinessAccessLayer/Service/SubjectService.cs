using Microsoft.EntityFrameworkCore;
using SharedLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessAccessLayer
{
    public class SubjectService : ISubjectServices
    {
        private readonly ISubjectRepository _subjectRepository;
        public SubjectService(ISubjectRepository subjectRepository)
        {
            _subjectRepository = subjectRepository;
        }
        public IList<SubjectDTO> GetAll()
        {
            return _subjectRepository.GetAll();
        }
        public SubjectDTO GetById(string subjectCode)
        {
            return _subjectRepository.GetById(subjectCode);
        }
        public bool Create(SubjectDTO subjectDTO)
        {
            return _subjectRepository.Create(subjectDTO);
        }
        public bool DeleteSubject(int id)
        {
            return _subjectRepository.DeleteSubject(id);
        }
        public bool DeleteAll()
        {
            return _subjectRepository.DeleteAll();
        }
        public bool updateSubject(string subjectCode, SubjectDTO subject)
        {
            return _subjectRepository.updateSubject(subjectCode, subject);
        }

        public IList<SubjectDTO> GetByStandard(int standard)
        {
            return _subjectRepository.GetByStandard(standard);
        }
    }
}
