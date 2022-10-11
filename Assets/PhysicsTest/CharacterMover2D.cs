
using UnityEngine;

public class CharacterMover2D : MonoBehaviour
{
    [SerializeField] new Rigidbody2D rigidbody;
    [SerializeField] float jumpforce;
    [SerializeField] int moveforce;
    [SerializeField] int moveSpeed;
    [SerializeField] int airJump = 1;
    [SerializeField] LayerMask groundLayer;
    [SerializeField] LayerMask canJumpLayer;

    bool onGround = false;
    int jumpCounts = 0;

    private void OnValidate()
    {
        if (rigidbody == null)
            rigidbody = GetComponent<Rigidbody2D>();  //Ha nincs bekötve semmi keres egy rigibodyt

        GetComponentInParent<Collider2D>();
        GetComponentInChildren<SpriteRenderer>();
    }



     void Update()
    {
      bool jumpPress =  Input.GetKeyDown(KeyCode.Space);

        if (jumpPress && (onGround || jumpCounts > 0 ))
        {
            Vector2 v = rigidbody.velocity;
            v.y = 0;
            rigidbody.velocity = v;

            rigidbody.AddForce(Vector2.up * jumpforce, ForceMode2D.Impulse);
            jumpCounts--;
        }
       
    }

     void FixedUpdate()
    {
        float x = Input.GetAxis("Horizontal");

        if (onGround)
        {
            // Földön nincs tehetelenség

            Vector2 v = rigidbody.velocity;
            v.x = x * moveSpeed;
            rigidbody.velocity = v;

        }
        else
        {
            // Levegõben tehetetlen mozgás
            rigidbody.AddForce(Vector2.right * x * moveforce); // Tehetelen mozgás (super mario)

              // Maximalizálom a vízszintes sebességet
            
            Vector2 v = rigidbody.velocity;
            float direction = Mathf.Sign(v.x);
            float horizontalSpeed = Mathf.Abs(v.x);
            
            v.x = Mathf.Min(horizontalSpeed, moveSpeed) * direction;
            rigidbody.velocity = v;

        }

    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        int layer = collision.gameObject.layer;

        if (groundLayer == (groundLayer | (1 << layer)))
        {
            onGround = true;
            jumpCounts = airJump * 1;

        }




    }
    void OnCollisionExit2D(Collision2D collision)
    {
        onGround = false;

    }
      

}
