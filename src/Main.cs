using System;
using System.Collections.Generic;

class Program {
    static void Main() {
        while (true) {
            bool input_valid;
            string user_input;

            string mode = "number"; // it's either "number" or "operator"

            bool calculating = true;

            List<decimal> numbers = new List<decimal>();
            List<string> operators = new List<string>();

            while (calculating) {
                switch (mode) {
                    case "number":
                        decimal number;
                        input_valid = false;
                        while (!input_valid) {
                            Console.Write("Enter an integer");
                            user_input = Console.ReadLine();
                            input_valid = true;
                            try {
                                number = decimal.Parse(user_input);
                                numbers.Add(number);
                            }
                            catch {
                                input_valid = false;
                            }
                        }
                        mode = "operator";
                        break;
                    case "operator":
                        input_valid = false;
                        while (!input_valid) {
                            Console.Write("Enter an operator");
                            user_input = Console.ReadLine();
                            if (user_input == "+") {
                                // Addition
                                operators.Add("+");
                                input_valid = true;
                            }
                            else if (user_input == "-") {
                                // Subtraction
                                operators.Add("-");
                                input_valid = true;
                            }
                            else if (user_input == "*") {
                                // Multiplacation
                                operators.Add("*");
                                input_valid = true;
                            }
                            else if (user_input == "/") {
                                // Division
                                operators.Add("/");
                                input_valid = true;
                            }
                            else if (user_input == "=") {
                                // Operation
                                input_valid = true;
                                calculating = false;
                            }
                        }
                        mode = "number";
                        break;
                }
                // end of calculation loop
            }
            // Then, calculate the program according to a lot of factors
            decimal answer = numbers[0];
            for (int i = 0; i < operators.Count; i++) {
                switch (operators[i]) {
                    case "+":
                        answer = answer + numbers[i+1];
                        break;
                    case "-":
                        answer = answer - numbers[i+1];
                        break;
                    case "*":
                        answer = answer * numbers[i+1];
                        break;
                    case "/":
                        answer = answer / numbers[i+1];
                        break;
                }
            }
            Console.Write("The answer is ");
            Console.WriteLine(answer);
        }
    }
}
