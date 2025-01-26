using Emne_8_Cloud.Data.Repositories;
using Emne_8_Cloud.Requests;
using Emne_8_Cloud.Responses;
using MediatR;

namespace Emne_8_Cloud.Handlers
{
    public class DeleteByIdHandler(IRecordRepository repository) : IRequestHandler<DeleteByIdRequest, DeleteByIdResponse>
    {
        public async Task<DeleteByIdResponse> Handle(DeleteByIdRequest request, CancellationToken cancellationToken)
        {
            var record = await repository.GetById(request.Id);
            if (record != null)
            {
                await repository.DeleteRecordById(request.Id);
                return new DeleteByIdResponse
                {
                    Message = "Record deleted successfully",
                };
            }
            return new DeleteByIdResponse
            {
                Message = "Record not found",
            };
        }
    }
}
