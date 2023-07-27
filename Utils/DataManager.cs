using Aquality.Selenium.Core.Utilities;

public static class JsonReader
{
    private static JsonSettingsFile testData = new JsonSettingsFile("testData.json");
    private static JsonSettingsFile config = new JsonSettingsFile("config.json");
    public static string GetTestDataValue(string key)
    {
        return testData.GetValue<string>(key);
    }
    public static string GetConfigValue(string key)
    {
        return config.GetValue<string>(key);
    }

    public static int GetTestDataInt(string key)
    {
        return int.Parse(testData.GetValue<string>(key));
    }

}