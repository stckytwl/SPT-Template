using BepInEx;
using BepInEx.Configuration;

namespace stckytwl.TEMPLATE;

[BepInPlugin("GUID", "TEMPLATE", "1.0.0")]
public class Plugin : BaseUnityPlugin
{
    private void Awake()
    {
        Utils.Logger = Logger;
    }
}