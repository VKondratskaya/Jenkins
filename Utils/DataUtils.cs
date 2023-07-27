namespace L2Task1.Utils
{
    public class DataUtils
    {
       public static string relativePath = JsonReader.GetTestDataValue("filePath").ToString();
       public static string fullPath = Path.GetFullPath(relativePath);
       public static int numberOfHobbies = JsonReader.GetTestDataInt("numberOfHobbies");
       public static string baseUrl = JsonReader.GetConfigValue("baseUrl").ToString();
       public static string timeToCheck = JsonReader.GetTestDataValue("time_to_check");

    }
}
