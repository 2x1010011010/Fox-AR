using UnityEngine.Events;

public class JumpButton : ButtonHandler
{
    public event UnityAction OnJumpButtonClick;
    protected override void OnButtonClick()
    {
        OnJumpButtonClick?.Invoke();
    }
}
