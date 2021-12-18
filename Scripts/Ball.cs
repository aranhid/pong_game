using Godot;
using System;
public class Ball : Area2D
{
	private const int DefaultSpeed = 100;

	public Vector2 direction;

	private Vector2 _initialPos;
	private float _speed = DefaultSpeed;

	private int scorePlayer;
	private int scoreBot;

	public override void _Ready()
	{
		direction = new Vector2(((float)new Random().NextDouble()) * 2 - 1, ((float)new Random().NextDouble()) * 2 - 1).Normalized();
		GD.Print(direction);
		_initialPos = Position;
		scorePlayer = GetNode<Score>("/root/Pong/Score/ScorePlayer").GetScore;
		scoreBot = GetNode<Score>("/root/Pong/Score/ScoreBot").GetScore;
	}

	public override void _Process(float delta)
	{
		_speed += delta * 2;
		Position += _speed * delta * direction * (scoreBot + scorePlayer + 1);
	}

	public void Reset()
	{
		direction = new Vector2(((float)new Random().NextDouble()) * 2 - 1, ((float)new Random().NextDouble()) * 2 - 1).Normalized();
		Position = _initialPos;
		_speed = DefaultSpeed;
	}
}
