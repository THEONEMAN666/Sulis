using UnityEngine;

public class PathMover : MonoBehaviour
{
    [SerializeField] Vector3 a, b;
    [SerializeField] Color col;
    [SerializeField] float speed;

    bool toA = false;  


    private void OnValidate()
    {
        transform.position = (a + b) / 2;


    }


      void Update()
    {
        Vector3 target;
            if (toA)

            target = a;

        else
            target = b;

        transform.position = Vector3.MoveTowards(transform.position, target, speed * Time.deltaTime);

        if (target == transform.position)
        {
            toA = !toA;

        }

    }

    void OnDrawGizmos()  // Csak editorban fut le //void OndrawGizmosSelected --> csak a kijelölteket jeleníti emg
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(a, 0.2f);
        Gizmos.color = Color.blue;
        Gizmos.DrawWireSphere(b, 0.2f);
        Gizmos.color = new Color(1, 0, 1, 1); // szin meghatározása értékekkel (az utolsó érték az átlátszóság) kódban 0-1 közötti értéket kell megadni
        Gizmos.DrawLine(a, b);

    }




   
    
}
