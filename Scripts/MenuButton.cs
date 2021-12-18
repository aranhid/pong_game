using Godot;
using System;

public class MenuButton : Button
{
    public override void _Pressed()
    {
        base._Pressed();
        if (Name == "Play")
            GetTree().ChangeScene("res://pong.tscn");
        if (Name == "Exit")
            GetTree().Quit();
    }
}
