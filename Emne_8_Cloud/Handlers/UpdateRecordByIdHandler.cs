using Emne_8_Cloud.Data.Repositories;
using Emne_8_Cloud.Requests;
using Emne_8_Cloud.Responses;
using MediatR;

namespace Emne_8_Cloud.Handlers
{
    public class UpdateRecordByIdHandler(IRecordRepository repository) : IRequestHandler<UpdateRecordByIdRequest, UpdateRecordByIdResponse>
    {
        public async Task<UpdateRecordByIdResponse> Handle(UpdateRecordByIdRequest request, CancellationToken cancellationToken)
        {
            var record = repository.GetById(request.Id);
            if (record != null)
            {
                await repository.UpdateRecordById(request.Id);
                return new UpdateRecordByIdResponse
                {
                    Message = "Record updated successfully nad now looks like this:",
                    Titel = request.Titel,
                    Description = request.Description

                };

            }
            return new UpdateRecordByIdResponse
            {
                Message = "Record not found"
            };
        }
    }
}
