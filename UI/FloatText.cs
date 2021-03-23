using UnityEngine;
public class FloatText : MonoBehaviour
{
    private bool move;
    private Vector2 randomVector;
    Transform myTransform;
    private void Awake()
    {
        myTransform = GetComponent<Transform>();
    }
    private void Start()
    {
        starMotion();
        Destroy(gameObject, 1);
    }
    private void Update()
    {
        if (move)
        {
            myTransform.Translate(randomVector * Time.deltaTime);
        }
    }

    public void starMotion()
    {
        myTransform.localPosition = Vector2.zero;
        randomVector = new Vector2(Random.Range(-0.01f,0.01f), 0.1f);
        move = true;
    }
}
