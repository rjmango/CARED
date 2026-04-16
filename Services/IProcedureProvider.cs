using CARED.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CARED.Services
{
    internal interface IProcedureProvider
    {
        public Task<List<Procedure>> GetProceduresAsync();
    }
}
