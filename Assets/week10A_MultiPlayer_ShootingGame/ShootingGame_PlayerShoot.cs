using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class ShootingGame_PlayerShoot : MonoBehaviourPunCallbacks
{
    public GameObject Bullet;
    public Transform Gun;
    public float speed = 3f;

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            print(gameObject.name + " mouse 0 down");
            if (photonView.IsMine)
            {
                print(photonView.Owner.NickName + " shoots");
                photonView.RPC("Shoot", RpcTarget.AllBuffered);
            }
            else
            {
                print(photonView.Owner.NickName + " doesn't shoot");
            }
        }
    }

    [PunRPC] //RPC = Remote Procedure Calls. Calls Remote Clone's Method
    void Shoot()
    {
        Vector3 BulletPos = Gun.position + Gun.forward * 2;
        Quaternion BulletRot = Gun.rotation;
        Vector3 BulletSpeed = Gun.forward * speed;

        GameObject Clone = Instantiate(Bullet, BulletPos, BulletRot);
        Clone.GetComponent<Rigidbody>().AddForce(BulletSpeed, ForceMode.Impulse);
        Destroy(Clone, 2f);
    }

}
