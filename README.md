Way1:
dotnet new console -o MyApp

cd MyApp/

cp file.cs MyApp/Program.cs
     (or)
nano Program.cs

ctl+o, Enter, ctl+x

dotnet run

Way2:
 sudo apt install mono-complete

 mcs <file_name.cs>

 mono <file_name.exe>
