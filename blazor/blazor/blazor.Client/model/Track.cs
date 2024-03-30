using Newtonsoft.Json;

namespace blazor.Client.model;

public class Track
{
    [JsonProperty("box")]
    public Box Box { get; set; }
    [JsonProperty("class")]
    public int Class { get; set; }
    [JsonProperty("confidence")]
    public double Confidence { get; set; } 
    [JsonProperty("name")]
    public string Name { get; set; }
    [JsonProperty("segments")]
    public Segments Segments { get; set; }
}

public class Box
{
    public double x1 {get; set; }
    public double y1 {get; set; }
    public double x2 {get; set; }
    public double y2 { get; set; }
}

public class Segments
{
    public double[] x { get; set; }
    public double[] y { get; set; }
}