using AutoMapper;
using Microsoft.IdentityModel.Tokens;
using SharedLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class ResultRepository : IResultRepository
    {
        private readonly ProjectDbContext _context;
        private readonly IMapper _mapper;
        public ResultRepository(ProjectDbContext context,IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public IList<ResultDTO> GetAllResult()
        {
            return _mapper.Map<IList<ResultDTO>>(_context.Result);
        }
        public ResultDTO GetResult(int id)
        {
            var result = _context.Result.Where(x=> x.studentId==id).FirstOrDefault();//use where
            return _mapper.Map<ResultDTO>(result);
        }

        public void CreateResult(ResultDTO result)
        {
            var newResult = _mapper.Map<ResultTable>(result);
            _context.Result.Add(newResult);
            _context.SaveChanges();
        }
        public bool DeleteResult(int id)
        {
            var result = _context.Result.Where(x=>x.Id==id).FirstOrDefault();   
            if(result!=null)
            {
                _context.Result.Remove(result);
                _context.SaveChanges();
                return true;
            }
            return false;
        }
        public bool DeleteAll()
        {
            if (_context.Result.IsNullOrEmpty())
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
    }
}
