using Auxiliary.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Crossplay
{
    public class CrossplaySettings : ISettings
    {
        [JsonPropertyName("enable-classic-support")]
        public bool EnableClassicSupport { get; set; } = true;

        [JsonPropertyName("use-fake-version")]
        public bool UseFakeVersion { get; set; } = true;

        [JsonPropertyName("fake-version")]
        public int FakeVersion { get; set; } = 271;
    }
}
