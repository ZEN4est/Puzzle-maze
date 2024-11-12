using UnrealBuildTool;

public class PuzzleMazeServerTarget : TargetRules
{
	public PuzzleMazeServerTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Server;
		ExtraModuleNames.Add("PuzzleMaze");
	}
}
