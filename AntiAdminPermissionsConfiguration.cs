using Rocket.API;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Game4Freak.AntiAdminPermissions
{
    public class AntiAdminPermissionsConfiguration : IRocketPluginConfiguration
    {
        [XmlArrayItem("antiPermission")]
        public List<string> antiPermissions;

        public void LoadDefaults()
        {
            antiPermissions = new List<string>() { "example.permission" };
        }
    }
}
