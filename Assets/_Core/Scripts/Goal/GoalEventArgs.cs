using System;
using UnityEngine;

namespace Pong.Goal 
{
    public class GoalEventArgs : EventArgs
    {
        public Collision2D Collision2D { get; set; }
    }
}

