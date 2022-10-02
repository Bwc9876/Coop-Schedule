using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

namespace CoopSchedule.External;

public enum Session
{
    AM = 0,
    PM = 1
}

[JsonObject]
public class PersistentData
{
    public static readonly PersistentData DefaultData = new()
    {
        Sessions = new[] {new List<StudentData>(), new List<StudentData>()},
        CurrentSession = Session.AM,
        Units = new List<UnitData>()
    };

    [JsonIgnore] public List<StudentData> Students => Sessions[(int) CurrentSession];
    public List<StudentData>[] Sessions { get; set; }
    public Session CurrentSession { get; set; }
    public List<UnitData> Units { get; set; }

    public static PersistentData Load(string path)
    {
        if (!File.Exists(path)) DefaultData.Save(path);
        var fileData = File.ReadAllText(path);
        return JsonConvert.DeserializeObject<PersistentData>(fileData);
    }

    public void Save(string path)
    {
        var fileData = JsonConvert.SerializeObject(this);
        File.WriteAllText(path, fileData);
    }
}