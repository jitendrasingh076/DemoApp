using DemoApp.Response;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoApp.Query
{
    public class SeriesDivisorQuery : IRequest<List<SeriesDivisorResponse>>
    {
        public int Divisor { get; set; }
        public int Number { get; set; }

        public SeriesDivisorQuery(int d,int n) {
            Divisor = d;
            Number = n;
        }

    }
}
