using DataAccessLayer.Repositories;
using QuestRooms.BLL.DTOModels;
using QuestRooms.BLL.Servises.Abstraction;
using QuestRoomsDAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuestRooms.BLL.Servises.Implementation
{
    public class CitiesServis: ICitiesService
    {
        private readonly IGenericRepository<City> cityRepos;

        public CitiesServis(IGenericRepository<City> _cityRepos)
        {
            cityRepos = _cityRepos;
        }
        public ICollection<CityDTO> GetCities()
        {
            var cities = cityRepos.GetAll();
            List<CityDTO> res = new List<CityDTO>();
            foreach (var item in cities)
            {
                res.Add(new CityDTO { Id = item.Id, Name = item.Name });
            }
            return res;
        }
    }
}
