using DemoApp.Query;
using DemoApp.Response;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace DemoApp.QueryHandler
{
    public class SeriesDivisorQueryHandler : IRequestHandler<SeriesDivisorQuery, List<SeriesDivisorResponse>>
    {
        public Task<List<SeriesDivisorResponse>> Handle(SeriesDivisorQuery request, CancellationToken cancellationToken)
        {
            string str = "1,1,1";
            int a = 1;
            int b = 1;
            int c = 1;
            int d;

            for (int i = 3; i < request.Number; i++)
            {
                d = a + b + c;
                a = b;
                b = c;
                c = d;
                str += "," + d.ToString();
            }

            List<SeriesDivisorResponse> list = new List<SeriesDivisorResponse>();
            string[] arrVal = str.Split(",");

            for (int i = 0; i < arrVal.Length; i++) {

                if (Convert.ToInt32(arrVal[i]) % request.Divisor == 0) {

                    list.Add(new SeriesDivisorResponse
                    {
                        Divisor = request.Divisor,
                        Number = i,
                        Output=Convert.ToInt32(arrVal[i])
                    }); 
                }
            }

            return Task.FromResult(list.ToList());
        }
    }
}
