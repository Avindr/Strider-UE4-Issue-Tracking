// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;

public class StriderTutorialUE4 : ModuleRules
{
	public StriderTutorialUE4(ReadOnlyTargetRules Target) : base(Target)
	{
		PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;

		PublicDependencyModuleNames.AddRange(new string[] { "Core", "CoreUObject", "Engine", "InputCore", "HeadMountedDisplay" });
	}
}
