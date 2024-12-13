using Godot;
using System;

public partial class BallObj : RigidBody2D
{
    RandomNumberGenerator ShotAngleRandom = new RandomNumberGenerator();
	Vector2 Shoot;
    // Called when the node enters the scene tree for the first time.
    public override void _Ready()
	{
        RandomNumberGenerator randomNumberGenerator = new RandomNumberGenerator();
        float AngleRandom = ShotAngleRandom.RandiRange(0, 4);
        if (AngleRandom == 0) { Shoot = new Vector2(230, 230); }
        if (AngleRandom == 1) { Shoot = new Vector2(-230, 230); }
        if (AngleRandom == 2) { Shoot = new Vector2(-230, -230); ; }
        if (AngleRandom == 3) { Shoot = new Vector2(230, -230); }
        ApplyImpulse(Shoot);
    }

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
        
	}
}
