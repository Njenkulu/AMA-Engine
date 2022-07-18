using Godot;
using System;

public class CharacterInfo : Resource
{
	// Declare member variables here. Examples:
	// private int a = 2;
	// private string b = "text";
	[Export] private string name;
	[Export] private int age;
	[Export] private string gender;
	[Export] private int height;
	[Export] private int lifePoints;
	[Export] private int maxGauge;
	[Export] private Sprite portraitSmall;
	[Export] private Sprite portraitBig;
	[Export] private Resource characterPrefab;
	[Export] private Resource hitBoxSetup;
	[Export] private Resource physics;
	[Export] private Resource headLook;
	[Export] private Resource moveSets;
	[Export] private Resource AIInstructions;

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
