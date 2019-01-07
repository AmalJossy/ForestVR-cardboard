
using UnityEngine;
using UnityEngine.EventSystems;

[RequireComponent(typeof(Collider))]
public class ChestBehaviour : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject chest, lid;
    static private Vector3 up = new Vector3(0, .5f, 0);
    static private Vector3 down = new Vector3(0, -.5f, 0);
    void Start()
    {
    }
    public void SetGazedAt(bool gazedAt)
    {
        //hint for interaction
        if (gazedAt)
            lid.transform.Translate(up);
        else
            lid.transform.Translate(down);
    }
    public void Reset() { }
    public void Recenter()
    {
#if !UNITY_EDITOR
        GvrCardboardHelpers.Recenter();
#else
        if (GvrEditorEmulator.Instance != null)
        {
            GvrEditorEmulator.Instance.Recenter();
        }
#endif  // !UNITY_EDITOR
    }
    // Update is called once per frame
    public void openLid()
    {
        //open chest lid
        lid.transform.Translate(Vector3.up);
    }
    void Update()
    {

    }
}
