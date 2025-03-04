using System.ComponentModel.DataAnnotations;
using BepInEx;
using BepInEx.Configuration;

namespace MegaSolarSail
{

    [BepInPlugin("cn.tursom.MegaSolarSail", "MegaSolarSail", "0.0.1")]
    public class MegaSolarSail : BaseUnityPlugin
    {
#pragma warning disable CS8618 // 在退出构造函数时，不可为 null 的字段必须包含非 null 值。请考虑添加 "required" 修饰符或声明为可为 null。
        private static ConfigEntry<double> EnergyMulCfg;
#pragma warning restore CS8618 // 在退出构造函数时，不可为 null 的字段必须包含非 null 值。请考虑添加 "required" 修饰符或声明为可为 null。
        private static double EnergyMul => EnergyMulCfg.Value;

        void Start()
        {
            Logger.LogInfo("MegaSolarSail on load");

            LoadConfig();

            Configs.freeMode.solarSailEnergyPerTick = (long)(Configs.freeMode.solarSailEnergyPerTick * EnergyMul);
            Configs.freeMode.dysonNodeEnergyPerTick = (long)(Configs.freeMode.dysonNodeEnergyPerTick * EnergyMul);
            Configs.freeMode.dysonFrameEnergyPerTick = (long)(Configs.freeMode.dysonFrameEnergyPerTick * EnergyMul);
            Configs.freeMode.dysonShellEnergyPerTick = (long)(Configs.freeMode.dysonShellEnergyPerTick * EnergyMul);
        }

        private void LoadConfig()
        {
            EnergyMulCfg = Config.Bind("config", "EnergyMul", 10.0, "solar sail energy increase multiplier\n"
                                                                    + "太阳帆能量增强倍率");
            Config.Save();
        }
    }
}
