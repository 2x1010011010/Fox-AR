using UnityEngine;

public class EventHandler : MonoBehaviour
{
    [SerializeField] private AnimationSwitcher _animator;
    [SerializeField] private SitButton _sitButton;
    [SerializeField] private JumpButton _jumpButton;
    [SerializeField] private TurnButton _turnButton;
    [SerializeField] private SomersaultButton _somersaultButton;

    private void OnEnable()
    {
        _sitButton.OnSitButtonClick += OnSitButtonClick;
        _jumpButton.OnJumpButtonClick += OnJumpButtonClick;
        _turnButton.OnTurnButtonClick += OnTurnButtonClick;
        _somersaultButton.OnSomersaultButtonClick += OnSomersaultButtonClick;
    }

    private void OnDisable()
    {
        _sitButton.OnSitButtonClick -= OnSitButtonClick;
        _jumpButton.OnJumpButtonClick -= OnJumpButtonClick;
        _turnButton.OnTurnButtonClick -= OnTurnButtonClick;
        _somersaultButton.OnSomersaultButtonClick -= OnSomersaultButtonClick;
    }

    private void OnJumpButtonClick()
    {
        _animator.PlayAnimation("Jump");
    }
    
    private void OnSitButtonClick()
    {
        _animator.PlayAnimation("SitDown");
    }

    private void OnTurnButtonClick()
    {
        _animator.PlayAnimation("Turn");
    }

    private void OnSomersaultButtonClick()
    {
        _animator.PlayAnimation("Somersault");
    }


}
