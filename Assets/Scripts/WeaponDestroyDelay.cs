using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponDestroyDelay : MonoBehaviour
{
    public float destroyTime = 5;

    private void Update()
    {
        Destroy(gameObject, destroyTime);
    }
}
