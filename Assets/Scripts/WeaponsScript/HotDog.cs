using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HotDog : MonoBehaviour
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


    public void Damage(int damage)
    {
        Debug.Log("Deal damage");
    }
}