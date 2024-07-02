using SharedLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessAccessLayer
{
    public class ResultService : IResultServices
    {
        private readonly IResultRepository _resultRepository;
        public ResultService(IResultRepository resultRepository)
        {
            _resultRepository = resultRepository;
        }
        public IList<ResultDTO> GetAllResult()
        {
            return _resultRepository.GetAllResult();
        }
        public ResultDTO GetResult(int id)
        {
            return _resultRepository.GetResult(id);
        }
        public void CreateResult(ResultDTO result)
        {
            _resultRepository.CreateResult(result);
        }
        public bool DeleteResult(int id)
        {
            return _resultRepository.DeleteResult(id);
        }
        public bool DeleteAll()
        {
            return _resultRepository.DeleteAll();
        }
    }
}
