using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField] float speed = 10f;
    CharacterController characterController;
    // Start is called before the first frame update
    void Start()
    {
        characterController = GetComponent<CharacterController>();

    }

    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        Vector3 input = new Vector3(x, 0, z);
        Vector3 localInput = transform.rotation * input;
        Vector3 motion = localInput * speed * Time.deltaTime;

        motion += Physics.gravity * Time.deltaTime;

        characterController.Move(motion);
    }
}
