namespace CSharpPractice
{
    class ObjectInheritance
    {
        public ObjectInheritance()
        {
            //implicit casting
            object obj1 = 1;
            debugFunctions.Print(obj1.GetType().ToString());

            // implicit casting
            object obj2 = "string";
            debugFunctions.Print(obj2.GetType().ToString());

            // more complex
            object obj3 = new Person("Adam Bull");
            if (obj3 is Person)
            {
                Person p = (Person)obj3;
                debugFunctions.Print(p.ToString());
            }
        }
    }
}
