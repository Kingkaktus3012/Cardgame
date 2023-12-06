using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using UnityEngine.UIElements;

public class Damage : MonoBehaviour
{
    [SerializeField]
    private UnityEngine.UI.Image imageComponent;
    public Sprite Ouch0;
    public Sprite Ouch1;
    public Sprite Ouch2;
    public Sprite Ouch3;
    public Sprite Ouch4;
    public Sprite Ouch5;
    public Sprite Ouch6;
    public Sprite Ouch7;
    public Sprite Ouch8;
    public Sprite Ouch9;
    public Sprite Ouch10;

    public float Ouch0a;
    public float Ouch1a;
    public float Ouch2a;
    public float Ouch3a;
    public float Ouch4a;
    public float Ouch5a;
    public float Ouch6a;
    public float Ouch7a;
    public float Ouch8a;
    public float Ouch9a;
    public float Ouch10a;
    // Start is called before the first frame update
    void Start()
    {
        Ouch0a = 0;
        Ouch1a = 0;
        Ouch2a = 0;
        Ouch3a = 0;
        Ouch4a = 0;
        Ouch5a = 0;
        Ouch6a = 0;
        Ouch7a = 0;
        Ouch8a = 0;
        Ouch9a = 0;
        Ouch10a = 1;
    }

    // Update is called once per frame
    void Update()
    {

        UnityEngine.Debug.Log("Ouch0a: " + Ouch0a); // Check the value of Ouch0a in the console

        if (Ouch0a == 1)
        {
            
            if (imageComponent != null && Ouch0 != null)
            {
                imageComponent.sprite = Ouch0; // Change the image to the new sprite
            }
            Ouch0a = 0;
        }
        
        if (Ouch1a == 1)
        {         
            if (imageComponent != null && Ouch1 != null)
            {
                imageComponent.sprite = Ouch1; // Change the image to the new sprite
            }
            Ouch1a = 0;
        }

        if(Ouch2a == 1)
        {
            if (imageComponent != null && Ouch2 != null)
            {
                imageComponent.sprite = Ouch2; // Change the image to the new sprite
            }
            Ouch2a = 0;
        }

        if (Ouch3a == 1)
        {
            if (imageComponent != null && Ouch3 != null)
            {
                imageComponent.sprite = Ouch3; // Change the image to the new sprite
            }
            Ouch3a = 0;
        }

        if (Ouch4a == 1)
        {
            if (imageComponent != null && Ouch4 != null)
            {
                imageComponent.sprite = Ouch4; // Change the image to the new sprite
            }
            Ouch4a = 0;
        }

        if (Ouch5a == 1)
        {
            if (imageComponent != null && Ouch5 != null)
            {
                imageComponent.sprite = Ouch5; // Change the image to the new sprite
            }
            Ouch5a = 0;
        }

        if (Ouch6a == 1)
        {
            if (imageComponent != null && Ouch6 != null)
            {
                imageComponent.sprite = Ouch6; // Change the image to the new sprite
            }
            Ouch6a = 0;
        }

        if (Ouch7a == 1)
        {
            if (imageComponent != null && Ouch7 != null)
            {
                imageComponent.sprite = Ouch7; // Change the image to the new sprite
            }
            Ouch7a = 0;
        }

        if (Ouch8a == 1)
        {
            if (imageComponent != null && Ouch8 != null)
            {
                imageComponent.sprite = Ouch8; // Change the image to the new sprite
            }
            Ouch8a = 0;
        }

        if (Ouch9a == 1)
        {
            if (imageComponent != null && Ouch9 != null)
            {
                imageComponent.sprite = Ouch9; // Change the image to the new sprite
            }
            Ouch9a = 0;
        }

        if (Ouch10a == 1)
        {
            if (imageComponent != null && Ouch10 != null)
            {
                imageComponent.sprite = Ouch10; // Change the image to the new sprite
            }
            Ouch10a = 0;
        }
    }
}
