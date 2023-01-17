using System;
using System.Collections;
using System.Collections.Generic;

namespace Data_Structures_Task_One {
    
    internal class program {

        public static void Main(string[] args) {
            string exp = "[()]{}{[()()]()}";
        }

        public class BalancedBrackets {
            public class Stack {
                public int top = -1;                    // Used to set the new top of our stack
                public char[] items = new char[100];    // Used to track stack max 
                
                public void Push(char x) {              // Adds char if there is space

                    if (top == 99) {
                        Console.WriteLine("Stack full");    
                    } else {
                        items[++top] = x;       // Increase by one and set x to value
                    }
                }

                char Pop() {

                    if (top == -1) {
                        Console.WriteLine("Underflow error");
                        return '\0';
                    } else {
                        char element = items[top];
                        top--;
                        return element;
                    }
                }

                Boolean isEmpty() {
                    return (top == -1) ? true : false;
                }

                //  Returns true if character1 and character2 are matching left and right brackets
                static Boolean isMatchingPair(char character1, char character2) {   
                    if (character1 == '(' && character2 == ')')
                        return true;
                    else if (character1 == '{' && character2 == '}')
                        return true;
                    else if (character1 == '[' && character2 == ']')
                        return true;
                    else 
                        return false;
                }
            }
        }
    }
}