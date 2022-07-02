using UnityEngine;
using UnityEngine.UI;

namespace CodeBase.Ui
{
    public class ProgressBar : MonoBehaviour
    {
        [SerializeField] private Image _image;

        public void SetProgress(float progressAmount)
        {
            _image.transform.localScale = new Vector3(progressAmount, 1, 1);
        }
    }
}
