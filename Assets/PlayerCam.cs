using UnityEngine;

public class PlayerCam : MonoBehaviour
{
    public float sensX;
    public float sebsY;


    public Transform orientation;

    float xRotation;
    float yRotation;

    private void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }



    private void Update()
    {
        float mousex = Input.GetAxisRaw("mouse X") + Time.deltaTime * sensX;
        float mousey = Input.GetAxisRaw("mouse Y") + Time.deltaTime * sensX;

        yRotation += mousex;
        xRotation += mousey;
        xRotation = Mathf.Clamp(xRotation, -90f, 90f);
        transform.rotation = Quaternion.Euler(xRotation, yRotation, 0);
        orientation.rotation = Quaternion.Euler(0, yRotation, 0);
    }
}
