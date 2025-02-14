using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpEgitimKampi301.EntityLayer.Concrete
{
    //Tablo-->QUERY
    //--------------
    // class->Table
    //Property-->Column

    //Access Modifiers -- Erişim Belirleyiciler
    //Public,Private,internale,Protected
    //Code First

    public class Category
    {
        public int CategoryId { get; set; } //Birincil anahtar ve otomatik
        //artan olması için önemli(Sınıfın adı birebir aynı yazılmalı)

        public string CategoryName { get; set; }

        public bool CategoryStatus { get; set; }

    }
}

/* Field-Variable-Property
   
  */
