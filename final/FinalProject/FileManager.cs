class FileManager
{
    public static void SaveToFile(string filePath, object data)
    {
        File.WriteAllText(filePath, JsonConvert.SerializeObject(data, Formatting.Indented));
    }

    public static string LoadFromFile(string filePath)
    {
        return File.Exists(filePath) ? File.ReadAllText(filePath) : string.Empty;
    }
}