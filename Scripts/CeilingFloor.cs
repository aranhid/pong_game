using Godot;

public class CeilingFloor : Area2D
{
	[Export]
	private int _bounceDirection = 1;

	public void OnAreaEntered(Area2D area)
	{
		if (area is Ball ball)
		{
			ball.direction = new Vector2(ball.direction.x, -ball.direction.y).Normalized();
		}
	}
}
