using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FPSControlerScript : MonoBehaviour
{
    public float speed = 5f, RotationDriveMode = 90f, currentSpeed;
    public Vector3 deplacement = Vector3.zero;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void FixedUpdate()
    {
        if(Input.GetKey(KeyCode.LeftControl))
        {
            currentSpeed = speed * 2;
        } else
        {
            currentSpeed = speed;
        }

        transform.Rotate(Vector3.up * RotationDriveMode * Time.fixedDeltaTime * Input.GetAxis("Horizontal"));
        transform.Translate(Vector3.forward * currentSpeed * Time.fixedDeltaTime * Input.GetAxis("Vertical"));
        transform.Translate(Vector3.up * currentSpeed * Time.fixedDeltaTime * Input.GetAxis("Jump"));
    }

}
