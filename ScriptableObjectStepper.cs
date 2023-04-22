using System;
using System.Collections;
using UnityEngine;

namespace Steps
{
    [CreateAssetMenu(menuName = "Steps/Stepper", fileName = "Stepper", order = 1)]
    public class ScriptableObjectStepper : ScriptableObject, IStepper
    {
        private IStepper _impl;

        public IStepper Impl
        {
            set => _impl = value;
        }

        public void AddStep(Func<bool> step)
        {
            _impl.AddStep(step);
        }

        public void AddStep(Func<float, bool> step)
        {
            _impl.AddStep(step);
        }

        public void AddStep(IEnumerator step)
        {
            _impl.AddStep(step);
        }
    }
}