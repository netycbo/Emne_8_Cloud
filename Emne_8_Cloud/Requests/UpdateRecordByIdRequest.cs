using Emne_8_Cloud.Responses;
using MediatR;

namespace Emne_8_Cloud.Requests
{
    public class UpdateRecordByIdRequest : IRequest<UpdateRecordByIdResponse>
    {
        public int Id { get; set; }
        public string Titel { get; set; }
        public string Description { get; set; }
    }
}