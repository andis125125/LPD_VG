using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Potato : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]
    float damage = 20;

    IEnumerator Remove(){
        yield return new WaitForSeconds(5f);
        Destroy(this.gameObject);
    }
    void Start()
    {
        StartCoroutine(Remove());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
