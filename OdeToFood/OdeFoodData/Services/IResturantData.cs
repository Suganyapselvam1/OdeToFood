using OdeFoodData.Models;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OdeFoodData.Services
{
    public interface IResturantData
    {
        IEnumerable<Resturant> GetAll();
        Resturant Get(int id);
        void Add(Resturant resturant);
        void Update(Resturant resturant);
        void Delete(int id);
        
    }
}
