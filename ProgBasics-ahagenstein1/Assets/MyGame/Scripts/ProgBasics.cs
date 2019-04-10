using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProgBasics : MonoBehaviour 

{

	// Use this for initialization
	void Start () 
    {
        //Methode im Start aufrufen sonst wird er nicht ausgeführt
        Operators();
        Test2();
        Test1();

    }
    //Methode deklariert
    public void Operators()
    {
        // Multiplikative Operatoren
        Debug.Log("Multiplikative Operatoren: * " + (3 * 4));
        Debug.Log("Multiplikative Operatoren: / " + (12 / 4));
        Debug.Log("Multiplikative Operatoren: % " + (3 % 4));

        //Additive Operatoren
        Debug.Log("Additive Operatoren: + " + (3 + 4));
        Debug.Log("Additive Operatoren: - " + (8 - 4));

        //Relationale Operatoren 
        Debug.Log("Relationale Operatoren: < " + (3 < 4));
        Debug.Log("Relationale Operatoren: <= " + (3 <= 4));
        Debug.Log("Relationale Operatoren: >" + (3 > 4));
        Debug.Log("Relationale Operatoren: >= " + (3 >= 4));

        //Gleichheits Operatoren 
        Debug.Log("Gleichheits Operatoren: ==" + (5 == 5));
        Debug.Log("Gleichheits Operatoren: !=" + (5 != 5));

        //Logische Operatoren 
        Debug.Log("Logische Operatoren: &" + (3 & 5));
        Debug.Log("Logische Operatoren: |" + (3 | 5));
        Debug.Log("Logische Operatoren: ^" + (3 ^ 5));

    }
    //Methode deklaiert
    public void XY()
    {

    }

    public void Test1()
    {
        Debug.Log("Multiplizieren jey: * " + (888 * 666));
    }

    public void Test2()
    {
        Debug.Log("Random Test: + " + (60 + 30));
    }

    // Update is called once per frame
    void Update () 
    {
		
	}
}
