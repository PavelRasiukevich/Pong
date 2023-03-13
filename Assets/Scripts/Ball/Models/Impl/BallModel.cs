using Ball.Models.Interfaces;
using UnityEngine;

namespace Ball.Models.Impl
{
    public class BallModel : IBallModel
    {
        public float BallSpeed { get; set; }
        
        public BallModel()
        {
        }

        public Vector3 GetActualPosition()
        {
            return Vector3.zero;
        }
    }
}