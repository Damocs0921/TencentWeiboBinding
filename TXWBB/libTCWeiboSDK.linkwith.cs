using System;
using MonoTouch.ObjCRuntime;

[assembly: LinkWith ("libTCWeiboSDK.a", LinkTarget.Simulator | LinkTarget.ArmV7 | LinkTarget.ArmV7s, ForceLoad = true,Frameworks = "Accounts")]
[assembly: LinkWith ("libTCWeiboSDK.a", LinkTarget.Simulator | LinkTarget.ArmV7 | LinkTarget.ArmV7s, ForceLoad = true,Frameworks = "Security")]
[assembly: LinkWith ("libTCWeiboSDK.a", LinkTarget.Simulator | LinkTarget.ArmV7 | LinkTarget.ArmV7s, ForceLoad = true,Frameworks = "Social")]
