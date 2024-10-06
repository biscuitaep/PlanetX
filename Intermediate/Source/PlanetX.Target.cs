using UnrealBuildTool;

public class PlanetXTarget : TargetRules
{
	public PlanetXTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Game;
		ExtraModuleNames.Add("PlanetX");
	}
}
