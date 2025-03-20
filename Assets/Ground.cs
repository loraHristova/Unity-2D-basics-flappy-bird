using UnityEngine;

public class Ground : MonoBehaviour
{

    public float speed = 4f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(new Vector3(-1f, 0f, 0f) * Time.deltaTime * speed);

        if(transform.position.x <= -13.5f){
            transform.position = new Vector3(1.5f, transform.position.y, transform.position.z);
        }
    }
}
