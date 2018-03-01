using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class cartLogic : MonoBehaviour {

    public foodLogic fLogic;
   
    Dictionary<GameObject, int> diccion = new Dictionary<GameObject, int>();
    public GameObject textoCarrito;
    public GameObject total;
    public GameObject btnPay;
    // Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
      

    }

    public void darInfoActual()
    {
        string[] txt = fLogic.darActual().GetComponentInChildren<Text>().text.Split(':');
        Debug.Log(txt[0]);
    }

    public void agregarProducto()   
    {
    
        if (diccion.ContainsKey(fLogic.darActual()))
        {
            diccion[fLogic.darActual()]++;
            Debug.Log(diccion[fLogic.darActual()]);
            Debug.Log("paa");// diccion.Values[fLogic.darActual()]++;
            agregarCarritoText();
        }
        else
        {
            diccion.Add(fLogic.darActual(), 1);
            agregarCarritoText();
        }
      
        //objCarritos.Add()
    }

    void agregarCarritoText()
    {
        List<GameObject> llaves = new List<GameObject>(diccion.Keys);
        string textoOut = "";
        string textPay = "";
        foreach (GameObject key in diccion.Keys)
        {
        
            string[] info_value = key.GetComponentInChildren<Text>().text.Split(':');
            int valDicc = (diccion[key]);
            Debug.Log(info_value[1].Trim());
            int valor = int.Parse(info_value[1].Trim());
            int multiplicacion = valDicc * valor;
            textoOut += key.GetComponentInChildren<Text>().text +"\t x "+ diccion[key] + "\t";
            textPay += info_value[0] + ":" + multiplicacion.ToString();
        }
        textoCarrito.GetComponent<Text>().text = textoOut;
        total.GetComponent<Text>().text = textPay;
        btnPay.GetComponent<Text>().text = "Pay: "+textPay;
        Debug.Log(llaves[0]);
    }


}
