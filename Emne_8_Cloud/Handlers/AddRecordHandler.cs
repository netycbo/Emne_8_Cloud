using Emne_8_Cloud.Data.Ententities;
using Emne_8_Cloud.Data.Repositories;
using Emne_8_Cloud.Requests;
using Emne_8_Cloud.Responses;
using MediatR;

namespace Emne_8_Cloud.Handlers
{
    public class AddRecordHandler(IRecordRepository repository) : IRequestHandler<AddRecordRequest, AddRecordResponse>
    {
        public async Task<AddRecordResponse> Handle(AddRecordRequest request, CancellationToken cancellationToken)
        {
            var addRecord = new RecordModel
            {
                Id = request.Id,
                Title = request.Titel,
                Description = request.Description,
                
            };
            await repository.AddRecord(addRecord);
            return new AddRecordResponse
            {
                Message = "Record added successfully",

            };
        }
    }
}
