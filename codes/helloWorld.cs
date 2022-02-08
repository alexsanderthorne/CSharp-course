namespace codes
{
    public class helloWorld
    {
        public void hello()
        {
            int age = 18;
            bool check = false;
            string messageAdtional;

            if(check == true){
                messageAdtional = "come on";
                Console.WriteLine(messageAdtional);
            }else{
                messageAdtional = "get out";
                Console.WriteLine(messageAdtional);
            }

            if(age >= 18 || check == true){
                Console.WriteLine("hey hey");
                Console.WriteLine(messageAdtional);
            }
            

            Console.WriteLine("The execution ends. type enter to finalize . . .");
            Console.ReadLine();
        }
    }

}