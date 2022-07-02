using UnityEngine;

namespace CodeBase.Ui
{
    public abstract class BasePopup : MonoBehaviour
    {
        [SerializeField] private Animator[] _animators;

        private bool _isEnabled;

        private static readonly int OpenTrigger = Animator.StringToHash("Show");
        private static readonly int CloseTrigger = Animator.StringToHash("Hide");

        public void Open()
        {
            foreach (var animator in _animators)
            {
                animator.SetTrigger(OpenTrigger);
            }
        }

        public void Close()
        {
            foreach (var animator in _animators)
            {
                animator.SetTrigger(CloseTrigger);
            }
        }
    }
}