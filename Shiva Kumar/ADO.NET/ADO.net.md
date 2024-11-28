ADO.NET:
==============
ADO.NET (ActiveX Data Objects for .NET) is a data access technology provided by the .NET Framework. It enables applications to interact with data sources such as databases

Components of ADO.NET
Data Providers: 
=============
ADO.NET uses data providers to connect to a specific data source. 

Each provider includes the following classes:

    Connection: Manages the connection to the database.
    Command: Executes SQL commands or stored procedures.
    DataReader: Provides a forward-only, read-only access to query results.
    DataAdapter: Bridges the database and the DataSet for disconnected operations.

Common data providers:
========================
    SQL Server (System.Data.SqlClient): For Microsoft SQL Server databases.
    OLE DB (System.Data.OleDb): For accessing legacy databases.
    ODBC (System.Data.Odbc): For ODBC-compliant databases.
    Oracle (System.Data.OracleClient): For Oracle databases.
Disconnected Architecture:
============================

DataSet: Represents an in-memory cache of data retrieved from the database.
DataTable: Represents a single table of in-memory data.
DataRelation: Defines relationships between tables in a DataSet.



Connection Strings Overview:
==============================
A connection string is a string that specifies information about a data source and the means of connecting to it. It typically includes the server name, database name, user credentials, and other parameters necessary for establishing a connection.

General Structure
"Provider=ProviderName;Data Source=DataSource;Initial Catalog=DatabaseName;User ID=UserID;Password=Password;"

1. Connecting to Text Files (CSV/TXT)
Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Path\To\Your\Folder;Extended Properties="text;HDR=Yes;FMT=Delimited(,)";Persist Security Info=False;
Data Source: The folder containing the CSV file.
Extended Properties: Specifies that the file is text and includes headers.

2. Connecting to Text Files XML Files
Provider=MSXML2.DOMDocument.6.0;Data Source=C:\Path\To\Your\File.xml;


3. Connecting to Excel Files
Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Path\To\Your\File.xls;Extended Properties="Excel 8.0;HDR=Yes;IMEX=1";
HDR: Indicates if the first row contains headers.
IMEX: Ensures mixed data types are read as text.

4. Connecting to RDBMS(SQL Server, Oracle, PostgreSQL, My SQL...etc)

4.1 SQL Server
Server=myServerAddress;Database=myDataBase;User Id=myUsername;Password=myPassword;(Sql server authentication)

Server=myServerAddress;Database=myDataBase;Integrated Security=True; (Windows authentication)

4.2 MySQL
Server=myServerAddress;Database=myDataBase;Uid=myUsername;Pwd=myPassword;

4.3 PostgreSQL
Host=myServerAddress;Database=myDataBase;Username=myUsername;Password=myPassword;

4.4 MS Access
Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Path\To\Your\Database.accdb;


Data Source 	Connection String Example
-----------------------------------------------------
CSV	            Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Path\To\Your\Folder;Extended Properties="text;HDR=Yes;"
XML	            Provider=MSXML2.DOMDocument.6.0;Data Source=C:\Path\To\Your\File.xml;
Excel	        Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Path\To\Your\File.xls;Extended Properties="Excel 8.0;"
SQL Server	    Server=myServerAddress;Database=myDataBase;User Id=myUsername;Password=myPassword;
MySQL	        Server=myServerAddress;Database=myDataBase;Uid=myUsername;Pwd=myPassword;
PostgreSQL	    Host=myServerAddress;Database=myDataBase;Username=myUsername;Password=myPassword;
MS Access	    Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Path\To\Your\Database.accdb;


Command:
===========
=> The Command object in ADO.NET is a fundamental component used to execute SQL queries and stored procedures against a database.
Execution of SQL Statements: 
    You can execute SQL commands directly using the Command object.
Stored Procedures: 
    It supports executing stored procedures with parameters.
Parameterization: 
    Helps prevent SQL injection attacks by using parameterized queries.

Properties of the Command Object
========================================

Property	    Description
--------------------------------
CommandText	    The SQL query or stored procedure name to execute.
CommandType	    Specifies how the CommandText is interpreted (e.g., Text, StoredProcedure).
Connection	    The database connection associated with the Command object.
Parameters	    A collection of parameters for the command (used for parameterized queries input or output ).
CommandTimeout	The time in seconds before a command is considered to have timed out.
Transaction	    The transaction that this command is part of, if any.

