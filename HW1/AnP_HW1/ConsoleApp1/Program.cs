using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW1_Task1
{
    class Program
    {
        public class Store : EntityBase
        {
            public Store(IIdGenerator idGenerator) : base(idGenerator)
            { }
        }

        public class Customer : EntityBase
        {
            public string Description { get; set; }

            public Customer(IIdGenerator idGenerator) : base(idGenerator)
            { }
        }

        static void Main(string[] args)
        {
        }
    }
}
