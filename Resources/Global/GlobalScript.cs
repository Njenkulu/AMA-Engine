using Godot;
using System;

public class GlobalScript : Node
{
	// Declare member variables here. Examples:
	// private int a = 2;
	// private string b = "text";

	[Export] private Resource P1Info;
	[Export] private Resource P2Info;
	[Export] private Resource P1AssistInfo;
	[Export] private Resource P2AssistInfo;

	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		
	}

 // Called every frame. 'delta' is the elapsed time since the previous frame.
 public override void _Process(float delta)
 {
	 
 }
}
