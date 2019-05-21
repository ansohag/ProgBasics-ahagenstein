using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProgBasics : MonoBehaviour 
{
    public int test1;
    public float test2;
    public string test3;
    public int divi1 = 24;
    public int divi2 = 2;

    // Use this for initialization
	void Start () 
    {
        //Methode im Start aufrufen sonst wird er nicht ausgeführt
        test1 = 1;
        Debug.Log("test 1 in Start" + test1);

         // Operators();
        Test2();
        Test1();
        intMult();
        //meinName();
        division();

        // add values for parameters
        AddNumbers(3,2);
        MultNumbers(2, 3, 1, 2);
        MyDatas("18", "Student", "172cm");
        SubNumbers(321, 123);
        meinName("Anna", "Hagenstein");

        // all methodes combined
        Combine();

        //return type
        Debug.Log(MyText("ahagenstein"));

        string drama = MyText("ahagenstein");

        Debug.Log("neu " + drama);

        Debug.Log(Wohnort("Seekirchen am Wallersee"));

        Debug.Log(yo("Billy", "Ray"));
    }

    //Methode deklaiert
    public void XY()
    {
        Debug.Log("Methode XY");

    }


    public void Test1()
    {
        Debug.Log("Multiplizieren jey: * " + (888 * 666));
    }


    public void Test2()
    {
        Debug.Log("Random Test: + " + (60 + 30));
    }

    public void division()
    {
        Debug.Log(divi1 / divi2);
    }

    //Methode deklaiert und Variablen deklariert
    public void AddNumbers(int a, int b)
    { 
        int c = a + b;
        Debug.Log("add numbers: " + c);
        test1 = 3;
        Debug.Log("test 1 in AddNumbers" + test1);
    }

    public void MultNumbers(int a, int b, int c, int d)
    {
        int e = a * b * c * d;
        Debug.Log("mult numbers: " + e);
    }

    //Methodes combined
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

   //return type
    public string Wohnort(string home)
    {
        return "Wohnort " + " " + home;
    }

    public void intMult()
    {
        //deklaration
        int Mult1;
        //initialisierung
        Mult1 = 6;
        int Mult2 = 2;

        Debug.Log("int multi " + (Mult1 * Mult2));
    }

    //return type
    public string yo(string vorname, string nachname)
    {
        return "Hello " + vorname + " " + nachname;
    }

    //parameter
    public void MyDatas(string age, string edu, string height)
    {
        Debug.Log("Age: " + age + ", Status: " + edu + ", Height: " + height);
    }

    //parameter
    public void SubNumbers(int a, int b)
    {
        int c = a - b;
        Debug.Log("substract numbers: " + c);
    }

    //parameter
    public void meinName(string vorname, string nachname)
    {
        Debug.Log("Vorname: " + vorname + " Nachname: " + nachname);
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
}
