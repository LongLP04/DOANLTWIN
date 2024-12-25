    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using DAL_DA.Models;
    using System.Windows.Forms;
using Guna.UI2.WinForms;
using System.Data.Entity;
namespace BUS_DA
    {
        public class benhnhanService
        {
       

    
        public List<BenhNhan> GetAll()
        {
           Model1 model1 = new Model1();
            return model1.BenhNhans.ToList();
        }



    }
    }
