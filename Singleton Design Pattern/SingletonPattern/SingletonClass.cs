namespace SingletonPattern
{
    public class SingletonClass
    {
        private static int counter = 0;
        private static bool instance_flag = false;

        // Private Constructor to block direct object creation
        private SingletonClass() {}

        public static SingletonClass GetInstance()
        {
            if(instance_flag) return null;
            else
            {
                instance_flag = true;
                return new SingletonClass();
            }
        }

        public string GetMessage()
        {
            counter++;
            var msg = $"Call no {counter} from Singleton Class\n";
            return msg;
        }

        // Class Destructor to reset instance_flag
        ~SingletonClass()
        {
            instance_flag = false;
        }
    }
}