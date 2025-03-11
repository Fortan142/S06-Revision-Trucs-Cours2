using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class creationMonnaieBonze : MonoBehaviour
{
    // Start is called before the first frame update
    

    [SerializeField] GameObject _prefabOriginal;

    void Start(){
        Quaternion _rotation = Quaternion.Euler(0f, 90f, 0f);
         Instantiate(_prefabOriginal, gameObject.transform.position, _rotation);
    }
    


}
