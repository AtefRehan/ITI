namespace Demo2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // nullable value type // c# 2 
            //byte 0->255
            //Nullable<byte> age = 30;//c# 2
            //byte age = 30;
            byte? age = 30;
            age= null;
            byte b1 = 2;

            //b1 =(byte) age;
            //b1 = age.Value;
            /*if (age.HasValue)
            {
               // b1 =(byte) age;
               b1= age.Value;
            }
            else
            {
                b1 = 0;
            }*/
            age = null;
            b1 = age ?? 0;
            //?? null coalescing operator

            Console.WriteLine(b1);

        }
    }
}
