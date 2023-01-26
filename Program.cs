using System;
using System.Collections;
using System.Collections.Generic;

namespace Data_Structures_Task_One {
    
    internal class program {

        public static void Main(string[] args) {
            string input = "[()]{}{[()()]()}";
            Stack<char> charStack = new Stack<char>();
            
            foreach (char c in input) {
                if (c == '[' || c == '('|| c == '{') {
                    charStack.Push(c);
                } else {

                    if(charStack.Count == 0){                        // Safe fail incase input is unbalanced
                        Console.WriteLine("input is unbalanced");
                        return;
                    }

                    bool check = false;
                    char sc = charStack.Pop();
                    // sc = '(' c = '}'
                    if (sc == '(' && c == ')') {                // check if brackets match
                        check = true;  
                    } else if (sc == '{' && c == '}') {         // check if curly brackets match
                        check = true;
                    } else if (sc == '[' && c == ']') {         // check if whatrver this is [] is matched
                        check = true;
                    } else {
                        check = false;
                    }

                    if(!check) {                                      // If check remains false the imput is "Wrong" aka not balanced      
                        Console.WriteLine("Input is not balanced");
                        return;
                    }

                }
            }

            if(charStack.Count() == 0) {                        // If no elements remain the stack is balanced
                Console.WriteLine("Input is balanced");
            } else {                                            // If any elements remain the stack is unbalanced
                Console.WriteLine("Input is not balanced");
            }
        }
    }
}