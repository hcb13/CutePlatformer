using UnityEngine;

public class AnimationDoor : MonoBehaviour
{
    private Animator _animator;

    private void Awake()
    {
        _animator = GetComponent<Animator>();

        GetComponent<OpenDoor>().OnOpenDoor += UpdateDoorOpen;
    }

    private void UpdateDoorOpen()
    {
        _animator.SetBool("IsOpen", true);
    }
}
