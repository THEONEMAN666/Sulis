
using UnityEngine;

 class Collectable : MonoBehaviour
{
    [SerializeField] Bounds bounds;

   
    [SerializeField] public int value = 1;
    public void TeleportRandom()
    {
        float randomX = Random.Range(bounds.min.x, bounds.max.x);   // random �rt�k lek�r�se minimum �s maximum �rt�ken
        float randomY = Random.Range(bounds.min.y, bounds.max.y);
        float randomZ = Random.Range(bounds.min.z, bounds.max.z);

        transform.position = new Vector3(randomX, randomY, randomZ);
    }

     void OnDrawGizmosSelected()
    {
        Gizmos.DrawWireCube(bounds.center, bounds.size);
    }




}
