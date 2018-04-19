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

        /// <summary>
        /// Returns the family id from the family name
        /// </summary>
        /// <param name="Familly_Name"></param>
        /// <returns>the family id</returns>
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

        /// <summary>
        /// Returns the sub-family id from the sub-familly name
        /// </summary>
        /// <param name="Sub_Familly_Name"></param>
        /// <returns>the sub-familly id</returns>
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

        /// <summary>
        /// Returns the brand id from the brand name
        /// </summary>
        /// <param name="Brand_Name"></param>
        /// <returns>the brand id</returns>
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

        /// <summary>
        /// Returns the id from the family name or create a new family if none found.
        /// </summary>
        /// <param name="Familly_Name"></param>
        /// <returns>the family id</returns>
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

        /// <summary>
        /// Returns the id from the sub-family name and family id or create a new sub-family if none found.
        /// </summary>
        /// <param name="Familly_ID"></param>
        /// <param name="Sub_Familly_Name"></param>
        /// <returns>the sub-family id</returns>
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

        /// <summary>
        /// Returns the id from the brand name or create a new brand if none found.
        /// </summary>
        /// <param name="Brand_Name"></param>
        /// <returns>the brand id</returns>
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

        /// <summary>
        /// Returns the quantity from the article with the given id
        /// </summary>
        /// <param name="Article_Id"></param>
        /// <returns>the quantity of the article</returns>
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

        /// <summary>
        /// Creates an article
        /// </summary>
        /// <param name="Article_ID"></param>
        /// <param name="Sub_Familly_ID"></param>
        /// <param name="Brand_ID"></param>
        /// <param name="Description"></param>
        /// <param name="Prix"></param>
        /// <returns>the id</returns>
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

        /// <summary>
        /// Creates an article
        /// </summary>
        /// <param name="Article_ID"></param>
        /// <param name="Sub_Familly_ID"></param>
        /// <param name="Brand_ID"></param>
        /// <param name="Description"></param>
        /// <param name="Prix"></param>
        /// <param name="Quantity"></param>
        /// <returns>the id</returns>
        public bool Create_Article(string Article_ID, int Sub_Familly_ID, int Brand_ID, string Description, float Prix, int Quantity)
        {
            // Check values.
            if (Sub_Familly_ID == -1 || Brand_ID == -1)
                return false;
            int Number = Count_Articles_Id(Article_ID);
            if (Number != -1) return false;

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
            Quantity_Parameter.Value = Quantity;

            cmd.Parameters.Add(Id_Parameter);
            cmd.Parameters.Add(Description_Parameter);
            cmd.Parameters.Add(Sub_Fammilly_Id_Parameter);
            cmd.Parameters.Add(Brand_Id_Parameter);
            cmd.Parameters.Add(Price_Parameter);
            cmd.Parameters.Add(Quantity_Parameter);

            int Nb = cmd.ExecuteNonQuery();

            return Nb == 1;
        }

        /// <summary>
        /// Returns the list of all the brands
        /// </summary>
        /// <returns>list of all the brands</returns>
        public List<Models.Brand> Get_Brands()
        {
            List<Models.Brand> Brands = new List<Models.Brand>();
            System.Data.SQLite.SQLiteCommand cmd = SQL_Connection.CreateCommand();
            cmd.CommandText = "SELECT * FROM Marques";

            System.Data.SQLite.SQLiteDataReader Brands_Reader = cmd.ExecuteReader();

            while (Brands_Reader.Read())
            {
                Models.Brand b = new Models.Brand();
                b.Id = Brands_Reader.GetInt32(0);
                b.Name = Brands_Reader.GetString(1);
                Brands.Add(b);
            }

            return Brands;
        }

        /// <summary>
        /// Returns the list of all the families
        /// </summary>
        /// <returns>list of all the families</returns>
        public List<Models.Family> Get_Families()
        {
            List<Models.Family> Famillies = new List<Models.Family>();
            System.Data.SQLite.SQLiteCommand cmd = SQL_Connection.CreateCommand();
            cmd.CommandText = "SELECT * FROM Familles";

            System.Data.SQLite.SQLiteDataReader Famillies_Reader = cmd.ExecuteReader();

            while (Famillies_Reader.Read())
            {
                Models.Family f = new Models.Family();
                f.Id = Famillies_Reader.GetInt32(0);
                f.Name = Famillies_Reader.GetString(1);
                Famillies.Add(f);
            }

            return Famillies;
        }

        /// <summary>
        /// Returns the list of all the sub-families
        /// </summary>
        /// <returns>list of all the sub-families</returns>
        public List<Models.SubFamily> Get_Sub_Families()
        {
            List<Models.SubFamily> SubFamillies = new List<Models.SubFamily>();
            System.Data.SQLite.SQLiteCommand cmd = SQL_Connection.CreateCommand();
            cmd.CommandText = "SELECT * FROM SousFamilles";

            System.Data.SQLite.SQLiteDataReader SubFamillies_Reader = cmd.ExecuteReader();

            while (SubFamillies_Reader.Read())
            {
                Models.SubFamily sf = new Models.SubFamily();
                sf.Id = SubFamillies_Reader.GetInt32(0);
                sf.Family_Id = SubFamillies_Reader.GetInt32(1);
                sf.Name = SubFamillies_Reader.GetString(2);
                SubFamillies.Add(sf);
            }

            return SubFamillies;
        }

        /// <summary>
        /// Returns the list of all the articles
        /// </summary>
        /// <returns>list of all the articles</returns>
        public List<Models.Article> Get_Articles_List()
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

        /// <summary>
        /// Returns the article from its reference
        /// </summary>
        /// <param name="refArticle"></param>
        /// <returns>the article</returns>
        public Models.Article Get_Article(string refArticle)
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

        /// <summary>
        /// Returns a sub-family from its name
        /// </summary>
        /// <param name="SubFamilly"></param>
        /// <returns>the sub-family</returns>
        public Models.SubFamily Get_Sub_Family(string SubFamilly)
        {
            Models.SubFamily SubFamily = new Models.SubFamily();

            System.Data.SQLite.SQLiteCommand cmd = SQL_Connection.CreateCommand();
            cmd.CommandText = "SELECT * FROM SousFamilles WHERE Nom = ?";

            System.Data.SQLite.SQLiteParameter Name_Parameter = new System.Data.SQLite.SQLiteParameter();
            Name_Parameter.Value = SubFamilly;
            cmd.Parameters.Add(Name_Parameter);

            System.Data.SQLite.SQLiteDataReader Familly_Reader = cmd.ExecuteReader();

            if (Familly_Reader.Read())
            {
                SubFamily.Id = Familly_Reader.GetInt32(0);
                SubFamily.Family_Id = Familly_Reader.GetInt32(1);
                SubFamily.Name = Familly_Reader.GetString(2);
            }

            return SubFamily;
        }

        /// <summary>
        /// Returns the family from its id
        /// </summary>
        /// <param name="Id"></param>
        /// <returns>the family</returns>
        public Models.Family Get_Family_With_Id(int Id)
        {
            Models.Family Familly = new Models.Family();

            System.Data.SQLite.SQLiteCommand cmd = SQL_Connection.CreateCommand();
            cmd.CommandText = "SELECT * FROM Familles WHERE RefFamille = ?";

            System.Data.SQLite.SQLiteParameter Id_Parameter = new System.Data.SQLite.SQLiteParameter();
            Id_Parameter.Value = Id;
            cmd.Parameters.Add(Id_Parameter);

            System.Data.SQLite.SQLiteDataReader Familly_Reader = cmd.ExecuteReader();

            if (Familly_Reader.Read())
            {
                Familly.Id = Familly_Reader.GetInt32(0);
                Familly.Name = Familly_Reader.GetString(1);
            }

            return Familly;
        }

        /// <summary>
        /// Returns true if the given brand has any articles associated to it
        /// </summary>
        /// <param name="Id"></param>
        /// <returns>true if articles are associated</returns>
        public bool Brand_Has_Articles_Associated(int Id)
        {
            System.Data.SQLite.SQLiteCommand cmd = SQL_Connection.CreateCommand();
            cmd.CommandText = "SELECT COUNT(*) FROM Articles WHERE RefMarque = ?";

            System.Data.SQLite.SQLiteParameter Id_Parameter = new System.Data.SQLite.SQLiteParameter();
            Id_Parameter.Value = Id;
            cmd.Parameters.Add(Id_Parameter);

            System.Data.SQLite.SQLiteDataReader Reader = cmd.ExecuteReader();

            if (Reader.Read())
            {
                return int.Parse(Reader.GetString(0)) > 0;
            }
            return false;
        }

        /// <summary>
        /// Returns true if the given sub-family has any articles associated to it
        /// </summary>
        /// <param name="Id"></param>
        /// <returns>true if articles are associated</returns>
        public bool SubFamily_Has_Articles_Associated(int Id)
        {
            System.Data.SQLite.SQLiteCommand cmd = SQL_Connection.CreateCommand();
            cmd.CommandText = "SELECT COUNT(*) FROM Articles WHERE RefSousFamille = ?";

            System.Data.SQLite.SQLiteParameter Id_Parameter = new System.Data.SQLite.SQLiteParameter();
            Id_Parameter.Value = Id;
            cmd.Parameters.Add(Id_Parameter);

            System.Data.SQLite.SQLiteDataReader Reader = cmd.ExecuteReader();

            if (Reader.Read())
            {
                return int.Parse(Reader.GetString(0)) > 0;
            }
            return false;
        }

        /// <summary>
        /// Returns true if the given family has any articles associated to it
        /// </summary>
        /// <param name="Id"></param>
        /// <returns>true if articles are associated</returns>
        public bool Family_Has_Articles_Associated(int Id)
        {
            System.Data.SQLite.SQLiteCommand cmd = SQL_Connection.CreateCommand();
            cmd.CommandText = "SELECT COUNT(*) FROM Articles INNER JOIN SousFamilles ON (Articles.RefSousFamille = SousFamilles.RefSousFamille) WHERE RefFamille = ?";

            System.Data.SQLite.SQLiteParameter Id_Parameter = new System.Data.SQLite.SQLiteParameter();
            Id_Parameter.Value = Id;
            cmd.Parameters.Add(Id_Parameter);

            System.Data.SQLite.SQLiteDataReader Reader = cmd.ExecuteReader();

            if (Reader.Read())
            {
                return int.Parse(Reader.GetString(0)) > 0;
            }
            return false;
        }

        /// <summary>
        /// Updates the family
        /// </summary>
        /// <param name="Familly_ID"></param>
        /// <param name="Familly_Name"></param>
        /// <returns>true if everything went fine</returns>
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

        /// <summary>
        /// Updates the sub-family
        /// </summary>
        /// <param name="Sub_Familly_ID"></param>
        /// <param name="Familly_ID"></param>
        /// <param name="Sub_Familly_Name"></param>
        /// <returns>true if everything went fine</returns>
        public bool Update_Sub_Familly(int Sub_Familly_ID, int Familly_ID, string Sub_Familly_Name)
        {
            System.Data.SQLite.SQLiteCommand cmd = SQL_Connection.CreateCommand();
            cmd = SQL_Connection.CreateCommand();
            cmd.CommandText = "UPDATE SousFamilles SET RefFamille = ?, Nom = ? WHERE RefSousFamille = ?";

            System.Data.SQLite.SQLiteParameter Id_Family_Parameter = new System.Data.SQLite.SQLiteParameter();
            System.Data.SQLite.SQLiteParameter Name_Parameter = new System.Data.SQLite.SQLiteParameter();
            System.Data.SQLite.SQLiteParameter Id_Sub_Family_Parameter = new System.Data.SQLite.SQLiteParameter();

            Id_Family_Parameter.Value = Familly_ID;
            Name_Parameter.Value = Sub_Familly_Name;
            Id_Sub_Family_Parameter.Value = Sub_Familly_ID;

            cmd.Parameters.Add(Id_Family_Parameter);
            cmd.Parameters.Add(Name_Parameter);
            cmd.Parameters.Add(Id_Sub_Family_Parameter);

            int Nb = cmd.ExecuteNonQuery();

            return Nb == 1;
        }

        /// <summary>
        /// Updates the brand
        /// </summary>
        /// <param name="Brand_ID"></param>
        /// <param name="Brand_Name"></param>
        /// <returns>true if everything went fine</returns>
        public bool Update_Brand(int Brand_ID, string Brand_Name)
        {
            System.Data.SQLite.SQLiteCommand cmd = SQL_Connection.CreateCommand();
            cmd = SQL_Connection.CreateCommand();
            cmd.CommandText = "UPDATE Marques SET Nom = ? WHERE RefMarque = ?";

            System.Data.SQLite.SQLiteParameter Name_Parameter = new System.Data.SQLite.SQLiteParameter();
            System.Data.SQLite.SQLiteParameter Id_Parameter = new System.Data.SQLite.SQLiteParameter();

            Name_Parameter.Value = Brand_Name;
            Id_Parameter.Value = Brand_ID;

            cmd.Parameters.Add(Name_Parameter);
            cmd.Parameters.Add(Id_Parameter);

            int Nb = cmd.ExecuteNonQuery();

            return Nb == 1;
        }

        /// <summary>
        /// Updates the article
        /// </summary>
        /// <param name="Description"></param>
        /// <param name="Reference"></param>
        /// <param name="Marque"></param>
        /// <param name="SousFamille"></param>
        /// <param name="PrixHT"></param>
        /// <param name="Quantity"></param>
        /// <returns>true if everything went fine<returns>
        public bool Update_Article(string Description, string Reference, int Marque, int SousFamille, float PrixHT, int Quantity)
        {
            if(Quantity == -1)
                Quantity = Count_Articles_Id(Reference);

            if (Quantity == -1) return false;

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
            Quantity_Parameter.Value = Quantity;
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

        /// <summary>
        /// Deletes the family
        /// </summary>
        /// <param name="Familly_ID"></param>
        /// <returns>true if everything went fine</returns>
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

        /// <summary>
        /// Deletes the sub-family
        /// </summary>
        /// <param name="Sub_Familly_ID"></param>
        /// <returns>true if everything went fine</returns>
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

        /// <summary>
        /// Deletes the brand
        /// </summary>
        /// <param name="Brand_ID"></param>
        /// <returns>true if everything went fine</returns>
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

        /// <summary>
        /// Deletes the article
        /// </summary>
        /// <param name="Article_ID"></param>
        /// <returns>true if everything went fine</returns>
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
