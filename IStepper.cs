using System;
using System.Collections;

namespace Steps
{
    public interface IStepper
    {
        void AddStep(Func<bool> step);
        void AddStep(Func<float, bool> step);
        void AddStep(IEnumerator step);
    }
}