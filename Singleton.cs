namespace SingletonExample
{
    public class Singleton
    {
        private static readonly Singleton _instance = new Singleton();
        private List<string> servers = new List<string>();
        private int nextServer = 0;

        private Singleton()
        {
            servers.Add("Henk");
            servers.Add("Kees");
            servers.Add("Ingrid");
            servers.Add("Maria");
        }

        public static Singleton GetSingleton()
        {
            return _instance;
        }

        public string GetNextServer()
        {
            string output = servers[nextServer];

            nextServer += 1;

            int maxservers = servers.Count;
            if (nextServer == maxservers)
            {
                nextServer = 0;
            }

            return output;
        }
    }
}