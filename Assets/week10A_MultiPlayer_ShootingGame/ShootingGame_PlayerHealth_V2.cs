using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using UnityEngine.UI;

public class ShootingGame_PlayerHealth_V2 : MonoBehaviourPunCallbacks
{
    float maxHealth = 1f;
    float currentHealth;
    public Slider healthSlider;
    GameObject PlayerCam;

    private void Start()
    {
        currentHealth = maxHealth;
        print("current health(start): " + currentHealth);
        print("max health(start): " + maxHealth);
        print("healthSlider(start): " + healthSlider.value);
        healthSlider.value = currentHealth / maxHealth;

        PlayerCam = Camera.main.gameObject;
    }

    [PunRPC]
    void Damage(float damage)
    {
        print("damaged: " + gameObject.name);
        currentHealth -= damage;
        healthSlider.value = currentHealth / maxHealth;

        if (healthSlider.value <= 0)
        {            
            PlayerCam.transform.SetParent(null);
            Destroy(gameObject);
        }
    }
}
