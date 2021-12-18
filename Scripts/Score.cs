using Godot;
using System;

public class Score : Label {

    private int _score;

    public override void _Ready()
	{
        _score = 0;
        Text = _score.ToString();
	}

    public void AddPoint()
    {
        if (_score == 9)
        {
            if (Name == "ScorePlayer")
            {
                Global.status = "win";
            }
            else
            {
                Global.status = "lose";
            }
            GetTree().ChangeScene("res://game_end.tscn");
        }
        _score += 1;
        Text = _score.ToString();
    }

    public int GetScore {
        get {
            return _score;
        }
    }
}