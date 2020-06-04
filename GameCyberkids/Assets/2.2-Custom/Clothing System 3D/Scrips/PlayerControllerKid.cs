using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerKid : MonoBehaviour
{
/*
    //Variables de Movimiento
    float horizontalMove;
    float verticarMove;

    private Vector3 playerInput;

    public CharacterController player;
    public float playerSpeed;
    public float gravity;
    public float fallVelocity;
    public float jumpForce;

    //Variables de movimiento relativo a camara
    public Camera mainCamera;
    private Vector3 camForward;
    private Vector3 camRight;
    private Vector3 movePlayer;

    //Variables de deslizamiento en pendientes
    public bool isOnSlope = false;
    private Vector3 hitNormal;
    public float slideVelocity;
    public float slopeForceDown;

    //Variables de animación
    public Animator playerAnimatorController;

    //Cargamos el componente CharacterController en la variable player al iniciar el script
    void Start()
    {
        player = GetComponent<CharacterController>();
        playerAnimatorController = GetComponent<Animator>();
        
    }


    void Update()
    {
        //Guardamos el valor de entrada horizontal y vertical para el movimiento
        horizontalMove = playerInput.GetAxis("Horizontal");
        verticarMove = playerInput.GetAxis("Vertical");

        playerInput = new Vector3(horizontalMove, 0, verticarMove); //Los almacenamos en un Vector 3
        playerInput = Vector3.ClampMagnitude(playerInput, 1); //Y limitamos su magnitud a 1 para evitar aceleraciones en movimientos diagonales

        playerAnimatorController.SetFloat("PlayerWalkVelocity", playerInput.magnitude * playerSpeed);

        CamDirection(); //Llamamos a la funcion CamDirection()

        movePlayer = playerInput.x * camRight + playerInput.z * camForward; //Almacenamos en movePlayer el vector de movimiento corregido 
        movePlayer = movePlayer * playerSpeed; // Y lo multiplicamos por la velocidad del jugador "playerSpeed"
        player.transform.LookAt(player.transform.position + movePlayer); //Hacemos que nuestro personaje mire siempre en la direccion en la que nos estamos moviendo

        SetGravity(); //Llamamos a la funcion SetGravity() para aplicar la gravedad
        PlayerSkills(); //Llamamos a la funcion PlayerSkills() para invocar las habilidades de nuestro personaje
        player.Move(movePlayer * Time.deltaTime); //Por ultimo, trasladamos los datos de movimiento a nuestro personaje
                                                  //De este modo mantenemos unos FPS estables independientes

        Debug.Log(playerInput.magnitude * playerSpeed);


    }


    public void CamDirection()
    {
        //Guardamos los vectores correspondientes a la posicion/rotacion de la camara tanto hacia adelante como hacia atras
        camForward = mainCamera.transform.forward;
        camRight = mainCamera.transform.right;
        //Asignamos los valores de "y" a 0 para no crear conflictos con otras operaciones de movimiento
        camForward.y = 0;
        camRight.y = 0;
        //Y normalizamos sus valores.
        camForward = camForward.normalized;
        camRight = camRight.normalized;

    }

    //Funcion para las habilidades de nuestro jugador
    public void PlayerSkills()
    {
        //Si estamos tocando el suelo y pulsamos el boton "Jump"
        if (player.isGrounded && Input.GetButtonDown("Jump"))
        {
            fallVelocity = jumpForce; //La velocidad de caida pasa a ser igual a la velocidad de salto
            movePlayer.y = fallVelocity; // Y pasamos el valor a movePlayer.y
            playerAnimatorController.SetTrigger("PlayerJump");

        }
    }


    //Funcion para la gravedad 
    public void SetGravity()
    {
        //Si estamos tocando el suelo
        if (player.isGrounded)
        {
            //La velocidad de caida es igual a la gravedad en valor negativo * Time.deltaTime.
            fallVelocity = gravity * Time.deltaTime;
            movePlayer.y = fallVelocity;
        }
        else //Si no...
        {
            //Aceleramos la caida cada frame restando el valor de la gravedad * Time.deltaTime.
            fallVelocity -= gravity * Time.deltaTime;
            movePlayer.y = fallVelocity;
            playerAnimatorController.SetFloat("PlayerVerticalVelocity", player.velocity.y);
        }
        playerAnimatorController.SetBool("IsGrounded", player.isGrounded);
        SlideDown(); //Llamamos a la funcion SlideDown() para comprobar si estamos en una pendiente
    }


    public void SlideDown()
    {
        //Si el angulo de la pendiente en la que nos encontramos es mayor o igual al asignado en player.
        isOnSlope = Vector.Angle(Vector3.up, hitNormal) >= player.slopeLimit && Vector3.Angle(Vector3.up, hitNormal) <= 90 && player.isGrounded;

        if (isOnSlope) //Si isOnSlope es Verdadero
        {
            //Movemos a nuestro jugador en los ejes "x" y "z" mas o menos deprisa en proporcion al angulo de la pendiente.
            movePlayer.x += ((1f - hitNormal.y) * hitNormal.x) * slideVelocity;
            movePlayer.z += ((1f - hitNormal.y) * hitNormal.z) * slideVelocity;
            //Y aplicamos una fuerza extra hacia abajo para evitar saltos al caer por la pendiente
            movePlayer.y += slopeForceDown;


        }
    }

    //Esta funcion detecta cuando colisionamos con otro objeto mientras nos movemos
    private void OnControllerColliderHit(ControllerColliderHit hit)
    {
        //Almacenamos la normal del plano contra el que hemos chocado en hitNormal
        hitNormal = hit.normal;
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.tag == "MovingPlatform")
        {
            Debug.Log("UNA PLATAFORMA!");
            player.transform.SetParent(other.transform);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if(other.tag == "MovingPlatform")
        {
            player.transform.SetParent(Null);
        }
    }

    private void OnAnimatorMove()
    {

    }

    */

}
