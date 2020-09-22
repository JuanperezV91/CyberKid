using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerObject : MonoBehaviour
{

    void OncollisionEnter(Collision coll)
    {

        
        if (coll.gameObject.name == "Targets")
        {
            Destruction();
        }

       

        
    }

    void Destruction()
    {
        Destroy(this.gameObject);
     
    }
}
