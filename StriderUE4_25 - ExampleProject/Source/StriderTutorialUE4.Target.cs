// Copyright 2020 Kenneth Claassen, All Rights Reserved.

using UnrealBuildTool;
using System.Collections.Generic;

public class StriderTutorialUE4Target : TargetRules
{
	public StriderTutorialUE4Target(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Game;
		DefaultBuildSettings = BuildSettingsVersion.V2;
		ExtraModuleNames.Add("StriderTutorialUE4");
	}
}
