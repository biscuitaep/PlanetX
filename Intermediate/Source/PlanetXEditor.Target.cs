using UnrealBuildTool;

public class PlanetXEditorTarget : TargetRules
{
	public PlanetXEditorTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Editor;
		ExtraModuleNames.Add("PlanetX");
	}
}
