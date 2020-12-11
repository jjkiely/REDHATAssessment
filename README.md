# REDHATAssessment
This is the github page for the TODO list application I developed as part of my red hat internship assessment.


HOW TO USE::
First download the Todo.cs and REDHAT.proj files from this page, ensure they are saved in a folder called "redHatToDoList" as this is necessary for the persistence to function correctly.
Ensure that .Net is installed on your computer before attempting to run the project.
navigate to the redHatToDoList folder using the terminal. Eg: "cd home/jjkiely/Documents/redHatToDoList"
once in the folder type "dotnet run Todo.cs" into the terminal, the program will begin running.


USING THE PROGRAM:
The program was designed to be simple to use, it will provide the user with options when it begins running, these options can be viewed at any time by pressing H.

Example use:
******
1) "dotnet run Todo.cs"
2) "A" 
3) "Get milk" 
4) "Shopping" 
5) V 
6) S 
7) todayslist 
8) Q
******
This example use case will run the program, add a new task to get milk, set the task category to shopping, then it will view the current tasks added, before saving them to a file called todayslist and finally quitting the application. I have included the "todayslist" file in the repository to further demonstrate functionality

OPENING AN EXISTING FILE:
Pressing O while the program is accepting commands will allow you to open an existing file, however it is essential that you type the name of the file correctly or else it will not work as intended.
