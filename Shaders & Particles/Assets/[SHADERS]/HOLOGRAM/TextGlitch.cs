using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class TextGlitch : MonoBehaviour
{
    private TextMeshPro textMeshPro;
    private Vector3 initialPosition;
    private Vector3 initialScale;

    private void Awake()
    {
        textMeshPro = GetComponent<TextMeshPro>();
        initialPosition = transform.position;
        initialScale = transform.localScale;

        StartCoroutine(GlitchRoutine());
    }

    private IEnumerator GlitchRoutine()
    {
        while (true)
        {
            // Restablecer posición y escala
            transform.position = initialPosition;
            transform.localScale = initialScale;
            yield return new WaitForSeconds(0.25f);

            // Alterar posición o escala
            transform.position = initialPosition + new Vector3(0f, 0, 0); // Desplazar ligeramente
            transform.localScale = initialScale * 1.1f; // Agrandar ligeramente
            yield return new WaitForSeconds(0.25f);

            // Restablecer posición y escala
            transform.position = initialPosition;
            transform.localScale = initialScale;
            yield return new WaitForSeconds(0.5f);

            // Alterar posición o escala
            transform.position = initialPosition + new Vector3(0f, 0, 0); // Desplazar en sentido contrario
            transform.localScale = initialScale * 0.9f; // Encoger ligeramente
            yield return new WaitForSeconds(0.1f);

            // Restablecer posición y escala
            transform.position = initialPosition;
            transform.localScale = initialScale;
            yield return new WaitForSeconds(0.1f);

            // Alterar posición o escala
            transform.position = initialPosition + new Vector3(0f, 0, 0); // Desplazar nuevamente
            transform.localScale = initialScale * 1.1f; // Agrandar nuevamente
            yield return new WaitForSeconds(0.1f);

            // Restablecer posición y escala
            transform.position = initialPosition;
            transform.localScale = initialScale;
            yield return new WaitForSeconds(0.4f);

            // Alterar posición o escala
            transform.position = initialPosition + new Vector3(0f, 0, 0); // Desplazar en sentido contrario
            transform.localScale = initialScale * 1.1f; // Encoger nuevamente
            yield return new WaitForSeconds(0.3f);
        }
    }
}
