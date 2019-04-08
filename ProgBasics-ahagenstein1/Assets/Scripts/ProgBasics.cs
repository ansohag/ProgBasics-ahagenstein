using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProgBasics : MonoBehaviour {

	// Use this for initialization
	void Start () {
        Debug.Log("erste Tests mit Operatoren");
        Debug.Log("Multiplikative Operatoren: * " + (2 * 4));
        Debug.Log("Multiplikative Operatoren:  / " + (2 / 4));
        Debug.Log("Multiplikative Operatoren:  % " + (2 % 4));
        Debug.Log("Additive Operatoren:  + " + (2 + 4));
        Debug.Log("Additive Operatoren:  - " + (2 - 4));
        Debug.Log("Relationale Operatoren:  < " + (2 < 4));
        Debug.Log("Relationale Operatoren:  <= " + (2 <= 4));
        Debug.Log("Relationale Operatoren:  > " + (2 > 4));
        Debug.Log("Relationale Operatoren:  >= " + (2 >= 4));
        Debug.Log("Gleichheits Operatoren:  == " + (2 == 4));
        Debug.Log("Gleichheits Operatoren:  != " + (2 == 4));
        Debug.Log("Logische Operatoren:  & " + (2 & 4));
        Debug.Log("Logische Operatoren:  | " + (2 | 4));
        Debug.Log("Logische Operatoren: & " + (true && true));

    }

    // Update is called once per frame
    void Update () {
		
	}
}
