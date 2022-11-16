using AM.ApplicationCore.Domaine;
using AM.ApplicationCore.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.Services
{
    public class ServicePassenger : Service<Passenger>,IServicePassenger
    {
        private readonly IUnitOfWork unitofwork;
        public ServicePassenger(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
            this.unitofwork = unitOfWork;
        }
    }
}
