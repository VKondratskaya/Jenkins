using Newtonsoft.Json.Linq;

public interface IDataManager
{
    JObject ReadTestData();
    JObject ReadConfig();
}

public class DataManager : IDataManager
{
    private static JObject? _testData;
    private static JObject? _config;

    public JObject ReadTestData()
    {
        if (_testData == null)
            _testData = JObject.Parse(File.ReadAllText("C:\\Users\\Victoria\\Desktop\\a1qaL2\\L2Task1\\Resources\\testData.json"));
        return _testData;
    }

    public JObject ReadConfig()
    {
        if (_config == null)
            _config = JObject.Parse(File.ReadAllText("C:\\Users\\Victoria\\Desktop\\a1qaL2\\L2Task1\\Resources\\config.json"));
        return _config;
    }
}