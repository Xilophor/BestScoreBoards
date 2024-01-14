using BepInEx;
using BepInEx.Logging;

namespace BestScoreBoards
{
    [BepInPlugin(MyPluginInfo.PLUGIN_GUID, MyPluginInfo.PLUGIN_NAME, MyPluginInfo.PLUGIN_VERSION)]
    public class Plugin : BaseUnityPlugin
    {
        private void Awake()
        {
            Logger = base.Logger;
            
            Logger.LogInfo("BestScoreBoards has loaded!");
        }

        internal new static ManualLogSource Logger;
    }
}