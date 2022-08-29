namespace CalculatorWebAPI.Models
{
    public class CalculatorDatabaseSettings : ICalculatorDatabaseSettings
    {
        string CalculatorCollectionName { get; set; } = String.Empty;
        string ICalculatorDatabaseSettings.CalculatorCollectionName { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        string ConnectionString { get; set; } = String.Empty;
        string ICalculatorDatabaseSettings.ConnectionString { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        string DatabaseName { get; set; } = String.Empty;
        string ICalculatorDatabaseSettings.DatabaseName { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}
