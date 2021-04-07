using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TestApi.Models
{
    public class PokemonDetails
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Descritpion { get; set; }
        public string habitat { get; set; }
        public string isLegendary { get; set; }
    }  
    public class pokemonfulldetails
    {
        public List<PokemonDetails> pokemonDetails { get; set; } = null;
        public pokemonfulldetails()
        {
            pokemonDetails = new List<PokemonDetails>();
            PokemonDetails sd = new PokemonDetails();
            sd.Id = 1;
            sd.Name = "mewtwo";
            sd.Descritpion = "Created by a scientist aftern years of horrific genesplicing and dna engineering experiments,it was.";
            sd.habitat = "rare";
            sd.isLegendary = "True";
            
            pokemonDetails.Add(sd);
        }
    }
}