using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateCamera : MonoBehaviour
{
    public float rotationSpeed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Gestion des fleches horizontales du clavier
        float horizontalInput = Input.GetAxis("Horizontal");
        //Rotation autour de l'axe vertical, à la vitesse choisie, et temporisée
        transform.Rotate(Vector3.up, horizontalInput * rotationSpeed * Time.deltaTime);
    }
}
