using AM.ApplicationCore.Domain;
using AM.ApplicationCore.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.Services
{
    internal class ServicePassenger : Service<Passenger>, IServicePassenger
    {
        private readonly IUnitOfWork _unitOfWork;
        public ServicePassenger(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public IEnumerable<Passenger> GetAll()
        {
            throw new NotImplementedException();
        }

        public Passenger GetById(params object[] keyValues)
        {
            throw new NotImplementedException();
        }
    }
}
