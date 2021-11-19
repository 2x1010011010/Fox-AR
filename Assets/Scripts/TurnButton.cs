using UnityEngine.Events;

public class TurnButton : ButtonHandler
{
    public event UnityAction OnTurnButtonClick;
    protected override void OnButtonClick()
    {
        OnTurnButtonClick?.Invoke();
    }
}
