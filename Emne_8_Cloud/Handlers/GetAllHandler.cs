using Emne_8_Cloud.Data.Repositories;
using Emne_8_Cloud.Requests;
using Emne_8_Cloud.Responses;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Emne_8_Cloud.Handlers
{
    public class GetAllHandler(IRecordRepository repository) : IRequestHandler<GetAllRequest, List<GetAllResponse>>
    {
        public async Task<List<GetAllResponse>> Handle(GetAllRequest request, CancellationToken cancellationToken)
        {
            var records = await repository.GetRecords().ToListAsync(cancellationToken);
            return records.Select(record => new GetAllResponse
            {
                Titel = record.Title,
                Description = record.Description
            }).ToList();
        }
    }
}
