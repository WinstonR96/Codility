using System;
using System.IO;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text.RegularExpressions;

namespace Codility
{
    class Program
    {
        static void Main(string[] args)
        {
            string S = "my.song.mp3 11b\ngreatSong.flac 1000b\nnot3.txt 5b\nvideo.mp4 200b\ngame.exe 100b\nmov!e.mkv 10000b";
            int[] A = { -1, 1, 3, 3, 3, 2, 3, 2, 1, 0 };
            Console.WriteLine(solution4(A));
            //Console.WriteLine(solution(1041));
            //Console.WriteLine(solution2("011100"));
            //Console.WriteLine(solution2("1111010101111"));
            //Console.WriteLine(solution2("011100"));
            //Console.WriteLine(solution3(S));
            Console.ReadLine();
        }


        //public static int solution(int N)
        //{
        //    // write your code in C# 6.0 with .NET 4.5 (Mono)
        //    var rxGap = new Regex("(?<=1)(0+)(?=1)");
        //    var strGap = Convert.ToString(N, 2);
        //    return
        //     rxGap.Matches(strGap)
        //        .Cast<Match>()
        //        .Select(m => m.Length)
        //        .DefaultIfEmpty(0)
        //        .Max();
        //}

        //public static int solution2(string s)
        //{
        //    var num = Convert.ToInt32(s, 2);
        //    int indice = 0;
        //    do
        //    {
        //        if(num % 2 != 0)
        //        {
        //            num = num - 1;
        //        }
        //        else
        //        {
        //            num = num / 2;
        //        }
        //        indice++;
        //    } while (num != 0);
        //    return indice;
        //}

        //public static string solution3(string S)
        //{
        //    double tamañoMusic = 0;
        //    double tamañoImage = 0;
        //    double tamañoMovies = 0;
        //    double tamañoOther = 0;
        //    string[] musica = { "mp3", "aac", "flac" };
        //    string[] image = { "jpg", "bmp", "gif" };
        //    string[] movie = { "mp4", "avi", "mkv" };
        //    // Hago un arreglo de archivos
        //    string[] files = S.Split("\n");
        //    foreach(var file in files)
        //    {
        //        // posteriormente hago un arreglo para cada archivo que almacena su nombre y su tamaño
        //        string[] dataFile = file.Split(" ");
        //        string fileNombre = dataFile[0];
        //        string extension = Path.GetExtension(fileNombre).Replace(".", "");
        //        Match m = Regex.Match(dataFile[1], "(\\d+)");
        //        double fileTamaño = Convert.ToDouble(m.Value);
        //        if(musica.Any(ext => ext == extension))
        //        {
        //            tamañoMusic += fileTamaño;
        //        }else if (image.Any(ext => ext == extension))
        //        {
        //            tamañoImage += fileTamaño;
        //        }else if (movie.Any(ext => ext == extension))
        //        {
        //            tamañoMovies += fileTamaño;
        //        }
        //        else
        //        {
        //            tamañoOther += fileTamaño;
        //        }
        //    }
        //    return $"music {tamañoMusic}b\nimages {tamañoImage}b\nmovies {tamañoMovies}b\nother {tamañoOther}b";
        //}

        public static int solution4(int[] A)
        {
            int numberOfPeriods = 0;
            int velocity = 0;
            int velocityAux = 0;
            for(int i = 0; i < A.Length; i++)
            {
                if (i == A.Length-1)
                    return numberOfPeriods;

                
                int x = A[i];
                int y = A[i + 1];

                if(x != y)
                {
                    velocity = Math.Abs(x - y);
                    if (velocity == velocityAux)
                    {
                        numberOfPeriods++;
                    }
                    velocityAux = velocity;
                }       
                
            }
            numberOfPeriods = (numberOfPeriods > 1000000000) ? -1 : numberOfPeriods;
            return numberOfPeriods;
        }
    }
}
