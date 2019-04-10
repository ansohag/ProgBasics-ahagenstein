using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProgBasics : MonoBehaviour 

{

	// Use this for initialization
	void Start () 
    {
        //Methode im Start aufrufen sonst wird er nicht ausgeführt
       // Operators();
        Test2();
        Test1();
        // AddNumbers(3,2);
        // MultNumbers(2, 3, 1, 2);
        Combine();
        Debug.Log(MyText("ahagenstein"));

        //variable string definiert
        string drama = MyText("ahagenstein");
        Debug.Log("neu " + drama);
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
    //Methode deklaiert und Variablen deklariert
    public void AddNumbers(int a, int b)
    { 
        int c = a + b;
        Debug.Log("add numbers: " + c);
    }

    public void MultNumbers(int a, int b, int c, int d)
    {
        int e = a * b * c * d;
        Debug.Log("mult numbers: " + e);
    }

    public void Combine()
    {
        MultNumbers(4, 2, 1, 3);
        Operators();
        AddNumbers(100, 1000);
    }

    //Methode mit String
    public string MyText(string myName)
    {
        return "Drama " + " " + myName; //leerer String
    }

    // Update is called once per frame
    void Update () 
    {
		
	}
}
