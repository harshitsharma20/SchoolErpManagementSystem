using AutoMapper;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.IdentityModel.Tokens;
using SharedLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class SubjectRepository : ISubjectRepository
    {
        private readonly ProjectDbContext _context;
        private readonly IMapper _mapper;
        public SubjectRepository(ProjectDbContext context,IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public IList<SubjectDTO> GetAll()
        {
            return _mapper.Map<IList<SubjectDTO>>(_context.Subject);
        }
        public SubjectDTO GetById(string subjectCode)
        {
            return _mapper.Map<SubjectDTO>(_context.Subject.Where(x => x.SubjectCode == subjectCode).FirstOrDefault());
        }
        public bool Create(SubjectDTO subjectDTO)
        {
            if (_context.Subject.Where(x => x.SubjectCode == subjectDTO.SubjectCode).Any())
            {
                return false;
            }
            _context.Subject.Add(_mapper.Map<SubjectTable>(subjectDTO));
            _context.SaveChanges();
            return true;
        }
        public bool DeleteSubject(int id)
        {
            var subject = _context.Subject.Where(x => x.Id==id).FirstOrDefault();
            if (subject!=null)
            {
                _context.Subject.Remove(subject);
                _context.SaveChanges();
                return true;
            }
            return false;
        }
        public bool DeleteAll()
        {
            if (_context.Subject.IsNullOrEmpty())
            {
                return false;
            }
            foreach(var result in _context.Result)
            {
                _context.Result.Remove(result);
            }
            _context.SaveChanges();
            return true;
        }
        public bool updateSubject(string subjectCode, SubjectDTO subject)
        {
            if (_context.Subject.Where(x => x.SubjectCode == subject.SubjectCode).Any() && subjectCode != subject.SubjectCode)
            {
                return false;
            }
            var newSubject = _context.Subject.Where(x => x.SubjectCode == subjectCode).FirstOrDefault();
            if (newSubject != null)
            {
                newSubject.SubjectCode= subject.SubjectCode;
                newSubject.Name = subject.Name;
                newSubject.standard = subject.standard;
                _context.SaveChanges();
                return true;
            }
            return false;
        }

        public IList<SubjectDTO> GetByStandard(int standard)
        {
            return _mapper.Map<IList<SubjectDTO>>(_context.Subject.Where(x => x.standard == standard));
        }
    }
}
