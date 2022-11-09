using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AM.ApplicationCore.Domaine;
using AM.ApplicationCore.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace AM.ApplicationCore.Services
{    
    public class ServicePlane : IservicePlane
    {
        private IGenericRepository<Plane> genericRepository;
        //public ServicePlane(IGenericRepository<Plane> genericRepository)
        //{
        //    this.genericRepository = genericRepository;
        //}
        private IUnitOfWork unitofwork;
        public ServicePlane(IUnitOfWork unitOfWork)
        {
            this.unitofwork = unitOfWork;
        }
        public void Add(Plane plane)
        {
            unitofwork.Repository<Plane>().Add(plane);
        }

        public IList<Plane> GetAll()
        {
           
            return unitofwork.Repository<Plane>().GetAll().ToList();
        }

        public void Remove(Plane plane)
        {
           unitofwork.Repository<Plane>().Delete(plane);
        }
        //public void Add(Plane plane)
        //{
        //    genericRepository.Add(plane);

        //}

        //public IList<Plane> GetAll()
        //{
        //   IEnumerable<Plane> result = genericRepository.GetAll();
        //    return result.ToList();
        //}

        //public void Remove(Plane plane)
        //{
        //    genericRepository.Delete(plane);  
        //    genericRepository.Delete(plane);  
        //}
    }
}
