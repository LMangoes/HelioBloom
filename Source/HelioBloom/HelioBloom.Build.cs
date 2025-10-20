// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;

public class HelioBloom : ModuleRules
{
	public HelioBloom(ReadOnlyTargetRules Target) : base(Target)
	{
		PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;

		PublicDependencyModuleNames.AddRange(new string[] {
			"Core",
			"CoreUObject",
			"Engine",
			"InputCore",
			"EnhancedInput",
			"AIModule",
			"StateTreeModule",
			"GameplayStateTreeModule",
			"UMG",
			"Slate"
		});

		PrivateDependencyModuleNames.AddRange(new string[] { });

		PublicIncludePaths.AddRange(new string[] {
			"HelioBloom",
			"HelioBloom/Variant_Platforming",
			"HelioBloom/Variant_Platforming/Animation",
			"HelioBloom/Variant_Combat",
			"HelioBloom/Variant_Combat/AI",
			"HelioBloom/Variant_Combat/Animation",
			"HelioBloom/Variant_Combat/Gameplay",
			"HelioBloom/Variant_Combat/Interfaces",
			"HelioBloom/Variant_Combat/UI",
			"HelioBloom/Variant_SideScrolling",
			"HelioBloom/Variant_SideScrolling/AI",
			"HelioBloom/Variant_SideScrolling/Gameplay",
			"HelioBloom/Variant_SideScrolling/Interfaces",
			"HelioBloom/Variant_SideScrolling/UI"
		});

		// Uncomment if you are using Slate UI
		// PrivateDependencyModuleNames.AddRange(new string[] { "Slate", "SlateCore" });

		// Uncomment if you are using online features
		// PrivateDependencyModuleNames.Add("OnlineSubsystem");

		// To include OnlineSubsystemSteam, add it to the plugins section in your uproject file with the Enabled attribute set to true
	}
}
