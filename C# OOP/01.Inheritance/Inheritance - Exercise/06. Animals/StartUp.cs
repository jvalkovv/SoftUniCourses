using System;

namespace Animals
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            string cmd = Console.ReadLine();
            Animal animalType;
            while (cmd != "Beast!")
            {
                try
                {
                    if (cmd == "Cat")
                    {
                        cmd = Console.ReadLine();
                        string[] action = cmd.Split();

                        string name = action[0];
                        int age = int.Parse(action[1]);
                        string gender = action[2];
                        if (name == "Tom")
                        {
                            animalType = new Tomcat(name, age);
                            Console.WriteLine(animalType.ToString());
                        }
                        else if (name == "Kitten")
                        {
                            animalType = new Kitten(name, age);
                            Console.WriteLine(animalType.ToString());
                        }
                        else
                        {
                            animalType = new Cat(name, age, gender);
                        }

                    }
                    if (cmd == "Dog")
                    {
                        cmd = Console.ReadLine();
                        string[] action = cmd.Split();

                        string name = action[0];
                        int age = int.Parse(action[1]);
                        string gender = action[2];

                        animalType = new Dog(name, age, gender);
                        Console.WriteLine(animalType.ToString());
                    }
                    if (cmd == "Frog")
                    {

                        cmd = Console.ReadLine();
                        string[] action = cmd.Split();

                        string name = action[0];
                        int age = int.Parse(action[1]);
                        string gender = action[2];

                        animalType = new Frog(name, age, gender);
                        Console.WriteLine(animalType.ToString());
                    }

                    cmd = Console.ReadLine();

                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
        }
    }
}
