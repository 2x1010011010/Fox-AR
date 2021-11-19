using UnityEngine.Events;

public class SomersaultButton : ButtonHandler
{
    public event UnityAction OnSomersaultButtonClick;
    protected override void OnButtonClick()
    {
        OnSomersaultButtonClick?.Invoke();
    }
}
