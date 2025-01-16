using UnityEngine;
using UnityEngine.Assertions.Must;
using UnityEngine.Rendering;

public class MapGenTriggerScript : MonoBehaviour
{
    private void OnTriggerEnter(Collider collider)
    {
        bool colideWithPlayer = collider.gameObject.CompareTag("Player");
        if (colideWithPlayer) {
            Debug.Log(colideWithPlayer);
        }
    }
}
