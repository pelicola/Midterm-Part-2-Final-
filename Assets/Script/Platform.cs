using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platform : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void OnCollisionEnter(Collision other){

        if(other.gameObject.tag == "Ball"){
            Destroy(gameObject, 2);
            Debug.Log("Platform Gone");

            
        }
    }
}
