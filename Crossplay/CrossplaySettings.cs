using TShockAPI;
using Newtonsoft.Json;

namespace Crossplay;

public class CrossplaySettings
{
    public bool EnableClassicSupport { get; set; } = true;
    public bool UseFakeVersion { get; set; } = true;
    public int FakeVersion { get; set; } = 274;

    public CrossplaySettings()
    {
        if (!File.Exists(Path.Combine(TShock.SavePath, "crossplay.json")))
        {
            SaveConfig();
        }
    }

    public void LoadConfig()
    {
        var savePath = Path.Combine(TShock.SavePath, "crossplay.json");
        var config = JsonConvert.DeserializeObject<CrossplaySettings>(File.ReadAllText(savePath));
        EnableClassicSupport = config.EnableClassicSupport;
        UseFakeVersion = config.UseFakeVersion;
        FakeVersion = config.FakeVersion;
    }

    public void SaveConfig()
    {
        var savePath = Path.Combine(TShock.SavePath, "crossplay.json");
        File.WriteAllText(savePath, JsonConvert.SerializeObject(this, Formatting.Indented));
    }
}