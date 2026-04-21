using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    public float speed = 5f;
    public GameObject missilePrefab;

    public AudioSource audioSource;
    public AudioClip shootSound;

    public SpriteRenderer background;

    private float minX, maxX;

    void Start()
    {
        // límites del background
        float bgMinX = background.bounds.min.x;
        float bgMaxX = background.bounds.max.x;

        // tamaño del player
        float objectWidth = GetComponent<SpriteRenderer>().bounds.extents.x;

        minX = bgMinX + objectWidth;
        maxX = bgMaxX - objectWidth;
    }

    void Update()
    {
        Move();
        ShootInput();
    }

    void Move()
    {
        float moveInput = 0f;

        if (Keyboard.current.leftArrowKey.isPressed)
            moveInput = -1f;
        else if (Keyboard.current.rightArrowKey.isPressed)
            moveInput = 1f;

        float posX = transform.position.x + moveInput * speed * Time.deltaTime;

        // limitar dentro del background
        posX = Mathf.Clamp(posX, minX, maxX);

        transform.position = new Vector3(posX, transform.position.y, transform.position.z);
    }

    void ShootInput()
    {
        if (Keyboard.current.spaceKey.wasPressedThisFrame)
        {
            Shoot();
        }
    }

    void Shoot()
    {
        Instantiate(missilePrefab, transform.position, Quaternion.identity);
        audioSource.PlayOneShot(shootSound);
    }
}