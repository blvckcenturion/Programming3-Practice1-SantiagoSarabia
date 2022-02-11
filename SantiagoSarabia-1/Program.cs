using System;

namespace SantiagoSarabia1
{
    class MainClass
    {
        public static string divider = "---------------------------------------------------";

        public static void Main(string[] args)
        {
            bool isValid = false;
            int option = 3;
            Console.WriteLine("Hola");

            while (!isValid)
            {
                Console.WriteLine("Ingrese la opcion para la ejecucion de dicho ejercicio");
                Console.WriteLine("1. Ejercicio 1");
                Console.WriteLine("2. Ejercicio 2");
                isValid = int.TryParse(Console.ReadLine(), out option);
                if (option > 2 || option < 1) isValid = false;
            }

            if (option == 1) Exercise1();
            else Exercise2();
        }

        static void Exercise1()
        {
            Console.WriteLine("Escribir un programa que permita al usuario ingresar datos a un arreglo de objetos de la clase Persona, la cual tiene dos atributos: Nombre y edad.");
            int arrayLength = 0;
            bool isValid = false;

            while (!isValid)
            {
                Console.WriteLine("Ingresa la cantidad de personas a ingresar");
                isValid = int.TryParse(Console.ReadLine(), out arrayLength);
            }

            Person[] people = new Person[arrayLength];
            for (int i = 0; i < arrayLength; i++)
            {
                int age = 0;
                Console.WriteLine("Ingresa el nombre para la persona #" + (i + 1));
                string name = Console.ReadLine();
                isValid = false;
                while (!isValid)
                {
                    Console.WriteLine("Ingresa la edad para la persona #" + (i + 1));
                    isValid = int.TryParse(Console.ReadLine(), out age);
                }
                people[i] = new Person(age, name);
            }
            people = PeopleNumsBubbleSort(people);
            Console.WriteLine("A. Mostrar el nombre de la persona con menor edad");
            Console.WriteLine(divider);
            Console.WriteLine("Nombre: " + people[0].Name + "| Edad: " + people[0].Age);
            Console.WriteLine(divider);
            people = PeopleAlfabeticBubbleSort(people);
            Console.WriteLine("B. Mostrar en pantalla el arreglo ordenado por nombre.");
            for (int i = 0; i < arrayLength; i++) Console.WriteLine("Nombre: " + people[i].Name + "| Edad: " + people[i].Age);
            Console.WriteLine(divider);
            Console.WriteLine("C. Mostrar por pantalla el arreglo ordenado por edad.");
            people = PeopleNumsBubbleSort(people);
            for (int i = 0; i < arrayLength; i++) Console.WriteLine("Nombre: " + people[i].Name + "| Edad: " + people[i].Age);


        }

        static Person[] PeopleNumsBubbleSort(Person[] people)
        {
            Person temp;
            for (int i = people.Length - 1; i > 0; i--)
            {
                for (int j = 0; j < i; j++)
                {
                    if (people[j].Age > people[j + 1].Age)
                    {
                        temp = people[j + 1];
                        people[j + 1] = people[j];
                        people[j] = temp;
                    }
                }
            }
            return people;
        }

        static Person[] PeopleAlfabeticBubbleSort(Person[] people)
        {
            Person temp;
            for (int i = 0; i < people.Length; i++)
            {
                for (int j = 0; j < people.Length - 1; j++)
                {
                    if (people[j].Name.CompareTo(people[j + 1].Name) > 0)
                    {
                        temp = people[j];
                        people[j] = people[j + 1];
                        people[j + 1] = temp;
                    }
                }
            }
            return people;
        }


        static void Exercise2()
        {
            Console.WriteLine("Escribir un método para el siguiente algoritmo de ordenamiento, luego mostrar su ejecución en un programa que usa un arreglo de 10 enteros.");
            int arrayLength = 0;
            bool isValid = false;

            while (!isValid)
            {
                Console.WriteLine("Ingresa la cantidad de numeros a ingresar");
                isValid = int.TryParse(Console.ReadLine(), out arrayLength);
            }

            int[] numsArray = new int[arrayLength];

            for (int i = 0; i < arrayLength; i++)
            {
                isValid = false;
                while (!isValid)
                {
                    Console.WriteLine("Ingresa el valor para la posicion: " + (i + 1));
                    isValid = int.TryParse(Console.ReadLine(), out numsArray[i]);
                }
            }

            int temp;
            for (int i = 0; i < arrayLength-1; i++)
            {
                Console.WriteLine(numsArray[i]);
                Console.WriteLine("Comparar con");
                for (int j = i + 1; j < arrayLength; j++)
                {
                    Console.WriteLine(numsArray[j]);
                    if (numsArray[i] > numsArray[j])
                    {
                        temp = numsArray[i];
                        numsArray[i] = numsArray[j];
                        numsArray[j] = temp;
                    }
                    

                
                }
                Console.WriteLine("------");
            }

            Console.WriteLine("Resultado:");
            for (int i = 0; i < arrayLength; i++) Console.WriteLine(numsArray[i]);


        }


    }
}
