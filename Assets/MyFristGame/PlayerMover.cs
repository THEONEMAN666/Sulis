using UnityEngine;

public class PlayerMover : MonoBehaviour
{
    [SerializeField] float speed;
    [SerializeField] float angularSpeed = 180;
    [SerializeField] Transform cameraTransform;
    [SerializeField] Animator animator;
    

     void Update()
    {

        //Inputkezel?s

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

        Vector3 rightDir = cameraTransform.right;
        Vector3 forwardDir = cameraTransform.forward;
        rightDir.y = 0;
        forwardDir.y = 0;

        Vector3 velocity = x * rightDir.normalized + y * forwardDir;



        // Vector3 velocity = new Vector3(x, 0, y);
        velocity.Normalize();
        velocity *= speed;

        


        // Elmozdul?s
        /*
        Vector3 position = transform.position;
        position.x += speed * Time.deltaTime;
        transform.position = position;
        */




        transform.position += velocity * Time.deltaTime;

        bool isRuning = velocity != Vector3.zero;

        animator.SetBool("isRunning", isRuning);


        if (isRuning)
        {
          Quaternion targetRot = Quaternion.LookRotation(velocity);

            transform.rotation = Quaternion.RotateTowards
                (transform.rotation,
                targetRot,
                angularSpeed * Time.deltaTime);
        }

    }

    public void StepDown()
    {
       
    }

}
