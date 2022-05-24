using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.CommandPattern
{
    public class Menu 
    {
        private List<Command> commands;
        public Menu()
        {
            commands = new List<Command>();
        }
        public void AddCommand(Command c)
        {
            commands.Add(c);
        }

        public void MenuSystem()
        {
            int s = 0;
            while (s!=-1)
            {
                for(int i = 0; i<commands.Count; i++)
                {
                    Console.WriteLine(i + ": " + commands[i]);
                }
                Console.Write("For quit press -1");
                try
                {
                    s = Convert.ToInt32(Console.ReadLine());
                    commands[s].execute();
                }
                catch(Exception ex)
                {
                    Console.WriteLine(ex);
                }

            }
        }
    }
}
