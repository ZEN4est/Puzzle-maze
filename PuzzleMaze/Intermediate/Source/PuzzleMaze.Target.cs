using UnrealBuildTool;

public class PuzzleMazeTarget : TargetRules
{
	public PuzzleMazeTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Game;
		ExtraModuleNames.Add("PuzzleMaze");
	}
}
