using System.Collections;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.UI;

public class Usuarionuevo : MonoBehaviour
{

    // Start is called before the first frame update
    [SerializeField] private InputField inputUsuario, inputContraseña;
    [SerializeField] private Text errorUsuario, errorContra;
    private string urlNoticias = "http://157.230.102.160/formacion/ceu/daw-2019-20/cms/public/index.php/unitynoticias";
    private Usuario usuario;
    public float velocidad = 100;

    private void Start()
    {

        GetComponent<Button>().onClick.AddListener(() => ComprobarUsuario());

    }

    // Update is called once per frame
    private void Update()
    {
    }

    private void ComprobarUsuario()
    {
        if (inputUsuario.text == "")
        {
            errorUsuario.text = "Debes introducir un usuario";
        }
        if (inputContraseña.text == "")
        {
            errorContra.text = "Debes introducir la contraseña";
        }
        else if (inputUsuario.text != "" && inputContraseña.text != "")
        {
            errorContra.text = "";
            errorUsuario.text = "";
            usuario = new Usuario(inputUsuario.text, inputContraseña.text);
            StartCoroutine(ApiMostrarNoticias(urlNoticias, usuario));
        }
    }

    private IEnumerator ApiMostrarNoticias(string urlNoticias, Usuario usuario)
    {
        WWWForm form = new WWWForm();
        form.AddField("usuario", usuario.usuario);
        //form.AddField("contrasena", usuario.contra);

        using (UnityWebRequest webRequest = UnityWebRequest.Post(urlNoticias, form))
        {
            yield return webRequest.SendWebRequest();
            if (webRequest.isNetworkError || webRequest.isHttpError)
            {
                errorUsuario.text = webRequest.error;

            }
            else if (webRequest.downloadHandler.text == "no")
            {
                errorUsuario.text = "Usuario no autorizado";

            }
            else
            {
                string jsonResponse = webRequest.downloadHandler.text;
                errorUsuario.text = "si";
            }
        }

    }

}

