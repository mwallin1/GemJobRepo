
using UnityEngine;

public class pMovement : MonoBehaviour
{

    // Start is called before the first frame update
    // Youtube Link https://www.youtube.com/watch?v=4HpC--2iowE


    public float speed = 6f;
    public float turnSmoothTime = 0.1f;
    float turnSmoothVelocity;
    public CharacterController con;
    public Transform cam;

    // Update is called once per frame
    void FixedUpdate()
    {

        float horizontal = Input.GetAxisRaw("Horizontal");
        float vertical = Input.GetAxisRaw("Vertical");

        Vector3 dir = new Vector3(horizontal, 0f, vertical).normalized;

        if (dir.magnitude >= 0.1f)
        {
            float targetAngle = Mathf.Atan2(dir.x, dir.z) * Mathf.Rad2Deg + cam.eulerAngles.y;
            float angle = Mathf.SmoothDampAngle(transform.eulerAngles.y, targetAngle, ref turnSmoothVelocity, turnSmoothTime);
            transform.rotation = Quaternion.Euler(0f, angle, 0f);
            Vector3 moveDir = Quaternion.Euler(0f, targetAngle, 0f) * Vector3.forward;
            con.Move(moveDir.normalized * speed * Time.deltaTime);
        }


        if (Input.GetKey(KeyCode.Escape)) {
            Application.Quit();
        }

    }

}
