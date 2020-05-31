using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraMove : MonoBehaviour
{
    [SerializeField]
    float sensitivity = 100f;

    [SerializeField]
    Transform body;

    float xRot = 0f;

    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        float mX = Input.GetAxis("Mouse X") * sensitivity * Time.deltaTime;
        float mY = Input.GetAxis("Mouse Y") * sensitivity * Time.deltaTime;

        xRot -= mY;
        xRot = Mathf.Clamp(xRot, -90f, 90f);
        
        transform.localRotation = Quaternion.Euler(xRot, 0f, 0f);

        body.Rotate(Vector3.up * mX);
    }
}
