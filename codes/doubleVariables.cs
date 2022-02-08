namespace codes{

    class doubleVariables{
        public void  doubleAges(){
            double age;
            age = 12.9;
            Console.WriteLine("You have" + age + "Years Old");
            age = 15 / 2;
            Console.WriteLine("You have" + age + "Years Old");
            age = 15.0 / 2;
            Console.WriteLine("You have" + age + "Years Old");

            Console.WriteLine("Type enter to stop . . .");
            Console.ReadLine();
        }
    }
}