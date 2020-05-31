using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    [SerializeField]
    GameObject projectile;

    [SerializeField]
    float speed = 100f;

    [SerializeField]
    Transform potatoSpawn;

    [SerializeField]
    float reload = 2;

    [SerializeField]
    Animator animate;
    void Fire(){
        //Debug.Log("Fire!!!");
        GameObject potato = Instantiate(projectile, potatoSpawn.position, Quaternion.identity) as GameObject;
        potato.GetComponent<Rigidbody>().AddForce(potatoSpawn.forward * speed);
        animate.SetTrigger("reload");
    }

    IEnumerator Shooting(){
        while(true){
            if (Input.GetButton("Fire1")){
                Fire();
                yield return new WaitForSeconds(reload);
            } else {
                yield return null;
            }
        }
    }

    
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Shooting());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
