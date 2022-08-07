using UnityEngine;
using UnityEngine.UI;
public class DropdownHolder : MonoBehaviour
{
    private Dropdown dropdown;
    public static bool shape;
    private void Start()
    {
        dropdown = transform.GetComponent<Dropdown>();
        dropdown.onValueChanged.AddListener(delegate { OnShape(); });
    }

     void OnShape()
    {
        shape = true;
        GameManager.instance.ShapeIndex = dropdown.value;
       
    }
}
