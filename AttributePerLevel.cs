using TaleWorlds.CampaignSystem.GameComponents;

namespace AttributePerLevel
{
    public class PerLevelCharacterModel : DefaultCharacterDevelopmentModel
    {
        public override int LevelsPerAttributePoint => 1;
        public override int FocusPointsPerLevel => 2;
    }
}
