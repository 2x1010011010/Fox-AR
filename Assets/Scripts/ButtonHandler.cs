using UnityEngine;
using UnityEngine.UI;

public abstract class ButtonHandler : MonoBehaviour
{
    [SerializeField] protected Button Button;

    private void OnEnable()
    {
        Button.onClick.AddListener(OnButtonClick);
    }

    private void OnDisable()
    {
        Button.onClick.RemoveListener(OnButtonClick);
    }

    protected abstract void OnButtonClick();
}
