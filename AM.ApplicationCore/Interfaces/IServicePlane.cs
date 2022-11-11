﻿using AM.ApplicationCore.Domain;
using AM.ApplicationCore.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.Interfaces
{
    public interface IServicePlane : IGenericRepository<Plane>
    {
       
        public void Add (Plane plane);
        //public void Remove(Plane plane);
        //public IList<Plane> GetAll();    
    }
}
