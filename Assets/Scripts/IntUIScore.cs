using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class IntUIScore : MonoBehaviour
{
    public Text Score;
    public int score;
    public static IntUIScore Instance;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
    }
    void Start()
    {
        score = 0;
        Score.text = "Score = " + score;
    }
    public void ScoreInCrease(int scorecomefrom)
    {
        score += scorecomefrom;
        Score.text = "Score = " + score;
        Debug.Log(score);
        if (score == 10)
        {
            PlayerMove.Instance.isMoving = false;
            AnimationBehavior.Instance.enabled = false;
            EnemyAnimations.Instance.enabled = false;
            PunchingAnimation.Instance.enabled = false;
            PlayerSwerve.Instance.enabled = false;
        }
    }
}
