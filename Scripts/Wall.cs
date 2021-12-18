using Godot;

public class Wall : Area2D
{
	public void OnWallAreaEntered(Area2D area)
	{
		if (area is Ball ball)
		{
			Score score;
			if (Name == "LeftWall")
			{
				score = GetNode<Score>("/root/Pong/Score/ScoreBot");
			}
			else
			{
				score = GetNode<Score>("/root/Pong/Score/ScorePlayer");
			}
			score.AddPoint();
			ball.Reset();
		}
	}
}
