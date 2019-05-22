using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnFly : MonoBehaviour
{
    public Fly flyPrefab;
    public GameObject flyParent;

    private void Update()
    {
        //SpawnFl();
    }

    IEnumerator Start()
    {
        while (true)
        {
            yield return new WaitForSeconds(3);
            SpawnFl();
        }

    }

    private void SpawnFl()
    {
        Fly flyClone = (Fly)Instantiate(flyPrefab, transform.position, transform.rotation);
        float flySize = 1f;
        flyClone.transform.localScale = new Vector3(flySize, flySize, 0);
        flyClone.transform.SetParent(flyParent.transform);
        flyClone.transform.localPosition = new Vector3(UnityEngine.Random.Range(-5f, 5f), flyParent.transform.position.y, 0f);
        flyClone.GetComponent<Rigidbody2D>().velocity = new Vector2(UnityEngine.Random.Range(-2, 2), UnityEngine.Random.Range(-10, -1));

    }

}
