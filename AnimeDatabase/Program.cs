using System;
using System.Data;
using JikanDotNet;
using Oracle.ManagedDataAccess;
using Oracle.ManagedDataAccess.Client;
using System.Globalization;
using System.Linq;

//Message Tymmy, admiral2

namespace AnimeDatabase
{

    class Program
    {


        static async System.Threading.Tasks.Task Main(string[] args)
        {
            IJikan jikan = new Jikan();
            int i = 44634;
            // create connection
            OracleConnection con = new OracleConnection();

            // create connection string using builder
            OracleConnectionStringBuilder ocsb = new OracleConnectionStringBuilder();
            ocsb.Password = "1234";
            ocsb.UserID = "c##gunyalal";
            ocsb.DataSource = "localhost:1521/XE";

            // connect
            con.ConnectionString = ocsb.ConnectionString;
            con.Open();
            Console.WriteLine("Connection established (" + con.ServerVersion + ")");
            var cmd = con.CreateCommand();
            cmd.CommandText = "CREATE TABLE AnimeTable(ID INT NOT NULL, Anime_Title varchar(400), Anime_Genre varchar(400), Members varchar(20), Episodes varchar(20), Favourites varchar(20), Score varchar(20), Scored_By varchar(20), Origin varchar(20), Year_Of_Release varchar(20), Status varchar(50), Score_Rank varchar(20), Popularity_Rank varchar(20), Rating varchar(50))";

            cmd.CommandType = CommandType.Text;

            //cmd.ExecuteNonQuery();

            /*while (true)
            {
                try
                {
                    //Anime Anime = await jikan.GetAnime(i);
                    var Anime = await jikan.GetAnimeAsync(i);
                    //System.Console.WriteLine(Anime.Data.Title);
                    string Genre = new string("");
                    try
                    {
                        foreach (var genre in Anime.Data.Genres)
                        {
                            //System.Console.WriteLine(genre);
                            Genre += genre + ", ";
                        }
                        Genre = Genre.Remove(Genre.Length - 2);
                    }
                    catch
                    {
                        Console.WriteLine(i + " GenreError");
                    }

                    // Console.Write(i + " ");
                    //Console.WriteLine(Anime.Data.Title);

                    //System.Threading.Thread.Sleep(100);
                    string Score = new string(Convert.ToString(Anime.Data.Score).Replace(',', '.'));
                    // Console.WriteLine(Convert.tos rank);
                    //Console.WriteLine(Score);
                    cmd.CommandText = "insert into AnimeTable(ID, Anime_Title, Anime_Genre, Members, Episodes, Favourites, Score, Scored_By, Origin, Year_Of_Release, Status, Score_Rank, Popularity_Rank, Rating) values (" + i + ",'" + Anime.Data.Title + "', '" + Genre + "', '" + Anime.Data.Members + "', '" + Convert.ToString(Anime.Data.Episodes) + "', '" + Anime.Data.Favorites + "', '" + Score + "', '" + Anime.Data.ScoredBy + "', '" + Anime.Data.Source + "', '" + Anime.Data.Year + "', '" + Anime.Data.Status + "', '" + Anime.Data.Rank + "', '" + Anime.Data.Popularity + "', '" + Anime.Data.Rating + "' )";

                   // var genre = await jikan.GetAnimeGenresAsync();
                    //cmd.CommandText = "insert into GENRETABLE(ID, GENRE_NAME, MEMBERS) values (" + i + ",'" + "' )";

                    Console.WriteLine(cmd.CommandText);
                    cmd.CommandType = CommandType.Text;
                    cmd.ExecuteNonQuery();


                    i++;
                    System.Threading.Thread.Sleep(2000);
                }
                catch
                {
                    Console.WriteLine(i + " error");
                    i++;
                    System.Threading.Thread.Sleep(2000);
                    continue;
                }
            }*/

            var genre = await jikan.GetAnimeGenresAsync();
            // Convert.ToString(genre);

            //Console.WriteLine(genre.Result);

            //cmd.CommandText = "insert into GENRETABLE(ID, GENRE_NAME, MEMBERS) values (" + i + ",'" + "' )";

            //Console.WriteLine(cmd.CommandText);
            //cmd.CommandType = CommandType.Text;
        }
    }
}
