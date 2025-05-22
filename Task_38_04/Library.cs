using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Encodings.Web;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using static System.Reflection.Metadata.BlobBuilder;

namespace Task_38_04
{
    class Library
    {
        private List<Student> studentss = new();
        public List<Student> Studentss => studentss;
        private string saveFileName = "students.json";

        public void AddStudent(Student stu)
        {
            if (stu != null)
            {
                studentss.Add(stu);
            }
        }
        public void RemoveStudent(Student stu)
        {
            if (studentss.Contains(stu))
                studentss.Remove(stu);
        }
        public void Save()
        {
            var options = new JsonSerializerOptions
            {
                WriteIndented = true,
                Encoder = JavaScriptEncoder.UnsafeRelaxedJsonEscaping
            };
            var serializationData = JsonSerializer.Serialize(studentss, options);
            File.WriteAllText(saveFileName, serializationData);
        }
        public void Load()
        {
            if (!File.Exists(saveFileName)) 
                return; 

            var data = File.ReadAllText(saveFileName);
            
            if (data != null)
                studentss = JsonSerializer.Deserialize <List<Student>> (data);
            else
                studentss = new List<Student>();
        }
    }
}
