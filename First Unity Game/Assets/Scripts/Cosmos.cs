using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cosmos : MonoBehaviour
{


    public GameObject Meteor1;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine("DropMeteor2");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void DropMeteors() {
        StartCoroutine("DropMeteor");
    }

    public void StopDropping() {
        StopCoroutine("DropMeteor");
    }

    void DropPiano() {
        Instantiate(Meteor1);
    }

    IEnumerator DropMeteor2() {
        for (;;) {
            Instantiate(Meteor1);
            yield return new WaitForSeconds(Random.Range(1.5f, 3f));
        }
    }


}
