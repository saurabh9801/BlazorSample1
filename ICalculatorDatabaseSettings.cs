namespace CalculatorWebAPI.Models
{
    public interface ICalculatorDatabaseSettings
    {     
        string CalculatorCollectionName { get; set; }
        string ConnectionString { get; set; }
        string DatabaseName { get; set; }
    }
}
