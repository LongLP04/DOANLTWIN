using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL_DA.Models;

namespace BUS_DA
{
    public class lichhenService
    {
        public List<LichHen> GetAll()
        {
            Model1 model1 = new Model1();
            return model1.LichHens.ToList();
        }
    }
}
