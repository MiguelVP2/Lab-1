using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cosmos : MonoBehaviour
{


    public GameObject meteor;
    public GameObject meteor2;
    public GameObject meteor3;
    public GameObject meteor4;
    public GameObject meteor5;
    public GameObject meteor6;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine("DropMeteor");
        StartCoroutine("DropMeteor2");
        StartCoroutine("DropMeteor3");        
        StartCoroutine("DropMeteor4");
        StartCoroutine("DropMeteor5");
        StartCoroutine("DropMeteor6");
        }

    // Update is called once per frame
    void Update()
    {
        
    }


    IEnumerator DropMeteor() {
        for (;;) {
            Instantiate(meteor);
            yield return new WaitForSeconds(Random.Range(1.5f, 3f));
        }
    }

    IEnumerator DropMeteor2() {
        for (;;) {
            Instantiate(meteor2);
            yield return new WaitForSeconds(Random.Range(1f, 2f));
        }
    }

    IEnumerator DropMeteor3() {
        for (;;) {
            Instantiate(meteor3);
            yield return new WaitForSeconds(Random.Range(1.5f, 4f));
        }
    }
    
    IEnumerator DropMeteor4()
    {
        for (;;)
        {
            Instantiate(meteor4);
            yield return new WaitForSeconds(Random.Range(1.5f, 3f));
        }
    }
    
    IEnumerator DropMeteor5()
    {
        for (;;)
        {
            Instantiate(meteor5);
            yield return new WaitForSeconds(Random.Range(1.5f, 3f));
        }
    }
    IEnumerator DropMeteor6()
    {
        for (;;)
        {
            Instantiate(meteor6);
            yield return new WaitForSeconds(Random.Range(1.5f, 3f));
        }
    }


}
