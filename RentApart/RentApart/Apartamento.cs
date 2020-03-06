namespace RentApart
{
    class Apartamento
    {
        public int NroContrato { get; set; }
        public string Locatario { get; set; }
        public string Email { get; set; }

        public Apartamento(int nrocontrato, string locatario, string email)
        {
            NroContrato = nrocontrato;
            Locatario = locatario;
            Email = email;
        }
    }
}
