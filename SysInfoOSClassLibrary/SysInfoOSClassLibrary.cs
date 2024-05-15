using PluginBase;

namespace SysInfoOSClassLibrary
{
    public class SysInfoOSCommand : ICommand
    {
        public string Name { get => "SysInfoOS"; }

        public string Description { get => "Общая информация о системе, имя компьютера, число процессоров, логические диски."; }

        public double Version { get => 1.1; }

        public List<string> Execute()
        {
            List<string> result = new List<string>
            {
                $"Версия Windows: {Environment.OSVersion}",
                $"64 Bit операционная система? : {(Environment.Is64BitOperatingSystem ? "Да" : "Нет")}",
                $"Имя компьютера : {Environment.MachineName}",
                $"Число процессоров : {Environment.ProcessorCount}",
                $"Системная папка : {Environment.SystemDirectory}",
                $"Логические диски : {string.Join(", ", Environment.GetLogicalDrives()).TrimEnd(',', ' ').Replace("\\", string.Empty)}"
            };

            return result;
        }
    }
}