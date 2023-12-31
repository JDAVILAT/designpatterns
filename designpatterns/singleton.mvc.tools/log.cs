namespace singleton.mvc.tools
{
    public sealed class log
    {
        private static log? _instance = null;
        private static string _path = string.Empty;
        private static object _protect = new object();

        public static log GetInstance(string path)
        {
            lock (_protect) //Recomendado cuando se trabaje con hilos
            {
                if (_instance == null)
                {
                    _instance = new log(path);
                }
            }
            return _instance;
        }

        private log(string path)
        {
            _path = path;
        }

        public void Save(string message)
        {
            File.AppendAllText(_path, message + Environment.NewLine);
        }
    }
}