using Godot;
using System;

public class StageScript : Resource
{
    // Declare member variables here. Examples:
    // private int a = 2;
    // private string b = "text";
    [Export] private string stageName;
    [Export] private Resource stagePrefab;
    [Export] private AudioStreamPlayer3D stageMusic;
    [Export] private Sprite thumbnail;

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
