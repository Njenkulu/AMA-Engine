using Godot;
using System;

public class CharacterPrefabs : Resource
{
	// Declare member variables here. Examples:
	// private int a = 2;
	// private string b = "text";
	[Export] private Node defaultPrefab;
	[Export] private Node alternateCostume;

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
