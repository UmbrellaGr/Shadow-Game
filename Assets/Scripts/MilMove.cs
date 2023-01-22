using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MilMove : MonoBehaviour
{
   
    [SerializeField] private float speed;
    [SerializeField] private float jump;

    private Animator anim;
    private Rigidbody2D myrb;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        myrb = GetComponent<Rigidbody2D>();
    }

    private void Move()
    {
        float movex = Input.GetAxis("Horizontal");

        float move = movex * speed * Time.deltaTime;

        if (move > 0)
        {
            transform.Translate(Vector3.right * move);

            transform.eulerAngles = new Vector3(0, 0, 0);
            anim.SetFloat("Run", Mathf.Abs(1));
        }


        else if (move < 0)
        {
            transform.Translate(Vector3.left * move);

            transform.eulerAngles = new Vector3(0, 180, 0);
            anim.SetFloat("Run", Mathf.Abs(1));
        }

        else
        {
            anim.SetFloat("Run", Mathf.Abs(0));
        }


    }

    private void Jump()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow) && DetectorSuelo.detectorsuelo)
        {
            myrb.AddForce(Vector2.up * jump, ForceMode2D.Impulse);
            
        }

        anim.SetBool("isJump", DetectorSuelo.detectorsuelo);
    }
    // Update is called once per frame
    void Update()
    {
        Move();
        Jump();
    }
}
