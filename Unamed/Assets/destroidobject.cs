using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroidobject : MonoBehaviour
{
    // Start is called before the first frame update
    
    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "enemy")
        {
            Destroy(this.gameObject);
        }
    }
}
