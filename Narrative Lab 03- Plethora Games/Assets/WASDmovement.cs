using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WASDmovement : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
    }
    // Update is called once per frame
    void Update()
    {
        float moveSpeed = 2f;
        Input.GetKey(KeyCode.W);
        Input.GetKey(KeyCode.S);
        Input.GetKey(KeyCode.A);
        Input.GetKey(KeyCode.D);
        if (Input.GetKey(KeyCode.W))
        {
            Debug.Log("Pressing W");
            transform.position += Vector3.up * Time.deltaTime * moveSpeed;
        }
        if (Input.GetKey(KeyCode.S))
        {
            Debug.Log("Pressing S");
            transform.position += Vector3.down * Time.deltaTime * moveSpeed;
        }
        if (Input.GetKey(KeyCode.A))
        {
            Debug.Log("Pressing A");
            transform.position += Vector3.left * Time.deltaTime * moveSpeed;
        }
        if (Input.GetKey(KeyCode.D))
        {
            Debug.Log("Pressing D");
            transform.position += Vector3.right * Time.deltaTime * moveSpeed;
        }
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");
        Vector3 move = new Vector3(horizontal, vertical, 0);
        transform.position += move * Time.deltaTime;
        if (move.sqrMagnitude > 0.01f) 
        {
            transform.up = move.normalized;
        }

    }
}
