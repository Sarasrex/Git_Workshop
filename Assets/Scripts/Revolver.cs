using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    [SerializeField] GameObject revolver;
    [SerializeField] private bool isShooting = false;



    // Start is called before the first frame update
    private void Start()
    {
        
    }

    // Update is called once per frame
    private void Update()
    {
        if (Input.GetMouseButton(0))
        {
            // Shooting functionality
            isShooting = true;
            Debug.Log("bang bang");
        }


        if (Input.GetMouseButtonUp(0))
        {
        // no longer shooting
           isShooting = false;
            Debug.Log(" Hands up");
        }
        

        
    }
}
