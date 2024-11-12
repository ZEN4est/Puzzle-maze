using UnrealBuildTool;

public class PuzzleMazeClientTarget : TargetRules
{
	public PuzzleMazeClientTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Client;
		ExtraModuleNames.Add("PuzzleMaze");
	}
}
