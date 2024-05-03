// See https://aka.ms/new-console-template for more information
using System.Login.Session;
using System.Login.DAL;

Console.WriteLine("Hello, World!");

//var result = UserService.ComposeSHA256("adminadmin");

// d82494f05d6917ba02f7aaa29689ccb444bb73f20380876cb05d1f37537b7892

//Console.WriteLine(result);

var result = Connection.Connect();

Console.WriteLine(result.ToString());
