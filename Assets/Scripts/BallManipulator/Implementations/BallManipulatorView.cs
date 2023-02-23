using Base;
using UnityEngine;

namespace BallManipulator.Implementations
{
    
    //probably change this to BALLVIEW BALLCONTROLLER BALL PROPERTIES thing
    public class BallManipulatorView : BaseView<BallManipulatorController, BallManipulatorProperties>
    {
        private void OnEnable()
        {
            Controller.BallPositionChanged += OnBallPositionChanged;
        }

        private void OnDisable()
        {
            Controller.BallPositionChanged -= OnBallPositionChanged;
        }

        private void OnBallPositionChanged(Vector3 data)
        {
            Debug.LogWarning("Ball Moving");
        }
    }
}
