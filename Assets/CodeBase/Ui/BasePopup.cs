using UnityEditor.Callbacks;
using UnityEngine;

namespace CodeBase.Ui
{
    public abstract class BasePopup : MonoBehaviour
    {
        [SerializeField] private Animator[] _animators;
        
        private bool _isEnabled;
        
        private static readonly int OpenTrigger = Animator.StringToHash("Open");
        private static readonly int CloseTrigger = Animator.StringToHash("Close");

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
            throw new System.NotImplementedException();
        }

        protected virtual void OnOpen()
        {
            throw new System.NotImplementedException();
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
