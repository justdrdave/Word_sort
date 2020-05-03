# Word sort

## Setup and Run
1. This is a .netcore 3.0 app so will run on Mac and Linux as well as Windows (project was written on a Mac), but requires the correct runtime installed https://dotnet.microsoft.com/download/dotnet-core/3.0
2. To run the console app in the terminal of your choice '''dotnet run'''
3. To run the unit tests in the terminal of your choice '''dotnet test'''

## Assumptions
1. The application only works with unicode and splits words based on a space
2. All other characters will be treated as part of a word
3. A double space will provide an empty string ("") as the shortest word with length 0
4. If multiple words meet the criteria for longest/shortest then the first will be returned