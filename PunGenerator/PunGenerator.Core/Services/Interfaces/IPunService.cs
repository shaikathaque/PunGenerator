using PunGenerator.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PunGenerator.Core.Services.Interfaces
{
    public interface IPunService
    {
        List<Pun> getPunList();
    }
}
