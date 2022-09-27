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

    void OnDrawGizmos()  // Csak editorban fut le //void OndrawGizmosSelected --> csak a kijel�lteket jelen�ti emg
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(a, 0.2f);
        Gizmos.color = Color.blue;
        Gizmos.DrawWireSphere(b, 0.2f);
        Gizmos.color = new Color(1, 0, 1, 1); // szin meghat�roz�sa �rt�kekkel (az utols� �rt�k az �tl�tsz�s�g) k�dban 0-1 k�z�tti �rt�ket kell megadni
        Gizmos.DrawLine(a, b);

    }




   
    
}
