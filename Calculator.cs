using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
namespace CalculatorWebAPI.Models
{
    [BsonIgnoreExtraElements]
    public class Calculator
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public int Id { get; set; }
        [BsonElement("first_number")]
        public int First_Number { get; set; }
        [BsonElement("second_number")]
        public int Second_Number { get; set; }
        [BsonElement("operator")]
        public string Operator { get; set; }=String.Empty;
        [BsonElement("created_date")]
        public DateTime CreatedOn { get; set; }



    }
}
