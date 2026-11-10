
namespace Heranca
{
    public abstract class Funcionario
    {

        protected decimal Salario;
        public string? Nome { get; set; }



        public virtual void Trabalhar()
        {
            Console.WriteLine("Funcionario está trabalhando.");
        }

        public Funcionario()
        {
           
        }
  
        public Funcionario(string nome, decimal salario)
        {
            Nome = nome;
            Salario = salario;
        }

        public abstract decimal CalcularBonus();

    }
}