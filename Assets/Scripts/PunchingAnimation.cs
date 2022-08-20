using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PunchingAnimation : MonoBehaviour
{
    public Animator anim;
    public static PunchingAnimation Instance;
    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == ("Enemy"))
        {
            anim.SetTrigger("Punch");
            anim.SetTrigger("Running");
        }
    }
}
