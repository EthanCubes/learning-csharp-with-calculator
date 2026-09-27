using System;

class Program {
    static void Main() {
        while (true) {
            bool input_valid;
            string user_input;

            string mode = "number"; // it's either "number" or "operator"

            bool calculating = true;

            while (calculating) {
                switch (mode) {
                    case "number":
                        input_valid = false;
                        while (!input_valid) {
                            Console.Write("Enter an integer");
                            user_input = Console.ReadLine();
                            int number;
                            input_valid = true;
                                try {
                            number = int.Parse(user_input);
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
                                input_valid = true;
                            }
                            else if (user_input == "-") {
                                // Subtraction
                                input_valid = true;
                            }
                            else if (user_input == "*") {
                                // Multiplacation
                                input_valid = true;
                            }
                            else if (user_input == "/") {
                                // Division
                                input_valid = true;
                            }
                            else if (user_input == "=") {
                                // Operation
                                input_valid = true;
                            }
                        }
                        mode = "number";
                        break;
                }
                // end of calculation loop
            }
            // end of program loop
        }
    }
}
