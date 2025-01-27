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
            var record = await repository.GetById(request.Id);
            if (record != null)
            {
                record.Title = request.Titel;
                record.Description = request.Description;
                await repository.UpdateRecordById(request.Id);
                repository.SaveChanges();

                return new UpdateRecordByIdResponse
                {
                    Message = "Record updated successfully and now looks like this:",
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
