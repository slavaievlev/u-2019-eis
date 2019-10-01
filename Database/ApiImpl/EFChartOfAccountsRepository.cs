using EisDatabase;
using EisDatabase.Api;
using EisModel;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database.ApiImpl
{
    public class EFChartOfAccountsRepository : IChartOfAccountsRepository
    {
        private readonly EisDbContext Context;

        public EFChartOfAccountsRepository(EisDbContext context)
        {
            Context = context;
        }

        public ChartOfAccounts Get(int id)
        {
            return Context.ChartOfAccounts.FirstOrDefault(chart => chart.Id == id);
        }

        public List<ChartOfAccounts> GetAll()
        {
            return Context.ChartOfAccounts.ToList();
        }
    }
}
