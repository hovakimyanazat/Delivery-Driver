using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collision : MonoBehaviour
{
    bool hasPackage;
    [SerializeField] Color hasPackageColor = new Color (1,1,1,1);
    [SerializeField] Color noPackageColor = new Color (1,1,1,1);
    SpriteRenderer spriteRenderer;
     void Start() {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }
    void OnCollisionEnter2D(Collision2D other) 
    {
        
    }
    void OnTriggerEnter2D(Collider2D other) 
    {
        if(other.tag == "Package" && !hasPackage)
        {
            hasPackage = true;
            spriteRenderer.color = hasPackageColor;
            Destroy(other.gameObject , 0.5f);
            
        }

        if(other.tag == "Customer" && hasPackage){
            hasPackage = false;
            spriteRenderer.color = noPackageColor;    
        }
    }
}
