using Raylib_cs;
using System.Text.Json;
using System.Text.Json.Serialization;

[System.Serializable]
public class SaveSystem
{
    public static string fileName = "data.txt";
    public List<Task> tasks { get; set; }

    public SaveSystem()
    {
        tasks = new List<Task>();
    }

    public void Save(SaveSystem save)
    {
        try
        {
            using (StreamWriter writer = new StreamWriter(fileName))
            {
                var opt = new JsonSerializerOptions() { WriteIndented = true };
                string strJson = JsonSerializer.Serialize<SaveSystem>(save, opt);
                writer.Write(strJson);
                Console.WriteLine("hej");
            }
        }
        catch (Exception exp)
        {
            Console.Write(exp.Message);
        }
    }

}