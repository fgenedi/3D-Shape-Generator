using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    public static GameObject curShape;
    bool first = true;
    [SerializeField]
    private GameObject[] shapes;

    private int _shapeIndex;
    public int ShapeIndex
    {
        get
        {
            return _shapeIndex;
        }
        set
        {
            _shapeIndex = value;
        }
    }

    private void Awake()
    {
        if (!instance)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }

    }
    
     void Update()
    {
        if(first)
        {
            curShape = GameObject.Instantiate(shapes[ShapeIndex]);
            curShape.GetComponent<Renderer>().material.color = GameUI.curColor;
            first = false;
        }
        if (GameUI.colour)
        {
            curShape.GetComponent<Renderer>().material.color = GameUI.curColor;
            GameUI.colour = false;
        }
        if (DropdownHolder.shape)
        {
            Destroy(curShape);
            curShape = GameObject.Instantiate(shapes[ShapeIndex]);
            curShape.GetComponent<Renderer>().material.color = GameUI.curColor;
            DropdownHolder.shape = false;
        }


    }
}
