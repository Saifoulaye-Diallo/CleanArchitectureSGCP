using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitectureSGCP.Core.Interfaces
{
    public interface IGestionPrescriptionService
    {
        Task AddPrescription(IPrescription prescription);

        Task UpdatePrescription(IPrescription prescription);

        Task GetPrescriptionById(int id);
    }
}
