using System;
using Base;
using UnityEngine;

namespace BallManipulator.Implementations
{
    public class BallManipulatorController : BaseController
    {
        public Action<Vector3> BallPositionChanged = delegate { };

        private void Update()
        {
            
            //delete
            //ball should move separately from input
            //just test
            var horizontal = Input.GetAxis("Horizontal");
            var vertical = Input.GetAxis("Vertical");

            if (horizontal != 0 || vertical != 0)
                BallPositionChanged(new Vector3(horizontal, vertical));
        }
    }
}