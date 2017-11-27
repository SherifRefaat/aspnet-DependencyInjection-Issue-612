using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.Core.Repositories
{
    public class DummyRepository : IRepository
    {
        public List<string> Fetch()
        {
            return new List<string>
            {
                "Foo",
                "bar",
                "Dummy"
            };
        }
    }
}
