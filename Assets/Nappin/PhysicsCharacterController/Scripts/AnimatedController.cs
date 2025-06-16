using UnityEngine;


namespace PhysicsCharacterController
{
    public class AnimatedController : MonoBehaviour
    {
        [Header("References")]
        public CharacterManager characterManager;
        public Rigidbody rigidbodyCharacter;
        [SerializeField] LayerMask groundMask;
        [Space(10)]

        [Header("Animation specifics")]
        public float velocityAnimationMultiplier = 1f;
        public bool lockRotationOnWall = true;
        public float groundCheckerThrashold = 0.4f;
        public float climbThreshold = 0.5f;


        private Animator anim;
        private float originalColliderHeight;


        /**/


        private void Awake()
        {
            anim = this.GetComponent<Animator>();
        }


        private void Start()
        {
            originalColliderHeight = characterManager.GetOriginalColliderHeight();
        }


        private void Update()
        { 
            float walk = 0;
            float horizontal = new Vector3(rigidbodyCharacter.linearVelocity.x, 0, rigidbodyCharacter.linearVelocity.z).magnitude;

            if (horizontal > 0.1f)
            {
                walk = Mathf.Abs(horizontal);
            }
            else
            {
                walk = 0;
            }
            anim.SetFloat("Walk", walk);
            
            anim.SetBool("Run", characterManager.GetSprint()); 
            anim.SetBool("Crouch", characterManager.GetCrouching());
            anim.SetBool("Slide", characterManager.GetSliding());
            
            //     anim.SetFloat("velocity", rigidbodyCharacter.linearVelocity.magnitude * velocityAnimationMultiplier);
            //
            //     anim.SetBool("isGrounded", CheckAnimationGrounded());
            //
            //     anim.SetBool("isJump", characterManager.GetJumping());
            //
            //     anim.SetBool("isTouchWall", characterManager.GetTouchingWall());
            //     if (lockRotationOnWall) characterManager.SetLockRotation(characterManager.GetTouchingWall());
            //
            //     anim.SetBool("isClimb", characterManager.GetTouchingWall() && rigidbodyCharacter.linearVelocity.y > climbThreshold);
            //
            //     anim.SetBool("isCrouch", characterManager.GetCrouching());

        }


        private bool CheckAnimationGrounded()
        {
            return Physics.CheckSphere(characterManager.transform.position - new Vector3(0, originalColliderHeight / 2f, 0), groundCheckerThrashold, groundMask);
        }
    }
}