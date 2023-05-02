using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebAppUN.Data
{
    public interface IData<Table>
    {
        List<Table> GetAllData();
        List<Table> Search(string SearchItem);
        Table Find(int Id);

        void Add(Table table);
        void Delete(Table table);
        void Edit(int Id,Table table);


    }
}
