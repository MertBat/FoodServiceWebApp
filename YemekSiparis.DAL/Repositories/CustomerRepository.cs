using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YemekSiparis.Core.Entities;
using YemekSiparis.Core.IRepositories;
using YemekSiparis.DAL.Context;

namespace YemekSiparis.DAL.Repositories
{
    public class CustomerRepository : BaseRepository<Customer>, ICustomerRepository
    {
        public CustomerRepository(AppDbContext context) : base(context)
        {

        }
    }
}
