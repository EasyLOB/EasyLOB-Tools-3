using System.IO;
using System.Linq;

// Recursively Copy folder contents to another in C#
// https://www.codeproject.com/Tips/278248/Recursively-Copy-folder-contents-to-another-in-Csh

// How to quickly check if folder is empty (.NET)?
// http://stackoverflow.com/questions/755574/how-to-quickly-check-if-folder-is-empty-net

namespace EasyLOB.Generator
{
    public static class Helper
    {
        public static bool CopyDirectoryContents(string sourceDirectory, string destinationDirectory)
        {
            sourceDirectory = sourceDirectory.EndsWith(@"\") ? sourceDirectory : sourceDirectory + @"\";
            destinationDirectory = destinationDirectory.EndsWith(@"\") ? destinationDirectory : destinationDirectory + @"\";

            try
            {
                if (Directory.Exists(sourceDirectory))
                {
                    if (Directory.Exists(destinationDirectory) == false)
                    {
                        Directory.CreateDirectory(destinationDirectory);
                    }

                    foreach (string files in Directory.GetFiles(sourceDirectory))
                    {
                        FileInfo fileInfo = new FileInfo(files);
                        fileInfo.CopyTo(string.Format(@"{0}\{1}", destinationDirectory, fileInfo.Name), true);
                    }

                    foreach (string drs in Directory.GetDirectories(sourceDirectory))
                    {
                        // .git
                        // .vs
                        // bin
                        // obj
                        // packages
                        if (!drs.EndsWith(".git") && !drs.EndsWith(".vs") &&
                            !drs.EndsWith("obj") && !drs.EndsWith("bin") &&
                            !drs.EndsWith("packages"))
                        {
                            DirectoryInfo directoryInfo = new DirectoryInfo(drs);
                            if (CopyDirectoryContents(drs, destinationDirectory + directoryInfo.Name) == false)
                            {
                                return false;
                            }
                        }
                    }
                }
                return true;
            }
            catch // (Exception exception)
            {
                return false;
            }
        }

        public static bool DeleteDirectoryContents(string directory)
        {
            directory = directory.EndsWith(@"\") ? directory : directory + @"\";

            try
            {
                if (Directory.Exists(directory))
                {
                    foreach (string files in Directory.GetFiles(directory))
                    {
                        FileInfo fileInfo = new FileInfo(files);
                        fileInfo.Delete();
                    }

                    foreach (string drs in Directory.GetDirectories(directory))
                    {
                        if (DeleteDirectoryContents(drs) == false)
                        {
                            return false;
                        }
                        Directory.Delete(drs);
                    }
                }
                return true;
            }
            catch // (Exception exception)
            {
                return false;
            }
        }

        public static bool IsDirectoryEmpty(string path)
        {
            return !Directory.EnumerateFileSystemEntries(path).Any();
        }

        public static bool RenameDirectoryContents(string directory, string from, string to)
        {
            directory = directory.EndsWith(@"\") ? directory : directory + @"\";

            try
            {
                if (Directory.Exists(directory))
                {
                    foreach (string files in Directory.GetFiles(directory))
                    {
                        FileInfo fileInfo = new FileInfo(files);
                        if (fileInfo.FullName.Contains(from))
                        {
                            File.Move(fileInfo.FullName, fileInfo.FullName.Replace(from, to));
                        }
                    }

                    foreach (string drs in Directory.GetDirectories(directory))
                    {
                        // .git
                        // .vs
                        // bin
                        // obj
                        // packages
                        if (!drs.EndsWith(".git") && !drs.EndsWith(".vs") &&
                            !drs.EndsWith("obj") && !drs.EndsWith("bin") &&
                            !drs.EndsWith("packages"))
                        {
                            string drsFromTo = drs;
                            if (drs.Contains(from))
                            {
                                drsFromTo = drs.Replace(from, to);
                                Directory.Move(drs, drsFromTo);
                            }
                            if (RenameDirectoryContents(drsFromTo, from, to) == false)
                            {
                                return false;
                            }
                        }
                    }
                }
                return true;
            }
            catch // (Exception exception)
            {
                return false;
            }
        }

        public static bool ReplaceDirectoryContents(string directory, string from, string to)
        {
            directory = directory.EndsWith(@"\") ? directory : directory + @"\";

            try
            {
                if (Directory.Exists(directory))
                {
                    foreach (string files in Directory.GetFiles(directory))
                    {
                        FileInfo fileInfo = new FileInfo(files);
                        if (".asax|.cs|.cshtml|.csproj|.config|.ini|.json|.resx|.sln".Contains(fileInfo.Extension))
                        {
                            string text = File.ReadAllText(fileInfo.FullName);
                            text = text.Replace(from, to);
                            File.WriteAllText(fileInfo.FullName, text);
                        }
                    }

                    foreach (string drs in Directory.GetDirectories(directory))
                    {
                        // .git
                        // .vs
                        // bin
                        // obj
                        // packages
                        if (!drs.EndsWith(".git") && !drs.EndsWith(".vs") &&
                            !drs.EndsWith("obj") && !drs.EndsWith("bin") &&
                            !drs.EndsWith("packages"))
                        {
                            if (ReplaceDirectoryContents(drs, from, to) == false)
                            {
                                return false;
                            }
                        }
                    }
                }
                return true;
            }
            catch // (Exception exception)
            {
                return false;
            }
        }
    }
}