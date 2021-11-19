using UnityEngine.Events;

public class SitButton : ButtonHandler
{
    public event UnityAction OnSitButtonClick;
    protected override void OnButtonClick()
    {
        OnSitButtonClick?.Invoke();
    }
}