Methods of the Command Object
====================================
Method	            Description
---------------------------------------------
ExecuteReader()	    Executes the command and returns a DataReader for reading data.
ExecuteNonQuery()	Executes commands that do not return any data (e.g., INSERT, UPDATE).
ExecuteScalar()	    Executes a query and returns the first column of the first row in the result set.
CreateParameter()	Creates a new parameter for use in parameterized queries.

Data DataReader
==============
The DataReader in ADO.NET is a crucial component for efficiently retrieving data from a database in a forward-only, read-only manner. 
It is designed for high performance and is particularly useful when working with large amounts of data.

=> It retrieves the data in sequential manner
=> provides a fast way to access data without storing it in memory.
=> Forward-Only and Read-Only: 
    Data can only be read in one direction (forward), and once read, it cannot be modified.
=> Efficient Memory Usage: 
    Only one row of data is stored in memory at any time, which reduces resource consumption.
=> Unbuffered Stream: 
    Data is retrieved directly from the database without caching, making it suitable for large datasets.

Imp Methods:
Read()	    => Move to the next record in the DataReader.
            => it returns bool. return true if next record exists else false
    while (reader.Read())
    {
        // Process first result set
    }
NextResult() => Move to the next result set (if multiple present in the result of the query execution).
    //Resultset 1 read
    while (reader.Read())
    {
        // Process first result set
    }
    //Resultset 2 read if present
    // Move to next result set
    if (reader.NextResult())
    {
        while (reader.Read())
        {
            // Process second result set
        }

        //Resultset 3 read if present
        // Move to next result set
        if (reader.NextResult())
        {
            while (reader.Read())
            {
                // Process second result set
            }
        }
    }

 If you want to work with connected oriented way no need to use data adapter 
 if you want to work with disconnected architechture then no need of data reader and command.
 
DataAdapter:
==================
=> It is an alternate approach to DataReader
=> The DataAdapter acts as a bridge between the database and the in-memory representation of data
=> It is responsible for retrieving data from a data source and populating it into a DataSet or DataTable, as well as sending changes made to the DataSet back to the database.

Key Features of DataAdapter:
==============
Filling Data: 
    The Fill method of the DataAdapter retrieves data from the database using a SQL command and populates it into a DataSet or DataTable.
Updating Data: 
    The Update method allows changes made in the DataSet to be sent back to the database.
Command Management: 
    The DataAdapter uses Command objects (like SelectCommand, InsertCommand, UpdateCommand, and DeleteCommand) to define how data is retrieved and manipulated.

Example Program to load students table data from database:
==============================================================
        string connectionString = "Data Source=.;Initial Catalog=YourDatabase;Integrated Security=True";
        SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM Students", connectionString);
        
        DataSet dataSet = new DataSet();
        adapter.Fill(dataSet, "Students"); // Fill the DataSet with data from the Students table

        // Displaying data
        foreach (DataRow row in dataSet.Tables["Students"].Rows)
        {
            Console.WriteLine($"{row["Name"]}, {row["Age"]}");
        }


DataSet:
=============
=> The DataSet is an in-memory representation of data that can hold multiple tables and relationships between them. 
=> It is designed to work in a disconnected manner
=> It is like a in-memory database with multiple tables in it.

Key Features:
--------------
Multiple Tables: 
    A DataSet can contain multiple DataTables, allowing for complex data structures.
Relationships: 
    You can define relationships between tables within the DataSet using DataRelation objects.
Schema Information: 
    The DataSet retains schema information (like column types, constraints) along with the actual data.

    DataSet dataSet = new DataSet();
    //You can add multiple tables to a dataset object
    dataSet.Tables.Add(dataTable1);
    dataSet.Tables.Add(dataTable2);

DataTable:
============
=>A DataTable represents a single table of in-memory data. It consists of rows and columns and provides methods for manipulating this data.

Key Features:
----------------------
Rows and Columns: 
    A DataTable contains collections of rows (DataRowCollection) and columns (DataColumnCollection).
Data Manipulation: 
    It provides methods to add, delete, or modify rows.
Constraints: 
    You can define constraints on columns (like primary keys or unique constraints).

    DataTable studentsTable = new DataTable("Students");
    studentsTable.Columns.Add("Name", typeof(string));
    studentsTable.Columns.Add("Age", typeof(int));

    // Adding rows
    studentsTable.Rows.Add("Alice", 20);
    studentsTable.Rows.Add("Bob", 22);

    // Displaying rows
    foreach (DataRow row in studentsTable.Rows)
    {
        Console.WriteLine($"{row["Name"]}, {row["Age"]}");
    }


