DataTable dt= new DataTable("dt");
dt.Columns.Add("ID", typeof(int));
dt.Columns.Add("FirstName", typeof(string));
dt.Columns.Add("LastName", typeof(string));
dt.Columns.Add("Age", typeof(byte));

dt.Rows.Add(1,"Sama","Isam","26");
dt.Rows.Add(2, "Hamed", "Abusamaha", "25");
dt.Rows.Add(3, "Laith", "Rafat", "15");
dt.Rows.Add(3, "Tamara", "Tarawneh", "30");
dt.Rows.Add(3, "Ramzi", "Moqbel", "43");

Console.WriteLine("ID    First Name         Last Name       Age");
          
foreach (DataRow row in dt.Rows)
{
    Console.Write(row["ID"].ToString().PadRight(10));
    Console.Write(row["FirstName"].ToString().PadRight(15));
    Console.Write(row["LastName"].ToString().PadRight(17));
    Console.WriteLine(row["Age"].ToString().PadRight(15));
}
