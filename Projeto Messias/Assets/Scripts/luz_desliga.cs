using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class luz_desliga : MonoBehaviour
{

    public GameObject OBluz;
    public BoxCollider trigger;

    public bool onTrigger;


    // Start is called before the first frame update
    void Start()
    {
        OBluz.SetActive(true);
        trigger.enabled = true;

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            onTrigger = true;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if(OBluz.activeInHierarchy && onTrigger)
        {
            onTrigger = false;
            OBluz.SetActive(false);
            trigger.enabled = false;
        }
        
    }
}
