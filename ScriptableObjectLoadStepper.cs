using UnityEngine;

namespace Steps
{
    [CreateAssetMenu(menuName = "Steps/Load Stepper", fileName = "Load Stepper", order = 1)]
    public class ScriptableObjectLoadStepper : ScriptableObject
    {
        [SerializeField] private ScriptableObjectStepper stepper;

        public void Invoke()
        {
            var s = new GameObject(nameof(Stepper)).AddComponent<Stepper>();
            stepper.Impl = s;
            DontDestroyOnLoad(s);
        }
    }
}