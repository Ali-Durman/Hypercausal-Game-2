using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public float playerSpeed;
    public bool isMoving;
    public static PlayerMove Instance;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(this.gameObject);
        }
    }

    private void Update()
    {
        if (!isMoving) return;
        transform.Translate(Vector3.forward * playerSpeed * Time.deltaTime);
    }
}
