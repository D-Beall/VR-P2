using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooter : MonoBehaviour {
    private Camera _camera;

	// Use this for initialization
	void Start () {
        _camera = GetComponent<Camera>();

        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetMouseButtonDown(0))
        {
            Vector3 point = new Vector3(_camera.pixelWidth / 2, _camera.pixelHeight / 2, 0);
            Ray ray = _camera.ScreenPointToRay(point);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit))
            {
                GameObject hitObject = hit.transform.gameObject;
                Target target = hitObject.GetComponent<Target>();
                if (target != null)
                {
                    target.Die();
                }
                else
                {
                    StartCoroutine(HitIndicator(hit.point));
                }
            }
        }
		
	}

    private IEnumerator HitIndicator(Vector3 pos)
    {
        GameObject sphere = GameObject.CreatePrimitive(PrimitiveType.Sphere);
        sphere.transform.position = pos;

        yield return new WaitForSeconds(1f);

        Destroy(sphere);
    }

    void OnGUI()
    {
        int size = 32;
        float posX = _camera.pixelWidth / 2 - size / 4;
        float posY = _camera.pixelHeight / 2 - size / 2;
        GUI.Label(new Rect(posX, posY, size, size), "+");
        GUI.backgroundColor = Color.black;
        GUI.contentColor = Color.red;
        GUI.Box(new Rect(0, 0, 100, 100), new GUIContent("HP"));
    }
}
