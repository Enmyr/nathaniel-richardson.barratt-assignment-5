using Godot;
using System;
using System.Runtime.CompilerServices;

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
        if (delta >= 1)
        {
            if (LinearVelocity.X > 0)
            {
                if (LinearVelocity.Y > 0)
                {
                    Shoot = new Vector2(15, 15);
                    ApplyImpulse(Shoot);
                }
                else
                {
                    Shoot = new Vector2(15, -15);
                    ApplyImpulse(Shoot);
                }
            }
            else
            {
                if (LinearVelocity.Y > 0)
                {
                    Shoot = new Vector2(-15, 15);
                    ApplyImpulse(Shoot);
                }
                else
                {
                    Shoot = new Vector2(-15, -15);
                    ApplyImpulse(Shoot);
                }
            }
            delta -= 1;
        }
	}
}
