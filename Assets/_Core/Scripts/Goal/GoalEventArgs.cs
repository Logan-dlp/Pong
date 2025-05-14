using System;
using UnityEngine;

public class GoalEventArgs : EventArgs
{
    public Collision2D Collision2D { get; set; }
}
