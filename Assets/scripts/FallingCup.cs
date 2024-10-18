using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallingCup : MonoBehaviour
{
    [SerializeField]  GameObject[] cups;
    [SerializeField]  float secondSpawn = 0.5f;
    [SerializeField]  float minTras;
    [SerializeField]  float maxTras; 
    void Start()
    {
        StartCoroutine(CupSpawn());
    }

    IEnumerator CupSpawn()
    {
        while (true)
        {
            var wanted =  Random.Range(minTras, maxTras);
            var position = new Vector3(wanted, transform.position.y);
            GameObject gameObject = Instantiate(cups[Random.Range(0, cups.Length)], position, Quaternion.identity);
            yield return new WaitForSeconds(secondSpawn);
            Destroy(gameObject, 5f);
        }
    }

    
}
