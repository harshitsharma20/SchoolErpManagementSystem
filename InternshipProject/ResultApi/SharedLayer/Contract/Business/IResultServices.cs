using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharedLayer
{
    public interface IResultServices
    {
        public IList<ResultDTO> GetAllResult();
        public ResultDTO GetResult(int id);
        public void CreateResult(ResultDTO result);
        public bool DeleteResult(int id);
        public bool DeleteAll();
    }
}
