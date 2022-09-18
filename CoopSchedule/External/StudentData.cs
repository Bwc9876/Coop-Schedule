using System.Collections.Generic;
using Newtonsoft.Json;

namespace CoopSchedule.External;

[JsonObject]
public class StudentData
{
    public string name;
    public List<string> units;

    public override string ToString()
    {
        return name;
    }
}