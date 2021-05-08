using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cadrastro_de_Pets
{
    class Program
    {
        static void Main(string[] args)
        {
            Cadastro pet = new Cadastro();

            pet.nome = "Lupi";
            pet.raça = "pint";
            pet.sexo = "macho";
            pet.especie = "cachorro";
            pet.nascimento = "30.05.2018";
            pet.caracterisFisicos = "dog, super pequeno mas, tão brabo como um cão da selva";
            pet.comportamento = "Ligeiramente um bichano para la de atentado, agitado e so para para comer e quando enventualemte cai no sono";


            Console.WriteLine(pet.nome);
            Console.WriteLine(pet.raça);
            Console.WriteLine(pet.sexo);
            Console.WriteLine(pet.especie);
            Console.WriteLine(pet.nascimento);
            Console.WriteLine(pet.caracterisFisicos);
            Console.WriteLine(pet.comportamento);



            Console.ReadLine();
        }
    }
}
