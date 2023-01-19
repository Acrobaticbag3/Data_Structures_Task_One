using System;
using System.Collections;
using System.Collections.Generic;

namespace Data_Structures_Task_One {
    
    internal class program {

        public static void Main(string[] args) {
            string input = "[()]{}{[()()]()}";
            Stack<char> stack = new Stack<char>();

            foreach (char c in input) {
                if (input == "[" || input == "(" || input == "{") {
                    stack.Push(c);   
                } else {
                    
                    if(stack.Count == 0){
                        Console.WriteLine("Input is unbalanced");
                        return;
                    }
                    char popedChar = stack.Pop();
                }

                bool check = false;
                if (c == ')') {
                    check = true;  
                } else if (c == '}') {
                    check = true;
                } else if (c == ']') {
                    check = true;
                } else {
                    check = false;
                }

                if(stack.Count == 0) {
                    Console.WriteLine("Input is balanced");
                } else {
                    Console.WriteLine("Input is not balanced");
                }
            }
        }
    }
}