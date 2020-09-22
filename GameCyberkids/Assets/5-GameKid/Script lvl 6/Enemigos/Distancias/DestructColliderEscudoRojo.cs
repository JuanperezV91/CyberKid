using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestructColliderEscudoRojo : MonoBehaviour
{
    void OncollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag.Equals("BotEnemyRed"))
        {
            Destroy(collision.gameObject);
        }
    }
}
