using System;

[Serializable]
public readonly struct PlayerStatsReadonly
{
	public readonly short Ping;

	public readonly short FPS;

	public readonly short TargetFPS;

	public PlayerStatsReadonly(short ping, short fps, short targetFps)
	{
		Ping = ping;
		FPS = fps;
		TargetFPS = targetFps;
	}
}
