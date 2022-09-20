using UnityEngine;

public class PlayerMover : MonoBehaviour
{
    [SerializeField] float speed;
    [SerializeField] float angularSpeed = 180;
    

     void Update()
    {

        //Inputkezelés

        bool right = Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D);
        bool left = Input.GetKey(KeyCode.LeftArrow);
        bool up = Input.GetKey(KeyCode.UpArrow);
        bool down = Input.GetKey(KeyCode.DownArrow);

        float x = 0;
        if (right && !left)
            x = 1;
        if (left && !right)
            x = -1;

        float y = 0;
        if (up)
            y += 1;
        if (down)
            y += -1;

        Vector3 velocity = new Vector3(x, 0, y);
        velocity.Normalize();
        velocity *= speed;

        


        // Elmozdulás
        /*
        Vector3 position = transform.position;
        position.x += speed * Time.deltaTime;
        transform.position = position;
        */




        transform.position += velocity * Time.deltaTime;

        if (velocity != Vector3.zero)
        {
          Quaternion targetRot = Quaternion.LookRotation(velocity);

            transform.rotation = Quaternion.RotateTowards
                (transform.rotation,
                targetRot,
                angularSpeed * Time.deltaTime);
        }

    }

}
