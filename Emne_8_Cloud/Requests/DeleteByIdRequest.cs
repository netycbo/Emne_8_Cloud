using Emne_8_Cloud.Responses;
using MediatR;

namespace Emne_8_Cloud.Requests
{
    public class DeleteByIdRequest : IRequest<DeleteByIdResponse>
    {
        public int Id { get; set; }
    }
}