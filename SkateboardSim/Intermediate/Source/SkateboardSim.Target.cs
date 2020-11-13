using UnrealBuildTool;

public class SkateboardSimTarget : TargetRules
{
	public SkateboardSimTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Game;
		ExtraModuleNames.Add("SkateboardSim");
	}
}
