using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseLook : MonoBehaviour
{
    public enum rotationAxes
    {
        mouseXandY = 0,
        mouseX = 1,
        mouseY = 2
    }
    public rotationAxes axes = rotationAxes.mouseY;
    public float sensitivityHor = 9.0f;
    public float sensitivityVer = 9.0f;
    public float minVert = -45.0f;
    public float maxvert = 45.0f;
    private float _rotationX = 0;

    // Start is called before the first frame update
    void Start()
    {
        Rigidbody body = GetComponent<Rigidbody>();
        if (body != null) body.freezeRotation = true;
    }

    // Update is called once per frame
    void Update()
    {
        if(axes == rotationAxes.mouseX)
        {
            transform.Rotate(0, Input.GetAxis("Mouse X") * sensitivityHor, 0);
        } 
        else if(axes == rotationAxes.mouseY)
        {
            _rotationX -= Input.GetAxis("Mouse Y") * sensitivityVer;
            _rotationX = Mathf.Clamp(_rotationX, minVert, maxvert);
            float rotationY = transform.localEulerAngles.y;
            transform.localEulerAngles = new Vector3(_rotationX, rotationY, 0);
        }
        else
        {
            _rotationX -= Input.GetAxis("Mouse Y") * sensitivityVer;
            _rotationX = Mathf.Clamp(_rotationX, minVert, maxvert);
            float delta = Input.GetAxis("Mouse X") * sensitivityHor;
            float rotationY = transform.localEulerAngles.y + delta;
            transform.localEulerAngles = new Vector3(_rotationX, rotationY, 0);
        }
    }
}
