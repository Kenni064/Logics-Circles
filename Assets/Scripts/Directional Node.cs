using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DirectionalNode : MonoBehaviour
{
    //public Sprite <variableName>;//
 
    public Sprite none;
    public Sprite left;
    public Sprite right;
    public string current;
    SpriteRenderer sr;

    // Start is called before the first frame update
    void Start()
    {
        sr = GetComponent<SpriteRenderer>();
        sr.sprite = left;
        SwitchSprite();
        
        
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void SwitchSprite()
    {
        

        if(current == "left")
        {
            Debug.Log("Choose Left");
        }
        else if(current == "right")
        {
            Debug.Log("Choose Right");
        }
        else 
        {
            Debug.Log("Choose None");
        }
    }
}
