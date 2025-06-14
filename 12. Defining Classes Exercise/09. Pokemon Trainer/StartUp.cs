namespace PokemonTrainer
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            List<Trainer> trainers = new();
            
            string command;

            while ((command = Console.ReadLine()) != "Tournament")
            {
                string[] tokens = command.Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string trainerName = tokens[0];
                string pokemonName = tokens[1];
                string pokemonElement = tokens[2];
                int pokemonHealth = int.Parse(tokens[3]);

                Trainer trainer = trainers.SingleOrDefault(t => t.Name == trainerName);

                if (trainer == null)
                {
                    trainer = new Trainer(trainerName);
                    trainer.Pokemons.Add(new (pokemonName, pokemonElement, pokemonHealth));
                    trainers.Add(trainer);
                }

                else
                {
                    trainer.Pokemons.Add(new(pokemonName, pokemonElement, pokemonHealth));
                }

                
            }

            string secondCommand;

            while ((secondCommand = Console.ReadLine()) != "End")
            {
                string element = secondCommand;

                foreach (Trainer trainer in trainers)
                {
                    if (trainer.Pokemons.Any(p => p.Element == element))
                    {
                        trainer.Badges++;
                    }
                    else
                    {
                       for (int p = 0; p < trainer.Pokemons.Count; p++)
                       {
                            Pokemon pokemon = trainer.Pokemons[p];

                            pokemon.Health -= 10;

                            if (pokemon.Health <= 0)
                            {
                                trainer.Pokemons.Remove(pokemon);
                            }
                       }
                    }
                    
                }
            }
            

            foreach (Trainer trainer in trainers.OrderByDescending(t => t.Badges))
            {
                Console.WriteLine($"{trainer.Name} {trainer.Badges} {trainer.Pokemons.Count}");
            }
        }
    }
}