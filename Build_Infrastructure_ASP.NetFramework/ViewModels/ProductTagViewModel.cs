using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Build_Infrastructure_ASP.NetFramework.ViewModels
{
    public class ProductTagViewModel
    {
        public int ProductID { set; get; }

        public string TagID { set; get; }

        public virtual ProductViewModel Post { set; get; }

        public virtual TagViewModel Tag { set; get; }
    }
}