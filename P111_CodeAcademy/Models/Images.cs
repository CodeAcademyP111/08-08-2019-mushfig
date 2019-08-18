using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace P111_CodeAcademy.Models
{
    public static class Images
    {
        private static List<Image> images = new List<Image>()
        {
            new Image{ Id=1, Link="1.jpg"},
            new Image{ Id=2, Link="2.jpg"},
            new Image{ Id=3, Link="3.jpg"},
            new Image{ Id=4, Link="3.jpg"}
        };

        //private static string[] students = new string[] {"Cavad","Helim","Rehim","Kerim ","Tabib "};
        private static string[] students = {
            "Cavad",
            "Helim",
            "Rehim",
            "Kerim",
            "Tabib"
        };

        private static int[] numbers = {1,2,3,4,5,6,7,8,9};

        public static List<Image> GetImages() => images;
        public static string[] GetStudents() => students;
        public static int[] GetNumbers() => numbers;
    }

    public class Image
    {
        public int Id { get; set; }
        public string Link { get; set; }
    }

}
