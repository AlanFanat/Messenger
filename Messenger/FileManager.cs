using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Messenger
{
    public static class FileManager
    {
        private static string usersNamesPath = "data/users.txt";
        private static string dialogsDirPath = "data/dialogs";
        public static List<User> GetUsers()
        {
            StreamReader usersReader = new StreamReader(usersNamesPath);
            List<User> users = new List<User>();
            while (!usersReader.EndOfStream)
            {
                string tmp = usersReader.ReadLine();
                if (!string.IsNullOrEmpty(tmp))
                {
                    string[] arrTmp = tmp.Split('*');
                    users.Add(new User(arrTmp[0], new Guid(arrTmp[1])));
                }
            }
            usersReader.Close();
            return users;
        }
        public static void AddUser(User user)
        {
            StreamWriter usersWriter = new StreamWriter("data/users.txt", true);
            usersWriter.WriteLine($"{user.Name}*{user.Id}");
            usersWriter.Close();
        }
        public static void SerializeDialog(Dialog dialog)
        {
            string json = JsonConvert.SerializeObject(dialog, Formatting.Indented);
            string dialogFileName = $"{dialog.FirstUserId} {dialog.SecondUserId}";
            string path = $"{dialogsDirPath}/{dialogFileName}";
            StreamWriter streamWriter = new StreamWriter(path, false);
            streamWriter.Write(json);
            streamWriter.Close();
        }
        public static Dictionary<Guid, Dialog> GetDialogs(Guid Id)
        {
            string stringId = Id.ToString();
            string[] dialogPaths = Directory.GetFiles(dialogsDirPath);
            var needfulPaths = dialogPaths.Select(path => Path.GetFileName(path).Split()).
                Where(bothId => bothId[0] == stringId || bothId[1] == stringId);
            Dictionary<Guid, Dialog> dict = new Dictionary<Guid, Dialog>();
            foreach(var fileName in needfulPaths)
            {
                Guid firstId = new Guid(fileName[0]);
                Guid secondId = new Guid(fileName[1]);
                string path = $"{dialogsDirPath}/{fileName[0]} {fileName[1]}";
                StreamReader streamReader = new StreamReader(path);
                string json = streamReader.ReadToEnd();
                streamReader.Close();
                var messages = JsonConvert.DeserializeObject<Message[]>(json);
                Dialog dialog = new Dialog(firstId, secondId, messages.ToList());
                Guid companionId = (firstId == Id ? secondId : firstId);
                dict.Add(companionId, dialog);
            }
            return dict;
        }
    }
}
