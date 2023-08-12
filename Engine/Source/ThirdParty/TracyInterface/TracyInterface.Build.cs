// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;
using System.IO;

public class TracyInterface : ModuleRules
{
	public TracyInterface(ReadOnlyTargetRules Target) : base(Target)
	{
		Type = ModuleType.External;

		string libJPGPath = Target.UEThirdPartySourceDirectory + "TracyInterface";
		PublicIncludePaths.Add(libJPGPath);

		ShadowVariableWarningLevel = WarningLevel.Off;

	}
}
