using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Results
{
    public class Result : IResult
    {
        
        //burda result'un tek parametreli contractor'una success'i yolla. eğer mesaj girilecekse. burda illa mesaj verecek diye bir durum yok verirse bu şekilde
        public Result(bool success, string message):this(success)
        {
            Message = message;
        }
        //overloading, classda iki farklı constractor var
        public Result(bool success)
        {
            Success = success;
        }

        public bool Success { get; }
        
        public string Message { get; }

   
    }
}
