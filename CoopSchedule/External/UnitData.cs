using Newtonsoft.Json;

namespace CoopSchedule.External;

[JsonObject]
public class UnitData
{
    public string Name { get; set; }
    public int MaxStudents { get; set; }

    public override string ToString() => Name;
}