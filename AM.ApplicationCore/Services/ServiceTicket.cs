using AM.ApplicationCore.Domain;
using AM.ApplicationCore.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.Services
{
    internal class ServiceTicket:Service<Ticket>,IServiceTicket
    {
        private readonly IUnitOfWork _unitOfWork;
        public ServiceTicket(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public IEnumerable<Ticket> GetAll()
        {
            throw new NotImplementedException();
        }

        public Ticket GetById(params object[] keyValues)
        {
            throw new NotImplementedException();
        }
    }
}
