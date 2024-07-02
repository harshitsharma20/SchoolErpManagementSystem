using AutoMapper;
using SharedLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class AuthorizationRepository : IAuthorizationRepository
    {
        private readonly ProjectDbContext _context;
        private readonly IMapper _mapper;
        public AuthorizationRepository(ProjectDbContext dbContext,IMapper mapper)
        {
            this._context = dbContext;
            this._mapper = mapper;
        }

        public bool IsAuthorized(string userId,string password)
        {
             bool check = _context.AuthorizationDetails.Where(x => x.UserId == userId && x.Password == password).Any();
            if(check) { return true; }
            return false;
            
        }
    }
}
