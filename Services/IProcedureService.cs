using System.Collections.Generic;
using System.Threading.Tasks;
using CARED.Models;

namespace CARED.Services
{
    public interface IProcedureService
    {
        Task<List<Procedure>> GetAllProceduresAsync();
    }
}