using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Birdjump : MonoBehaviour
{
    Rigidbody2D rb;
    public float jump_num = 4;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        Debug.Log("게임 시작");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            rb.velocity = Vector2.up * jump_num;
            Debug.Log("마우스 입력 감지");
        }
    }
}
