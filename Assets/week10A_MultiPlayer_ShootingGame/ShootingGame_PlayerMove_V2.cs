using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class ShootingGame_PlayerMove_V2 : MonoBehaviourPunCallbacks
{
    public GameObject Gun;
    float GunRotationX;
    GameObject PlayerCam;

    private void Start()
    {
        if(photonView.IsMine)
        {
            PlayerCam = Camera.main.gameObject;
            PlayerCam.transform.SetParent(Gun.transform);
            PlayerCam.transform.localPosition = Vector3.zero;
            PlayerCam.transform.localRotation = Quaternion.identity;
        }
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Cursor.visible = true;
            Cursor.lockState = CursorLockMode.None;
        }
        if (Input.GetMouseButtonDown(0))
        {
            Cursor.visible = false;
            Cursor.lockState = CursorLockMode.Confined;
        }

        if (photonView.IsMine)
        {
            // Move with Horizontal, Vertical Input
            float moveH = Input.GetAxisRaw("Horizontal") * Time.deltaTime * 3f;
            float moveV = Input.GetAxisRaw("Vertical") * Time.deltaTime * 3f;
            transform.Translate(moveH, 0, moveV);

            // Rotate Y Axis 
            float rotY = Input.GetAxisRaw("Mouse X") * Time.deltaTime * 500;
            transform.Rotate(0, rotY, 0);

            // Rotate X Axis (Gun, Camera)
            float rotX = Input.GetAxisRaw("Mouse Y") * Time.deltaTime * 500;
            GunRotationX -= rotX;
            GunRotationX = Mathf.Clamp(GunRotationX, -80f, 20f);
            Gun.transform.localRotation = Quaternion.Euler(GunRotationX, 0, 0);
        }

        if (transform.position.y < -5)
        {
            Vector2 originPos = Random.insideUnitCircle * 2.0f;
            transform.position = new Vector3(originPos.x, 0, originPos.y);
            Vector3 randomForward = Random.insideUnitSphere.normalized;
            Vector3 randomDir = new Vector3(randomForward.x, 0, randomForward.z);
            transform.rotation = Quaternion.LookRotation(randomDir);
        }
    }
}
