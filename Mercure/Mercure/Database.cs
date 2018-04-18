using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mercure
{
    class Database
    {
        /// <summary>
        /// Unique instance of the database.
        /// </summary>
        public static Database database;

        /// <summary>
        ///  SQLite connection.
        /// </summary>
        private System.Data.SQLite.SQLiteConnection SQL_Connection;

        /// <summary>
        /// Constructor.
        /// </summary>
        private Database()
        {
            SQL_Connection = new System.Data.SQLite.SQLiteConnection("Data Source=res/Mercure.SQLite;");
            SQL_Connection.Open();
        }

        /// <summary>
        /// Returns an instance of the database.
        /// </summary>
        /// <returns>An instance of the database</returns>
        public static Database GetInstance()
        {
            if (database == null)
                database = new Database();

            return database;
        }

        /// <summary>
        /// Clears the database.
        /// </summary>
        public void Clear_Database()
        {
            System.Data.SQLite.SQLiteCommand cmd = SQL_Connection.CreateCommand();
            cmd.CommandText = "DELETE FROM Articles";
            cmd.ExecuteNonQuery();

            cmd = SQL_Connection.CreateCommand();
            cmd.CommandText = "DELETE FROM SousFamilles";
            cmd.ExecuteNonQuery();

            cmd = SQL_Connection.CreateCommand();
            cmd.CommandText = "DELETE FROM Familles";
            cmd.ExecuteNonQuery();

            cmd = SQL_Connection.CreateCommand();
            cmd.CommandText = "DELETE FROM Marques";
            cmd.ExecuteNonQuery();
        }

        /// <summary>
        /// Returns a new valid ID value for the table.
        /// </summary>
        /// <param name="Table_Name">The name of the table to get the max ID from</param>
        /// <returns>A new valid ID for the table</returns>
        public int Get_New_Id(string Table_Name) 
        {
            string ID_Name = Table_Name.Substring(0, Table_Name.Length - 1);

            System.Data.SQLite.SQLiteCommand cmd = SQL_Connection.CreateCommand();
            cmd.CommandText = "SELECT max(Ref" + ID_Name + ") FROM " + Table_Name;

            object Id = cmd.ExecuteScalar();
            if (Id != null && Id.ToString() != "")
                return int.Parse(Id.ToString()) + 1;
            else
                return 0;
        }

        /** Queries. */
        /*private System.Data.SQLite.SQLiteDataReader Get_Query(string Table_Name, string ID)
        {

        }

        private string Create_Query(string Table_Name, string[] Columns_Set, string[] Values)
        {

        }

        private void Update_Query(string Table_Name, string ID, string[] Columns_Set, string[] Values)
        {

        }

        private void Delete_Query(string Table_Name, string ID)
        {

        }*/

        /** Getters. */
        public int Get_Familly_ID(string Familly_Name)
        {
            // TODO : check for typos
            System.Data.SQLite.SQLiteCommand cmd = SQL_Connection.CreateCommand();
            cmd.CommandText = "SELECT RefFamille FROM Familles WHERE Nom = ?";

            System.Data.SQLite.SQLiteParameter Familly_Name_Parameter = new System.Data.SQLite.SQLiteParameter();
            Familly_Name_Parameter.Value = Familly_Name;
            cmd.Parameters.Add(Familly_Name_Parameter);

            object Id = cmd.ExecuteScalar();
            if (Id != null && Id.ToString() != "")
                return int.Parse(Id.ToString());
            else
                return -1;
        }

        public int Get_Sub_Familly_ID(string Sub_Familly_Name)
        {
            // TODO : check for typos
            System.Data.SQLite.SQLiteCommand cmd = SQL_Connection.CreateCommand();
            cmd.CommandText = "SELECT RefSousFamille FROM SousFamilles WHERE Nom = ?";

            System.Data.SQLite.SQLiteParameter Name_Parameter = new System.Data.SQLite.SQLiteParameter();
            Name_Parameter.Value = Sub_Familly_Name;
            cmd.Parameters.Add(Name_Parameter);

            object Id = cmd.ExecuteScalar();
            if (Id != null && Id.ToString() != "")
                return int.Parse(Id.ToString());
            else
                return -1;
        }

        public int Get_Brand_ID(string Brand_Name)
        {
            // TODO : check for typos
            System.Data.SQLite.SQLiteCommand cmd = SQL_Connection.CreateCommand();
            cmd.CommandText = "SELECT RefMarque FROM Marques WHERE Nom = ?";

            System.Data.SQLite.SQLiteParameter Name_Parameter = new System.Data.SQLite.SQLiteParameter();
            Name_Parameter.Value = Brand_Name;
            cmd.Parameters.Add(Name_Parameter);

            object Id = cmd.ExecuteScalar();
            if (Id != null && Id.ToString() != "")
                return int.Parse(Id.ToString());
            else
                return -1;
        }

        /** Creations. */
        public int Get_Or_Create_Familly(string Familly_Name)
        {
            int Id = Get_Familly_ID(Familly_Name);

            if (Id != -1)
                return Id;

            Id = Get_New_Id("Familles");
            
            System.Data.SQLite.SQLiteCommand cmd = SQL_Connection.CreateCommand();
            cmd.CommandText = "INSERT INTO Familles (RefFamille, Nom) VALUES (?, ?)";

            System.Data.SQLite.SQLiteParameter Id_Parameter = new System.Data.SQLite.SQLiteParameter();
            System.Data.SQLite.SQLiteParameter Name_Parameter = new System.Data.SQLite.SQLiteParameter();

            Id_Parameter.Value = Id;
            Name_Parameter.Value = Familly_Name;

            cmd.Parameters.Add(Id_Parameter);
            cmd.Parameters.Add(Name_Parameter);

            int Nb = cmd.ExecuteNonQuery();

            if (Nb != 1)
                return -1;
            else
                return Id;
        }

        public int Get_Or_Create_Sub_Familly(int Familly_ID, string Sub_Familly_Name)
        {
            // Check we have a valid familly ID.
            if (Familly_ID == -1)
                return -1;

            // Check if the ID is already in use.
            int Id = Get_Sub_Familly_ID(Sub_Familly_Name);

            if (Id != -1)
                return Id;

            // Create the subfamilly.
            Id = Get_New_Id("SousFamilles");

            System.Data.SQLite.SQLiteCommand cmd = SQL_Connection.CreateCommand();
            cmd.CommandText = "INSERT INTO SousFamilles (RefSousFamille, RefFamille, Nom) VALUES (?, ?, ?)";

            System.Data.SQLite.SQLiteParameter Id_Parameter = new System.Data.SQLite.SQLiteParameter();
            System.Data.SQLite.SQLiteParameter Family_Id_Parameter = new System.Data.SQLite.SQLiteParameter();
            System.Data.SQLite.SQLiteParameter Name_Parameter = new System.Data.SQLite.SQLiteParameter();
            
            Id_Parameter.Value = Id;
            Family_Id_Parameter.Value = Familly_ID;
            Name_Parameter.Value = Sub_Familly_Name;

            cmd.Parameters.Add(Id_Parameter);
            cmd.Parameters.Add(Family_Id_Parameter);
            cmd.Parameters.Add(Name_Parameter);

            int Nb = cmd.ExecuteNonQuery();

            if (Nb != 1)
                return -1;
            else
                return Id;
        }

        public int Get_Or_Create_Brand(string Brand_Name)
        {
            // Check if the brand name is already in use.
            int Id = Get_Brand_ID(Brand_Name);

            if (Id != -1)
                return Id;

            // Create the brand.
            Id = Get_New_Id("Marques");

            System.Data.SQLite.SQLiteCommand cmd = SQL_Connection.CreateCommand();
            cmd.CommandText = "INSERT INTO Marques (RefMarque, Nom) VALUES (?, ?)";

            System.Data.SQLite.SQLiteParameter Id_Parameter = new System.Data.SQLite.SQLiteParameter();
            System.Data.SQLite.SQLiteParameter Name_Parameter = new System.Data.SQLite.SQLiteParameter();

            Id_Parameter.Value = Id;
            Name_Parameter.Value = Brand_Name;

            cmd.Parameters.Add(Id_Parameter);
            cmd.Parameters.Add(Name_Parameter);

            int Nb = cmd.ExecuteNonQuery();

            if (Nb != 1)
                return -1;
            else
                return Id;
        }

        public int Count_Articles_Id(string Article_Id)
        {
            // TODO : check for typos
            System.Data.SQLite.SQLiteCommand cmd = SQL_Connection.CreateCommand();
            cmd.CommandText = "SELECT Quantite FROM Articles WHERE RefArticle = ?";

            System.Data.SQLite.SQLiteParameter Article_Id_Parameter = new System.Data.SQLite.SQLiteParameter();
            Article_Id_Parameter.Value = Article_Id;
            cmd.Parameters.Add(Article_Id_Parameter);

            object Id = cmd.ExecuteScalar();
            if (Id != null && Id.ToString() != "")
                return int.Parse(Id.ToString());
            else
                return -1;
        }

        public bool Create_Article(string Article_ID, int Sub_Familly_ID, int Brand_ID, string Description, float Prix)
        {
            // Check values.
            if (Sub_Familly_ID == -1 || Brand_ID == -1)
                return false;

            int Quantite = Count_Articles_Id(Article_ID);
            
            //If the article already exists just update the quantity
            if (Quantite != -1)
            {
                System.Data.SQLite.SQLiteCommand cmd = SQL_Connection.CreateCommand();
                cmd.CommandText = "UPDATE Articles SET (Quantite = ?) WHERE RefArticle = ?";

                System.Data.SQLite.SQLiteParameter Id_Parameter = new System.Data.SQLite.SQLiteParameter();
                System.Data.SQLite.SQLiteParameter Quantity_Parameter = new System.Data.SQLite.SQLiteParameter();

                Id_Parameter.Value = Article_ID;
                Quantity_Parameter.Value = Quantite + 1;

                int Rows = cmd.ExecuteNonQuery();
                return Rows == 1;
            }
            else
            {

                System.Data.SQLite.SQLiteCommand cmd = SQL_Connection.CreateCommand();
                cmd.CommandText = "INSERT INTO Articles (RefArticle, Description, RefSousFamille, RefMarque, PrixHT, Quantite) VALUES (?, ?, ?, ?, ?, ?)";

                System.Data.SQLite.SQLiteParameter Id_Parameter = new System.Data.SQLite.SQLiteParameter();
                System.Data.SQLite.SQLiteParameter Description_Parameter = new System.Data.SQLite.SQLiteParameter();
                System.Data.SQLite.SQLiteParameter Sub_Fammilly_Id_Parameter = new System.Data.SQLite.SQLiteParameter();
                System.Data.SQLite.SQLiteParameter Brand_Id_Parameter = new System.Data.SQLite.SQLiteParameter();
                System.Data.SQLite.SQLiteParameter Price_Parameter = new System.Data.SQLite.SQLiteParameter();
                System.Data.SQLite.SQLiteParameter Quantity_Parameter = new System.Data.SQLite.SQLiteParameter();

                Id_Parameter.Value = Article_ID;
                Description_Parameter.Value = Description;
                Sub_Fammilly_Id_Parameter.Value = Sub_Familly_ID;
                Brand_Id_Parameter.Value = Brand_ID;
                Price_Parameter.Value = Prix;
                Quantity_Parameter.Value = 1;

                cmd.Parameters.Add(Id_Parameter);
                cmd.Parameters.Add(Description_Parameter);
                cmd.Parameters.Add(Sub_Fammilly_Id_Parameter);
                cmd.Parameters.Add(Brand_Id_Parameter);
                cmd.Parameters.Add(Price_Parameter);
                cmd.Parameters.Add(Quantity_Parameter);

                int Nb = cmd.ExecuteNonQuery();

                return Nb == 1;
            }
        }

        public List<Models.Article> getArticles()
        {
            List<Models.Article> Articles = new List<Models.Article>();
            System.Data.SQLite.SQLiteCommand cmd = SQL_Connection.CreateCommand();
            cmd.CommandText = "SELECT RefArticle, Description, SousFamilles.Nom as SousFamille, m.Nom as Marque, PrixHT, Quantite FROM Articles natural join SousFamilles inner join Marques m on m.RefMarque = Articles.refMarque";

            System.Data.SQLite.SQLiteDataReader Articles_Reader = cmd.ExecuteReader();
            
            int Article_Index = Articles_Reader.GetOrdinal("RefArticle");
            int Description_Index = Articles_Reader.GetOrdinal("Description");
            int Sub_Familly_Index = Articles_Reader.GetOrdinal("SousFamille");
            int Brand_Index = Articles_Reader.GetOrdinal("Marque");
            int Price_Index = Articles_Reader.GetOrdinal("PrixHT");
            int Quantity_Index = Articles_Reader.GetOrdinal("Quantite");
           
            while (Articles_Reader.Read())
            {
                Models.Article A = new Models.Article();

                
                A.Ref_Article = Articles_Reader.GetString(Article_Index);  
                A.Description = Articles_Reader.GetString(Description_Index);               
                A.Sub_Familly_Name = Articles_Reader.GetString(Sub_Familly_Index);
                A.Brand_Name = Articles_Reader.GetString(Brand_Index);               
                A.Price_HT = Articles_Reader.GetFloat(Price_Index);              
                A.Quantity = Articles_Reader.GetInt32(Quantity_Index);

                Articles.Add(A);
            }

            return Articles;
        }

        public Models.Article getArticle(string refArticle)
        {
            Models.Article Article = new Models.Article();
            System.Data.SQLite.SQLiteCommand cmd = SQL_Connection.CreateCommand();
            cmd.CommandText = "SELECT RefArticle, Description, SousFamilles.Nom as SousFamille, m.Nom as Marque, PrixHT, Quantite FROM Articles natural join SousFamilles inner join Marques m on m.RefMarque = Articles.refMarque WHERE RefArticle = ?";

            System.Data.SQLite.SQLiteParameter Id_Parameter = new System.Data.SQLite.SQLiteParameter();
            Id_Parameter.Value = refArticle;
            cmd.Parameters.Add(Id_Parameter);

            System.Data.SQLite.SQLiteDataReader Articles_Reader = cmd.ExecuteReader();

            int Article_Index = Articles_Reader.GetOrdinal("RefArticle");
            int Description_Index = Articles_Reader.GetOrdinal("Description");
            int Sub_Familly_Index = Articles_Reader.GetOrdinal("SousFamille");
            int Brand_Index = Articles_Reader.GetOrdinal("Marque");
            int Price_Index = Articles_Reader.GetOrdinal("PrixHT");
            int Quantity_Index = Articles_Reader.GetOrdinal("Quantite");

            if(Articles_Reader.Read())
            {
                Models.Article A = new Models.Article();


                Article.Ref_Article = Articles_Reader.GetString(Article_Index);
                Article.Description = Articles_Reader.GetString(Description_Index);
                Article.Sub_Familly_Name = Articles_Reader.GetString(Sub_Familly_Index);
                Article.Brand_Name = Articles_Reader.GetString(Brand_Index);
                Article.Price_HT = Articles_Reader.GetFloat(Price_Index);
                Article.Quantity = Articles_Reader.GetInt32(Quantity_Index);

            }

            return Article;
        }

        /** Udpates. */
        public bool Update_Familly(int Familly_ID, string Familly_Name)
        {
            System.Data.SQLite.SQLiteCommand cmd = SQL_Connection.CreateCommand();
            cmd = SQL_Connection.CreateCommand();
            cmd.CommandText = "UPDATE Familles SET Nom = ? WHERE RefFamille = ?";

            System.Data.SQLite.SQLiteParameter Name_Parameter = new System.Data.SQLite.SQLiteParameter();
            System.Data.SQLite.SQLiteParameter Id_Parameter = new System.Data.SQLite.SQLiteParameter();

            Name_Parameter.Value = Familly_Name;
            Id_Parameter.Value = Familly_ID;

            cmd.Parameters.Add(Name_Parameter);
            cmd.Parameters.Add(Id_Parameter);

            int Nb = cmd.ExecuteNonQuery();

            return Nb == 1;
        }

        public bool Update_Sub_Familly(int Sub_Familly_ID, int Familly_ID, string Sub_Familly_Name)
        {
            return false;
        }

        public bool Update_Brand(int Brand_ID, string Brand_Name)
        {
            System.Data.SQLite.SQLiteCommand cmd = SQL_Connection.CreateCommand();
            cmd = SQL_Connection.CreateCommand();
            cmd.CommandText = "UPDATE Marque SET Nom = ? WHERE RefMarque = ?";

            System.Data.SQLite.SQLiteParameter Name_Parameter = new System.Data.SQLite.SQLiteParameter();
            System.Data.SQLite.SQLiteParameter Id_Parameter = new System.Data.SQLite.SQLiteParameter();

            Name_Parameter.Value = Brand_Name;
            Id_Parameter.Value = Brand_ID;

            cmd.Parameters.Add(Name_Parameter);
            cmd.Parameters.Add(Id_Parameter);

            int Nb = cmd.ExecuteNonQuery();

            return Nb == 1;
        }

        public bool Update_Article(string Description, string Reference, int Marque, int Famille, int SousFamille, float PrixHT)
        {
            int Quantite = Count_Articles_Id(Reference);

            if (Quantite == -1) return false;

            System.Data.SQLite.SQLiteCommand cmd = SQL_Connection.CreateCommand();
            cmd = SQL_Connection.CreateCommand();
            cmd.CommandText = "UPDATE Articles SET Description = ?, RefSousFamille = ?, RefMarque = ?, PrixHT = ?, Quantite = ? WHERE RefArticle = ?";

            
            System.Data.SQLite.SQLiteParameter Description_Parameter = new System.Data.SQLite.SQLiteParameter();
            System.Data.SQLite.SQLiteParameter Sub_Fammilly_Id_Parameter = new System.Data.SQLite.SQLiteParameter();
            System.Data.SQLite.SQLiteParameter Brand_Id_Parameter = new System.Data.SQLite.SQLiteParameter();
            System.Data.SQLite.SQLiteParameter Price_Parameter = new System.Data.SQLite.SQLiteParameter();
            System.Data.SQLite.SQLiteParameter Quantity_Parameter = new System.Data.SQLite.SQLiteParameter();
            System.Data.SQLite.SQLiteParameter Id_Parameter = new System.Data.SQLite.SQLiteParameter();
            
           
            Description_Parameter.Value = Description;
            Sub_Fammilly_Id_Parameter.Value = SousFamille;
            Brand_Id_Parameter.Value = Marque;
            Price_Parameter.Value = PrixHT;
            Quantity_Parameter.Value = Quantite;
            Id_Parameter.Value = Reference;

            
            cmd.Parameters.Add(Description_Parameter);
            cmd.Parameters.Add(Sub_Fammilly_Id_Parameter);
            cmd.Parameters.Add(Brand_Id_Parameter);
            cmd.Parameters.Add(Price_Parameter);
            cmd.Parameters.Add(Quantity_Parameter);
            cmd.Parameters.Add(Id_Parameter);

            int Nb = cmd.ExecuteNonQuery();

            return Nb == 1;
        }


        /** Removals. */
        public bool Delete_Familly(int Familly_ID)
        {
            System.Data.SQLite.SQLiteCommand cmd = SQL_Connection.CreateCommand();
            cmd = SQL_Connection.CreateCommand();
            cmd.CommandText = "DELETE FROM Familles WHERE RefFamille = ?";

            System.Data.SQLite.SQLiteParameter Id_Parameter = new System.Data.SQLite.SQLiteParameter();

            Id_Parameter.Value = Familly_ID;

            cmd.Parameters.Add(Id_Parameter);

            int Nb = cmd.ExecuteNonQuery();

            return Nb == 1;
        }

        public bool Delete_Sub_Familly(int Sub_Familly_ID)
        {
            System.Data.SQLite.SQLiteCommand cmd = SQL_Connection.CreateCommand();
            cmd = SQL_Connection.CreateCommand();
            cmd.CommandText = "DELETE FROM SousFamilles WHERE RefSousFamille = ?";
            System.Data.SQLite.SQLiteParameter Id_Parameter = new System.Data.SQLite.SQLiteParameter();

            Id_Parameter.Value = Sub_Familly_ID;

            cmd.Parameters.Add(Id_Parameter);

            int Nb = cmd.ExecuteNonQuery();

            return Nb == 1;
        }

        public bool Delete_Brand(int Brand_ID)
        {
            System.Data.SQLite.SQLiteCommand cmd = SQL_Connection.CreateCommand();
            cmd = SQL_Connection.CreateCommand();
            cmd.CommandText = "DELETE FROM Marques WHERE RefMarque = ?";
            System.Data.SQLite.SQLiteParameter Id_Parameter = new System.Data.SQLite.SQLiteParameter();

            Id_Parameter.Value = Brand_ID;

            cmd.Parameters.Add(Id_Parameter);

            int Nb = cmd.ExecuteNonQuery();

            return Nb == 1;
        }

        public bool Delete_Article(string Article_ID)
        {
            System.Data.SQLite.SQLiteCommand cmd = SQL_Connection.CreateCommand();
            cmd.CommandText = "DELETE FROM Articles WHERE RefArticle = ?";
            System.Data.SQLite.SQLiteParameter Id_Parameter = new System.Data.SQLite.SQLiteParameter();

            Id_Parameter.Value = Article_ID;

            cmd.Parameters.Add(Id_Parameter);

            int Nb = cmd.ExecuteNonQuery();

            return Nb == 1;
        }
    }
}
