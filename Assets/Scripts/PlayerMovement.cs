using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField]
    float movementSpeed;

    [SerializeField]
    float rotateSpeed;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        float movement = Input.GetAxisRaw("Vertical");
        float turn = Input.GetAxisRaw("Horizontal");

        transform.Translate(new UnityEngine.Vector3(0, 0, movement) * movementSpeed * Time.deltaTime);
        transform.Rotate(new UnityEngine.Vector3(0,turn,0)* rotateSpeed * Time.deltaTime);

        if (Input.GetButtonDown("Jump"))
        {
            transform.Translate(new UnityEngine.Vector3(0,1f,0));
        }

    }
}
