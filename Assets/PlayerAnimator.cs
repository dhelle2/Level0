using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimator : MonoBehaviour
{
    private Animator animator;
    private const string IDLE_ANIMATION_BOOL = "idle";
    private const string WALK_ANIMATION_BOOL = "walk";

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();

    }

    public void AnimateIdle()
    {
        Animate(IDLE_ANIMATION_BOOL);
    }

    public void AnimateWalk()
    {
        Animate(WALK_ANIMATION_BOOL);
    }




    private void DisableOtherAnimations(Animator animator, string animation)
    {
        foreach (AnimatorControllerParameter parameter in animator.parameters)
        {
            if (parameter.name != animation)
            {
                animator.SetBool(parameter.name, false);
            }
        }
    }

    private void Animate(string boolName)
    {
        DisableOtherAnimations(animator, boolName);

        animator.SetBool(boolName, true);
    }
    // Update is called once per frame
    void Update()
    {

    }
}
