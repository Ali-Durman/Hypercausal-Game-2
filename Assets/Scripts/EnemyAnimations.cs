using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAnimations : MonoBehaviour
{
    public Animator anim;
    public static EnemyAnimations Instance;
    private void Awake()
    {
        if(Instance == null)
        {
            Instance = this;
        }
    }
    
    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == ("Player"))
        {
            anim.SetTrigger("Death");
            Destroy(gameObject);
            IntUIScore.Instance.ScoreInCrease(1);
        }

    }
    public void IdleEnemyAnimation()
    {
        anim.SetTrigger("EnemyIdle");
    } 
}
