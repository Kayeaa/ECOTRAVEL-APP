using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BLL.Entities;
using BLL.Mapper;
using Common.Repositories;

namespace BLL.Services
{
    public class ReservationService : IReservationRepository<Reservation, int>
    {
        private readonly IReservationRepository<DAL.Entities.Reservation, int> _repository;

        public IEnumerable<Reservation> Get()
        {
            return _repository.Get().Select(e => e.ToBLL());
        }

        public Reservation Get(int id)
        {
            return _repository.Get(id).ToBLL();
        }

        public int Insert(Reservation entity)
        {
            return _repository.Insert(entity.ToDAL());
        }

        public bool Update(int id, Reservation entity)
        {
            return _repository.Update(id, entity.ToDAL());
        }

        public bool Delete(int id)
        {
            return _repository.Delete(id);
        }

        //A CHECK COMMENT FAIRE
        public IEnumerable<Reservation> GetByTypeLogement(int idTypeLogement)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Reservation> GetByClient(int idClient)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Reservation> GetByDate(DateTime date)
        {
            throw new NotImplementedException();
        }
    }
}
