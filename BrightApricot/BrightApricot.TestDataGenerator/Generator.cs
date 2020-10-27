using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using BrightApricot.Shared.Enums;
using BrightApricot.Shared.Models;
using System.Text.Json;

namespace BrightApricot.TestDataGenerator
{
    internal class Generator
    {
        private readonly string _fileName;
        private IList<Recipe> _recipes = new List<Recipe>();

        public Generator(string fileName)
        {
            _fileName = fileName;
        }

        public void Run()
        {
            //want to create another
            while (true)
            {
                Console.WriteLine("do you want to create a recipe?[Y/n]");
                string input;
                if ((input = Console.ReadLine())?.ToLower() == "y" || string.IsNullOrWhiteSpace(input))
                {
                    _recipes.Add(CreateRecipe());
                }
                else
                {
                    //save
                    SaveJson();
                    break;
                }
            }
            //query data
            //create instance
            //save local

            //when no
            //save to file

            Console.WriteLine("bye bye :)");
        }

        private void SaveJson()
        {
            var json = JsonSerializer.Serialize(_recipes);
            var bytes = Encoding.UTF8.GetBytes(json);

            using var fs = new FileStream(_fileName, FileMode.Create);
            fs.Write(bytes);
        }

        private Recipe CreateRecipe()
        {
            Console.WriteLine("Name?");
            var name = Console.ReadLine();

            Console.WriteLine("Description?");
            var description = Console.ReadLine();

            var Ingredients = new List<Ingredient>();
            do
            {
                Console.WriteLine("Ingredient Name: \n" +
                                  "Amount: \n" +
                                  "Unit: [L]iter, [K]ilogram");
                var ingredient = new Ingredient
                {
                    IngredientName = Console.ReadLine(),
                    amount = float.Parse(Console.ReadLine()),
                    Unit = Console.ReadLine()?.ToLower() switch
                    {
                        "K" => SIUnits.Kilogram,
                        "L" => SIUnits.Liter,
                        _ => SIUnits.Kilogram
                    } 
                };
                Ingredients.Add(ingredient);

                Console.WriteLine("New ingredient?[y/N]");
            } while (!string.IsNullOrWhiteSpace(Console.ReadLine()));


            var instructions = new List<Instruction>();
            do
            {
                Console.WriteLine("Short Description \n " +
                                  "Long Description");
                var instruction = new Instruction
                {
                    ShortDescription = Console.ReadLine(),
                    CompleteDescription = Console.ReadLine()
                };
                instructions.Add(instruction);
                Console.WriteLine("New instruction?[y/N]");

            } while (!string.IsNullOrWhiteSpace(Console.ReadLine()));

            return new Recipe
                {Base64Image = Image.Base64Image, 
                    Description = description,
                    ImageFileType = Image.ImageFileType,
                    Ingredients = Ingredients,
                    Instructions = instructions,
                    Title = name
                };
        }
    }
}
