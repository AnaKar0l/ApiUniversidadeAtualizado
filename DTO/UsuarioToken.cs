namespace apiUniversidade.DTO;
public class UsuarioToken
{
    public bool Autenticado { get; set; }
    public DateTime Expiração { get; set; }
    public string Token { get; set; }
    public string Mensagem { get; set; }
}