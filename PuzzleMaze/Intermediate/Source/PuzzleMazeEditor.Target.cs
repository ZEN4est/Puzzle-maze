using UnrealBuildTool;

public class PuzzleMazeEditorTarget : TargetRules
{
	public PuzzleMazeEditorTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Editor;
		ExtraModuleNames.Add("PuzzleMaze");
	}
}
