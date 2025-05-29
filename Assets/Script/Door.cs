using UnityEngine;

public class Door : MonoBehaviour, IClickable
{
    private Animator animator;
    private bool isOpen = false;

    void Start()
    {
        animator = GetComponent<Animator>();
    }

    public void OnClick()
    {
        if (isOpen)
        {
            animator.SetTrigger("Close");
        }
        else
        {
            animator.SetTrigger("Open");
        }

        isOpen = !isOpen;
    }
}
