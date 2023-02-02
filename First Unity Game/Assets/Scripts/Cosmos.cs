using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cosmos : MonoBehaviour
{


    public GameObject meteor;
    public GameObject meteor2;
    public GameObject meteor3;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine("DropMeteor");
        StartCoroutine("DropMeteor2");
        StartCoroutine("DropMeteor3");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //public void DropMeteors() {
      //  StartCoroutine("DropMeteor");
    //}

    //public void DropMeteors2() {
      //  StartCoroutine("DropMeteor2");
    //}

    //public void DropMeteors3() {
      //  StartCoroutine("DropMeteor3");
    //}


    //public void StopDropping() {
      //  StopCoroutine("DropMeteor");
    //}

    IEnumerator DropMeteor() {
        for (;;) {
            Instantiate(meteor);
            yield return new WaitForSeconds(Random.Range(1.5f, 3f));
        }
    }

    IEnumerator DropMeteor2() {
        for (;;) {
            Instantiate(meteor2);
            yield return new WaitForSeconds(Random.Range(1.5f, 3f));
        }
    }

    IEnumerator DropMeteor3() {
        for (;;) {
            Instantiate(meteor3);
            yield return new WaitForSeconds(Random.Range(1.5f, 3f));
        }
    }


}
