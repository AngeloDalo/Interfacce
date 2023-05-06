// See httusing System;

namespace Corso
{
    class Program
    {
        static void Main(string[] args)
        {
            Studente studente1 = new Studente("angelo", "dalo", "5d");
            Insegnante insegnante1 = new Insegnante("angelo2", "dalo2", "io");
            Insegnante insegnante2 = new Insegnante("marco", "neri", "storia");
            Console.WriteLine(insegnante1.Equals(insegnante2));
        }
    }
    class Persona
    {
        public string nome;
        public string cognome;
        public Persona(string nome, string cognome)
        {
            this.nome = nome;
            this.cognome = cognome;
        }
        //VIRTUAL mi permette di far riscrivere metodo
        public virtual void Saluta()
        {
            Console.WriteLine("sono una persona");
        }
    }
    class Insegnante: IEquatable<Insegnante>
    {
        public string materia;
        public string nome;
        public string cognome;
        public Insegnante(string nome, string cognome, string materia)
        {
            this.materia = materia;
            this.nome = nome;
            this.cognome = cognome;
        }
        public bool Equals (Insegnante insegnante)
        {
            return this.nome == insegnante.nome;
        }
    }

    class Studente : Persona
    {
        public string classe;

        public Studente(string nome, string cognome, string classe) : base(nome, cognome)
        {
            this.classe = classe;
        }
        public override void Saluta()
        {
            //base.Salute() prende il saluta di persona
            Console.WriteLine("ciao sono uno studente");
        }
        public void Studia()
        {

        }
    }
}





