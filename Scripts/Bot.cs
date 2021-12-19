using Godot;
using System;

public class Bot : Area2D
{
	private const int MoveSpeed = 100;
	private int _ballDir;
    private Ball main_ball;

	public override void _Ready()
	{
        main_ball = GetNode<Ball>("/root/Pong/Ball");
		_ballDir = -1;
	}

	public override void _Process(float delta)
	{
		Vector2 position = Position;
        int dir = 0;
        float diff = main_ball.Position.y - position.y;
        if (diff != 0)
            dir = (int) (diff/Math.Abs(diff));
		position += new Vector2(0, dir * MoveSpeed * delta);
		position.y = Mathf.Clamp(position.y, 16, GetViewportRect().Size.y - 16);
		Position = position;
	}

	public void OnAreaEntered(Area2D area)
	{
		if (area is Ball ball)
		{
			ball.direction = new Vector2(_ballDir, ((float)new Random().NextDouble()) * 2 - 1).Normalized();
			AudioStreamPlayer2D sound = (AudioStreamPlayer2D) ball.GetNode("AudioStreamPlayer2D");
			sound.Play();
		}
	}
}
