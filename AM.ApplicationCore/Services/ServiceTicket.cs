using AM.ApplicationCore.Domaine;
using AM.ApplicationCore.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.Services
{
    public class ServiceTicket:  Service<Ticket>,IServiceTicket
    {
        private readonly IUnitOfWork unitofwork;
        public ServiceTicket(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
            this.unitofwork = unitOfWork;
        }
    }
}
