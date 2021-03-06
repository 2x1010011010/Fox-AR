using UnityEngine;

public class AnimationSwitcher : MonoBehaviour
{
    [SerializeField] private Animator _animator;

    public void PlayAnimation(string animation)
    {
        _animator.StopPlayback();
        _animator.Play(animation);
    }
}
