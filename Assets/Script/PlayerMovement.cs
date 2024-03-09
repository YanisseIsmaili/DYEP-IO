using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    public int playerNumber; // 1 pour le joueur 1, 2 pour le joueur 2
    public float speed = 5f;
    public Rigidbody2D rb;
    private Vector2 movementInput;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (playerNumber == 1)
        {
            movementInput = new Vector2(Input.GetAxis("MoveHorizontal_P1"), Input.GetAxis("MoveVertical_P1"));
        }
        else if (playerNumber == 2)
        {
            movementInput = new Vector2(Input.GetAxis("MoveHorizontal_P2"), Input.GetAxis("MoveVertical_P2"));
        }
    }

    void FixedUpdate()
    {
        rb.MovePosition(rb.position + movementInput * speed * Time.fixedDeltaTime);
    }

    // Méthode appelée lorsqu'un dispositif de contrôle est récupéré
    void OnDeviceRegained()
    {
        // Code à exécuter lorsque le dispositif de contrôle est récupéré
    }

    // Méthode appelée lorsqu'un changement de contrôle est détecté
    void OnControlChanged()
    {
        // Code à exécuter lorsqu'un changement de contrôle est détecté
    }

    // Méthodes appelées lorsqu'un mouvement horizontal ou vertical est détecté pour chaque joueur
    void OnMoveHorizontal_P1(InputValue value)
    {
        // Code à exécuter lorsqu'un mouvement horizontal du joueur 1 est détecté
    }

    void OnMoveVertical_P1(InputValue value)
    {
        // Code à exécuter lorsqu'un mouvement vertical du joueur 1 est détecté
    }

    void OnMoveHorizontal_P2(InputValue value)
    {
        // Code à exécuter lorsqu'un mouvement horizontal du joueur 2 est détecté
    }

    void OnMoveVertical_P2(InputValue value)
    {
        // Code à exécuter lorsqu'un mouvement vertical du joueur 2 est détecté
    }
}
