

namespace ArrayApp3
{
    class Cadastro
    {
        public string ClientName { get; set; }
        public string Email { get; set; }
        public int RoomNumber { get; set; }

        public Cadastro ()
        {
        }

        public Cadastro( string nome, string email, int number)
        {
            ClientName = nome;
            Email = email;
            RoomNumber = number;
        }

        
        public override string ToString()
        {
            return "Nome: " + ClientName + "; email: " + Email + "; Quarto: " + RoomNumber;
        }
    }
}
