using UnrealBuildTool;

public class PlanetXClientTarget : TargetRules
{
	public PlanetXClientTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Client;
		ExtraModuleNames.Add("PlanetX");
	}
}
