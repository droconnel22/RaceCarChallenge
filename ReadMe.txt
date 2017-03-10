
Create a race care setup selector. The purpose of the program is to rank a given set of car configurations for a particular, given, race track, based on the full race completion time.
-          The 2 main entities are: Race Track and Car Configuration
-          The race track has the following properties:
o   Lap distance
o   Number of laps to complete
o   Time it takes to make a pitstop
-          “Known” properties of each car configuration, for a particular race track are:
o   Fuel capacity
o   Time to complete a lap
o   Average fuel consumption per lap
-          Assumptions:
o   Car if fuelled to its configuration at the start of the race
o   Car is fuelled up to the same level each pitstop
o   Pitstop times are static
o   Lap times are consistent
-          The program should be able to accept an arbitrary number of car configurations
 
Read the following requirements carefully:
-          The solution should consist of a single class library, written in C#
-          Do not produce a User Interface of any kind, however, the solution may include a test class library/module
-          The solution should demonstrate best practises
-          The main class library may only use features of the language. Do not use any .NET or 3rd party libraries, i.e. your project should have no external references. However your test module may do so and may use NuGet to manage any 3rd party libraries if the licence allows it.
-          Send a ZIP file with your solution, but make sure to remove all binaries
-          There is no time limit. Do not deliver a complicated solution. This should illustrate your strength as a capable but a pragmatic engineer.
