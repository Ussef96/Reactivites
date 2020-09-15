using System;
using System.Collections;
using System.Data.Entity.Infrastructure;
using System.Threading.Tasks;

namespace Domain
{
    public class Value : IDbAsyncEnumerable
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public IDbAsyncEnumerator GetAsyncEnumerator()
        {
            return GetAsyncEnumerator();
        }

        
    }
}
