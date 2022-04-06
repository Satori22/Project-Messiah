using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;

public class Menu_pausa : MonoBehaviour
{

    public GameObject menu;
    public GameObject continuar;
    public GameObject mapa;
    public GameObject op��es;
    public GameObject itens;
    public GameObject sair;


    public bool pausaLigado;
    public bool pausaDesligado;


    // Start is called before the first frame update
    void Start()
    {
        menu.SetActive(false);
        pausaLigado = false;
        pausaDesligado = true;
        
    }

    // Update is called once per frame
    void Update()
    {

        if (pausaDesligado && Input.GetButtonDown("Pausa"))
        {
            Time.timeScale = 0;
            menu.SetActive(true);
            pausaLigado = true;
            pausaDesligado = false;
        }

        else if(pausaLigado && Input.GetButtonDown("Pausa"))
        {
            Cursor.lockState = CursorLockMode.Locked;
            Cursor.visible = false;
            Time.timeScale = 1;
            menu.SetActive(false);
            pausaLigado = false;
            pausaDesligado = true;
        }
    }

    public void Continuar()
    {

        Time.timeScale = 1;
        menu.SetActive(false);
        pausaLigado = false;
        pausaDesligado = true;
    }

    public void Sair()
    {
        
        Debug.Log("Saiu do jogo");
        Application.Quit();
    }


    //Bot�es para implementar
    public void Mapa()
    {
       
        Debug.Log("Mapa em constru��o");
    }

    public void Op��es()
    {
        
        Debug.Log("Op��es em constru��o");
    }

    public void Itens()
    {
        
        Debug.Log("Itens em constru��o");
    }
}
