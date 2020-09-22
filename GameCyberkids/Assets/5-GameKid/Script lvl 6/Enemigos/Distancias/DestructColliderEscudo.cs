using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestructColliderEscudo : MonoBehaviour
{
    void OncollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag.Equals("BotEnemyBlue"))
        {
            Destroy(collision.gameObject);
        }
    }
}
