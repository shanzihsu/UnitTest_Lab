using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labs.Lab7.Lab7
{
    public class SalePageService
    {
        public IRecordRepository RecordRepository { get; private set; }

        public SalePageService(IRecordRepository recordRepository)
        {
            this.RecordRepository = recordRepository;
        }

        public SalePage GetSalePage(int id)
        {
            this.RecordRepository.RecordSalePageVisits(id);

            return new SalePage
            {
                Id = 1,
                Price = 100,
                Title = "Test SalePage"
            };
        }
    }
}
