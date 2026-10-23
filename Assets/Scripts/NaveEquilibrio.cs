using UnityEngine;

public class NaveEquilibrio : MonoBehaviour
{
    public float velocidad = 8f;
    private SpriteRenderer spriteRenderer;

    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.A) || (Input.GetKey(KeyCode.LeftArrow)))
        {
            transform.Translate(Vector3.left * velocidad * Time.deltaTime);
            spriteRenderer.color = Color.red;
        }

        if (Input.GetKey(KeyCode.D) || (Input.GetKey(KeyCode.RightArrow)))
        {
            transform.Translate(Vector3.right * velocidad * Time.deltaTime);
            spriteRenderer.color = Color.blue;
        }

        if (Input.GetKey(KeyCode.W) || (Input.GetKey(KeyCode.UpArrow)))
        {
            transform.Translate(Vector3.up * velocidad * Time.deltaTime);
            spriteRenderer.color = Color.green;
        }

        if (Input.GetKey(KeyCode.S) || (Input.GetKey(KeyCode.DownArrow)))
        {
            transform.Translate(Vector3.down * velocidad * Time.deltaTime);
            spriteRenderer.color = Color.yellow;
        }
        
        if (Input.GetKey(KeyCode.Space))
        {
            transform.Translate(Vector3.up * velocidad * Time.deltaTime);
            spriteRenderer.color = Color.magenta;
        }
    }
}