using UnityEngine;

public class collectable : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other)
    {
        print(other.gameObject.name);
    }
 
}
