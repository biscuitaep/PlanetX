using UnrealBuildTool;

public class PlanetXServerTarget : TargetRules
{
	public PlanetXServerTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Server;
		ExtraModuleNames.Add("PlanetX");
	}
}
