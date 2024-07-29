using System.Collections;
using System.Collections.Generic;
using UnityEditor.SceneManagement;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    private void Update()
    {
        if ( transform.position.x < -screenBounds.x)

        {
            GameObject.Destroy(gameObject);
        }
        else
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(-speed);
        }
    }
}
