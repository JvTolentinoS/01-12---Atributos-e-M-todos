using System;

namespace _01_12___Atributos_e_M_todos
{
    internal class NewBaseType
    {
        static void Main(string[] args)
        {
            Personagens primeiroPersonagem = new Personagens();
            Personagens segundoPersonagem = new Personagens();

            Console.WriteLine("Simulador de Batalha!");
            Console.WriteLine("-------------------------");
            Console.WriteLine("Escolha seu 1º personagem");
            Primeiro();

            Console.WriteLine($"Esse simulador tenta reimaginar uma batalha entre dois comandantes, seu sistema é simples e não adequa sistemas complexos, no entanto envolve regras que ditam os meios para garantir uma vitória, para isso, existem três tipos de movimentos permitidos, o efeito de cada um deles dependerá da habilidade de seu comandante, bem como a disposição de suas tropas para lutar. O primeiro movimento é o 'Avançar', ele permite realizar uma ação ofensiva contra um inimigo, ela é efetiva contra uma defesa. O segundo movimento é o 'Envelopar', ele permite derrotar um 'Avançar' sem problemas. O terceiro movimento é o 'Defender', ele permite derrotar uma tentativa de Envelopagem. O máximo de turnos permitidos são 5 para cada jogador, o vencedor será aquele que melhor destruir o exército inimigo. Um exército perde quando é derrotado três vezes.");

            Console.WriteLine("-------------------------");

            Console.WriteLine($"O comandante {primeiroPersonagem.nome} sempre será o primeiro a atacar, qual será seu movimento?");
            Console.WriteLine($"[1] - Avançar");
            Console.WriteLine($"[2] - Envelopar");
            Console.WriteLine($"[3] - Defender");

            int escolha = int.Parse(Console.ReadLine());
            switch (escolha)
            {
                case 1:
                AvancarPrimeiro();
                break;

                case 2:

                break;

                case 3:

                break;
            }










            //Métodos
            
            void AvancarPrimeiro(){
                primeiroPersonagem.avançar = true;
                if(segundoPersonagem.defesa == true){
                if(segundoPersonagem.organização <= 1){
                    Console.WriteLine($"Comandante {primeiroPersonagem.nome} conseguímos derrotar o inimigo!");
                }else if(segundoPersonagem.organização <= 2){
                    Console.WriteLine($"Comandante {primeiroPersonagem.nome} só nos resta mais uma vitória para expulsarmos o inimigo!");
                    segundoPersonagem.organização = 2 - 1;
                }else if(segundoPersonagem.organização <= 3){
                    Console.WriteLine($"Comandante {primeiroPersonagem.nome} Vitória! o inimigo foi forçado a recuar perante nosso avanço!");
                }
                }
                if(segundoPersonagem.envelopar == true){
                    Console.WriteLine($"Infelizmente o inimigo conseguiu sobreviver a vosso ataque.");
                }
                if(segundoPersonagem.avançar == true){
                if(segundoPersonagem.habilidade > primeiroPersonagem.habilidade){
                    Console.WriteLine($"O comandante inimigo foi capaz de deter nosso ataque!");
                }else if(segundoPersonagem.habilidade <= primeiroPersonagem.habilidade){
                    if(segundoPersonagem.organização <= 1){
                    Console.WriteLine($"Comandante {primeiroPersonagem.nome} conseguímos derrotar o inimigo!");
                }else if(segundoPersonagem.organização <= 2){
                    Console.WriteLine($"Comandante {primeiroPersonagem.nome} só nos resta mais uma vitória para expulsarmos o inimigo!");
                    segundoPersonagem.organização = 2 - 1;
                }else if(segundoPersonagem.organização <= 3){
                    Console.WriteLine($"Comandante {primeiroPersonagem.nome} Vitória! o inimigo foi forçado a recuar perante nosso avanço!");
                }
                }
                }
            }
            void AvancarSegundo(){
                segundoPersonagem.avançar = true;
                if(primeiroPersonagem.defesa == true){
                if(primeiroPersonagem.organização <= 1){
                    Console.WriteLine($"Comandante {segundoPersonagem.nome} conseguímos derrotar o inimigo!");
                }else if(primeiroPersonagem.organização <= 2){
                    Console.WriteLine($"Comandante {segundoPersonagem.nome} só nos resta mais uma vitória para expulsarmos o inimigo!");
                    primeiroPersonagem.organização = 2 - 1;
                }else if(primeiroPersonagem.organização <= 3){
                    Console.WriteLine($"Comandante {segundoPersonagem.nome} Vitória! o inimigo foi forçado a recuar perante nosso avanço!");
                }
                }
                if(primeiroPersonagem.envelopar == true){
                    Console.WriteLine($"Infelizmente o inimigo conseguiu sobreviver a vosso ataque.");
                }
                if(primeiroPersonagem.avançar == true){
                if(primeiroPersonagem.habilidade > segundoPersonagem.habilidade){
                    Console.WriteLine($"O comandante inimigo foi capaz de deter nosso ataque!");
                }else if(primeiroPersonagem.habilidade <= segundoPersonagem.habilidade){
                    if(primeiroPersonagem.organização <= 1){
                    Console.WriteLine($"Comandante {segundoPersonagem.nome} conseguímos derrotar o inimigo!");
                }else if(primeiroPersonagem.organização <= 2){
                    Console.WriteLine($"Comandante {segundoPersonagem.nome} só nos resta mais uma vitória para expulsarmos o inimigo!");
                    primeiroPersonagem.organização = 2 - 1;
                }else if(primeiroPersonagem.organização <= 3){
                    Console.WriteLine($"Comandante {segundoPersonagem.nome} Vitória! o inimigo foi forçado a recuar perante nosso avanço!");
                }
                }
                }
            }
            
            

            void Turno(){
            switch (turno)
            {
                case 1:
                break;
            }
            }

            void Primeiro()
            {

                Personagens primeiroPersonagem = new Personagens();
                Console.WriteLine("Insira o nome do 1º comandante");
                primeiroPersonagem.nome = Console.ReadLine();
                Console.WriteLine("Insira a idade de 1º comandante");
                primeiroPersonagem.idade = int.Parse(Console.ReadLine());
                primeiroPersonagem.prestigio = 50;
                primeiroPersonagem.habilidade = (primeiroPersonagem.prestigio * primeiroPersonagem.idade) / 10 - (2 * primeiroPersonagem.idade);
                primeiroPersonagem.exercito = "Exército 1";
                //valores escondidos
                primeiroPersonagem.organização = 3;
                primeiroPersonagem.avançar = false;
                primeiroPersonagem.defesa = false;
                primeiroPersonagem.envelopar = false;
                Console.WriteLine("Gostaria de verificar as informações de seu personagem? s/n?");
                string res = Console.ReadLine();

                if (res == "s")
                {
                    Console.WriteLine($"Nome: {primeiroPersonagem.nome}.");
                    Console.WriteLine($"Idade: {primeiroPersonagem.idade}.");
                    Console.WriteLine($"Prestigio: {primeiroPersonagem.prestigio}.");
                    Console.WriteLine($"Habilidade: {primeiroPersonagem.habilidade}.");
                    Console.WriteLine($"Marque OK para inicializar a configuração do segundo personagem");
                    string ok = Console.ReadLine();
                    if (ok == "OK")
                    {
                        Console.WriteLine("Iniciando a configuração do segundo personagem...");
                        Segundo();
                    }
                }
                else if (res == "n")
                {
                    Console.WriteLine("Iniciando a configuração do segundo personagem...");
                    Segundo();
                }

            }
            //Segundo personagem 
            void Segundo()
            {
                Personagens segundoPersonagem = new Personagens();

                Console.WriteLine("Insira o nome do 2º comandante");
                segundoPersonagem.nome = Console.ReadLine();
                Console.WriteLine("Insira a idade de 2º comandante");
                segundoPersonagem.idade = int.Parse(Console.ReadLine());
                segundoPersonagem.prestigio = 50;
                segundoPersonagem.habilidade = (segundoPersonagem.prestigio * segundoPersonagem.idade) / 10 - (2 * segundoPersonagem.idade);
                segundoPersonagem.exercito = "Exército 2";
                //valores escondidos
                segundoPersonagem.organização = 3;
                segundoPersonagem.avançar = false;
                segundoPersonagem.defesa = false;
                segundoPersonagem.envelopar = false;
                Console.WriteLine("Gostaria de verificar as informações de seu personagem? s/n?");
                string res = Console.ReadLine();

                if (res == "s")
                {
                    Console.WriteLine($"Nome: {segundoPersonagem.nome}.");
                    Console.WriteLine($"Idade: {segundoPersonagem.idade}.");
                    Console.WriteLine($"Prestigio: {segundoPersonagem.prestigio}.");
                    Console.WriteLine($"Habilidade: {segundoPersonagem.habilidade}.");
                    Console.WriteLine($"Marque OK para inicializar a configuração da batalha");
                    string ok = Console.ReadLine();
                    if (ok == "OK")
                    {
                        Console.WriteLine("Iniciando a configuração da batalha...");
                        System.Threading.Thread.Sleep(2000);
                    }

                }
                else if (res == "n")
                {
                    Console.WriteLine("Iniciando a configuração da batalha...");
                    System.Threading.Thread.Sleep(2000);
                }
            }
        }
        }
    }
