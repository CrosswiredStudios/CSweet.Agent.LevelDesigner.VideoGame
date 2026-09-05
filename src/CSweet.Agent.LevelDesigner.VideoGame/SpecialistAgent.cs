using CrosswiredStudios.VideoGame.AgentKit;

namespace CSweet.Agent.LevelDesigner.VideoGame;

public sealed class SpecialistAgent : VideoGameSpecialistAgentBase
{
    public override string AgentId => "com.csweet.video-game-level-designer";
    public override string Version => "2.1.1";
    protected override string RoleKey => "level-designer";
    protected override string ArtifactTypeKey => "video-game.level-content-plan.v1";
    protected override string RolePrompt => "Own level flows, encounter design, pacing, spatial metrics, content assembly, validation hypotheses, and playable level evidence. Connect every layout decision to player behavior.";
    protected override IReadOnlyList<string> RequiredSections => ["Player Flow", "Spatial Metrics", "Encounters", "Pacing", "Content Assembly", "Validation Hypotheses", "Playable Evidence"];
}
