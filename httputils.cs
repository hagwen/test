"taskID": "aAaa23"
Response startRespons = await httpUtils.Get(baseURL + startEndpoint + dd7d5c72da660ddbc93569150177b5e9eba44d19733be8282b77802d5b53020a);
Console.WriteLine($"Start:\n{Colors.Magenta}{startRespons}{ANSICodes.Reset}\n\n"); // Print the response from the server to the console
string aAaa23 = ""; // We get the taskID from the previous response and use it to get the task (look at the console output to find the taskID)
