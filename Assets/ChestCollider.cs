using System.Collections;
using System.Collections.Generic;
using UnityEngine;

///--------------------------------
///   Authors: PJ & Ari
///   UO270119 - RAA2021
///--------------------------------

public class ChestCollider : MonoBehaviour
{
    public InteractiveChest MyChest;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
        this.MyChest.GetComponent<AudioSource>().enabled = true;
    }

    void OnTriggerExit(Collider other)
    {
        this.MyChest.GetComponent<AudioSource>().enabled = false;
    }
}
