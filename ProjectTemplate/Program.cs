using System;
using System.Text;
using NLog;

namespace ProjectTemplate
{
    internal static class Program
    {
        private static Logger logger = LogManager.GetCurrentClassLogger();
        public static void Main(string[] args)
        {
            logger.Info("A simple Project Template for my projects.");
            logger.Info($"Global value : {Settings.Name}");
            logger.Info($"Persistant value : {Settings.PSettings.PValue}");
        }
    }
}