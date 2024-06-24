# A loop programming exercise - MathTutor

- Write a program named MathTutor01 that allows the user to answer a random generated math addition question. 

- Limit the random numbers to a value from 1 to 99. After the user enter their answer display a message indicating if the user is correct or incorrect. 

- Your program must handle invalid inputs. Here is a sample run:

```
What is 20 + 10 = ?
Invalid input! You must enter an integer value for the answer. What is 20 + 10 = ?
abc
Invalid input! You must enter an integer value for the answer. What is 20 + 10 = ?
33.33
Invalid input! You must enter an integer value for the answer. What is 20 + 10 = ?
33
Incorrect! The correct answer is 30.
What is 1 + 99 = ?
98
Incorrect! The correct answer is 100.
```
- Write a program named MathTutor02 that is a modification of MathTutor01 that allows for multiple attempts to answer the question. 

- If the user answers the question correctly display the number of attempts to answer the question correctly. 

- Here is a sample run:

```
What is 97 + 99 = ?
I don’t know. Why don’t you tell me the answer.
Invalid input! You must enter an integer value for the answer. What is 97 + 99 = ?
98
Incorrect! Would you like to try again (y/n)?
y
What is 97 + 99 = ?
200
Incorrect! Would you like to try again (y/n)?
y
What is 97 + 99 = ?
198
Incorrect! Would you like to try again (y/n)?
y
What is 97 + 99 = ?
196
Correct! You got the correct answer in 4 attempts.
What is 7 + 19 = ?
19
Incorrect! Would you like to try again (y/n)?
y
What is 7 + 19 = ?
7
Incorrect! Would you like to try again (y/n)?
n
The correct answer is 26.
```

- Write a program named MathTutor03 that is a modification of MathTutor02 that allows the user to answer multiple addition questions. 

- Here is a sample run:

```
Question #1: What is 3 + 9 = ?
12
Correct!
Would you like another question (y/n)
y
Question #2: What is 2 + 8 = ?
10
Correct!
Would you like another question (y/n)?
y
Question #3: What is 11 + 43 = ?
44
Incorrect! Would you like try again (y/n)?
n
The correct answer is 54.
Would like another question (y/n)?
y
Question #4: What is 1 + 2 = ?
3
Correct!
Would you like another question (y/n)?
n
Thanks for playing! You answered 3 out of 4 questions correctly.
```

- Write a program named MathTutor04 that is a modification of MathTutor03 that allows the user to select the type of math question (addition, subtraction, multiplication, or division). 

- Here is a sample run:

```
Math Tutor – Version 0.4 
------------------------ 
a) Addition
s) Subtraction
m) Multiplication
d) Division
x) Exit Program
Enter a letter for your choice:
a
What is 61 + 6 = ?
67
Correct!

Math Tutor – Version 0.4 
------------------------ 
a) Addition
s) Subtraction
m) Multiplication
d) Division
x) Exit Program
Enter a letter for your choice:
s
What is 47 - 33 = ?
60
Incorrect! Would you like to try again (y/n)?
y
What is 47 - 33 = ?
14
Correct!

Math Tutor – Version 0.4 
------------------------ 
a) Addition
s) Subtraction
m) Multiplication
d) Division
x) Exit Program
Enter a letter for your choice:
m
What is 3 * 4 = ?
12
Correct!

Math Tutor – Version 0.4 
------------------------ 
a) Addition
s) Subtraction
m) Multiplication
d) Division
x) Exit Program
Enter a letter for your choice:
d
What is 7 / 2 = ?
3.5
Correct!

Math Tutor – Version 0.4 
------------------------ 
a) Addition
s) Subtraction
m) Multiplication
d) Division
x) Exit Program
Enter a letter for your choice:
x
Goodbye and thanks for playing!
```