/*
Red Hat Internship Assessment "To DO List"
Written by Joseph Kiely
Please only run this code inside the current folder, as directory referencing will be broken if Todo.cs is moved
This program is written in c# and can be run if .Net is installed by naviagating to the Todolist folder in the terminal and typing "dotnet run Todo.cs"
*/


using System;
using System.IO;

namespace REDHAT
{
    class Todo
    {

       
        public class Task //this is the class for the task objects
        {
            
            public string listItem { get; set; }  //get and set methods for the task content itself
            public string category { get; set; }  //get and set for the category

            public Task() {listItem=""; category = ""; }
            public Task( string x, string y) { listItem = x; category = y; }//constructor

            public override string ToString()
            {
                string disp = String.Format(@"Task: ""{0}"" Category=""{1}""", listItem, category);//this string will format the data of the task object into an easily readable format
                return disp;
            }
        }
       

        
        static void Main(string[] args)//this main method is responsible for the behaviour of the program, options are printed to the terminal and depending on user input, different actions are carried out
        {
            String Commands= "Your To Do List" + Environment.NewLine;
            Console.WriteLine("Hello, please enter your command from the following list");//instructions for the use of the program
            Console.WriteLine("Press O to open an existing list");
            Console.WriteLine("Press A to add a task");
            Console.WriteLine("Press D to delete a task");
            Console.WriteLine("Press S to save your tasks to a file");
            Console.WriteLine("Press V to view the tasks you have created so far in the console");
            Console.WriteLine("Press Q to exit the program");
            Console.WriteLine("To see these options again at any time, press H");
            Boolean run=true;
            while(run==true){ // this loop will keep the program running until Q is pressed
                String command = Console.ReadLine();
                if(String.Equals(command,"O")==true)//these if statements change the action of the program depending on user input
                {
                    Console.WriteLine("Please Enter The Name of the file you wish to open, without the file extension");
                    string open= Console.ReadLine();
                    Commands=System.IO.File.ReadAllText(@"..\redHatToDoList\"+open+".txt");
                    Console.WriteLine("File Opened");
                    Console.WriteLine("Returning to Main Menu");
                    

                }
                if(String.Equals(command,"A")==true){
                    Console.WriteLine("Please Enter The Task You Would Like To Add");
                    string x=Console.ReadLine();
                    Console.WriteLine("Please Enter A Category For That Task");
                    string y = Console.ReadLine();
                    Task c1 = new Task(x,y);
                    Commands+=c1.ToString()+Environment.NewLine;
                    Console.WriteLine("Task created, returning to main menu");
                    Console.WriteLine("Please Enter Your Command");
                }
                
                if(String.Equals(command,"Q")==true)
                {
                    Console.WriteLine("Quitting");
                    run=false;
                    break;

                }
                if(String.Equals(command, "S")==true){
                    Console.WriteLine("Please Enter The Name of the file you wish to save to, without the file extension");
                    Console.WriteLine("If the File does not exist it will be created");
                    string filename= Console.ReadLine();
                    Console.WriteLine("Saving to File, returning to main menu");
                    writeToFile(Commands, filename);
                }
                if(String.Equals(command, "V")==true){
                    Console.WriteLine("Showing Tasks");
                    Console.WriteLine(Commands);
                    Console.WriteLine("Please Enter Your Command");
                }
                if(String.Equals(command, "H")==true){
                    Console.WriteLine("Press O to open an existing list");
                    Console.WriteLine("Press A to add a shape");
                    Console.WriteLine("Press S to save your tasks to a file");
                    Console.WriteLine("Press V to view the tasks you have created so far in the console");
                    Console.WriteLine("Press Q to exit the program");
                    Console.WriteLine("To see these options again at any time, press H");
                }
                
            }
            System.Environment.Exit(1);//when Q is pressed, the loop will break which will cause this exit code to trigger, exiting the program
        }

        public static void writeToFile(String contents, String filename)//this method creates a txt file and saves it
        {
            string str=contents;
            string pathc="";
            pathc += @"..\redHatToDoList\"+filename+".txt";//the path where the txt file will be stored
            if(File.Exists(pathc)){//ensures that the file is always updated whenever the code is run again with the same file
                File.Delete(pathc);
            }
            string fileString = contents;
            File.WriteAllText(pathc,fileString);
     
        }
    }
}
