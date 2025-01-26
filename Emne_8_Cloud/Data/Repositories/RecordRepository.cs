using Emne_8_Cloud.Data.Ententities;
using Microsoft.EntityFrameworkCore;

namespace Emne_8_Cloud.Data.Repositories
{
    public class RecordRepository(AppDbContext context) : IRecordRepository
    {
        public async Task<RecordModel?> GetById(int id)
        {
            return await context.Records.FirstOrDefaultAsync(r => r.Id == id);
        }
        public IQueryable<RecordModel> GetRecords()
        {
            return context.Records;
        }
        public async Task DeleteRecordById(int id)
        {
            var record = context.Records.FirstOrDefault(r => r.Id == id);
            if (record != null)
            {
                context.Records.Remove(record);
                context.SaveChanges();
            }
        }
        public async Task<RecordModel> AddRecord(RecordModel record)
        {
            await context.Records.AddAsync(record);
            await context.SaveChangesAsync();
            return record;
        }
        public async Task<RecordModel?> UpdateRecordById(int id)
        {
            return await context.Records.FirstOrDefaultAsync(r => r.Id == id);
        }
        public void SaveChanges() => context.SaveChangesAsync();
    }
}
