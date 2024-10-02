namespace ATMWebAPI.Model
{
    public class ClienteDto
    {
        public string Nome { get; set; }
        public int Idade { get; set; }
        public IFormFile Documento { get; set; }
    }
}
