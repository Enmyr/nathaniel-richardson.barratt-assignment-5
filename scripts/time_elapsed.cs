using Godot;
using System;

public partial class time_elapsed : Label
{
	// Called when the node enters the scene tree for the first time.
	private float time = 0.0f;
	private Label TimeLabel;
	public override void _Ready()
	{
		base._Ready();

		TimeLabel = GetNode<Label>("LabelTime");
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
		base._Process(delta);

		time += (float)delta;

		TimeLabel.Text = $"Time elapsed since start: {time:F1} s";
	}
}
