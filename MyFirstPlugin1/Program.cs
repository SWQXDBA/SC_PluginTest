
using System.Runtime.Remoting.Contexts;
using NLog;
using NLog.Fluent;
using Torch;
using Torch.API;
using Torch.Commands;
using Torch.Commands.Permissions;
using VRage.Game.ModAPI;
using VRage.Game;
using VRage.Game.Definitions.SessionComponents;

namespace MyFirstPlugin1 {
    [Category("infos")]
    public class TestCommands : CommandModule {
        
        [Command("getid", "This is a Test Command.")]
        [Permission(MyPromoteLevel.Moderator)]
        public void Test2() {
            Context.Respond("您的steamUserId："+ Context.Player.SteamUserId);
            Context.Respond("您的Identity：" + Context.Player.Identity);
            Context.Respond("您的DisplayName：" + Context.Player.DisplayName);
            Context.Respond("您的Character：" + Context.Player.Character);
        }
        
    }
    

    public class TestPlugin : TorchPluginBase {

        public static readonly Logger Log = LogManager.GetCurrentClassLogger();

        
        public override void Init(ITorchBase torch) {
            base.Init(torch);
            Log.Info("This is a Test if it works!");
        }


    }
}