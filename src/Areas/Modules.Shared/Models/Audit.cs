namespace Modules.Shared.Models
{
    using Extensions;
    using MongoDB.Bson.Serialization.Attributes;
    
    public class Audit
    {
        [BsonId]
        [BsonRepresentation(MongoDB.Bson.BsonType.ObjectId)]
        public string Id { get; set; } 
        public DateTime? CreatedAt { get; set; } = DateTime.Now;
        public DateTime? ModifiedAt { get; set; }= DateTime.Now;
        public string CreatedBy { get; set; }
        public string ModifiedBy { get; set; } 
        [BsonDefaultValue(false)]
        public bool IsDeleted { get; set; }
        
        [BsonIgnore]
        public string CreatedAtShow
        {
            get { return CreatedAt.HasValue ? CreatedAt.Value.ToLocalTime().ToString(DateExtensions.FormatDate) : ""; }
        }
        [BsonIgnore]
        public string CreatedAtFullShow
        {
            get { return CreatedAt.HasValue ? CreatedAt.Value.ToLocalTime().ToString(DateExtensions.FormatDateFull) : ""; }
        }

        [BsonIgnore]
        public string LastModifiedShow
        {
            get { return ModifiedAt.HasValue ? ModifiedAt.Value.ToLocalTime().ToString(DateExtensions.FormatDate) : ""; }
        }
        
        [BsonIgnore]
        public string LastModifiedFullShow
        {
            get { return ModifiedAt.HasValue ? ModifiedAt.Value.ToLocalTime().ToString(DateExtensions.FormatDateFull) : ""; }
        }
    }
}