using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;

public class escada_vertical : MonoBehaviour
{

    public Transform playerController;
    bool dentro = false;
    public float vel = 6f;
    public FirstPersonController player;
    public AudioSource som;



    void Start()
    {
        player = GetComponent<FirstPersonController>();
        dentro = false;
        
    }


    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "escada")
        {
            Debug.Log("Tocando a escada");
            player.enabled = false;
            dentro = !dentro;
        }
    }

    private void OnTriggerExit(Collider col)
    {
        if (col.gameObject.tag == "escada")
        {
            Debug.Log("Afastou da escada");
            player.enabled = true;
            dentro = !dentro;
        }
    }

    void Update()
    {
        if (dentro == true && Input.GetKey("w"))
        {
            player.transform.position += Vector3.up /
            vel * Time.deltaTime;
        }

        if (dentro == true && Input.GetKey("s"))
        {
            player.transform.position += Vector3.down /
            vel * Time.deltaTime;
        }

        if (dentro == true && Input.GetKey("w"))
        {
            som.enabled = true;
            som.loop = false;
        }
        else
        {
            som.enabled = false;
            som.loop = false;

        }




    }
}
