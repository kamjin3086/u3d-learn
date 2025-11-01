using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HightChanger : MonoBehaviour
{
    public float maxHeight = 6;

    private bool s = false;

    void Start() {
        s = true;
    }

    // Update is called once per frame
    void Update()
    {

        if(transform.localScale.y > maxHeight) {
            s = false;
        }

        if(transform.localScale.y<1){
            s = true;
        }
        
        if(s) {
            transform.localScale = new Vector3(1, transform.localScale.y + 0.006f, 1);    
        } else {
            transform.localScale = new Vector3(1, transform.localScale.y - 0.002f, 1);    
        }
        
     }
        
}
