using Emne_8_Cloud.Data.Ententities;

namespace Emne_8_Cloud.Data.Repositories
{
    public interface IRecordRepository
    {
        Task<RecordModel> AddRecord(RecordModel record);
        Task DeleteRecordById(int id);
        IQueryable<RecordModel> GetRecords();
        void SaveChanges();
        Task<RecordModel?> UpdateRecordById(int id);
        Task<RecordModel?> GetById(int id);
    }
}