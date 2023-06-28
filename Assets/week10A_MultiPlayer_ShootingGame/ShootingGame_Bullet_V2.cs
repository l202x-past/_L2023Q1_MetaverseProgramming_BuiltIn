using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class ShootingGame_Bullet_V2 : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        print("bullet hits " + other.gameObject.name);
        if (other.gameObject.tag == "Player")
        {
            PhotonView pv = other.GetComponent<PhotonView>();
            if (!pv.IsMine)
            {
                print("damage " + other.gameObject.name);
                pv.RPC("Damage", RpcTarget.AllBuffered, 0.1f);
            }
        }
        Destroy(gameObject);
    }
}
