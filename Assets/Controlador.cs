using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controlador : MonoBehaviour {

    public GameObject screenPrincipal;
    public GameObject panelFood;
    public GameObject food;
    public GameObject canvas;
    public GameObject tangoCam;
    public GameObject cam;
    public GameObject bkArBtn;
    public GameObject arPoint;
    public GameObject arUI;
    public GameObject menuChoize;
    public GameObject orderScreen;
    public GameObject payScreen;

	// Use this for initialization
	void Start () {
        inciar();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void darMenu()
    {
        activarscreeMain();
        activarMenu();
       
    }

    public GameObject darPanelFood()
    {
        return panelFood;
    }

    public void activarMenu()
    {
        if (menuChoize.activeSelf == true)
        {
            menuChoize.SetActive(false);
        }
        else
        {
            menuChoize.SetActive(true);
        }
    }
    /// <summary>
    /// 
    /// 
    /// 
    //public GameObject food;
    //public GameObject bkArBtn;
    //public GameObject arUI;
    public void inciar()
    {
        activarscreeMain();
    }
    public void activarArPointCloud()
    {
        if (arPoint.activeSelf == true)
        {
            arPoint.SetActive(false);
        }
        else
        {
            arPoint.SetActive(false);
        }
    }
    public void activarTangoCam()
    {
        if(tangoCam.activeSelf == true)
        {
            tangoCam.SetActive(false);
        }
        else
        {
            tangoCam.SetActive(true);
        }
    }

    public void activateCam()
    {
        if(cam.activeSelf == true)
        {
            cam.SetActive(false);
        }
        else
        {
            cam.SetActive(true);
        }
    }
    public void activarCanvas()
    {
        if (canvas.activeSelf == true)
        {
            canvas.SetActive(false);
        }
        else
        {
            canvas.SetActive(true);
        }
    }
    public void activarscreeMain()
    {
        if ( screenPrincipal.activeSelf == true)
        {
            screenPrincipal.SetActive(false);
        }
        else
        {
            screenPrincipal.SetActive(true);
        }
    }

    public void activarpanelFood()
    {
        if (panelFood.activeSelf == true)
        {
            panelFood.SetActive(false);
        }
        else
        {
            panelFood.SetActive(true);
        }
    }
    
    public void activarArUi()
    {
        if (arUI.activeSelf == true)
        {
            arUI.SetActive(false);
        }
        else
        {
            arUI.SetActive(true);
        }
    }

    public void activarOrderScreen()
    {
        if (orderScreen.activeSelf == true)
        {
            orderScreen.SetActive(false);
        }
        else
        {
            orderScreen.SetActive(true);
        }
    }
    public void activarPayScreen()
    {
        if (payScreen.activeSelf == true)
        {
            payScreen.SetActive(false);
        }
        else
        {
            payScreen.SetActive(true);
        }
    }

    public void changePayScreen()
    {
        activarscreeMain();
        activarPayScreen();
    }

    public void activarArFeature()
    {
        activarArPointCloud();
        activarTangoCam();
        activarArUi();
    }
    public void volverDelMenuFoAlMenuMain()
    {
        activarMenu();
        activarscreeMain();
    }

    public void ChangeToOrder()
    {
        activarscreeMain();
        activarOrderScreen();
    }
}
