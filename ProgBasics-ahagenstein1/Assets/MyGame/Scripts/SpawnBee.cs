using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnBee : MonoBehaviour 
{
    public Bee beePrefab;

	// Use this for initialization
	void Start () 
    {
      
	}
	
	// Update is called once per frame
	void Update ()
    {
        SpawnBe();
    }

    private void SpawnBe()
    {
        Bee beeClone = (Bee)Instantiate(beePrefab, transform.position, transform.rotation);
    }
}
