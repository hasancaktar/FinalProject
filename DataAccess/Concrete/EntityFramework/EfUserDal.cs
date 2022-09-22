﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.DataAccess.EntityFramework;
using Core.Entities.Concrete;
using DataAccess.Abstract;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfUserDal : EfEntityRepositoryBase<User, NorthwindContext>, IUserDal
    {

        public List<OperationClaim> GetClaims(User user)
        {
            using (var context = new NorthwindContext())
            {
                //operation claimlerle uiser operation claimlere join atıyoruz sonra onların içinde id'si bizim gönderdiğimiz id'ye eşit olanı buluyor operaitonclaim olarak da bunları return ediyoruz.
                var result = from operationClaim in context.OperationClaims
                    join userOperationClaim in context.UserOperationClaims
                        on operationClaim.Id equals userOperationClaim.OperationClaimId
                    where userOperationClaim.UserId == user.Id
                    select new OperationClaim { Id = operationClaim.Id, Name = operationClaim.Name };
                return result.ToList();

            }
        }
    }
}
