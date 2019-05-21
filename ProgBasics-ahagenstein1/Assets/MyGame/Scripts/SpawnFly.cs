using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnFly : MonoBehaviour
{
    public Fly flyPrefab;

    private void Update()
    {
        SpawnFl();
    }

    private void SpawnFl()
    {
        Fly flyClone = (Fly)Instantiate(flyPrefab, transform.position, transform.rotation);
    }

}
