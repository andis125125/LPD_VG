using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collider : MonoBehaviour
{
    private void OnCollisionEnter(Collision other) {
        if (other.gameObject.tag == "Enviroment"){
            Destroy(this.gameObject);
        }
    }
}
