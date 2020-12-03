﻿namespace CooksAssistant
{
	public class Config
	{
		public bool AddCookingMenu { get; set; } = true;
		public bool AddCookingCommunityCentreBundle { get; set; } = true;
		public bool AddCookingSkill { get; set; } = true;
		public bool AddCookingTool { get; set; } = true;
		public bool AddCookingQuestline { get; set; } = true;
		public bool AddNewStuff { get; set; } = true;
		public bool AddNewRecipeScaling { get; set; } = true;
		public bool PlayCookingAnimation { get; set; } = true;
		public bool FoodHealingTakesTime { get; set; } = true;
		public bool FoodCanBurn { get; set; } = true;
		public bool HideFoodBuffsUntilEaten { get; set; } = true;
		public bool DebugMode { get; set; } = true;
		public bool DebugRegenTracker { get; set; } = true;
		public string ConsoleCommandPrefix { get; set; } = "cac";
	}
}
