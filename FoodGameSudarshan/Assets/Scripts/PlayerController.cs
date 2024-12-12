using UnityEngine;
using UnityEngine.InputSystem;
[RequireComponent(typeof(CharacterController))]
public class PlayerController : MonoBehaviour
{
    #region Camera Data
    Transform cameraMainTransform;
    #endregion

    #region Input Controllers
    [SerializeField] InputActionReference moveControl;
    [SerializeField] InputActionReference jumpControl;
    #endregion

    #region Movemnet Data
    [SerializeField] float moveSpeed = 10.0f;
    Vector3 moveDirection = Vector3.zero;
    [SerializeField] float jumpHeight = 3.0f;
    Vector3 jumpVelocity = Vector3.zero;
    [SerializeField] float gravityScale = 5.75f;
    [SerializeField] float rotateSpeed = 5.0f;
    #endregion

    #region Player Data
    CharacterController myController;
    [SerializeField] Transform myModelTransform;
    Animator myAnimator;
    #endregion

    #region Ground Checking
    [SerializeField] Transform groundCheck;
    [SerializeField] float groundDistance = 2.0f;//Chnaged on 10/06/21 from 4.0f to 2.0f
    public LayerMask groundMask;
    //bool isGrounded = true; //Commented on 10/06/21 sandbox 6 slide 4
    bool IsGrounded { get; set; } //Added on 10/06/21 sandbox 6 slide 4
    #endregion

    // Start is called before the first frame update
    public void Start()
    {
        cameraMainTransform = Camera.main.transform;
        myController = GetComponent<CharacterController>();
        myAnimator = GetComponentInChildren<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        //Commented on 10/06/21 sandbox 6 slide 4
        /*isGrounded = Physics.CheckSphere(
            groundCheck.position,
            groundDistance,
            groundMask);*/
        
        CheckGround();//Added on 10/06/21 sandbox 6 slide 4
        Move();
        Jump();
        Rotate();
        //Debug.Log(Time.deltaTime);
    }

    //Added on 10/06/21 sandbox 6 slide 4
    void CheckGround()
    {
        IsGrounded = Physics.CheckSphere(
            groundCheck.position,
            groundDistance,
            groundMask);
        if(IsGrounded)
        {
            jumpVelocity = Vector3.zero;
        }
    }

    void Move()
    {
        //Left/right movemnet - Keys: A & D - Values: -1.0, 0.0, 1.0
        moveDirection.x = moveControl.action.ReadValue<Vector2>().x;
        moveDirection.y = 0.0f;
        //Forward/Backward movemnet - Keys: W & S - Values: -1.0, 0.0, 1.0
        moveDirection.z = moveControl.action.ReadValue<Vector2>().y;
        //Move using the transform
        moveDirection = moveDirection.x * transform.right + moveDirection.z * transform.forward;
        //moveDirection = moveDirection.x * transform.right + moveDirection.z * cameraMainTransform.forward;
        moveDirection.Normalize();
        // transform.Translate(moveDirection * moveSpeed * Time.deltaTime);
        myController.Move(moveDirection * moveSpeed * Time.deltaTime);
        myAnimator.SetFloat("Speed", Mathf.Abs(moveDirection.x) + Mathf.Abs(moveDirection.z));
    }

    void Jump()
    {
        //Cghanged isGrounded to IsGounded on 10/06/21
        if (jumpControl.action.triggered && IsGrounded)
        {
            jumpVelocity.y = Mathf.Sqrt(-3.0f * jumpHeight * gravityScale * Physics.gravity.y);
        }
        jumpVelocity.y += gravityScale * Physics.gravity.y * Time.deltaTime;
        //transform.Translate(jumpVelocity * Time.deltaTime);
        myController.Move(jumpVelocity * Time.deltaTime);
        myAnimator.SetBool("Grounded", IsGrounded);
    }

    //when script is active
    void OnEnable()
    {
        moveControl.action.Enable();
        jumpControl.action.Enable();
    }

    //when script is inactive
    void OnDisable()
    {
        moveControl.action.Disable();
        jumpControl.action.Disable();
    }

    void Rotate()
    {
        if (!(moveDirection.x.Equals(0.0f) && moveDirection.x.Equals(0.0f)))
        {
            transform.rotation = Quaternion.Euler(0.0f,cameraMainTransform.eulerAngles.y,0.0f);
            Quaternion newRotation = Quaternion.LookRotation(new Vector3(moveDirection.x,0.0f,moveDirection.z));
            myModelTransform.rotation = Quaternion.Slerp(myModelTransform.rotation,newRotation,rotateSpeed * Time.deltaTime);
        }
    }
}
