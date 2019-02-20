using System.Collections;
using UnityEngine;

public class Camera2Texture : MonoBehaviour
{

    public RenderTexture[] renderTextures;
    private Camera cam;

    private void Awake()
    {
        cam = GetComponent<Camera>();
    }

    private void Start()
    {
        StartCoroutine(RenderTexturesCoroutine());
    }

    IEnumerator RenderTexturesCoroutine()
    {
        for (int i = 0; i < renderTextures.Length; i++)
        {
            // just move the camera a little bit and focus the center of the scene
            this.transform.position += Vector3.left * 2 * i;
            cam.transform.LookAt(Vector3.zero);

            cam.targetTexture = renderTextures[i];
            yield return new WaitForSeconds(1f);
            cam.Render();
        }

        cam.targetTexture = null;
        this.gameObject.SetActive(false);
    }
}
