using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float MovementSpeed = 5.5f;
    public Projectile projectilePrefab;
    public Transform launchOffSet;

    private void Update()
    {
        var movement = Input.GetAxis("Horizontal");
        transform.position += new Vector3(movement, 0, 0) * Time.deltaTime * MovementSpeed;

        if (Input.GetButtonDown("Fire3")){
        Instantiate(projectilePrefab, launchOffSet.position, transform.rotation);
        }
    }  
}
