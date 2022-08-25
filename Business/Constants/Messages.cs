using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Constants
{
    //new'lemeye gerek kalmadan direk Messages. diye erişmek için static yaptık. belli değişmeyen constant veriler için yapmak uygun olur
    public static class Messages
    {
        public static string ProductAdded = "Ürün eklendi";
        public static string ProductNameInvalid = "Ürün ismi geçersiz";

    }
}
