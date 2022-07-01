using UnityEngine;

namespace CodeBase.Ui
{
    public abstract class BasePopup : MonoBehaviour
    {
        [SerializeField] private Animator[] _animators;

        private bool _isEnabled;

        private static readonly int OpenTrigger = Animator.StringToHash("Show");
        private static readonly int CloseTrigger = Animator.StringToHash("Hide");

        private void Awake()
        {
            OnInitialization();
        }

        private void Update()
        {
            OnUpdate();
        }

        protected virtual void OnUpdate()
        {
        }

        protected virtual void OnInitialization()
        {
        }

        protected virtual void OnClose()
        {
        }

        protected virtual void OnOpen()
        {
        }

        public void Open()
        {
            OnOpen();
            foreach (var animator in _animators)
            {
                animator.SetTrigger(OpenTrigger);
            }
        }

        public void Close()
        {
            OnClose();
            foreach (var animator in _animators)
            {
                animator.SetTrigger(CloseTrigger);
            }
        }
    }
}