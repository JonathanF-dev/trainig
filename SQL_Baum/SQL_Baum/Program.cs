using System;
using MySql.Data.MySqlClient;

namespace SQL_Baum
{
    class Program
    {
        static void Main(string[] args)
        {

            Baum neuer_Baum = new Baum(0, "", 0.0);
            char fortfahren = 'j';
            char suchen = 'j';
            string verbindung = "Server=127.0.0.1;" +
                                "port=3306;" +
                                "database=daten;" +
                                "uid=admin;" +
                                "password=adminPasswort;" +
                                "sslMode=Preferred;";
            MySqlConnection connect = new MySqlConnection(verbindung);

            string create_table_string = "CREATE TABLE baeume(" + "nummer INT" +", " + "Art VARCHAR (30)" + ", " + "hoehe DOUBLE" + ");";
            MySqlCommand create_table = new MySqlCommand(create_table_string);
            create_table.Connection = connect;


            


            string SQL_abfrage = "SELECT * FROM baeume;";
            MySqlCommand abfrage = new MySqlCommand(SQL_abfrage);
            abfrage.Connection = connect;
            
            connect.Open();
            create_table.ExecuteNonQuery();
            connect.Close();

            while (fortfahren == 'j')
            {

                Console.Write("Bitte geben Sie die Nummer des Baums ein: ");
                int nummer = (int.Parse(Console.ReadLine()));
                Console.Write("Bitte geben sie die Art des Baums ein: ");
                string art = (Console.ReadLine());
                Console.Write("Bitte geben Sie die Höhe des Baumes ein: ");
                double hoehe = (double.Parse(Console.ReadLine()));
                
                string insert_baum_string = "INSERT INTO baeume VALUES(" +
                nummer + ", '" +
                art + "', " +
                hoehe + ");";
                MySqlCommand insert_baum = new MySqlCommand(insert_baum_string);
                insert_baum.Connection = connect;

                connect.Open();
                insert_baum.ExecuteNonQuery();
                connect.Close();
                Console.Write("Möchten Sie einen bestimmten Baum suchen?(j/n): ");
                suchen = char.Parse(Console.ReadLine());
                
                while (suchen == 'j')
                {
                    Console.Write("Bitte geben Sie die Nummer des gewünschten Baumes ein: ");
                    int suchnummer = int.Parse(Console.ReadLine());

                    string suchen_string = "SELECT * FROM baeume WHERE nummer = " + suchnummer + ";";
                    MySqlCommand suche = new MySqlCommand(suchen_string);
                    suche.Connection = connect;
                    MySqlDataReader Suchen;
                    connect.Open();
                    Suchen = suche.ExecuteReader();
                    while (Suchen.Read())
                    {
                        string zeile = "";
                        for (int i = 0; i < Suchen.FieldCount; i++)
                        {
                            zeile += Suchen.GetValue(i).ToString() + " ";
                        }
                        Console.WriteLine(zeile);

                    }
                    connect.Close();

                    Console.Write("Möchten Sie eine weiter Suche tätigen?(j/n): ");
                    suchen = char.Parse(Console.ReadLine());
                    
                }
                Console.Write("Möchten Sie einen weiteren Baum hinzufügen?(j/n): ");
                fortfahren = char.Parse(Console.ReadLine());


            }


            MySqlDataReader Reader;
                connect.Open();
                Reader = abfrage.ExecuteReader();
                while (Reader.Read())
                {
                    string zeile = "";
                    for (int i = 0; i < Reader.FieldCount; i++)
                    {
                        zeile += Reader.GetValue(i).ToString() + " ";
                    }
                    Console.WriteLine(zeile);
                }
            connect.Close();


            string drop_string = "DROP TABLE baeume;";
            MySqlCommand drop = new MySqlCommand(drop_string);
            drop.Connection = connect;
            connect.Open();
            drop.ExecuteNonQuery();
            connect.Close();


        }
    }
}
