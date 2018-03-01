using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class foodLogic : MonoBehaviour {


    public GameObject[] comida;
    public GameObject fActual;

    public GameObject hamburguesa;
    public GameObject perro;
    public GameObject ensalada;
    public GameObject other;

    public GameObject[] arFood;

    public bool inAr = false;
   
    public Controlador con;
    public int actual;
    
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void activarCurrent()
    {
        if (actual==0)
        {
            Debug.Log("olas");
            activarBurger();
        }
        else if (actual==1)
        {
            activarPerro();
        }
        else if(actual ==2 )
        {
            activarEnsalada();
        }
        else
        {
            Debug.Log("olas"); 
        }
    }

    public void activarBurger()
    {
        if (inAr)
        {
            activarPanelFood();
            activarBurgerInfo();
            fActual = comida[0];
            setIntActual(0);
        }
        else
        {
            con.activarMenu();
            activarPanelFood();
            activarBurgerInfo();
            fActual = comida[0];
            setIntActual(0);
        }
   
    }

    public void activarPerro()
    {
        if (inAr)
        {
            activarPanelFood();
            activarPerroInfo();
            fActual = comida[1];
            setIntActual(1);
        }
        else
        {
            con.activarMenu();
            activarPanelFood();
            activarPerroInfo();
            fActual = comida[1];
            setIntActual(1);
        }
    }

    public void activarEnsalada()
    {
        if (inAr)
        {
            activarPanelFood();
            activarEnsaladaInfo();
            fActual = comida[2];
            setIntActual(2);
        }

        else
        {
            con.activarMenu();
            activarPanelFood();
            activarEnsaladaInfo();
            fActual = comida[2];
            setIntActual(2);
        }
    }

    public void activarPanelFood()
    {
        con.activarpanelFood();
    }

    public GameObject darActual()
    {
        return fActual;
    }

    public void activarBurgerInfo()
    {
        if (hamburguesa.activeSelf == true)
        {
            hamburguesa.SetActive(false);
        }
        else
        {
            hamburguesa.SetActive(true);
        }
    }
    public void activarPerroInfo()
    {
        if (perro.activeSelf == true)
        {
            perro.SetActive(false);
        }
        else
        {
            perro.SetActive(true);
        }
    }
    public void activarEnsaladaInfo()
    {
        if (ensalada.activeSelf == true)
        {
            ensalada.SetActive(false);
        }
        else
        {
            ensalada.SetActive(true);
        }
    }

    public void backPanelFood()
    {
        activarCurrent();
        activarPanelFood();
    }
    public void returnMain()
    {
        activarCurrent();
    }

    public void setIntActual(int i)
    {
        actual = i;
    }
   
    public void activateArActual()
    {
        if (arFood[actual].activeSelf == true)
        {
            arFood[actual].SetActive(false);
        }
        else
        {
            arFood[actual].SetActive(true);
        }
    }

    public void arButton()
    {
        Debug.Log("ARRRR");
        changeArFlag();
        activarCurrent();
        con.activarArFeature();
        activateArActual();
    }

    public void changeArFlag()
    {
        if (inAr)
        {
            inAr = false;
        }
        else
        {
            inAr = true;
        }
    }
    public GameObject darArActual()
    {
        return arFood[actual];
    }
}
