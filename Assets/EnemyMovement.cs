using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    public float speed = 2f;
    public SpriteRenderer background;

    private float direction = 1f;
    private float minX, maxX;

    void Start()
    {
        // límites del background
        float bgMinX = background.bounds.min.x;
        float bgMaxX = background.bounds.max.x;

        // tamaño del enemigo
        float objectWidth = GetComponent<SpriteRenderer>().bounds.extents.x;

        // ajustar para que no se salga visualmente
        minX = bgMinX + objectWidth;
        maxX = bgMaxX - objectWidth;
    }

    void Update()
    {
        float posX = transform.position.x;

        if (posX >= maxX)
        {
            direction = -1f;
        }
        else if (posX <= minX)
        {
            direction = 1f;
        }

        posX += direction * speed * Time.deltaTime;

        transform.position = new Vector3(posX, transform.position.y, transform.position.z);
    }
}