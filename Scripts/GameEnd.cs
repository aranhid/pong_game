using Godot;
using System;

public class GameEnd : Node2D
{
    Label label;
    public override void _Ready()
    {
        label = GetNode<Label>("/root/Node2D/Control/Label");
        if (Global.status == "win")
        {
            label.Text = "Victory!";
            GetNode<AudioStreamPlayer>("/root/Node2D/WinSound").Play();
        }
        else
        {
            label.Text = "Lose!";
            GetNode<AudioStreamPlayer>("/root/Node2D/LoseSound").Play();
        }
    }

//  // Called every frame. 'delta' is the elapsed time since the previous frame.
//  public override void _Process(float delta)
//  {
//      
//  }
}
