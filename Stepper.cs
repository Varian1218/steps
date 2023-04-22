using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Steps
{
    public class Stepper : MonoBehaviour, IStepper
    {
        private readonly List<Func<bool>> _steps = new();

        public void AddStep(Func<bool> step)
        {
            _steps.Add(step);
        }

        public void AddStep(Func<float, bool> step)
        {
            _steps.Add(() => step(Time.deltaTime));
        }

        public void AddStep(IEnumerator step)
        {
            StartCoroutine(step);
        }

        public void AddInverseStep(Func<bool> step)
        {
            _steps.Add(() => !step());
        }

        private void Update()
        {
            _steps.RemoveAll(it => it());
        }
    }
}