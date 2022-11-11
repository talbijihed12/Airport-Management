using AM.ApplicationCore.Domain;
using AM.ApplicationCore.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.Services
{

    public class ServicePlane : Service<Plane> , IServicePlane
    {
       
        private readonly IUnitOfWork _unitOfWork;
        //public ServicePlane(IGenericRepository<Plane> genericRepository)
        //{
        //    this.genericRepository = genericRepository;
        //}
        public ServicePlane(IUnitOfWork unitOfWork): base(unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public void Add(Plane plane)
        {
           _unitOfWork.Repository<Plane>().Add(plane);
            
        }

        public IList<Plane> GetAll()
        {
           return _unitOfWork.Repository<Plane>().GetAll().ToList();
        }

        public Plane GetById(params object[] keyValues)
        {
            throw new NotImplementedException();
        }

        public void Remove(Plane plane)
        {
            _unitOfWork.Repository<Plane>().Delete(plane);
        }
        public void Update(Plane plane)
        {
            _unitOfWork.Repository<Plane>().Update(plane);
        }

        IEnumerable<Plane> IGenericRepository<Plane>.GetAll()
        {
            throw new NotImplementedException();
        }
    }
}
