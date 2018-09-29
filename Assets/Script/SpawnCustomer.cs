using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnCustomer : MonoBehaviour {

    public Transform customer1;
    public Transform customer2;
    private int random;

    void Start() {
        spawn();
    }

    public void spawn()
    {
        random = Random.Range(0, 1);
        if(random == 0)
        {
            Instantiate(customer1);
        }else if(random == 1)
        {
            Instantiate(customer2);
        }
    }
}
