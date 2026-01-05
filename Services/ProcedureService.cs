using System.Collections.Generic;
using System.Threading.Tasks;
using System.Xml;
using CARED.Models;
using CARED.Data;
using Microsoft.EntityFrameworkCore;

namespace CARED.Services
{
    public class ProcedureService : IProcedureService
    {
        private readonly AppDatabaseContext _dbContext;
        public ProcedureService(AppDatabaseContext dbContext)
        {
            _dbContext = dbContext;
        }
        public Task<List<Procedure>> GetAllProceduresAsync()
        {
            return _dbContext.Procedures.ToListAsync();
        }
    }
}