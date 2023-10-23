using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class WeaponAsset : MonoBehaviour
{
    public Weapons weapon;
    public string weaponName;
    public int weaponDamage;

    private PlayerStats stats;


    private void Awake()
    {
        stats = GetComponent<PlayerStats>();
        weaponName = weapon.weaponName;
        weaponDamage = weapon.damage;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Enemy")
        {
            Destroy(gameObject);
        }
    }
}
