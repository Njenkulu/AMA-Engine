using Godot;
using System;

public class PhysicsScript : Resource
{
	// Declare member variables here. Examples:
	// private int a = 2;
	// private string b = "text";

	[Export] private int forwardSpeed;
	[Export] private int backwardSpeed;
	[Export] private bool highMovingFriction;
	[Export] private int friction;
	[Export] private bool enableJump;
	[Export] private int jumpForce;
	[Export] private int jumpDistance;
	[Export] private int jumpDelay;
	[Export] private int landingDelay;
	[Export] private int airJumps;
	[Export] private int charactersWeight;
	[Export] private int groundCollisionMass;
	[Export] private bool cumulativeForce;


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
