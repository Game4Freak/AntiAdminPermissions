using Rocket.API;
using Rocket.API.Collections;
using Rocket.Core;
using Rocket.Core.Plugins;
using Rocket.Unturned;
using Rocket.Unturned.Chat;
using Rocket.Unturned.Enumerations;
using Rocket.Unturned.Events;
using Rocket.Unturned.Player;
using SDG.Unturned;
using Steamworks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading;
using UnityEngine;
using Logger = Rocket.Core.Logging.Logger;

namespace Game4Freak.AntiAdminPermissions
{
    public class AntiAdminPermissions : RocketPlugin<AntiAdminPermissionsConfiguration>
    {
        public static AntiAdminPermissions Instance;
        public const string VERSION = "1.0.0";
        private IRocketPermissionsProvider _defaultPermissionsProvider;

        protected override void Load()
        {
            Instance = this;
            Logger.Log("AntiAdminPermissions v" + VERSION);

            _defaultPermissionsProvider = R.Permissions;
            R.Permissions = new AntiAdminPermissionProvider(_defaultPermissionsProvider);
        }

        protected override void Unload()
        {
            R.Permissions = _defaultPermissionsProvider;
        }
    }
}