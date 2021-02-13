using OdeFoodData.Models;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OdeFoodData.Services
{
    public interface IResturantData
    {
        List<Resturant> GetAll();

    }
}
