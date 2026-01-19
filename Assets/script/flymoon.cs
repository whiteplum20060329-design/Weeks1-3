using UnityEngine;


public class flymoon : MonoBehaviour
{
    public Vector2 start;
    public Vector2 end;
    public float progress;
    public Vector3 output;

    public float duration;

    public Vector2 random;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        start = transform.position;

        random = Random.insideUnitCircle;
    }

    // Update is called once per frame
    void Update()
    {
        progress += Time.deltaTime / duration;

        
        end = end + random * 5;



        output = Vector3.Lerp(start, end, progress);
        transform.position = output;

    }
}
