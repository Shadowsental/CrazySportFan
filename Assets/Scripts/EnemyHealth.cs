using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    public int health;
    public int score;
    public int expOnDefeat;

    public ScoreManeger scoreManeger;

    private PlayerLevel playerLevel;

    public WeaponAsset weaponAsset;


    void Awake()
    {
        playerLevel = GetComponent<PlayerLevel>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Weapon")
        {
            weaponAsset = GetComponent<WeaponAsset>();
            Debug.Log("Take damage! " + weaponAsset.weaponDamage + " from: " + weaponAsset.name);

            health -= weaponAsset.weaponDamage;

        }
    }

    void Update()
    {
        if(health <= 0)
        {
            scoreManeger.score += score;
            playerLevel.exp += expOnDefeat;
            Debug.Log("Got: " + expOnDefeat + " exp");
            Destroy(gameObject);
        }
    }
}
