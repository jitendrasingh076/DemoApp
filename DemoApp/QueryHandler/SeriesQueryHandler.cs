using DemoApp.Query;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace DemoApp.QueryHandler
{
    public class SeriesQueryHandler : IRequestHandler<SeriesQuery, string>
    {
        public Task<string> Handle(SeriesQuery request, CancellationToken cancellationToken)
        {
            string str = "1,1,1";
            int a = 1;
            int b = 1;
            int c = 1;
            int d;

            for (int i = 3; i < request.number; i++) {
                d = a + b + c;
                a = b;
                b = c;
                c = d;
                str += "," + d.ToString();
            }

            return Task.FromResult(str);
        }
    }
}
