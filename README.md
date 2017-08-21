# Triangle-Challenge
Hi this is a challenge to build a solution that will help us for finding the type of a Triangle by using three side’s lengths as inputs, the program should return us one of the three “Scalene, Isosceles, Equilateral” types of Triangle as results.
### It’s Simple!!!
In this solution I tried to build a program with good solving technic and structural considerations that could be applied to larger and potentially more complex problems.
## Application Steps:
### First Step, Analyzing inputs:
The tree inputs that will be used, to determine a Triangle must have 3 important logical conditions:
I)	All of them must be digits:
I used the “Validating” event property of the input Textboxes to control this condition.
II)	All Lengths must be greater than Zero.
III)	Each side must be lower than sum of the others. It means that in a Triangle with three sides ( a , b , c ), three ( a < b+c , b < a+c , c < a+b ) conditions must be valid.
If you take a little consideration it can be clearly found that, in order to control last two items (II, III), we can use this small statement:
Max ( a , b , c ) < [ Sum ( a , b , c ) – Max ( a , b , c ) ]
If this comparison returns true, it means that ( a < b+c , b < a+c , c < a+b & a > 0 , b > 0 , c > 0). In this code the “triangleControl” method controls items I and II.
### Second Step, Finding the Triangle Type:
In this step we have good filtered inputs and it’s time to find the Triangle type. I used the enumerable list (enum) to create a relation between each type of Triangle and 1, 2 and 3 numbers in a separated part that could be useful for next step of development in the future. Then I used “Distinct” method of “System.linq” Name Space for finding the number of input repetitious.
### Third Step, Final Step:
Showing the results of operation. 
## Built With
I used Microsoft C#.Net for building the solution and in order to add Testing section into my project I used Microsoft Unit Testing Framework.
## Authors
* **Mohammad Hadaeghi** 
