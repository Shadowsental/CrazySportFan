using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShooterRotation : MonoBehaviour
{
    public Transform shooter;
    public float radius;

    private Transform pivot;

    private void Start()
    {
        pivot = shooter.transform;
        transform.parent = pivot;
        transform.position += Vector3.right * radius;
    }

    private void Update()
    {
        Vector3 shooterVector = Camera.main.WorldToScreenPoint(shooter.position);
        shooterVector = Input.mousePosition - shooterVector;
        float angle = Mathf.Atan2(shooterVector.x, shooterVector.y) * Mathf.Rad2Deg;

        pivot.position = shooter.position;
        pivot.rotation = Quaternion.AngleAxis(angle - 90, Vector3.up);
    }
}
