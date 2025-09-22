namespace ControlFlowStatements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IfStatementExample();
            IfElseIfExample();
            SwitchStatementExample();
        }
        private static void IfStatementExample()
        {
            int number = 10;

            if (number > 5)
            
                Console.WriteLine("Numero es mayor a 5");
            
            else
            
                Console.WriteLine("Numbero is menor a 5");
            
        }

        private static void IfElseIfExample()
        {
            int number = 10;
            if (number > 10)
            {
                Console.WriteLine("Numero es mayor a 10");
            }
            else if (number == 10)
            {
                Console.WriteLine("Numero es igual a 10");
            }
            else
            {
                Console.WriteLine("Numbero is menor a 10");
            }
        }
        private static void SwitchStatementExample()
        {
            int day = 3;
            switch (day)
            {
                case 1:
                    Console.WriteLine("Lunes");
                    break;
                case 2:
                    Console.WriteLine("Martes");
                    break;
                case 3:
                    Console.WriteLine("Miercoles");
                    break;
                case 4:
                    Console.WriteLine("Jueves");
                    break;
                case 5:
                    Console.WriteLine("Viernes");
                    break;
                case 6:
                    Console.WriteLine("Sabado");
                    break;
                case 7:
                    Console.WriteLine("Domingo");
                    break;
                default:
                    Console.WriteLine("Dia no valido");
                    break;
            }
        }
    }
}
