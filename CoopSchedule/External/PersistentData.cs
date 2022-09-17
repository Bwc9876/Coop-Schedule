using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

namespace CoopSchedule.External;

[JsonObject]
public class PersistentData
{
    public List<StudentData> Students { get; set; }
    public List<UnitData> Units { get; set; }

    public static readonly PersistentData DefaultData = new()
    {
        Students = new List<StudentData>(),
        Units = new List<UnitData>()
    };

    public static PersistentData Load(string path)
    {
        if (!File.Exists(path))
        {
            DefaultData.Save(path);
        }
        var fileData = File.ReadAllText(path);
        return JsonConvert.DeserializeObject<PersistentData>(fileData);
    }
    
    public void Save(string path)
    {
        var fileData = JsonConvert.SerializeObject(this);
        File.WriteAllText(path, fileData);
    }
}
