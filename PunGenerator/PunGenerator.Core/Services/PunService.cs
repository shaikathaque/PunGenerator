using PunGenerator.Core.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PunGenerator.Core.Models;
using PunGenerator.Core.Repositories.Interfaces;

namespace PunGenerator.Core.Services
{
    class PunService : IPunService
    {
        private readonly IPunRepository _punRepository;

        public PunService(IPunRepository punRepository)
        {
            _punRepository = punRepository;
        }

        public List<Pun> getPunList()
        {
            return _punRepository.getPunList();         
        }
    }
}
