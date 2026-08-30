# Video Game Level Designer

Owns level flows, encounters, pacing, content assembly, metrics, and playable level evidence.

## Contract

- Package ID: `com.csweet.video-game-level-designer`
- Version: `1.0.0`
- Provides: `video-game.level-designer.execute.v1`
- Activation: manual
- Requested platform/provider capabilities: none
- Event subscriptions: none
- Network access: none

## Develop

```powershell
dotnet test
dotnet run --project src/CSweet.Agent.LevelDesigner.VideoGame -- --self-test
```

The tests run entirely in memory and require no C-Sweet instance or credentials.

## Install

Keep `csweet-plugin.json` at the repository root. Import a reviewed GitHub commit in C-Sweet, or
clone this repository as an immediate child of C-Sweet's configured local agent catalog. Review
the exact manifest, grants, activation mode, and source before approving installation.

Built with `CSweet.Agent.SDK` 4.0.0.
