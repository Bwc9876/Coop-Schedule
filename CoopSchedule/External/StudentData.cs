using System.Collections.Generic;
using Newtonsoft.Json;

namespace CoopSchedule.External;

[JsonObject]
public class StudentData
{
    public string Name;
    public List<string> Units;

    public override string ToString()
    {
        return Name;
    }
}