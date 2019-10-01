using EisModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EisDatabase.Api
{
    public interface IChartOfAccountsRepository
    {
        ChartOfAccounts Get(int id);

        List<ChartOfAccounts> GetAll();
    }
}
