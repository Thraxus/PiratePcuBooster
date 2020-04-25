using Sandbox.ModAPI;
using VRage.Game;
using VRage.Game.Components;

namespace PiratePcuBooster.Thraxus
{
	[MySessionComponentDescriptor(MyUpdateOrder.NoUpdate, priority: int.MinValue + 1)]
    public class Core : MySessionComponentBase
    {
	    public override void LoadData()
	    {
		    base.LoadData();
		    if (MyAPIGateway.Session.SessionSettings.BlockLimitsEnabled == MyBlockLimitsEnabledEnum.NONE)
			    MyAPIGateway.Session.SessionSettings.PiratePCU = 1000000;
		    else
		    {
			    MyAPIGateway.Session.SessionSettings.PiratePCU = MyAPIGateway.Session.SessionSettings.TotalPCU * 3;
		    }
		}
    }
}
