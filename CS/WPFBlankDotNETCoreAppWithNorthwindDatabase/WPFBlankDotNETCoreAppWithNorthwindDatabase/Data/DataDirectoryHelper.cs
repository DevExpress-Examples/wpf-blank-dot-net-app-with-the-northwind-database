using System.IO;
using System.Reflection;

namespace WPFBlankDotNETCoreAppWithNorthwindDatabase.Data {
    public class DataDirectoryHelper {
        public static string GetDataDirectory() {
            Assembly entryAssembly = Assembly.GetEntryAssembly();
            if (entryAssembly == null) return null;
            string appPath = entryAssembly.Location;
            return Path.GetDirectoryName(appPath);
        }
        public static string GetFile(string fileName, string directoryName) {
            string dirName = Path.GetFullPath(GetDataDirectory());
            return dirName + "\\" + directoryName + "\\" + fileName;
        }
    }
}