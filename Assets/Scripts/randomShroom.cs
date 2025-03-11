using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class randomShroom : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        float aléatoires = Random.value(0f, 1f);

        if (aléatoires<0.5f){
            gameObject.transform.position(4,0,0);
        }
        else{
            gameObject.transform.position(0,0,0);
        }
    }
}
