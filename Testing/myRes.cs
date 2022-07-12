using Godot;
using System;

public class myRes : Resource
{
    // Declare member variables here. Examples:
    [Export] private int a = 2;
    [Export] private string b = "text";
    [Export] private Resource res;

    // Called when the node enters the scene tree for the first time.
    public virtual void _Ready()
    {
        
    }

//  // Called every frame. 'delta' is the elapsed time since the previous frame.
//  public override void _Process(float delta)
//  {
//      
//  }
}
