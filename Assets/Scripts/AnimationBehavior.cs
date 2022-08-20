using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationBehavior : MonoBehaviour
{
    public Animator anim;
    public static AnimationBehavior Instance;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
    }

    public void RunAnimation()
    {
        anim.SetTrigger("Running");
    }
    public void IdleAnimation()
    {
        anim.SetTrigger("Idle");
    }
}
