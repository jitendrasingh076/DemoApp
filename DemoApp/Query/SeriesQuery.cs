using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoApp.Query
{
    public class SeriesQuery :IRequest<string>
    {
        public int number { get; set; }
        public SeriesQuery(int n) {
            number = n;
        }
    }
}
